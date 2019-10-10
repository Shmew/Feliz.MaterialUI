namespace Feliz.Generator

open System


[<AutoOpen>]
module private WriterHelpers =

  let indent numLevels = String.indent 2 numLevels

  let baseEnumProps =
    [
      {
        DocLines = [
          "The `text-anchor` attribute is used to align (start-, middle- or end-alignment) a string of pre-formatted text or auto-wrapped text where the wrapping area is determined from the `inline-size` property relative to a given point. It is not applicable to other types of auto-wrapped text. For those cases you should use `text-align`. For multi-line text, the alignment takes place for each line."
          ""
          "The `text-anchor` attribute is applied to each individual text chunk within a given `<text>` element. Each text chunk has an initial current text position, which represents the point in the user coordinate system resulting from (depending on context) application of the `x` and `y` attributes on the `<text>` element, any `x` or `y` attribute values on a `<tspan>`, `<tref>` or `<altGlyph>` element assigned explicitly to the first rendered character in a text chunk, or determination of the initial current text position for a `<textPath>` element."
        ]
        PropName = "textAnchor"
        TypeName = "prop.textAnchor"
      }
      {
        DocLines = ["https://www.w3.org/WAI/PF/aria-1.1/roles"]
        PropName = "role"
        TypeName = "prop.role"
      }
      {
        DocLines = []
        PropName = "transform"
        TypeName = "prop.transform"
      }
      {
        DocLines = [
          "Indicates what functions can be performed when the dragged object is released on the drop target. This allows assistive technologies to convey the possible drag options available to users, including whether a pop-up menu of choices is provided by the application. Typically, drop effect functions can only be provided once an object has been grabbed for a drag operation as the drop effect functions available are dependent on the object being dragged."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-dropeffect"
        ]
        PropName = "ariaDropEffect"
        TypeName = "prop.ariaDropEffect"
      }
      {
        DocLines = [
          "Indicates the entered value does not conform to the format expected by the application."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-invalid"
        ]
        PropName = "ariaInvalid"
        TypeName = "prop.ariaInvalid"
      }
      {
        DocLines = [
          "Indicates what user agent change notifications (additions, removals, etc.) assistive technologies will receive within a live region. See related `aria-atomic`."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-relevant"
        ]
        PropName = "ariaRelevant"
        TypeName = "prop.ariaRelevant"
      }
      {
        DocLines = [
          "Indicates that an element will be updated, and describes the types of updates the user agents, assistive technologies, and user can expect from the live region."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-live"
        ]
        PropName = "ariaLive"
        TypeName = "prop.ariaLive"
      }
      {
        DocLines = [
          "Indicates whether user input completion suggestions are provided."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-autocomplete"
        ]
        PropName = "ariaAutocomplete"
        TypeName = "prop.ariaAutocomplete"
      }
      {
        DocLines = [
          "Indicates the current \"checked\" state of checkboxes, radio buttons, and other widgets. See related `aria-pressed` and `aria-selected`."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-checked"
        ]
        PropName = "ariaChecked"
        TypeName = "prop.ariaChecked"
      }
      {
        DocLines = [
          "Indicates whether the element and orientation is horizontal or vertical."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-orientation"
        ]
        PropName = "ariaOrientation"
        TypeName = "prop.ariaOrientation"
      }
      {
        DocLines = [
          "Indicates the current \"pressed\" state of toggle buttons. See related `aria-checked` and `aria-selected`."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-pressed"
        ]
        PropName = "ariaPressed"
        TypeName = "prop.ariaPressed"
      }
      {
        DocLines = [
          "Indicates if items in a table or grid are sorted in ascending or descending order."
          ""
          "https://www.w3.org/WAI/PF/aria-1.1/states_and_properties#aria-sort"
        ]
        PropName = "ariaSort"
        TypeName = "prop.ariaSort"
      }
      {
        DocLines = []
        PropName = "type'"
        TypeName = "prop.withType"
      }
    ]


