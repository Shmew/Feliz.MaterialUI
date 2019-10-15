namespace Feliz.Generator

open System


[<AutoOpen>]
module private WriterHelpers =

  let indent numLevels = String.indent 2 numLevels

  // Returns all ancestor (base) components of the component, with closest
  // ancestors first.
  let getAncestors allComponents comp =
    let rec inner currentHierarchy comp =
      match comp.BaseComponentMethodName with
      | None -> currentHierarchy |> List.rev
      | Some baseMethodName ->
          let baseComp =
            allComponents
            |> List.tryFind (fun bc -> bc.MethodName = baseMethodName)
            |> function
               | Some bc -> bc
               | None -> failwithf "Component '%s' inherits non-existent component '%s'" comp.MethodName baseMethodName
          inner (baseComp :: currentHierarchy) baseComp
    inner [] comp


module GetLines =


  /// Gets the code lines for the implementation of a single component overload.
  /// Does not include docs.
  let singleComponentOverload (comp: Component) (compOverload: ComponentOverload) =
    let createElementFirstArg =
      match comp.Source with
      | ImportPath (path, None) -> sprintf "(importDefault \"%s\")" path
      | ImportPath (path, Some selector) -> sprintf "(import \"%s\" \"%s\")" selector path
      | Tag tag -> sprintf "\"%s\"" tag
    sprintf "static member %s%s %s = createElement %s %s"
      (if compOverload.IsInline then "inline " else "")
      comp.MethodName
      compOverload.ParamsCode
      createElementFirstArg
      compOverload.PropsCode
    |> List.singleton


  /// Gets the code lines for the implementation of a single regular (non-enum)
  /// prop overload. Does not include docs.
  let singlePropRegularOverload (prop: Prop) (propOverload: RegularPropOverload) =
    let bodyCode =
      match propOverload.BodyCode with
      | ValueExprOnly expr -> sprintf "Interop.mkAttr \"%s\" %s" prop.RealPropName expr
      | CustomBody code -> code
    sprintf "static member %s%s %s = %s"
      (if propOverload.IsInline then "inline " else "")
      prop.MethodName
      propOverload.ParamsCode
      bodyCode
    |> List.singleton


  /// Gets the code lines for the implementation of a single regular (non-enum)
  /// prop overload. Does not include docs.
  let singlePropEnumOverload (prop: Prop) (propOverload: EnumPropOverload) =
    sprintf "static member %s%s %s= Interop.mkAttr \"%s\" %s"
      (if propOverload.IsInline then "inline " else "")
      propOverload.MethodName
      (match propOverload.ParamsCode with Some s -> s + " " | None -> "")
      prop.RealPropName
      propOverload.ValueCode
    |> List.singleton


  let regularNonExtensionPropsForComponent (comp: Component) =
    let propsAndRegularNonExtensionOverloads =
      comp.Props
      |> List.choose (fun p ->
          let regularNonExtensionOverloads =
            p.RegularOverloads |> List.filter (fun o -> not o.IsExtension)
          if regularNonExtensionOverloads.IsEmpty
          then None
          else Some (p, regularNonExtensionOverloads)
      )

    if propsAndRegularNonExtensionOverloads.IsEmpty then []
    else 
      let allOverloadsAreInline =
        propsAndRegularNonExtensionOverloads
        |> List.forall (fun (_, os) -> os |> List.forall (fun o -> o.IsInline))
      [
        if allOverloadsAreInline then "[<Erase>]"
        sprintf "type %s =" comp.MethodName

        for prop, overloads in propsAndRegularNonExtensionOverloads do
        for overload in overloads do
          yield! prop.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 1)
          yield! singlePropRegularOverload prop overload |> List.map (indent 1)
      ]


  let regularExtensionPropsForComponent (comp: Component) =
    let propsAndRegularExtensionOverloads =
      comp.Props
      |> List.choose (fun p ->
          let regularExtensionOverloads =
            p.RegularOverloads |> List.filter (fun o -> o.IsExtension)
          if regularExtensionOverloads.IsEmpty
          then None
          else Some (p, regularExtensionOverloads)
      )

    if propsAndRegularExtensionOverloads.IsEmpty then []
    else 
      [
        "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
        sprintf "module %sExtensions =" comp.MethodName
        ""
        sprintf "type %s with" comp.MethodName |> indent 1

        for prop, overloads in propsAndRegularExtensionOverloads do
        for overload in overloads do
          yield! prop.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 2)
          yield! singlePropRegularOverload prop overload |> List.map (indent 2)
      ]


  let enumPropsForComponent (comp: Component) =
    let propsAndEnumOverloads =
      comp.Props
      |> List.choose (fun p ->
          if p.EnumOverloads.IsEmpty
          then None
          else Some (p, p.EnumOverloads)
      )

    if propsAndEnumOverloads.IsEmpty then []
    else 
      [
        sprintf "module %s =" comp.MethodName
        for prop, overloads in propsAndEnumOverloads do
          ""
          let allOverloadsAreInline = overloads |> List.forall (fun o -> o.IsInline)
          yield! prop.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 1)
          if allOverloadsAreInline then "[<Erase>]" |> indent 1
          sprintf "type %s =" prop.MethodName |> indent 1

          for overload in overloads do
            yield! overload.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 2)
            yield! singlePropEnumOverload prop overload |> List.map (indent 2)
      ]


  let propsForComponent (comp: Component) =
    let regularProps = regularNonExtensionPropsForComponent comp
    let regularExtensionProps = regularExtensionPropsForComponent comp
    let enumProps = enumPropsForComponent comp

    [
      if not regularProps.IsEmpty then
        yield! regularProps
        ""
      if not regularExtensionProps.IsEmpty then
        yield! regularExtensionProps
        ""
      yield! enumProps
    ]
    |> List.trimEmptyLines


