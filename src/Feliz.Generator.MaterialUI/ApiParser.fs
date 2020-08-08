module ApiParser

open System
open System.Collections.Generic
open FSharp.Data
open Feliz.Generator
open System.Text.RegularExpressions
open Domain


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
      |> trimStart '@'
      |> appendApostropheToReservedKeywords
    RealRuleName = row.``Rule name``
  }


let parseProp componentMethodName (row: ComponentApiPage.Props.Row) (rowHtml: HtmlNode) : Prop =
  let isRequired = row.Name.EndsWith "*"
  let realPropName = row.Name.Trim(' ', '*')
  let propMethodName = realPropName |> kebabCaseToCamelCase |> appendApostropheToReservedKeywords

  let markdownDocLines =
    if propMethodName = "classes" then
      ["Override or extend the styles applied to the component."]
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

    | "alert", "iconMapping", "{ error?: node, info?: node, success?: node, warning?: node }" ->
        [
          [ "error", "ReactElement", true
            "info", "ReactElement", true
            "success", "ReactElement", true
            "warning", "ReactElement", true ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | "buttonBase", "action", "ref" ->
        [
          RegularPropOverload.create "(ref: IRefValue<ButtonBaseActions option>)" "ref"
          RegularPropOverload.create "(handler: ButtonBaseActions -> unit)" "handler"
        ]

    | "buttonBase", "type'", _ ->
        // https://github.com/mui-org/material-ui/issues/21924
        //
        // If documented, it's just to specify the default value; the corresponding Feliz
        // prop (prop.type') should be used
        []

    | "popover", "action", "ref" ->
        [
          RegularPropOverload.create "(ref: IRefValue<PopoverActions option>)" "ref"
          RegularPropOverload.create "(handler: PopoverActions -> unit)" "handler"
        ]

    | "popover", ("anchorOrigin" | "transformOrigin"), "{ horizontal: 'center' | 'left' | 'right' | number, vertical: 'bottom' | 'center' | 'top' | number }" ->
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

    | "accordion", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> bool -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: bool -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "autocomplete", "filterOptions", "func" ->
        [
          RegularPropOverload.create "(filterOptions: 'option [] -> string -> 'option [])" "(Func<_,_,_> (fun opts (s: AutocompleteFilterOptionsState) -> filterOptions opts s.inputValue))"
          RegularPropOverload.create "(filterOptions: 'option [] -> AutocompleteFilterOptionsState -> 'option [])" "(Func<_,_,_> filterOptions)"
        ]

    | "autocomplete", "getOptionDisabled", "func" ->
        [RegularPropOverload.create "(isDisabled: 'option -> bool)" "isDisabled"]

    | "autocomplete", "getOptionLabel", "func" ->
        [RegularPropOverload.create "(getLabel: 'option -> string)" "getLabel"]

    | "autocomplete", "getOptionSelected", "func" ->
        [RegularPropOverload.create "(getSelected: 'option -> 'a -> bool)" "(Func<_,_,_> getSelected)"]

    | "autocomplete", "getLimitTagsText", "func" ->
        [RegularPropOverload.create "(getText: int -> ReactElement)" "getText"]

    | "autocomplete", "groupBy", "func" ->
        [RegularPropOverload.create "(getGroup: 'option -> string)" "getGroup"]

    | "autocomplete", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> 'option -> AutocompleteOnChangeReason -> unit)" "(Func<_,_,_,_> handler)"
          |> RegularPropOverload.setExtension true
          RegularPropOverload.create "(handler: 'option -> unit)" "(Func<_,_,_,_> (fun _ v _ -> handler v))"
          |> RegularPropOverload.setExtension true

          RegularPropOverload.create "(handler: Event -> 'option [] -> AutocompleteOnChangeReason -> unit)" "(Func<_,_,_,_> handler)"
          RegularPropOverload.create "(handler: 'option [] -> unit)" "(Func<_,_,_,_> (fun _ v _ -> handler v))"

          RegularPropOverload.create "(handler: Event -> 'option option -> AutocompleteOnChangeReason -> unit)" "(Func<_,_,_,_> handler)"
          RegularPropOverload.create "(handler: 'option option -> unit)" "(Func<_,_,_,_> (fun _ v _ -> handler v))"
        ]

    | "autocomplete", "onInputChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> string -> AutocompleteInputChangeReason -> unit)" "(Func<_,_,_,_> handler)"
          RegularPropOverload.create "(handler: string -> unit)" "(Func<_,_,_,_> (fun _ v _ -> handler v))"
        ]

    | "autocomplete", "onHighlightChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> 'option -> AutocompleteHighlightChangeReason -> unit)" "(Func<_,_,_,_> handler)"
          RegularPropOverload.create "(handler: 'option -> AutocompleteHighlightChangeReason -> unit)" "(Func<_,_,_,_> (fun _ o r -> handler o r))"
          RegularPropOverload.create "(handler: 'option -> unit)" "(Func<_,_,_,_> (fun _ o _ -> handler o))"
        ]

    | "autocomplete", "options", "array" ->
        [RegularPropOverload.create "(options: 'option [])" "options"]

    | "autocomplete", "renderGroup", "func" ->
        [RegularPropOverload.create "(render: AutocompleteRenderGroupParams -> ReactElement)" "render"]

    | "autocomplete", "renderInput", "func" ->
        [RegularPropOverload.create "(render: AutocompleteRenderInputParams -> ReactElement)" "render"]

    | "autocomplete", "renderOption", "func" ->
        [RegularPropOverload.create "(render: 'option -> AutocompleteRenderOptionState -> ReactElement)" "(Func<_,_,_> render)"]

    | "autocomplete", "renderTags", "func" ->
        [RegularPropOverload.create "(render: 'option [] -> AutocompleteRenderValueState -> ReactElement)" "(Func<_,_,_> render)"]

    | "autocomplete", ("defaultValue" | "value"), "any" ->
        [
          RegularPropOverload.create "(value: 'option [])" "value"
          RegularPropOverload.create "(value: 'option option)" "value"
          RegularPropOverload.create "(value: 'option)" "value" |> RegularPropOverload.setExtension true
        ]

    | "popover", "anchorPosition",  "{ left: number, top: number }" ->
        [
          [ "left", "int", false
            "top", "int", false ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | "treeView", ("expanded" | "defaultExpanded"), "Array<string>" ->
        [RegularPropOverload.create "([<ParamArray>] nodeIds: string [])" "nodeIds"]

    | "inputBase", "onBlur", "func" ->
        [RegularPropOverload.create "(handler: Event option -> unit)" "handler"]

    | ("input" | "filledInput" | "outlinedInput" | "inputBase" | "textareaAutosize" | "textField"), ("rows" | "rowsMax" | "rowsMin"), "number | string" ->
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

    | "slider", "scale", "func" ->
      [
        RegularPropOverload.create "(transform: int -> int)" "transform"
        RegularPropOverload.create "(transform: float -> float)" "transform"
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
          RegularPropOverload.create "(handler: Event -> 'a -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: 'a -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "toggleButtonGroup", "value", "any" ->
        [
          RegularPropOverload.create "(value: 'toggleButtonValue option)" "value"
          RegularPropOverload.create "(values: 'toggleButtonValue [])" "values"
        ]

    | ("checkbox" | "formControlLabel" | "switch"), "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> unit)" "handler"
          RegularPropOverload.create "(handler: bool -> unit)" "(fun (e: Event) -> handler e.Checked)"
        ]

    | "expansionPanel", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> bool -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: bool -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "tablePagination", "labelDisplayedRows", "func" ->
        [RegularPropOverload.create "(getLabel: {| from: int; ``to``: int; count: int |} -> ReactElement)" "getLabel"]

    | "slider", ("onChange" | "onChangeCommitted"), "func" ->
        [
          RegularPropOverload.create "(handler: Event -> int -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: Event -> float -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: int -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
          RegularPropOverload.create "(handler: float -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
          RegularPropOverload.create "(handler: Event -> int [] -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: Event -> float [] -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: int [] -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
          RegularPropOverload.create "(handler: float [] -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "rating", ("onChange" | "onChangeActive"), "func" ->
        [
          RegularPropOverload.create "(handler: Event -> int -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: Event -> float -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: int -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
          RegularPropOverload.create "(handler: float -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "rating", ("defaultValue" | "max" | "precision" | "value"), "number" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: float)" "value"
        ]

    | "radioGroup", "defaultValue", "Array<string> | number | string" ->
        [
          // TODO: Should this accept arrays, too? Or is that just an artifact of the way
          // the MUI docs are generated?
          RegularPropOverload.create "(value: 'a)" "value"
        ]

    | "select", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> ReactElement -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: 'a -> unit)" "(Func<_,_,_> (fun (e: Event) _ -> handler !!e.Value))"
        ]

    | "tablePagination", "onChangePage", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> int -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: int -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "toggleButtonGroup", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> 'a -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: 'a -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "slider", "step", "number" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: float)" "value"
          RegularPropOverload.create "(value: int option)" "value"
          RegularPropOverload.create "(value: float option)" "value" |> RegularPropOverload.setExtension true
        ]

    | "select", "renderValue", "func" ->
        [
          RegularPropOverload.create "(render: 'a -> ReactElement)" "render"
          RegularPropOverload.create "(render: 'a -> ReactElement seq)" "render"
          RegularPropOverload.create "(render: 'a -> string)" "render"
          RegularPropOverload.create "(render: 'a -> string seq)" "render"
          RegularPropOverload.create "(render: 'a -> int)" "render"
          RegularPropOverload.create "(render: 'a -> float)" "render"
        ]

    | _, _, "any" when markdownDocLines |> List.exists (fun s -> s.Contains "The DOM API casts this to a string") ->
        [RegularPropOverload.create "(value: string)" "value"]

    | "circularProgress", "size", "number | string"
    | "skeleton", ("height" | "width"), "number | string" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: Styles.ICssUnit)" "value"
        ]

    | "collapse", "collapsedHeight", "number | string" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          RegularPropOverload.create "(value: Styles.ICssUnit)" "value"
        ]

    | "dialog", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> DialogCloseReason -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: DialogCloseReason -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "menu", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> MenuCloseReason -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: MenuCloseReason -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "modal", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> ModalCloseReason -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: ModalCloseReason -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "popover", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> PopoverCloseReason -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: PopoverCloseReason -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "snackbar", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> SnackbarCloseReason -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: SnackbarCloseReason -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "speedDial", "onClose", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> SpeedDialCloseReason -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: SpeedDialCloseReason -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
        ]

    | "speedDial", "onOpen", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> SpeedDialOpenReason -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: SpeedDialOpenReason -> unit)" "(Func<_,_,_> (fun _ v -> handler v))"
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
        [RegularPropOverload.create "(handler: Event -> string [] -> unit)" "handler"]

    | "treeView", ("defaultSelected" | "selected"), "Array<string> | string" ->
      [
        RegularPropOverload.create "(value: string)" "value"
        RegularPropOverload.create "([<ParamArray>] values: string [])" "values"
      ]

    | "treeView", "onNodeSelect", "func" ->
      [
        RegularPropOverload.create "(handler: Event -> string -> unit)" "(Func<_,_,_> handler)"
        RegularPropOverload.create "(handler: Event -> string [] -> unit)" "(Func<_,_,_> handler)"
      ]

    | _, "transitionDuration", "number | { enter?: number, exit?: number }" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          [ "enter", "int", true
            "exit", "int", true ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | _, "transitionDuration", "number | { appear?: number, enter?: number, exit?: number }" ->
        [
          RegularPropOverload.create "(value: int)" "value"
          [ "appear", "int", true
            "enter", "int", true
            "exit", "int", true ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | _, ("transitionDuration" | "timeout"), ("'auto' | number | { appear?: number, enter?: number, exit?: number }" | "number | { appear?: number, enter?: number, exit?: number }") ->
        [
          RegularPropOverload.create "(value: int)" "value"
          [ "appear", "int", true
            "enter", "int", true
            "exit", "int", true ]
          |> paramListAndObjCreator
          ||> RegularPropOverload.create
        ]

    | "popper", "anchorEl", ("HTML element | object | func") ->
        [
          RegularPropOverload.create "(value: Element option)" "value"
          RegularPropOverload.create "(getElement: unit -> Element option)" "getElement"
          RegularPropOverload.create "(referenceObject: obj)" "referenceObject"
          RegularPropOverload.create "(getReferenceObject: unit -> obj)" "getReferenceObject"
          RegularPropOverload.create "(ref: IRefValue<Element option>)" "(fun () -> ref.current)"
        ]

    | _, "anchorEl", ("HTML element | func") ->
        [
          RegularPropOverload.create "(value: Element option)" "value"
          RegularPropOverload.create "(getElement: unit -> Element option)" "getElement"
          RegularPropOverload.create "(ref: IRefValue<Element option>)" "(fun () -> ref.current)"
        ]

    | "popover", "getContentAnchorEl", "func" ->
      [
        RegularPropOverload.create "(handler: Element option -> unit)" "handler"
      ]

    | ("modal" | "popover" | "popper" | "portal"), "container", ("HTML element | React.Component | func") ->
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

    | "pagination", "getItemAriaLabel", "func" ->
        [
          RegularPropOverload.create "(getLabel: string -> int -> bool -> string)" "(Func<_,_,_,_> (fun t p s -> getLabel t p s))"
        ]

    | "pagination", "onChange", "func" ->
        [
          RegularPropOverload.create "(handler: Event -> int -> unit)" "(Func<_,_,_> handler)"
          RegularPropOverload.create "(handler: int -> unit)" "(Func<_,_> (fun _ p -> handler p))"
        ]

    | "pagination", "renderItem", "func" ->
        [
          RegularPropOverload.create "(render: PaginationRenderItemParams -> ReactElement)" "(Func<_,_> (fun p -> render p))"
        ]

    | "unstable_TrapFocus", "getDoc", "func" ->
        [RegularPropOverload.create "(getDoc: unit -> Document)" "getDoc"]

    | "unstable_TrapFocus", "isEnabled", "func" ->
        [RegularPropOverload.create "(isEnabled: unit -> bool)" "isEnabled"]

    | _, pn, ("object" | "{ component?: element type }") when pn.EndsWith "Props" ->
        [RegularPropOverload.create "(props: IReactProperty list)" "(createObj !!props)"]

    | _, pn, "object" when pn = "classes" || pn.EndsWith "Classes" ->
        []

    | _, _, t when t = "bool" || t.Split('|') |> Array.map String.trim |> Array.contains "bool" ->
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
    | "tabList", "children", "Array<element>"
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

      | "snackbar", "anchorOrigin", "{ horizontal: 'center' | 'left' | 'right', vertical: 'bottom' | 'top' }" ->
          [
            EnumPropOverload.create "topLeft" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "topCenter" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"center\" ])"
            EnumPropOverload.create "topRight" "(createObj [ \"vertical\" ==> \"top\"; \"horizontal\" ==> \"right\" ])"
            EnumPropOverload.create "bottomLeft" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"left\" ])"
            EnumPropOverload.create "bottomCenter" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"center\" ])"
            EnumPropOverload.create "bottomRight" "(createObj [ \"vertical\" ==> \"bottom\"; \"horizontal\" ==> \"right\" ])"
          ]

      | "popover", ("anchorOrigin" | "transformOrigin"), "{ horizontal: 'center' | 'left' | 'right' | number, vertical: 'bottom' | 'center' | 'top' | number }" ->
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
              elif value = "number" || value = "bool" || value.Contains "{" then None
              else
                // Probably literal, e.g. bool or int
                Some value
          )

        let overloads =
          enumValueExpressions
          |> List.map (fun v ->
              let methodName = 
                v.Trim('"')
                |> kebabCaseToCamelCase
                |> prefixUnderscoreToNumbers
                |> appendApostropheToReservedKeywords
              EnumPropOverload.create methodName v
          )
        if overloads.IsEmpty then failwithf "No enum overloads for %s.%s" componentMethodName propMethodName
        overloads

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
    | "formHelperText", "children" ->
        s.Replace("If `''` is provided", "If `' '` is provided")
    | _ -> s

  let transformedMarkdownDocLines =
    markdownDocLines
    |> List.map globalDocTransform
    |> List.map propSpecifiDocTransform
    |> List.trimEmptyLines

  Prop.create realPropName propMethodName
  |> Prop.setDocs transformedMarkdownDocLines
  |> Prop.setRequired isRequired
  |> Prop.addRegularOverloads regularOverloads
  |> Prop.addEnumOverloads enumOverloads


let parseComponent (htmlPathOrUrl: string) =

    Console.WriteLine(sprintf "Processing component %s" htmlPathOrUrl)

    let page = ComponentApiPage.Load(htmlPathOrUrl)
    let html = page.Html

    let importMatches = Regex.Match(html.CssSelect("pre").[0].InnerText(), "import (.+?) from'(.+?)'")
    let compMethodName = importMatches.Groups.[1].Value |> String.lowerFirst
    let importPath = importMatches.Groups.[2].Value

    let noteNodes1 =
      html.CssSelect(".markdown-body").[1].Elements()
      |> List.skipWhile (fun n -> n.Name() <> "table")
      |> List.trySkip 1
      |> List.takeWhile (fun n -> n.Name() = "p")

    let noteNodes2 =
      html.CssSelect(".markdown-body").[1].Elements()
      |> List.skipWhile (fun n -> n.Name() <> "h2" || n.InnerText() <> "Notes")
      |> List.trySkip 1
      |> List.takeWhile (fun n -> n.Name() = "p")
    
    let markdownDocLines =
      noteNodes1 @ noteNodes2
      |> docElementsToMarkdownLines
      |> fun ls ->
          if importPath.StartsWith "@material-ui/lab" then
            "**This is an experimental component from @material-ui/lab. Breaking changes may occur at any time.**" :: "" :: ls
          else ls

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

    let props =
      page.Tables.Props.Rows
      |> Array.mapi (fun i r ->
          let rowHtml = page.Tables.Props.Html.CssSelect("tbody > tr").[i]
          parseProp compMethodName r rowHtml
      )

    let props =
      // TODO: Remove when docs are fixed:
      // https://github.com/mui-org/material-ui/issues/21711#issuecomment-657233933
      if compMethodName = "container" then
        let children = 
          Prop.create "children" "children"
          |> Prop.addRegularOverloads [
            RegularPropOverload.createCustom "(element: ReactElement)" "prop.children element"
            RegularPropOverload.createCustom "(elements: ReactElement seq)" "prop.children elements"
            RegularPropOverload.create "(value: string)" "value"
            RegularPropOverload.create "(values: string seq)" "values"
            RegularPropOverload.create "(value: int)" "value"
            RegularPropOverload.create "(value: float)" "value"
          ]
        Array.append [|children|] props
      else props

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


    let componentName =
      Regex.Match(page.Html.Body().ToString(), "The \<code\>(.+?)\<\/code\> name can be used for")
        .Groups.[1].Value
      |> Some
      |> Option.filter (not << String.IsNullOrEmpty)
      |> Option.orElse (Some ("Mui" + String.upperFirst compMethodName))  // TODO: Remove when resolved: https://github.com/mui-org/material-ui/issues/20556

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
        Component.createImportDefault compMethodName importPath
        |> Component.setDocs markdownDocLines
        |> Component.addOverloads additionalOverloads
        |> Component.addProps props
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
      ComponentName = componentName
    }


let parseApi () =

  let components =
    HtmlCache.getApiFiles ()
    |> Array.Parallel.map parseComponent
    |> Array.toList

  let themeProvider =
    Component.createImportSelector "themeProvider" "ThemeProvider" "@material-ui/core/styles"
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

  // https://material-ui.com/styles/api/#stylesprovider
  let stylesProvider =
    Component.createImportSelector "stylesProvider" "StylesProvider" "@material-ui/core/styles"
    |> Component.setDocs [
        "This component allows you to change the behavior of the styling solution. It makes the options available down the React tree thanks to the context."
        ""
        "It should preferably be used at **the root of your component tree**."
    ]
    |> Component.addProp (
        Prop.create "children" "children"
        |> Prop.setDocs ["Your component tree."]
        |> Prop.addRegularOverload (
            RegularPropOverload.createCustom "(elements: ReactElement seq)" "prop.children elements"
        )
    )
    |> Component.addProp (
      Prop.create "disableGeneration" "disableGeneration"
      |> Prop.setDocs ["You can disable the generation of the styles with this option. It can be useful when traversing the React tree outside of the HTML rendering step on the server. Let's say you are using react-apollo to extract all the queries made by the interface server-side. You can significantly speed up the traversal with this property."]
      |> Prop.addRegularOverload (RegularPropOverload.create "(value: bool)" "value")
    )
    |> Component.addProp (
      Prop.create "injectFirst" "injectFirst"
      |> Prop.setDocs ["By default, the styles are injected last in the `<head>` element of the page. As a result, they gain more specificity than any other style sheet. If you want to override Material-UI's styles, set this prop."]
      |> Prop.addRegularOverload (RegularPropOverload.create "(value: bool)" "value")
    )
    |> Component.addProp (
      Prop.create "jss" "jss"
      |> Prop.setDocs ["JSS's instance."]
      |> Prop.addRegularOverload (RegularPropOverload.create "(value: obj)" "value")
    )

  let api =
    ComponentApi.create "Feliz.MaterialUI" "Mui"
    |> ComponentApi.addComponent themeProvider
    |> ComponentApi.addComponent stylesProvider
    |> ComponentApi.addComponents (components |> List.map (fun c -> c.GeneratorComponent))
    |> ComponentApi.setParseProps "!!properties |> Object.fromFlatEntries"

  {
    GeneratorComponentApi = api
    MuiComponents = components
  }
