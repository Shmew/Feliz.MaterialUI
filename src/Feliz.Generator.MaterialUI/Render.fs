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
    sprintf "static member inline %s(className: string) : IReactProperty = unbox (\"%s.%s\", className)"
      rule.MethodName
      propName
      rule.RealRuleName
    |> List.singleton


  let classRulesForComponent (api: MuiComponentApi) (comp: MuiComponent) =
    [
      let propsAndClassRules =
        comp.GeneratorComponent.Props
        |> List.choose (fun p ->
            if p.MethodName = "classes" && not comp.ClassRules.IsEmpty then
              Some (p, comp.ClassRules)
            elif p.MethodName.EndsWith "Classes" then
              let otherCompName =
                p.MethodName.Substring(0, p.MethodName.Length-7)
                |> String.lowerFirst
              let rules =
                api.MuiComponents
                |> List.find (fun c -> c.GeneratorComponent.MethodName = otherCompName)
                |> fun c -> c.ClassRules
              if not rules.IsEmpty then Some (p, rules) else None
            else None
              
        )

      if not propsAndClassRules.IsEmpty then
        sprintf "module %s =" comp.GeneratorComponent.MethodName

        for prop, classRules in propsAndClassRules do
          ""
          yield! prop.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 1)
          "[<Erase>]" |> indent 1
          sprintf "type %s =" prop.MethodName |> indent 1
          for rule in classRules do
            yield! rule.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 2)
            yield! singleClassRule prop.MethodName rule |> List.map (indent 2)
        ""
        ""
    ]

  let themePropsForComponent (comp: MuiComponent) =
    sprintf """static member inline mui%s(props: IReactProperty list) : IThemeProp = unbox ("props.Mui%s", createObj !!props)"""
      (comp.GeneratorComponent.MethodName |> String.upperFirst)
      (comp.GeneratorComponent.MethodName |> String.upperFirst)
    |> List.singleton

  /// Gets the code lines for the implementation of a single class rule. Does not
  /// include docs.
  let singleThemeOverrideRule stylesheetName (rule: ClassRule) =
    sprintf "static member inline %s(styles: IStyleAttribute list) : IThemeProp = unbox (\"overrides.%s.%s\", createObj !!styles)"
      rule.MethodName
      stylesheetName
      rule.RealRuleName
    |> List.singleton

  let themeOverridesForComponent (comp: MuiComponent) stylesheetName =
    [
      "[<Erase>]"
      sprintf "type %s =" (stylesheetName |> String.lowerFirst)
      for rule in comp.ClassRules do
        yield! rule.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 1)
        yield! singleThemeOverrideRule stylesheetName rule |> List.map (indent 1)
    ]

  let locale (loc: Locale) =
    [
      sprintf "/// %s" loc.Name
      sprintf "static member inline %s: Theme = import \"%s\" \"@material-ui/core/locale\"" loc.ImportName loc.ImportName
    ]


let classesDocument (api: MuiComponentApi) =
  [
    sprintf "namespace %s" api.GeneratorComponentApi.Namespace
    ""
    "(*////////////////////////////////"
    "/// THIS FILE IS AUTO-GENERATED //"
    "////////////////////////////////*)"
    ""
    "open System.ComponentModel"
    "open Fable.Core"
    "open Feliz"
    ""
    "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
    "module classesProps ="
    ""
    for comp in api.MuiComponents do
      yield! GetLines.classRulesForComponent api comp |> List.map (indent 1)
  ]
  |> String.concat Environment.NewLine


let themePropsDocument (api: MuiComponentApi) =
  [
    sprintf "namespace %s" api.GeneratorComponentApi.Namespace
    ""
    "(*////////////////////////////////"
    "/// THIS FILE IS AUTO-GENERATED //"
    "////////////////////////////////*)"
    ""
    "open System.ComponentModel"
    "open Fable.Core"
    "open Fable.Core.JsInterop"
    "open Feliz"
    ""
    ""
    "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
    "module themeProps ="
    ""
    "  module theme ="
    ""
    "    [<Erase>]"
    "    type props ="
    for comp in api.MuiComponents do
      yield! GetLines.themePropsForComponent comp |> List.map (indent 3)
    ""
  ]
  |> String.concat Environment.NewLine


let themeOverridesDocument (api: MuiComponentApi) =

  let getCompAndStylesheetName = function
    | { StylesheetName = Some n } as c -> Some (c, n)
    | _ -> None

  [
    sprintf "namespace %s" api.GeneratorComponentApi.Namespace
    ""
    "(*////////////////////////////////"
    "/// THIS FILE IS AUTO-GENERATED //"
    "////////////////////////////////*)"
    ""
    "open System.ComponentModel"
    "open Fable.Core"
    "open Fable.Core.JsInterop"
    "open Feliz"
    ""
    "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
    "module themeOverrides ="
    ""
    "  module theme ="
    ""
    "    module overrides ="
    ""
    for comp, stylesheetName in api.MuiComponents |> List.choose getCompAndStylesheetName do
      yield! GetLines.themeOverridesForComponent comp stylesheetName |> List.map (indent 3)
      ""
  ]
  |> String.concat Environment.NewLine


let localizationDocument (localization: Localization) =

  [
    "namespace Feliz.MaterialUI"
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
    ""
  ]
  |> String.concat Environment.NewLine
