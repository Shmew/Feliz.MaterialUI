module ApiParser

open System
open System.Collections.Generic
open FSharp.Data
open Feliz.Generator
open System.Text.RegularExpressions
open Domain


// TODO: Clean up / refactor / rewrite
let paramListAndObjCreator paramData =
  let toSafeName = kebabCaseToCamelCase >> prefixUnderscoreToNumbers >> appendApostropheToReservedKeywords
  let paramList =
    paramData
    |> List.map (fun (name, fsType, isOptional) ->
        sprintf "%s%s: %s" (if isOptional then "?" else "") (toSafeName name) fsType
    )
    |> String.concat ", "
    |> sprintf "(%s)"
  let objCreator =
    paramData
    |> List.map (fun (name, _, isOptional) ->
        if isOptional then
          sprintf "(if %s.IsSome then x?``%s`` <- %s)" (toSafeName name) name (toSafeName name)
        else
          sprintf "x?``%s`` <- %s" name (toSafeName name)
    )
    |> String.concat "; "
    |> sprintf "(let x = createEmpty<obj> in %s; x)"
  paramList, objCreator


let parseClassRule (row: ComponentApiPage.Css.Row) (rowHtml: HtmlNode) =
  let markdownDocLines =
    rowHtml.CssSelect("td").[2].Elements()
    |> docElementsToMarkdownLines

  {
    DocLines = markdownDocLines
    MethodName = 
      row.``Rule name``
      |> kebabCaseToCamelCase
      |> appendApostropheToReservedKeywords
    RealRuleName = row.``Rule name``
  }


