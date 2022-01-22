namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open System.ComponentModel
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz


[<Erase>]
type themeProvider =
  /// Your component tree.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// A theme object. You can provide a function to extend the outer theme.
  static member inline theme (theme: Theme) = Interop.mkAttr "theme" theme
  /// A theme object. You can provide a function to extend the outer theme.
  static member inline theme (extendTheme: Theme -> Theme) = Interop.mkAttr "theme" extendTheme


[<Erase>]
type stylesProvider =
  /// Your component tree.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// You can disable the generation of the styles with this option. It can be useful when traversing the React tree outside of the HTML rendering step on the server. Let's say you are using react-apollo to extract all the queries made by the interface server-side. You can significantly speed up the traversal with this property.
  static member inline disableGeneration (value: bool) = Interop.mkAttr "disableGeneration" value
  /// By default, the styles are injected last in the `<head>` element of the page. As a result, they gain more specificity than any other style sheet. If you want to override Material-UI's styles, set this prop.
  static member inline injectFirst (value: bool) = Interop.mkAttr "injectFirst" value
  /// JSS's instance.
  static member inline jss (value: obj) = Interop.mkAttr "jss" value


[<Erase>]
type accordion =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, expands the accordion by default.
  static member inline defaultExpanded (value: bool) = Interop.mkAttr "defaultExpanded" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, it removes the margin between two expanded accordion items and the increase of height.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  ///   If `true`, expands the accordion, otherwise collapse it. Setting this prop enables control over the accordion.
  static member inline expanded (value: bool) = Interop.mkAttr "expanded" value
  ///   Callback fired when the expand/collapse state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, expanded: boolean) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *expanded:* The `expanded` state of the accordion.
  static member inline onChange (handler: Event -> bool -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback fired when the expand/collapse state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, expanded: boolean) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *expanded:* The `expanded` state of the accordion.
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The component used for the transition. [Follow this guide](https://mui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)


[<Erase>]
type accordionActions =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the actions do not have additional margin.
  static member inline disableSpacing (value: bool) = Interop.mkAttr "disableSpacing" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type accordionDetails =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type accordionSummary =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The icon to display as the expand indicator.
  static member inline expandIcon (element: ReactElement) = Interop.mkAttr "expandIcon" element
  ///   This prop can help identify which element has keyboard focus. The class name will be applied when the element gains the focus through keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/HEAD/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type alert =
  /// The action to display. It renders after the message, at the end of the alert.
  static member inline action (value: ReactElement) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the alert.
  static member inline action (values: ReactElement seq) = Interop.mkAttr "action" values
  /// The action to display. It renders after the message, at the end of the alert.
  static member inline action (value: string) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the alert.
  static member inline action (values: string seq) = Interop.mkAttr "action" values
  /// The action to display. It renders after the message, at the end of the alert.
  static member inline action (value: int) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the alert.
  static member inline action (value: float) = Interop.mkAttr "action" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   Override the default label for the *close popup* icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline closeText (value: string) = Interop.mkAttr "closeText" value
  ///   Override the icon displayed before the children. Unless provided, the icon is mapped to the value of the `severity` prop. Set to `false` to remove the `icon`.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  ///   The component maps the `severity` prop to a range of different icons, for instance success to ``. If you wish to change this mapping, you can provide your own. Alternatively, you can use the `icon` prop to override the icon displayed.
  static member inline iconMapping (?error: ReactElement, ?info: ReactElement, ?success: ReactElement, ?warning: ReactElement) = Interop.mkAttr "iconMapping" (let x = createEmpty<obj> in (if error.IsSome then x?``error`` <- error); (if info.IsSome then x?``info`` <- info); (if success.IsSome then x?``success`` <- success); (if warning.IsSome then x?``warning`` <- warning); x)
  ///   Callback fired when the component requests to be closed. When provided and no `action` prop is set, a close icon button is displayed that triggers the callback when clicked.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// The ARIA role attribute of the element.
  static member inline role (value: string) = Interop.mkAttr "role" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module alert =

  ///   The main color for the alert. Unless provided, the value is taken from the `severity` prop.
  [<Erase>]
  type color =
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// The severity of the alert. This defines the color and icon used.
  [<Erase>]
  type severity =
    static member inline error = Interop.mkAttr "severity" "error"
    static member inline info = Interop.mkAttr "severity" "info"
    static member inline success = Interop.mkAttr "severity" "success"
    static member inline warning = Interop.mkAttr "severity" "warning"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type alertTitle =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type appBar =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If true, the `color` prop is applied in dark mode.
  static member inline enableColorOnDark (value: bool) = Interop.mkAttr "enableColorOnDark" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module appBar =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline transparent = Interop.mkAttr "color" "transparent"
    static member inline string = Interop.mkAttr "color" string

  ///   The positioning type. The behavior of the different options is described [in the MDN web docs](https://developer.mozilla.org/en-US/docs/Learn/CSS/CSS_layout/Positioning). Note: `sticky` is not universally supported and will fall back to `static` when unavailable.
  [<Erase>]
  type position =
    static member inline absolute = Interop.mkAttr "position" "absolute"
    static member inline fixed' = Interop.mkAttr "position" "fixed"
    static member inline relative = Interop.mkAttr "position" "relative"
    static member inline static' = Interop.mkAttr "position" "static"
    static member inline sticky = Interop.mkAttr "position" "sticky"


[<Erase>]
type autocomplete =
  /// Array of options.
  static member inline options (options: 'option []) = Interop.mkAttr "options" (ResizeArray options)
  ///   Render the input.
  ///
  /// **Signature:**
  ///
  /// `function(params: object) => ReactNode`
  static member inline renderInput (render: AutocompleteRenderInputParams -> ReactElement) = Interop.mkAttr "renderInput" render
  ///   If `true`, the portion of the selected suggestion that has not been typed by the user, known as the completion string, appears inline after the input cursor in the textbox. The inline completion string is visually highlighted and has a selected state.
  static member inline autoComplete (value: bool) = Interop.mkAttr "autoComplete" value
  ///   If `true`, the first option is automatically highlighted.
  static member inline autoHighlight (value: bool) = Interop.mkAttr "autoHighlight" value
  ///   If `true`, the selected option becomes the value of the input when the Autocomplete loses focus unless the user chooses a different option or changes the character string in the input.
  static member inline autoSelect (value: bool) = Interop.mkAttr "autoSelect" value
  ///   Control if the input should be blurred when an option is selected:
  ///
  /// - `false` the input is not blurred. - `true` the input is always blurred. - `touch` the input is blurred after a touch event. - `mouse` the input is blurred after a mouse event.
  static member inline blurOnSelect (value: bool) = Interop.mkAttr "blurOnSelect" value
  ///   Props applied to the
  ///
  /// [`Chip`](https://mui.com/api/chip/) element.
  static member inline ChipProps (props: IReactProperty list) = Interop.mkAttr "ChipProps" (createObj !!props)
  /// The icon to display in place of the default clear icon.
  static member inline clearIcon (element: ReactElement) = Interop.mkAttr "clearIcon" element
  ///   If `true`, the input's text is cleared on blur if no value is selected.
  ///
  /// Set to `true` if you want to help the user enter a new value. Set to `false` if you want to help the user resume their search.
  static member inline clearOnBlur (value: bool) = Interop.mkAttr "clearOnBlur" value
  ///   If `true`, clear all values when the user presses escape and the popup is closed.
  static member inline clearOnEscape (value: bool) = Interop.mkAttr "clearOnEscape" value
  ///   Override the default text for the *clear* icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  ///   Override the default text for the *close popup* icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline closeText (value: string) = Interop.mkAttr "closeText" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'option []) = Interop.mkAttr "defaultValue" (ResizeArray value)
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'option option) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the input can't be cleared.
  static member inline disableClearable (value: bool) = Interop.mkAttr "disableClearable" value
  ///   If `true`, the popup won't close when a value is selected.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, will allow focus on disabled items.
  static member inline disabledItemsFocusable (value: bool) = Interop.mkAttr "disabledItemsFocusable" value
  ///   If `true`, the list box in the popup will not wrap focus.
  static member inline disableListWrap (value: bool) = Interop.mkAttr "disableListWrap" value
  ///   If `true`, the `Popper` content will be under the DOM hierarchy of the parent component.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  ///   A filter function that determines the options that are eligible.
  ///
  /// **Signature:**
  ///
  /// `function(options: Array, state: object) => Array`
  ///
  /// *options:* The options to render.
  ///
  /// *state:* The state of the component.
  static member inline filterOptions (filterOptions: 'option [] -> string -> 'option []) = Interop.mkAttr "filterOptions" (Func<_,_,_> (fun opts (s: AutocompleteFilterOptionsState) -> ResizeArray (filterOptions opts s.inputValue)))
  ///   A filter function that determines the options that are eligible.
  ///
  /// **Signature:**
  ///
  /// `function(options: Array, state: object) => Array`
  ///
  /// *options:* The options to render.
  ///
  /// *state:* The state of the component.
  static member inline filterOptions (filterOptions: 'option [] -> AutocompleteFilterOptionsState -> 'option []) = Interop.mkAttr "filterOptions" (Func<_,_,_> filterOptions)
  ///   If `true`, hide the selected options from the list box.
  static member inline filterSelectedOptions (value: bool) = Interop.mkAttr "filterSelectedOptions" value
  /// Force the visibility display of the popup icon.
  static member inline forcePopupIcon (value: bool) = Interop.mkAttr "forcePopupIcon" value
  ///   If `true`, the Autocomplete is free solo, meaning that the user input is not bound to provided options.
  static member inline freeSolo (value: bool) = Interop.mkAttr "freeSolo" value
  ///   If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   The label to display when the tags are truncated (`limitTags`).
  ///
  /// **Signature:**
  ///
  /// `function(more: number) => ReactNode`
  ///
  /// *more:* The number of truncated tags.
  static member inline getLimitTagsText (getText: int -> ReactElement) = Interop.mkAttr "getLimitTagsText" getText
  ///   Used to determine the disabled state for a given option.
  ///
  /// **Signature:**
  ///
  /// `function(option: T) => boolean`
  ///
  /// *option:* The option to test.
  static member inline getOptionDisabled (isDisabled: 'option -> bool) = Interop.mkAttr "getOptionDisabled" isDisabled
  ///   Used to determine the string value for a given option. It's used to fill the input (and the list box options if `renderOption` is not provided).
  ///
  /// **Signature:**
  ///
  /// `function(option: T) => string`
  static member inline getOptionLabel (getLabel: 'option -> string) = Interop.mkAttr "getOptionLabel" getLabel
  ///   If provided, the options will be grouped under the returned string. The groupBy value is also used as the text for group headings when `renderGroup` is not provided.
  ///
  /// **Signature:**
  ///
  /// `function(options: T) => string`
  ///
  /// *options:* The options to group.
  static member inline groupBy (getGroup: 'option -> string) = Interop.mkAttr "groupBy" getGroup
  ///   If `true`, the component handles the "Home" and "End" keys when the popup is open. It should move focus to the first option and last option, respectively.
  static member inline handleHomeEndKeys (value: bool) = Interop.mkAttr "handleHomeEndKeys" value
  /// This prop is used to help implement the accessibility logic. If you don't provide an id it will fall back to a randomly generated one.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   If `true`, the highlight can move to the input.
  static member inline includeInputInList (value: bool) = Interop.mkAttr "includeInputInList" value
  /// The input value.
  static member inline inputValue (value: string) = Interop.mkAttr "inputValue" value
  ///   Used to determine if the option represents the given value. Uses strict equality by default. ⚠️ Both arguments need to be handled, an option can only match with one value.
  ///
  /// **Signature:**
  ///
  /// `function(option: T, value: T) => boolean`
  ///
  /// *option:* The option to test.
  ///
  /// *value:* The value to test against.
  static member inline isOptionEqualToValue (value: TODO) = Interop.mkAttr "isOptionEqualToValue" value
  ///   The maximum number of tags that will be visible when not focused. Set `-1` to disable the limit.
  static member inline limitTags (value: TODO) = Interop.mkAttr "limitTags" value
  /// The component used to render the listbox.
  static member inline ListboxComponent (value: ReactElementType) = Interop.mkAttr "ListboxComponent" value
  /// Props applied to the Listbox element.
  static member inline ListboxProps (props: IReactProperty list) = Interop.mkAttr "ListboxProps" (createObj !!props)
  ///   If `true`, the component is in a loading state. This shows the `loadingText` in place of suggestions (only if there are no suggestions to show, e.g. `options` are empty).
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline loadingText (value: ReactElement) = Interop.mkAttr "loadingText" value
  ///   Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline loadingText (values: ReactElement seq) = Interop.mkAttr "loadingText" values
  ///   Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline loadingText (value: string) = Interop.mkAttr "loadingText" value
  ///   Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline loadingText (values: string seq) = Interop.mkAttr "loadingText" values
  ///   Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline loadingText (value: int) = Interop.mkAttr "loadingText" value
  ///   Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline loadingText (value: float) = Interop.mkAttr "loadingText" value
  ///   If `true`, `value` must be an array and the menu will support multiple selections.
  static member inline multiple (value: bool) = Interop.mkAttr "multiple" value
  ///   Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline noOptionsText (value: ReactElement) = Interop.mkAttr "noOptionsText" value
  ///   Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline noOptionsText (values: ReactElement seq) = Interop.mkAttr "noOptionsText" values
  ///   Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline noOptionsText (value: string) = Interop.mkAttr "noOptionsText" value
  ///   Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline noOptionsText (values: string seq) = Interop.mkAttr "noOptionsText" values
  ///   Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline noOptionsText (value: int) = Interop.mkAttr "noOptionsText" value
  ///   Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline noOptionsText (value: float) = Interop.mkAttr "noOptionsText" value
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: T | Array, reason: string, details?: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the component.
  ///
  /// *reason:* One of "createOption", "selectOption", "removeOption", "blur" or "clear".
  static member inline onChange (handler: Event -> 'option [] -> AutocompleteOnChangeReason -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> handler)
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: T | Array, reason: string, details?: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the component.
  ///
  /// *reason:* One of "createOption", "selectOption", "removeOption", "blur" or "clear".
  static member inline onChange (handler: 'option [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> (fun _ v _ -> handler v))
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: T | Array, reason: string, details?: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the component.
  ///
  /// *reason:* One of "createOption", "selectOption", "removeOption", "blur" or "clear".
  static member inline onChange (handler: Event -> 'option option -> AutocompleteOnChangeReason -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> handler)
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: T | Array, reason: string, details?: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the component.
  ///
  /// *reason:* One of "createOption", "selectOption", "removeOption", "blur" or "clear".
  static member inline onChange (handler: 'option option -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> (fun _ v _ -> handler v))
  ///   Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggleInput"`, `"escape"`, `"selectOption"`, `"removeOption"`, `"blur"`.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback fired when the highlight option changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, option: T, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *option:* The highlighted option.
  ///
  /// *reason:* Can be: `"keyboard"`, `"auto"`, `"mouse"`.
  static member inline onHighlightChange (handler: Event -> 'option -> AutocompleteHighlightChangeReason -> unit) = Interop.mkAttr "onHighlightChange" (Func<_,_,_,_> handler)
  ///   Callback fired when the highlight option changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, option: T, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *option:* The highlighted option.
  ///
  /// *reason:* Can be: `"keyboard"`, `"auto"`, `"mouse"`.
  static member inline onHighlightChange (handler: 'option -> AutocompleteHighlightChangeReason -> unit) = Interop.mkAttr "onHighlightChange" (Func<_,_,_,_> (fun _ o r -> handler o r))
  ///   Callback fired when the highlight option changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, option: T, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *option:* The highlighted option.
  ///
  /// *reason:* Can be: `"keyboard"`, `"auto"`, `"mouse"`.
  static member inline onHighlightChange (handler: 'option -> unit) = Interop.mkAttr "onHighlightChange" (Func<_,_,_,_> (fun _ o _ -> handler o))
  ///   Callback fired when the input value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: string, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the text input.
  ///
  /// *reason:* Can be: `"input"` (user input), `"reset"` (programmatic change), `"clear"`.
  static member inline onInputChange (handler: Event -> string -> AutocompleteInputChangeReason -> unit) = Interop.mkAttr "onInputChange" (Func<_,_,_,_> handler)
  ///   Callback fired when the input value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: string, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the text input.
  ///
  /// *reason:* Can be: `"input"` (user input), `"reset"` (programmatic change), `"clear"`.
  static member inline onInputChange (handler: string -> unit) = Interop.mkAttr "onInputChange" (Func<_,_,_,_> (fun _ v _ -> handler v))
  ///   Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  ///   If `true`, the popup will open on input focus.
  static member inline openOnFocus (value: bool) = Interop.mkAttr "openOnFocus" value
  ///   Override the default text for the *open popup* icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline openText (value: string) = Interop.mkAttr "openText" value
  /// The component used to render the body of the popup.
  static member inline PaperComponent (value: ReactElementType) = Interop.mkAttr "PaperComponent" value
  /// The component used to position the popup.
  static member inline PopperComponent (value: ReactElementType) = Interop.mkAttr "PopperComponent" value
  /// The icon to display in place of the default popup icon.
  static member inline popupIcon (element: ReactElement) = Interop.mkAttr "popupIcon" element
  ///   Render the group.
  ///
  /// **Signature:**
  ///
  /// `function(params: AutocompleteRenderGroupParams) => ReactNode`
  ///
  /// *params:* The group to render.
  static member inline renderGroup (render: AutocompleteRenderGroupParams -> ReactElement) = Interop.mkAttr "renderGroup" render
  ///   Render the option, use `getOptionLabel` by default.
  ///
  /// **Signature:**
  ///
  /// `function(props: object, option: T, state: object) => ReactNode`
  ///
  /// *props:* The props to apply on the li element.
  ///
  /// *option:* The option to render.
  ///
  /// *state:* The state of the component.
  static member inline renderOption (render: 'option -> AutocompleteRenderOptionState -> ReactElement) = Interop.mkAttr "renderOption" (Func<_,_,_> render)
  ///   Render the selected value.
  ///
  /// **Signature:**
  ///
  /// `function(value: Array, getTagProps: function) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  ///
  /// *getTagProps:* A tag props getter.
  static member inline renderTags (render: 'option [] -> AutocompleteRenderValueState -> ReactElement) = Interop.mkAttr "renderTags" (Func<_,_,_> render)
  ///   If `true`, the input's text is selected on focus. It helps the user clear the selected value.
  static member inline selectOnFocus (value: bool) = Interop.mkAttr "selectOnFocus" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The value of the autocomplete.
  ///
  /// The value must have reference equality with the option in order to be selected. You can customize the equality behavior with the `isOptionEqualToValue` prop.
  static member inline value (value: 'option []) = Interop.mkAttr "value" (ResizeArray value)
  ///   The value of the autocomplete.
  ///
  /// The value must have reference equality with the option in order to be selected. You can customize the equality behavior with the `isOptionEqualToValue` prop.
  static member inline value (value: 'option option) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module autocompleteExtensions =

  type autocomplete with
    /// The default value. Use when the component is not controlled.
    static member inline defaultValue (value: 'option) = Interop.mkAttr "defaultValue" value
    ///   Callback fired when the value changes.
    ///
    /// **Signature:**
    ///
    /// `function(event: React.SyntheticEvent, value: T | Array, reason: string, details?: string) => void`
    ///
    /// *event:* The event source of the callback.
    ///
    /// *value:* The new value of the component.
    ///
    /// *reason:* One of "createOption", "selectOption", "removeOption", "blur" or "clear".
    static member inline onChange (handler: Event -> 'option -> AutocompleteOnChangeReason -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> handler)
    ///   Callback fired when the value changes.
    ///
    /// **Signature:**
    ///
    /// `function(event: React.SyntheticEvent, value: T | Array, reason: string, details?: string) => void`
    ///
    /// *event:* The event source of the callback.
    ///
    /// *value:* The new value of the component.
    ///
    /// *reason:* One of "createOption", "selectOption", "removeOption", "blur" or "clear".
    static member inline onChange (handler: 'option -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> (fun _ v _ -> handler v))
    ///   The value of the autocomplete.
    ///
    /// The value must have reference equality with the option in order to be selected. You can customize the equality behavior with the `isOptionEqualToValue` prop.
    static member inline value (value: 'option) = Interop.mkAttr "value" value

module autocomplete =

  ///   Control if the input should be blurred when an option is selected:
  ///
  /// - `false` the input is not blurred. - `true` the input is always blurred. - `touch` the input is blurred after a touch event. - `mouse` the input is blurred after a mouse event.
  [<Erase>]
  type blurOnSelect =
    static member inline mouse = Interop.mkAttr "blurOnSelect" "mouse"
    static member inline touch = Interop.mkAttr "blurOnSelect" "touch"

  /// Force the visibility display of the popup icon.
  [<Erase>]
  type forcePopupIcon =
    static member inline auto = Interop.mkAttr "forcePopupIcon" "auto"

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type avatar =
  ///   Used in combination with `src` or `srcSet` to provide an alt attribute for the rendered `img` element.
  static member inline alt (value: string) = Interop.mkAttr "alt" value
  ///   Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (element: ReactElement) = prop.children element
  ///   Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/img#attributes) applied to the `img` element if the component is used to display an image. It can be used to listen for the loading error event.
  static member inline imgProps (props: IReactProperty list) = Interop.mkAttr "imgProps" (createObj !!props)
  ///   The `sizes` attribute for the `img` element.
  static member inline sizes (value: string) = Interop.mkAttr "sizes" value
  ///   The `src` attribute for the `img` element.
  static member inline src (value: string) = Interop.mkAttr "src" value
  ///   The `srcSet` attribute for the `img` element. Use this attribute for responsive image display.
  static member inline srcSet (value: string) = Interop.mkAttr "srcSet" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module avatar =

  /// The shape of the avatar.
  [<Erase>]
  type variant =
    static member inline circular = Interop.mkAttr "variant" "circular"
    static member inline rounded = Interop.mkAttr "variant" "rounded"
    static member inline square = Interop.mkAttr "variant" "square"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type avatarGroup =
  /// The avatars to stack.
  static member inline children (element: ReactElement) = prop.children element
  /// The avatars to stack.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The avatars to stack.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The avatars to stack.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The avatars to stack.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The avatars to stack.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Max avatars to show before +x.
  static member inline max (value: int) = Interop.mkAttr "max" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The total number of avatars. Used for calculating the number of extra avatars.
  static member inline total (value: int) = Interop.mkAttr "total" value

module avatarGroup =

  /// Spacing between avatars.
  [<Erase>]
  type spacing =
    static member inline medium = Interop.mkAttr "spacing" "medium"
    static member inline small = Interop.mkAttr "spacing" "small"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline circular = Interop.mkAttr "variant" "circular"
    static member inline rounded = Interop.mkAttr "variant" "rounded"
    static member inline square = Interop.mkAttr "variant" "square"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type backdrop =
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Backdrop. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Backdrop.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   If `true`, the backdrop is invisible. It can be used when rendering a popover or a custom select component.
  static member inline invisible (value: bool) = Interop.mkAttr "invisible" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)


[<Erase>]
type backdropUnstyled =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Backdrop. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Backdrop.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   If `true`, the backdrop is invisible. It can be used when rendering a popover or a custom select component.
  static member inline invisible (value: bool) = Interop.mkAttr "invisible" value


[<Erase>]
type badge =
  /// The content rendered within the badge.
  static member inline badgeContent (value: ReactElement) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent (values: ReactElement seq) = Interop.mkAttr "badgeContent" values
  /// The content rendered within the badge.
  static member inline badgeContent (value: string) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent (values: string seq) = Interop.mkAttr "badgeContent" values
  /// The content rendered within the badge.
  static member inline badgeContent (value: int) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent (value: float) = Interop.mkAttr "badgeContent" value
  /// The badge will be added relative to this node.
  static member inline children (element: ReactElement) = prop.children element
  /// The badge will be added relative to this node.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The badge will be added relative to this node.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The badge will be added relative to this node.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The badge will be added relative to this node.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The badge will be added relative to this node.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Badge. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Badge.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   If `true`, the badge is invisible.
  static member inline invisible (value: bool) = Interop.mkAttr "invisible" value
  /// Max count to show.
  static member inline max (value: int) = Interop.mkAttr "max" value
  ///   Controls whether the badge is hidden when `badgeContent` is zero.
  static member inline showZero (value: bool) = Interop.mkAttr "showZero" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module badge =

  /// The anchor of the badge.
  [<Erase>]
  type anchorOrigin =
    static member inline topLeft = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "left" ])
    static member inline topRight = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "right" ])
    static member inline bottomLeft = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "left" ])
    static member inline bottomRight = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "right" ])

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// Wrapped shape the badge should overlap.
  [<Erase>]
  type overlap =
    static member inline circular = Interop.mkAttr "overlap" "circular"
    static member inline rectangular = Interop.mkAttr "overlap" "rectangular"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline dot = Interop.mkAttr "variant" "dot"
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type badgeUnstyled =
  /// The content rendered within the badge.
  static member inline badgeContent (value: ReactElement) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent (values: ReactElement seq) = Interop.mkAttr "badgeContent" values
  /// The content rendered within the badge.
  static member inline badgeContent (value: string) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent (values: string seq) = Interop.mkAttr "badgeContent" values
  /// The content rendered within the badge.
  static member inline badgeContent (value: int) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent (value: float) = Interop.mkAttr "badgeContent" value
  /// The badge will be added relative to this node.
  static member inline children (element: ReactElement) = prop.children element
  /// The badge will be added relative to this node.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The badge will be added relative to this node.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The badge will be added relative to this node.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The badge will be added relative to this node.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The badge will be added relative to this node.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Badge. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Badge.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   If `true`, the badge is invisible.
  static member inline invisible (value: bool) = Interop.mkAttr "invisible" value
  /// Max count to show.
  static member inline max (value: int) = Interop.mkAttr "max" value
  ///   Controls whether the badge is hidden when `badgeContent` is zero.
  static member inline showZero (value: bool) = Interop.mkAttr "showZero" value
  /// The variant to use.
  static member inline variant (value: string) = Interop.mkAttr "variant" value

module badgeUnstyled =

  /// The anchor of the badge.
  [<Erase>]
  type anchorOrigin =
    static member inline right", vertical: "bottom = Interop.mkAttr "anchorOrigin" "right", vertical: "bottom"
    static member inline 'top' } = Interop.mkAttr "anchorOrigin" 'top' }


[<Erase>]
type bottomNavigation =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: any) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* We default to the index of the child.
  static member inline onChange (handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: any) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* We default to the index of the child.
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   If `true`, all `BottomNavigationAction`s will show their labels. By default, only the selected `BottomNavigationAction` will show its label.
  static member inline showLabels (value: bool) = Interop.mkAttr "showLabels" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The value of the currently selected `BottomNavigationAction`.
  static member inline value (value: 'a) = Interop.mkAttr "value" value


[<Erase>]
type bottomNavigationAction =
  ///   This prop isn't supported. Use the `component` prop if you need to change the children structure.
  static member inline children  = UnsupportedProp ()
  /// The icon to display.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The label element.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// The label element.
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// The label element.
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label (value: float) = Interop.mkAttr "label" value
  ///   If `true`, the `BottomNavigationAction` will show its label. By default, only the selected `BottomNavigationAction` inside `BottomNavigation` will show its label.
  ///
  /// The prop defaults to the value (`false`) inherited from the parent BottomNavigation component.
  static member inline showLabel (value: bool) = Interop.mkAttr "showLabel" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// You can provide your own value. Otherwise, we fallback to the child position index.
  static member inline value (value: 'a) = Interop.mkAttr "value" value


[<Erase>]
type breadcrumbs =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Override the default label for the expand button.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline expandText (value: string) = Interop.mkAttr "expandText" value
  /// If max items is exceeded, the number of items to show after the ellipsis.
  static member inline itemsAfterCollapse (value: TODO) = Interop.mkAttr "itemsAfterCollapse" value
  /// If max items is exceeded, the number of items to show before the ellipsis.
  static member inline itemsBeforeCollapse (value: TODO) = Interop.mkAttr "itemsBeforeCollapse" value
  ///   Specifies the maximum number of breadcrumbs to display. When there are more than the maximum number, only the first `itemsBeforeCollapse` and last `itemsAfterCollapse` will be shown, with an ellipsis in between.
  static member inline maxItems (value: TODO) = Interop.mkAttr "maxItems" value
  /// Custom separator node.
  static member inline separator (value: ReactElement) = Interop.mkAttr "separator" value
  /// Custom separator node.
  static member inline separator (values: ReactElement seq) = Interop.mkAttr "separator" values
  /// Custom separator node.
  static member inline separator (value: string) = Interop.mkAttr "separator" value
  /// Custom separator node.
  static member inline separator (values: string seq) = Interop.mkAttr "separator" values
  /// Custom separator node.
  static member inline separator (value: int) = Interop.mkAttr "separator" value
  /// Custom separator node.
  static member inline separator (value: float) = Interop.mkAttr "separator" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type button =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, no elevation is used.
  static member inline disableElevation (value: bool) = Interop.mkAttr "disableElevation" value
  ///   If `true`, the keyboard focus ripple is disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  ///   If `true`, the ripple effect is disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `.Mui-focusVisible` class.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// Element placed after the children.
  static member inline endIcon (element: ReactElement) = Interop.mkAttr "endIcon" element
  ///   If `true`, the button will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   The URL to link to when the button is clicked. If defined, an `a` element will be used as the root node.
  static member inline href (value: string) = Interop.mkAttr "href" value
  /// Element placed before the children.
  static member inline startIcon (element: ReactElement) = Interop.mkAttr "startIcon" element
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module button =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  ///   The size of the component. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline contained = Interop.mkAttr "variant" "contained"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type buttonBase =
  ///   A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  ///   A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  ///   If `true`, the ripples are centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  ///   The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the ripple effect is disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `.Mui-focusVisible` class.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  ///   If `true`, the touch ripple effect is disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  ///   If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  ///   This prop can help identify which element has keyboard focus. The class name will be applied when the element gains the focus through keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/HEAD/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  ///   The component used to render a link when the `href` prop is provided.
  static member inline LinkComponent (value: ReactElementType) = Interop.mkAttr "LinkComponent" value
  ///   Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


[<Erase>]
type buttonGroup =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, no elevation is used.
  static member inline disableElevation (value: bool) = Interop.mkAttr "disableElevation" value
  ///   If `true`, the button keyboard focus ripple is disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  ///   If `true`, the button ripple effect is disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  ///   If `true`, the buttons will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module buttonGroup =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// The component orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  ///   The size of the component. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline contained = Interop.mkAttr "variant" "contained"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type buttonUnstyled =
  ///   A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (value: TODO) = Interop.mkAttr "action" value
  ///   The component used for the Root slot. Either a string to use a HTML element or a component. This is equivalent to `components.Root`. If both are provided, the `component` is used.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  ///   The component used for the Root slot. Either a string to use a HTML element or a component. This is equivalent to `components.Root`. If both are provided, the `component` is used.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Button. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type calendarPicker =
  /// Callback fired on date change
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module calendarPicker =

  /// Initially open view.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Controlled open view.
  [<Erase>]
  type view =
    static member inline day = Interop.mkAttr "view" "day"
    static member inline month = Interop.mkAttr "view" "month"
    static member inline year = Interop.mkAttr "view" "year"

  /// Views for calendar picker.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline month = Interop.mkAttr "views" "month"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type calendarPickerSkeleton =
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type card =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the card will use raised styling.
  static member inline raised (value: bool) = Interop.mkAttr "raised" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type cardActionArea =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type cardActions =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the actions do not have additional margin.
  static member inline disableSpacing (value: bool) = Interop.mkAttr "disableSpacing" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type cardContent =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type cardHeader =
  /// The action to display in the card header.
  static member inline action (value: ReactElement) = Interop.mkAttr "action" value
  /// The action to display in the card header.
  static member inline action (values: ReactElement seq) = Interop.mkAttr "action" values
  /// The action to display in the card header.
  static member inline action (value: string) = Interop.mkAttr "action" value
  /// The action to display in the card header.
  static member inline action (values: string seq) = Interop.mkAttr "action" values
  /// The action to display in the card header.
  static member inline action (value: int) = Interop.mkAttr "action" value
  /// The action to display in the card header.
  static member inline action (value: float) = Interop.mkAttr "action" value
  /// The Avatar element to display.
  static member inline avatar (value: ReactElement) = Interop.mkAttr "avatar" value
  /// The Avatar element to display.
  static member inline avatar (values: ReactElement seq) = Interop.mkAttr "avatar" values
  /// The Avatar element to display.
  static member inline avatar (value: string) = Interop.mkAttr "avatar" value
  /// The Avatar element to display.
  static member inline avatar (values: string seq) = Interop.mkAttr "avatar" values
  /// The Avatar element to display.
  static member inline avatar (value: int) = Interop.mkAttr "avatar" value
  /// The Avatar element to display.
  static member inline avatar (value: float) = Interop.mkAttr "avatar" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, `subheader` and `title` won't be wrapped by a Typography component. This can be useful to render an alternative Typography variant by wrapping the `title` text, and optional `subheader` text with the Typography component.
  static member inline disableTypography (value: bool) = Interop.mkAttr "disableTypography" value
  /// The content of the component.
  static member inline subheader (value: ReactElement) = Interop.mkAttr "subheader" value
  /// The content of the component.
  static member inline subheader (values: ReactElement seq) = Interop.mkAttr "subheader" values
  /// The content of the component.
  static member inline subheader (value: string) = Interop.mkAttr "subheader" value
  /// The content of the component.
  static member inline subheader (values: string seq) = Interop.mkAttr "subheader" values
  /// The content of the component.
  static member inline subheader (value: int) = Interop.mkAttr "subheader" value
  /// The content of the component.
  static member inline subheader (value: float) = Interop.mkAttr "subheader" value
  ///   These props will be forwarded to the subheader (as long as disableTypography is not `true`).
  static member inline subheaderTypographyProps (props: IReactProperty list) = Interop.mkAttr "subheaderTypographyProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The content of the component.
  static member inline title (value: ReactElement) = Interop.mkAttr "title" value
  /// The content of the component.
  static member inline title (values: ReactElement seq) = Interop.mkAttr "title" values
  /// The content of the component.
  static member inline title (value: string) = Interop.mkAttr "title" value
  /// The content of the component.
  static member inline title (values: string seq) = Interop.mkAttr "title" values
  /// The content of the component.
  static member inline title (value: int) = Interop.mkAttr "title" value
  /// The content of the component.
  static member inline title (value: float) = Interop.mkAttr "title" value
  ///   These props will be forwarded to the title (as long as disableTypography is not `true`).
  static member inline titleTypographyProps (props: IReactProperty list) = Interop.mkAttr "titleTypographyProps" (createObj !!props)
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type cardMedia =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Image to be displayed as a background image. Either `image` or `src` prop must be specified. Note that caller must specify height otherwise the image will not be visible.
  static member inline image (value: string) = Interop.mkAttr "image" value
  ///   An alias for `image` property. Available only with media components. Media components: `video`, `audio`, `picture`, `iframe`, `img`.
  static member inline src (value: string) = Interop.mkAttr "src" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type checkbox =
  ///   If `true`, the component is checked.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon (element: ReactElement) = Interop.mkAttr "checkedIcon" element
  /// The default checked state. Use when the component is not controlled.
  static member inline defaultChecked (value: bool) = Interop.mkAttr "defaultChecked" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the ripple effect is disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  ///   The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   If `true`, the component appears indeterminate. This does not set the native input element to indeterminate due to inconsistent behavior across browsers. However, we set a `data-indeterminate` attribute on the `input`.
  static member inline indeterminate (value: bool) = Interop.mkAttr "indeterminate" value
  /// The icon to display when the component is indeterminate.
  static member inline indeterminateIcon (element: ReactElement) = Interop.mkAttr "indeterminateIcon" element
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  ///   Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
  ///   If `true`, the `input` element is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The value of the component. The browser uses "on" as the default value.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module checkbox =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  ///   The size of the component. `small` is equivalent to the dense checkbox styling.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type chip =
  /// The Avatar element to display.
  static member inline avatar (value: ReactElement) = Interop.mkAttr "avatar" value
  ///   This prop isn't supported. Use the `component` prop if you need to change the children structure.
  static member inline children  = UnsupportedProp ()
  ///   If `true`, the chip will appear clickable, and will raise when pressed, even if the onClick prop is not defined. If `false`, the chip will not appear clickable, even if onClick prop is defined. This can be used, for example, along with the component prop to indicate an anchor Chip is clickable. Note: this controls the UI and does not affect the onClick event.
  static member inline clickable (value: bool) = Interop.mkAttr "clickable" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Override the default delete icon element. Shown only if `onDelete` is set.
  static member inline deleteIcon (value: ReactElement) = Interop.mkAttr "deleteIcon" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Icon element.
  static member inline icon (value: ReactElement) = Interop.mkAttr "icon" value
  /// The content of the component.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// The content of the component.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// The content of the component.
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// The content of the component.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// The content of the component.
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// The content of the component.
  static member inline label (value: float) = Interop.mkAttr "label" value
  /// Callback fired when the delete icon is clicked. If set, the delete icon will be shown.
  static member inline onDelete (handler: Event -> unit) = Interop.mkAttr "onDelete" handler
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module chip =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"
    static member inline string = Interop.mkAttr "size" string

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type circularProgress =
  ///   If `true`, the shrink animation is disabled. This only works if variant is `indeterminate`.
  static member inline disableShrink (value: bool) = Interop.mkAttr "disableShrink" value
  /// The size of the component. If using a number, the pixel unit is assumed. If using a string, you need to provide the CSS unit, e.g '3rem'.
  static member inline size (value: int) = Interop.mkAttr "size" value
  /// The size of the component. If using a number, the pixel unit is assumed. If using a string, you need to provide the CSS unit, e.g '3rem'.
  static member inline size (value: Styles.ICssUnit) = Interop.mkAttr "size" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The thickness of the circle.
  static member inline thickness (value: int) = Interop.mkAttr "thickness" value
  /// The value of the progress indicator for the determinate variant. Value between 0 and 100.
  static member inline value (value: int) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module circularProgress =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// The variant to use. Use indeterminate when there is no progress value.
  [<Erase>]
  type variant =
    static member inline determinate = Interop.mkAttr "variant" "determinate"
    static member inline indeterminate = Interop.mkAttr "variant" "indeterminate"


[<Erase>]
type clickAwayListener =
  ///   The wrapped element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Callback fired when a "click away" event is detected.
  static member inline onClickAway (handler: Event -> unit) = Interop.mkAttr "onClickAway" handler
  ///   If `true`, the React tree is ignored and only the DOM tree is considered. This prop changes how portaled elements are handled.
  static member inline disableReactTree (value: bool) = Interop.mkAttr "disableReactTree" value

module clickAwayListener =

  ///   The mouse event to listen to. You can disable the listener by providing `false`.
  [<Erase>]
  type mouseEvent =
    static member inline onClick = Interop.mkAttr "mouseEvent" "onClick"
    static member inline onMouseDown = Interop.mkAttr "mouseEvent" "onMouseDown"
    static member inline onMouseUp = Interop.mkAttr "mouseEvent" "onMouseUp"
    static member inline false' = Interop.mkAttr "mouseEvent" false

  ///   The touch event to listen to. You can disable the listener by providing `false`.
  [<Erase>]
  type touchEvent =
    static member inline onTouchEnd = Interop.mkAttr "touchEvent" "onTouchEnd"
    static member inline onTouchStart = Interop.mkAttr "touchEvent" "onTouchStart"
    static member inline false' = Interop.mkAttr "touchEvent" false


[<Erase>]
type clockPicker =
  /// Selected date @DateIOType.
  static member inline date (value: 'a) = Interop.mkAttr "date" value
  /// On change callback @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  ///   Set to `true` if focus should be moved to clock picker.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get clock number aria-text for hours.
  static member inline getHoursClockNumberText (value: TODO) = Interop.mkAttr "getHoursClockNumberText" value
  /// Get clock number aria-text for minutes.
  static member inline getMinutesClockNumberText (value: TODO) = Interop.mkAttr "getMinutesClockNumberText" value
  /// Get clock number aria-text for seconds.
  static member inline getSecondsClockNumberText (value: TODO) = Interop.mkAttr "getSecondsClockNumberText" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type collapse =
  /// Add a custom transition end trigger. Called with the transitioning DOM node and a done callback. Allows for more fine grained transition end logic. Note: Timeouts are still used as a fallback if provided.
  static member inline addEndListener (value: TODO) = Interop.mkAttr "addEndListener" value
  /// The content node to be collapsed.
  static member inline children (element: ReactElement) = prop.children element
  /// The content node to be collapsed.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content node to be collapsed.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content node to be collapsed.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content node to be collapsed.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content node to be collapsed.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The width (horizontal) or height (vertical) of the container when collapsed.
  static member inline collapsedSize (value: int) = Interop.mkAttr "collapsedSize" value
  /// The width (horizontal) or height (vertical) of the container when collapsed.
  static member inline collapsedSize (value: Styles.ICssUnit) = Interop.mkAttr "collapsedSize" value
  ///   The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  ///   The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The transition timing function. You may specify a single easing or a object containing enter and exit values.
  static member inline easing (value: TODO) = Interop.mkAttr "easing" value
  ///   If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)

module collapse =

  /// The transition orientation.
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  [<Erase>]
  type timeout =
    static member inline auto = Interop.mkAttr "timeout" "auto"


[<Erase>]
type container =
  static member inline children (element: ReactElement) = prop.children element
  static member inline children (elements: ReactElement seq) = prop.children elements
  static member inline children (value: string) = Interop.mkAttr "children" value
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  static member inline children (value: int) = Interop.mkAttr "children" value
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the left and right padding is removed.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  /// Set the max-width to match the min-width of the current breakpoint. This is useful if you'd prefer to design for a fixed set of sizes instead of trying to accommodate a fully fluid viewport. It's fluid by default.
  static member inline fixed' (value: bool) = Interop.mkAttr "fixed" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module container =

  ///   Determine the max-width of the container. The container width grows with the size of the screen. Set to `false` to disable `maxWidth`.
  [<Erase>]
  type maxWidth =
    static member inline xs = Interop.mkAttr "maxWidth" "xs"
    static member inline sm = Interop.mkAttr "maxWidth" "sm"
    static member inline md = Interop.mkAttr "maxWidth" "md"
    static member inline lg = Interop.mkAttr "maxWidth" "lg"
    static member inline xl = Interop.mkAttr "maxWidth" "xl"
    static member inline false' = Interop.mkAttr "maxWidth" false
    static member inline string = Interop.mkAttr "maxWidth" string


[<Erase>]
type cssBaseline =
  /// You can wrap a node.
  static member inline children (element: ReactElement) = prop.children element
  /// You can wrap a node.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// You can wrap a node.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// You can wrap a node.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// You can wrap a node.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// You can wrap a node.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   Enable `color-scheme` CSS property to use `theme.palette.mode`. For more details, check out https://developer.mozilla.org/en-US/docs/Web/CSS/color-scheme For browser support, check out https://caniuse.com/?search=color-scheme
  static member inline enableColorScheme (value: bool) = Interop.mkAttr "enableColorScheme" value


[<Erase>]
type datePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// Cancel text message.
  static member inline cancelText (value: ReactElement) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: ReactElement seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: string) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: string seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: int) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (value: float) = Interop.mkAttr "cancelText" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true`, it shows the clear action in the picker dialog.
  static member inline clearable (value: bool) = Interop.mkAttr "clearable" value
  /// Clear text message.
  static member inline clearText (value: ReactElement) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: ReactElement seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: string seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: int) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (value: float) = Interop.mkAttr "clearText" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   CSS media query when `Mobile` mode will be changed to `Desktop`.
  static member inline desktopModeMediaQuery (value: string) = Interop.mkAttr "desktopModeMediaQuery" value
  ///   Props applied to the
  ///
  /// [`Dialog`](https://mui.com/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Ok button text.
  static member inline okText (value: ReactElement) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: ReactElement seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: string) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: string seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: int) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (value: float) = Interop.mkAttr "okText" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  ///   Paper props passed down to [Paper](https://mui.com/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Popper props passed down to [Popper](https://mui.com/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for day. Check the [PickersDay](https://mui.com/api/pickers-day/) component.
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, the today button is displayed. **Note** that `showClearButton` has a higher priority.
  static member inline showTodayButton (value: bool) = Interop.mkAttr "showTodayButton" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Today text message.
  static member inline todayText (value: ReactElement) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: ReactElement seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: string) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: string seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: int) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (value: float) = Interop.mkAttr "todayText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  ///   Custom component for popper [Transition](https://mui.com/components/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module datePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline month = Interop.mkAttr "views" "month"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type dateRangePicker =
  /// Callback fired when the value (the selected date range) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `startProps` and `endProps` arguments of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api), that you need to forward to the range start/end inputs respectively. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// The value of the date range picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  ///   The number of calendars that render on **desktop**.
  static member inline calendars (value: TODO) = Interop.mkAttr "calendars" value
  /// Cancel text message.
  static member inline cancelText (value: ReactElement) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: ReactElement seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: string) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: string seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: int) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (value: float) = Interop.mkAttr "cancelText" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true`, it shows the clear action in the picker dialog.
  static member inline clearable (value: bool) = Interop.mkAttr "clearable" value
  /// Clear text message.
  static member inline clearText (value: ReactElement) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: ReactElement seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: string seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: int) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (value: float) = Interop.mkAttr "clearText" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   CSS media query when `Mobile` mode will be changed to `Desktop`.
  static member inline desktopModeMediaQuery (value: string) = Interop.mkAttr "desktopModeMediaQuery" value
  ///   Props applied to the
  ///
  /// [`Dialog`](https://mui.com/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  ///   If `true`, after selecting `start` date calendar will not automatically switch to the month of `end` date.
  static member inline disableAutoMonthSwitching (value: bool) = Interop.mkAttr "disableAutoMonthSwitching" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: ReactElement) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: ReactElement seq) = Interop.mkAttr "endText" values
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: string) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: string seq) = Interop.mkAttr "endText" values
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: int) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: float) = Interop.mkAttr "endText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Ok button text.
  static member inline okText (value: ReactElement) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: ReactElement seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: string) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: string seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: int) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (value: float) = Interop.mkAttr "okText" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  ///   Paper props passed down to [Paper](https://mui.com/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Popper props passed down to [Popper](https://mui.com/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for `` days. @DateIOType
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, the today button is displayed. **Note** that `showClearButton` has a higher priority.
  static member inline showTodayButton (value: bool) = Interop.mkAttr "showTodayButton" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: ReactElement) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: ReactElement seq) = Interop.mkAttr "startText" values
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: string) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: string seq) = Interop.mkAttr "startText" values
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: int) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: float) = Interop.mkAttr "startText" value
  /// Today text message.
  static member inline todayText (value: ReactElement) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: ReactElement seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: string) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: string seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: int) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (value: float) = Interop.mkAttr "todayText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  ///   Custom component for popper [Transition](https://mui.com/components/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module dateRangePicker =

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type dateRangePickerDay =
  /// The date to show.
  static member inline day (value: 'a) = Interop.mkAttr "day" value
  ///   Set to `true` if the `day` is the end of a highlighted date range.
  static member inline isEndOfHighlighting (value: bool) = Interop.mkAttr "isEndOfHighlighting" value
  ///   Set to `true` if the `day` is the start of a highlighted date range.
  static member inline isEndOfPreviewing (value: bool) = Interop.mkAttr "isEndOfPreviewing" value
  ///   Set to `true` if the `day` is in a highlighted date range.
  static member inline isHighlighting (value: bool) = Interop.mkAttr "isHighlighting" value
  ///   Set to `true` if the `day` is in a preview date range.
  static member inline isPreviewing (value: bool) = Interop.mkAttr "isPreviewing" value
  ///   Set to `true` if the `day` is the start of a highlighted date range.
  static member inline isStartOfHighlighting (value: bool) = Interop.mkAttr "isStartOfHighlighting" value
  ///   Set to `true` if the `day` is the end of a highlighted date range.
  static member inline isStartOfPreviewing (value: bool) = Interop.mkAttr "isStartOfPreviewing" value
  ///   If `true`, day is outside of month and will be hidden.
  static member inline outsideCurrentMonth (value: bool) = Interop.mkAttr "outsideCurrentMonth" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, renders as selected.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type dateTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// Cancel text message.
  static member inline cancelText (value: ReactElement) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: ReactElement seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: string) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: string seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: int) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (value: float) = Interop.mkAttr "cancelText" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true`, it shows the clear action in the picker dialog.
  static member inline clearable (value: bool) = Interop.mkAttr "clearable" value
  /// Clear text message.
  static member inline clearText (value: ReactElement) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: ReactElement seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: string seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: int) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (value: float) = Interop.mkAttr "clearText" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// Date tab icon.
  static member inline dateRangeIcon (element: ReactElement) = Interop.mkAttr "dateRangeIcon" element
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   CSS media query when `Mobile` mode will be changed to `Desktop`.
  static member inline desktopModeMediaQuery (value: string) = Interop.mkAttr "desktopModeMediaQuery" value
  ///   Props applied to the
  ///
  /// [`Dialog`](https://mui.com/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// To show tabs.
  static member inline hideTabs (value: bool) = Interop.mkAttr "hideTabs" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  ///   Minimal selectable moment of time with binding to date, to set max time in each day use `maxTime`.
  static member inline maxDateTime (value: 'a) = Interop.mkAttr "maxDateTime" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  ///   Minimal selectable moment of time with binding to date, to set min time in each day use `minTime`.
  static member inline minDateTime (value: 'a) = Interop.mkAttr "minDateTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Ok button text.
  static member inline okText (value: ReactElement) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: ReactElement seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: string) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: string seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: int) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (value: float) = Interop.mkAttr "okText" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  ///   Paper props passed down to [Paper](https://mui.com/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Popper props passed down to [Popper](https://mui.com/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for day. Check the [PickersDay](https://mui.com/api/pickers-day/) component.
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, the today button is displayed. **Note** that `showClearButton` has a higher priority.
  static member inline showTodayButton (value: bool) = Interop.mkAttr "showTodayButton" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Time tab icon.
  static member inline timeIcon (element: ReactElement) = Interop.mkAttr "timeIcon" element
  /// Today text message.
  static member inline todayText (value: ReactElement) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: ReactElement seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: string) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: string seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: int) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (value: float) = Interop.mkAttr "todayText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  ///   Custom component for popper [Transition](https://mui.com/components/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module dateTimePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline hours = Interop.mkAttr "views" "hours"
    static member inline minutes = Interop.mkAttr "views" "minutes"
    static member inline month = Interop.mkAttr "views" "month"
    static member inline seconds = Interop.mkAttr "views" "seconds"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type desktopDatePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  ///   Paper props passed down to [Paper](https://mui.com/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Popper props passed down to [Popper](https://mui.com/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for day. Check the [PickersDay](https://mui.com/api/pickers-day/) component.
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  ///   Custom component for popper [Transition](https://mui.com/components/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module desktopDatePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline month = Interop.mkAttr "views" "month"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type desktopDateRangePicker =
  /// Callback fired when the value (the selected date range) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `startProps` and `endProps` arguments of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api), that you need to forward to the range start/end inputs respectively. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// The value of the date range picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  ///   The number of calendars that render on **desktop**.
  static member inline calendars (value: TODO) = Interop.mkAttr "calendars" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   If `true`, after selecting `start` date calendar will not automatically switch to the month of `end` date.
  static member inline disableAutoMonthSwitching (value: bool) = Interop.mkAttr "disableAutoMonthSwitching" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: ReactElement) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: ReactElement seq) = Interop.mkAttr "endText" values
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: string) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: string seq) = Interop.mkAttr "endText" values
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: int) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: float) = Interop.mkAttr "endText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  ///   Paper props passed down to [Paper](https://mui.com/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Popper props passed down to [Popper](https://mui.com/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for `` days. @DateIOType
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: ReactElement) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: ReactElement seq) = Interop.mkAttr "startText" values
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: string) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: string seq) = Interop.mkAttr "startText" values
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: int) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: float) = Interop.mkAttr "startText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  ///   Custom component for popper [Transition](https://mui.com/components/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module desktopDateRangePicker =

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type desktopDateTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// Date tab icon.
  static member inline dateRangeIcon (element: ReactElement) = Interop.mkAttr "dateRangeIcon" element
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// To show tabs.
  static member inline hideTabs (value: bool) = Interop.mkAttr "hideTabs" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  ///   Minimal selectable moment of time with binding to date, to set max time in each day use `maxTime`.
  static member inline maxDateTime (value: 'a) = Interop.mkAttr "maxDateTime" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  ///   Minimal selectable moment of time with binding to date, to set min time in each day use `minTime`.
  static member inline minDateTime (value: 'a) = Interop.mkAttr "minDateTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  ///   Paper props passed down to [Paper](https://mui.com/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Popper props passed down to [Popper](https://mui.com/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for day. Check the [PickersDay](https://mui.com/api/pickers-day/) component.
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Time tab icon.
  static member inline timeIcon (element: ReactElement) = Interop.mkAttr "timeIcon" element
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  ///   Custom component for popper [Transition](https://mui.com/components/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module desktopDateTimePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline hours = Interop.mkAttr "views" "hours"
    static member inline minutes = Interop.mkAttr "views" "minutes"
    static member inline month = Interop.mkAttr "views" "month"
    static member inline seconds = Interop.mkAttr "views" "seconds"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type desktopTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  ///   Paper props passed down to [Paper](https://mui.com/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Popper props passed down to [Popper](https://mui.com/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  ///   Custom component for popper [Transition](https://mui.com/components/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module desktopTimePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'hours' = Interop.mkAttr "views" Array<'hours'
    static member inline minutes = Interop.mkAttr "views" "minutes"
    static member inline 'seconds'> = Interop.mkAttr "views" 'seconds'>


[<Erase>]
type dialog =
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The id(s) of the element(s) that describe the dialog.
  static member inline ariaDescribedby (value: string) = Interop.mkAttr "aria-describedby" value
  /// The id(s) of the element(s) that label the dialog.
  static member inline ariaLabelledby (value: string) = Interop.mkAttr "aria-labelledby" value
  /// A backdrop component. This prop enables custom backdrop rendering.
  static member inline BackdropComponent (value: ReactElementType) = Interop.mkAttr "BackdropComponent" value
  /// Dialog children, usually the included sub-components.
  static member inline children (element: ReactElement) = prop.children element
  /// Dialog children, usually the included sub-components.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Dialog children, usually the included sub-components.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Dialog children, usually the included sub-components.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Dialog children, usually the included sub-components.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Dialog children, usually the included sub-components.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, hitting escape will not fire the `onClose` callback.
  static member inline disableEscapeKeyDown (value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  ///   If `true`, the dialog is full-screen.
  static member inline fullScreen (value: bool) = Interop.mkAttr "fullScreen" value
  ///   If `true`, the dialog stretches to `maxWidth`.
  ///
  /// Notice that the dialog width grow is limited by the default margin.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick (handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: Event -> DialogCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: DialogCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  /// The component used to render the body of the dialog.
  static member inline PaperComponent (value: ReactElementType) = Interop.mkAttr "PaperComponent" value
  ///   Props applied to the
  ///
  /// [`Paper`](https://mui.com/api/paper/) element.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The component used for the transition. [Follow this guide](https://mui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module dialog =

  ///   Determine the max-width of the dialog. The dialog width grows with the size of the screen. Set to `false` to disable `maxWidth`.
  [<Erase>]
  type maxWidth =
    static member inline xs = Interop.mkAttr "maxWidth" "xs"
    static member inline sm = Interop.mkAttr "maxWidth" "sm"
    static member inline md = Interop.mkAttr "maxWidth" "md"
    static member inline lg = Interop.mkAttr "maxWidth" "lg"
    static member inline xl = Interop.mkAttr "maxWidth" "xl"
    static member inline false' = Interop.mkAttr "maxWidth" false
    static member inline string = Interop.mkAttr "maxWidth" string

  /// Determine the container for scrolling the dialog.
  [<Erase>]
  type scroll =
    static member inline body = Interop.mkAttr "scroll" "body"
    static member inline paper = Interop.mkAttr "scroll" "paper"


[<Erase>]
type dialogActions =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the actions do not have additional margin.
  static member inline disableSpacing (value: bool) = Interop.mkAttr "disableSpacing" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type dialogContent =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Display the top and bottom dividers.
  static member inline dividers (value: bool) = Interop.mkAttr "dividers" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type dialogContentText =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type dialogTitle =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type divider =
  /// Absolutely position the element.
  static member inline absolute (value: bool) = Interop.mkAttr "absolute" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, a vertical divider will have the correct height when used in flex container. (By default, a vertical divider will have a calculated height of `0px` if it is the child of a flex container.)
  static member inline flexItem (value: bool) = Interop.mkAttr "flexItem" value
  ///   If `true`, the divider will have a lighter color.
  static member inline light (value: bool) = Interop.mkAttr "light" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module divider =

  /// The component orientation.
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The text alignment.
  [<Erase>]
  type textAlign =
    static member inline center = Interop.mkAttr "textAlign" "center"
    static member inline left = Interop.mkAttr "textAlign" "left"
    static member inline right = Interop.mkAttr "textAlign" "right"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline fullWidth = Interop.mkAttr "variant" "fullWidth"
    static member inline inset = Interop.mkAttr "variant" "inset"
    static member inline middle = Interop.mkAttr "variant" "middle"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type drawer =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The elevation of the drawer.
  static member inline elevation (value: TODO) = Interop.mkAttr "elevation" value
  ///   If `true`, the backdrop is not rendered.
  static member inline hideBackdrop (value: bool) = Interop.mkAttr "hideBackdrop" value
  ///   Props applied to the
  ///
  /// [`Modal`](https://mui.com/api/modal/) element.
  static member inline ModalProps (props: IReactProperty list) = Interop.mkAttr "ModalProps" (createObj !!props)
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  ///   Props applied to the
  ///
  /// [`Paper`](https://mui.com/api/paper/) element.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Props applied to the
  ///
  /// [`Slide`](https://mui.com/api/slide/) element.
  static member inline SlideProps (props: IReactProperty list) = Interop.mkAttr "SlideProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)

module drawer =

  /// Side from which the drawer will appear.
  [<Erase>]
  type anchor =
    static member inline bottom = Interop.mkAttr "anchor" "bottom"
    static member inline left = Interop.mkAttr "anchor" "left"
    static member inline right = Interop.mkAttr "anchor" "right"
    static member inline top = Interop.mkAttr "anchor" "top"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline permanent = Interop.mkAttr "variant" "permanent"
    static member inline persistent = Interop.mkAttr "variant" "persistent"
    static member inline temporary = Interop.mkAttr "variant" "temporary"


[<Erase>]
type fab =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the keyboard focus ripple is disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  ///   If `true`, the ripple effect is disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  ///   The URL to link to when the button is clicked. If defined, an `a` element will be used as the root node.
  static member inline href (value: string) = Interop.mkAttr "href" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module fab =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline string = Interop.mkAttr "color" string

  ///   The size of the component. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline circular = Interop.mkAttr "variant" "circular"
    static member inline extended = Interop.mkAttr "variant" "extended"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type fade =
  ///   A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Add a custom transition end trigger. Called with the transitioning DOM node and a done callback. Allows for more fine grained transition end logic. Note: Timeouts are still used as a fallback if provided.
  static member inline addEndListener (value: TODO) = Interop.mkAttr "addEndListener" value
  ///   Perform the enter transition when it first mounts if `in` is also `true`. Set this to `false` to disable this behavior.
  static member inline appear (value: bool) = Interop.mkAttr "appear" value
  /// The transition timing function. You may specify a single easing or a object containing enter and exit values.
  static member inline easing (value: TODO) = Interop.mkAttr "easing" value
  ///   If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)


[<Erase>]
type filledInput =
  ///   This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  ///   If `true`, the `input` element is focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The components used for each slot inside the InputBase. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Input.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the component is disabled. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the input will not have an underline.
  static member inline disableUnderline (value: bool) = Interop.mkAttr "disableUnderline" value
  ///   End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  ///   If `true`, the `input` will indicate an error. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the `input` will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   If `true`, the label is hidden. This is used to increase density for a `FilledInput`. Be sure to add `aria-label` to the `input` element.
  static member inline hiddenLabel (value: bool) = Interop.mkAttr "hiddenLabel" value
  ///   The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: string) = Interop.mkAttr "inputComponent" value
  ///   The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline maxRows (value: int) = Interop.mkAttr "maxRows" value
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline minRows (value: int) = Interop.mkAttr "minRows" value
  ///   If `true`, a `textarea` element is rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  ///   Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  ///   The short hint displayed in the `input` before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  ///   If `true`, the `input` element is required. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  ///   Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  ///   The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module filledInput =

  ///   The color of the component. The prop defaults to the value (`'primary'`) inherited from the parent FormControl component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline string = Interop.mkAttr "color" string

  ///   If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl. The prop defaults to the value (`'none'`) inherited from the parent FormControl component.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type formControl =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the label, input and helper text should be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the label is displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the component is displayed in focused state.
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  ///   If `true`, the component will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   If `true`, the label is hidden. This is used to increase density for a `FilledInput`. Be sure to add `aria-label` to the `input` element.
  static member inline hiddenLabel (value: bool) = Interop.mkAttr "hiddenLabel" value
  ///   If `true`, the label will indicate that the `input` is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module formControl =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  ///   If `dense` or `normal`, will adjust vertical spacing of this and contained components.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"
    static member inline normal = Interop.mkAttr "margin" "normal"

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"
    static member inline string = Interop.mkAttr "size" string

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type formControlLabel =
  ///   A control element. For instance, it can be a `Radio`, a `Switch` or a `Checkbox`.
  static member inline control (value: ReactElement) = Interop.mkAttr "control" value
  /// A text or an element to be used in an enclosing label element.
  static member inline label (value: TODO) = Interop.mkAttr "label" value
  ///   If `true`, the component appears selected.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   If `true`, the control is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the label is rendered as it is passed without an additional typography node.
  static member inline disableTypography (value: bool) = Interop.mkAttr "disableTypography" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  ///   Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The value of the component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module formControlLabel =

  /// The position of the label.
  [<Erase>]
  type labelPlacement =
    static member inline bottom = Interop.mkAttr "labelPlacement" "bottom"
    static member inline end' = Interop.mkAttr "labelPlacement" "end"
    static member inline start = Interop.mkAttr "labelPlacement" "start"
    static member inline top = Interop.mkAttr "labelPlacement" "top"


[<Erase>]
type formControlUnstyled =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Class name applied to the root element.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the FormControl. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  ///   If `true`, the label, input and helper text should be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the label is displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the component is displayed in focused state.
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  ///   If `true`, the label will indicate that the `input` is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value


[<Erase>]
type formGroup =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Display group of elements in a compact row.
  static member inline row (value: bool) = Interop.mkAttr "row" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type formHelperText =
  ///   The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the helper text should be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, helper text should be displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the helper text should use filled classes key.
  static member inline filled (value: bool) = Interop.mkAttr "filled" value
  ///   If `true`, the helper text should use focused classes key.
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  ///   If `true`, the helper text should use required classes key.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module formHelperText =

  ///   If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type formLabel =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the label should be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the label is displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the label should use filled classes key.
  static member inline filled (value: bool) = Interop.mkAttr "filled" value
  ///   If `true`, the input of this label is focused (used by `FormGroup` components).
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  ///   If `true`, the label will indicate that the `input` is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module formLabel =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string


[<Erase>]
type globalStyles =
  /// The styles you want to apply globally.
  static member inline styles (value: bool) = Interop.mkAttr "styles" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type grid =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The number of columns.
  static member inline columns (value: TODO) = Interop.mkAttr "columns" value
  ///   Defines the horizontal space between the type `item` components. It overrides the value of the `spacing` prop.
  static member inline columnSpacing (value: TODO) = Interop.mkAttr "columnSpacing" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the component will have the flex *container* behavior. You should be wrapping *items* with a *container*.
  static member inline container (value: bool) = Interop.mkAttr "container" value
  ///   If `true`, the component will have the flex *item* behavior. You should be wrapping *items* with a *container*.
  static member inline item (value: bool) = Interop.mkAttr "item" value
  ///   If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for the `lg` breakpoint and wider screens if not overridden.
  static member inline lg (value: bool) = Interop.mkAttr "lg" value
  ///   If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for the `md` breakpoint and wider screens if not overridden.
  static member inline md (value: bool) = Interop.mkAttr "md" value
  ///   Defines the vertical space between the type `item` components. It overrides the value of the `spacing` prop.
  static member inline rowSpacing (value: TODO) = Interop.mkAttr "rowSpacing" value
  ///   If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for the `sm` breakpoint and wider screens if not overridden.
  static member inline sm (value: bool) = Interop.mkAttr "sm" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for the `xl` breakpoint and wider screens if not overridden.
  static member inline xl (value: bool) = Interop.mkAttr "xl" value
  /// If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for all the screen sizes with the lowest priority.
  static member inline xs (value: bool) = Interop.mkAttr "xs" value
  ///   If `true`, it sets `min-width: 0` on the item. Refer to the limitations section of the documentation to better understand the use case.
  static member inline zeroMinWidth (value: bool) = Interop.mkAttr "zeroMinWidth" value

module grid =

  ///   Defines the `flex-direction` style property. It is applied for all screen sizes.
  [<Erase>]
  type direction =
    static member inline columnReverse = Interop.mkAttr "direction" "column-reverse"
    static member inline column = Interop.mkAttr "direction" "column"
    static member inline rowReverse = Interop.mkAttr "direction" "row-reverse"
    static member inline row = Interop.mkAttr "direction" "row"
    static member inline Array<'columnReverse' = Interop.mkAttr "direction" Array<'column-reverse'
    static member inline column = Interop.mkAttr "direction" "column"
    static member inline rowReverse = Interop.mkAttr "direction" "row-reverse"
    static member inline 'row'> = Interop.mkAttr "direction" 'row'>
    static member inline object = Interop.mkAttr "direction" object

  ///   If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for the `lg` breakpoint and wider screens if not overridden.
  [<Erase>]
  type lg =
    static member inline auto = Interop.mkAttr "lg" "auto"

  ///   If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for the `md` breakpoint and wider screens if not overridden.
  [<Erase>]
  type md =
    static member inline auto = Interop.mkAttr "md" "auto"

  ///   If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for the `sm` breakpoint and wider screens if not overridden.
  [<Erase>]
  type sm =
    static member inline auto = Interop.mkAttr "sm" "auto"

  ///   Defines the space between the type `item` components. It can only be used on a type `container` component.
  [<Erase>]
  type spacing =
    static member inline Array<number = Interop.mkAttr "spacing" Array<number
    static member inline string> = Interop.mkAttr "spacing" string>
    static member inline object = Interop.mkAttr "spacing" object
    static member inline string = Interop.mkAttr "spacing" string

  ///   Defines the `flex-wrap` style property. It's applied for all screen sizes.
  [<Erase>]
  type wrap =
    static member inline nowrap = Interop.mkAttr "wrap" "nowrap"
    static member inline wrapReverse = Interop.mkAttr "wrap" "wrap-reverse"
    static member inline wrap = Interop.mkAttr "wrap" "wrap"

  ///   If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for the `xl` breakpoint and wider screens if not overridden.
  [<Erase>]
  type xl =
    static member inline auto = Interop.mkAttr "xl" "auto"

  /// If a number, it sets the number of columns the grid item uses. It can't be greater than the total number of columns of the container (12 by default). If 'auto', the grid item's width matches its content. If false, the prop is ignored. If true, the grid item's width grows to use the space available in the grid container. The value is applied for all the screen sizes with the lowest priority.
  [<Erase>]
  type xs =
    static member inline auto = Interop.mkAttr "xs" "auto"


[<Erase>]
type grow =
  ///   A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Add a custom transition end trigger. Called with the transitioning DOM node and a done callback. Allows for more fine grained transition end logic. Note: Timeouts are still used as a fallback if provided.
  static member inline addEndListener (value: TODO) = Interop.mkAttr "addEndListener" value
  ///   Perform the enter transition when it first mounts if `in` is also `true`. Set this to `false` to disable this behavior.
  static member inline appear (value: bool) = Interop.mkAttr "appear" value
  /// The transition timing function. You may specify a single easing or a object containing enter and exit values.
  static member inline easing (value: TODO) = Interop.mkAttr "easing" value
  ///   If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)

module grow =

  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  [<Erase>]
  type timeout =
    static member inline auto = Interop.mkAttr "timeout" "auto"


[<Erase>]
type hidden =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, screens this size and down are hidden.
  static member inline lgDown (value: bool) = Interop.mkAttr "lgDown" value
  ///   If `true`, screens this size and up are hidden.
  static member inline lgUp (value: bool) = Interop.mkAttr "lgUp" value
  ///   If `true`, screens this size and down are hidden.
  static member inline mdDown (value: bool) = Interop.mkAttr "mdDown" value
  ///   If `true`, screens this size and up are hidden.
  static member inline mdUp (value: bool) = Interop.mkAttr "mdUp" value
  /// Hide the given breakpoint(s).
  static member inline only ([<ParamArray>] values: BreakpointKey []) = Interop.mkAttr "only" values
  ///   If `true`, screens this size and down are hidden.
  static member inline smDown (value: bool) = Interop.mkAttr "smDown" value
  ///   If `true`, screens this size and up are hidden.
  static member inline smUp (value: bool) = Interop.mkAttr "smUp" value
  ///   If `true`, screens this size and down are hidden.
  static member inline xlDown (value: bool) = Interop.mkAttr "xlDown" value
  ///   If `true`, screens this size and up are hidden.
  static member inline xlUp (value: bool) = Interop.mkAttr "xlUp" value
  ///   If `true`, screens this size and down are hidden.
  static member inline xsDown (value: bool) = Interop.mkAttr "xsDown" value
  ///   If `true`, screens this size and up are hidden.
  static member inline xsUp (value: bool) = Interop.mkAttr "xsUp" value

module hidden =

  /// Specify which implementation to use. 'js' is the default, 'css' works better for server-side rendering.
  [<Erase>]
  type implementation =
    static member inline css = Interop.mkAttr "implementation" "css"
    static member inline js = Interop.mkAttr "implementation" "js"

  ///   You can use this prop when choosing the `js` implementation with server-side rendering.
  ///
  /// As `window.innerWidth` is unavailable on the server, we default to rendering an empty component during the first mount. You might want to use a heuristic to approximate the screen width of the client browser screen width.
  ///
  /// For instance, you could be using the user-agent or the client-hints. https://caniuse.com/#search=client%20hint
  [<Erase>]
  type initialWidth =
    static member inline xs = Interop.mkAttr "initialWidth" "xs"
    static member inline sm = Interop.mkAttr "initialWidth" "sm"
    static member inline md = Interop.mkAttr "initialWidth" "md"
    static member inline lg = Interop.mkAttr "initialWidth" "lg"
    static member inline xl = Interop.mkAttr "initialWidth" "xl"

  /// Hide the given breakpoint(s).
  [<Erase>]
  type only =
    static member inline xs = Interop.mkAttr "only" "xs"
    static member inline sm = Interop.mkAttr "only" "sm"
    static member inline md = Interop.mkAttr "only" "md"
    static member inline lg = Interop.mkAttr "only" "lg"
    static member inline xl = Interop.mkAttr "only" "xl"


[<Erase>]
type icon =
  /// The base class applied to the icon. Defaults to 'material-icons', but can be changed to any other base class that suits the icon font you're using (e.g. material-icons-rounded, fas, etc).
  static member inline baseClassName (value: string) = Interop.mkAttr "baseClassName" value
  /// The name of the icon font ligature.
  static member inline children (element: ReactElement) = prop.children element
  /// The name of the icon font ligature.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The name of the icon font ligature.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The name of the icon font ligature.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The name of the icon font ligature.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The name of the icon font ligature.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module icon =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline action = Interop.mkAttr "color" "action"
    static member inline disabled = Interop.mkAttr "color" "disabled"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// The fontSize applied to the icon. Defaults to 24px, but can be configure to inherit font size.
  [<Erase>]
  type fontSize =
    static member inline inherit' = Interop.mkAttr "fontSize" "inherit"
    static member inline large = Interop.mkAttr "fontSize" "large"
    static member inline medium = Interop.mkAttr "fontSize" "medium"
    static member inline small = Interop.mkAttr "fontSize" "small"
    static member inline string = Interop.mkAttr "fontSize" string


[<Erase>]
type iconButton =
  /// The icon to display.
  static member inline children (element: ReactElement) = prop.children element
  /// The icon to display.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The icon to display.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The icon to display.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The icon to display.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The icon to display.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the keyboard focus ripple is disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  ///   If `true`, the ripple effect is disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `.Mui-focusVisible` class.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module iconButton =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// If given, uses a negative margin to counteract the padding on one side (this is often helpful for aligning the left or right side of the icon with content above or below, without ruining the border size and shape).
  [<Erase>]
  type edge =
    static member inline end' = Interop.mkAttr "edge" "end"
    static member inline start = Interop.mkAttr "edge" "start"
    static member inline false' = Interop.mkAttr "edge" false

  ///   The size of the component. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type imageList =
  ///   The content of the component, normally `ImageListItem`s.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally `ImageListItem`s.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally `ImageListItem`s.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally `ImageListItem`s.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally `ImageListItem`s.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally `ImageListItem`s.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Number of columns.
  static member inline cols (value: TODO) = Interop.mkAttr "cols" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The gap between items in px.
  static member inline gap (value: int) = Interop.mkAttr "gap" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module imageList =

  /// The height of one row in px.
  [<Erase>]
  type rowHeight =
    static member inline auto = Interop.mkAttr "rowHeight" "auto"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline masonry = Interop.mkAttr "variant" "masonry"
    static member inline quilted = Interop.mkAttr "variant" "quilted"
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline woven = Interop.mkAttr "variant" "woven"


[<Erase>]
type imageListItem =
  ///   The content of the component, normally an ``.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally an ``.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally an ``.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally an ``.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally an ``.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally an ``.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Width of the item in number of grid columns.
  static member inline cols (value: TODO) = Interop.mkAttr "cols" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Height of the item in number of grid rows.
  static member inline rows (value: TODO) = Interop.mkAttr "rows" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type imageListItemBar =
  /// An IconButton element to be used as secondary action target (primary action target is the item itself).
  static member inline actionIcon (element: ReactElement) = Interop.mkAttr "actionIcon" element
  /// String or element serving as subtitle (support text).
  static member inline subtitle (value: ReactElement) = Interop.mkAttr "subtitle" value
  /// String or element serving as subtitle (support text).
  static member inline subtitle (values: ReactElement seq) = Interop.mkAttr "subtitle" values
  /// String or element serving as subtitle (support text).
  static member inline subtitle (value: string) = Interop.mkAttr "subtitle" value
  /// String or element serving as subtitle (support text).
  static member inline subtitle (values: string seq) = Interop.mkAttr "subtitle" values
  /// String or element serving as subtitle (support text).
  static member inline subtitle (value: int) = Interop.mkAttr "subtitle" value
  /// String or element serving as subtitle (support text).
  static member inline subtitle (value: float) = Interop.mkAttr "subtitle" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// Title to be displayed.
  static member inline title (value: ReactElement) = Interop.mkAttr "title" value
  /// Title to be displayed.
  static member inline title (values: ReactElement seq) = Interop.mkAttr "title" values
  /// Title to be displayed.
  static member inline title (value: string) = Interop.mkAttr "title" value
  /// Title to be displayed.
  static member inline title (values: string seq) = Interop.mkAttr "title" values
  /// Title to be displayed.
  static member inline title (value: int) = Interop.mkAttr "title" value
  /// Title to be displayed.
  static member inline title (value: float) = Interop.mkAttr "title" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module imageListItemBar =

  /// Position of secondary action IconButton.
  [<Erase>]
  type actionPosition =
    static member inline left = Interop.mkAttr "actionPosition" "left"
    static member inline right = Interop.mkAttr "actionPosition" "right"

  /// Position of the title bar.
  [<Erase>]
  type position =
    static member inline below = Interop.mkAttr "position" "below"
    static member inline bottom = Interop.mkAttr "position" "bottom"
    static member inline top = Interop.mkAttr "position" "top"


[<Erase>]
type input =
  ///   This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  ///   If `true`, the `input` element is focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The components used for each slot inside the InputBase. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Input.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the component is disabled. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the `input` will not have an underline.
  static member inline disableUnderline (value: bool) = Interop.mkAttr "disableUnderline" value
  ///   End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  ///   If `true`, the `input` will indicate an error. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the `input` will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: string) = Interop.mkAttr "inputComponent" value
  ///   The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline maxRows (value: int) = Interop.mkAttr "maxRows" value
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline minRows (value: int) = Interop.mkAttr "minRows" value
  ///   If `true`, a `textarea` element is rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  ///   Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  ///   The short hint displayed in the `input` before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  ///   If `true`, the `input` element is required. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  ///   Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  ///   The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module input =

  ///   The color of the component. The prop defaults to the value (`'primary'`) inherited from the parent FormControl component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline string = Interop.mkAttr "color" string

  ///   If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl. The prop defaults to the value (`'none'`) inherited from the parent FormControl component.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type inputAdornment =
  ///   The content of the component, normally an `IconButton` or string.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally an `IconButton` or string.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally an `IconButton` or string.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally an `IconButton` or string.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally an `IconButton` or string.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally an `IconButton` or string.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Disable pointer events on the root. This allows for the content of the adornment to focus the `input` on click.
  static member inline disablePointerEvents (value: bool) = Interop.mkAttr "disablePointerEvents" value
  /// If children is a string then disable wrapping in a Typography component.
  static member inline disableTypography (value: bool) = Interop.mkAttr "disableTypography" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module inputAdornment =

  ///   The position this adornment should appear relative to the `Input`.
  [<Erase>]
  type position =
    static member inline end' = Interop.mkAttr "position" "end"
    static member inline start = Interop.mkAttr "position" "start"

  ///   The variant to use. Note: If you are using the `TextField` component or the `FormControl` component you do not have to set this manually.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type inputBase =
  ///   This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  ///   If `true`, the `input` element is focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The components used for each slot inside the InputBase. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Input.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the component is disabled. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, GlobalStyles for the auto-fill keyframes will not be injected/removed on mount/unmount. Make sure to inject them at the top of your application. This option is intended to help with boosting the initial rendering performance if you are loading a big amount of Input components at once.
  static member inline disableInjectingGlobalStyles (value: bool) = Interop.mkAttr "disableInjectingGlobalStyles" value
  ///   End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  ///   If `true`, the `input` will indicate an error. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the `input` will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   The component used for the `input` element. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline maxRows (value: int) = Interop.mkAttr "maxRows" value
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline minRows (value: int) = Interop.mkAttr "minRows" value
  ///   If `true`, a `textarea` element is rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  ///   Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback fired when the `input` is blurred.
  ///
  /// Notice that the first argument (event) might be undefined.
  static member inline onBlur (handler: Event option -> unit) = Interop.mkAttr "onBlur" handler
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  ///   The short hint displayed in the `input` before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  ///   If `true`, the `input` element is required. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  ///   Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  ///   The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module inputBase =

  ///   The color of the component. The prop defaults to the value (`'primary'`) inherited from the parent FormControl component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  ///   If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl. The prop defaults to the value (`'none'`) inherited from the parent FormControl component.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type inputLabel =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the transition animation is disabled.
  static member inline disableAnimation (value: bool) = Interop.mkAttr "disableAnimation" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the label is displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the `input` of this label is focused.
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  ///   if `true`, the label will indicate that the `input` is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  ///   If `true`, the label is shrunk.
  static member inline shrink (value: bool) = Interop.mkAttr "shrink" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module inputLabel =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  ///   If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type inputUnstyled =
  ///   This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  ///   If `true`, the `input` element is focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// Class name applied to the root element.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the InputBase. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Input.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the component is disabled. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Trailing adornment for this input.
  static member inline endAdornment (value: ReactElement) = Interop.mkAttr "endAdornment" value
  /// Trailing adornment for this input.
  static member inline endAdornment (values: ReactElement seq) = Interop.mkAttr "endAdornment" values
  /// Trailing adornment for this input.
  static member inline endAdornment (value: string) = Interop.mkAttr "endAdornment" value
  /// Trailing adornment for this input.
  static member inline endAdornment (values: string seq) = Interop.mkAttr "endAdornment" values
  /// Trailing adornment for this input.
  static member inline endAdornment (value: int) = Interop.mkAttr "endAdornment" value
  /// Trailing adornment for this input.
  static member inline endAdornment (value: float) = Interop.mkAttr "endAdornment" value
  ///   If `true`, the `input` will indicate an error. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline maxRows (value: int) = Interop.mkAttr "maxRows" value
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline minRows (value: int) = Interop.mkAttr "minRows" value
  ///   If `true`, a `textarea` element is rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  ///   Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   The short hint displayed in the `input` before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  ///   If `true`, the `input` element is required. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// Leading adornment for this input.
  static member inline startAdornment (value: ReactElement) = Interop.mkAttr "startAdornment" value
  /// Leading adornment for this input.
  static member inline startAdornment (values: ReactElement seq) = Interop.mkAttr "startAdornment" values
  /// Leading adornment for this input.
  static member inline startAdornment (value: string) = Interop.mkAttr "startAdornment" value
  /// Leading adornment for this input.
  static member inline startAdornment (values: string seq) = Interop.mkAttr "startAdornment" values
  /// Leading adornment for this input.
  static member inline startAdornment (value: int) = Interop.mkAttr "startAdornment" value
  /// Leading adornment for this input.
  static member inline startAdornment (value: float) = Interop.mkAttr "startAdornment" value
  ///   Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  ///   The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type linearProgress =
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The value of the progress indicator for the determinate and buffer variants. Value between 0 and 100.
  static member inline value (value: int) = Interop.mkAttr "value" value
  /// The value for the buffer variant. Value between 0 and 100.
  static member inline valueBuffer (value: int) = Interop.mkAttr "valueBuffer" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module linearProgress =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline string = Interop.mkAttr "color" string

  /// The variant to use. Use indeterminate or query when there is no progress value.
  [<Erase>]
  type variant =
    static member inline buffer = Interop.mkAttr "variant" "buffer"
    static member inline determinate = Interop.mkAttr "variant" "determinate"
    static member inline indeterminate = Interop.mkAttr "variant" "indeterminate"
    static member inline query = Interop.mkAttr "variant" "query"


[<Erase>]
type link =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The color of the link.
  static member inline color (value: 'a) = Interop.mkAttr "color" value
  ///   The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  ///   The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module link =

  /// Controls when the link should have an underline.
  [<Erase>]
  type underline =
    static member inline always = Interop.mkAttr "underline" "always"
    static member inline hover = Interop.mkAttr "underline" "hover"
    static member inline none = Interop.mkAttr "underline" "none"

  /// Applies the theme typography styles.
  [<Erase>]
  type variant =
    static member inline body1 = Interop.mkAttr "variant" "body1"
    static member inline body2 = Interop.mkAttr "variant" "body2"
    static member inline button = Interop.mkAttr "variant" "button"
    static member inline caption = Interop.mkAttr "variant" "caption"
    static member inline h1 = Interop.mkAttr "variant" "h1"
    static member inline h2 = Interop.mkAttr "variant" "h2"
    static member inline h3 = Interop.mkAttr "variant" "h3"
    static member inline h4 = Interop.mkAttr "variant" "h4"
    static member inline h5 = Interop.mkAttr "variant" "h5"
    static member inline h6 = Interop.mkAttr "variant" "h6"
    static member inline inherit' = Interop.mkAttr "variant" "inherit"
    static member inline overline = Interop.mkAttr "variant" "overline"
    static member inline subtitle1 = Interop.mkAttr "variant" "subtitle1"
    static member inline subtitle2 = Interop.mkAttr "variant" "subtitle2"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type list =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, compact vertical padding designed for keyboard and mouse input is used for the list and list items. The prop is available to descendant components as the `dense` context.
  static member inline dense (value: bool) = Interop.mkAttr "dense" value
  ///   If `true`, vertical padding is removed from the list.
  static member inline disablePadding (value: bool) = Interop.mkAttr "disablePadding" value
  ///   The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: ReactElement) = Interop.mkAttr "subheader" value
  ///   The content of the subheader, normally `ListSubheader`.
  static member inline subheader (values: ReactElement seq) = Interop.mkAttr "subheader" values
  ///   The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: string) = Interop.mkAttr "subheader" value
  ///   The content of the subheader, normally `ListSubheader`.
  static member inline subheader (values: string seq) = Interop.mkAttr "subheader" values
  ///   The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: int) = Interop.mkAttr "subheader" value
  ///   The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: float) = Interop.mkAttr "subheader" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type listItem =
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  /// **Deprecated** -
  ///
  ///       checkout [ListItemButton](https://mui.com/api/list-item-button/) instead
  ///
  ///   If `true`, the list item is focused during the first mount. Focus will also be triggered if the value changes from false to true.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  /// **Deprecated** -
  ///
  ///       checkout [ListItemButton](https://mui.com/api/list-item-button/) instead
  ///
  ///   If `true`, the list item is a button (using `ButtonBase`). Props intended for `ButtonBase` can then be applied to `ListItem`.
  static member inline button (value: bool) = Interop.mkAttr "button" value
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the InputBase. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Input.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  /// **Deprecated**
  ///
  ///   The container component used when a `ListItemSecondaryAction` is the last child.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline ContainerComponent (value: ReactElementType) = Interop.mkAttr "ContainerComponent" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  /// **Deprecated**
  ///
  /// Props applied to the container component if used.
  static member inline ContainerProps (props: IReactProperty list) = Interop.mkAttr "ContainerProps" (createObj !!props)
  ///   If `true`, compact vertical padding designed for keyboard and mouse input is used. The prop defaults to the value inherited from the parent List component.
  static member inline dense (value: bool) = Interop.mkAttr "dense" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  /// **Deprecated** -
  ///
  ///       checkout [ListItemButton](https://mui.com/api/list-item-button/) instead
  ///
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the left and right padding is removed.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  ///   If `true`, all padding is removed.
  static member inline disablePadding (value: bool) = Interop.mkAttr "disablePadding" value
  ///   If `true`, a 1px light border is added to the bottom of the list item.
  static member inline divider (value: bool) = Interop.mkAttr "divider" value
  /// The element to display at the end of ListItem.
  static member inline secondaryAction (value: ReactElement) = Interop.mkAttr "secondaryAction" value
  /// The element to display at the end of ListItem.
  static member inline secondaryAction (values: ReactElement seq) = Interop.mkAttr "secondaryAction" values
  /// The element to display at the end of ListItem.
  static member inline secondaryAction (value: string) = Interop.mkAttr "secondaryAction" value
  /// The element to display at the end of ListItem.
  static member inline secondaryAction (values: string seq) = Interop.mkAttr "secondaryAction" values
  /// The element to display at the end of ListItem.
  static member inline secondaryAction (value: int) = Interop.mkAttr "secondaryAction" value
  /// The element to display at the end of ListItem.
  static member inline secondaryAction (value: float) = Interop.mkAttr "secondaryAction" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  /// **Deprecated** -
  ///
  ///       checkout [ListItemButton](https://mui.com/api/list-item-button/) instead
  ///
  /// Use to apply selected styling.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module listItem =

  ///   Defines the `align-items` style property.
  [<Erase>]
  type alignItems =
    static member inline center = Interop.mkAttr "alignItems" "center"
    static member inline flexStart = Interop.mkAttr "alignItems" "flex-start"


[<Erase>]
type listItemAvatar =
  ///   The content of the component, normally an `Avatar`.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally an `Avatar`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally an `Avatar`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally an `Avatar`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally an `Avatar`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally an `Avatar`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type listItemButton =
  ///   If `true`, the list item is focused during the first mount. Focus will also be triggered if the value changes from false to true.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component if a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, compact vertical padding designed for keyboard and mouse input is used. The prop defaults to the value inherited from the parent List component.
  static member inline dense (value: bool) = Interop.mkAttr "dense" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the left and right padding is removed.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  ///   If `true`, a 1px light border is added to the bottom of the list item.
  static member inline divider (value: bool) = Interop.mkAttr "divider" value
  ///   This prop can help identify which element has keyboard focus. The class name will be applied when the element gains the focus through keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/HEAD/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// Use to apply selected styling.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module listItemButton =

  ///   Defines the `align-items` style property.
  [<Erase>]
  type alignItems =
    static member inline center = Interop.mkAttr "alignItems" "center"
    static member inline flexStart = Interop.mkAttr "alignItems" "flex-start"


[<Erase>]
type listItemIcon =
  ///   The content of the component, normally `Icon`, `SvgIcon`, or a `@mui/icons-material` SVG icon element.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally `Icon`, `SvgIcon`, or a `@mui/icons-material` SVG icon element.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally `Icon`, `SvgIcon`, or a `@mui/icons-material` SVG icon element.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally `Icon`, `SvgIcon`, or a `@mui/icons-material` SVG icon element.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally `Icon`, `SvgIcon`, or a `@mui/icons-material` SVG icon element.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally `Icon`, `SvgIcon`, or a `@mui/icons-material` SVG icon element.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type listItemSecondaryAction =
  ///   The content of the component, normally an `IconButton` or selection control.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally an `IconButton` or selection control.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally an `IconButton` or selection control.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally an `IconButton` or selection control.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally an `IconButton` or selection control.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally an `IconButton` or selection control.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type listItemText =
  ///   Alias for the `primary` prop.
  static member inline children (element: ReactElement) = prop.children element
  ///   Alias for the `primary` prop.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   Alias for the `primary` prop.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   Alias for the `primary` prop.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   Alias for the `primary` prop.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   Alias for the `primary` prop.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the children won't be wrapped by a Typography component. This can be useful to render an alternative Typography variant by wrapping the `children` (or `primary`) text, and optional `secondary` text with the Typography component.
  static member inline disableTypography (value: bool) = Interop.mkAttr "disableTypography" value
  ///   If `true`, the children are indented. This should be used if there is no left avatar or left icon.
  static member inline inset (value: bool) = Interop.mkAttr "inset" value
  /// The main content element.
  static member inline primary (value: ReactElement) = Interop.mkAttr "primary" value
  /// The main content element.
  static member inline primary (values: ReactElement seq) = Interop.mkAttr "primary" values
  /// The main content element.
  static member inline primary (value: string) = Interop.mkAttr "primary" value
  /// The main content element.
  static member inline primary (values: string seq) = Interop.mkAttr "primary" values
  /// The main content element.
  static member inline primary (value: int) = Interop.mkAttr "primary" value
  /// The main content element.
  static member inline primary (value: float) = Interop.mkAttr "primary" value
  ///   These props will be forwarded to the primary typography component (as long as disableTypography is not `true`).
  static member inline primaryTypographyProps (props: IReactProperty list) = Interop.mkAttr "primaryTypographyProps" (createObj !!props)
  /// The secondary content element.
  static member inline secondary (value: ReactElement) = Interop.mkAttr "secondary" value
  /// The secondary content element.
  static member inline secondary (values: ReactElement seq) = Interop.mkAttr "secondary" values
  /// The secondary content element.
  static member inline secondary (value: string) = Interop.mkAttr "secondary" value
  /// The secondary content element.
  static member inline secondary (values: string seq) = Interop.mkAttr "secondary" values
  /// The secondary content element.
  static member inline secondary (value: int) = Interop.mkAttr "secondary" value
  /// The secondary content element.
  static member inline secondary (value: float) = Interop.mkAttr "secondary" value
  ///   These props will be forwarded to the secondary typography component (as long as disableTypography is not `true`).
  static member inline secondaryTypographyProps (props: IReactProperty list) = Interop.mkAttr "secondaryTypographyProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type listSubheader =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the List Subheader will not have gutters.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  ///   If `true`, the List Subheader will not stick to the top during scroll.
  static member inline disableSticky (value: bool) = Interop.mkAttr "disableSticky" value
  ///   If `true`, the List Subheader is indented.
  static member inline inset (value: bool) = Interop.mkAttr "inset" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module listSubheader =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"


[<Erase>]
type loadingButton =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the loading indicator is shown.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Element placed before the children if the button is in loading state. The node should contain an element with `role="progressbar"` with an accessible name. By default we render a `CircularProgress` that is labelled by the button itself.
  static member inline loadingIndicator (value: ReactElement) = Interop.mkAttr "loadingIndicator" value
  ///   Element placed before the children if the button is in loading state. The node should contain an element with `role="progressbar"` with an accessible name. By default we render a `CircularProgress` that is labelled by the button itself.
  static member inline loadingIndicator (values: ReactElement seq) = Interop.mkAttr "loadingIndicator" values
  ///   Element placed before the children if the button is in loading state. The node should contain an element with `role="progressbar"` with an accessible name. By default we render a `CircularProgress` that is labelled by the button itself.
  static member inline loadingIndicator (value: string) = Interop.mkAttr "loadingIndicator" value
  ///   Element placed before the children if the button is in loading state. The node should contain an element with `role="progressbar"` with an accessible name. By default we render a `CircularProgress` that is labelled by the button itself.
  static member inline loadingIndicator (values: string seq) = Interop.mkAttr "loadingIndicator" values
  ///   Element placed before the children if the button is in loading state. The node should contain an element with `role="progressbar"` with an accessible name. By default we render a `CircularProgress` that is labelled by the button itself.
  static member inline loadingIndicator (value: int) = Interop.mkAttr "loadingIndicator" value
  ///   Element placed before the children if the button is in loading state. The node should contain an element with `role="progressbar"` with an accessible name. By default we render a `CircularProgress` that is labelled by the button itself.
  static member inline loadingIndicator (value: float) = Interop.mkAttr "loadingIndicator" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module loadingButton =

  /// The loading indicator can be positioned on the start, end, or the center of the button.
  [<Erase>]
  type loadingPosition =
    static member inline start = Interop.mkAttr "loadingPosition" "start"
    static member inline end' = Interop.mkAttr "loadingPosition" "end"
    static member inline center = Interop.mkAttr "loadingPosition" "center"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline contained = Interop.mkAttr "variant" "contained"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline text = Interop.mkAttr "variant" "text"


[<Erase>]
type masonry =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Number of columns.
  static member inline columns (value: TODO) = Interop.mkAttr "columns" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The default number of columns of the component. This is provided for server-side rendering.
  static member inline defaultColumns (value: int) = Interop.mkAttr "defaultColumns" value
  /// The default height of the component in px. This is provided for server-side rendering.
  static member inline defaultHeight (value: int) = Interop.mkAttr "defaultHeight" value
  ///   The default spacing of the component. Like `spacing`, it is a factor of the theme's spacing. This is provided for server-side rendering.
  static member inline defaultSpacing (value: int) = Interop.mkAttr "defaultSpacing" value
  /// Defines the space between children. It is a factor of the theme's spacing.
  static member inline spacing (value: TODO) = Interop.mkAttr "spacing" value
  ///   Allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type menu =
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// An HTML element, or a function that returns one. It's used to set the position of the menu.
  static member inline anchorEl (value: #Element option) = Interop.mkAttr "anchorEl" value
  /// An HTML element, or a function that returns one. It's used to set the position of the menu.
  static member inline anchorEl (getElement: unit -> #Element option) = Interop.mkAttr "anchorEl" getElement
  /// An HTML element, or a function that returns one. It's used to set the position of the menu.
  static member inline anchorEl (ref: IRefValue<#Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
  ///   If `true` (Default) will focus the `[role="menu"]` if no focusable child is found. Disabled children are not focusable. If you set this prop to `false` focus will be placed on the parent modal container. This has severe accessibility implications and should only be considered if you manage focus otherwise.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  ///   Menu contents, normally `MenuItem`s.
  static member inline children (element: ReactElement) = prop.children element
  ///   Menu contents, normally `MenuItem`s.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   Menu contents, normally `MenuItem`s.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   Menu contents, normally `MenuItem`s.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   Menu contents, normally `MenuItem`s.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   Menu contents, normally `MenuItem`s.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   When opening the menu will not focus the active item but the `[role="menu"]` unless `autoFocus` is also set to `false`. Not using the default means not following WAI-ARIA authoring practices. Please be considerate about possible accessibility implications.
  static member inline disableAutoFocusItem (value: bool) = Interop.mkAttr "disableAutoFocusItem" value
  ///   Props applied to the
  ///
  /// [`MenuList`](https://mui.com/api/menu-list/) element.
  static member inline MenuListProps (props: IReactProperty list) = Interop.mkAttr "MenuListProps" (createObj !!props)
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`, `"tabKeyDown"`.
  static member inline onClose (handler: Event -> MenuCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`, `"tabKeyDown"`.
  static member inline onClose (handler: MenuCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The length of the transition in `ms`, or 'auto'
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  ///   The length of the transition in `ms`, or 'auto'
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module menu =

  ///   The length of the transition in `ms`, or 'auto'
  [<Erase>]
  type transitionDuration =
    static member inline auto = Interop.mkAttr "transitionDuration" "auto"

  ///   The variant to use. Use `menu` to prevent selected items from impacting the initial focus.
  [<Erase>]
  type variant =
    static member inline menu = Interop.mkAttr "variant" "menu"
    static member inline selectedMenu = Interop.mkAttr "variant" "selectedMenu"


[<Erase>]
type menuItem =
  ///   If `true`, the list item is focused during the first mount. Focus will also be triggered if the value changes from false to true.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, compact vertical padding designed for keyboard and mouse input is used. The prop defaults to the value inherited from the parent Menu component.
  static member inline dense (value: bool) = Interop.mkAttr "dense" value
  ///   If `true`, the left and right padding is removed.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  ///   If `true`, a 1px light border is added to the bottom of the menu item.
  static member inline divider (value: bool) = Interop.mkAttr "divider" value
  ///   This prop can help identify which element has keyboard focus. The class name will be applied when the element gains the focus through keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/HEAD/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type menuList =
  ///   If `true`, will focus the `[role="menu"]` container and move into tab order.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  ///   If `true`, will focus the first menuitem if `variant="menu"` or selected item if `variant="selectedMenu"`.
  static member inline autoFocusItem (value: bool) = Interop.mkAttr "autoFocusItem" value
  ///   MenuList contents, normally `MenuItem`s.
  static member inline children (element: ReactElement) = prop.children element
  ///   MenuList contents, normally `MenuItem`s.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   MenuList contents, normally `MenuItem`s.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   MenuList contents, normally `MenuItem`s.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   MenuList contents, normally `MenuItem`s.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   MenuList contents, normally `MenuItem`s.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, will allow focus on disabled items.
  static member inline disabledItemsFocusable (value: bool) = Interop.mkAttr "disabledItemsFocusable" value
  ///   If `true`, the menu items will not wrap focus.
  static member inline disableListWrap (value: bool) = Interop.mkAttr "disableListWrap" value

module menuList =

  ///   The variant to use. Use `menu` to prevent selected items from impacting the initial focus and the vertical alignment relative to the anchor element.
  [<Erase>]
  type variant =
    static member inline menu = Interop.mkAttr "variant" "menu"
    static member inline selectedMenu = Interop.mkAttr "variant" "selectedMenu"


[<Erase>]
type mobileDatePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// Cancel text message.
  static member inline cancelText (value: ReactElement) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: ReactElement seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: string) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: string seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: int) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (value: float) = Interop.mkAttr "cancelText" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true`, it shows the clear action in the picker dialog.
  static member inline clearable (value: bool) = Interop.mkAttr "clearable" value
  /// Clear text message.
  static member inline clearText (value: ReactElement) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: ReactElement seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: string seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: int) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (value: float) = Interop.mkAttr "clearText" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   Props applied to the
  ///
  /// [`Dialog`](https://mui.com/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Ok button text.
  static member inline okText (value: ReactElement) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: ReactElement seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: string) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: string seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: int) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (value: float) = Interop.mkAttr "okText" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for day. Check the [PickersDay](https://mui.com/api/pickers-day/) component.
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, the today button is displayed. **Note** that `showClearButton` has a higher priority.
  static member inline showTodayButton (value: bool) = Interop.mkAttr "showTodayButton" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Today text message.
  static member inline todayText (value: ReactElement) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: ReactElement seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: string) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: string seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: int) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (value: float) = Interop.mkAttr "todayText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileDatePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline month = Interop.mkAttr "views" "month"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type mobileDateRangePicker =
  /// Callback fired when the value (the selected date range) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `startProps` and `endProps` arguments of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api), that you need to forward to the range start/end inputs respectively. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// The value of the date range picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  ///   The number of calendars that render on **desktop**.
  static member inline calendars (value: TODO) = Interop.mkAttr "calendars" value
  /// Cancel text message.
  static member inline cancelText (value: ReactElement) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: ReactElement seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: string) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: string seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: int) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (value: float) = Interop.mkAttr "cancelText" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true`, it shows the clear action in the picker dialog.
  static member inline clearable (value: bool) = Interop.mkAttr "clearable" value
  /// Clear text message.
  static member inline clearText (value: ReactElement) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: ReactElement seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: string seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: int) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (value: float) = Interop.mkAttr "clearText" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   Props applied to the
  ///
  /// [`Dialog`](https://mui.com/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  ///   If `true`, after selecting `start` date calendar will not automatically switch to the month of `end` date.
  static member inline disableAutoMonthSwitching (value: bool) = Interop.mkAttr "disableAutoMonthSwitching" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: ReactElement) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: ReactElement seq) = Interop.mkAttr "endText" values
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: string) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: string seq) = Interop.mkAttr "endText" values
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: int) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: float) = Interop.mkAttr "endText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Ok button text.
  static member inline okText (value: ReactElement) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: ReactElement seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: string) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: string seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: int) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (value: float) = Interop.mkAttr "okText" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for `` days. @DateIOType
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, the today button is displayed. **Note** that `showClearButton` has a higher priority.
  static member inline showTodayButton (value: bool) = Interop.mkAttr "showTodayButton" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: ReactElement) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: ReactElement seq) = Interop.mkAttr "startText" values
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: string) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: string seq) = Interop.mkAttr "startText" values
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: int) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: float) = Interop.mkAttr "startText" value
  /// Today text message.
  static member inline todayText (value: ReactElement) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: ReactElement seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: string) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: string seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: int) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (value: float) = Interop.mkAttr "todayText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileDateRangePicker =

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type mobileDateTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// Cancel text message.
  static member inline cancelText (value: ReactElement) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: ReactElement seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: string) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: string seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: int) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (value: float) = Interop.mkAttr "cancelText" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true`, it shows the clear action in the picker dialog.
  static member inline clearable (value: bool) = Interop.mkAttr "clearable" value
  /// Clear text message.
  static member inline clearText (value: ReactElement) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: ReactElement seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: string seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: int) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (value: float) = Interop.mkAttr "clearText" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// Date tab icon.
  static member inline dateRangeIcon (element: ReactElement) = Interop.mkAttr "dateRangeIcon" element
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   Props applied to the
  ///
  /// [`Dialog`](https://mui.com/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// To show tabs.
  static member inline hideTabs (value: bool) = Interop.mkAttr "hideTabs" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  ///   Minimal selectable moment of time with binding to date, to set max time in each day use `maxTime`.
  static member inline maxDateTime (value: 'a) = Interop.mkAttr "maxDateTime" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  ///   Minimal selectable moment of time with binding to date, to set min time in each day use `minTime`.
  static member inline minDateTime (value: 'a) = Interop.mkAttr "minDateTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Ok button text.
  static member inline okText (value: ReactElement) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: ReactElement seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: string) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: string seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: int) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (value: float) = Interop.mkAttr "okText" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for day. Check the [PickersDay](https://mui.com/api/pickers-day/) component.
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, the today button is displayed. **Note** that `showClearButton` has a higher priority.
  static member inline showTodayButton (value: bool) = Interop.mkAttr "showTodayButton" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Time tab icon.
  static member inline timeIcon (element: ReactElement) = Interop.mkAttr "timeIcon" element
  /// Today text message.
  static member inline todayText (value: ReactElement) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: ReactElement seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: string) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: string seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: int) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (value: float) = Interop.mkAttr "todayText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileDateTimePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline hours = Interop.mkAttr "views" "hours"
    static member inline minutes = Interop.mkAttr "views" "minutes"
    static member inline month = Interop.mkAttr "views" "month"
    static member inline seconds = Interop.mkAttr "views" "seconds"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type mobileStepper =
  /// The total steps.
  static member inline steps (value: TODO) = Interop.mkAttr "steps" value
  /// Set the active step (zero based index). Defines which dot is highlighted when the variant is 'dots'.
  static member inline activeStep (value: TODO) = Interop.mkAttr "activeStep" value
  ///   A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (value: ReactElement) = Interop.mkAttr "backButton" value
  ///   A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (values: ReactElement seq) = Interop.mkAttr "backButton" values
  ///   A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (value: string) = Interop.mkAttr "backButton" value
  ///   A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (values: string seq) = Interop.mkAttr "backButton" values
  ///   A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (value: int) = Interop.mkAttr "backButton" value
  ///   A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (value: float) = Interop.mkAttr "backButton" value
  ///   Props applied to the `LinearProgress` element.
  static member inline LinearProgressProps (props: IReactProperty list) = Interop.mkAttr "LinearProgressProps" (createObj !!props)
  ///   A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (value: ReactElement) = Interop.mkAttr "nextButton" value
  ///   A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (values: ReactElement seq) = Interop.mkAttr "nextButton" values
  ///   A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (value: string) = Interop.mkAttr "nextButton" value
  ///   A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (values: string seq) = Interop.mkAttr "nextButton" values
  ///   A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (value: int) = Interop.mkAttr "nextButton" value
  ///   A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (value: float) = Interop.mkAttr "nextButton" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileStepper =

  /// Set the positioning type.
  [<Erase>]
  type position =
    static member inline bottom = Interop.mkAttr "position" "bottom"
    static member inline static' = Interop.mkAttr "position" "static"
    static member inline top = Interop.mkAttr "position" "top"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline dots = Interop.mkAttr "variant" "dots"
    static member inline progress = Interop.mkAttr "variant" "progress"
    static member inline text = Interop.mkAttr "variant" "text"


