namespace Feliz.Generator


type RegularPropOverloadBody =
  | ValueExprOnly of string
  | CustomBody of string


type ComponentSource =
  /// The component is created from a string tag
  | Tag of string
  /// The component is imported using the specified path and selector. If
  /// `selector` is `None`, will use `importDefault`.
  | ImportPath of path: string * selector: string option


type RegularPropOverload = {
  /// The code for the method parameters, e.g. `(value: string)`.
  ParamsCode: string
  /// The code for the prop value expression, e.g. `value` or
  /// `(System.Func<_,_,_> handler)`.
  BodyCode: RegularPropOverloadBody
  /// Whether the member is inline.
  IsInline: bool
  /// Whether the member should be implemented as an extension member.
  IsExtension: bool
}


type EnumPropOverload = {
  /// The doc lines for the enum prop's value/overload, without leading ///.
  DocLines: string list
  /// The name of the enum prop's value/overload.
  MethodName: string
  /// The code for the method parameters, e.g. `(value: string)`. Normally this
  /// would be `None` (for simple enum values).
  ParamsCode: string option
  /// The code for the prop value expression. Normally this would be the enum
  /// value, e.g. `"topRight"`.
  ValueCode: string
  /// Whether the member is inline.
  IsInline: bool
}


type Prop = {
  /// The doc lines for the prop, without leading ///.
  DocLines: string list
  /// Whether this prop is required.
  IsRequired: bool
  /// The actual name of the prop in the native API.
  RealPropName: string
  /// The name used for the prop overload methods (and for the prop types for
  /// enum props).
  MethodName: string
  /// The prop overloads.
  RegularOverloads: RegularPropOverload list
  /// The prop overloads.
  EnumOverloads: EnumPropOverload list
}


type ComponentOverload = {
  /// The code for the method parameters, e.g. `props` or `(text: string)`.
  ParamsCode: string
  /// The expression for the props passed to the created element, e.g. `props`
  /// or `[ prop.children (Html.text text) ]`.
  PropsCode: string
  /// Whether the member is inline.
  IsInline: bool
}


type Component = {
  /// The doc lines for the component, without leading ///.
  DocLines: string list
  /// The name used for the component overloads.
  MethodName: string
  /// The source of the component (string tag or import path/selector).
  Source: ComponentSource
  /// The overloads used to create the component.
  Overloads: ComponentOverload list
  /// The component's props.
  Props: Prop list
  /// The MethodName of the component this component inherits props from.
  BaseComponentMethodName: string option
}


type ComponentApi = {
  /// The namespace for the API.
  Namespace: string
  /// The expression used to parse `properties: IReactProperty seq` into a prop object
  /// when creating a component. The default is `createObj !!properties`.
  ParseProps: string
  /// Lines to insert before the component definitions.
  ComponentsPrelude: string list
  /// Lines to insert before the prop definitions.
  PropsPrelude: string list
  /// The type the component methods will be placed in.
  ComponentContainerTypeName: string
  /// All components in the API.
  Components: Component list
}


module RegularPropOverload =

  /// Creates an inline prop overload with the specified code for params and
  /// value expression, implemented as a regular (non-extension) member.
  let create paramsCode valueCode = {
    ParamsCode = paramsCode
    BodyCode = ValueExprOnly valueCode
    IsInline = true
    IsExtension = false
  }

  /// Creates an inline prop overload with the specified code for params and
  /// body, implemented as a regular (non-extension) member.
  let createCustom paramsCode customBodyCode = {
    ParamsCode = paramsCode
    BodyCode = CustomBody customBodyCode
    IsInline = true
    IsExtension = false
  }

  /// Sets whether the overload is inline.
  let setInline isInline (overload: RegularPropOverload) =
    { overload with IsInline = isInline }

  /// Sets whether the overload is implemented as an extension member.
  let setExtension isExtension (overload: RegularPropOverload) =
    { overload with IsExtension = isExtension }


module EnumPropOverload =

  /// Creates an inline enum prop value/overload with the specified method name
  /// and code for value expression and no docs or params.
  let create methodName valueCode = {
    DocLines = []
    MethodName = methodName
    ParamsCode = None
    ValueCode = valueCode
    IsInline = true
  }

  /// Sets the doc lines of the enum prop value/overload.
  let setDocs docLines (overload: EnumPropOverload) =
    { overload with DocLines = docLines }

  /// Sets the params code for the enum prop value/overload.
  let setParamsCode code (overload: EnumPropOverload) =
    { overload with ParamsCode = Some code }

  /// Sets whether the overload is inline.
  let setInline isInline (overload: EnumPropOverload) =
    { overload with IsInline = isInline }