module GetLines =


  /// Gets the code lines for the implementation of a single component overload.
  /// Does not include docs.
  let singleComponentOverload (comp: Component) (compOverload: ComponentOverload) =
    sprintf "static member %s%s %s = createElement (%s \"%s\") %s"
      (if compOverload.IsInline then "inline " else "")
      comp.MethodName
      compOverload.ParamsCode
      (match comp.ImportSelector with None -> "importDefault" | Some sel -> "import " + sel)
      comp.ImportPath
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
        if allOverloadsAreInline then
          "[<Erase; EditorBrowsable(EditorBrowsableState.Never)>]"
        else
          "[<EditorBrowsable(EditorBrowsableState.Never)>]"
        sprintf "type %sProps =" comp.MethodName

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
        "[<EditorBrowsable(EditorBrowsableState.Never)>]" |> indent 1
        sprintf "type %sProps with" comp.MethodName |> indent 1

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
        "[<EditorBrowsable(EditorBrowsableState.Never)>]"
        sprintf "module %sProps =" comp.MethodName
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


  type private InheritanceHierarchyNode = {
    /// The regular (non-enum), sufficiently qualified prop type to inherit.
    RegularPropType: string option
    /// The enum props to inherit.
    EnumProps: InheritedEnumProp list
  }


  let propInheritance (allComponents: Component list) =
    
    let rec inheritanceHierarchyOf (comp: Component) (currentHierarchy: InheritanceHierarchyNode list) : InheritanceHierarchyNode list =

      let inheritedComponent, hierarchyNode =
        match comp.PropInheritance with
        | None -> None, None
        | Some (InheritsComponent methodName) ->
            let baseComp =
              allComponents
              |> List.tryFind (fun c -> c.MethodName = methodName)
              |> function
                 | Some c -> c
                 | None -> failwithf "Component '%s' inherits non-existent component '%s'" comp.MethodName methodName
            let regularPropType = if Component.hasRegularProps baseComp then Some (baseComp.MethodName + "Props") else None
            let enumProps = 
              baseComp.Props
              |> List.filter (fun p -> not p.EnumOverloads.IsEmpty)
              |> List.map (fun p -> {
                  DocLines = p.DocLines
                  PropName = p.MethodName
                  TypeName = sprintf "%sProps.%s" baseComp.MethodName p.MethodName
              })
            Some baseComp, Some { RegularPropType = regularPropType; EnumProps = enumProps }
        | Some InheritsNativeDom -> 
            None, Some { RegularPropType = Some "prop"; EnumProps = baseEnumProps }
        | Some (InheritsCustom (regularPropType, enumProps)) -> 
            None, Some { RegularPropType = regularPropType; EnumProps = enumProps }
      
      match inheritedComponent, hierarchyNode with
      | None, None -> currentHierarchy |> List.rev
      | None, Some n -> n :: currentHierarchy |> List.rev
      | Some baseComp, None -> inheritanceHierarchyOf baseComp currentHierarchy
      | Some baseComp, Some n -> inheritanceHierarchyOf baseComp (n :: currentHierarchy)

    let compsWithInheritance =
      allComponents |> List.map (fun c ->
        let selfHierarchyNode = {
          RegularPropType =
            if Component.hasRegularProps c then c.MethodName + "Props" |> Some else None
          EnumProps =
            c.Props
            |> List.filter (fun p -> not p.EnumOverloads.IsEmpty)
            |> List.map (fun p -> {
                DocLines = p.DocLines
                PropName = p.MethodName
                TypeName = sprintf "%sProps.%s" c.MethodName p.MethodName
            })
        }
        c, inheritanceHierarchyOf c [selfHierarchyNode]
      )

    let lengthOfLargestHierarchy =
      compsWithInheritance |> List.map (fun (_, h) -> h.Length) |> List.max

    [
      for i in [lengthOfLargestHierarchy .. -1 .. 0] do
        let compsAndHierarchyNodesForThisLevel =
          compsWithInheritance
          |> List.choose (fun (c, h) ->
              match h |> List.tryItem i with
              | None -> None
              | Some node -> Some (c, node)
          )

        let compsAndPropTypeNames =
          compsAndHierarchyNodesForThisLevel
          |> List.choose (function c, { RegularPropType = Some t } -> Some (c, t) | _ -> None)

        if not compsAndPropTypeNames.IsEmpty then
          "[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]"
          sprintf "module InheritanceLevel%i =" i
          ""
          for comp, typeName in compsAndPropTypeNames do
            sprintf "type %s = %s" comp.MethodName typeName |> indent 1

        ""
      
      let compsWithEnumProps =
        compsWithInheritance
        |> List.choose (fun (c, h) ->
            let enumProps =
              h
              |> List.collect (fun n -> n.EnumProps)
              |> List.distinctBy (fun p -> p.PropName)
            if enumProps.IsEmpty then None else Some (c, enumProps)
        )

      for c, enumProps in compsWithEnumProps do
        ""
        ""
        sprintf "module %s =" c.MethodName
        ""
        for p in enumProps do
          yield! p.DocLines |> List.map (String.prefix "/// " >> String.trim >> indent 1)
          sprintf "type %s = %s" p.PropName p.TypeName |> indent 1
    ]


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
      "let createElement (el: ReactElementType) (properties: IReactProperty list) : ReactElement =" |> indent 1
      "reactElement el (createObj !!properties)" |> indent 2
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
      ""
      if not api.PropsPrelude.IsEmpty then
        yield! api.PropsPrelude
        ""
        ""
      for comp in api.Components do
        yield! GetLines.propsForComponent comp
        ""
        ""
      yield! GetLines.propInheritance api.Components
      ""
    ]
    |> String.concat Environment.NewLine
