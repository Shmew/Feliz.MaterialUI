module Render

open System
open Feliz.Generator
open Utils
open Domain

let indent numLevels = String.indent 2 numLevels

module GetLines =

    /// Gets the code lines for the implementation of a single class rule. Does not
    /// include docs.
    let singleClassRule (propName: string) (rule: ClassRule) =
        //sprintf "static member inline %s(className: string) : IReactProperty = unbox (\"%s.%s\", className)"
        //rule.MethodName
        //propName
        //rule.RealRuleName
        sprintf "static member inline %s : string = \"%s\"" rule.MethodName rule.GlobalClass
        |> List.singleton

    let classRulesForComponent (api: MuiComponentApi) (comp: MuiComponent) =
        [ let propsAndClassRules =
              comp.GeneratorComponent.Props
              |> List.choose (fun p ->
                  if p.MethodName = "classes"
                     && not comp.ClassRules.IsEmpty then
                      Some(p, comp.ClassRules)
                  elif p.MethodName.EndsWith "Classes" then
                      let otherCompName =
                          p.MethodName.Substring(0, p.MethodName.Length - 7)
                          |> String.lowerFirst

                      let rules =
                          api.MuiComponents
                          |> List.find (fun c -> c.GeneratorComponent.MethodName = otherCompName)
                          |> fun c -> c.ClassRules

                      if not rules.IsEmpty then
                          Some(p, rules)
                      else
                          None
                  else
                      None

              )

          if not propsAndClassRules.IsEmpty then
              sprintf "module %s =" comp.GeneratorComponent.MethodName

              for prop, classRules in propsAndClassRules do
                  ""

                  yield!
                      prop.DocLines
                      |> List.map (String.prefix "/// " >> String.trim >> indent 1)

                  "[<Erase>]" |> indent 1
                  sprintf "type %s =" prop.MethodName |> indent 1

                  for rule in classRules do
                      yield!
                          rule.DocLines
                          |> List.map (String.prefix "/// " >> String.trim >> indent 2)

                      yield!
                          singleClassRule prop.MethodName rule
                          |> List.map (indent 2)

              ""
              "" ]

    let themeDefaultPropsForComponent stylesheetName =
        sprintf
            """static member inline %s(props: IReactProperty list) : IThemeProp = unbox ("components.%s.defaultProps", createObj !!props)"""
            (stylesheetName |> String.lowerFirst)
            stylesheetName
        |> List.singleton

    /// Gets the code lines for the implementation of a single class rule. Does not
    /// include docs.
    let singleThemeOverrideRule stylesheetName (rule: ClassRule) =
        sprintf
            "static member inline %s(styles: IStyleAttribute list) : IThemeProp = unbox (\"overrides.%s.%s\", createObj !!styles)"
            rule.MethodName
            stylesheetName
            rule.RealRuleName
        |> List.singleton

    let singleStyleOverrideRule stylesheetName (rule: ClassRule) =
        sprintf
            "static member inline %s(styles: IStyleAttribute list) : IThemeProp = unbox (\"components.%s.styleOverrides.%s\", createObj !!styles)"
            rule.MethodName
            stylesheetName
            rule.RealRuleName
        |> List.singleton

    let componentVariants stylesheetName = [
        indent 1 "/// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied."
        sprintf
            "static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants(\"%s\", !!values)"
            stylesheetName
        |> indent 1
    ]

    //let componentOverrideHelperCode (stylesheetName: string) = [
    //    indent 1 "static member inline componentOverride(?styleOverrides: seq<IStyleOverride>, ?variants: IComponentVariant []): IComponentOverride ="
    //    indent 2
    //        (sprintf "Styles.createComponentOverride(\"%s\", ?styleOverrides = styleOverrides, ?variants = variants)" stylesheetName)
    //    ""
    //]

    let themeOverridesForComponent (comp: MuiComponent) stylesheetName =
        [ "[<Erase>]"
          sprintf "type %s =" (stylesheetName |> String.lowerFirst)

          //yield! componentOverrideHelperCode stylesheetName
          yield! componentVariants stylesheetName

          for rule in comp.ClassRules do
              yield!
                  rule.DocLines
                  |> List.map (String.prefix "/// " >> String.trim >> indent 1)

              if comp.GeneratorComponent.MethodName = "cssBaseline" then
                 //&& rule.RealRuleName = "@global" then
                  "static member inline global'(htmlTagsWithStyles: (string * (IStyleAttribute list)) list) : IThemeProp = unbox (\"styleOverrides.MuiCssBaseline.@global\", createObj !!(htmlTagsWithStyles |> List.map (fun (tag, styles) -> tag, createObj !!styles)))"
                  |> indent 1
              else
                  yield!
                      singleStyleOverrideRule stylesheetName rule
                      |> List.map (indent 1) ]

    let locale (loc: Locale) =
        [ sprintf "/// %s" loc.Name
          sprintf
              "static member inline %s: Theme = import \"%s\" \"@mui/material/locale\""
              loc.ImportName
              loc.ImportName ]


    let materialIcon (iconTitle: string) =
        [
            sprintf "let inline %s (props: #seq<IReactProperty>) = ofImport \"default\" \"@mui/icons-material/%s\" (createObj !!props) []"
                (jsParamNameToFsParamName iconTitle + "Icon")
                iconTitle
        ]