[<Erase>]
type mobileTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// Cancel text message.
  static member inline cancelText (value: ReactElement) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: ReactElement seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: string) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: string seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: int) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (value: float) = Interop.mkAttr "cancelText" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true`, it shows the clear action in the picker dialog.
  static member inline clearable (value: bool) = Interop.mkAttr "clearable" value
  /// Clear text message.
  static member inline clearText (value: ReactElement) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: ReactElement seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: string seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: int) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (value: float) = Interop.mkAttr "clearText" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  ///   Props applied to the
  ///
  /// [`Dialog`](https://mui.com/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Ok button text.
  static member inline okText (value: ReactElement) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: ReactElement seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: string) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: string seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: int) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (value: float) = Interop.mkAttr "okText" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  ///   If `true`, the today button is displayed. **Note** that `showClearButton` has a higher priority.
  static member inline showTodayButton (value: bool) = Interop.mkAttr "showTodayButton" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Today text message.
  static member inline todayText (value: ReactElement) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: ReactElement seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: string) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: string seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: int) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (value: float) = Interop.mkAttr "todayText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileTimePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'hours' = Interop.mkAttr "views" Array<'hours'
    static member inline minutes = Interop.mkAttr "views" "minutes"
    static member inline 'seconds'> = Interop.mkAttr "views" 'seconds'>


[<Erase>]
type modal =
  ///   A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// A backdrop component. This prop enables custom backdrop rendering.
  static member inline BackdropComponent (value: ReactElementType) = Interop.mkAttr "BackdropComponent" value
  ///   Props applied to the
  ///
  /// [`Backdrop`](https://mui.com/api/backdrop/) element.
  static member inline BackdropProps (props: IReactProperty list) = Interop.mkAttr "BackdropProps" (createObj !!props)
  /// When set to true the Modal waits until a nested Transition is completed before closing.
  static member inline closeAfterTransition (value: bool) = Interop.mkAttr "closeAfterTransition" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Modal. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Modal.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   An HTML element or function that returns one. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (value: TODO) = Interop.mkAttr "container" value
  ///   If `true`, the modal will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any modal children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus (value: bool) = Interop.mkAttr "disableAutoFocus" value
  ///   If `true`, the modal will not prevent focus from leaving the modal while open.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus (value: bool) = Interop.mkAttr "disableEnforceFocus" value
  ///   If `true`, hitting escape will not fire the `onClose` callback.
  static member inline disableEscapeKeyDown (value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  ///   The `children` will be under the DOM hierarchy of the parent component.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  ///   If `true`, the modal will not restore focus to previously focused element once modal is hidden.
  static member inline disableRestoreFocus (value: bool) = Interop.mkAttr "disableRestoreFocus" value
  /// Disable the scroll lock behavior.
  static member inline disableScrollLock (value: bool) = Interop.mkAttr "disableScrollLock" value
  ///   If `true`, the backdrop is not rendered.
  static member inline hideBackdrop (value: bool) = Interop.mkAttr "hideBackdrop" value
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Modal.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick (handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  ///   Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: Event -> ModalCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  ///   Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: ModalCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type modalUnstyled =
  ///   A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// A backdrop component. This prop enables custom backdrop rendering.
  static member inline BackdropComponent (value: ReactElementType) = Interop.mkAttr "BackdropComponent" value
  ///   Props applied to the
  ///
  /// [`BackdropUnstyled`](https://mui.com/api/backdrop-unstyled/) element.
  static member inline BackdropProps (props: IReactProperty list) = Interop.mkAttr "BackdropProps" (createObj !!props)
  /// When set to true the Modal waits until a nested Transition is completed before closing.
  static member inline closeAfterTransition (value: bool) = Interop.mkAttr "closeAfterTransition" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Modal. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Modal.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   An HTML element or function that returns one. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (value: TODO) = Interop.mkAttr "container" value
  ///   If `true`, the modal will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any modal children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus (value: bool) = Interop.mkAttr "disableAutoFocus" value
  ///   If `true`, the modal will not prevent focus from leaving the modal while open.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus (value: bool) = Interop.mkAttr "disableEnforceFocus" value
  ///   If `true`, hitting escape will not fire the `onClose` callback.
  static member inline disableEscapeKeyDown (value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  ///   The `children` will be under the DOM hierarchy of the parent component.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  ///   If `true`, the modal will not restore focus to previously focused element once modal is hidden.
  static member inline disableRestoreFocus (value: bool) = Interop.mkAttr "disableRestoreFocus" value
  /// Disable the scroll lock behavior.
  static member inline disableScrollLock (value: bool) = Interop.mkAttr "disableScrollLock" value
  ///   If `true`, the backdrop is not rendered.
  static member inline hideBackdrop (value: bool) = Interop.mkAttr "hideBackdrop" value
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Modal.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick (handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  ///   Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler


[<Erase>]
type monthPicker =
  /// Date value for the MonthPicker
  static member inline date (value: 'a) = Interop.mkAttr "date" value
  /// Maximal selectable date.
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date.
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Callback fired on date change.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// className applied to the root element.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true` picker is disabled
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  ///   If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  ///   If `true` picker is readonly
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type nativeSelect =
  ///   The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (element: ReactElement) = prop.children element
  ///   The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The icon that displays the arrow.
  static member inline IconComponent (value: ReactElementType) = Interop.mkAttr "IconComponent" value
  ///   An `Input` element; does not have to be a material-ui specific `Input`.
  static member inline input (value: ReactElement) = Interop.mkAttr "input" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select#attributes) applied to the `select` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Callback fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The `input` value.
  static member inline value (value: string) = Interop.mkAttr "value" value

