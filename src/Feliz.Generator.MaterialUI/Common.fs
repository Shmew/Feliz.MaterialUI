[<AutoOpen>]
module Common

open FSharp.Data
open ReverseMarkdown
open Domain

type ComponentApiPage = HtmlProvider<"cache/material-ui/api/app-bar.html">

type LocalizationPage = HtmlProvider<"cache/material-ui/guides/localization.html">

type MuiXDatePickersApiIndex = HtmlProvider<"cache/x/api/date-pickers/index.html">

//type SystemPropertiesApi = HtmlProvider<"https://mui.com/system/properties">

//type MaterialIconsPage = HtmlProvider<"https://mui.com/material-ui/material-icons/">
type MaterialIconsPage = HtmlProvider<"cache/material-ui/material-icons.html">

let kebabCaseToCamelCase (s: string) =
    let pieces = s.Split("-")

    if pieces.Length > 1 then
        pieces
        |> Array.iteri (fun i piece ->
            if i > 0 then
                pieces.[i] <-
                    piece.Substring(0, 1).ToUpper()
                    + piece.Substring(1))

        pieces |> String.concat ""
    else
        s

let prefixUnderscoreToNumbers (s: string) =
    if s.Length > 0
        && s |> Seq.head |> System.Char.IsNumber then
        "_" + s
    else
        s

let trimStart (start: char) (str: string) = str.TrimStart(start)

let appendApostropheToReservedKeywords =
    let reserved =
        [ "checked"
          "static"
          "fixed"
          "inline"
          "default"
          "component"
          "inherit"
          "open"
          "type"
          "true"
          "false"
          "in"
          "end"
          "global" ]
        |> Set.ofList

    fun s ->
        if reserved.Contains s then
            s + "'"
        else
            s

let private markdownConverter =
    Converter(
        Config(
            GithubFlavored = true,
            RemoveComments = true,
            SmartHrefHandling = true,
            UnknownTags = Config.UnknownTagsOption.PassThrough
        )
    )

let docElementsToMarkdownLines (nodes: HtmlNode list) =
    (nodes
     |> Seq.map (fun x ->
         x
             .ToString()
             .Replace("\n", "<br><br>")
             .Replace("\r", ""))
     |> String.concat ""
     |> fun s -> s.Replace("href=\"/", "href=\"https://mui.com/")
     |> fun s -> s.Replace("</code><code>", "</code> <code>")
     |> markdownConverter.Convert)
    |> fun s -> System.Text.RegularExpressions.Regex.Replace(s, "\r?\n\r?\n(\r?\n)+", "\r\n\r\n")
    |> String.split "\n"
    |> List.trimEmptyLines
    |> List.map String.removeControlCharacters


let (|PropsTypeUnion|_|) (componentName: string) (propName: string) (types: string []) =
    match types.Length with
    | 1 -> Some types[0]
    | n when n > 0 && n <= 9 ->
        let unionTypeParams = types |> String.concat ", "
        Some(sprintf "U%i<%s>" n unionTypeParams)

    | 0 ->
        printfn "No type information provided for component %A, prop %A" componentName propName
        None

    | n ->
        printfn "Unions with more than 9 cases are not supported. (Component: %A, prop: %A)" componentName propName
        None


let jsParamNameToFsParamName (paramName: JsParamName) =
    paramName
    |> kebabCaseToCamelCase
    |> prefixUnderscoreToNumbers
    |> appendApostropheToReservedKeywords


let jsObjectFromParamsCode (toSafeName) (objEntries: (ParamName * ParamTypeSignature * IsOptional) list) =
    objEntries
    |> List.map (fun (name, _, isOptional) ->
            if isOptional then
                sprintf "(if %s.IsSome then x?``%s`` <- %s)" (toSafeName name) name (toSafeName name)
            else
                sprintf "x?``%s`` <- %s" name (toSafeName name))
        |> String.concat "; "
        |> sprintf "(let x = createEmpty<obj> in %s; x)"


/// <summary> Helps to create overloads for a prop that could take an object with optional fields.
/// A parameter is a list of tuples having the form: (parameter-name, parameter-type, is-optional) --
/// to represent object fields.
/// </summary>
/// <param name="paramData">A list of tuples having the form: (parameter-name, parameter-type, is-optional).</param>
/// <returns>Tuple of form: (param-list, obj-creator),
/// where `param-list` is a code for method parameters and `obj-creator` -- for method body.
/// </returns>
let paramListAndObjCreator (paramData: (ParamName * ParamTypeSignature * IsOptional) list) =
    let toSafeName = jsParamNameToFsParamName

    let paramList =
        paramData
        |> List.map (fun (name, fsType, isOptional) ->
            sprintf "%s%s: %s" (if isOptional then "?" else "") (toSafeName name) fsType)
        |> String.concat ", "
        |> sprintf "(%s)"

    let objCreator = paramData |> jsObjectFromParamsCode toSafeName

    paramList, objCreator


