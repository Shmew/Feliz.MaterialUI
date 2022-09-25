module DocTypeSignatureParser

open System
open FParsec
open Feliz.Generator
open Domain

module Parsers =

    type Parser<'t> = Parser<'t, unit>

    let tsIdentifier<'State> : Parser<string, 'State> = identifier (IdentifierOptions())

    let stringLiteralIdentifier<'State> : Parser<string, 'State> =
        let opts = IdentifierOptions(
            isAsciiIdContinue = (fun c -> isAsciiLetter c || isDigit c || c = '_' || c = '-')
        )
        identifier (opts)

    let ws = unicodeSpaces

    let tsStringLiteral (stringLiteralParser: Parser<string, 'State>) =
        let tsStringSingleQuote = pchar '''
        let tsSTringDoubleQuote = pchar '"'
        choice [
            pstring "''"
            pstring "\"\""
            between tsStringSingleQuote tsStringSingleQuote stringLiteralParser
            between tsSTringDoubleQuote tsSTringDoubleQuote stringLiteralParser
        ]

    let intLiteral = pint32

    let boolLiteral<'State> : Parser<bool, 'State> =
        choice [
            pstring "false" |>> bool.Parse
            pstring "true" |>> bool.Parse
        ]

    let tsLiteralType: Parser<TsLiteralType> =
        choice [
            tsStringLiteral stringLiteralIdentifier |>> StringLiteral
            intLiteral |>> IntLiteral
            boolLiteral |>> BoolLiteral
        ]

    let tsAtomicType: Parser<TsType> =
        choice [
            stringReturn "string" String
            stringReturn "number" Number
            stringReturn "integer" Integer
            stringReturn "bool" Bool
            stringReturn "Date" Date
            stringReturn "func" Func
            stringReturn "object" TsAtomicType.Object
            stringReturn "elementType" ElementType
            stringReturn "element type" ElementType
            stringReturn "element" Element
            stringReturn "HTML element" HTMLElement
            stringReturn "node" Node
            stringReturn "any" Any
            tsLiteralType |>> Literal
            tsIdentifier |>> OtherType
        ] |>> TsType.Atomic

    let tsType, tsTypeRef = createParserForwardedToRef<TsType, unit>()

    let tsObject: Parser<TsType> =
    
        let objectEntry =
            let objField =
                tsIdentifier .>>. (opt (pchar '?'))
                |>> (fun (fieldName, isOptionalMarker) -> fieldName, isOptionalMarker.IsSome)
        
            tuple2
                objField
                (ws >>. pchar ':' .>> ws >>. tsType)
            |>> (fun ((fieldName, isOptional), fieldType) -> fieldName, fieldType, isOptional)
    
        let objectEntries = sepEndBy1 objectEntry (pchar ',' .>> ws)
    
        between (pchar '{') (pchar '}') (ws >>. objectEntries .>> ws)
        |>> TsType.Object

    let tsArray =
        pstring "Array" >>. (between (pchar '<') (pchar '>') (ws >>. tsType .>> ws))
        |>> TsType.Array

    let tsNonUnionType =
        choice [ tsObject; tsArray; tsAtomicType]

    let tsPlainUnionCases (pElement: Parser<'t, _>) =
        ws >>. (sepBy1 (pElement .>> ws) (pchar '|' .>> ws))

    let tsUnion: Parser<TsType> =
        tsPlainUnionCases tsNonUnionType
        |>> (function
                | [t] -> t
                | ts -> Union ts)

    do tsTypeRef.Value <-
            choice [
                tsUnion
                tsObject
                tsArray
                tsAtomicType
            ]

    let tsTypeSignature =
        ws >>. tsType .>> ws .>> eof


module Translators =

    type FsTypeSignature = string

    type Translators = {
        InnerAtomic: TsAtomicType -> FsTypeSignature
        InnerObject: (string * TsType * bool) list -> FsTypeSignature
        InnerUnion: TsType list -> FsTypeSignature
        InnerArray: TsType -> FsTypeSignature
        TopLevelAtomic: TsAtomicType -> PropOverload list
        TopLevelObject: (string * TsType * bool) list -> PropOverload list
        TopLevelUnion: TsType list -> PropOverload list
        TopLevelArray: TsType -> PropOverload list
    }

    let enumPropOverloadOfLiteral (tsLiteral: TsLiteralType) =
        match tsLiteral with
        | StringLiteral s ->
            EnumPropOverload.create (jsParamNameToFsParamName s) ("\"" + s + "\"")

        | IntLiteral i ->
            EnumPropOverload.create (i |> string |> jsParamNameToFsParamName) (string i)

        | BoolLiteral b ->
            let propName, propValue =
                match b with
                | true -> "true'", "true"
                | false -> "false'", "false"

            EnumPropOverload.create propName propValue

    let translateInnerTsAtomicType (tsAtomicType: TsAtomicType) =
        match tsAtomicType with
        | Any -> "'T"
        | String -> "string"
        | Number -> "float"
        | Integer -> "int"
        | Bool -> "bool"
        | Date -> "System.DateTime"
        | Func -> "Func<obj, obj>"
        | TsAtomicType.Object -> "obj"
        | Element -> "ReactElement"
        | ElementType -> "ReactElementType"
        | HTMLElement -> "U2<#Element option, IRefValue<#Element option>>"
        | Literal (StringLiteral s) -> "string" //"\"" + s + "\""
        | Literal (IntLiteral i) -> "int" // "\"" + string i + "\""
        | Literal (BoolLiteral b) -> "bool"
        | OtherType typeName -> typeName
        | Node -> "U6<ReactElement, seq<ReactElement>, string, seq<string>, int, float>"

    let rec translateNestedTsTypeSign customize (tsType: TsType) =
        let translators = translators customize
        match tsType with
        | Atomic t -> translators.InnerAtomic t
        | Array elType -> translators.InnerArray elType
        | Union cases -> translators.InnerUnion cases
        | TsType.Object objEntries -> translators.InnerObject objEntries

    and translateNestedArrayTypeSign customize (elementType: TsType) =
        translateNestedTsTypeSign customize elementType + " []"

    and translateNestedUnionTypeSign customize (unionCases: TsType list) =
        let translatedUnionCases =
            unionCases
            //|> List.map (function
            //    | TsType.Atomic (TsAtomicType.Literal (StringLiteral _)) -> "string"
            //    | t -> t |> translateNestedTsTypeSign customize)
            |> List.map (translateNestedTsTypeSign customize)
            |> List.distinct
        let unionArity = translatedUnionCases.Length

        match translatedUnionCases with
        | [] ->
            invalidArg (nameof unionArity) ("Union cannot be empty")

        | [t] -> t

        | _ when unionArity > 9 ->
            invalidArg (nameof unionArity) ("Unions with more than 9 cases are not supported")

        | cases ->
            let unionTypeParamsList = cases |> String.concat ", "
            sprintf "U%i<%s>" unionArity unionTypeParamsList

    and translateNestedObjectTypeSign customize (objEntries: (string * TsType * bool) list) =
        let entries =
            objEntries
            |> List.map (fun (fieldName, fieldType, isOptional) ->
                let fsFieldName = jsParamNameToFsParamName fieldName
                let fsTypeSign =
                    let rawTypeSign = translateNestedTsTypeSign customize fieldType
                    if isOptional then rawTypeSign + " option"
                    else rawTypeSign
                fsFieldName + ": " + fsTypeSign)
            |> String.concat "; "
        "{| " + entries + " |}"

    and translateTopLevelTsType (customize: Translators -> Translators) (tsType: TsType) =
        let translators = translators customize
        match tsType with
        | Atomic t -> translators.TopLevelAtomic t
        | Union cases -> translators.TopLevelUnion cases
        | Object objEntries -> translators.TopLevelObject objEntries
        | Array elType -> translators.TopLevelArray elType

    and translateTopLevelTsAtomicType customize (tsAtomicType: TsAtomicType) =
        match tsAtomicType with
        | Node ->
            [ RegularPropOverload.create "(value: ReactElement)" "value"
              RegularPropOverload.create "(values: seq<ReactElement>)" "values"
              RegularPropOverload.create "(value: string)" "value"
              RegularPropOverload.create "(values: string seq)" "values"
              RegularPropOverload.create "(value: int)" "value"
              RegularPropOverload.create "(value: float)" "value" ]
            |> List.map PropOverload.Regular

        | HTMLElement ->
            [ RegularPropOverload.create "(value: #Element option)" "value"
              RegularPropOverload.create "(getElement: unit -> #Element option)" "getElement"
              RegularPropOverload.create "(ref: IRefValue<#Element option>)" "(fun () -> ref.current)" ]
            |> List.map PropOverload.Regular

        | Literal literal ->
            enumPropOverloadOfLiteral literal
            |> PropOverload.Enum
            |> List.singleton

        | t ->
            let translators = translators customize
            let typeSign = translators.InnerAtomic t
            RegularPropOverload.create ("(value: " + typeSign + ")") "value"
            |> PropOverload.Regular
            |> List.singleton

    and translateTopLevelObject customize (objEntries: (string * TsType * bool) list) =
        let translatedParams =
            objEntries
            |> List.map (fun (fieldName, fieldType, isOptional) ->
                fieldName, translateNestedTsTypeSign customize fieldType, isOptional)

        let paramsListStr =
            translatedParams
            |> List.map (fun (fieldName, fieldType, isOptional) ->
                if isOptional then "?" else ""
                + jsParamNameToFsParamName fieldName
                + ": "
                + fieldType)
            |> String.concat ", "

        let objCreationCode =
            translatedParams |> jsObjectFromParamsCode jsParamNameToFsParamName

        RegularPropOverload.create
            ("(" + paramsListStr + ")")
            objCreationCode
        |> PropOverload.Regular
        |> List.singleton

    and translateTopLevelUnion customize (unionCases: TsType list) =
        unionCases
        |> List.collect (function
            | TsType.Atomic (Literal literal) ->
                enumPropOverloadOfLiteral literal
                |> PropOverload.Enum
                |> List.singleton

            | t -> translateTopLevelTsType customize t)
        |> List.distinctBy (function
            | PropOverload.Regular p -> Choice1Of2 p.ParamsCode
            | PropOverload.Enum p -> Choice2Of2 (p.MethodName, p.ParamsCode))

    and translateTopLevelArray customize (elementType: TsType) =
        let translatedTypeSign = translateNestedTsTypeSign customize elementType
        let methodParamsCode =
            sprintf "([<ParamArray>] values: %s [])" translatedTypeSign
        let methodBodyCode = "values"

        RegularPropOverload.create methodParamsCode methodBodyCode
        |> PropOverload.Regular
        |> List.singleton

    and translators (customize: Translators -> Translators): Translators =
        {
            InnerAtomic = translateInnerTsAtomicType
            InnerObject = translateNestedObjectTypeSign customize
            InnerUnion = translateNestedUnionTypeSign customize
            InnerArray = translateNestedArrayTypeSign customize
            TopLevelAtomic = translateTopLevelTsAtomicType customize
            TopLevelObject = translateTopLevelObject customize
            TopLevelUnion = translateTopLevelUnion customize
            TopLevelArray = translateTopLevelArray customize
        } |> customize

    type Translators with
        static member Default = translators id

type Translators = Translators.Translators

let tryParseTypeSignatureString (str: string) =
    str
    |> run Parsers.tsTypeSignature
    |> function
        | Success(t, _, _) -> Result.Ok t
        | Failure(errorMsg, _, _) -> Result.Error errorMsg

let translateDefault (typeSignature: TsType) =
    typeSignature
    |> Translators.translateTopLevelTsType id

let translateCustom (customizeTranslators: Translators -> Translators) typeSignature =
    typeSignature
    |> Translators.translateTopLevelTsType customizeTranslators

let parseAndTranslateDefault (typeSignatureString: string) =
    typeSignatureString
    |> tryParseTypeSignatureString
    |> Result.map translateDefault

let parseAndTranslateCustom (customizeTranslators: Translators -> Translators) (typeSignatureString: string) =
    typeSignatureString
    |> tryParseTypeSignatureString
    |> Result.map (translateCustom customizeTranslators)