module nativeSelect =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type noSsr =
  /// You can wrap a node.
  static member inline children (element: ReactElement) = prop.children element
  /// You can wrap a node.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// You can wrap a node.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// You can wrap a node.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// You can wrap a node.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// You can wrap a node.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the component will not only prevent server-side rendering. It will also defer the rendering of the children into a different screen frame.
  static member inline defer (value: bool) = Interop.mkAttr "defer" value
  /// The fallback content to display.
  static member inline fallback (value: ReactElement) = Interop.mkAttr "fallback" value
  /// The fallback content to display.
  static member inline fallback (values: ReactElement seq) = Interop.mkAttr "fallback" values
  /// The fallback content to display.
  static member inline fallback (value: string) = Interop.mkAttr "fallback" value
  /// The fallback content to display.
  static member inline fallback (values: string seq) = Interop.mkAttr "fallback" values
  /// The fallback content to display.
  static member inline fallback (value: int) = Interop.mkAttr "fallback" value
  /// The fallback content to display.
  static member inline fallback (value: float) = Interop.mkAttr "fallback" value


[<Erase>]
type outlinedInput =
  ///   This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  ///   If `true`, the `input` element is focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The components used for each slot inside the InputBase. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the component is disabled. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  ///   If `true`, the `input` will indicate an error. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   If `true`, the `input` will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  ///   The label of the `input`. It is only used for layout. The actual labelling is handled by `InputLabel`.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  ///   The label of the `input`. It is only used for layout. The actual labelling is handled by `InputLabel`.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  ///   The label of the `input`. It is only used for layout. The actual labelling is handled by `InputLabel`.
  static member inline label (value: string) = Interop.mkAttr "label" value
  ///   The label of the `input`. It is only used for layout. The actual labelling is handled by `InputLabel`.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  ///   The label of the `input`. It is only used for layout. The actual labelling is handled by `InputLabel`.
  static member inline label (value: int) = Interop.mkAttr "label" value
  ///   The label of the `input`. It is only used for layout. The actual labelling is handled by `InputLabel`.
  static member inline label (value: float) = Interop.mkAttr "label" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline maxRows (value: int) = Interop.mkAttr "maxRows" value
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline minRows (value: int) = Interop.mkAttr "minRows" value
  ///   If `true`, a `textarea` element is rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  ///   Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   If `true`, the outline is notched to accommodate the label.
  static member inline notched (value: bool) = Interop.mkAttr "notched" value
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  ///   The short hint displayed in the `input` before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  ///   If `true`, the `input` element is required. The prop defaults to the value (`false`) inherited from the parent FormControl component.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  ///   Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  ///   The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module outlinedInput =

  ///   The color of the component. The prop defaults to the value (`'primary'`) inherited from the parent FormControl component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline string = Interop.mkAttr "color" string

  ///   If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl. The prop defaults to the value (`'none'`) inherited from the parent FormControl component.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type pagination =
  /// Number of always visible pages at the beginning and end.
  static member inline boundaryCount (value: TODO) = Interop.mkAttr "boundaryCount" value
  /// The total number of pages.
  static member inline count (value: TODO) = Interop.mkAttr "count" value
  /// The page selected by default when the component is uncontrolled.
  static member inline defaultPage (value: TODO) = Interop.mkAttr "defaultPage" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   Accepts a function which returns a string value that provides a user-friendly name for the current page. This is important for screen reader users.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  ///
  /// **Signature:**
  ///
  /// `function(type: string, page: number, selected: bool) => string`
  ///
  /// *type:* The link or button type to format ('page' | 'first' | 'last' | 'next' | 'previous'). Defaults to 'page'.
  ///
  /// *page:* The page number to format.
  ///
  /// *selected:* If true, the current page is selected.
  static member inline getItemAriaLabel (getLabel: string -> int -> bool -> string) = Interop.mkAttr "getItemAriaLabel" (Func<_,_,_,_> (fun t p s -> getLabel t p s))
  ///   If `true`, hide the next-page button.
  static member inline hideNextButton (value: bool) = Interop.mkAttr "hideNextButton" value
  ///   If `true`, hide the previous-page button.
  static member inline hidePrevButton (value: bool) = Interop.mkAttr "hidePrevButton" value
  ///   Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent, page: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *page:* The page selected.
  static member inline onChange (handler: Event -> int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent, page: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *page:* The page selected.
  static member inline onChange (handler: int -> unit) = Interop.mkAttr "onChange" (Func<_,_> (fun _ p -> handler p))
  /// The current page.
  static member inline page (value: TODO) = Interop.mkAttr "page" value
  ///   Render the item.
  ///
  /// **Signature:**
  ///
  /// `function(params: PaginationRenderItemParams) => ReactNode`
  ///
  /// *params:* The props to spread on a PaginationItem.
  static member inline renderItem (render: PaginationRenderItemParams -> ReactElement) = Interop.mkAttr "renderItem" (Func<_,_> (fun p -> render p))
  ///   If `true`, show the first-page button.
  static member inline showFirstButton (value: bool) = Interop.mkAttr "showFirstButton" value
  ///   If `true`, show the last-page button.
  static member inline showLastButton (value: bool) = Interop.mkAttr "showLastButton" value
  /// Number of always visible pages before and after the current page.
  static member inline siblingCount (value: TODO) = Interop.mkAttr "siblingCount" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module pagination =

  /// The active color.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline standard = Interop.mkAttr "color" "standard"
    static member inline string = Interop.mkAttr "color" string

  /// The shape of the pagination items.
  [<Erase>]
  type shape =
    static member inline circular = Interop.mkAttr "shape" "circular"
    static member inline rounded = Interop.mkAttr "shape" "rounded"

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type paginationItem =
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for first, last, next & previous item type
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// The current page number.
  static member inline page (value: ReactElement) = Interop.mkAttr "page" value
  /// The current page number.
  static member inline page (values: ReactElement seq) = Interop.mkAttr "page" values
  /// The current page number.
  static member inline page (value: string) = Interop.mkAttr "page" value
  /// The current page number.
  static member inline page (values: string seq) = Interop.mkAttr "page" values
  /// The current page number.
  static member inline page (value: int) = Interop.mkAttr "page" value
  /// The current page number.
  static member inline page (value: float) = Interop.mkAttr "page" value
  ///   If `true` the pagination item is selected.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module paginationItem =

  /// The active color.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline standard = Interop.mkAttr "color" "standard"
    static member inline string = Interop.mkAttr "color" string

  /// The shape of the pagination item.
  [<Erase>]
  type shape =
    static member inline circular = Interop.mkAttr "shape" "circular"
    static member inline rounded = Interop.mkAttr "shape" "rounded"

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string

  /// The type of pagination item.
  [<Erase>]
  type type' =
    static member inline endEllipsis = Interop.mkAttr "type" "end-ellipsis"
    static member inline first = Interop.mkAttr "type" "first"
    static member inline last = Interop.mkAttr "type" "last"
    static member inline next = Interop.mkAttr "type" "next"
    static member inline page = Interop.mkAttr "type" "page"
    static member inline previous = Interop.mkAttr "type" "previous"
    static member inline startEllipsis = Interop.mkAttr "type" "start-ellipsis"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type paper =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: TODO) = Interop.mkAttr "elevation" value
  ///   If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module paper =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline elevation = Interop.mkAttr "variant" "elevation"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type pickersDay =
  /// The date to show.
  static member inline day (value: 'a) = Interop.mkAttr "day" value
  ///   If `true`, day is outside of month and will be hidden.
  static member inline outsideCurrentMonth (value: bool) = Interop.mkAttr "outsideCurrentMonth" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, renders as disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  ///   If `true`, days are rendering without margin. Useful for displaying linked range of days.
  static member inline disableMargin (value: bool) = Interop.mkAttr "disableMargin" value
  ///   If `true`, renders as selected.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   If `true`, renders as today date.
  static member inline today (value: bool) = Interop.mkAttr "today" value


[<Erase>]
type popover =
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// A ref for imperative actions. It currently only supports updatePosition() action.
  static member inline action (ref: IRefValue<PopoverActions option>) = Interop.mkAttr "action" ref
  /// A ref for imperative actions. It currently only supports updatePosition() action.
  static member inline action (handler: PopoverActions -> unit) = Interop.mkAttr "action" handler
  /// An HTML element, or a function that returns one. It's used to set the position of the popover.
  static member inline anchorEl (value: #Element option) = Interop.mkAttr "anchorEl" value
  /// An HTML element, or a function that returns one. It's used to set the position of the popover.
  static member inline anchorEl (getElement: unit -> #Element option) = Interop.mkAttr "anchorEl" getElement
  /// An HTML element, or a function that returns one. It's used to set the position of the popover.
  static member inline anchorEl (ref: IRefValue<#Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
  ///   This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: PopoverOriginHorizontal, vertical: PopoverOriginVertical) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  ///   This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: int, vertical: PopoverOriginVertical) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  ///   This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: PopoverOriginHorizontal, vertical: int) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  ///   This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: int, vertical: int) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// This is the position that may be used to set the position of the popover. The coordinates are relative to the application's client area.
  static member inline anchorPosition (left: int, top: int) = Interop.mkAttr "anchorPosition" (let x = createEmpty<obj> in x?``left`` <- left; x?``top`` <- top; x)
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   An HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (value: TODO) = Interop.mkAttr "container" value
  /// The elevation of the popover.
  static member inline elevation (value: TODO) = Interop.mkAttr "elevation" value
  /// Specifies how close to the edge of the window the popover can appear.
  static member inline marginThreshold (value: int) = Interop.mkAttr "marginThreshold" value
  ///   Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  static member inline onClose (handler: Event -> PopoverCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  ///   Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  static member inline onClose (handler: PopoverCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  ///   Props applied to the
  ///
  /// [`Paper`](https://mui.com/api/paper/) element.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  static member inline transformOrigin (horizontal: PopoverOriginHorizontal, vertical: PopoverOriginVertical) = Interop.mkAttr "transformOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  static member inline transformOrigin (horizontal: int, vertical: PopoverOriginVertical) = Interop.mkAttr "transformOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  static member inline transformOrigin (horizontal: PopoverOriginHorizontal, vertical: int) = Interop.mkAttr "transformOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  static member inline transformOrigin (horizontal: int, vertical: int) = Interop.mkAttr "transformOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  ///   The component used for the transition. [Follow this guide](https://mui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module popover =

  ///   This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  [<Erase>]
  type anchorOrigin =
    static member inline topLeft = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "left" ])
    static member inline topCenter = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "center" ])
    static member inline topRight = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "right" ])
    static member inline centerLeft = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "center"; "horizontal" ==> "left" ])
    static member inline centerCenter = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "center"; "horizontal" ==> "center" ])
    static member inline centerRight = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "center"; "horizontal" ==> "right" ])
    static member inline bottomLeft = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "left" ])
    static member inline bottomCenter = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "center" ])
    static member inline bottomRight = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "right" ])

  /// This determines which anchor prop to refer to when setting the position of the popover.
  [<Erase>]
  type anchorReference =
    static member inline anchorEl = Interop.mkAttr "anchorReference" "anchorEl"
    static member inline anchorPosition = Interop.mkAttr "anchorReference" "anchorPosition"
    static member inline none = Interop.mkAttr "anchorReference" "none"

  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  [<Erase>]
  type transformOrigin =
    static member inline topLeft = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "left" ])
    static member inline topCenter = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "center" ])
    static member inline topRight = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "right" ])
    static member inline centerLeft = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "center"; "horizontal" ==> "left" ])
    static member inline centerCenter = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "center"; "horizontal" ==> "center" ])
    static member inline centerRight = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "center"; "horizontal" ==> "right" ])
    static member inline bottomLeft = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "left" ])
    static member inline bottomCenter = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "center" ])
    static member inline bottomRight = Interop.mkAttr "transformOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "right" ])

  /// Set to 'auto' to automatically calculate transition time based on height.
  [<Erase>]
  type transitionDuration =
    static member inline auto = Interop.mkAttr "transitionDuration" "auto"


