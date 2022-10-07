module DocTypeSignatureParser

open System
open FParsec
open Feliz.Generator
open Domain

module Parsers =

    type Parser<'t> = Parser<'t, unit>

    let jsIdentifier<'State> : Parser<string, 'State> = identifier (IdentifierOptions())

    let stringLiteralIdentifier<'State> : Parser<string, 'State> =
        let opts = IdentifierOptions(
            isAsciiIdContinue = (fun c -> isAsciiLetter c || isDigit c || c = '_' || c = '-')
        )
        identifier (opts)

    let ws = unicodeSpaces

    let jsStringLiteral (stringLiteralParser: Parser<string, 'State>) =
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

    let literalPropType: Parser<LiteralPropType> =
        choice [
            jsStringLiteral stringLiteralIdentifier |>> StringLiteral
            intLiteral |>> IntLiteral
            boolLiteral |>> BoolLiteral
        ]

    let atomicPropType: Parser<PropType> =
        choice [
            stringReturn "string" String
            stringReturn "number" Number
            stringReturn "integer" Integer
            stringReturn "bool" Bool
            stringReturn "Date" Date
            stringReturn "func" Func
            stringReturn "object" AtomicPropType.Object
            stringReturn "elementType" ElementType
            stringReturn "element type" ElementType
            stringReturn "element" Element
            stringReturn "HTML element" HTMLElement
            stringReturn "node" Node
            stringReturn "any" Any
            literalPropType |>> Literal
            jsIdentifier |>> OtherType
        ] |>> PropType.Atomic

    let propType, propTypeRef = createParserForwardedToRef<PropType, unit>()

    let propTypeObject: Parser<PropType> =
    
        let objectEntry =
            let objField =
                jsIdentifier .>>. (opt (pchar '?'))
                |>> (fun (fieldName, isOptionalMarker) -> fieldName, isOptionalMarker.IsSome)
        
            tuple2
                objField
                (ws >>. pchar ':' .>> ws >>. propType)
            |>> (fun ((fieldName, isOptional), fieldType) -> fieldName, fieldType, isOptional)
    
        let objectEntries = sepEndBy1 objectEntry (pchar ',' .>> ws)
    
        between (pchar '{') (pchar '}') (ws >>. objectEntries .>> ws)
        |>> PropType.Object

    let propTypeArray =
        pstring "Array" >>. (between (pchar '<') (pchar '>') (ws >>. propType .>> ws))
        |>> PropType.Array

    let propTypeNonUnion =
        choice [ propTypeObject; propTypeArray; atomicPropType]

    let propTypeUnionCases (pElement: Parser<'t, _>) =
        ws >>. (sepBy1 (pElement .>> ws) (pchar '|' .>> ws))

    let propTypeUnion: Parser<PropType> =
        propTypeUnionCases propTypeNonUnion
        |>> (function
                | [t] -> t
                | ts -> Union ts)

    do propTypeRef.Value <-
            choice [
                propTypeUnion
                propTypeObject
                propTypeArray
                atomicPropType
            ]

    let propTypeFinal =
        ws >>. propType .>> ws .>> eof


module Translators =

    type FsTypeSignature = string

    type Translators = {
        InnerAtomic: AtomicPropType -> FsTypeSignature
        InnerObject: (string * PropType * bool) list -> FsTypeSignature
        InnerUnion: PropType list -> FsTypeSignature
        InnerArray: PropType -> FsTypeSignature
        TopLevelAtomic: AtomicPropType -> PropOverload list
        TopLevelObject: (string * PropType * bool) list -> PropOverload list
        TopLevelUnion: PropType list -> PropOverload list
        TopLevelArray: PropType -> PropOverload list
    }

    let enumPropOverloadOfLiteral (propTypeLiteral: LiteralPropType) =
        match propTypeLiteral with
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

    let translateInnerTsAtomicType (atomicType: AtomicPropType) =
        match atomicType with
        | Any -> "'T"
        | String -> "string"
        | Number -> "float"
        | Integer -> "int"
        | Bool -> "bool"
        | Date -> "System.DateTime"
        | Func -> "Func<obj, obj>"
        | AtomicPropType.Object -> "obj"
        | Element -> "ReactElement"
        | ElementType -> "ReactElementType"
        | HTMLElement -> "U2<#Element option, IRefValue<#Element option>>"
        | Literal (StringLiteral s) -> "string" //"\"" + s + "\""
        | Literal (IntLiteral i) -> "int" // "\"" + string i + "\""
        | Literal (BoolLiteral b) -> "bool"
        | OtherType typeName -> typeName
        | Node -> "U6<ReactElement, seq<ReactElement>, string, seq<string>, int, float>"

    let rec translateInnerPropType customize (propType: PropType) =
        let translators = translators customize
        match propType with
        | Atomic t -> translators.InnerAtomic t
        | Array elType -> translators.InnerArray elType
        | Union cases -> translators.InnerUnion cases
        | PropType.Object objEntries -> translators.InnerObject objEntries

    and translateInnerPropTypeArray customize (elementType: PropType) =
        translateInnerPropType customize elementType + " []"

    and translateInnerPropTypeUnion customize (unionCases: PropType list) =
        let translatedUnionCases =
            unionCases
            //|> List.map (function
            //    | TsType.Atomic (TsAtomicType.Literal (StringLiteral _)) -> "string"
            //    | t -> t |> translateNestedTsTypeSign customize)
            |> List.map (translateInnerPropType customize)
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

    and translateInnerPropTypeObject customize (objEntries: (string * PropType * bool) list) =
        let entries =
            objEntries
            |> List.map (fun (fieldName, fieldType, isOptional) ->
                let fsFieldName = jsParamNameToFsParamName fieldName
                let fsTypeSign =
                    let rawTypeSign = translateInnerPropType customize fieldType
                    if isOptional then rawTypeSign + " option"
                    else rawTypeSign
                fsFieldName + ": " + fsTypeSign)
            |> String.concat "; "
        "{| " + entries + " |}"

    and translateTopLevelPropType (customize: Translators -> Translators) (tsType: PropType) =
        let translators = translators customize
        match tsType with
        | Atomic t -> translators.TopLevelAtomic t
        | Union cases -> translators.TopLevelUnion cases
        | Object objEntries -> translators.TopLevelObject objEntries
        | Array elType -> translators.TopLevelArray elType

    and translateTopLevelPropTypeAtomic customize (tsAtomicType: AtomicPropType) =
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

        | Number ->
            [ RegularPropOverload.create "(value: int)" "value"
              RegularPropOverload.create "(value: float)" "value" ]
            |> List.map PropOverload.Regular

        | t ->
            let translators = translators customize
            let typeSign = translators.InnerAtomic t
            RegularPropOverload.create ("(value: " + typeSign + ")") "value"
            |> PropOverload.Regular
            |> List.singleton

    and translateTopLevelPropTypeObject customize (objEntries: (string * PropType * bool) list) =
        let translatedParams =
            objEntries
            |> List.map (fun (fieldName, fieldType, isOptional) ->
                fieldName, translateInnerPropType customize fieldType, isOptional)

        let paramsListStr =
            translatedParams
            |> List.map (fun (fieldName, fieldType, isOptional) ->
                if isOptional then "?" else ""
                + jsParamNameToFsParamName fieldName
                + ": "
                + fieldType)
            |> String.concat ", "

        let objCreationCode =
            translatedParams
            |> jsObjectFromParamsCodeWithCustomParamValueTransformByParamType
                jsParamNameToFsParamName
                [
                    "seq<IReactProperty>", "createObj !!"
                ]

        RegularPropOverload.create
            ("(" + paramsListStr + ")")
            objCreationCode
        |> PropOverload.Regular
        |> List.singleton

    and translateTopLevelPropTypeUnion customize (unionCases: PropType list) =
        unionCases
        |> List.collect (function
            | PropType.Atomic (Literal literal) ->
                enumPropOverloadOfLiteral literal
                |> PropOverload.Enum
                |> List.singleton

            | t -> translateTopLevelPropType customize t)
        |> List.distinctBy (function
            | PropOverload.Regular p -> Choice1Of2 p.ParamsCode
            | PropOverload.Enum p -> Choice2Of2 (p.MethodName, p.ParamsCode))

    and translateTopLevelPropTypeArray customize (elementType: PropType) =
        let translatedTypeSign = translateInnerPropType customize elementType
        let methodParamsCode =
            sprintf "([<ParamArray>] values: %s [])" translatedTypeSign
        let methodBodyCode = "values"

        RegularPropOverload.create methodParamsCode methodBodyCode
        |> PropOverload.Regular
        |> List.singleton

    and translators (customize: Translators -> Translators): Translators =
        {
            InnerAtomic = translateInnerTsAtomicType
            InnerObject = translateInnerPropTypeObject customize
            InnerUnion = translateInnerPropTypeUnion customize
            InnerArray = translateInnerPropTypeArray customize
            TopLevelAtomic = translateTopLevelPropTypeAtomic customize
            TopLevelObject = translateTopLevelPropTypeObject customize
            TopLevelUnion = translateTopLevelPropTypeUnion customize
            TopLevelArray = translateTopLevelPropTypeArray customize
        } |> customize

    type Translators with
        static member Default = translators id

type Translators = Translators.Translators

let tryParseTypeSignatureString (str: string) =
    str
    |> run Parsers.propTypeFinal
    |> function
        | Success(t, _, _) -> Result.Ok t
        | Failure(errorMsg, _, _) -> Result.Error errorMsg

let translateDefault (typeSignature: PropType) =
    typeSignature
    |> Translators.translateTopLevelPropType id

let translateCustom (customizeTranslators: Translators -> Translators) typeSignature =
    typeSignature
    |> Translators.translateTopLevelPropType customizeTranslators

let parseAndTranslateDefault (typeSignatureString: string) =
    typeSignatureString
    |> tryParseTypeSignatureString
    |> Result.map translateDefault

let parseAndTranslateCustom (customizeTranslators: Translators -> Translators) (typeSignatureString: string) =
    typeSignatureString
    |> tryParseTypeSignatureString
    |> Result.map (translateCustom customizeTranslators)