type PropObjectBuilderParamInfo = {
    JsParamName : JsParamName
    FsParamName : FsParamName
    FsParamTypeSignature : ParamTypeSignature
    IsOptional : bool
}

/// <summary> Generates method's parameters list and body-code, that constructs and returns JS-object.
/// Allows to specify expr for parameter value transformation. </summary>
/// <param name="paramValueTransformExpr">Body of the function that handles paramValue.
/// Example: `!!createObj`. </param>
let paramListAndObjCreatorWithParamValueTransform
    (paramValueTransformExpr: FsExprCode)
    (paramsData: PropObjectBuilderParamInfo list)
    =
    let paramList =
        paramsData
        |> List.map (fun p ->
            sprintf "%s%s: %s" (if p.IsOptional then "?" else "") p.FsParamName p.FsParamTypeSignature)
        |> String.concat ", "
        |> sprintf "(%s)"

    let outputObjCretionCode =
        paramsData
        |> List.map (fun p ->
            let paramValue pname = sprintf "(paramValue %s)" pname
            if p.IsOptional then
                sprintf "(if %s.IsSome then x?``%s`` <- %s)" (p.FsParamName) p.JsParamName (paramValue (p.FsParamName + ".Value"))
            else
                sprintf "x?``%s`` <- %s" p.JsParamName (paramValue p.FsParamName)
        )
        |> String.concat "; "
        |> sprintf "(let inline paramValue p = p |> %s in let x = createEmpty<obj> in %s; x)" paramValueTransformExpr

    paramList, outputObjCretionCode


module RegularPropOverload =

    open Feliz.Generator

    /// Adds common overload of `children` prop parameterized by `seq<ReactElement>`.
    let childrenElementsSeq () =
        RegularPropOverload.createCustom "(elements: seq<ReactElement>)" "prop.children elements"


    /// <summary> Overload with a list of probably optional parameters --
    /// useful for props that take so-called "configuration object".
    /// A parameter is a list of tuples having the form: (parameter-name, parameter-type, is-optional) --
    /// to represent object fields. </summary>
    /// <param name="paramData">A list of tuples having the form: (parameter-name, parameter-type, is-optional).</param>
    let createConfigObjectLike (paramsInfo: (ParamName * ParamTypeSignature * IsOptional) list) =
        paramsInfo |> paramListAndObjCreator ||> RegularPropOverload.create


    // Overoad with an optional parameter for each of the provided breakpoints.
    let createWithBreakpoints (breakpointKeys: BreakpointKey list) (propType: ParamTypeSignature) =
        [for bpKey in breakpointKeys -> bpKey, propType, true]
        |> createConfigObjectLike


    /// Overload with an optional parameter for each of the default MUI breakpoints: "xs", "sm", "md", "lg", "xl". 
    let createWithMuiBreakpoints (breakpointPropType: ParamTypeSignature) =
        let breakpoints = ["xs"; "sm"; "md"; "lg"; "xl"]
        createWithBreakpoints breakpoints breakpointPropType


    /// Overload with a `seq` of mappings: (breakpoint-key, value) -- to allow to set custom breakpoints.
    let createWithCustomBreakpoints (breakPointPropType: ParamTypeSignature) =
        let paramCode = sprintf "(breakpointMappings: seq<string * %s>)" breakPointPropType
        let valueCode = "(createObj !!breakpointMappings)"
        RegularPropOverload.create paramCode valueCode


    let createWithBreakpointsAndParamValueTransform
        (breakpointKeys: BreakpointKey list)
        (propType: ParamTypeSignature)
        (paramValueTransformExpr: FsExprCode)
        =
        [ for bpKey in breakpointKeys ->
            { JsParamName = bpKey
              FsParamName = jsParamNameToFsParamName bpKey
              FsParamTypeSignature = propType
              IsOptional = true } ]
        |> paramListAndObjCreatorWithParamValueTransform paramValueTransformExpr
        ||> RegularPropOverload.create


    let createWithMuiBreakpointsAndParamValueTransform
        (propType: ParamTypeSignature)
        (paramValueTransformExpr: FsExprCode)
        =
        createWithBreakpointsAndParamValueTransform
            ["xs"; "sm"; "md"; "lg"; "xl"]
            propType
            paramValueTransformExpr


module Component =

    open Feliz.Generator

    /// Adds `children` prop parameterized by `seq<ReactElement>`.
    let addChildrenProp (comp: Component) =
        comp |> Component.addProp (
            Prop.create "children" "children"
            |> Prop.setDocs [ "Your component tree." ]
            |> Prop.addRegularOverload (RegularPropOverload.childrenElementsSeq())
        )