module Render =


  let componentDocument (api: ComponentApi) =
    [
      sprintf "namespace %s" api.Namespace
      ""
      "(*////////////////////////////////"
      "/// THIS FILE IS AUTO-GENERATED //"
      "////////////////////////////////*)"
      ""
      "open System.ComponentModel"
      "open Fable.Core"
      "open Fable.Core.JsInterop"
      "open Fable.React"
      "open Feliz"
      ""
      "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
      sprintf "module %sHelpers =" api.ComponentContainerTypeName
      ""
      "let reactElement (el: ReactElementType) (props: 'a) : ReactElement =" |> indent 1
      "import \"createElement\" \"react\"" |> indent 2
      ""
      "let reactElementTag (tag: string) (props: 'a) : ReactElement =" |> indent 1
      "import \"createElement\" \"react\"" |> indent 2
      ""
      "let createElement (el: ReactElementType) (properties: IReactProperty seq) : ReactElement =" |> indent 1
      "reactElement el (createObj !!properties)" |> indent 2
      ""
      "let createElementTag (tag: string) (properties: IReactProperty seq) : ReactElement =" |> indent 1
      "reactElementTag tag (createObj !!properties)" |> indent 2
      ""
      if not api.ComponentsPrelude.IsEmpty then
        yield! api.ComponentsPrelude
        ""
      if api.Components |> List.forall Component.hasOnlyInlineOverloads then "[<Erase>]"
      sprintf "type %s =" api.ComponentContainerTypeName
      ""
      for comp in api.Components do
      for overload in comp.Overloads do
        yield! comp.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 1)
        yield! GetLines.singleComponentOverload comp overload |> List.map (indent 1)
        ""
    ]
    |> String.concat Environment.NewLine


  let propsDocument (api: ComponentApi) =
    let componentsWithInheritedProps =
      api.Components
      |> List.map (fun c ->
          let ancestors = getAncestors api.Components c
          let propsToInherit =
            ancestors
            |> List.collect (fun c -> 
                c.Props
                |> List.map (fun p -> { p with DocLines = sprintf "*Inherited from `%s`*" c.MethodName :: "" :: p.DocLines })
            )
          { c with Props = c.Props @ propsToInherit |> List.distinctBy (fun p -> p.MethodName) }
      )
    [
      sprintf "namespace %s" api.Namespace
      ""
      "(*////////////////////////////////"
      "/// THIS FILE IS AUTO-GENERATED //"
      "////////////////////////////////*)"
      ""
      "open System"
      "open System.ComponentModel"
      "open Browser.Types"
      "open Fable.Core"
      "open Fable.Core.JsInterop"
      "open Fable.React"
      "open Feliz"
      if not api.PropsPrelude.IsEmpty then
        ""
        ""
        yield! api.PropsPrelude
      for comp in componentsWithInheritedProps do
        ""
        ""
        yield! GetLines.propsForComponent comp
      ""
    ]
    |> String.concat Environment.NewLine