[<Erase>]
type popper =
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  ///   An HTML element, [virtualElement](https://popper.js.org/docs/v2/virtual-elements/), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (value: #Element option) = Interop.mkAttr "anchorEl" value
  ///   An HTML element, [virtualElement](https://popper.js.org/docs/v2/virtual-elements/), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (getElement: unit -> #Element option) = Interop.mkAttr "anchorEl" getElement
  ///   An HTML element, [virtualElement](https://popper.js.org/docs/v2/virtual-elements/), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (referenceObject: obj) = Interop.mkAttr "anchorEl" referenceObject
  ///   An HTML element, [virtualElement](https://popper.js.org/docs/v2/virtual-elements/), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (getReferenceObject: unit -> obj) = Interop.mkAttr "anchorEl" getReferenceObject
  ///   An HTML element, [virtualElement](https://popper.js.org/docs/v2/virtual-elements/), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (ref: IRefValue<#Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
  /// Popper render function or node.
  static member inline children (element: ReactElement) = prop.children element
  /// Popper render function or node.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Popper render function or node.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Popper render function or node.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Popper render function or node.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Popper render function or node.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   An HTML element or function that returns one. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (value: TODO) = Interop.mkAttr "container" value
  ///   The `children` will be under the DOM hierarchy of the parent component.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Popper.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value
  /// A ref that points to the used popper instance.
  static member inline popperRef (ref: IRefValue<#Element option>) = Interop.mkAttr "popperRef" ref
  /// A ref that points to the used popper instance.
  static member inline popperRef (handler: #Element -> unit) = Interop.mkAttr "popperRef" handler
  /// Help supporting a react-transition-group/Transition component.
  static member inline transition (value: bool) = Interop.mkAttr "transition" value

module popper =

  /// Direction of the text.
  [<Erase>]
  type direction =
    static member inline ltr = Interop.mkAttr "direction" "ltr"
    static member inline rtl = Interop.mkAttr "direction" "rtl"

  ///   Popper.js is based on a "plugin-like" architecture, most of its features are fully encapsulated "modifiers".
  ///
  /// A modifier is a function that is called each time Popper.js needs to compute the position of the popper. For this reason, modifiers should be very performant to avoid bottlenecks. To learn how to create a modifier, [read the modifiers documentation](https://popper.js.org/docs/v2/modifiers/).
  [<Erase>]
  type modifiers =
    static member inline afterRead = Interop.mkAttr "modifiers" "afterRead"
    static member inline afterWrite = Interop.mkAttr "modifiers" "afterWrite"
    static member inline beforeMain = Interop.mkAttr "modifiers" "beforeMain"
    static member inline beforeRead = Interop.mkAttr "modifiers" "beforeRead"
    static member inline beforeWrite = Interop.mkAttr "modifiers" "beforeWrite"
    static member inline main = Interop.mkAttr "modifiers" "main"
    static member inline read = Interop.mkAttr "modifiers" "read"
    static member inline 'write', requires?: Array<string>, requiresIfExists?: Array<string> }> = Interop.mkAttr "modifiers" 'write', requires?: Array<string>, requiresIfExists?: Array<string> }>

  /// Popper placement.
  [<Erase>]
  type placement =
    static member inline autoEnd = Interop.mkAttr "placement" "auto-end"
    static member inline autoStart = Interop.mkAttr "placement" "auto-start"
    static member inline auto = Interop.mkAttr "placement" "auto"
    static member inline bottomEnd = Interop.mkAttr "placement" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "placement" "bottom-start"
    static member inline bottom = Interop.mkAttr "placement" "bottom"
    static member inline leftEnd = Interop.mkAttr "placement" "left-end"
    static member inline leftStart = Interop.mkAttr "placement" "left-start"
    static member inline left = Interop.mkAttr "placement" "left"
    static member inline rightEnd = Interop.mkAttr "placement" "right-end"
    static member inline rightStart = Interop.mkAttr "placement" "right-start"
    static member inline right = Interop.mkAttr "placement" "right"
    static member inline topEnd = Interop.mkAttr "placement" "top-end"
    static member inline topStart = Interop.mkAttr "placement" "top-start"
    static member inline top = Interop.mkAttr "placement" "top"

  ///   Options provided to the
  ///
  /// [`Popper.js`](https://popper.js.org/docs/v2/constructors/#options) instance.
  [<Erase>]
  type popperOptions =
    static member inline autoStart = Interop.mkAttr "popperOptions" "auto-start"
    static member inline auto = Interop.mkAttr "popperOptions" "auto"
    static member inline bottomEnd = Interop.mkAttr "popperOptions" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "popperOptions" "bottom-start"
    static member inline bottom = Interop.mkAttr "popperOptions" "bottom"
    static member inline leftEnd = Interop.mkAttr "popperOptions" "left-end"
    static member inline leftStart = Interop.mkAttr "popperOptions" "left-start"
    static member inline left = Interop.mkAttr "popperOptions" "left"
    static member inline rightEnd = Interop.mkAttr "popperOptions" "right-end"
    static member inline rightStart = Interop.mkAttr "popperOptions" "right-start"
    static member inline right = Interop.mkAttr "popperOptions" "right"
    static member inline topEnd = Interop.mkAttr "popperOptions" "top-end"
    static member inline topStart = Interop.mkAttr "popperOptions" "top-start"
    static member inline top", strategy?: "absolute = Interop.mkAttr "popperOptions" "top", strategy?: "absolute"
    static member inline 'fixed' } = Interop.mkAttr "popperOptions" 'fixed' }