module Prop =

  /// Creates a prop with the specified native API name and method name and no
  /// docs or overloads.
  let create realPropName methodName = {
    DocLines = []
    IsRequired = false
    RealPropName = realPropName
    MethodName = methodName
    RegularOverloads = []
    EnumOverloads = []
  }

  /// Sets the prop's doc lines.
  let setDocs docLines (prop: Prop) =
    { prop with DocLines = docLines }

  /// Sets whether the prop is required.
  let setRequired value prop =
    { prop with IsRequired = value }

  /// Adds the specified regular (non-enum) overload to the prop.
  let addRegularOverload overload prop =
    { prop with RegularOverloads = prop.RegularOverloads @ [overload] }

  /// Adds the specified regular (non-enum) overloads to the prop.
  let addRegularOverloads (overloads: #seq<_>) prop =
    (prop, overloads) ||> Seq.fold (flip addRegularOverload)

  /// Adds the specified enum value/overload to the prop.
  let addEnumOverload overload prop =
    { prop with EnumOverloads = prop.EnumOverloads @ [overload] }

  /// Adds the specified enum values/overloads to the prop.
  let addEnumOverloads (overloads: #seq<_>) prop =
    (prop, overloads) ||> Seq.fold (flip addEnumOverload)

  /// Indicates whether all regular prop overloads are inline.
  let allRegularOverloadsAreInline prop =
    prop.RegularOverloads |> List.forall (fun o -> o.IsInline)


module ComponentOverload =

  /// A default overload that accepts and passes a list of props.
  let default' = {
    ParamsCode = "props"
    PropsCode = "props"
    IsInline = true
  }
  
  /// Creates an inline component overload with the specified code for params
  /// and props expression.
  let create paramsCode propsCode =
    {
      ParamsCode = paramsCode
      PropsCode = propsCode
      IsInline = true
    }

  /// Sets whether the overload is inline.
  let setInline isInline (overload: ComponentOverload) =
    { overload with IsInline = isInline }


module Component =

  /// Creates a component with the specified method name and import path, no
  /// documentation, import selector, props, or prop inheritance, and the
  /// default component overload.
  let createImportDefault methodName importPath = {
    DocLines = []
    MethodName = methodName
    Source = ImportPath (importPath, None)
    Overloads = [ComponentOverload.default']
    Props = []
    BaseComponentMethodName = None
  }

  /// Creates a component with the specified method name and import
  /// path/selector, no documentation, props, or prop inheritance, and the
  /// default component overload.
  let createImportSelector methodName importSelector importPath = {
    DocLines = []
    MethodName = methodName
    Source = ImportPath (importPath, Some importSelector)
    Overloads = [ComponentOverload.default']
    Props = []
    BaseComponentMethodName = None
  }

  /// Creates a component with the specified method name and tag, no
  /// documentation, props, or prop inheritance, and the default component
  /// overload.
  let createTag methodName tag = {
    DocLines = []
    MethodName = methodName
    Source = Tag tag
    Overloads = [ComponentOverload.default']
    Props = []
    BaseComponentMethodName = None
  }

  /// Sets the component's doc lines.
  let setDocs docLines (comp: Component) =
    { comp with DocLines = docLines }

  /// Adds the specified overload to the component.
  let addOverload overload comp =
    { comp with Overloads = comp.Overloads @ [overload] }

  /// Adds the specified overloads to the component.
  let addOverloads (overloads: #seq<_>) comp =
    (comp, overloads) ||> Seq.fold (flip addOverload)

  /// Removes the default overload that accepts a list of props.
  let removeDefaultOverload comp =
    { comp with Overloads = comp.Overloads |> List.except [ComponentOverload.default'] }

  /// Adds the specified prop to the component.
  let addProp prop comp =
    { comp with Props = comp.Props @ [prop] }

  /// Adds the specified props to the component.
  let addProps (props: #seq<_>) comp =
    (comp, props) ||> Seq.fold (flip addProp)

  /// Set this component to inherit the props of another component with the
  /// specified MethodName.
  let inheritsPropsFrom baseComponentMethodName comp =
    { comp with BaseComponentMethodName = Some baseComponentMethodName }

  /// Indicates whether all props have only inline overloads.
  let hasOnlyInlineOverloads comp =
    comp.Overloads |> List.forall (fun o -> o.IsInline)

  /// Indicates whether the component has regular (non-enum) props.
  let hasRegularProps comp =
    comp.Props |> List.exists (fun p -> p.RegularOverloads |> List.isEmpty |> not)

  /// Indicates whether the component has enum props.
  let hasEnumProps comp =
    comp.Props |> List.exists (fun p -> p.EnumOverloads |> List.isEmpty |> not)


module ComponentApi =

  /// Creates a component API with the specified namespace and component type
  /// name and no components.
  let create namespace' typeName = {
    Namespace = namespace'
    ParseProps = "createObj !!properties"
    ComponentsPrelude = []
    PropsPrelude = []
    ComponentContainerTypeName = typeName
    Components = []
  }

  /// Adds the specified component to the API.
  let addComponent component' api =
    { api with Components = api.Components @ [component'] }

  /// Adds the specified components to the API.
  let addComponents (components: #seq<_>) api =
    (api, components) ||> Seq.fold (flip addComponent)

  /// Sets the expression used to parse `properties: IReactProperty seq` into a prop
  /// object when creating a component. The default is `createObj !!properties`.
  let setParseProps parsePropsExpr api =
    { api with ParseProps = parsePropsExpr }

  /// Sets the specified components prelude.
  let setComponentsPrelude lines api =
    { api with ComponentsPrelude = lines }

  /// Sets the specified props prelude.
  let setPropsPrelude lines api =
    { api with PropsPrelude = lines }

  /// Sets the specified namespace.
  let withNamespace namespace' api =
    { api with Namespace = namespace' }

  /// Sets the specified container type name.
  let withTypeName typeName api =
    { api with ComponentContainerTypeName = typeName }
