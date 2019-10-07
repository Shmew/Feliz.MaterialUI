module Render

open System
open Feliz.Generator
open Utils
open Domain


let indent numLevels = String.indent 2 numLevels


module GetLines =

  /// Gets the code lines for the implementation of a single class rule. Does not
  /// include docs.
  let singleClassRule (comp: MuiComponent) (rule: ClassRule) =
    sprintf "static member inline %s(value: string) : I%sClasses = unbox (\"%s\", value)"
      rule.MethodName
      (comp.GeneratorComponent.MethodName |> String.upperFirst)
      rule.RealRuleName
    |> List.singleton


  let classRulesForComponent (comp: MuiComponent) =
    [
      sprintf "type I%sClasses = interface end" (comp.GeneratorComponent.MethodName |> String.upperFirst)
      if not comp.ClassRules.IsEmpty then
        ""
        "[<Erase>]"
        sprintf "type %s =" comp.GeneratorComponent.MethodName
        for rule in comp.ClassRules do
          yield! rule.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 1)
          yield! singleClassRule comp rule |> List.map (indent 1)
    ]

  let themePropsForComponent (comp: MuiComponent) =
    sprintf """static member inline mui%s(props: IReactProperty list) : IThemeProps = unbox ("Mui%s", createObj !!props)"""
      (comp.GeneratorComponent.MethodName |> String.upperFirst)
      (comp.GeneratorComponent.MethodName |> String.upperFirst)
    |> List.singleton

  /// Gets the code lines for the implementation of a single class rule. Does not
  /// include docs.
  let singleThemeOverrideRule stylesheetName (rule: ClassRule) =
    sprintf "static member inline %s(styles: IStyleAttribute list) : I%sOverrideRule = unbox (\"%s\", createObj !!styles)"
      rule.MethodName
      (stylesheetName |> String.upperFirst)
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


let classesDocument (api: MuiComponentApi) =
  [
    sprintf "namespace %s" api.GeneratorComponentApi.Namespace
    ""
    "(*////////////////////////////////"
    "/// THIS FILE IS AUTO-GENERATED //"
    "////////////////////////////////*)"
    ""
    "open Fable.Core"
    ""
    "/// Override or extend the styles applied to components."
    "module classes ="
    ""
    for comp in api.MuiComponents do
      yield! GetLines.classRulesForComponent comp |> List.map (indent 1)
      ""
      ""
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
    "open Fable.Core"
    "open Fable.Core.JsInterop"
    "open Feliz"
    ""
    "type IThemeProps = interface end"
    ""
    ""
    "[<Erase>]"
    "type themeProps ="
    for comp in api.MuiComponents do
      yield! GetLines.themePropsForComponent comp |> List.map (indent 1)
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
    "open Fable.Core"
    "open Fable.Core.JsInterop"
    "open Feliz"
    ""
    "type IOverrideStyleSheet = interface end"
    ""
    for comp, stylesheetName in api.MuiComponents |> List.choose getCompAndStylesheetName do
      sprintf "type I%sOverrideRule = interface end" stylesheetName
    ""
    "[<Erase>]"
    "type overrides ="
    for comp, stylesheetName in api.MuiComponents |> List.choose getCompAndStylesheetName do
      sprintf "static member inline %s (rules: I%sOverrideRule list) : IOverrideStyleSheet = unbox (\"%s\", createObj !!rules)"
        (stylesheetName |> String.lowerFirst)
        stylesheetName
        stylesheetName
      |> indent 1
    ""
    "module overrides ="
    ""
    for comp, stylesheetName in api.MuiComponents |> List.choose getCompAndStylesheetName do
      yield! GetLines.themeOverridesForComponent comp stylesheetName |> List.map (indent 1)
      ""
  ]
  |> String.concat Environment.NewLine