[<Erase>]
type popperUnstyled =
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  ///   An HTML element, [virtualElement](https://popper.js.org/docs/v2/virtual-elements/), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (value: TODO) = Interop.mkAttr "anchorEl" value
  /// Popper render function or node.
  static member inline children (value: TODO) = Interop.mkAttr "children" value
  ///   An HTML element or function that returns one. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (value: TODO) = Interop.mkAttr "container" value
  ///   The `children` will be under the DOM hierarchy of the parent component.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Popper.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value
  /// A ref that points to the used popper instance.
  static member inline popperRef (value: TODO) = Interop.mkAttr "popperRef" value
  /// Help supporting a react-transition-group/Transition component.
  static member inline transition (value: bool) = Interop.mkAttr "transition" value

module popperUnstyled =

  /// Direction of the text.
  [<Erase>]
  type direction =
    static member inline ltr = Interop.mkAttr "direction" "ltr"
    static member inline rtl = Interop.mkAttr "direction" "rtl"

  ///   Popper.js is based on a "plugin-like" architecture, most of its features are fully encapsulated "modifiers".
  ///
  /// A modifier is a function that is called each time Popper.js needs to compute the position of the popper. For this reason, modifiers should be very performant to avoid bottlenecks. To learn how to create a modifier, [read the modifiers documentation](https://popper.js.org/docs/v2/modifiers/).
  [<Erase>]
  type modifiers =
    static member inline afterRead = Interop.mkAttr "modifiers" "afterRead"
    static member inline afterWrite = Interop.mkAttr "modifiers" "afterWrite"
    static member inline beforeMain = Interop.mkAttr "modifiers" "beforeMain"
    static member inline beforeRead = Interop.mkAttr "modifiers" "beforeRead"
    static member inline beforeWrite = Interop.mkAttr "modifiers" "beforeWrite"
    static member inline main = Interop.mkAttr "modifiers" "main"
    static member inline read = Interop.mkAttr "modifiers" "read"
    static member inline 'write', requires?: Array<string>, requiresIfExists?: Array<string> }> = Interop.mkAttr "modifiers" 'write', requires?: Array<string>, requiresIfExists?: Array<string> }>

  /// Popper placement.
  [<Erase>]
  type placement =
    static member inline autoEnd = Interop.mkAttr "placement" "auto-end"
    static member inline autoStart = Interop.mkAttr "placement" "auto-start"
    static member inline auto = Interop.mkAttr "placement" "auto"
    static member inline bottomEnd = Interop.mkAttr "placement" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "placement" "bottom-start"
    static member inline bottom = Interop.mkAttr "placement" "bottom"
    static member inline leftEnd = Interop.mkAttr "placement" "left-end"
    static member inline leftStart = Interop.mkAttr "placement" "left-start"
    static member inline left = Interop.mkAttr "placement" "left"
    static member inline rightEnd = Interop.mkAttr "placement" "right-end"
    static member inline rightStart = Interop.mkAttr "placement" "right-start"
    static member inline right = Interop.mkAttr "placement" "right"
    static member inline topEnd = Interop.mkAttr "placement" "top-end"
    static member inline topStart = Interop.mkAttr "placement" "top-start"
    static member inline top = Interop.mkAttr "placement" "top"

  ///   Options provided to the
  ///
  /// [`Popper.js`](https://popper.js.org/docs/v2/constructors/#options) instance.
  [<Erase>]
  type popperOptions =
    static member inline autoStart = Interop.mkAttr "popperOptions" "auto-start"
    static member inline auto = Interop.mkAttr "popperOptions" "auto"
    static member inline bottomEnd = Interop.mkAttr "popperOptions" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "popperOptions" "bottom-start"
    static member inline bottom = Interop.mkAttr "popperOptions" "bottom"
    static member inline leftEnd = Interop.mkAttr "popperOptions" "left-end"
    static member inline leftStart = Interop.mkAttr "popperOptions" "left-start"
    static member inline left = Interop.mkAttr "popperOptions" "left"
    static member inline rightEnd = Interop.mkAttr "popperOptions" "right-end"
    static member inline rightStart = Interop.mkAttr "popperOptions" "right-start"
    static member inline right = Interop.mkAttr "popperOptions" "right"
    static member inline topEnd = Interop.mkAttr "popperOptions" "top-end"
    static member inline topStart = Interop.mkAttr "popperOptions" "top-start"
    static member inline top", strategy?: "absolute = Interop.mkAttr "popperOptions" "top", strategy?: "absolute"
    static member inline 'fixed' } = Interop.mkAttr "popperOptions" 'fixed' }


[<Erase>]
type portal =
  ///   The children to render into the `container`.
  static member inline children (element: ReactElement) = prop.children element
  ///   The children to render into the `container`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The children to render into the `container`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The children to render into the `container`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The children to render into the `container`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The children to render into the `container`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   An HTML element or function that returns one. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (value: TODO) = Interop.mkAttr "container" value
  ///   The `children` will be under the DOM hierarchy of the parent component.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value


[<Erase>]
type radio =
  ///   If `true`, the component is checked.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon (element: ReactElement) = Interop.mkAttr "checkedIcon" element
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the ripple effect is disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  ///   The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  ///   Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string). You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   If `true`, the `input` element is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The value of the component.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module radio =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  ///   The size of the component. `small` is equivalent to the dense radio styling.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type radioGroup =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// The name used to reference the value of the control. If you don't provide this prop, it falls back to a randomly generated name.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback fired when a radio button is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent, value: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The value of the selected radio button. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when a radio button is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent, value: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The value of the selected radio button. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// Value of the selected radio button.
  static member inline value (value: string) = Interop.mkAttr "value" value


[<Erase>]
type rating =
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: int) = Interop.mkAttr "defaultValue" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: float) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// The icon to display when empty.
  static member inline emptyIcon (element: ReactElement) = Interop.mkAttr "emptyIcon" element
  /// The label read when the rating input is empty.
  static member inline emptyLabelText (value: ReactElement) = Interop.mkAttr "emptyLabelText" value
  /// The label read when the rating input is empty.
  static member inline emptyLabelText (values: ReactElement seq) = Interop.mkAttr "emptyLabelText" values
  /// The label read when the rating input is empty.
  static member inline emptyLabelText (value: string) = Interop.mkAttr "emptyLabelText" value
  /// The label read when the rating input is empty.
  static member inline emptyLabelText (values: string seq) = Interop.mkAttr "emptyLabelText" values
  /// The label read when the rating input is empty.
  static member inline emptyLabelText (value: int) = Interop.mkAttr "emptyLabelText" value
  /// The label read when the rating input is empty.
  static member inline emptyLabelText (value: float) = Interop.mkAttr "emptyLabelText" value
  ///   Accepts a function which returns a string value that provides a user-friendly name for the current value of the rating. This is important for screen reader users.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  ///
  /// **Signature:**
  ///
  /// `function(value: number) => string`
  ///
  /// *value:* The rating label's value to format.
  static member inline getLabelText (getText: int -> string) = Interop.mkAttr "getLabelText" getText
  ///   Accepts a function which returns a string value that provides a user-friendly name for the current value of the rating. This is important for screen reader users.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  ///
  /// **Signature:**
  ///
  /// `function(value: number) => string`
  ///
  /// *value:* The rating label's value to format.
  static member inline getLabelText (getText: float -> string) = Interop.mkAttr "getLabelText" getText
  ///   If `true`, only the selected icon will be highlighted.
  static member inline highlightSelectedOnly (value: bool) = Interop.mkAttr "highlightSelectedOnly" value
  /// The icon to display.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The component containing the icon.
  static member inline IconContainerComponent (value: ReactElementType) = Interop.mkAttr "IconContainerComponent" value
  /// Maximum rating.
  static member inline max (value: int) = Interop.mkAttr "max" value
  /// Maximum rating.
  static member inline max (value: float) = Interop.mkAttr "max" value
  ///   The name attribute of the radio `input` elements. This input `name` should be unique within the page. Being unique within a form is insufficient since the `name` is used to generated IDs.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: number | null) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: Event -> int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: number | null) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: Event -> float -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: number | null) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: number | null) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: float -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeActive (handler: Event -> int -> unit) = Interop.mkAttr "onChangeActive" (Func<_,_,_> handler)
  ///   Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeActive (handler: Event -> float -> unit) = Interop.mkAttr "onChangeActive" (Func<_,_,_> handler)
  ///   Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeActive (handler: int -> unit) = Interop.mkAttr "onChangeActive" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeActive (handler: float -> unit) = Interop.mkAttr "onChangeActive" (Func<_,_,_> (fun _ v -> handler v))
  /// The minimum increment value change allowed.
  static member inline precision (value: int) = Interop.mkAttr "precision" value
  /// The minimum increment value change allowed.
  static member inline precision (value: float) = Interop.mkAttr "precision" value
  /// Removes all hover effects and pointer events.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The rating value.
  static member inline value (value: int) = Interop.mkAttr "value" value
  /// The rating value.
  static member inline value (value: float) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module rating =

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type scopedCssBaseline =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Enable `color-scheme` CSS property to use `theme.palette.mode`. For more details, check out https://developer.mozilla.org/en-US/docs/Web/CSS/color-scheme For browser support, check out https://caniuse.com/?search=color-scheme
  static member inline enableColorScheme (value: bool) = Interop.mkAttr "enableColorScheme" value