let parseProp componentMethodName (row: ComponentApiPage.Props.Row) (rowHtml: HtmlNode) : Prop =
  let realPropName = row.Name.Trim(' ', '*')
  let propMethodName = realPropName |> kebabCaseToCamelCase |> appendApostropheToReservedKeywords

  let markdownDocLines =
    if propMethodName = "classes" then
      sprintf "Override or extend the styles applied to the component. Use `classes.%s` to specify class names." componentMethodName
      |> List.singleton
    else
      rowHtml.CssSelect("td").[3].Elements()
      |> docElementsToMarkdownLines
  
  let propDocType = row.Type.Trim()


  let isProbablyEnumProp =
    (componentMethodName = "grid" && propMethodName = "spacing")
    || (propDocType.Contains "'"  // There is a string value
        && (propDocType.Contains "|"  // There are multiple values (at least one string per above)
            || (propDocType.StartsWith "'" && propDocType.EndsWith "'")))  // There is a single string value


  let regularOverloads =
    match componentMethodName, propMethodName, propDocType with
    | _, _, "unsupportedProp" ->
        [RegularPropOverload.createCustom "" "UnsupportedProp ()"]
    | "buttonBase", "action", "ref" ->
        [
          RegularPropOverload.create "(ref: IRefValue<ButtonBaseActions option>)" "ref"
          RegularPropOverload.create "(handler: ButtonBaseActions -> unit)" "handler"
        ]

    | "popover", "action", "ref" ->
        [
          RegularPropOverload.create "(ref: IRefValue<PopoverActions option>)" "ref"
          RegularPropOverload.create "(handler: PopoverActions -> unit)" "handler"
        ]

    | "popover", ("anchorOrigin" | "transformOrigin"), "{ horizontal: number | 'left' | 'center' | 'right', vertical: number | 'top' | 'center' | 'bottom' }" ->
        [
          RegularPropOverload.create "(horizontal: PopoverOriginHorizontal, vertical: PopoverOriginVertical)" "(createObj [ \"horizontal\" ==> horizontal; \"vertical\" ==> vertical ])"
          RegularPropOverload.create "(horizontal: int, vertical: PopoverOriginVertical)" "(createObj [ \"horizontal\" ==> horizontal; \"vertical\" ==> vertical ])"
          RegularPropOverload.create "(horizontal: PopoverOriginHorizontal, vertical: int)" "(createObj [ \"horizontal\" ==> horizontal; \"vertical\" ==> vertical ])"
          RegularPropOverload.create "(horizontal: int, vertical: int)" "(createObj [ \"horizontal\" ==> horizontal; \"vertical\" ==> vertical ])"
        ]

    | "tabs", "action", "ref" ->
        [
          RegularPropOverload.create "(ref: IRefValue<TabsActions option>)" "ref"
          RegularPropOverload.create "(handler: TabsActions -> unit)" "handler"
        ]

    | "tablePagination", "rowsPerPageOptions", "array" ->
        [RegularPropOverload.create "([<ParamArray>] values: int [])" "values"]

    | "popover", "anchorPosition",  "{ left: number, top: number }" ->
        [
          [ "left", "int", false
            "top", "int", false ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | "treeView", "defaultExpanded", _ ->
        [RegularPropOverload.create "([<ParamArray>] nodeIds: string [])" "nodeIds"]

    | ("input" | "filledInput" | "outlinedInput" | "inputBase" | "textareaAutosize" | "textField"), ("rows" | "rowsMax"), "string | number" ->
        [RegularPropOverload.create "(value: int)" "value"]

    | ("input" | "filledInput" | "outlinedInput" | "inputBase" | "textField" | "nativeSelect" | "radioGroup"), "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> unit)" "handler"
          RegularPropOverload.create "(handler: string -> unit)" "(fun (e: Event) -> handler e.Value)"
        ]

    | "hidden", "only", "'xs' | 'sm' | 'md' | 'lg' | 'xl' | Array<'xs' | 'sm' | 'md' | 'lg' | 'xl'>" ->
        [RegularPropOverload.create "([<ParamArray>] values: BreakpointKey [])" "values"]

    | "slider", ("value" | "defaultValue"), _ ->
        [
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: float)" "value"
          RegularPropOverload.create "(min: int, max: int)" "(min, max)"
          RegularPropOverload.create "(min: float, max: float)" "(min, max)"
        ]

    | "slider", "marks", "bool | array" ->
        [
          RegularPropOverload.create "(value: bool)" "value"
          RegularPropOverload.create "([<ParamArray>] values: int [])" "(values |> Array.map (fun x -> createObj [ \"value\" ==> x ]))"
          RegularPropOverload.create "([<ParamArray>] values: float [])" "(values |> Array.map (fun x -> createObj [ \"value\" ==> x ]))"
          RegularPropOverload.create "([<ParamArray>] valuesAndLabels: (int * string option) [])" "(valuesAndLabels |> Array.map (fun (v, lb) -> createObj [ \"value\" ==> v; \"label\" ==> lb ]))"
          RegularPropOverload.create "([<ParamArray>] valuesAndLabels: (float * string option) [])" "(valuesAndLabels |> Array.map (fun (v, lb) -> createObj [ \"value\" ==> v; \"label\" ==> lb ]))"
        ]

    | "slider", "valueLabelFormat", _ ->
        [
          RegularPropOverload.create "(value: string)" "value"
          RegularPropOverload.create "(format: int -> int -> string)" "format"
          RegularPropOverload.create "(format: float -> int -> string)" "format"
        ]

    | "rating", "getLabelText", "func" ->
        [
          RegularPropOverload.create "(getText: int -> string)" "getText"
          RegularPropOverload.create "(getText: float -> string)" "getText"
        ]

    | "slider", "getAriaLabel", "func" ->
        [
          RegularPropOverload.create "(getLabel: int -> string)" "getLabel"
        ]

    | "slider", "getAriaValueText", "func" ->
        [
          RegularPropOverload.create "(getText: int -> int -> string)" "getText"
          RegularPropOverload.create "(getText: float -> int -> string)" "getText"
        ]

    | "typography", "variantMapping", "object" ->
        [
          [ "h1", "string", true
            "h2", "string", true
            "h3", "string", true
            "h4", "string", true
            "h5", "string", true
            "h6", "string", true
            "subtitle1", "string", true
            "subtitle2", "string", true
            "body1", "string", true
            "body2", "string", true ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | ("bottomNavigation" | "tabs"), "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> 'a -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: 'a -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "toggleButtonGroup", "value", "any" ->
        [
          RegularPropOverload.create "(value: 'toggleButtonValue option)" "value"
          RegularPropOverload.create "(values: 'toggleButtonValue [])" "values"
        ]

    | "speedDial", "onClose", "func" ->
        [RegularPropOverload.create "(handler: Event -> string -> unit)" "(System.Func<_,_,_> handler)"]

    | ("checkbox" | "formControlLabel" | "switch"), "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> unit)" "handler"
          RegularPropOverload.create "(handler: bool -> unit)" "(fun (e: Event) -> handler e.Checked)"
        ]

    | "expansionPanel", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> bool -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: bool -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "tablePagination", "labelDisplayedRows", "func" ->
        [RegularPropOverload.create "(getLabel: {| from: int; ``to``: int; count: int |} -> ReactElement)" "getLabel"]

    | "rating", ("onChange" | "onChangeActive"), "func"
    | "slider", ("onChange" | "onChangeCommitted"), "func" ->
        [
          RegularPropOverload.create "(handler: Event -> int -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: Event -> float -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: int -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
          RegularPropOverload.create "(handler: float -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "select", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> ReactElement -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: 'a -> unit)" "(System.Func<_,_,_> (fun (e: Event) _ -> handler !!e.Value))"
        ]

    | "tablePagination", "onChangePage", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> int -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: int -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "toggleButtonGroup", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> 'a -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: 'a -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "slider", "step", "number" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: float)" "value"
          RegularPropOverload.create "(value: int option)" "value"
          RegularPropOverload.create "(value: float option)" "value" |> RegularPropOverload.setExtension true
        ]

    | "select", "renderValue", "func" ->
        [RegularPropOverload.create "(render: 'a -> ReactElement)" "render"]

    | _, _, "any" when markdownDocLines |> List.exists (fun s -> s.Contains "The DOM API casts this to a string") ->
        [RegularPropOverload.create "(value: string)" "value"]

    | "circularProgress", "size", "number | string"
    | "skeleton", ("height" | "width"), "number | string" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: Styles.ICssUnit)" "value"
        ]

    | "collapse", "collapsedHeight", "string" ->
        [RegularPropOverload.create "(value: Styles.ICssUnit)" "value"]

    | "dialog", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> DialogCloseReason -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: DialogCloseReason -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "menu", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> MenuCloseReason -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: MenuCloseReason -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "modal", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> ModalCloseReason -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: ModalCloseReason -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "popover", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> PopoverCloseReason -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: PopoverCloseReason -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "snackbar", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> SnackbarCloseReason -> unit)" "(System.Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: SnackbarCloseReason -> unit)" "(System.Func<_,_,_> (fun _ v -> handler v))"
        ]

    | ("modal" | "portal"), "onRendered", "func" ->
        []  // deprecated

    | ("dialog" | "menu" | "popover" | "snackbar"), ("onEnter" | "onEntered" | "onEntering"), "func" ->
        [RegularPropOverload.create "(handler: ReactElement -> bool -> unit)" "handler"]

    | ("dialog" | "menu" | "popover" | "snackbar"), ("onExit" | "onExited" | "onExiting"), "func" ->
        [RegularPropOverload.create "(handler: ReactElement -> unit)" "handler"]

    | "snackbar", "autoHideDuration", "number" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: int option)" "value"
        ]

    | "treeView", "onNodeToggle", "func" ->
        [RegularPropOverload.create "(handler: string -> bool -> unit)" "handler"]

    | _, "transitionDuration", "number | { appear?: number, enter?: number, exit?: number }" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          [ "appear", "int", true
            "enter", "int", true;
            "exit", "int", true ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | _, ("transitionDuration" | "timeout"), ("number | { enter?: number, exit?: number }" | "number | { enter?: number, exit?: number } | 'auto'") ->
        [
          RegularPropOverload.create "(value: int)" "value"
          [ "enter", "int", true;
            "exit", "int", true ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | _, "anchorEl", "object | func" ->
        [
          RegularPropOverload.create "(value: Element option)" "value"
          RegularPropOverload.create "(handler: unit -> Element option)" "handler"
          RegularPropOverload.create "(ref: IRefValue<Element option>)" "(fun () -> ref.current)"
        ]

    | "popover", "getContentAnchorEl", "func" ->
      [
        RegularPropOverload.create "(handler: Element option -> unit)" "handler"
      ]

    | ("modal" | "popover" | "popper" | "portal"), "container", ("object | func" | "func | React.Component | Element") ->
        [
          RegularPropOverload.create "(element: Element option)" "element"
          RegularPropOverload.create "(element: ReactElement option)" "element"
          RegularPropOverload.create "(getElement: unit -> Element option)" "getElement"
          RegularPropOverload.create "(getElement: unit -> ReactElement option)" "getElement"
        ]

    | "popper", ("modifiers" | "popperOptions"), "object" ->
        [RegularPropOverload.create "(value: 'a)" "value"]

    | _, "component'", ("elementType" | "element type")
    | ("filledInput" | "input" | "inputBase"), "inputComponent", "elementType" ->
        [
          RegularPropOverload.create "(value: string)" "value"
          RegularPropOverload.create "(value: ReactElementType)" "value"
        ]

    | _, pn, ("elementType" | "element type") when pn.EndsWith "Component" ->
        [RegularPropOverload.create "(value: ReactElementType)" "value"]

    | ("checkbox" | "filledInput" | "formControlLabel" | "input" | "inputBase" | "outlinedInput" | "radio" | "switch" | "textField"), "inputRef", "ref" ->
        [
          RegularPropOverload.create "(ref: IRefValue<Element option>)" "ref"
          RegularPropOverload.create "(handler: Element -> unit)" "handler"
        ]

    | "buttonBase", "buttonRef", "ref" ->
        [
          RegularPropOverload.create "(ref: IRefValue<Element option>)" "ref"
          RegularPropOverload.create "(handler: Element -> unit)" "handler"
        ]

    | "popper", "popperRef", "ref"
    | "rootRef", "rootRef", "refType.isRequired" ->
        [
          RegularPropOverload.create "(ref: IRefValue<Element option>)" "ref"
          RegularPropOverload.create "(handler: Element -> unit)" "handler"
        ]

    | _, pn, ("object" | "{ component?: element type }") when pn.EndsWith "Props" ->
        [RegularPropOverload.create "(props: IReactProperty list)" "(createObj !!props)"]

    | _, pn, "object" when pn.EndsWith "Classes" ->
        let otherComponentName = pn.Substring(0, pn.Length - 7)
        [RegularPropOverload.create (sprintf "(classNames: classes.I%sClasses list)" otherComponentName) "(createObj !!classNames)"]

    | _, _, "bool" ->
        [RegularPropOverload.create "(value: bool)" "value"]

    | _, _, "string" ->
        [RegularPropOverload.create "(value: string)" "value"]

    | "swipeableDrawer", "hysteresis", "number" ->
        [RegularPropOverload.create "(value: float)" "value"]

    | "gridList", "cellHeight", "number | 'auto'"
    | _, _, "number" ->
        [RegularPropOverload.create "(value: int)" "value"]

    | _, pn, "func" when pn.StartsWith "on" ->
        [RegularPropOverload.create "(handler: Event -> unit)" "handler"]

    | _, pn, "node" when pn = "icon" || pn.EndsWith "Icon" ->
        [RegularPropOverload.create "(element: ReactElement)" "element"]

    | ("filledInput" | "input" | "inputBase" | "outlinedInput"), ("startAdornment" | "endAdornment"), "node" ->
        [RegularPropOverload.create "(element: ReactElement)" "element"]

    | ("formControl" | "tableRow"), "children", "node" ->
        [
          RegularPropOverload.createCustom "(element: ReactElement)" "prop.children element"
          RegularPropOverload.createCustom "(elements: ReactElement seq)" "prop.children elements"
        ]

    | "stepper", "children", "node" ->
        [RegularPropOverload.createCustom "(elements: ReactElement seq)" "prop.children elements"]

    | _, "children", "node"
    | "popper", "children", "node | func" ->  // TODO: popper.children can also be a func, but can't find signature docs
        [
          RegularPropOverload.createCustom "(element: ReactElement)" "prop.children element"
          RegularPropOverload.createCustom "(elements: ReactElement seq)" "prop.children elements"
          RegularPropOverload.create "(value: string)" "value"
          RegularPropOverload.create "(values: string seq)" "values"
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: float)" "value"
        ]

    | _, _, "node" ->
        [
          RegularPropOverload.create "(value: ReactElement)" "value"
          RegularPropOverload.create "(values: ReactElement seq)" "values"
          RegularPropOverload.create "(value: string)" "value"
          RegularPropOverload.create "(values: string seq)" "values"
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: float)" "value"
        ]

    | _, _, "element" ->
        [RegularPropOverload.create "(value: ReactElement)" "value"]

    | _, _, "any" ->
        [RegularPropOverload.create "(value: 'a)" "value"]

    | _, "classes", _ ->
        [
          RegularPropOverload.create
            (sprintf "(classNames: classes.I%sClasses list)" (String.upperFirst componentMethodName))
            "(createObj !!classNames)"
        ]

    | _ when isProbablyEnumProp ->
        []

    | _ ->
        [RegularPropOverload.create "(value: TODO)" "value"]


  let enumOverloads =

    if not isProbablyEnumProp then []
    else
      match componentMethodName, propMethodName, propDocType with
      | "hidden", "only", "'xs' | 'sm' | 'md' | 'lg' | 'xl' | Array<'xs' | 'sm' | 'md' | 'lg' | 'xl'>" ->
          [
            EnumPropOverload.create "xs" "\"xs\""
            EnumPropOverload.create "sm" "\"sm\""
            EnumPropOverload.create "md" "\"md\""
            EnumPropOverload.create "lg" "\"lg\""
            EnumPropOverload.create "xl" "\"xl\""
          ]

      | "snackbar", "anchorOrigin", "{ horizontal: 'left' | 'center' | 'right', vertical: 'top' | 'bottom' }" ->
          [
            EnumPropOverload.create "topLeft" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "topCenter" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"center\" ])"
            EnumPropOverload.create "topRight" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"right\" ])"
            EnumPropOverload.create "bottomLeft" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "bottomCenter" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"center\" ])"
            EnumPropOverload.create "bottomRight" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"right\" ])"
          ]

      | "popover", ("anchorOrigin" | "transformOrigin"), "{ horizontal: number | 'left' | 'center' | 'right', vertical: number | 'top' | 'center' | 'bottom' }" ->
          [
            EnumPropOverload.create "topLeft" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "topCenter" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"center\" ])"
            EnumPropOverload.create "topRight" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"right\" ])"
            EnumPropOverload.create "centerLeft" "(createObj [ \"vertical\" ==> \"center\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "centerCenter" "(createObj [ \"vertical\" ==> \"center\"; \"horizontal\" ==> \"center\" ])"
            EnumPropOverload.create "centerRight" "(createObj [ \"vertical\" ==> \"center\"; \"horizontal\" ==> \"right\" ])"
            EnumPropOverload.create "bottomLeft" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "bottomCenter" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"center\" ])"
            EnumPropOverload.create "bottomRight" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"right\" ])"
          ]

      | "badge", "anchorOrigin", "{ horizontal: 'left' | 'right', vertical: 'bottom' | 'top' }" ->
          [
            EnumPropOverload.create "topLeft" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "topRight" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"right\" ])"
            EnumPropOverload.create "bottomLeft" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "bottomRight" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"right\" ])"
          ]

      | _ ->
        let enumValueExpressions =
          propDocType.Split("|")
          |> Array.toList
          |> List.choose (fun s -> 
              let value = s.Trim()
              if value.StartsWith "'" && value.EndsWith "'" then
                // String
                value.Replace("'", "\"") |> Some
              elif value = "number" || value.Contains "{" then None
              else
                // Probably literal, e.g. bool or int
                Some value
          )
        
        enumValueExpressions
        |> List.map (fun v ->
            let methodName = 
              v.Trim('"')
              |> kebabCaseToCamelCase
              |> prefixUnderscoreToNumbers
              |> appendApostropheToReservedKeywords
            EnumPropOverload.create methodName v
        )


  let addRegularOverloads prop =
    (prop, regularOverloads) ||> Seq.fold (flip Prop.addRegularOverload)

  let addEnumOverloads prop =
    (prop, enumOverloads) ||> Seq.fold (flip Prop.addEnumOverload)

  let globalDocTransform (s: string) =
    s.Replace(" It supports those theme colors that make sense for this component.", "")
     .Replace(" You may specify a single timeout for all transitions, or individually with an object.", "")
     .Replace("event.target.value", "event.Value")
     .Replace(" The DOM API casts this to a string.", "")

  let propSpecifiDocTransform (s: string) =
    match componentMethodName, propMethodName with
    | "nativeSelect", "children" ->
        s.Replace("Can be some `` elements.", "Can be some `<option>` elements.")
    | "stepper", "children" ->
        s.Replace("Two or more `` components.", "Two or more `<Step />` components.")
    | "tableRow", "children" ->
        s.Replace("Should be valid | children", "Should be valid `<tr>` children")
         .Replace("|  |", "")
    | _ -> s

  let transformedMarkdownDocLines =
    markdownDocLines
    |> List.map globalDocTransform
    |> List.map propSpecifiDocTransform
    |> List.trimEmptyLines

  Prop.create realPropName propMethodName
  |> Prop.setDocs transformedMarkdownDocLines
  |> addRegularOverloads
  |> addEnumOverloads


let parseComponent (htmlPathOrUrl: string) =

    Console.WriteLine(sprintf "Processing component %s" htmlPathOrUrl)

    let page = ComponentApiPage.Load(htmlPathOrUrl)
    let html = page.Html

    let importMatches = Regex.Match(html.CssSelect("pre").[0].InnerText(), "import (.+) from'(.+?)'")
    let compMethodName = importMatches.Groups.[1].Value |> String.lowerFirst
    let importPath = importMatches.Groups.[2].Value

    let noteNodes1 =
      html.CssSelect(".markdown-body").[0].Elements()
      |> List.skipWhile (fun n -> n.Name() <> "table")
      |> List.trySkip 1
      |> List.takeWhile (fun n -> n.Name() = "p")

    let noteNodes2 =
      html.CssSelect(".markdown-body").[0].Elements()
      |> List.skipWhile (fun n -> n.Name() <> "h2" || n.InnerText() <> "Notes")
      |> List.trySkip 1
      |> List.takeWhile (fun n -> n.Name() = "p")
    
    let markdownDocLines = noteNodes1 @ noteNodes2 |> docElementsToMarkdownLines

    let additionalOverloads =
      match compMethodName with
      | "dialogContentText"
      | "dialogTitle"
      | "formHelperText"
      | "formLabel"
      | "inputLabel"
      | "listSubheader"
      | "stepLabel"
      | "tableCell"
      | "typography" ->
          [ComponentOverload.create "(text: string)" "[ prop.children (Html.text text) ]"]
      | "icon" ->
          [ComponentOverload.create "(name: string)" "[ prop.children (Html.text name) ]"]
      | "listItemText" ->
          [ComponentOverload.create "(primary: string)" "[ listItemText.primary primary ]"]
      | _ ->
          []

    let addAdditionalOverloads comp =
      (comp, additionalOverloads) ||> List.fold (flip Component.addOverload)

    let props =
      page.Tables.Props.Rows
      |> Array.mapi (fun i r ->
          let rowHtml = page.Tables.Props.Html.CssSelect("tbody > tr").[i]
          parseProp compMethodName r rowHtml
      )
      |> Array.filter (fun p -> not (p.RegularOverloads.IsEmpty && p.EnumOverloads.IsEmpty))

    let addProps comp =
      (comp, props) ||> Array.fold (flip Component.addProp)

    // Some components are currently missing children from the props listing
    // https://github.com/mui-org/material-ui/issues/17674#issuecomment-537880347
    let addMissingChildrenProp (comp: Component) =
      let hasChildren = comp.Props |> List.exists (fun p -> p.MethodName = "children")
      match comp.MethodName with
      | "card" | "cardContent" | "swipeableDrawer" when not hasChildren ->
          let prop =
            Prop.create "children" "children"
            |> Prop.setDocs ["The content of the component."]
            |> Prop.addRegularOverload (RegularPropOverload.createCustom "(element: ReactElement)" "prop.children element")
            |> Prop.addRegularOverload (RegularPropOverload.createCustom "(elements: ReactElement seq)" "prop.children elements")
            |> Prop.addRegularOverload (RegularPropOverload.create "(value: string)" "value")
            |> Prop.addRegularOverload (RegularPropOverload.create "(values: string seq)" "values")
            |> Prop.addRegularOverload (RegularPropOverload.create "(value: int)" "value")
            |> Prop.addRegularOverload (RegularPropOverload.create "(value: float)" "value")
          comp |> Component.addProp prop
      | _ -> comp

    let addChildrenOverloadIfSupported (comp: Component) =
      let hasReactElementSeqChildren = 
        comp.Props
        |> List.exists (fun p -> 
            p.MethodName = "children"
            && p.RegularOverloads |> List.exists (fun o -> o.ParamsCode = "(elements: ReactElement seq)")
        )
      if not hasReactElementSeqChildren then comp
      else
        // Use #seq<ReactElement> to help overload resolution when using empty lists
        let overload = ComponentOverload.create "(children: #seq<ReactElement>)" (sprintf "[ Feliz.MaterialUI.%s.children (children :> ReactElement seq) ]" comp.MethodName)
        comp |> Component.addOverload overload


    let addUnsupportedChildrenProp (comp: Component) =
      let hasChildren = comp.Props |> List.exists (fun p -> p.MethodName = "children")
      if hasChildren then comp
      else
        let prop =
          Prop.create "children" "children"
          |> Prop.setDocs ["This component does not support children."]
          |> Prop.addRegularOverload (RegularPropOverload.createCustom "" "UnsupportedProp ()")
        comp |> Component.addProp prop


    let stylesheetName =
      Regex.Match(page.Html.Body().ToString(), "Style sheet name:\s*\<code\>(.+?)\<\/code\>")
        .Groups.[1].Value
      |> Some
      |> Option.filter (not << String.IsNullOrEmpty)

    let setInheritance =
      let inheritFrom =
        Regex.Match(page.Html.Body().InnerText(), "Any other props supplied will be provided to the root element \((.+?)\)")
          .Groups.[1].Value
      match compMethodName, inheritFrom with
      | _, (null | "") -> id
      | ("collapse" | "fade" | "grow" | "slide" | "zoom"), "Transition" -> 
          id  // The Transition component is from an external library
      | _, ("native component" | "native element") ->
          id  // Native DOM inheritance not currently supported
      | _, baseComp -> baseComp |> String.lowerFirst |> Component.inheritsPropsFrom

    {
      GeneratorComponent =
        Component.create compMethodName importPath
        |> Component.setDocs markdownDocLines
        |> addAdditionalOverloads
        |> addProps
        |> addMissingChildrenProp
        |> addChildrenOverloadIfSupported
        |> addUnsupportedChildrenProp
        |> setInheritance
      ClassRules =
        let rowsAndHtml =
          try 
            page.Tables.CSS.Rows
            |> Array.mapi (fun i r ->
                r, page.Tables.CSS.Html.CssSelect("tbody > tr").[i]
            )
            |> Array.toList
          with :? KeyNotFoundException -> []
        rowsAndHtml |> List.map (fun (r, html) -> parseClassRule r html)
      StylesheetName = stylesheetName
    }


let parseApi () =

  let components =
    HtmlCache.getFiles ()
    |> Array.Parallel.map parseComponent
    |> Array.toList

  let addAllComponents api =
    (api, (components |> List.map (fun c -> c.GeneratorComponent)))
    ||> List.fold (flip ComponentApi.addComponent)

  let muiThemeProvider =
    Component.create "muiThemeProvider" "@material-ui/core/styles/MuiThemeProvider"
    |> Component.addProp (
        Prop.create "children" "children"
        |> Prop.setDocs ["Your component tree."]
        |> Prop.addRegularOverload (
            RegularPropOverload.createCustom "(elements: ReactElement seq)" "prop.children elements"
        )
    )
    |> Component.addProp (
      Prop.create "theme" "theme"
      |> Prop.setDocs ["A theme object. You can provide a function to extend the outer theme."]
      |> Prop.addRegularOverload (RegularPropOverload.create "(theme: Theme)" "theme")
      |> Prop.addRegularOverload (RegularPropOverload.create "(extendTheme: Theme -> Theme)" "extendTheme")
    )


  let api =
    ComponentApi.create "Feliz.MaterialUI" "Mui"
    |> ComponentApi.addComponent muiThemeProvider
    |> addAllComponents

  {
    GeneratorComponentApi = api
    MuiComponents = components
  }