let classesDocument (additionalOpens: string list) (api: MuiComponentApi) =
    [ sprintf "namespace %s" api.GeneratorComponentApi.Namespace
      ""
      "(*////////////////////////////////"
      "/// THIS FILE IS AUTO-GENERATED //"
      "////////////////////////////////*)"
      ""
      "open System.ComponentModel"
      "open Fable.Core"
      "open Feliz"
      yield! additionalOpens
      ""
      "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
      "module classesProps ="
      ""
      for comp in api.MuiComponents do
          yield!
              GetLines.classRulesForComponent api comp
              |> List.map (indent 1) ]
    |> String.concat Environment.NewLine

let themePropsDocument (additionalOpens: string list) (api: MuiComponentApi) =

    let getStylesheetName =
        function
        | { ComponentName = Some n } as c -> Some n
        | _ -> None

    [ sprintf "namespace %s" api.GeneratorComponentApi.Namespace
      ""
      "(*////////////////////////////////"
      "/// THIS FILE IS AUTO-GENERATED //"
      "////////////////////////////////*)"
      ""
      "open System.ComponentModel"
      "open Fable.Core"
      "open Fable.Core.JsInterop"
      "open Feliz"
      yield! additionalOpens
      ""
      ""
      "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
      "module themeProps ="
      ""
      "  module theme ="
      ""
      "    [<Erase>]"
      "    type defaultProps ="
      for stylesheetName in api.MuiComponents |> List.choose getStylesheetName do
          yield!
              GetLines.themeDefaultPropsForComponent stylesheetName
              |> List.map (indent 3)
      "" ]
    |> String.concat Environment.NewLine

let themeOverridesDocument (additionalOpens: string list) (api: MuiComponentApi) =

    let getCompAndStylesheetName =
        function
        | { ComponentName = Some n } as c -> Some(c, n)
        | _ -> None

    [ sprintf "namespace %s" api.GeneratorComponentApi.Namespace
      ""
      "(*////////////////////////////////"
      "/// THIS FILE IS AUTO-GENERATED //"
      "////////////////////////////////*)"
      ""
      "open System"
      "open System.ComponentModel"
      "open Fable.Core"
      "open Fable.Core.JsInterop"
      "open Feliz"
      yield! additionalOpens
      ""
      "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
      "module themeOverrides ="
      ""
      "  module theme ="
      ""
      "    module styleOverrides ="
      ""
      for comp, stylesheetName in
          api.MuiComponents
          |> List.choose getCompAndStylesheetName do
          if not comp.ClassRules.IsEmpty then
              yield!
                  GetLines.themeOverridesForComponent comp stylesheetName
                  |> List.map (indent 3)

              "" ]
    |> String.concat Environment.NewLine

let localizationDocument (localization: Localization) =

    [ "namespace Feliz.MaterialUI"
      ""
      "(*////////////////////////////////"
      "/// THIS FILE IS AUTO-GENERATED //"
      "////////////////////////////////*)"
      ""
      "open Fable.Core"
      "open Fable.Core.JsInterop"
      ""
      "[<Erase>]"
      "type Locale ="
      for loc in localization.Locales do
          yield! GetLines.locale loc |> List.map (indent 1)
      "" ]
    |> String.concat Environment.NewLine


let materialIconsDocument (iconTitles: seq<string>) =
    [ "module Feliz.MaterialUI.Icons"
      ""
      "(*////////////////////////////////"
      "/// THIS FILE IS AUTO-GENERATED //"
      "////////////////////////////////*)"
      ""
      "open Fable.Core"
      "open Fable.Core.JsInterop"
      "open Fable.React"
      "open Feliz"
      ""
      for iconTitle in iconTitles do
          yield! GetLines.materialIcon iconTitle //|> List.map (indent 1)
      "" ]
    |> String.concat Environment.NewLine