[<Erase>]
type select =
  ///   If `true`, the width of the popover will automatically be set according to the items inside the menu, otherwise it will be at least the width of the select input.
  static member inline autoWidth (value: bool) = Interop.mkAttr "autoWidth" value
  ///   The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (element: ReactElement) = prop.children element
  ///   The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the component is initially open. Use when the component open state is not controlled (i.e. the `open` prop is not defined). You can only use it when the `native` prop is `false` (default).
  static member inline defaultOpen (value: bool) = Interop.mkAttr "defaultOpen" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  ///   If `true`, a value is displayed even if no items are selected.
  ///
  /// In order to display a meaningful value, a function can be passed to the `renderValue` prop which returns the value to be displayed when no items are selected.
  ///
  /// ⚠️ When using this prop, make sure the label doesn't overlap with the empty displayed value. The label should either be hidden or forced to a shrunk state.
  static member inline displayEmpty (value: bool) = Interop.mkAttr "displayEmpty" value
  /// The icon that displays the arrow.
  static member inline IconComponent (value: ReactElementType) = Interop.mkAttr "IconComponent" value
  ///   The `id` of the wrapper element or the `select` element when `native`.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   An `Input` element; does not have to be a material-ui specific `Input`.
  static member inline input (value: ReactElement) = Interop.mkAttr "input" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element. When `native` is `true`, the attributes are applied on the `select` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   See [OutlinedInput#label](https://mui.com/api/outlined-input/#props)
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  ///   See [OutlinedInput#label](https://mui.com/api/outlined-input/#props)
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  ///   See [OutlinedInput#label](https://mui.com/api/outlined-input/#props)
  static member inline label (value: string) = Interop.mkAttr "label" value
  ///   See [OutlinedInput#label](https://mui.com/api/outlined-input/#props)
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  ///   See [OutlinedInput#label](https://mui.com/api/outlined-input/#props)
  static member inline label (value: int) = Interop.mkAttr "label" value
  ///   See [OutlinedInput#label](https://mui.com/api/outlined-input/#props)
  static member inline label (value: float) = Interop.mkAttr "label" value
  /// The ID of an element that acts as an additional label. The Select will be labelled by the additional label and the selected value.
  static member inline labelId (value: string) = Interop.mkAttr "labelId" value
  ///   Props applied to the
  ///
  /// [`Menu`](https://mui.com/api/menu/) element.
  static member inline MenuProps (props: IReactProperty list) = Interop.mkAttr "MenuProps" (createObj !!props)
  ///   If `true`, `value` must be an array and the menu will support multiple selections.
  static member inline multiple (value: bool) = Interop.mkAttr "multiple" value
  ///   If `true`, the component uses a native `select` element.
  static member inline native (value: bool) = Interop.mkAttr "native" value
  ///   Callback fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: SelectChangeEvent, child?: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event unless the change event is caused by browser autofill.
  ///
  /// *child:* The react element that was selected when `native` is `false` (default).
  static member inline onChange (handler: Event -> ReactElement -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: SelectChangeEvent, child?: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event unless the change event is caused by browser autofill.
  ///
  /// *child:* The react element that was selected when `native` is `false` (default).
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun (e: Event) _ -> handler !!e.Value))
  ///   Callback fired when the component requests to be closed. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback fired when the component requests to be opened. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  ///   If `true`, the component is shown. You can only use it when the `native` prop is `false` (default).
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  ///   Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> ReactElement) = Interop.mkAttr "renderValue" render
  ///   Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> ReactElement seq) = Interop.mkAttr "renderValue" render
  ///   Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> string) = Interop.mkAttr "renderValue" render
  ///   Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> string seq) = Interop.mkAttr "renderValue" render
  ///   Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> int) = Interop.mkAttr "renderValue" render
  ///   Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> float) = Interop.mkAttr "renderValue" render
  /// Props applied to the clickable div element.
  static member inline SelectDisplayProps (props: IReactProperty list) = Interop.mkAttr "SelectDisplayProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The `input` value. Providing an empty string will select no options. Set to an empty string `''` if you don't want any of the available options to be selected.
  ///
  /// If the value is an object it must have reference equality with the option in order to be selected. If the value is not an object, the string representation must match with the string representation of the option in order to be selected.
  static member inline value (value: 'a) = Interop.mkAttr "value" value

module select =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type skeleton =
  /// Optional children to infer width and height from.
  static member inline children (element: ReactElement) = prop.children element
  /// Optional children to infer width and height from.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Optional children to infer width and height from.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Optional children to infer width and height from.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Optional children to infer width and height from.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Optional children to infer width and height from.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Height of the skeleton. Useful when you don't want to adapt the skeleton to a text element but for instance a card.
  static member inline height (value: int) = Interop.mkAttr "height" value
  /// Height of the skeleton. Useful when you don't want to adapt the skeleton to a text element but for instance a card.
  static member inline height (value: Styles.ICssUnit) = Interop.mkAttr "height" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// Width of the skeleton. Useful when the skeleton is inside an inline element with no width of its own.
  static member inline width (value: int) = Interop.mkAttr "width" value
  /// Width of the skeleton. Useful when the skeleton is inside an inline element with no width of its own.
  static member inline width (value: Styles.ICssUnit) = Interop.mkAttr "width" value

module skeleton =

  ///   The animation. If `false` the animation effect is disabled.
  [<Erase>]
  type animation =
    static member inline pulse = Interop.mkAttr "animation" "pulse"
    static member inline wave = Interop.mkAttr "animation" "wave"
    static member inline false' = Interop.mkAttr "animation" false

  /// The type of content that will be rendered.
  [<Erase>]
  type variant =
    static member inline circular = Interop.mkAttr "variant" "circular"
    static member inline rectangular = Interop.mkAttr "variant" "rectangular"
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type slide =
  ///   A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Add a custom transition end trigger. Called with the transitioning DOM node and a done callback. Allows for more fine grained transition end logic. Note: Timeouts are still used as a fallback if provided.
  static member inline addEndListener (value: TODO) = Interop.mkAttr "addEndListener" value
  ///   Perform the enter transition when it first mounts if `in` is also `true`. Set this to `false` to disable this behavior.
  static member inline appear (value: bool) = Interop.mkAttr "appear" value
  /// An HTML element, or a function that returns one. It's used to set the container the Slide is transitioning from.
  static member inline container (value: TODO) = Interop.mkAttr "container" value
  /// The transition timing function. You may specify a single easing or a object containing enter and exit values.
  static member inline easing (value: TODO) = Interop.mkAttr "easing" value
  ///   If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)

module slide =

  /// Direction the child node will enter from.
  [<Erase>]
  type direction =
    static member inline down = Interop.mkAttr "direction" "down"
    static member inline left = Interop.mkAttr "direction" "left"
    static member inline right = Interop.mkAttr "direction" "right"
    static member inline up = Interop.mkAttr "direction" "up"


[<Erase>]
type slider =
  /// The label of the slider.
  static member inline ariaLabel (value: string) = Interop.mkAttr "aria-label" value
  /// The id of the element containing a label for the slider.
  static member inline ariaLabelledby (value: string) = Interop.mkAttr "aria-labelledby" value
  /// A string value that provides a user-friendly name for the current value of the slider.
  static member inline ariaValuetext (value: string) = Interop.mkAttr "aria-valuetext" value
  /// The components used for each slot inside the Slider. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: int) = Interop.mkAttr "defaultValue" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: float) = Interop.mkAttr "defaultValue" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (min: int, max: int) = Interop.mkAttr "defaultValue" (min, max)
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (min: float, max: float) = Interop.mkAttr "defaultValue" (min, max)
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the active thumb doesn't swap when moving pointer over a thumb while dragging another thumb.
  static member inline disableSwap (value: bool) = Interop.mkAttr "disableSwap" value
  ///   Accepts a function which returns a string value that provides a user-friendly name for the thumb labels of the slider. This is important for screen reader users.
  ///
  /// **Signature:**
  ///
  /// `function(index: number) => string`
  ///
  /// *index:* The thumb label's index to format.
  static member inline getAriaLabel (getLabel: int -> string) = Interop.mkAttr "getAriaLabel" getLabel
  ///   Accepts a function which returns a string value that provides a user-friendly name for the current value of the slider. This is important for screen reader users.
  ///
  /// **Signature:**
  ///
  /// `function(value: number, index: number) => string`
  ///
  /// *value:* The thumb label's value to format.
  ///
  /// *index:* The thumb label's index to format.
  static member inline getAriaValueText (getText: int -> int -> string) = Interop.mkAttr "getAriaValueText" getText
  ///   Accepts a function which returns a string value that provides a user-friendly name for the current value of the slider. This is important for screen reader users.
  ///
  /// **Signature:**
  ///
  /// `function(value: number, index: number) => string`
  ///
  /// *value:* The thumb label's value to format.
  ///
  /// *index:* The thumb label's index to format.
  static member inline getAriaValueText (getText: float -> int -> string) = Interop.mkAttr "getAriaValueText" getText
  /// Indicates whether the theme context has rtl direction. It is set automatically.
  static member inline isRtl (value: bool) = Interop.mkAttr "isRtl" value
  ///   Marks indicate predetermined values to which the user can move the slider. If `true` the marks are spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks (value: bool) = Interop.mkAttr "marks" value
  /// The maximum allowed value of the slider. Should not be equal to min.
  static member inline max (value: int) = Interop.mkAttr "max" value
  /// The minimum allowed value of the slider. Should not be equal to max.
  static member inline min (value: int) = Interop.mkAttr "min" value
  ///   Name attribute of the hidden `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: Event -> int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: Event -> float -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: float -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: Event -> int [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: Event -> float [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: int [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: float [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> int -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> handler)
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> float -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> handler)
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: int -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: float -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> int [] -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> handler)
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> float [] -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> handler)
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: int [] -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: float [] -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> (fun _ v -> handler v))
  /// A transformation function, to change the scale of the slider.
  static member inline scale (transform: int -> int) = Interop.mkAttr "scale" transform
  /// A transformation function, to change the scale of the slider.
  static member inline scale (transform: float -> float) = Interop.mkAttr "scale" transform
  ///   The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
  ///
  /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step (value: int) = Interop.mkAttr "step" value
  ///   The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
  ///
  /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step (value: float) = Interop.mkAttr "step" value
  ///   The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
  ///
  /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step (value: int option) = Interop.mkAttr "step" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   Tab index attribute of the hidden `input` element.
  static member inline tabIndex (value: int) = Interop.mkAttr "tabIndex" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (value: int) = Interop.mkAttr "value" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (value: float) = Interop.mkAttr "value" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (min: int, max: int) = Interop.mkAttr "value" (min, max)
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (min: float, max: float) = Interop.mkAttr "value" (min, max)
  /// The format function the value label's value.
  ///
  /// When a function is provided, it should have the following signature:
  ///
  /// - {number} value The value label's value to format - {number} index The value label's index to format
  static member inline valueLabelFormat (value: string) = Interop.mkAttr "valueLabelFormat" value
  /// The format function the value label's value.
  ///
  /// When a function is provided, it should have the following signature:
  ///
  /// - {number} value The value label's value to format - {number} index The value label's index to format
  static member inline valueLabelFormat (format: int -> int -> string) = Interop.mkAttr "valueLabelFormat" format
  /// The format function the value label's value.
  ///
  /// When a function is provided, it should have the following signature:
  ///
  /// - {number} value The value label's value to format - {number} index The value label's index to format
  static member inline valueLabelFormat (format: float -> int -> string) = Interop.mkAttr "valueLabelFormat" format
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module sliderExtensions =

  type slider with
    ///   The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
    ///
    /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
    static member inline step (value: float option) = Interop.mkAttr "step" value

module slider =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline string = Interop.mkAttr "color" string

  /// The props used for each slot inside the Slider.
  [<Erase>]
  type componentsProps =
    static member inline number, valueLabelDisplay?: 'auto' = Interop.mkAttr "componentsProps" number, valueLabelDisplay?: 'auto'
    static member inline off = Interop.mkAttr "componentsProps" "off"
    static member inline 'on' } } = Interop.mkAttr "componentsProps" 'on' } }

  /// The component orientation.
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The size of the slider.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"

  ///   The track presentation:
  ///
  /// - `normal` the track will render a bar representing the slider value. - `inverted` the track will render a bar representing the remaining slider value. - `false` the track will render without a bar.
  [<Erase>]
  type track =
    static member inline inverted = Interop.mkAttr "track" "inverted"
    static member inline normal = Interop.mkAttr "track" "normal"
    static member inline false' = Interop.mkAttr "track" false

  ///   Controls when the value label is displayed:
  ///
  /// - `auto` the value label will display when the thumb is hovered or focused. - `on` will display persistently. - `off` will never display.
  [<Erase>]
  type valueLabelDisplay =
    static member inline auto = Interop.mkAttr "valueLabelDisplay" "auto"
    static member inline off = Interop.mkAttr "valueLabelDisplay" "off"
    static member inline on = Interop.mkAttr "valueLabelDisplay" "on"


[<Erase>]
type sliderUnstyled =
  /// The label of the slider.
  static member inline ariaLabel (value: string) = Interop.mkAttr "aria-label" value
  /// The id of the element containing a label for the slider.
  static member inline ariaLabelledby (value: string) = Interop.mkAttr "aria-labelledby" value
  /// A string value that provides a user-friendly name for the current value of the slider.
  static member inline ariaValuetext (value: string) = Interop.mkAttr "aria-valuetext" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Slider. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: TODO) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the active thumb doesn't swap when moving pointer over a thumb while dragging another thumb.
  static member inline disableSwap (value: bool) = Interop.mkAttr "disableSwap" value
  ///   Accepts a function which returns a string value that provides a user-friendly name for the thumb labels of the slider. This is important for screen reader users.
  ///
  /// **Signature:**
  ///
  /// `function(index: number) => string`
  ///
  /// *index:* The thumb label's index to format.
  static member inline getAriaLabel (value: TODO) = Interop.mkAttr "getAriaLabel" value
  ///   Accepts a function which returns a string value that provides a user-friendly name for the current value of the slider. This is important for screen reader users.
  ///
  /// **Signature:**
  ///
  /// `function(value: number, index: number) => string`
  ///
  /// *value:* The thumb label's value to format.
  ///
  /// *index:* The thumb label's index to format.
  static member inline getAriaValueText (value: TODO) = Interop.mkAttr "getAriaValueText" value
  /// Indicates whether the theme context has rtl direction. It is set automatically.
  static member inline isRtl (value: bool) = Interop.mkAttr "isRtl" value
  ///   Marks indicate predetermined values to which the user can move the slider. If `true` the marks are spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks (value: bool) = Interop.mkAttr "marks" value
  /// The maximum allowed value of the slider. Should not be equal to min.
  static member inline max (value: int) = Interop.mkAttr "max" value
  /// The minimum allowed value of the slider. Should not be equal to max.
  static member inline min (value: int) = Interop.mkAttr "min" value
  ///   Name attribute of the hidden `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: Event, value: number | Array, activeThumb: number) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any). **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  ///
  /// *activeThumb:* Index of the currently moved thumb.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, value: number | Array) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> unit) = Interop.mkAttr "onChangeCommitted" handler
  /// A transformation function, to change the scale of the slider.
  static member inline scale (value: TODO) = Interop.mkAttr "scale" value
  ///   The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
  ///
  /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step (value: int) = Interop.mkAttr "step" value
  ///   Tab index attribute of the hidden `input` element.
  static member inline tabIndex (value: int) = Interop.mkAttr "tabIndex" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// The format function the value label's value.
  ///
  /// When a function is provided, it should have the following signature:
  ///
  /// - {number} value The value label's value to format - {number} index The value label's index to format
  static member inline valueLabelFormat (value: TODO) = Interop.mkAttr "valueLabelFormat" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module sliderUnstyled =

  /// The props used for each slot inside the Slider.
  [<Erase>]
  type componentsProps =
    static member inline number, valueLabelDisplay?: 'auto' = Interop.mkAttr "componentsProps" number, valueLabelDisplay?: 'auto'
    static member inline off = Interop.mkAttr "componentsProps" "off"
    static member inline 'on' } } = Interop.mkAttr "componentsProps" 'on' } }

  /// The component orientation.
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  ///   The track presentation:
  ///
  /// - `normal` the track will render a bar representing the slider value. - `inverted` the track will render a bar representing the remaining slider value. - `false` the track will render without a bar.
  [<Erase>]
  type track =
    static member inline inverted = Interop.mkAttr "track" "inverted"
    static member inline normal = Interop.mkAttr "track" "normal"
    static member inline false' = Interop.mkAttr "track" false

  ///   Controls when the value label is displayed:
  ///
  /// - `auto` the value label will display when the thumb is hovered or focused. - `on` will display persistently. - `off` will never display.
  [<Erase>]
  type valueLabelDisplay =
    static member inline auto = Interop.mkAttr "valueLabelDisplay" "auto"
    static member inline off = Interop.mkAttr "valueLabelDisplay" "off"
    static member inline on = Interop.mkAttr "valueLabelDisplay" "on"


[<Erase>]
type snackbar =
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (value: ReactElement) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (values: ReactElement seq) = Interop.mkAttr "action" values
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (value: string) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (values: string seq) = Interop.mkAttr "action" values
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (value: int) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (value: float) = Interop.mkAttr "action" value
  ///   The number of milliseconds to wait before automatically calling the `onClose` function. `onClose` should then set the state of the `open` prop to hide the Snackbar. This behavior is disabled by default with the `null` value.
  static member inline autoHideDuration (value: int) = Interop.mkAttr "autoHideDuration" value
  ///   The number of milliseconds to wait before automatically calling the `onClose` function. `onClose` should then set the state of the `open` prop to hide the Snackbar. This behavior is disabled by default with the `null` value.
  static member inline autoHideDuration (value: int option) = Interop.mkAttr "autoHideDuration" value
  ///   Replace the `SnackbarContent` component.
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  ///   Props applied to the `ClickAwayListener` element.
  static member inline ClickAwayListenerProps (props: IReactProperty list) = Interop.mkAttr "ClickAwayListenerProps" (createObj !!props)
  ///   Props applied to the
  ///
  /// [`SnackbarContent`](https://mui.com/api/snackbar-content/) element.
  static member inline ContentProps (props: IReactProperty list) = Interop.mkAttr "ContentProps" (createObj !!props)
  ///   If `true`, the `autoHideDuration` timer will expire even if the window is not focused.
  static member inline disableWindowBlurListener (value: bool) = Interop.mkAttr "disableWindowBlurListener" value
  /// When displaying multiple consecutive Snackbars from a parent rendering a single <Snackbar/>, add the key prop to ensure independent treatment of each message. e.g. <snackbar key="{message}"></snackbar>, otherwise, the message may update-in-place and features such as autoHideDuration may be canceled.
  static member inline key (value: 'a) = Interop.mkAttr "key" value
  /// The message to display.
  static member inline message (value: ReactElement) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message (values: ReactElement seq) = Interop.mkAttr "message" values
  /// The message to display.
  static member inline message (value: string) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message (values: string seq) = Interop.mkAttr "message" values
  /// The message to display.
  static member inline message (value: int) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message (value: float) = Interop.mkAttr "message" value
  ///   Callback fired when the component requests to be closed. Typically `onClose` is used to set state in the parent component, which is used to control the `Snackbar` `open` prop. The `reason` parameter can optionally be used to control the response to `onClose`, for example ignoring `clickaway`.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"timeout"` (`autoHideDuration` expired), `"clickaway"`, or `"escapeKeyDown"`.
  static member inline onClose (handler: Event -> SnackbarCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  ///   Callback fired when the component requests to be closed. Typically `onClose` is used to set state in the parent component, which is used to control the `Snackbar` `open` prop. The `reason` parameter can optionally be used to control the response to `onClose`, for example ignoring `clickaway`.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent | Event, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"timeout"` (`autoHideDuration` expired), `"clickaway"`, or `"escapeKeyDown"`.
  static member inline onClose (handler: SnackbarCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  ///   The number of milliseconds to wait before dismissing after user interaction. If `autoHideDuration` prop isn't specified, it does nothing. If `autoHideDuration` prop is specified but `resumeHideDuration` isn't, we default to `autoHideDuration / 2` ms.
  static member inline resumeHideDuration (value: int) = Interop.mkAttr "resumeHideDuration" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The component used for the transition. [Follow this guide](https://mui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module snackbar =

  ///   The anchor of the `Snackbar`. On smaller screens, the component grows to occupy all the available width, the horizontal alignment is ignored.
  [<Erase>]
  type anchorOrigin =
    static member inline topLeft = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "left" ])
    static member inline topCenter = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "center" ])
    static member inline topRight = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "top"; "horizontal" ==> "right" ])
    static member inline bottomLeft = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "left" ])
    static member inline bottomCenter = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "center" ])
    static member inline bottomRight = Interop.mkAttr "anchorOrigin" (createObj [ "vertical" ==> "bottom"; "horizontal" ==> "right" ])


[<Erase>]
type snackbarContent =
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (value: ReactElement) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (values: ReactElement seq) = Interop.mkAttr "action" values
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (value: string) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (values: string seq) = Interop.mkAttr "action" values
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (value: int) = Interop.mkAttr "action" value
  /// The action to display. It renders after the message, at the end of the snackbar.
  static member inline action (value: float) = Interop.mkAttr "action" value
  /// The message to display.
  static member inline message (value: ReactElement) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message (values: ReactElement seq) = Interop.mkAttr "message" values
  /// The message to display.
  static member inline message (value: string) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message (values: string seq) = Interop.mkAttr "message" values
  /// The message to display.
  static member inline message (value: int) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message (value: float) = Interop.mkAttr "message" value
  /// The ARIA role attribute of the element.
  static member inline role (value: string) = Interop.mkAttr "role" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type speedDial =
  ///   The aria-label of the button element. Also used to provide the `id` for the `SpeedDial` element and its children.
  static member inline ariaLabel (value: string) = Interop.mkAttr "ariaLabel" value
  ///   SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (element: ReactElement) = prop.children element
  ///   SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   Props applied to the
  ///
  /// [`Fab`](https://mui.com/api/fab/) element.
  static member inline FabProps (props: IReactProperty list) = Interop.mkAttr "FabProps" (createObj !!props)
  ///   If `true`, the SpeedDial is hidden.
  static member inline hidden (value: bool) = Interop.mkAttr "hidden" value
  ///   The icon to display in the SpeedDial Fab. The `SpeedDialIcon` component provides a default Icon with animation.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggle"`, `"blur"`, `"mouseLeave"`, `"escapeKeyDown"`.
  static member inline onClose (handler: Event -> SpeedDialCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggle"`, `"blur"`, `"mouseLeave"`, `"escapeKeyDown"`.
  static member inline onClose (handler: SpeedDialCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  ///   Callback fired when the component requests to be open.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggle"`, `"focus"`, `"mouseEnter"`.
  static member inline onOpen (handler: Event -> SpeedDialOpenReason -> unit) = Interop.mkAttr "onOpen" (Func<_,_,_> handler)
  ///   Callback fired when the component requests to be open.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggle"`, `"focus"`, `"mouseEnter"`.
  static member inline onOpen (handler: SpeedDialOpenReason -> unit) = Interop.mkAttr "onOpen" (Func<_,_,_> (fun _ v -> handler v))
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The icon to display in the SpeedDial Fab when the SpeedDial is open.
  static member inline openIcon (element: ReactElement) = Interop.mkAttr "openIcon" element
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The component used for the transition. [Follow this guide](https://mui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module speedDial =

  /// The direction the actions open relative to the floating action button.
  [<Erase>]
  type direction =
    static member inline down = Interop.mkAttr "direction" "down"
    static member inline left = Interop.mkAttr "direction" "left"
    static member inline right = Interop.mkAttr "direction" "right"
    static member inline up = Interop.mkAttr "direction" "up"


[<Erase>]
type speedDialAction =
  /// Adds a transition delay, to allow a series of SpeedDialActions to be animated.
  static member inline delay (value: int) = Interop.mkAttr "delay" value
  ///   Props applied to the
  ///
  /// [`Fab`](https://mui.com/api/fab/) component.
  static member inline FabProps (props: IReactProperty list) = Interop.mkAttr "FabProps" (createObj !!props)
  /// The icon to display in the SpeedDial Fab.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// This prop is used to help implement the accessibility logic. If you don't provide this prop. It falls back to a randomly generated id.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// Make the tooltip always visible when the SpeedDial is open.
  static member inline tooltipOpen (value: bool) = Interop.mkAttr "tooltipOpen" value
  /// Label to display in the tooltip.
  static member inline tooltipTitle (value: ReactElement) = Interop.mkAttr "tooltipTitle" value
  /// Label to display in the tooltip.
  static member inline tooltipTitle (values: ReactElement seq) = Interop.mkAttr "tooltipTitle" values
  /// Label to display in the tooltip.
  static member inline tooltipTitle (value: string) = Interop.mkAttr "tooltipTitle" value
  /// Label to display in the tooltip.
  static member inline tooltipTitle (values: string seq) = Interop.mkAttr "tooltipTitle" values
  /// Label to display in the tooltip.
  static member inline tooltipTitle (value: int) = Interop.mkAttr "tooltipTitle" value
  /// Label to display in the tooltip.
  static member inline tooltipTitle (value: float) = Interop.mkAttr "tooltipTitle" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module speedDialAction =

  /// Placement of the tooltip.
  [<Erase>]
  type tooltipPlacement =
    static member inline bottomEnd = Interop.mkAttr "tooltipPlacement" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "tooltipPlacement" "bottom-start"
    static member inline bottom = Interop.mkAttr "tooltipPlacement" "bottom"
    static member inline leftEnd = Interop.mkAttr "tooltipPlacement" "left-end"
    static member inline leftStart = Interop.mkAttr "tooltipPlacement" "left-start"
    static member inline left = Interop.mkAttr "tooltipPlacement" "left"
    static member inline rightEnd = Interop.mkAttr "tooltipPlacement" "right-end"
    static member inline rightStart = Interop.mkAttr "tooltipPlacement" "right-start"
    static member inline right = Interop.mkAttr "tooltipPlacement" "right"
    static member inline topEnd = Interop.mkAttr "tooltipPlacement" "top-end"
    static member inline topStart = Interop.mkAttr "tooltipPlacement" "top-start"
    static member inline top = Interop.mkAttr "tooltipPlacement" "top"


[<Erase>]
type speedDialIcon =
  /// The icon to display.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The icon to display in the SpeedDial Floating Action Button when the SpeedDial is open.
  static member inline openIcon (element: ReactElement) = Interop.mkAttr "openIcon" element
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type stack =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Add an element between each child.
  static member inline divider (value: ReactElement) = Interop.mkAttr "divider" value
  /// Add an element between each child.
  static member inline divider (values: ReactElement seq) = Interop.mkAttr "divider" values
  /// Add an element between each child.
  static member inline divider (value: string) = Interop.mkAttr "divider" value
  /// Add an element between each child.
  static member inline divider (values: string seq) = Interop.mkAttr "divider" values
  /// Add an element between each child.
  static member inline divider (value: int) = Interop.mkAttr "divider" value
  /// Add an element between each child.
  static member inline divider (value: float) = Interop.mkAttr "divider" value
  /// Defines the space between immediate children.
  static member inline spacing (value: TODO) = Interop.mkAttr "spacing" value
  ///   The system prop, which allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module stack =

  ///   Defines the `flex-direction` style property. It is applied for all screen sizes.
  [<Erase>]
  type direction =
    static member inline columnReverse = Interop.mkAttr "direction" "column-reverse"
    static member inline column = Interop.mkAttr "direction" "column"
    static member inline rowReverse = Interop.mkAttr "direction" "row-reverse"
    static member inline row = Interop.mkAttr "direction" "row"
    static member inline Array<'columnReverse' = Interop.mkAttr "direction" Array<'column-reverse'
    static member inline column = Interop.mkAttr "direction" "column"
    static member inline rowReverse = Interop.mkAttr "direction" "row-reverse"
    static member inline 'row'> = Interop.mkAttr "direction" 'row'>
    static member inline object = Interop.mkAttr "direction" object


[<Erase>]
type staticDatePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for day. Check the [PickersDay](https://mui.com/api/pickers-day/) component.
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module staticDatePicker =

  /// Force static wrapper inner components to be rendered in mobile or desktop mode.
  [<Erase>]
  type displayStaticWrapperAs =
    static member inline desktop = Interop.mkAttr "displayStaticWrapperAs" "desktop"
    static member inline mobile = Interop.mkAttr "displayStaticWrapperAs" "mobile"

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline month = Interop.mkAttr "views" "month"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type staticDateRangePicker =
  /// Callback fired when the value (the selected date range) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `startProps` and `endProps` arguments of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api), that you need to forward to the range start/end inputs respectively. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// The value of the date range picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  ///   The number of calendars that render on **desktop**.
  static member inline calendars (value: TODO) = Interop.mkAttr "calendars" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   If `true`, after selecting `start` date calendar will not automatically switch to the month of `end` date.
  static member inline disableAutoMonthSwitching (value: bool) = Interop.mkAttr "disableAutoMonthSwitching" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: ReactElement) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: ReactElement seq) = Interop.mkAttr "endText" values
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: string) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: string seq) = Interop.mkAttr "endText" values
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: int) = Interop.mkAttr "endText" value
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: float) = Interop.mkAttr "endText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for `` days. @DateIOType
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: ReactElement) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: ReactElement seq) = Interop.mkAttr "startText" values
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: string) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: string seq) = Interop.mkAttr "startText" values
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: int) = Interop.mkAttr "startText" value
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: float) = Interop.mkAttr "startText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module staticDateRangePicker =

  /// Force static wrapper inner components to be rendered in mobile or desktop mode.
  [<Erase>]
  type displayStaticWrapperAs =
    static member inline desktop = Interop.mkAttr "displayStaticWrapperAs" "desktop"
    static member inline mobile = Interop.mkAttr "displayStaticWrapperAs" "mobile"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type staticDateTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  ///   If `true`, `onChange` is fired on click even if the same date is selected.
  static member inline allowSameDateSelection (value: bool) = Interop.mkAttr "allowSameDateSelection" value
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// Date tab icon.
  static member inline dateRangeIcon (element: ReactElement) = Interop.mkAttr "dateRangeIcon" element
  ///   Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'a) = Interop.mkAttr "defaultCalendarMonth" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, todays date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Get aria-label text for switching between views button.
  static member inline getViewSwitchingButtonText (value: TODO) = Interop.mkAttr "getViewSwitchingButtonText" value
  /// To show tabs.
  static member inline hideTabs (value: bool) = Interop.mkAttr "hideTabs" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  ///   If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max selectable date. @DateIOType
  static member inline maxDate (value: 'a) = Interop.mkAttr "maxDate" value
  ///   Minimal selectable moment of time with binding to date, to set max time in each day use `maxTime`.
  static member inline maxDateTime (value: 'a) = Interop.mkAttr "maxDateTime" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  /// Min selectable date. @DateIOType
  static member inline minDate (value: 'a) = Interop.mkAttr "minDate" value
  ///   Minimal selectable moment of time with binding to date, to set min time in each day use `minTime`.
  static member inline minDateTime (value: 'a) = Interop.mkAttr "minDateTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback firing on month change. @DateIOType
  static member inline onMonthChange (handler: Event -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  ///   Custom renderer for day. Check the [PickersDay](https://mui.com/api/pickers-day/) component.
  static member inline renderDay (value: TODO) = Interop.mkAttr "renderDay" value
  ///   Component displaying when passed `loading` true.
  static member inline renderLoading (value: TODO) = Interop.mkAttr "renderLoading" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  static member inline shouldDisableDate (value: TODO) = Interop.mkAttr "shouldDisableDate" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  ///   If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Time tab icon.
  static member inline timeIcon (element: ReactElement) = Interop.mkAttr "timeIcon" element
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module staticDateTimePicker =

  /// Force static wrapper inner components to be rendered in mobile or desktop mode.
  [<Erase>]
  type displayStaticWrapperAs =
    static member inline desktop = Interop.mkAttr "displayStaticWrapperAs" "desktop"
    static member inline mobile = Interop.mkAttr "displayStaticWrapperAs" "mobile"

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'day' = Interop.mkAttr "views" Array<'day'
    static member inline hours = Interop.mkAttr "views" "hours"
    static member inline minutes = Interop.mkAttr "views" "minutes"
    static member inline month = Interop.mkAttr "views" "month"
    static member inline seconds = Interop.mkAttr "views" "seconds"
    static member inline 'year'> = Interop.mkAttr "views" 'year'>


[<Erase>]
type staticTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module staticTimePicker =

  /// Force static wrapper inner components to be rendered in mobile or desktop mode.
  [<Erase>]
  type displayStaticWrapperAs =
    static member inline desktop = Interop.mkAttr "displayStaticWrapperAs" "desktop"
    static member inline mobile = Interop.mkAttr "displayStaticWrapperAs" "mobile"

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'hours' = Interop.mkAttr "views" Array<'hours'
    static member inline minutes = Interop.mkAttr "views" "minutes"
    static member inline 'seconds'> = Interop.mkAttr "views" 'seconds'>


[<Erase>]
type step =
  /// Sets the step as active. Is passed to child components.
  static member inline active (value: bool) = Interop.mkAttr "active" value
  ///   Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (element: ReactElement) = prop.children element
  ///   Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Mark the step as completed. Is passed to child components.
  static member inline completed (value: bool) = Interop.mkAttr "completed" value
  ///   If `true`, the step is disabled, will also disable the button if `StepButton` is a child of `Step`. Is passed to child components.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Expand the step.
  static member inline expanded (value: bool) = Interop.mkAttr "expanded" value
  /// The position of the step. The prop defaults to the value inherited from the parent Stepper component.
  static member inline index (value: TODO) = Interop.mkAttr "index" value
  ///   If `true`, the Step is displayed as rendered last. The prop defaults to the value inherited from the parent Stepper component.
  static member inline last (value: bool) = Interop.mkAttr "last" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type stepButton =
  ///   Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (element: ReactElement) = prop.children element
  ///   Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The icon displayed by the step label.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The optional node to display.
  static member inline optional (value: ReactElement) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional (values: ReactElement seq) = Interop.mkAttr "optional" values
  /// The optional node to display.
  static member inline optional (value: string) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional (values: string seq) = Interop.mkAttr "optional" values
  /// The optional node to display.
  static member inline optional (value: int) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional (value: float) = Interop.mkAttr "optional" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type stepConnector =
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type stepContent =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The component used for the transition. [Follow this guide](https://mui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Adjust the duration of the content expand transition. Passed as a prop to the transition component.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// Adjust the duration of the content expand transition. Passed as a prop to the transition component.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module stepContent =

  /// Adjust the duration of the content expand transition. Passed as a prop to the transition component.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  [<Erase>]
  type transitionDuration =
    static member inline auto = Interop.mkAttr "transitionDuration" "auto"


[<Erase>]
type stepIcon =
  /// Whether this step is active.
  static member inline active (value: bool) = Interop.mkAttr "active" value
  /// Mark the step as completed. Is passed to child components.
  static member inline completed (value: bool) = Interop.mkAttr "completed" value
  ///   If `true`, the step is marked as failed.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// The label displayed in the step icon.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type stepLabel =
  /// In most cases will simply be a string containing a title for the label.
  static member inline children (element: ReactElement) = prop.children element
  /// In most cases will simply be a string containing a title for the label.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// In most cases will simply be a string containing a title for the label.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// In most cases will simply be a string containing a title for the label.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// In most cases will simply be a string containing a title for the label.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// In most cases will simply be a string containing a title for the label.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The props used for each slot inside.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   If `true`, the step is marked as failed.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// Override the default label of the step icon.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The optional node to display.
  static member inline optional (value: ReactElement) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional (values: ReactElement seq) = Interop.mkAttr "optional" values
  /// The optional node to display.
  static member inline optional (value: string) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional (values: string seq) = Interop.mkAttr "optional" values
  /// The optional node to display.
  static member inline optional (value: int) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional (value: float) = Interop.mkAttr "optional" value
  ///   The component to render in place of the
  ///
  /// [`StepIcon`](https://mui.com/api/step-icon/).
  static member inline StepIconComponent (value: ReactElementType) = Interop.mkAttr "StepIconComponent" value
  ///   Props applied to the
  ///
  /// [`StepIcon`](https://mui.com/api/step-icon/) element.
  static member inline StepIconProps (props: IReactProperty list) = Interop.mkAttr "StepIconProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type stepper =
  /// Set the active step (zero based index). Set to -1 to disable all the steps.
  static member inline activeStep (value: TODO) = Interop.mkAttr "activeStep" value
  /// If set to 'true' and orientation is horizontal, then the step label will be positioned under the icon.
  static member inline alternativeLabel (value: bool) = Interop.mkAttr "alternativeLabel" value
  ///   Two or more `<Step />` components.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// An element to be placed between each step.
  static member inline connector (value: ReactElement) = Interop.mkAttr "connector" value
  ///   If set the `Stepper` will not assist in controlling steps for linear flow.
  static member inline nonLinear (value: bool) = Interop.mkAttr "nonLinear" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module stepper =

  /// The component orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"


[<Erase>]
type svgIcon =
  /// Node passed into the SVG element.
  static member inline children (element: ReactElement) = prop.children element
  /// Node passed into the SVG element.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Node passed into the SVG element.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Node passed into the SVG element.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Node passed into the SVG element.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Node passed into the SVG element.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Applies a color attribute to the SVG element.
  static member inline htmlColor (value: string) = Interop.mkAttr "htmlColor" value
  ///   If `true`, the root node will inherit the custom `component`'s viewBox and the `viewBox` prop will be ignored. Useful when you want to reference a custom `component` and have `SvgIcon` pass that `component`'s viewBox to the root node.
  static member inline inheritViewBox (value: bool) = Interop.mkAttr "inheritViewBox" value
  ///   The shape-rendering attribute. The behavior of the different options is described on the [MDN Web Docs](https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/shape-rendering). If you are having issues with blurry icons you should investigate this prop.
  static member inline shapeRendering (value: string) = Interop.mkAttr "shapeRendering" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   Provides a human-readable title for the element that contains it. https://www.w3.org/TR/SVG-access/#Equivalent
  static member inline titleAccess (value: string) = Interop.mkAttr "titleAccess" value
  /// Allows you to redefine what the coordinates without units mean inside an SVG element. For example, if the SVG element is 500 (width) by 200 (height), and you pass viewBox="0 0 50 20", this means that the coordinates inside the SVG will go from the top left corner (0,0) to bottom right (50,20) and each unit will be worth 10px.
  static member inline viewBox (value: string) = Interop.mkAttr "viewBox" value

module svgIcon =

  ///   The color of the component. You can use the `htmlColor` prop to apply a color attribute to the SVG element.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline action = Interop.mkAttr "color" "action"
    static member inline disabled = Interop.mkAttr "color" "disabled"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// The fontSize applied to the icon. Defaults to 24px, but can be configure to inherit font size.
  [<Erase>]
  type fontSize =
    static member inline inherit' = Interop.mkAttr "fontSize" "inherit"
    static member inline large = Interop.mkAttr "fontSize" "large"
    static member inline medium = Interop.mkAttr "fontSize" "medium"
    static member inline small = Interop.mkAttr "fontSize" "small"
    static member inline string = Interop.mkAttr "fontSize" string


[<Erase>]
type swipeableDrawer =
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback fired when the component requests to be opened.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Disable the backdrop transition. This can improve the FPS on low-end devices.
  static member inline disableBackdropTransition (value: bool) = Interop.mkAttr "disableBackdropTransition" value
  ///   If `true`, touching the screen near the edge of the drawer will not slide in the drawer a bit to promote accidental discovery of the swipe gesture.
  static member inline disableDiscovery (value: bool) = Interop.mkAttr "disableDiscovery" value
  ///   If `true`, swipe to open is disabled. This is useful in browsers where swiping triggers navigation actions. Swipe to open is disabled on iOS browsers by default.
  static member inline disableSwipeToOpen (value: bool) = Interop.mkAttr "disableSwipeToOpen" value
  /// Affects how far the drawer must be opened/closed to change its state. Specified as percent (0-1) of the width of the drawer
  static member inline hysteresis (value: float) = Interop.mkAttr "hysteresis" value
  /// Defines, from which (average) velocity on, the swipe is defined as complete although hysteresis isn't reached. Good threshold is between 250 - 1000 px/s
  static member inline minFlingVelocity (value: int) = Interop.mkAttr "minFlingVelocity" value
  /// The element is used to intercept the touch events on the edge.
  static member inline SwipeAreaProps (props: IReactProperty list) = Interop.mkAttr "SwipeAreaProps" (createObj !!props)
  ///   The width of the left most (or right most) area in `px` that the drawer can be swiped open from.
  static member inline swipeAreaWidth (value: int) = Interop.mkAttr "swipeAreaWidth" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)


[<Erase>]
type switch =
  ///   If `true`, the component is checked.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon (element: ReactElement) = Interop.mkAttr "checkedIcon" element
  /// The default checked state. Use when the component is not controlled.
  static member inline defaultChecked (value: bool) = Interop.mkAttr "defaultChecked" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the ripple effect is disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  ///   The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  ///   Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string). You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string). You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
  ///   If `true`, the `input` element is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// The value of the component. The browser uses "on" as the default value.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module switch =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// If given, uses a negative margin to counteract the padding on one side (this is often helpful for aligning the left or right side of the icon with content above or below, without ruining the border size and shape).
  [<Erase>]
  type edge =
    static member inline end' = Interop.mkAttr "edge" "end"
    static member inline start = Interop.mkAttr "edge" "start"
    static member inline false' = Interop.mkAttr "edge" false

  ///   The size of the component. `small` is equivalent to the dense switch styling.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type switchUnstyled =
  ///   If `true`, the component is checked.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// Class name applied to the root element.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   The component used for the Root slot. Either a string to use a HTML element or a component. This is equivalent to `components.Root`. If both are provided, the `component` is used.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  ///   The component used for the Root slot. Either a string to use a HTML element or a component. This is equivalent to `components.Root`. If both are provided, the `component` is used.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Switch. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Switch.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// The default checked state. Use when the component is not controlled.
  static member inline defaultChecked (value: bool) = Interop.mkAttr "defaultChecked" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string). You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   If `true`, the component is read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  ///   If `true`, the `input` element is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type tab =
  ///   This prop isn't supported. Use the `component` prop if you need to change the children structure.
  static member inline children  = UnsupportedProp ()
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the keyboard focus ripple is disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  ///   If `true`, the ripple effect is disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `.Mui-focusVisible` class.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display.
  static member inline icon (value: TODO) = Interop.mkAttr "icon" value
  /// The label element.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// The label element.
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// The label element.
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label (value: float) = Interop.mkAttr "label" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// You can provide your own value. Otherwise, we fallback to the child position index.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// Tab labels appear in a single row. They can use a second line if needed.
  static member inline wrapped (value: bool) = Interop.mkAttr "wrapped" value

module tab =

  /// The position of the icon relative to the label.
  [<Erase>]
  type iconPosition =
    static member inline bottom = Interop.mkAttr "iconPosition" "bottom"
    static member inline end' = Interop.mkAttr "iconPosition" "end"
    static member inline start = Interop.mkAttr "iconPosition" "start"
    static member inline top = Interop.mkAttr "iconPosition" "top"


[<Erase>]
type tabContext =
  ///   The value of the currently selected `Tab`.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value


[<Erase>]
type table =
  ///   The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Set the header sticky.
  ///
  /// ⚠️ It doesn't work with IE11.
  static member inline stickyHeader (value: bool) = Interop.mkAttr "stickyHeader" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module table =

  /// Allows TableCells to inherit padding of the Table.
  [<Erase>]
  type padding =
    static member inline checkbox = Interop.mkAttr "padding" "checkbox"
    static member inline none = Interop.mkAttr "padding" "none"
    static member inline normal = Interop.mkAttr "padding" "normal"

  /// Allows TableCells to inherit size of the Table.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type tableBody =
  ///   The content of the component, normally `TableRow`.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally `TableRow`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally `TableRow`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type tableCell =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Set scope attribute.
  static member inline scope (value: string) = Interop.mkAttr "scope" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module tableCell =

  ///   Set the text-align on the table cell content.
  ///
  /// Monetary or generally number fields **should be right aligned** as that allows you to add them up quickly in your head without having to worry about decimals.
  [<Erase>]
  type align =
    static member inline center = Interop.mkAttr "align" "center"
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline justify = Interop.mkAttr "align" "justify"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline right = Interop.mkAttr "align" "right"

  ///   Sets the padding applied to the cell. The prop defaults to the value (`'default'`) inherited from the parent Table component.
  [<Erase>]
  type padding =
    static member inline checkbox = Interop.mkAttr "padding" "checkbox"
    static member inline none = Interop.mkAttr "padding" "none"
    static member inline normal = Interop.mkAttr "padding" "normal"

  ///   Specify the size of the cell. The prop defaults to the value (`'medium'`) inherited from the parent Table component.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"

  /// Set aria-sort direction.
  [<Erase>]
  type sortDirection =
    static member inline asc = Interop.mkAttr "sortDirection" "asc"
    static member inline desc = Interop.mkAttr "sortDirection" "desc"
    static member inline false' = Interop.mkAttr "sortDirection" false

  /// Specify the cell type. The prop defaults to the value inherited from the parent TableHead, TableBody, or TableFooter components.
  [<Erase>]
  type variant =
    static member inline body = Interop.mkAttr "variant" "body"
    static member inline footer = Interop.mkAttr "variant" "footer"
    static member inline head = Interop.mkAttr "variant" "head"


[<Erase>]
type tableContainer =
  ///   The content of the component, normally `Table`.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally `Table`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally `Table`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally `Table`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally `Table`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally `Table`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type tableFooter =
  ///   The content of the component, normally `TableRow`.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally `TableRow`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally `TableRow`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type tableHead =
  ///   The content of the component, normally `TableRow`.
  static member inline children (element: ReactElement) = prop.children element
  ///   The content of the component, normally `TableRow`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The content of the component, normally `TableRow`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The content of the component, normally `TableRow`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type tablePagination =
  /// The total number of rows.
  ///
  /// To enable server side pagination for an unknown number of items, provide -1.
  static member inline count (value: TODO) = Interop.mkAttr "count" value
  ///   Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.MouseEvent | null, page: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *page:* The page selected.
  static member inline onPageChange (handler: Event -> unit) = Interop.mkAttr "onPageChange" handler
  /// The zero-based index of the current page.
  static member inline page (value: TODO) = Interop.mkAttr "page" value
  /// The number of rows per page.
  ///
  /// Set -1 to display all the rows.
  static member inline rowsPerPage (value: TODO) = Interop.mkAttr "rowsPerPage" value
  /// The component used for displaying the actions. Either a string to use a HTML element or a component.
  static member inline ActionsComponent (value: ReactElementType) = Interop.mkAttr "ActionsComponent" value
  ///   Props applied to the back arrow
  ///
  /// [`IconButton`](https://mui.com/api/icon-button/) component.
  static member inline backIconButtonProps (props: IReactProperty list) = Interop.mkAttr "backIconButtonProps" (createObj !!props)
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Accepts a function which returns a string value that provides a user-friendly name for the current page. This is important for screen reader users.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  ///
  /// **Signature:**
  ///
  /// `function(type: string) => string`
  ///
  /// *type:* The link or button type to format ('first' | 'last' | 'next' | 'previous').
  static member inline getItemAriaLabel (value: TODO) = Interop.mkAttr "getItemAriaLabel" value
  ///   Customize the displayed rows label. Invoked with a `{ from, to, count, page }` object.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelDisplayedRows (getLabel: {| from: int; ``to``: int; count: int |} -> ReactElement) = Interop.mkAttr "labelDisplayedRows" getLabel
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (value: ReactElement) = Interop.mkAttr "labelRowsPerPage" value
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (values: ReactElement seq) = Interop.mkAttr "labelRowsPerPage" values
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (value: string) = Interop.mkAttr "labelRowsPerPage" value
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (values: string seq) = Interop.mkAttr "labelRowsPerPage" values
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (value: int) = Interop.mkAttr "labelRowsPerPage" value
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (value: float) = Interop.mkAttr "labelRowsPerPage" value
  ///   Props applied to the next arrow
  ///
  /// [`IconButton`](https://mui.com/api/icon-button/) element.
  static member inline nextIconButtonProps (props: IReactProperty list) = Interop.mkAttr "nextIconButtonProps" (createObj !!props)
  ///   Callback fired when the number of rows per page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onRowsPerPageChange (handler: Event -> unit) = Interop.mkAttr "onRowsPerPageChange" handler
  /// Customizes the options of the rows per page select field. If less than two options are available, no select field will be displayed. Use -1 for the value with a custom label to show all the rows.
  static member inline rowsPerPageOptions (value: TODO) = Interop.mkAttr "rowsPerPageOptions" value
  ///   Props applied to the rows per page
  ///
  /// [`Select`](https://mui.com/api/select/) element.
  static member inline SelectProps (props: IReactProperty list) = Interop.mkAttr "SelectProps" (createObj !!props)
  ///   If `true`, show the first-page button.
  static member inline showFirstButton (value: bool) = Interop.mkAttr "showFirstButton" value
  ///   If `true`, show the last-page button.
  static member inline showLastButton (value: bool) = Interop.mkAttr "showLastButton" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type tablePaginationUnstyled =
  /// The total number of rows.
  ///
  /// To enable server side pagination for an unknown number of items, provide -1.
  static member inline count (value: int) = Interop.mkAttr "count" value
  ///   Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.MouseEvent | null, page: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *page:* The page selected.
  static member inline onPageChange (handler: Event -> unit) = Interop.mkAttr "onPageChange" handler
  /// The zero-based index of the current page.
  static member inline page (value: TODO) = Interop.mkAttr "page" value
  /// The number of rows per page.
  ///
  /// Set -1 to display all the rows.
  static member inline rowsPerPage (value: TODO) = Interop.mkAttr "rowsPerPage" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the TablePagination. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the TablePagination.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Accepts a function which returns a string value that provides a user-friendly name for the current page. This is important for screen reader users.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  ///
  /// **Signature:**
  ///
  /// `function(type: string) => string`
  ///
  /// *type:* The link or button type to format ('first' | 'last' | 'next' | 'previous').
  static member inline getItemAriaLabel (value: TODO) = Interop.mkAttr "getItemAriaLabel" value
  ///   Customize the displayed rows label. Invoked with a `{ from, to, count, page }` object.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelDisplayedRows (value: TODO) = Interop.mkAttr "labelDisplayedRows" value
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (value: ReactElement) = Interop.mkAttr "labelRowsPerPage" value
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (values: ReactElement seq) = Interop.mkAttr "labelRowsPerPage" values
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (value: string) = Interop.mkAttr "labelRowsPerPage" value
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (values: string seq) = Interop.mkAttr "labelRowsPerPage" values
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (value: int) = Interop.mkAttr "labelRowsPerPage" value
  ///   Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://mui.com/guides/localization/).
  static member inline labelRowsPerPage (value: float) = Interop.mkAttr "labelRowsPerPage" value
  ///   Callback fired when the number of rows per page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.ChangeEvent) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onRowsPerPageChange (handler: Event -> unit) = Interop.mkAttr "onRowsPerPageChange" handler
  /// Customizes the options of the rows per page select field. If less than two options are available, no select field will be displayed. Use -1 for the value with a custom label to show all the rows.
  static member inline rowsPerPageOptions (value: TODO) = Interop.mkAttr "rowsPerPageOptions" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type tableRow =
  ///   Should be valid `<tr>` children such as `TableCell`.
  static member inline children (element: ReactElement) = prop.children element
  ///   Should be valid `<tr>` children such as `TableCell`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the table row will shade on hover.
  static member inline hover (value: bool) = Interop.mkAttr "hover" value
  ///   If `true`, the table row will have the selected shading.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type tableSortLabel =
  ///   If `true`, the label will have the active styling (should be true for the sorted column).
  static member inline active (value: bool) = Interop.mkAttr "active" value
  /// Label contents, the arrow will be appended automatically.
  static member inline children (element: ReactElement) = prop.children element
  /// Label contents, the arrow will be appended automatically.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Label contents, the arrow will be appended automatically.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Label contents, the arrow will be appended automatically.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Label contents, the arrow will be appended automatically.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Label contents, the arrow will be appended automatically.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Hide sort icon when active is false.
  static member inline hideSortIcon (value: bool) = Interop.mkAttr "hideSortIcon" value
  /// Sort icon to use.
  static member inline IconComponent (value: ReactElementType) = Interop.mkAttr "IconComponent" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module tableSortLabel =

  /// The current sort direction.
  [<Erase>]
  type direction =
    static member inline asc = Interop.mkAttr "direction" "asc"
    static member inline desc = Interop.mkAttr "direction" "desc"


[<Erase>]
type tabList =
  ///   A list of `` elements.
  static member inline children (element: ReactElement) = prop.children element
  ///   A list of `` elements.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   A list of `` elements.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   A list of `` elements.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   A list of `` elements.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   A list of `` elements.
  static member inline children (value: float) = Interop.mkAttr "children" value


[<Erase>]
type tabPanel =
  ///   The `value` of the corresponding `Tab`. Must use the index of the `Tab` when no `value` was passed to `Tab`.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type tabPanelUnstyled =
  /// The value of the TabPanel. It will be shown when the Tab with the corresponding value is selected.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the TabPanel. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the TabPanel.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value


[<Erase>]
type tabs =
  ///   Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It supports two actions: `updateIndicator()` and `updateScrollButtons()`
  static member inline action (ref: IRefValue<TabsActions option>) = Interop.mkAttr "action" ref
  ///   Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It supports two actions: `updateIndicator()` and `updateScrollButtons()`
  static member inline action (handler: TabsActions -> unit) = Interop.mkAttr "action" handler
  ///   If `true`, the scroll buttons aren't forced hidden on mobile. By default the scroll buttons are hidden on mobile and takes precedence over `scrollButtons`.
  static member inline allowScrollButtonsMobile (value: bool) = Interop.mkAttr "allowScrollButtonsMobile" value
  /// The label for the Tabs as a string.
  static member inline ariaLabel (value: string) = Interop.mkAttr "aria-label" value
  /// An id or list of ids separated by a space that label the Tabs.
  static member inline ariaLabelledby (value: string) = Interop.mkAttr "aria-labelledby" value
  ///   If `true`, the tabs are centered. This prop is intended for large views.
  static member inline centered (value: bool) = Interop.mkAttr "centered" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: any) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* We default to the index of the child (number)
  static member inline onChange (handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: any) => void`
  ///
  /// *event:* The event source of the callback. **Warning**: This is a generic event not a change event.
  ///
  /// *value:* We default to the index of the child (number)
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// The component used to render the scroll buttons.
  static member inline ScrollButtonComponent (value: ReactElementType) = Interop.mkAttr "ScrollButtonComponent" value
  ///   If `true` the selected tab changes on focus. Otherwise it only changes on activation.
  static member inline selectionFollowsFocus (value: bool) = Interop.mkAttr "selectionFollowsFocus" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  /// Props applied to the tab indicator element.
  static member inline TabIndicatorProps (props: IReactProperty list) = Interop.mkAttr "TabIndicatorProps" (createObj !!props)
  ///   Props applied to the
  ///
  /// [`TabScrollButton`](https://mui.com/api/tab-scroll-button/) element.
  static member inline TabScrollButtonProps (props: IReactProperty list) = Interop.mkAttr "TabScrollButtonProps" (createObj !!props)
  ///   The value of the currently selected `Tab`. If you don't want any selected `Tab`, you can set this prop to `false`.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  ///   If `true`, the scrollbar is visible. It can be useful when displaying a long vertical list of tabs.
  static member inline visibleScrollbar (value: bool) = Interop.mkAttr "visibleScrollbar" value

module tabs =

  /// Determines the color of the indicator.
  [<Erase>]
  type indicatorColor =
    static member inline primary = Interop.mkAttr "indicatorColor" "primary"
    static member inline secondary = Interop.mkAttr "indicatorColor" "secondary"

  /// The component orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  ///   Determine behavior of scroll buttons when tabs are set to scroll:
  ///
  /// - `auto` will only present them when not all the items are visible. - `true` will always present them. - `false` will never present them.
  ///
  /// By default the scroll buttons are hidden on mobile. This behavior can be disabled with `allowScrollButtonsMobile`.
  [<Erase>]
  type scrollButtons =
    static member inline auto = Interop.mkAttr "scrollButtons" "auto"
    static member inline false' = Interop.mkAttr "scrollButtons" false
    static member inline true' = Interop.mkAttr "scrollButtons" true

  ///   Determines the color of the `Tab`.
  [<Erase>]
  type textColor =
    static member inline inherit' = Interop.mkAttr "textColor" "inherit"
    static member inline primary = Interop.mkAttr "textColor" "primary"
    static member inline secondary = Interop.mkAttr "textColor" "secondary"

  ///   Determines additional display behavior of the tabs:
  ///
  ///  - `scrollable` will invoke scrolling properties and allow for horizontally scrolling (or swiping) of the tab bar. -`fullWidth` will make the tabs grow to use all the available space, which should be used for small views, like on mobile. - `standard` will render the default state.
  [<Erase>]
  type variant =
    static member inline fullWidth = Interop.mkAttr "variant" "fullWidth"
    static member inline scrollable = Interop.mkAttr "variant" "scrollable"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type tabScrollButton =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module tabScrollButton =

  /// The direction the button should indicate.
  [<Erase>]
  type direction =
    static member inline left = Interop.mkAttr "direction" "left"
    static member inline right = Interop.mkAttr "direction" "right"

  /// The component orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"


[<Erase>]
type tabsListUnstyled =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the TabsList. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the TabsList.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value


[<Erase>]
type tabsUnstyled =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Tabs. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Tabs.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: TODO) = Interop.mkAttr "defaultValue" value
  /// Callback invoked when new value is being set.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   If `true` the selected tab changes on focus. Otherwise it only changes on activation.
  static member inline selectionFollowsFocus (value: bool) = Interop.mkAttr "selectionFollowsFocus" value
  ///   The value of the currently selected `Tab`. If you don't want any selected `Tab`, you can set this prop to `false`.
  static member inline value (value: TODO) = Interop.mkAttr "value" value

module tabsUnstyled =

  /// The direction of the text.
  [<Erase>]
  type direction =
    static member inline ltr = Interop.mkAttr "direction" "ltr"
    static member inline rtl = Interop.mkAttr "direction" "rtl"

  /// The component orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"


[<Erase>]
type tabUnstyled =
  ///   A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (value: TODO) = Interop.mkAttr "action" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The components used for each slot inside the Tab. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  /// The props used for each slot inside the Tab.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Callback invoked when new value is being set.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// You can provide your own value. Otherwise, we fall back to the child position index.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type textareaAutosize =
  /// Maximum number of rows to display.
  static member inline maxRows (value: int) = Interop.mkAttr "maxRows" value
  /// Minimum number of rows to display.
  static member inline minRows (value: int) = Interop.mkAttr "minRows" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type textField =
  ///   This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  ///   If `true`, the `input` element is focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the label is displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  ///   Props applied to the
  ///
  /// [`FormHelperText`](https://mui.com/api/form-helper-text/) element.
  static member inline FormHelperTextProps (props: IReactProperty list) = Interop.mkAttr "FormHelperTextProps" (createObj !!props)
  ///   If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// The helper text content.
  static member inline helperText (value: ReactElement) = Interop.mkAttr "helperText" value
  /// The helper text content.
  static member inline helperText (values: ReactElement seq) = Interop.mkAttr "helperText" values
  /// The helper text content.
  static member inline helperText (value: string) = Interop.mkAttr "helperText" value
  /// The helper text content.
  static member inline helperText (values: string seq) = Interop.mkAttr "helperText" values
  /// The helper text content.
  static member inline helperText (value: int) = Interop.mkAttr "helperText" value
  /// The helper text content.
  static member inline helperText (value: float) = Interop.mkAttr "helperText" value
  ///   The id of the `input` element. Use this prop to make `label` and `helperText` accessible for screen readers.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   Props applied to the
  ///
  /// [`InputLabel`](https://mui.com/api/input-label/) element. Pointer events like `onClick` are enabled if and only if `shrink` is `true`.
  static member inline InputLabelProps (props: IReactProperty list) = Interop.mkAttr "InputLabelProps" (createObj !!props)
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  ///   Props applied to the Input element. It will be a
  ///
  /// [`FilledInput`](https://mui.com/api/filled-input/),
  ///
  /// [`OutlinedInput`](https://mui.com/api/outlined-input/) or
  ///
  /// [`Input`](https://mui.com/api/input/) component depending on the `variant` prop value.
  static member inline InputProps (props: IReactProperty list) = Interop.mkAttr "InputProps" (createObj !!props)
  ///   Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  ///   Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// The label content.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// The label content.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// The label content.
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// The label content.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// The label content.
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// The label content.
  static member inline label (value: float) = Interop.mkAttr "label" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline maxRows (value: int) = Interop.mkAttr "maxRows" value
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline minRows (value: int) = Interop.mkAttr "minRows" value
  ///   If `true`, a `textarea` element is rendered instead of an input.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  ///   Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  ///   The short hint displayed in the `input` before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  ///   If `true`, the label is displayed as required and the `input` element is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  ///   Render a
  ///
  /// [`Select`](https://mui.com/api/select/) element while passing the Input element to `Select` as `input` parameter. If this option is set you must pass the options of the select as children.
  static member inline select (value: bool) = Interop.mkAttr "select" value
  ///   Props applied to the
  ///
  /// [`Select`](https://mui.com/api/select/) element.
  static member inline SelectProps (props: IReactProperty list) = Interop.mkAttr "SelectProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  ///   The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module textField =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  ///   If `dense` or `normal`, will adjust vertical spacing of this and contained components.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"
    static member inline normal = Interop.mkAttr "margin" "normal"

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"
    static member inline string = Interop.mkAttr "size" string

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type timeline =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// className applied to the root element.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module timeline =

  /// The position where the TimelineContent should appear relative to the time axis.
  [<Erase>]
  type position =
    static member inline alternate = Interop.mkAttr "position" "alternate"
    static member inline left = Interop.mkAttr "position" "left"
    static member inline right = Interop.mkAttr "position" "right"


[<Erase>]
type timelineConnector =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type timelineContent =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type timelineDot =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module timelineDot =

  /// The dot can have a different colors.
  [<Erase>]
  type color =
    static member inline error = Interop.mkAttr "color" "error"
    static member inline grey = Interop.mkAttr "color" "grey"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"

  /// The dot can appear filled or outlined.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type timelineItem =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module timelineItem =

  /// The position where the timeline's item should appear.
  [<Erase>]
  type position =
    static member inline left = Interop.mkAttr "position" "left"
    static member inline right = Interop.mkAttr "position" "right"


[<Erase>]
type timelineOppositeContent =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type timelineSeparator =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type timePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  ///   The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/api/text-field/#textfield-api) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  static member inline renderInput (value: TODO) = Interop.mkAttr "renderInput" value
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (value: TODO) = Interop.mkAttr "acceptRegex" value
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// Cancel text message.
  static member inline cancelText (value: ReactElement) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: ReactElement seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: string) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (values: string seq) = Interop.mkAttr "cancelText" values
  /// Cancel text message.
  static member inline cancelText (value: int) = Interop.mkAttr "cancelText" value
  /// Cancel text message.
  static member inline cancelText (value: float) = Interop.mkAttr "cancelText" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  ///   If `true`, it shows the clear action in the picker dialog.
  static member inline clearable (value: bool) = Interop.mkAttr "clearable" value
  /// Clear text message.
  static member inline clearText (value: ReactElement) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: ReactElement seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (values: string seq) = Interop.mkAttr "clearText" values
  /// Clear text message.
  static member inline clearText (value: int) = Interop.mkAttr "clearText" value
  /// Clear text message.
  static member inline clearText (value: float) = Interop.mkAttr "clearText" value
  /// The components used for each slot. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  ///   CSS media query when `Mobile` mode will be changed to `Desktop`.
  static member inline desktopModeMediaQuery (value: string) = Interop.mkAttr "desktopModeMediaQuery" value
  ///   Props applied to the
  ///
  /// [`Dialog`](https://mui.com/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  ///   If `true` the popup or dialog will immediately close after submitting full date.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  ///   If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Accessible text that helps user to understand which time and view is selected.
  static member inline getClockLabelText (value: TODO) = Interop.mkAttr "getClockLabelText" value
  /// Get aria-label text for control that opens picker dialog. Aria-label text must include selected date. @DateIOType
  static member inline getOpenDialogAriaText (value: TODO) = Interop.mkAttr "getOpenDialogAriaText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  ///   Pass a ref to the `input` element.
  static member inline inputRef (value: TODO) = Interop.mkAttr "inputRef" value
  ///   Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  ///   Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'a) = Interop.mkAttr "maxTime" value
  ///   Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'a) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Ok button text.
  static member inline okText (value: ReactElement) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: ReactElement seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: string) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (values: string seq) = Interop.mkAttr "okText" values
  /// Ok button text.
  static member inline okText (value: int) = Interop.mkAttr "okText" value
  /// Ok button text.
  static member inline okText (value: float) = Interop.mkAttr "okText" value
  /// Callback fired when date is accepted @DateIOType.
  static member inline onAccept (handler: Event -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  static member inline onViewChange (handler: Event -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  ///   Paper props passed down to [Paper](https://mui.com/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  ///   Popper props passed down to [Popper](https://mui.com/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Custom formatter to be passed into Rifm component.
  static member inline rifmFormatter (value: TODO) = Interop.mkAttr "rifmFormatter" value
  ///   Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  static member inline shouldDisableTime (value: TODO) = Interop.mkAttr "shouldDisableTime" value
  ///   If `true`, the today button is displayed. **Note** that `showClearButton` has a higher priority.
  static member inline showTodayButton (value: bool) = Interop.mkAttr "showTodayButton" value
  ///   If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Today text message.
  static member inline todayText (value: ReactElement) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: ReactElement seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: string) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (values: string seq) = Interop.mkAttr "todayText" values
  /// Today text message.
  static member inline todayText (value: int) = Interop.mkAttr "todayText" value
  /// Today text message.
  static member inline todayText (value: float) = Interop.mkAttr "todayText" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: ReactElement seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  ///   Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: ReactElement seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  ///   Custom component for popper [Transition](https://mui.com/components/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: TODO) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module timePicker =

  /// First view to show.
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"

  /// Array of views to show.
  [<Erase>]
  type views =
    static member inline Array<'hours' = Interop.mkAttr "views" Array<'hours'
    static member inline minutes = Interop.mkAttr "views" "minutes"
    static member inline 'seconds'> = Interop.mkAttr "views" 'seconds'>


[<Erase>]
type toggleButton =
  /// The value to associate with the button when selected in a ToggleButtonGroup.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the component is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, the keyboard focus ripple is disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  ///   If `true`, the ripple effect is disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `.Mui-focusVisible` class.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  ///   If `true`, the button will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   If `true`, the button is rendered in an active state.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module toggleButton =

  /// The color of the button when it is in an active state.
  [<Erase>]
  type color =
    static member inline standard = Interop.mkAttr "color" "standard"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// The size of the component. The prop defaults to the value inherited from the parent ToggleButtonGroup component.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type toggleButtonGroup =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  ///   If `true`, the component is disabled. This implies that all ToggleButton children will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  ///   If `true`, only allow one of the child ToggleButton values to be selected.
  static member inline exclusive (value: bool) = Interop.mkAttr "exclusive" value
  ///   If `true`, the button group will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.MouseEvent, value: any) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* of the selected buttons. When `exclusive` is true this is a single value; when false an array of selected values. If no value is selected and `exclusive` is true the value is null; when false an empty array.
  static member inline onChange (handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  ///   Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.MouseEvent, value: any) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* of the selected buttons. When `exclusive` is true this is a single value; when false an array of selected values. If no value is selected and `exclusive` is true the value is null; when false an empty array.
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The currently selected value within the group or an array of selected values when `exclusive` is false.
  ///
  /// The value must have reference equality with the option in order to be selected.
  static member inline value (value: 'toggleButtonValue option) = Interop.mkAttr "value" value
  ///   The currently selected value within the group or an array of selected values when `exclusive` is false.
  ///
  /// The value must have reference equality with the option in order to be selected.
  static member inline value (values: 'toggleButtonValue []) = Interop.mkAttr "value" (ResizeArray values)

module toggleButtonGroup =

  /// The color of a button when it is selected.
  [<Erase>]
  type color =
    static member inline standard = Interop.mkAttr "color" "standard"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"
    static member inline string = Interop.mkAttr "color" string

  /// The component orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The size of the component.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"
    static member inline string = Interop.mkAttr "size" string


[<Erase>]
type toolbar =
  ///   The Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`. The Toolbar is a flex container, allowing flex item properites to be used to lay out the children.
  static member inline children (element: ReactElement) = prop.children element
  ///   The Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`. The Toolbar is a flex container, allowing flex item properites to be used to lay out the children.
  static member inline children (elements: ReactElement seq) = prop.children elements
  ///   The Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`. The Toolbar is a flex container, allowing flex item properites to be used to lay out the children.
  static member inline children (value: string) = Interop.mkAttr "children" value
  ///   The Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`. The Toolbar is a flex container, allowing flex item properites to be used to lay out the children.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  ///   The Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`. The Toolbar is a flex container, allowing flex item properites to be used to lay out the children.
  static member inline children (value: int) = Interop.mkAttr "children" value
  ///   The Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`. The Toolbar is a flex container, allowing flex item properites to be used to lay out the children.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, disables gutter padding.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value

module toolbar =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline dense = Interop.mkAttr "variant" "dense"
    static member inline regular = Interop.mkAttr "variant" "regular"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type tooltip =
  ///   Tooltip reference element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (value: ReactElement) = Interop.mkAttr "title" value
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (values: ReactElement seq) = Interop.mkAttr "title" values
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (value: string) = Interop.mkAttr "title" value
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (values: string seq) = Interop.mkAttr "title" values
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (value: int) = Interop.mkAttr "title" value
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (value: float) = Interop.mkAttr "title" value
  ///   If `true`, adds an arrow to the tooltip.
  static member inline arrow (value: bool) = Interop.mkAttr "arrow" value
  /// The components used for each slot inside the Tooltip. Either a string to use a HTML element or a component.
  static member inline components (value: TODO) = Interop.mkAttr "components" value
  ///   The props used for each slot inside the Tooltip. Note that `componentsProps.popper` prop values win over `PopperProps` and `componentsProps.transition` prop values win over `TransitionProps` if both are applied.
  static member inline componentsProps (value: TODO) = Interop.mkAttr "componentsProps" value
  ///   Set to `true` if the `title` acts as an accessible description. By default the `title` acts as an accessible label for the child.
  static member inline describeChild (value: bool) = Interop.mkAttr "describeChild" value
  /// Do not respond to focus-visible events.
  static member inline disableFocusListener (value: bool) = Interop.mkAttr "disableFocusListener" value
  /// Do not respond to hover events.
  static member inline disableHoverListener (value: bool) = Interop.mkAttr "disableHoverListener" value
  ///   Makes a tooltip not interactive, i.e. it will close when the user hovers over the tooltip before the `leaveDelay` is expired.
  static member inline disableInteractive (value: bool) = Interop.mkAttr "disableInteractive" value
  /// Do not respond to long press touch events.
  static member inline disableTouchListener (value: bool) = Interop.mkAttr "disableTouchListener" value
  ///   The number of milliseconds to wait before showing the tooltip. This prop won't impact the enter touch delay (`enterTouchDelay`).
  static member inline enterDelay (value: int) = Interop.mkAttr "enterDelay" value
  /// The number of milliseconds to wait before showing the tooltip when one was already recently opened.
  static member inline enterNextDelay (value: int) = Interop.mkAttr "enterNextDelay" value
  /// The number of milliseconds a user must touch the element before showing the tooltip.
  static member inline enterTouchDelay (value: int) = Interop.mkAttr "enterTouchDelay" value
  ///   If `true`, the tooltip follow the cursor over the wrapped element.
  static member inline followCursor (value: bool) = Interop.mkAttr "followCursor" value
  /// This prop is used to help implement the accessibility logic. If you don't provide this prop. It falls back to a randomly generated id.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   The number of milliseconds to wait before hiding the tooltip. This prop won't impact the leave touch delay (`leaveTouchDelay`).
  static member inline leaveDelay (value: int) = Interop.mkAttr "leaveDelay" value
  /// The number of milliseconds after the user stops touching an element before hiding the tooltip.
  static member inline leaveTouchDelay (value: int) = Interop.mkAttr "leaveTouchDelay" value
  ///   Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  ///   Callback fired when the component requests to be open.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  ///   If `true`, the component is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The component used for the popper.
  static member inline PopperComponent (value: ReactElementType) = Interop.mkAttr "PopperComponent" value
  ///   Props applied to the
  ///
  /// [`Popper`](https://mui.com/api/popper/) element.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The component used for the transition. [Follow this guide](https://mui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module tooltip =

  /// Tooltip placement.
  [<Erase>]
  type placement =
    static member inline bottomEnd = Interop.mkAttr "placement" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "placement" "bottom-start"
    static member inline bottom = Interop.mkAttr "placement" "bottom"
    static member inline leftEnd = Interop.mkAttr "placement" "left-end"
    static member inline leftStart = Interop.mkAttr "placement" "left-start"
    static member inline left = Interop.mkAttr "placement" "left"
    static member inline rightEnd = Interop.mkAttr "placement" "right-end"
    static member inline rightStart = Interop.mkAttr "placement" "right-start"
    static member inline right = Interop.mkAttr "placement" "right"
    static member inline topEnd = Interop.mkAttr "placement" "top-end"
    static member inline topStart = Interop.mkAttr "placement" "top-start"
    static member inline top = Interop.mkAttr "placement" "top"


[<Erase>]
type treeItem =
  /// The id of the node.
  static member inline nodeId (value: string) = Interop.mkAttr "nodeId" value
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The icon used to collapse the node.
  static member inline collapseIcon (element: ReactElement) = Interop.mkAttr "collapseIcon" element
  ///   The component used for the content node.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline ContentComponent (value: ReactElementType) = Interop.mkAttr "ContentComponent" value
  /// Props applied to ContentComponent
  static member inline ContentProps (props: IReactProperty list) = Interop.mkAttr "ContentProps" (createObj !!props)
  ///   If `true`, the node is disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// The icon displayed next to a end node.
  static member inline endIcon (element: ReactElement) = Interop.mkAttr "endIcon" element
  /// The icon used to expand the node.
  static member inline expandIcon (element: ReactElement) = Interop.mkAttr "expandIcon" element
  /// The icon to display next to the tree node's label.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The tree node label.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// The tree node label.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// The tree node label.
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// The tree node label.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// The tree node label.
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// The tree node label.
  static member inline label (value: float) = Interop.mkAttr "label" value
  ///   This prop isn't supported. Use the `onNodeFocus` callback on the tree if you need to monitor a node's focus.
  static member inline onFocus  = UnsupportedProp ()
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The component used for the transition. [Follow this guide](https://mui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  ///   Props applied to the transition element. By default, the element is based on this
  ///
  /// [`Transition`](http://reactcommunity.org/react-transition-group/transition/) component.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)


[<Erase>]
type treeView =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The default icon used to collapse the node.
  static member inline defaultCollapseIcon (element: ReactElement) = Interop.mkAttr "defaultCollapseIcon" element
  ///   The default icon displayed next to a end node. This is applied to all tree nodes and can be overridden by the TreeItem `icon` prop.
  static member inline defaultEndIcon (element: ReactElement) = Interop.mkAttr "defaultEndIcon" element
  /// Expanded node ids. (Uncontrolled)
  static member inline defaultExpanded ([<ParamArray>] nodeIds: string []) = Interop.mkAttr "defaultExpanded" nodeIds
  /// The default icon used to expand the node.
  static member inline defaultExpandIcon (element: ReactElement) = Interop.mkAttr "defaultExpandIcon" element
  ///   The default icon displayed next to a parent node. This is applied to all parent nodes and can be overridden by the TreeItem `icon` prop.
  static member inline defaultParentIcon (element: ReactElement) = Interop.mkAttr "defaultParentIcon" element
  ///   Selected node ids. (Uncontrolled) When `multiSelect` is true this takes an array of strings; when false (default) a string.
  static member inline defaultSelected (value: string) = Interop.mkAttr "defaultSelected" value
  ///   Selected node ids. (Uncontrolled) When `multiSelect` is true this takes an array of strings; when false (default) a string.
  static member inline defaultSelected ([<ParamArray>] values: string []) = Interop.mkAttr "defaultSelected" values
  ///   If `true`, will allow focus on disabled items.
  static member inline disabledItemsFocusable (value: bool) = Interop.mkAttr "disabledItemsFocusable" value
  ///   If `true` selection is disabled.
  static member inline disableSelection (value: bool) = Interop.mkAttr "disableSelection" value
  /// Expanded node ids. (Controlled)
  static member inline expanded ([<ParamArray>] nodeIds: string []) = Interop.mkAttr "expanded" nodeIds
  /// This prop is used to help implement the accessibility logic. If you don't provide this prop. It falls back to a randomly generated id.
  static member inline id (value: string) = Interop.mkAttr "id" value
  ///   If true `ctrl` and `shift` will trigger multiselect.
  static member inline multiSelect (value: bool) = Interop.mkAttr "multiSelect" value
  ///   Callback fired when tree items are focused.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, value: string) => void`
  ///
  /// *event:* The event source of the callback **Warning**: This is a generic event not a focus event.
  ///
  /// *value:* of the focused node.
  static member inline onNodeFocus (handler: Event -> unit) = Interop.mkAttr "onNodeFocus" handler
  ///   Callback fired when tree items are selected/unselected.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, nodeIds: Array | string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *nodeIds:* Ids of the selected nodes. When `multiSelect` is true this is an array of strings; when false (default) a string.
  static member inline onNodeSelect (handler: Event -> string -> unit) = Interop.mkAttr "onNodeSelect" (Func<_,_,_> handler)
  ///   Callback fired when tree items are selected/unselected.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, nodeIds: Array | string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *nodeIds:* Ids of the selected nodes. When `multiSelect` is true this is an array of strings; when false (default) a string.
  static member inline onNodeSelect (handler: Event -> string [] -> unit) = Interop.mkAttr "onNodeSelect" (Func<_,_,_> handler)
  ///   Callback fired when tree items are expanded/collapsed.
  ///
  /// **Signature:**
  ///
  /// `function(event: React.SyntheticEvent, nodeIds: array) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *nodeIds:* The ids of the expanded nodes.
  static member inline onNodeToggle (handler: Event -> string [] -> unit) = Interop.mkAttr "onNodeToggle" handler
  ///   Selected node ids. (Controlled) When `multiSelect` is true this takes an array of strings; when false (default) a string.
  static member inline selected (value: string) = Interop.mkAttr "selected" value
  ///   Selected node ids. (Controlled) When `multiSelect` is true this takes an array of strings; when false (default) a string.
  static member inline selected ([<ParamArray>] values: string []) = Interop.mkAttr "selected" values
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value


[<Erase>]
type typography =
  /// The content of the component.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  ///   If `true`, the text will have a bottom margin.
  static member inline gutterBottom (value: bool) = Interop.mkAttr "gutterBottom" value
  ///   If `true`, the text will not wrap, but instead will truncate with a text overflow ellipsis.
  ///
  /// Note that text overflow can only happen with block or inline-block level elements (the element needs to have a width in order to overflow).
  static member inline noWrap (value: bool) = Interop.mkAttr "noWrap" value
  ///   If `true`, the element will be a paragraph element.
  static member inline paragraph (value: bool) = Interop.mkAttr "paragraph" value
  ///   The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/the-sx-prop/) for more details.
  static member inline sx (value: TODO) = Interop.mkAttr "sx" value
  ///   The component maps the variant prop to a range of different HTML element types. For instance, subtitle1 to ``. If you wish to change that mapping, you can provide your own. Alternatively, you can use the `component` prop.
  static member inline variantMapping (?h1: string, ?h2: string, ?h3: string, ?h4: string, ?h5: string, ?h6: string, ?subtitle1: string, ?subtitle2: string, ?body1: string, ?body2: string) = Interop.mkAttr "variantMapping" (let x = createEmpty<obj> in (if h1.IsSome then x?``h1`` <- h1); (if h2.IsSome then x?``h2`` <- h2); (if h3.IsSome then x?``h3`` <- h3); (if h4.IsSome then x?``h4`` <- h4); (if h5.IsSome then x?``h5`` <- h5); (if h6.IsSome then x?``h6`` <- h6); (if subtitle1.IsSome then x?``subtitle1`` <- subtitle1); (if subtitle2.IsSome then x?``subtitle2`` <- subtitle2); (if body1.IsSome then x?``body1`` <- body1); (if body2.IsSome then x?``body2`` <- body2); x)

module typography =

  /// Set the text-align on the component.
  [<Erase>]
  type align =
    static member inline center = Interop.mkAttr "align" "center"
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline justify = Interop.mkAttr "align" "justify"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline right = Interop.mkAttr "align" "right"

  /// Applies the theme typography styles.
  [<Erase>]
  type variant =
    static member inline body1 = Interop.mkAttr "variant" "body1"
    static member inline body2 = Interop.mkAttr "variant" "body2"
    static member inline button = Interop.mkAttr "variant" "button"
    static member inline caption = Interop.mkAttr "variant" "caption"
    static member inline h1 = Interop.mkAttr "variant" "h1"
    static member inline h2 = Interop.mkAttr "variant" "h2"
    static member inline h3 = Interop.mkAttr "variant" "h3"
    static member inline h4 = Interop.mkAttr "variant" "h4"
    static member inline h5 = Interop.mkAttr "variant" "h5"
    static member inline h6 = Interop.mkAttr "variant" "h6"
    static member inline inherit' = Interop.mkAttr "variant" "inherit"
    static member inline overline = Interop.mkAttr "variant" "overline"
    static member inline subtitle1 = Interop.mkAttr "variant" "subtitle1"
    static member inline subtitle2 = Interop.mkAttr "variant" "subtitle2"
    static member inline string = Interop.mkAttr "variant" string


[<Erase>]
type unstable_TrapFocus =
  ///   If `true`, focus is locked.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  ///   A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  ///   If `true`, the trap focus will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any trap focus children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the trap focus less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus (value: bool) = Interop.mkAttr "disableAutoFocus" value
  ///   If `true`, the trap focus will not prevent focus from leaving the trap focus while open.
  ///
  /// Generally this should never be set to `true` as it makes the trap focus less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus (value: bool) = Interop.mkAttr "disableEnforceFocus" value
  ///   If `true`, the trap focus will not restore focus to previously focused element once trap focus is hidden.
  static member inline disableRestoreFocus (value: bool) = Interop.mkAttr "disableRestoreFocus" value
  ///   Returns an array of ordered tabbable nodes (i.e. in tab order) within the root. For instance, you can provide the "tabbable" npm dependency.
  ///
  /// **Signature:**
  ///
  /// `function(root: HTMLElement) => void`
  static member inline getTabbable (value: TODO) = Interop.mkAttr "getTabbable" value
  ///   This prop extends the `open` prop. It allows to toggle the open state without having to wait for a rerender when changing the `open` prop. This prop should be memoized. It can be used to support multiple trap focus mounted at the same time.
  static member inline isEnabled (isEnabled: unit -> bool) = Interop.mkAttr "isEnabled" isEnabled


[<Erase>]
type yearPicker =
  /// Callback firing on year change @DateIOType.
  static member inline onYearChange (handler: Event -> unit) = Interop.mkAttr "onYearChange" handler
  ///   Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  static member inline shouldDisableYear (value: TODO) = Interop.mkAttr "shouldDisableYear" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type zoom =
  ///   A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://mui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Add a custom transition end trigger. Called with the transitioning DOM node and a done callback. Allows for more fine grained transition end logic. Note: Timeouts are still used as a fallback if provided.
  static member inline addEndListener (value: TODO) = Interop.mkAttr "addEndListener" value
  ///   Perform the enter transition when it first mounts if `in` is also `true`. Set this to `false` to disable this behavior.
  static member inline appear (value: bool) = Interop.mkAttr "appear" value
  /// The transition timing function. You may specify a single easing or a object containing enter and exit values.
  static member inline easing (value: TODO) = Interop.mkAttr "easing" value
  ///   If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
