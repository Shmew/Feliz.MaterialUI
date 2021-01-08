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
  /// The content of the accordion.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the accordion.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the accordion.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the accordion.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the accordion.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the accordion.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, expands the accordion by default.
  static member inline defaultExpanded (value: bool) = Interop.mkAttr "defaultExpanded" value
  /// If `true`, the accordion will be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, expands the accordion, otherwise collapse it. Setting this prop enables control over the accordion.
  static member inline expanded (value: bool) = Interop.mkAttr "expanded" value
  /// Callback fired when the expand/collapse state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, expanded: boolean) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *expanded:* The `expanded` state of the accordion.
  static member inline onChange (handler: Event -> bool -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback fired when the expand/collapse state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, expanded: boolean) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *expanded:* The `expanded` state of the accordion.
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value
  /// The component used for the collapse effect. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value

module accordion =

  /// *Inherited from `paper`*
  ///
  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline elevation = Interop.mkAttr "variant" "elevation"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


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
  /// If `true`, the actions do not have additional margin.
  static member inline disableSpacing (value: bool) = Interop.mkAttr "disableSpacing" value


[<Erase>]
type accordionDetails =
  /// The content of the accordion details.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the accordion details.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the accordion details.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the accordion details.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the accordion details.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the accordion details.
  static member inline children (value: float) = Interop.mkAttr "children" value


[<Erase>]
type accordionSummary =
  /// The content of the accordion summary.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the accordion summary.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the accordion summary.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the accordion summary.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the accordion summary.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the accordion summary.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The icon to display as the expand indicator.
  static member inline expandIcon (element: ReactElement) = Interop.mkAttr "expandIcon" element
  /// Props applied to the `IconButton` element wrapping the expand icon.
  static member inline IconButtonProps (props: IReactProperty list) = Interop.mkAttr "IconButtonProps" (createObj !!props)
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


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
  /// Override the default label for the *close popup* icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline closeText (value: string) = Interop.mkAttr "closeText" value
  /// Override the icon displayed before the children. Unless provided, the icon is mapped to the value of the `severity` prop.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The component maps the `severity` prop to a range of different icons, for instance success to ``. If you wish to change this mapping, you can provide your own. Alternatively, you can use the `icon` prop to override the icon displayed.
  static member inline iconMapping (?error: ReactElement, ?info: ReactElement, ?success: ReactElement, ?warning: ReactElement) = Interop.mkAttr "iconMapping" (let x = createEmpty<obj> in (if error.IsSome then x?``error`` <- error); (if info.IsSome then x?``info`` <- info); (if success.IsSome then x?``success`` <- success); (if warning.IsSome then x?``warning`` <- warning); x)
  /// Callback fired when the component requests to be closed. When provided and no `action` prop is set, a close icon button is displayed that triggers the callback when clicked.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// The ARIA role attribute of the element.
  static member inline role (value: string) = Interop.mkAttr "role" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// *Inherited from `paper`*
  ///
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value

module alert =

  /// The main color for the alert. Unless provided, the value is taken from the `severity` prop.
  [<Erase>]
  type color =
    static member inline error = Interop.mkAttr "color" "error"
    static member inline info = Interop.mkAttr "color" "info"
    static member inline success = Interop.mkAttr "color" "success"
    static member inline warning = Interop.mkAttr "color" "warning"

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
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// *Inherited from `paper`*
  ///
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value

module appBar =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline transparent = Interop.mkAttr "color" "transparent"

  /// The positioning type. The behavior of the different options is described [in the MDN web docs](https://developer.mozilla.org/en-US/docs/Learn/CSS/CSS_layout/Positioning). Note: `sticky` is not universally supported and will fall back to `static` when unavailable.
  [<Erase>]
  type position =
    static member inline absolute = Interop.mkAttr "position" "absolute"
    static member inline fixed' = Interop.mkAttr "position" "fixed"
    static member inline relative = Interop.mkAttr "position" "relative"
    static member inline static' = Interop.mkAttr "position" "static"
    static member inline sticky = Interop.mkAttr "position" "sticky"

  /// *Inherited from `paper`*
  ///
  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline elevation = Interop.mkAttr "variant" "elevation"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


[<Erase>]
type autocomplete =
  /// If `true`, the portion of the selected suggestion that has not been typed by the user, known as the completion string, appears inline after the input cursor in the textbox. The inline completion string is visually highlighted and has a selected state.
  static member inline autoComplete (value: bool) = Interop.mkAttr "autoComplete" value
  /// If `true`, the first option is automatically highlighted.
  static member inline autoHighlight (value: bool) = Interop.mkAttr "autoHighlight" value
  /// If `true`, the selected option becomes the value of the input when the Autocomplete loses focus unless the user chooses a different option or changes the character string in the input.
  static member inline autoSelect (value: bool) = Interop.mkAttr "autoSelect" value
  /// Control if the input should be blurred when an option is selected:
  ///
  /// - `false` the input is not blurred. - `true` the input is always blurred. - `touch` the input is blurred after a touch event. - `mouse` the input is blurred after a mouse event.
  static member inline blurOnSelect (value: bool) = Interop.mkAttr "blurOnSelect" value
  /// Props applied to the [`Chip`](https://material-ui.com/api/chip/) element.
  static member inline ChipProps (props: IReactProperty list) = Interop.mkAttr "ChipProps" (createObj !!props)
  /// If `true`, the input's text will be cleared on blur if no value is selected.
  ///
  /// Set to `true` if you want to help the user enter a new value. Set to `false` if you want to help the user resume his search.
  static member inline clearOnBlur (value: bool) = Interop.mkAttr "clearOnBlur" value
  /// If `true`, clear all values when the user presses escape and the popup is closed.
  static member inline clearOnEscape (value: bool) = Interop.mkAttr "clearOnEscape" value
  /// Override the default text for the *clear* icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline clearText (value: string) = Interop.mkAttr "clearText" value
  /// The icon to display in place of the default close icon.
  static member inline closeIcon (element: ReactElement) = Interop.mkAttr "closeIcon" element
  /// Override the default text for the *close popup* icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline closeText (value: string) = Interop.mkAttr "closeText" value
  /// If `true`, the popup will ignore the blur event if the input is filled. You can inspect the popup markup with your browser tools. Consider this option when you need to customize the component.
  static member inline debug (value: bool) = Interop.mkAttr "debug" value
  /// The default input value. Use when the component is not controlled.
  static member inline defaultValue (value: 'option []) = Interop.mkAttr "defaultValue" (ResizeArray value)
  /// The default input value. Use when the component is not controlled.
  static member inline defaultValue (value: 'option option) = Interop.mkAttr "defaultValue" value
  /// If `true`, the input can't be cleared.
  static member inline disableClearable (value: bool) = Interop.mkAttr "disableClearable" value
  /// If `true`, the popup won't close when a value is selected.
  static member inline disableCloseOnSelect (value: bool) = Interop.mkAttr "disableCloseOnSelect" value
  /// If `true`, the input will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, will allow focus on disabled items.
  static member inline disabledItemsFocusable (value: bool) = Interop.mkAttr "disabledItemsFocusable" value
  /// If `true`, the list box in the popup will not wrap focus.
  static member inline disableListWrap (value: bool) = Interop.mkAttr "disableListWrap" value
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  /// A filter function that determines the options that are eligible.
  ///
  /// **Signature:**
  ///
  /// `function(options: T[], state: object) => undefined`
  ///
  /// *options:* The options to render.
  ///
  /// *state:* The state of the component.
  static member inline filterOptions (filterOptions: 'option [] -> string -> 'option []) = Interop.mkAttr "filterOptions" (Func<_,_,_> (fun opts (s: AutocompleteFilterOptionsState) -> ResizeArray (filterOptions opts s.inputValue)))
  /// A filter function that determines the options that are eligible.
  ///
  /// **Signature:**
  ///
  /// `function(options: T[], state: object) => undefined`
  ///
  /// *options:* The options to render.
  ///
  /// *state:* The state of the component.
  static member inline filterOptions (filterOptions: 'option [] -> AutocompleteFilterOptionsState -> 'option []) = Interop.mkAttr "filterOptions" (Func<_,_,_> filterOptions)
  /// If `true`, hide the selected options from the list box.
  static member inline filterSelectedOptions (value: bool) = Interop.mkAttr "filterSelectedOptions" value
  /// Force the visibility display of the popup icon.
  static member inline forcePopupIcon (value: bool) = Interop.mkAttr "forcePopupIcon" value
  /// If `true`, the Autocomplete is free solo, meaning that the user input is not bound to provided options.
  static member inline freeSolo (value: bool) = Interop.mkAttr "freeSolo" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// The label to display when the tags are truncated (`limitTags`).
  ///
  /// **Signature:**
  ///
  /// `function(more: number) => ReactNode`
  ///
  /// *more:* The number of truncated tags.
  static member inline getLimitTagsText (getText: int -> ReactElement) = Interop.mkAttr "getLimitTagsText" getText
  /// Used to determine the disabled state for a given option.
  ///
  /// **Signature:**
  ///
  /// `function(option: T) => boolean`
  ///
  /// *option:* The option to test.
  static member inline getOptionDisabled (isDisabled: 'option -> bool) = Interop.mkAttr "getOptionDisabled" isDisabled
  /// Used to determine the string value for a given option. It's used to fill the input (and the list box options if `renderOption` is not provided).
  ///
  /// **Signature:**
  ///
  /// `function(option: T) => string`
  static member inline getOptionLabel (getLabel: 'option -> string) = Interop.mkAttr "getOptionLabel" getLabel
  /// Used to determine if an option is selected, considering the current value. Uses strict equality by default.
  ///
  /// **Signature:**
  ///
  /// `function(option: T, value: T) => boolean`
  ///
  /// *option:* The option to test.
  ///
  /// *value:* The value to test against.
  static member inline getOptionSelected (getSelected: 'option -> 'a -> bool) = Interop.mkAttr "getOptionSelected" (Func<_,_,_> getSelected)
  /// If provided, the options will be grouped under the returned string. The groupBy value is also used as the text for group headings when `renderGroup` is not provided.
  ///
  /// **Signature:**
  ///
  /// `function(options: T) => string`
  ///
  /// *options:* The options to group.
  static member inline groupBy (getGroup: 'option -> string) = Interop.mkAttr "groupBy" getGroup
  /// If `true`, the component handles the "Home" and "End" keys when the popup is open. It should move focus to the first option and last option, respectively.
  static member inline handleHomeEndKeys (value: bool) = Interop.mkAttr "handleHomeEndKeys" value
  /// This prop is used to help implement the accessibility logic. If you don't provide this prop. It falls back to a randomly generated id.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// If `true`, the highlight can move to the input.
  static member inline includeInputInList (value: bool) = Interop.mkAttr "includeInputInList" value
  /// The input value.
  static member inline inputValue (value: string) = Interop.mkAttr "inputValue" value
  /// The maximum number of tags that will be visible when not focused. Set `-1` to disable the limit.
  static member inline limitTags (value: int) = Interop.mkAttr "limitTags" value
  /// The component used to render the listbox.
  static member inline ListboxComponent (value: ReactElementType) = Interop.mkAttr "ListboxComponent" value
  /// Props applied to the Listbox element.
  static member inline ListboxProps (props: IReactProperty list) = Interop.mkAttr "ListboxProps" (createObj !!props)
  /// If `true`, the component is in a loading state.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline loadingText (value: ReactElement) = Interop.mkAttr "loadingText" value
  /// Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline loadingText (values: ReactElement seq) = Interop.mkAttr "loadingText" values
  /// Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline loadingText (value: string) = Interop.mkAttr "loadingText" value
  /// Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline loadingText (values: string seq) = Interop.mkAttr "loadingText" values
  /// Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline loadingText (value: int) = Interop.mkAttr "loadingText" value
  /// Text to display when in a loading state.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline loadingText (value: float) = Interop.mkAttr "loadingText" value
  /// If `true`, `value` must be an array and the menu will support multiple selections.
  static member inline multiple (value: bool) = Interop.mkAttr "multiple" value
  /// Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline noOptionsText (value: ReactElement) = Interop.mkAttr "noOptionsText" value
  /// Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline noOptionsText (values: ReactElement seq) = Interop.mkAttr "noOptionsText" values
  /// Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline noOptionsText (value: string) = Interop.mkAttr "noOptionsText" value
  /// Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline noOptionsText (values: string seq) = Interop.mkAttr "noOptionsText" values
  /// Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline noOptionsText (value: int) = Interop.mkAttr "noOptionsText" value
  /// Text to display when there are no options.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline noOptionsText (value: float) = Interop.mkAttr "noOptionsText" value
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: T | T[], reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the component.
  ///
  /// *reason:* One of "create-option", "select-option", "remove-option", "blur" or "clear".
  static member inline onChange (handler: Event -> 'option [] -> AutocompleteOnChangeReason -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: T | T[], reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the component.
  ///
  /// *reason:* One of "create-option", "select-option", "remove-option", "blur" or "clear".
  static member inline onChange (handler: 'option [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> (fun _ v _ -> handler v))
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: T | T[], reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the component.
  ///
  /// *reason:* One of "create-option", "select-option", "remove-option", "blur" or "clear".
  static member inline onChange (handler: Event -> 'option option -> AutocompleteOnChangeReason -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: T | T[], reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the component.
  ///
  /// *reason:* One of "create-option", "select-option", "remove-option", "blur" or "clear".
  static member inline onChange (handler: 'option option -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> (fun _ v _ -> handler v))
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggleInput"`, `"escape"`, `"select-option"`, `"blur"`.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback fired when the highlight option changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, option: T, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *option:* The highlighted option.
  ///
  /// *reason:* Can be: `"keyboard"`, `"auto"`, `"mouse"`.
  static member inline onHighlightChange (handler: Event -> 'option -> AutocompleteHighlightChangeReason -> unit) = Interop.mkAttr "onHighlightChange" (Func<_,_,_,_> handler)
  /// Callback fired when the highlight option changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, option: T, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *option:* The highlighted option.
  ///
  /// *reason:* Can be: `"keyboard"`, `"auto"`, `"mouse"`.
  static member inline onHighlightChange (handler: 'option -> AutocompleteHighlightChangeReason -> unit) = Interop.mkAttr "onHighlightChange" (Func<_,_,_,_> (fun _ o r -> handler o r))
  /// Callback fired when the highlight option changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, option: T, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *option:* The highlighted option.
  ///
  /// *reason:* Can be: `"keyboard"`, `"auto"`, `"mouse"`.
  static member inline onHighlightChange (handler: 'option -> unit) = Interop.mkAttr "onHighlightChange" (Func<_,_,_,_> (fun _ o _ -> handler o))
  /// Callback fired when the input value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: string, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the text input.
  ///
  /// *reason:* Can be: `"input"` (user input), `"reset"` (programmatic change), `"clear"`.
  static member inline onInputChange (handler: Event -> string -> AutocompleteInputChangeReason -> unit) = Interop.mkAttr "onInputChange" (Func<_,_,_,_> handler)
  /// Callback fired when the input value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: string, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value of the text input.
  ///
  /// *reason:* Can be: `"input"` (user input), `"reset"` (programmatic change), `"clear"`.
  static member inline onInputChange (handler: string -> unit) = Interop.mkAttr "onInputChange" (Func<_,_,_,_> (fun _ v _ -> handler v))
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Control the popup` open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// If `true`, the popup will open on input focus.
  static member inline openOnFocus (value: bool) = Interop.mkAttr "openOnFocus" value
  /// Override the default text for the *open popup* icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline openText (value: string) = Interop.mkAttr "openText" value
  /// Array of options.
  static member inline options (options: 'option []) = Interop.mkAttr "options" (ResizeArray options)
  /// The component used to render the body of the popup.
  static member inline PaperComponent (value: ReactElementType) = Interop.mkAttr "PaperComponent" value
  /// The component used to position the popup.
  static member inline PopperComponent (value: ReactElementType) = Interop.mkAttr "PopperComponent" value
  /// The icon to display in place of the default popup icon.
  static member inline popupIcon (element: ReactElement) = Interop.mkAttr "popupIcon" element
  /// Render the group.
  ///
  /// **Signature:**
  ///
  /// `function(option: any) => ReactNode`
  ///
  /// *option:* The group to render.
  static member inline renderGroup (render: AutocompleteRenderGroupParams -> ReactElement) = Interop.mkAttr "renderGroup" render
  /// Render the input.
  ///
  /// **Signature:**
  ///
  /// `function(params: object) => ReactNode`
  static member inline renderInput (render: AutocompleteRenderInputParams -> ReactElement) = Interop.mkAttr "renderInput" render
  /// Render the option, use `getOptionLabel` by default.
  ///
  /// **Signature:**
  ///
  /// `function(option: T, state: object) => ReactNode`
  ///
  /// *option:* The option to render.
  ///
  /// *state:* The state of the component.
  static member inline renderOption (render: 'option -> AutocompleteRenderOptionState -> ReactElement) = Interop.mkAttr "renderOption" (Func<_,_,_> render)
  /// Render the selected value.
  ///
  /// **Signature:**
  ///
  /// `function(value: T[], getTagProps: function) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  ///
  /// *getTagProps:* A tag props getter.
  static member inline renderTags (render: 'option [] -> AutocompleteRenderValueState -> ReactElement) = Interop.mkAttr "renderTags" (Func<_,_,_> render)
  /// If `true`, the input's text will be selected on focus. It helps the user clear the selected value.
  static member inline selectOnFocus (value: bool) = Interop.mkAttr "selectOnFocus" value
  /// The value of the autocomplete.
  ///
  /// The value must have reference equality with the option in order to be selected. You can customize the equality behavior with the `getOptionSelected` prop.
  static member inline value (value: 'option []) = Interop.mkAttr "value" (ResizeArray value)
  /// The value of the autocomplete.
  ///
  /// The value must have reference equality with the option in order to be selected. You can customize the equality behavior with the `getOptionSelected` prop.
  static member inline value (value: 'option option) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module autocompleteExtensions =

  type autocomplete with
    /// The default input value. Use when the component is not controlled.
    static member inline defaultValue (value: 'option) = Interop.mkAttr "defaultValue" value
    /// Callback fired when the value changes.
    ///
    /// **Signature:**
    ///
    /// `function(event: object, value: T | T[], reason: string) => void`
    ///
    /// *event:* The event source of the callback.
    ///
    /// *value:* The new value of the component.
    ///
    /// *reason:* One of "create-option", "select-option", "remove-option", "blur" or "clear".
    static member inline onChange (handler: Event -> 'option -> AutocompleteOnChangeReason -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> handler)
    /// Callback fired when the value changes.
    ///
    /// **Signature:**
    ///
    /// `function(event: object, value: T | T[], reason: string) => void`
    ///
    /// *event:* The event source of the callback.
    ///
    /// *value:* The new value of the component.
    ///
    /// *reason:* One of "create-option", "select-option", "remove-option", "blur" or "clear".
    static member inline onChange (handler: 'option -> unit) = Interop.mkAttr "onChange" (Func<_,_,_,_> (fun _ v _ -> handler v))
    /// The value of the autocomplete.
    ///
    /// The value must have reference equality with the option in order to be selected. You can customize the equality behavior with the `getOptionSelected` prop.
    static member inline value (value: 'option) = Interop.mkAttr "value" value

module autocomplete =

  /// Control if the input should be blurred when an option is selected:
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

  /// The size of the autocomplete.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"


[<Erase>]
type avatar =
  /// Used in combination with `src` or `srcSet` to provide an alt attribute for the rendered `img` element.
  static member inline alt (value: string) = Interop.mkAttr "alt" value
  /// Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (element: ReactElement) = prop.children element
  /// Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Used to render icon or text elements inside the Avatar if `src` is not set. This can be an element, or just a string.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Attributes applied to the `img` element if the component is used to display an image. It can be used to listen for the loading error event.
  static member inline imgProps (props: IReactProperty list) = Interop.mkAttr "imgProps" (createObj !!props)
  /// The `sizes` attribute for the `img` element.
  static member inline sizes (value: string) = Interop.mkAttr "sizes" value
  /// The `src` attribute for the `img` element.
  static member inline src (value: string) = Interop.mkAttr "src" value
  /// The `srcSet` attribute for the `img` element. Use this attribute for responsive image display.
  static member inline srcSet (value: string) = Interop.mkAttr "srcSet" value

module avatar =

  /// The shape of the avatar.
  [<Erase>]
  type variant =
    static member inline circle = Interop.mkAttr "variant" "circle"
    static member inline rounded = Interop.mkAttr "variant" "rounded"
    static member inline square = Interop.mkAttr "variant" "square"


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

module avatarGroup =

  /// Spacing between avatars.
  [<Erase>]
  type spacing =
    static member inline medium = Interop.mkAttr "spacing" "medium"
    static member inline small = Interop.mkAttr "spacing" "small"


[<Erase>]
type backdrop =
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
  /// If `true`, the backdrop is invisible. It can be used when rendering a popover or a custom select component.
  static member inline invisible (value: bool) = Interop.mkAttr "invisible" value
  /// If `true`, the backdrop is open.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  /// *Inherited from `fade`*
  ///
  /// Enable this prop if you encounter 'Function components cannot be given refs', use `unstable_createStrictModeTheme`, and can't forward the ref in the child component.
  static member inline disableStrictModeCompat (value: bool) = Interop.mkAttr "disableStrictModeCompat" value
  /// *Inherited from `fade`*
  ///
  /// If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  /// *Inherited from `fade`*
  ///
  /// The duration for the transition, in milliseconds.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// *Inherited from `fade`*
  ///
  /// The duration for the transition, in milliseconds.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)


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
  /// If `true`, the badge will be invisible.
  static member inline invisible (value: bool) = Interop.mkAttr "invisible" value
  /// Max count to show.
  static member inline max (value: int) = Interop.mkAttr "max" value
  /// Controls whether the badge is hidden when `badgeContent` is zero.
  static member inline showZero (value: bool) = Interop.mkAttr "showZero" value

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
    static member inline error = Interop.mkAttr "color" "error"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// Wrapped shape the badge should overlap.
  [<Erase>]
  type overlap =
    static member inline circle = Interop.mkAttr "overlap" "circle"
    static member inline rectangle = Interop.mkAttr "overlap" "rectangle"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline dot = Interop.mkAttr "variant" "dot"
    static member inline standard = Interop.mkAttr "variant" "standard"


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
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* We default to the index of the child.
  static member inline onChange (handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* We default to the index of the child.
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// If `true`, all `BottomNavigationAction`s will show their labels. By default, only the selected `BottomNavigationAction` will show its label.
  static member inline showLabels (value: bool) = Interop.mkAttr "showLabels" value
  /// The value of the currently selected `BottomNavigationAction`.
  static member inline value (value: 'a) = Interop.mkAttr "value" value


[<Erase>]
type bottomNavigationAction =
  /// This prop isn't supported. Use the `component` prop if you need to change the children structure.
  static member inline children  = UnsupportedProp ()
  /// The icon element.
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
  /// If `true`, the `BottomNavigationAction` will show its label. By default, only the selected `BottomNavigationAction` inside `BottomNavigation` will show its label.
  static member inline showLabel (value: bool) = Interop.mkAttr "showLabel" value
  /// You can provide your own value. Otherwise, we fallback to the child position index.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


[<Erase>]
type breadcrumbs =
  /// The breadcrumb children.
  static member inline children (element: ReactElement) = prop.children element
  /// The breadcrumb children.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The breadcrumb children.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The breadcrumb children.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The breadcrumb children.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The breadcrumb children.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Override the default label for the expand button.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline expandText (value: string) = Interop.mkAttr "expandText" value
  /// If max items is exceeded, the number of items to show after the ellipsis.
  static member inline itemsAfterCollapse (value: int) = Interop.mkAttr "itemsAfterCollapse" value
  /// If max items is exceeded, the number of items to show before the ellipsis.
  static member inline itemsBeforeCollapse (value: int) = Interop.mkAttr "itemsBeforeCollapse" value
  /// Specifies the maximum number of breadcrumbs to display. When there are more than the maximum number, only the first `itemsBeforeCollapse` and last `itemsAfterCollapse` will be shown, with an ellipsis in between.
  static member inline maxItems (value: int) = Interop.mkAttr "maxItems" value
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


[<Erase>]
type button =
  /// The content of the button.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the button.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the button.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the button.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, no elevation is used.
  static member inline disableElevation (value: bool) = Interop.mkAttr "disableElevation" value
  /// If `true`, the keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// Element placed after the children.
  static member inline endIcon (element: ReactElement) = Interop.mkAttr "endIcon" element
  /// If `true`, the button will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// The URL to link to when the button is clicked. If defined, an `a` element will be used as the root node.
  static member inline href (value: string) = Interop.mkAttr "href" value
  /// Element placed before the children.
  static member inline startIcon (element: ReactElement) = Interop.mkAttr "startIcon" element
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)

module button =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the button. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline large = Interop.mkAttr "size" "large"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline contained = Interop.mkAttr "variant" "contained"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline text = Interop.mkAttr "variant" "text"


[<Erase>]
type buttonBase =
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
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
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the base button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


[<Erase>]
type buttonGroup =
  /// The content of the button group.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the button group.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the button group.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the button group.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the button group.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the button group.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the buttons will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, no elevation is used.
  static member inline disableElevation (value: bool) = Interop.mkAttr "disableElevation" value
  /// If `true`, the button keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the button ripple effect will be disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// If `true`, the buttons will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value

module buttonGroup =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The group orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The size of the button. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline large = Interop.mkAttr "size" "large"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline contained = Interop.mkAttr "variant" "contained"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline text = Interop.mkAttr "variant" "text"


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
  /// If `true`, the card will use raised styling.
  static member inline raised (value: bool) = Interop.mkAttr "raised" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// *Inherited from `paper`*
  ///
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value

module card =

  /// *Inherited from `paper`*
  ///
  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline elevation = Interop.mkAttr "variant" "elevation"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


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
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


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
  /// If `true`, the actions do not have additional margin.
  static member inline disableSpacing (value: bool) = Interop.mkAttr "disableSpacing" value


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
  /// The Avatar for the Card Header.
  static member inline avatar (value: ReactElement) = Interop.mkAttr "avatar" value
  /// The Avatar for the Card Header.
  static member inline avatar (values: ReactElement seq) = Interop.mkAttr "avatar" values
  /// The Avatar for the Card Header.
  static member inline avatar (value: string) = Interop.mkAttr "avatar" value
  /// The Avatar for the Card Header.
  static member inline avatar (values: string seq) = Interop.mkAttr "avatar" values
  /// The Avatar for the Card Header.
  static member inline avatar (value: int) = Interop.mkAttr "avatar" value
  /// The Avatar for the Card Header.
  static member inline avatar (value: float) = Interop.mkAttr "avatar" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, `subheader` and `title` won't be wrapped by a Typography component. This can be useful to render an alternative Typography variant by wrapping the `title` text, and optional `subheader` text with the Typography component.
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
  /// These props will be forwarded to the subheader (as long as disableTypography is not `true`).
  static member inline subheaderTypographyProps (props: IReactProperty list) = Interop.mkAttr "subheaderTypographyProps" (createObj !!props)
  /// The content of the Card Title.
  static member inline title (value: ReactElement) = Interop.mkAttr "title" value
  /// The content of the Card Title.
  static member inline title (values: ReactElement seq) = Interop.mkAttr "title" values
  /// The content of the Card Title.
  static member inline title (value: string) = Interop.mkAttr "title" value
  /// The content of the Card Title.
  static member inline title (values: string seq) = Interop.mkAttr "title" values
  /// The content of the Card Title.
  static member inline title (value: int) = Interop.mkAttr "title" value
  /// The content of the Card Title.
  static member inline title (value: float) = Interop.mkAttr "title" value
  /// These props will be forwarded to the title (as long as disableTypography is not `true`).
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
  /// Image to be displayed as a background image. Either `image` or `src` prop must be specified. Note that caller must specify height otherwise the image will not be visible.
  static member inline image (value: string) = Interop.mkAttr "image" value
  /// An alias for `image` property. Available only with media components. Media components: `video`, `audio`, `picture`, `iframe`, `img`.
  static member inline src (value: string) = Interop.mkAttr "src" value


[<Erase>]
type checkbox =
  /// If `true`, the component is checked.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon (element: ReactElement) = Interop.mkAttr "checkedIcon" element
  /// If `true`, the checkbox will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// If `true`, the component appears indeterminate. This does not set the native input element to indeterminate due to inconsistent behavior across browsers. However, we set a `data-indeterminate` attribute on the input.
  static member inline indeterminate (value: bool) = Interop.mkAttr "indeterminate" value
  /// The icon to display when the component is indeterminate.
  static member inline indeterminateIcon (element: ReactElement) = Interop.mkAttr "indeterminateIcon" element
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// The value of the component. The browser uses "on" as the default value.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `iconButton`*
  ///
  /// If `true`, the keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)

module checkbox =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the checkbox. `small` is equivalent to the dense checkbox styling.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// *Inherited from `iconButton`*
  ///
  /// If given, uses a negative margin to counteract the padding on one side (this is often helpful for aligning the left or right side of the icon with content above or below, without ruining the border size and shape).
  [<Erase>]
  type edge =
    static member inline start = Interop.mkAttr "edge" "start"
    static member inline end' = Interop.mkAttr "edge" "end"
    static member inline false' = Interop.mkAttr "edge" false


[<Erase>]
type chip =
  /// Avatar element.
  static member inline avatar (value: ReactElement) = Interop.mkAttr "avatar" value
  /// This prop isn't supported. Use the `component` prop if you need to change the children structure.
  static member inline children  = UnsupportedProp ()
  /// If `true`, the chip will appear clickable, and will raise when pressed, even if the onClick prop is not defined. If false, the chip will not be clickable, even if onClick prop is defined. This can be used, for example, along with the component prop to indicate an anchor Chip is clickable.
  static member inline clickable (value: bool) = Interop.mkAttr "clickable" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Override the default delete icon element. Shown only if `onDelete` is set.
  static member inline deleteIcon (value: ReactElement) = Interop.mkAttr "deleteIcon" value
  /// If `true`, the chip should be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Icon element.
  static member inline icon (value: ReactElement) = Interop.mkAttr "icon" value
  /// The content of the label.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// The content of the label.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// The content of the label.
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// The content of the label.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// The content of the label.
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// The content of the label.
  static member inline label (value: float) = Interop.mkAttr "label" value
  /// Callback function fired when the delete icon is clicked. If set, the delete icon will be shown.
  static member inline onDelete (handler: Event -> unit) = Interop.mkAttr "onDelete" handler

module chip =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the chip.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline default' = Interop.mkAttr "variant" "default"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


[<Erase>]
type circularProgress =
  /// If `true`, the shrink animation is disabled. This only works if variant is `indeterminate`.
  static member inline disableShrink (value: bool) = Interop.mkAttr "disableShrink" value
  /// The size of the circle. If using a number, the pixel unit is assumed. If using a string, you need to provide the CSS unit, e.g '3rem'.
  static member inline size (value: int) = Interop.mkAttr "size" value
  /// The size of the circle. If using a number, the pixel unit is assumed. If using a string, you need to provide the CSS unit, e.g '3rem'.
  static member inline size (value: Styles.ICssUnit) = Interop.mkAttr "size" value
  /// The thickness of the circle.
  static member inline thickness (value: int) = Interop.mkAttr "thickness" value
  /// The value of the progress indicator for the determinate and static variants. Value between 0 and 100.
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

  /// The variant to use. Use indeterminate when there is no progress value.
  [<Erase>]
  type variant =
    static member inline determinate = Interop.mkAttr "variant" "determinate"
    static member inline indeterminate = Interop.mkAttr "variant" "indeterminate"
    static member inline static' = Interop.mkAttr "variant" "static"


[<Erase>]
type clickAwayListener =
  /// The wrapped element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// If `true`, the React tree is ignored and only the DOM tree is considered. This prop changes how portaled elements are handled.
  static member inline disableReactTree (value: bool) = Interop.mkAttr "disableReactTree" value
  /// Callback fired when a "click away" event is detected.
  static member inline onClickAway (handler: Event -> unit) = Interop.mkAttr "onClickAway" handler

module clickAwayListener =

  /// The mouse event to listen to. You can disable the listener by providing `false`.
  [<Erase>]
  type mouseEvent =
    static member inline onClick = Interop.mkAttr "mouseEvent" "onClick"
    static member inline onMouseDown = Interop.mkAttr "mouseEvent" "onMouseDown"
    static member inline onMouseUp = Interop.mkAttr "mouseEvent" "onMouseUp"
    static member inline false' = Interop.mkAttr "mouseEvent" false

  /// The touch event to listen to. You can disable the listener by providing `false`.
  [<Erase>]
  type touchEvent =
    static member inline onTouchEnd = Interop.mkAttr "touchEvent" "onTouchEnd"
    static member inline onTouchStart = Interop.mkAttr "touchEvent" "onTouchStart"
    static member inline false' = Interop.mkAttr "touchEvent" false


[<Erase>]
type collapse =
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
  /// The height of the container when collapsed.
  static member inline collapsedHeight (value: int) = Interop.mkAttr "collapsedHeight" value
  /// The height of the container when collapsed.
  static member inline collapsedHeight (value: Styles.ICssUnit) = Interop.mkAttr "collapsedHeight" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Enable this prop if you encounter 'Function components cannot be given refs', use `unstable_createStrictModeTheme`, and can't forward the ref in the passed `Component`.
  static member inline disableStrictModeCompat (value: bool) = Interop.mkAttr "disableStrictModeCompat" value
  /// If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)

module collapse =

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
  /// If `true`, the left and right padding is removed.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  /// Set the max-width to match the min-width of the current breakpoint. This is useful if you'd prefer to design for a fixed set of sizes instead of trying to accommodate a fully fluid viewport. It's fluid by default.
  static member inline fixed' (value: bool) = Interop.mkAttr "fixed" value

module container =

  /// Determine the max-width of the container. The container width grows with the size of the screen. Set to `false` to disable `maxWidth`.
  [<Erase>]
  type maxWidth =
    static member inline lg = Interop.mkAttr "maxWidth" "lg"
    static member inline md = Interop.mkAttr "maxWidth" "md"
    static member inline sm = Interop.mkAttr "maxWidth" "sm"
    static member inline xl = Interop.mkAttr "maxWidth" "xl"
    static member inline xs = Interop.mkAttr "maxWidth" "xs"
    static member inline false' = Interop.mkAttr "maxWidth" false


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


[<Erase>]
type dialog =
  /// The id(s) of the element(s) that describe the dialog.
  static member inline ariaDescribedby (value: string) = Interop.mkAttr "aria-describedby" value
  /// The id(s) of the element(s) that label the dialog.
  static member inline ariaLabelledby (value: string) = Interop.mkAttr "aria-labelledby" value
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
  /// If `true`, clicking the backdrop will not fire the `onClose` callback.
  static member inline disableBackdropClick (value: bool) = Interop.mkAttr "disableBackdropClick" value
  /// If `true`, hitting escape will not fire the `onClose` callback.
  static member inline disableEscapeKeyDown (value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  /// If `true`, the dialog will be full-screen
  static member inline fullScreen (value: bool) = Interop.mkAttr "fullScreen" value
  /// If `true`, the dialog stretches to `maxWidth`.
  ///
  /// Notice that the dialog width grow is limited by the default margin.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick (handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: Event -> DialogCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: DialogCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired before the dialog enters.
  static member inline onEnter (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEnter" handler
  /// Callback fired when the dialog has entered.
  static member inline onEntered (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntered" handler
  /// Callback fired when the dialog is entering.
  static member inline onEntering (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntering" handler
  /// Callback fired when the escape key is pressed, `disableKeyboard` is false and the modal is in focus.
  static member inline onEscapeKeyDown (handler: Event -> unit) = Interop.mkAttr "onEscapeKeyDown" handler
  /// Callback fired before the dialog exits.
  static member inline onExit (handler: ReactElement -> unit) = Interop.mkAttr "onExit" handler
  /// Callback fired when the dialog has exited.
  static member inline onExited (handler: ReactElement -> unit) = Interop.mkAttr "onExited" handler
  /// Callback fired when the dialog is exiting.
  static member inline onExiting (handler: ReactElement -> unit) = Interop.mkAttr "onExiting" handler
  /// If `true`, the Dialog is open.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The component used to render the body of the dialog.
  static member inline PaperComponent (value: ReactElementType) = Interop.mkAttr "PaperComponent" value
  /// Props applied to the [`Paper`](https://material-ui.com/api/paper/) element.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)
  /// *Inherited from `modal`*
  ///
  /// A backdrop component. This prop enables custom backdrop rendering.
  static member inline BackdropComponent (value: ReactElementType) = Interop.mkAttr "BackdropComponent" value
  /// *Inherited from `modal`*
  ///
  /// Props applied to the [`Backdrop`](https://material-ui.com/api/backdrop/) element.
  static member inline BackdropProps (props: IReactProperty list) = Interop.mkAttr "BackdropProps" (createObj !!props)
  /// *Inherited from `modal`*
  ///
  /// When set to true the Modal waits until a nested Transition is completed before closing.
  static member inline closeAfterTransition (value: bool) = Interop.mkAttr "closeAfterTransition" value
  /// *Inherited from `modal`*
  ///
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: Element option) = Interop.mkAttr "container" element
  /// *Inherited from `modal`*
  ///
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: ReactElement option) = Interop.mkAttr "container" element
  /// *Inherited from `modal`*
  ///
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// *Inherited from `modal`*
  ///
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any modal children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus (value: bool) = Interop.mkAttr "disableAutoFocus" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not prevent focus from leaving the modal while open.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus (value: bool) = Interop.mkAttr "disableEnforceFocus" value
  /// *Inherited from `modal`*
  ///
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not restore focus to previously focused element once modal is hidden.
  static member inline disableRestoreFocus (value: bool) = Interop.mkAttr "disableRestoreFocus" value
  /// *Inherited from `modal`*
  ///
  /// Disable the scroll lock behavior.
  static member inline disableScrollLock (value: bool) = Interop.mkAttr "disableScrollLock" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the backdrop is not rendered.
  static member inline hideBackdrop (value: bool) = Interop.mkAttr "hideBackdrop" value
  /// *Inherited from `modal`*
  ///
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Modal.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value

module dialog =

  /// Determine the max-width of the dialog. The dialog width grows with the size of the screen. Set to `false` to disable `maxWidth`.
  [<Erase>]
  type maxWidth =
    static member inline lg = Interop.mkAttr "maxWidth" "lg"
    static member inline md = Interop.mkAttr "maxWidth" "md"
    static member inline sm = Interop.mkAttr "maxWidth" "sm"
    static member inline xl = Interop.mkAttr "maxWidth" "xl"
    static member inline xs = Interop.mkAttr "maxWidth" "xs"
    static member inline false' = Interop.mkAttr "maxWidth" false

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
  /// If `true`, the actions do not have additional margin.
  static member inline disableSpacing (value: bool) = Interop.mkAttr "disableSpacing" value


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
  /// *Inherited from `typography`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component. Overrides the behavior of the `variantMapping` prop.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `typography`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component. Overrides the behavior of the `variantMapping` prop.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `typography`*
  ///
  /// If `true`, the text will have a bottom margin.
  static member inline gutterBottom (value: bool) = Interop.mkAttr "gutterBottom" value
  /// *Inherited from `typography`*
  ///
  /// If `true`, the text will not wrap, but instead will truncate with a text overflow ellipsis.
  ///
  /// Note that text overflow can only happen with block or inline-block level elements (the element needs to have a width in order to overflow).
  static member inline noWrap (value: bool) = Interop.mkAttr "noWrap" value
  /// *Inherited from `typography`*
  ///
  /// If `true`, the text will have a bottom margin.
  static member inline paragraph (value: bool) = Interop.mkAttr "paragraph" value
  /// *Inherited from `typography`*
  ///
  /// The component maps the variant prop to a range of different HTML element types. For instance, subtitle1 to ``. If you wish to change that mapping, you can provide your own. Alternatively, you can use the `component` prop.
  static member inline variantMapping (?h1: string, ?h2: string, ?h3: string, ?h4: string, ?h5: string, ?h6: string, ?subtitle1: string, ?subtitle2: string, ?body1: string, ?body2: string) = Interop.mkAttr "variantMapping" (let x = createEmpty<obj> in (if h1.IsSome then x?``h1`` <- h1); (if h2.IsSome then x?``h2`` <- h2); (if h3.IsSome then x?``h3`` <- h3); (if h4.IsSome then x?``h4`` <- h4); (if h5.IsSome then x?``h5`` <- h5); (if h6.IsSome then x?``h6`` <- h6); (if subtitle1.IsSome then x?``subtitle1`` <- subtitle1); (if subtitle2.IsSome then x?``subtitle2`` <- subtitle2); (if body1.IsSome then x?``body1`` <- body1); (if body2.IsSome then x?``body2`` <- body2); x)

module dialogContentText =

  /// *Inherited from `typography`*
  ///
  /// Set the text-align on the component.
  [<Erase>]
  type align =
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline center = Interop.mkAttr "align" "center"
    static member inline right = Interop.mkAttr "align" "right"
    static member inline justify = Interop.mkAttr "align" "justify"

  /// *Inherited from `typography`*
  ///
  /// The color of the component.
  [<Erase>]
  type color =
    static member inline initial = Interop.mkAttr "color" "initial"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline textPrimary = Interop.mkAttr "color" "textPrimary"
    static member inline textSecondary = Interop.mkAttr "color" "textSecondary"
    static member inline error = Interop.mkAttr "color" "error"

  /// *Inherited from `typography`*
  ///
  /// Controls the display type
  [<Erase>]
  type display =
    static member inline initial = Interop.mkAttr "display" "initial"
    static member inline block = Interop.mkAttr "display" "block"
    static member inline inline' = Interop.mkAttr "display" "inline"

  /// *Inherited from `typography`*
  ///
  /// Applies the theme typography styles.
  [<Erase>]
  type variant =
    static member inline h1 = Interop.mkAttr "variant" "h1"
    static member inline h2 = Interop.mkAttr "variant" "h2"
    static member inline h3 = Interop.mkAttr "variant" "h3"
    static member inline h4 = Interop.mkAttr "variant" "h4"
    static member inline h5 = Interop.mkAttr "variant" "h5"
    static member inline h6 = Interop.mkAttr "variant" "h6"
    static member inline subtitle1 = Interop.mkAttr "variant" "subtitle1"
    static member inline subtitle2 = Interop.mkAttr "variant" "subtitle2"
    static member inline body1 = Interop.mkAttr "variant" "body1"
    static member inline body2 = Interop.mkAttr "variant" "body2"
    static member inline caption = Interop.mkAttr "variant" "caption"
    static member inline button = Interop.mkAttr "variant" "button"
    static member inline overline = Interop.mkAttr "variant" "overline"
    static member inline srOnly = Interop.mkAttr "variant" "srOnly"
    static member inline inherit' = Interop.mkAttr "variant" "inherit"


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
  /// If `true`, the children won't be wrapped by a typography component. For instance, this can be useful to render an h4 instead of the default h2.
  static member inline disableTypography (value: bool) = Interop.mkAttr "disableTypography" value


[<Erase>]
type divider =
  /// Absolutely position the element.
  static member inline absolute (value: bool) = Interop.mkAttr "absolute" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, a vertical divider will have the correct height when used in flex container. (By default, a vertical divider will have a calculated height of `0px` if it is the child of a flex container.)
  static member inline flexItem (value: bool) = Interop.mkAttr "flexItem" value
  /// If `true`, the divider will have a lighter color.
  static member inline light (value: bool) = Interop.mkAttr "light" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module divider =

  /// The divider orientation.
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline fullWidth = Interop.mkAttr "variant" "fullWidth"
    static member inline inset = Interop.mkAttr "variant" "inset"
    static member inline middle = Interop.mkAttr "variant" "middle"


[<Erase>]
type drawer =
  /// The contents of the drawer.
  static member inline children (element: ReactElement) = prop.children element
  /// The contents of the drawer.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The contents of the drawer.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The contents of the drawer.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The contents of the drawer.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The contents of the drawer.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The elevation of the drawer.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// Props applied to the [`Modal`](https://material-ui.com/api/modal/) element.
  static member inline ModalProps (props: IReactProperty list) = Interop.mkAttr "ModalProps" (createObj !!props)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// If `true`, the drawer is open.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props applied to the [`Paper`](https://material-ui.com/api/paper/) element.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Props applied to the [`Slide`](https://material-ui.com/api/slide/) element.
  static member inline SlideProps (props: IReactProperty list) = Interop.mkAttr "SlideProps" (createObj !!props)
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
type expansionPanel =
  /// The content of the expansion panel.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the expansion panel.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the expansion panel.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the expansion panel.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the expansion panel.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the expansion panel.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, expands the panel by default.
  static member inline defaultExpanded (value: bool) = Interop.mkAttr "defaultExpanded" value
  /// If `true`, the panel will be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, expands the panel, otherwise collapse it. Setting this prop enables control over the panel.
  static member inline expanded (value: bool) = Interop.mkAttr "expanded" value
  /// Callback fired when the expand/collapse state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, expanded: boolean) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *expanded:* The `expanded` state of the panel.
  static member inline onChange (handler: Event -> bool -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback fired when the expand/collapse state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, expanded: boolean) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *expanded:* The `expanded` state of the panel.
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value
  /// The component used for the collapse effect. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value

module expansionPanel =

  /// *Inherited from `paper`*
  ///
  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline elevation = Interop.mkAttr "variant" "elevation"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


[<Erase>]
type expansionPanelActions =
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
  /// If `true`, the actions do not have additional margin.
  static member inline disableSpacing (value: bool) = Interop.mkAttr "disableSpacing" value


[<Erase>]
type expansionPanelDetails =
  /// The content of the expansion panel details.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the expansion panel details.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the expansion panel details.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the expansion panel details.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the expansion panel details.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the expansion panel details.
  static member inline children (value: float) = Interop.mkAttr "children" value


[<Erase>]
type expansionPanelSummary =
  /// The content of the expansion panel summary.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the expansion panel summary.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the expansion panel summary.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the expansion panel summary.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the expansion panel summary.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the expansion panel summary.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The icon to display as the expand indicator.
  static member inline expandIcon (element: ReactElement) = Interop.mkAttr "expandIcon" element
  /// Props applied to the `IconButton` element wrapping the expand icon.
  static member inline IconButtonProps (props: IReactProperty list) = Interop.mkAttr "IconButtonProps" (createObj !!props)
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


[<Erase>]
type fab =
  /// The content of the button.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the button.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the button.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the button.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The URL to link to when the button is clicked. If defined, an `a` element will be used as the root node.
  static member inline href (value: string) = Interop.mkAttr "href" value
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)

module fab =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the button. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline large = Interop.mkAttr "size" "large"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline extended = Interop.mkAttr "variant" "extended"
    static member inline round = Interop.mkAttr "variant" "round"


[<Erase>]
type fade =
  /// A single child content element.
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Enable this prop if you encounter 'Function components cannot be given refs', use `unstable_createStrictModeTheme`, and can't forward the ref in the child component.
  static member inline disableStrictModeCompat (value: bool) = Interop.mkAttr "disableStrictModeCompat" value
  /// If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)


[<Erase>]
type filledInput =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the input will not have an underline.
  static member inline disableUnderline (value: bool) = Interop.mkAttr "disableUnderline" value
  /// End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: string) = Interop.mkAttr "inputComponent" value
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// If `true`, a textarea element will be rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax (value: int) = Interop.mkAttr "rowsMax" value
  /// Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `inputBase`*
  ///
  /// Callback fired when the input is blurred.
  ///
  /// Notice that the first argument (event) might be undefined.
  static member inline onBlur (handler: Event option -> unit) = Interop.mkAttr "onBlur" handler
  /// *Inherited from `inputBase`*
  ///
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline rowsMin (value: int) = Interop.mkAttr "rowsMin" value

module filledInput =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type formControl =
  /// The contents of the form control.
  static member inline children (element: ReactElement) = prop.children element
  /// The contents of the form control.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the label, input and helper text should be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the label should be displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// If `true`, the component will be displayed in focused state.
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  /// If `true`, the component will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// If `true`, the label will be hidden. This is used to increase density for a `FilledInput`. Be sure to add `aria-label` to the `input` element.
  static member inline hiddenLabel (value: bool) = Interop.mkAttr "hiddenLabel" value
  /// If `true`, the label will indicate that the input is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value

module formControl =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If `dense` or `normal`, will adjust vertical spacing of this and contained components.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"
    static member inline normal = Interop.mkAttr "margin" "normal"

  /// The size of the text field.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type formControlLabel =
  /// If `true`, the component appears selected.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// A control element. For instance, it can be be a `Radio`, a `Switch` or a `Checkbox`.
  static member inline control (value: ReactElement) = Interop.mkAttr "control" value
  /// If `true`, the control will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// The text to be used in an enclosing label element.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// The text to be used in an enclosing label element.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// The text to be used in an enclosing label element.
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// The text to be used in an enclosing label element.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// The text to be used in an enclosing label element.
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// The text to be used in an enclosing label element.
  static member inline label (value: float) = Interop.mkAttr "label" value
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
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


[<Erase>]
type formHelperText =
  /// The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  ///
  /// If `' '` is provided, the component reserves one line height for displaying a future message.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the helper text should be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, helper text should be displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// If `true`, the helper text should use filled classes key.
  static member inline filled (value: bool) = Interop.mkAttr "filled" value
  /// If `true`, the helper text should use focused classes key.
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  /// If `true`, the helper text should use required classes key.
  static member inline required (value: bool) = Interop.mkAttr "required" value

module formHelperText =

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
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
  /// If `true`, the label should be displayed in a disabled state.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the label should be displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// If `true`, the label should use filled classes key.
  static member inline filled (value: bool) = Interop.mkAttr "filled" value
  /// If `true`, the input of this label is focused (used by `FormGroup` components).
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  /// If `true`, the label will indicate that the input is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value

module formLabel =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"


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
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the component will have the flex *container* behavior. You should be wrapping *items* with a *container*.
  static member inline container (value: bool) = Interop.mkAttr "container" value
  /// If `true`, the component will have the flex *item* behavior. You should be wrapping *items* with a *container*.
  static member inline item (value: bool) = Interop.mkAttr "item" value
  /// If `true`, it sets `min-width: 0` on the item. Refer to the limitations section of the documentation to better understand the use case.
  static member inline zeroMinWidth (value: bool) = Interop.mkAttr "zeroMinWidth" value

module grid =

  /// Defines the `align-content` style property. It's applied for all screen sizes.
  [<Erase>]
  type alignContent =
    static member inline stretch = Interop.mkAttr "alignContent" "stretch"
    static member inline center = Interop.mkAttr "alignContent" "center"
    static member inline flexStart = Interop.mkAttr "alignContent" "flex-start"
    static member inline flexEnd = Interop.mkAttr "alignContent" "flex-end"
    static member inline spaceBetween = Interop.mkAttr "alignContent" "space-between"
    static member inline spaceAround = Interop.mkAttr "alignContent" "space-around"

  /// Defines the `align-items` style property. It's applied for all screen sizes.
  [<Erase>]
  type alignItems =
    static member inline flexStart = Interop.mkAttr "alignItems" "flex-start"
    static member inline center = Interop.mkAttr "alignItems" "center"
    static member inline flexEnd = Interop.mkAttr "alignItems" "flex-end"
    static member inline stretch = Interop.mkAttr "alignItems" "stretch"
    static member inline baseline = Interop.mkAttr "alignItems" "baseline"

  /// Defines the `flex-direction` style property. It is applied for all screen sizes.
  [<Erase>]
  type direction =
    static member inline row = Interop.mkAttr "direction" "row"
    static member inline rowReverse = Interop.mkAttr "direction" "row-reverse"
    static member inline column = Interop.mkAttr "direction" "column"
    static member inline columnReverse = Interop.mkAttr "direction" "column-reverse"

  /// Defines the `justify-content` style property. It is applied for all screen sizes.
  [<Erase>]
  type justify =
    static member inline flexStart = Interop.mkAttr "justify" "flex-start"
    static member inline center = Interop.mkAttr "justify" "center"
    static member inline flexEnd = Interop.mkAttr "justify" "flex-end"
    static member inline spaceBetween = Interop.mkAttr "justify" "space-between"
    static member inline spaceAround = Interop.mkAttr "justify" "space-around"
    static member inline spaceEvenly = Interop.mkAttr "justify" "space-evenly"

  /// Defines the number of grids the component is going to use. It's applied for the `lg` breakpoint and wider screens if not overridden.
  [<Erase>]
  type lg =
    static member inline false' = Interop.mkAttr "lg" false
    static member inline auto = Interop.mkAttr "lg" "auto"
    static member inline true' = Interop.mkAttr "lg" true
    static member inline _1 = Interop.mkAttr "lg" 1
    static member inline _2 = Interop.mkAttr "lg" 2
    static member inline _3 = Interop.mkAttr "lg" 3
    static member inline _4 = Interop.mkAttr "lg" 4
    static member inline _5 = Interop.mkAttr "lg" 5
    static member inline _6 = Interop.mkAttr "lg" 6
    static member inline _7 = Interop.mkAttr "lg" 7
    static member inline _8 = Interop.mkAttr "lg" 8
    static member inline _9 = Interop.mkAttr "lg" 9
    static member inline _10 = Interop.mkAttr "lg" 10
    static member inline _11 = Interop.mkAttr "lg" 11
    static member inline _12 = Interop.mkAttr "lg" 12

  /// Defines the number of grids the component is going to use. It's applied for the `md` breakpoint and wider screens if not overridden.
  [<Erase>]
  type md =
    static member inline false' = Interop.mkAttr "md" false
    static member inline auto = Interop.mkAttr "md" "auto"
    static member inline true' = Interop.mkAttr "md" true
    static member inline _1 = Interop.mkAttr "md" 1
    static member inline _2 = Interop.mkAttr "md" 2
    static member inline _3 = Interop.mkAttr "md" 3
    static member inline _4 = Interop.mkAttr "md" 4
    static member inline _5 = Interop.mkAttr "md" 5
    static member inline _6 = Interop.mkAttr "md" 6
    static member inline _7 = Interop.mkAttr "md" 7
    static member inline _8 = Interop.mkAttr "md" 8
    static member inline _9 = Interop.mkAttr "md" 9
    static member inline _10 = Interop.mkAttr "md" 10
    static member inline _11 = Interop.mkAttr "md" 11
    static member inline _12 = Interop.mkAttr "md" 12

  /// Defines the number of grids the component is going to use. It's applied for the `sm` breakpoint and wider screens if not overridden.
  [<Erase>]
  type sm =
    static member inline false' = Interop.mkAttr "sm" false
    static member inline auto = Interop.mkAttr "sm" "auto"
    static member inline true' = Interop.mkAttr "sm" true
    static member inline _1 = Interop.mkAttr "sm" 1
    static member inline _2 = Interop.mkAttr "sm" 2
    static member inline _3 = Interop.mkAttr "sm" 3
    static member inline _4 = Interop.mkAttr "sm" 4
    static member inline _5 = Interop.mkAttr "sm" 5
    static member inline _6 = Interop.mkAttr "sm" 6
    static member inline _7 = Interop.mkAttr "sm" 7
    static member inline _8 = Interop.mkAttr "sm" 8
    static member inline _9 = Interop.mkAttr "sm" 9
    static member inline _10 = Interop.mkAttr "sm" 10
    static member inline _11 = Interop.mkAttr "sm" 11
    static member inline _12 = Interop.mkAttr "sm" 12

  /// Defines the space between the type `item` component. It can only be used on a type `container` component.
  [<Erase>]
  type spacing =
    static member inline _0 = Interop.mkAttr "spacing" 0
    static member inline _1 = Interop.mkAttr "spacing" 1
    static member inline _2 = Interop.mkAttr "spacing" 2
    static member inline _3 = Interop.mkAttr "spacing" 3
    static member inline _4 = Interop.mkAttr "spacing" 4
    static member inline _5 = Interop.mkAttr "spacing" 5
    static member inline _6 = Interop.mkAttr "spacing" 6
    static member inline _7 = Interop.mkAttr "spacing" 7
    static member inline _8 = Interop.mkAttr "spacing" 8
    static member inline _9 = Interop.mkAttr "spacing" 9
    static member inline _10 = Interop.mkAttr "spacing" 10

  /// Defines the `flex-wrap` style property. It's applied for all screen sizes.
  [<Erase>]
  type wrap =
    static member inline nowrap = Interop.mkAttr "wrap" "nowrap"
    static member inline wrap = Interop.mkAttr "wrap" "wrap"
    static member inline wrapReverse = Interop.mkAttr "wrap" "wrap-reverse"

  /// Defines the number of grids the component is going to use. It's applied for the `xl` breakpoint and wider screens.
  [<Erase>]
  type xl =
    static member inline false' = Interop.mkAttr "xl" false
    static member inline auto = Interop.mkAttr "xl" "auto"
    static member inline true' = Interop.mkAttr "xl" true
    static member inline _1 = Interop.mkAttr "xl" 1
    static member inline _2 = Interop.mkAttr "xl" 2
    static member inline _3 = Interop.mkAttr "xl" 3
    static member inline _4 = Interop.mkAttr "xl" 4
    static member inline _5 = Interop.mkAttr "xl" 5
    static member inline _6 = Interop.mkAttr "xl" 6
    static member inline _7 = Interop.mkAttr "xl" 7
    static member inline _8 = Interop.mkAttr "xl" 8
    static member inline _9 = Interop.mkAttr "xl" 9
    static member inline _10 = Interop.mkAttr "xl" 10
    static member inline _11 = Interop.mkAttr "xl" 11
    static member inline _12 = Interop.mkAttr "xl" 12

  /// Defines the number of grids the component is going to use. It's applied for all the screen sizes with the lowest priority.
  [<Erase>]
  type xs =
    static member inline false' = Interop.mkAttr "xs" false
    static member inline auto = Interop.mkAttr "xs" "auto"
    static member inline true' = Interop.mkAttr "xs" true
    static member inline _1 = Interop.mkAttr "xs" 1
    static member inline _2 = Interop.mkAttr "xs" 2
    static member inline _3 = Interop.mkAttr "xs" 3
    static member inline _4 = Interop.mkAttr "xs" 4
    static member inline _5 = Interop.mkAttr "xs" 5
    static member inline _6 = Interop.mkAttr "xs" 6
    static member inline _7 = Interop.mkAttr "xs" 7
    static member inline _8 = Interop.mkAttr "xs" 8
    static member inline _9 = Interop.mkAttr "xs" 9
    static member inline _10 = Interop.mkAttr "xs" 10
    static member inline _11 = Interop.mkAttr "xs" 11
    static member inline _12 = Interop.mkAttr "xs" 12


[<Erase>]
type gridList =
  /// Number of px for one cell height. You can set `'auto'` if you want to let the children determine the height.
  static member inline cellHeight (value: int) = Interop.mkAttr "cellHeight" value
  /// Grid Tiles that will be in Grid List.
  static member inline children (element: ReactElement) = prop.children element
  /// Grid Tiles that will be in Grid List.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Grid Tiles that will be in Grid List.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Grid Tiles that will be in Grid List.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Grid Tiles that will be in Grid List.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Grid Tiles that will be in Grid List.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Number of columns.
  static member inline cols (value: int) = Interop.mkAttr "cols" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Number of px for the spacing between tiles.
  static member inline spacing (value: int) = Interop.mkAttr "spacing" value

module gridList =

  /// Number of px for one cell height. You can set `'auto'` if you want to let the children determine the height.
  [<Erase>]
  type cellHeight =
    static member inline auto = Interop.mkAttr "cellHeight" "auto"


[<Erase>]
type gridListTile =
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children (element: ReactElement) = prop.children element
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Width of the tile in number of grid cells.
  static member inline cols (value: int) = Interop.mkAttr "cols" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Height of the tile in number of grid cells.
  static member inline rows (value: int) = Interop.mkAttr "rows" value


[<Erase>]
type gridListTileBar =
  /// An IconButton element to be used as secondary action target (primary action target is the tile itself).
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
  /// Title to be displayed on tile.
  static member inline title (value: ReactElement) = Interop.mkAttr "title" value
  /// Title to be displayed on tile.
  static member inline title (values: ReactElement seq) = Interop.mkAttr "title" values
  /// Title to be displayed on tile.
  static member inline title (value: string) = Interop.mkAttr "title" value
  /// Title to be displayed on tile.
  static member inline title (values: string seq) = Interop.mkAttr "title" values
  /// Title to be displayed on tile.
  static member inline title (value: int) = Interop.mkAttr "title" value
  /// Title to be displayed on tile.
  static member inline title (value: float) = Interop.mkAttr "title" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module gridListTileBar =

  /// Position of secondary action IconButton.
  [<Erase>]
  type actionPosition =
    static member inline left = Interop.mkAttr "actionPosition" "left"
    static member inline right = Interop.mkAttr "actionPosition" "right"

  /// Position of the title bar.
  [<Erase>]
  type titlePosition =
    static member inline bottom = Interop.mkAttr "titlePosition" "bottom"
    static member inline top = Interop.mkAttr "titlePosition" "top"


[<Erase>]
type grow =
  /// A single child content element.
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Enable this prop if you encounter 'Function components cannot be given refs', use `unstable_createStrictModeTheme`, and can't forward the ref in the child component.
  static member inline disableStrictModeCompat (value: bool) = Interop.mkAttr "disableStrictModeCompat" value
  /// If `true`, show the component; triggers the enter or exit animation.
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
  /// If `true`, screens this size and down will be hidden.
  static member inline lgDown (value: bool) = Interop.mkAttr "lgDown" value
  /// If `true`, screens this size and up will be hidden.
  static member inline lgUp (value: bool) = Interop.mkAttr "lgUp" value
  /// If `true`, screens this size and down will be hidden.
  static member inline mdDown (value: bool) = Interop.mkAttr "mdDown" value
  /// If `true`, screens this size and up will be hidden.
  static member inline mdUp (value: bool) = Interop.mkAttr "mdUp" value
  /// Hide the given breakpoint(s).
  static member inline only ([<ParamArray>] values: BreakpointKey []) = Interop.mkAttr "only" values
  /// If `true`, screens this size and down will be hidden.
  static member inline smDown (value: bool) = Interop.mkAttr "smDown" value
  /// If `true`, screens this size and up will be hidden.
  static member inline smUp (value: bool) = Interop.mkAttr "smUp" value
  /// If `true`, screens this size and down will be hidden.
  static member inline xlDown (value: bool) = Interop.mkAttr "xlDown" value
  /// If `true`, screens this size and up will be hidden.
  static member inline xlUp (value: bool) = Interop.mkAttr "xlUp" value
  /// If `true`, screens this size and down will be hidden.
  static member inline xsDown (value: bool) = Interop.mkAttr "xsDown" value
  /// If `true`, screens this size and up will be hidden.
  static member inline xsUp (value: bool) = Interop.mkAttr "xsUp" value

module hidden =

  /// Specify which implementation to use. 'js' is the default, 'css' works better for server-side rendering.
  [<Erase>]
  type implementation =
    static member inline js = Interop.mkAttr "implementation" "js"
    static member inline css = Interop.mkAttr "implementation" "css"

  /// You can use this prop when choosing the `js` implementation with server-side rendering.
  ///
  /// As `window.innerWidth` is unavailable on the server, we default to rendering an empty component during the first mount. You might want to use an heuristic to approximate the screen width of the client browser screen width.
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

module icon =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline action = Interop.mkAttr "color" "action"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline disabled = Interop.mkAttr "color" "disabled"

  /// The fontSize applied to the icon. Defaults to 24px, but can be configure to inherit font size.
  [<Erase>]
  type fontSize =
    static member inline inherit' = Interop.mkAttr "fontSize" "inherit"
    static member inline default' = Interop.mkAttr "fontSize" "default"
    static member inline small = Interop.mkAttr "fontSize" "small"
    static member inline large = Interop.mkAttr "fontSize" "large"


[<Erase>]
type iconButton =
  /// The icon element.
  static member inline children (element: ReactElement) = prop.children element
  /// The icon element.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The icon element.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The icon element.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The icon element.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The icon element.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, the button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)

module iconButton =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If given, uses a negative margin to counteract the padding on one side (this is often helpful for aligning the left or right side of the icon with content above or below, without ruining the border size and shape).
  [<Erase>]
  type edge =
    static member inline start = Interop.mkAttr "edge" "start"
    static member inline end' = Interop.mkAttr "edge" "end"
    static member inline false' = Interop.mkAttr "edge" false

  /// The size of the button. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"


[<Erase>]
type input =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the input will not have an underline.
  static member inline disableUnderline (value: bool) = Interop.mkAttr "disableUnderline" value
  /// End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: string) = Interop.mkAttr "inputComponent" value
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// If `true`, a textarea element will be rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax (value: int) = Interop.mkAttr "rowsMax" value
  /// Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `inputBase`*
  ///
  /// Callback fired when the input is blurred.
  ///
  /// Notice that the first argument (event) might be undefined.
  static member inline onBlur (handler: Event option -> unit) = Interop.mkAttr "onBlur" handler
  /// *Inherited from `inputBase`*
  ///
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline rowsMin (value: int) = Interop.mkAttr "rowsMin" value

module input =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type inputAdornment =
  /// The content of the component, normally an `IconButton` or string.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component, normally an `IconButton` or string.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally an `IconButton` or string.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally an `IconButton` or string.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally an `IconButton` or string.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally an `IconButton` or string.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Disable pointer events on the root. This allows for the content of the adornment to focus the input on click.
  static member inline disablePointerEvents (value: bool) = Interop.mkAttr "disablePointerEvents" value
  /// If children is a string then disable wrapping in a Typography component.
  static member inline disableTypography (value: bool) = Interop.mkAttr "disableTypography" value

module inputAdornment =

  /// The position this adornment should appear relative to the `Input`.
  [<Erase>]
  type position =
    static member inline start = Interop.mkAttr "position" "start"
    static member inline end' = Interop.mkAttr "position" "end"

  /// The variant to use. Note: If you are using the `TextField` component or the `FormControl` component you do not have to set this manually.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline filled = Interop.mkAttr "variant" "filled"


[<Erase>]
type inputBase =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: string) = Interop.mkAttr "inputComponent" value
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// If `true`, a textarea element will be rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// Callback fired when the input is blurred.
  ///
  /// Notice that the first argument (event) might be undefined.
  static member inline onBlur (handler: Event option -> unit) = Interop.mkAttr "onBlur" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax (value: int) = Interop.mkAttr "rowsMax" value
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline rowsMin (value: int) = Interop.mkAttr "rowsMin" value
  /// Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module inputBase =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type inputLabel =
  /// The contents of the `InputLabel`.
  static member inline children (element: ReactElement) = prop.children element
  /// The contents of the `InputLabel`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The contents of the `InputLabel`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The contents of the `InputLabel`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The contents of the `InputLabel`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The contents of the `InputLabel`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, the transition animation is disabled.
  static member inline disableAnimation (value: bool) = Interop.mkAttr "disableAnimation" value
  /// If `true`, apply disabled class.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the label will be displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input of this label is focused.
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  /// if `true`, the label will indicate that the input is required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// If `true`, the label is shrunk.
  static member inline shrink (value: bool) = Interop.mkAttr "shrink" value
  /// *Inherited from `formLabel`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `formLabel`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `formLabel`*
  ///
  /// If `true`, the label should use filled classes key.
  static member inline filled (value: bool) = Interop.mkAttr "filled" value

module inputLabel =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
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
type linearProgress =
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
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The variant to use. Use indeterminate or query when there is no progress value.
  [<Erase>]
  type variant =
    static member inline buffer = Interop.mkAttr "variant" "buffer"
    static member inline determinate = Interop.mkAttr "variant" "determinate"
    static member inline indeterminate = Interop.mkAttr "variant" "indeterminate"
    static member inline query = Interop.mkAttr "variant" "query"


[<Erase>]
type link =
  /// The content of the link.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the link.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the link.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the link.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the link.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the link.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Applies the theme typography styles.
  static member inline variant (value: string) = Interop.mkAttr "variant" value
  /// *Inherited from `typography`*
  ///
  /// If `true`, the text will have a bottom margin.
  static member inline gutterBottom (value: bool) = Interop.mkAttr "gutterBottom" value
  /// *Inherited from `typography`*
  ///
  /// If `true`, the text will not wrap, but instead will truncate with a text overflow ellipsis.
  ///
  /// Note that text overflow can only happen with block or inline-block level elements (the element needs to have a width in order to overflow).
  static member inline noWrap (value: bool) = Interop.mkAttr "noWrap" value
  /// *Inherited from `typography`*
  ///
  /// If `true`, the text will have a bottom margin.
  static member inline paragraph (value: bool) = Interop.mkAttr "paragraph" value
  /// *Inherited from `typography`*
  ///
  /// The component maps the variant prop to a range of different HTML element types. For instance, subtitle1 to ``. If you wish to change that mapping, you can provide your own. Alternatively, you can use the `component` prop.
  static member inline variantMapping (?h1: string, ?h2: string, ?h3: string, ?h4: string, ?h5: string, ?h6: string, ?subtitle1: string, ?subtitle2: string, ?body1: string, ?body2: string) = Interop.mkAttr "variantMapping" (let x = createEmpty<obj> in (if h1.IsSome then x?``h1`` <- h1); (if h2.IsSome then x?``h2`` <- h2); (if h3.IsSome then x?``h3`` <- h3); (if h4.IsSome then x?``h4`` <- h4); (if h5.IsSome then x?``h5`` <- h5); (if h6.IsSome then x?``h6`` <- h6); (if subtitle1.IsSome then x?``subtitle1`` <- subtitle1); (if subtitle2.IsSome then x?``subtitle2`` <- subtitle2); (if body1.IsSome then x?``body1`` <- body1); (if body2.IsSome then x?``body2`` <- body2); x)

module link =

  /// The color of the link.
  [<Erase>]
  type color =
    static member inline initial = Interop.mkAttr "color" "initial"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline textPrimary = Interop.mkAttr "color" "textPrimary"
    static member inline textSecondary = Interop.mkAttr "color" "textSecondary"
    static member inline error = Interop.mkAttr "color" "error"

  /// Controls when the link should have an underline.
  [<Erase>]
  type underline =
    static member inline none = Interop.mkAttr "underline" "none"
    static member inline hover = Interop.mkAttr "underline" "hover"
    static member inline always = Interop.mkAttr "underline" "always"

  /// *Inherited from `typography`*
  ///
  /// Set the text-align on the component.
  [<Erase>]
  type align =
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline center = Interop.mkAttr "align" "center"
    static member inline right = Interop.mkAttr "align" "right"
    static member inline justify = Interop.mkAttr "align" "justify"

  /// *Inherited from `typography`*
  ///
  /// Controls the display type
  [<Erase>]
  type display =
    static member inline initial = Interop.mkAttr "display" "initial"
    static member inline block = Interop.mkAttr "display" "block"
    static member inline inline' = Interop.mkAttr "display" "inline"


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
  /// If `true`, compact vertical padding designed for keyboard and mouse input will be used for the list and list items. The prop is available to descendant components as the `dense` context.
  static member inline dense (value: bool) = Interop.mkAttr "dense" value
  /// If `true`, vertical padding will be removed from the list.
  static member inline disablePadding (value: bool) = Interop.mkAttr "disablePadding" value
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: ReactElement) = Interop.mkAttr "subheader" value
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (values: ReactElement seq) = Interop.mkAttr "subheader" values
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: string) = Interop.mkAttr "subheader" value
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (values: string seq) = Interop.mkAttr "subheader" values
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: int) = Interop.mkAttr "subheader" value
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: float) = Interop.mkAttr "subheader" value


[<Erase>]
type listItem =
  /// If `true`, the list item will be focused during the first mount. Focus will also be triggered if the value changes from false to true.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// If `true`, the list item will be a button (using `ButtonBase`). Props intended for `ButtonBase` can then be applied to `ListItem`.
  static member inline button (value: bool) = Interop.mkAttr "button" value
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component. By default, it's a `li` when `button` is `false` and a `div` when `button` is `true`.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component. By default, it's a `li` when `button` is `false` and a `div` when `button` is `true`.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The container component used when a `ListItemSecondaryAction` is the last child.
  static member inline ContainerComponent (value: ReactElementType) = Interop.mkAttr "ContainerComponent" value
  /// Props applied to the container component if used.
  static member inline ContainerProps (props: IReactProperty list) = Interop.mkAttr "ContainerProps" (createObj !!props)
  /// If `true`, compact vertical padding designed for keyboard and mouse input will be used.
  static member inline dense (value: bool) = Interop.mkAttr "dense" value
  /// If `true`, the list item will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the left and right padding is removed.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  /// If `true`, a 1px light border is added to the bottom of the list item.
  static member inline divider (value: bool) = Interop.mkAttr "divider" value
  /// Use to apply selected styling.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value

module listItem =

  /// Defines the `align-items` style property.
  [<Erase>]
  type alignItems =
    static member inline flexStart = Interop.mkAttr "alignItems" "flex-start"
    static member inline center = Interop.mkAttr "alignItems" "center"


[<Erase>]
type listItemAvatar =
  /// The content of the component – normally `Avatar`.
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value


[<Erase>]
type listItemIcon =
  /// The content of the component, normally `Icon`, `SvgIcon`, or a `@material-ui/icons` SVG icon element.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component, normally `Icon`, `SvgIcon`, or a `@material-ui/icons` SVG icon element.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally `Icon`, `SvgIcon`, or a `@material-ui/icons` SVG icon element.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally `Icon`, `SvgIcon`, or a `@material-ui/icons` SVG icon element.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally `Icon`, `SvgIcon`, or a `@material-ui/icons` SVG icon element.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally `Icon`, `SvgIcon`, or a `@material-ui/icons` SVG icon element.
  static member inline children (value: float) = Interop.mkAttr "children" value


[<Erase>]
type listItemSecondaryAction =
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children (value: float) = Interop.mkAttr "children" value


[<Erase>]
type listItemText =
  /// Alias for the `primary` prop.
  static member inline children (element: ReactElement) = prop.children element
  /// Alias for the `primary` prop.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Alias for the `primary` prop.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Alias for the `primary` prop.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Alias for the `primary` prop.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Alias for the `primary` prop.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, the children won't be wrapped by a Typography component. This can be useful to render an alternative Typography variant by wrapping the `children` (or `primary`) text, and optional `secondary` text with the Typography component.
  static member inline disableTypography (value: bool) = Interop.mkAttr "disableTypography" value
  /// If `true`, the children will be indented. This should be used if there is no left avatar or left icon.
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
  /// These props will be forwarded to the primary typography component (as long as disableTypography is not `true`).
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
  /// These props will be forwarded to the secondary typography component (as long as disableTypography is not `true`).
  static member inline secondaryTypographyProps (props: IReactProperty list) = Interop.mkAttr "secondaryTypographyProps" (createObj !!props)


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
  /// If `true`, the List Subheader will not have gutters.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  /// If `true`, the List Subheader will not stick to the top during scroll.
  static member inline disableSticky (value: bool) = Interop.mkAttr "disableSticky" value
  /// If `true`, the List Subheader will be indented.
  static member inline inset (value: bool) = Interop.mkAttr "inset" value

module listSubheader =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline inherit' = Interop.mkAttr "color" "inherit"


[<Erase>]
type menu =
  /// A HTML element, or a function that returns it. It's used to set the position of the menu.
  static member inline anchorEl (value: Element option) = Interop.mkAttr "anchorEl" value
  /// A HTML element, or a function that returns it. It's used to set the position of the menu.
  static member inline anchorEl (getElement: unit -> Element option) = Interop.mkAttr "anchorEl" getElement
  /// A HTML element, or a function that returns it. It's used to set the position of the menu.
  static member inline anchorEl (ref: IRefValue<Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
  /// If `true` (Default) will focus the `[role="menu"]` if no focusable child is found. Disabled children are not focusable. If you set this prop to `false` focus will be placed on the parent modal container. This has severe accessibility implications and should only be considered if you manage focus otherwise.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// Menu contents, normally `MenuItem`s.
  static member inline children (element: ReactElement) = prop.children element
  /// Menu contents, normally `MenuItem`s.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Menu contents, normally `MenuItem`s.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Menu contents, normally `MenuItem`s.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Menu contents, normally `MenuItem`s.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Menu contents, normally `MenuItem`s.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// When opening the menu will not focus the active item but the `[role="menu"]` unless `autoFocus` is also set to `false`. Not using the default means not following WAI-ARIA authoring practices. Please be considerate about possible accessibility implications.
  static member inline disableAutoFocusItem (value: bool) = Interop.mkAttr "disableAutoFocusItem" value
  /// Props applied to the [`MenuList`](https://material-ui.com/api/menu-list/) element.
  static member inline MenuListProps (props: IReactProperty list) = Interop.mkAttr "MenuListProps" (createObj !!props)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`, `"tabKeyDown"`.
  static member inline onClose (handler: Event -> MenuCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`, `"tabKeyDown"`.
  static member inline onClose (handler: MenuCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired before the Menu enters.
  static member inline onEnter (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEnter" handler
  /// Callback fired when the Menu has entered.
  static member inline onEntered (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntered" handler
  /// Callback fired when the Menu is entering.
  static member inline onEntering (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntering" handler
  /// Callback fired before the Menu exits.
  static member inline onExit (handler: ReactElement -> unit) = Interop.mkAttr "onExit" handler
  /// Callback fired when the Menu has exited.
  static member inline onExited (handler: ReactElement -> unit) = Interop.mkAttr "onExited" handler
  /// Callback fired when the Menu is exiting.
  static member inline onExiting (handler: ReactElement -> unit) = Interop.mkAttr "onExiting" handler
  /// If `true`, the menu is visible.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The length of the transition in `ms`, or 'auto'
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The length of the transition in `ms`, or 'auto'
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  /// *Inherited from `popover`*
  ///
  /// A ref for imperative actions. It currently only supports updatePosition() action.
  static member inline action (ref: IRefValue<PopoverActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `popover`*
  ///
  /// A ref for imperative actions. It currently only supports updatePosition() action.
  static member inline action (handler: PopoverActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `popover`*
  ///
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: PopoverOriginHorizontal, vertical: PopoverOriginVertical) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// *Inherited from `popover`*
  ///
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: int, vertical: PopoverOriginVertical) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// *Inherited from `popover`*
  ///
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: PopoverOriginHorizontal, vertical: int) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// *Inherited from `popover`*
  ///
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: int, vertical: int) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// *Inherited from `popover`*
  ///
  /// This is the position that may be used to set the position of the popover. The coordinates are relative to the application's client area.
  static member inline anchorPosition (left: int, top: int) = Interop.mkAttr "anchorPosition" (let x = createEmpty<obj> in x?``left`` <- left; x?``top`` <- top; x)
  /// *Inherited from `popover`*
  ///
  /// A HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: Element option) = Interop.mkAttr "container" element
  /// *Inherited from `popover`*
  ///
  /// A HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: ReactElement option) = Interop.mkAttr "container" element
  /// *Inherited from `popover`*
  ///
  /// A HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// *Inherited from `popover`*
  ///
  /// A HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// *Inherited from `popover`*
  ///
  /// The elevation of the popover.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// *Inherited from `popover`*
  ///
  /// This function is called in order to retrieve the content anchor element. It's the opposite of the `anchorEl` prop. The content anchor element should be an element inside the popover. It's used to correctly scroll and set the position of the popover. The positioning strategy tries to make the content anchor element just above the anchor element.
  static member inline getContentAnchorEl (handler: Element option -> unit) = Interop.mkAttr "getContentAnchorEl" handler
  /// *Inherited from `popover`*
  ///
  /// Specifies how close to the edge of the window the popover can appear.
  static member inline marginThreshold (value: int) = Interop.mkAttr "marginThreshold" value
  /// *Inherited from `popover`*
  ///
  /// Props applied to the [`Paper`](https://material-ui.com/api/paper/) element.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// *Inherited from `popover`*
  ///
  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  static member inline transformOrigin (horizontal: PopoverOriginHorizontal, vertical: PopoverOriginVertical) = Interop.mkAttr "transformOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// *Inherited from `popover`*
  ///
  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  static member inline transformOrigin (horizontal: int, vertical: PopoverOriginVertical) = Interop.mkAttr "transformOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// *Inherited from `popover`*
  ///
  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  static member inline transformOrigin (horizontal: PopoverOriginHorizontal, vertical: int) = Interop.mkAttr "transformOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// *Inherited from `popover`*
  ///
  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  static member inline transformOrigin (horizontal: int, vertical: int) = Interop.mkAttr "transformOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// *Inherited from `popover`*
  ///
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// *Inherited from `popover`*
  ///
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)
  /// *Inherited from `modal`*
  ///
  /// A backdrop component. This prop enables custom backdrop rendering.
  static member inline BackdropComponent (value: ReactElementType) = Interop.mkAttr "BackdropComponent" value
  /// *Inherited from `modal`*
  ///
  /// Props applied to the [`Backdrop`](https://material-ui.com/api/backdrop/) element.
  static member inline BackdropProps (props: IReactProperty list) = Interop.mkAttr "BackdropProps" (createObj !!props)
  /// *Inherited from `modal`*
  ///
  /// When set to true the Modal waits until a nested Transition is completed before closing.
  static member inline closeAfterTransition (value: bool) = Interop.mkAttr "closeAfterTransition" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any modal children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus (value: bool) = Interop.mkAttr "disableAutoFocus" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, clicking the backdrop will not fire `onClose`.
  static member inline disableBackdropClick (value: bool) = Interop.mkAttr "disableBackdropClick" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not prevent focus from leaving the modal while open.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus (value: bool) = Interop.mkAttr "disableEnforceFocus" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, hitting escape will not fire `onClose`.
  static member inline disableEscapeKeyDown (value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  /// *Inherited from `modal`*
  ///
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not restore focus to previously focused element once modal is hidden.
  static member inline disableRestoreFocus (value: bool) = Interop.mkAttr "disableRestoreFocus" value
  /// *Inherited from `modal`*
  ///
  /// Disable the scroll lock behavior.
  static member inline disableScrollLock (value: bool) = Interop.mkAttr "disableScrollLock" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the backdrop is not rendered.
  static member inline hideBackdrop (value: bool) = Interop.mkAttr "hideBackdrop" value
  /// *Inherited from `modal`*
  ///
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Modal.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value
  /// *Inherited from `modal`*
  ///
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick (handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  /// *Inherited from `modal`*
  ///
  /// Callback fired when the escape key is pressed, `disableEscapeKeyDown` is false and the modal is in focus.
  static member inline onEscapeKeyDown (handler: Event -> unit) = Interop.mkAttr "onEscapeKeyDown" handler

module menu =

  /// The length of the transition in `ms`, or 'auto'
  [<Erase>]
  type transitionDuration =
    static member inline auto = Interop.mkAttr "transitionDuration" "auto"

  /// The variant to use. Use `menu` to prevent selected items from impacting the initial focus and the vertical alignment relative to the anchor element.
  [<Erase>]
  type variant =
    static member inline menu = Interop.mkAttr "variant" "menu"
    static member inline selectedMenu = Interop.mkAttr "variant" "selectedMenu"

  /// *Inherited from `popover`*
  ///
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
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

  /// *Inherited from `popover`*
  ///
  /// This determines which anchor prop to refer to to set the position of the popover.
  [<Erase>]
  type anchorReference =
    static member inline anchorEl = Interop.mkAttr "anchorReference" "anchorEl"
    static member inline anchorPosition = Interop.mkAttr "anchorReference" "anchorPosition"
    static member inline none = Interop.mkAttr "anchorReference" "none"

  /// *Inherited from `popover`*
  ///
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


[<Erase>]
type menuItem =
  /// Menu item contents.
  static member inline children (element: ReactElement) = prop.children element
  /// Menu item contents.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Menu item contents.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Menu item contents.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Menu item contents.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Menu item contents.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, compact vertical padding designed for keyboard and mouse input will be used.
  static member inline dense (value: bool) = Interop.mkAttr "dense" value
  /// If `true`, the left and right padding is removed.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value
  /// *Inherited from `listItem`*
  ///
  /// If `true`, the list item will be focused during the first mount. Focus will also be triggered if the value changes from false to true.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// *Inherited from `listItem`*
  ///
  /// If `true`, the list item will be a button (using `ButtonBase`). Props intended for `ButtonBase` can then be applied to `ListItem`.
  static member inline button (value: bool) = Interop.mkAttr "button" value
  /// *Inherited from `listItem`*
  ///
  /// The container component used when a `ListItemSecondaryAction` is the last child.
  static member inline ContainerComponent (value: ReactElementType) = Interop.mkAttr "ContainerComponent" value
  /// *Inherited from `listItem`*
  ///
  /// Props applied to the container component if used.
  static member inline ContainerProps (props: IReactProperty list) = Interop.mkAttr "ContainerProps" (createObj !!props)
  /// *Inherited from `listItem`*
  ///
  /// If `true`, the list item will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `listItem`*
  ///
  /// If `true`, a 1px light border is added to the bottom of the list item.
  static member inline divider (value: bool) = Interop.mkAttr "divider" value
  /// *Inherited from `listItem`*
  ///
  /// Use to apply selected styling.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value

module menuItem =

  /// *Inherited from `listItem`*
  ///
  /// Defines the `align-items` style property.
  [<Erase>]
  type alignItems =
    static member inline flexStart = Interop.mkAttr "alignItems" "flex-start"
    static member inline center = Interop.mkAttr "alignItems" "center"


[<Erase>]
type menuList =
  /// If `true`, will focus the `[role="menu"]` container and move into tab order.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// If `true`, will focus the first menuitem if `variant="menu"` or selected item if `variant="selectedMenu"`.
  static member inline autoFocusItem (value: bool) = Interop.mkAttr "autoFocusItem" value
  /// MenuList contents, normally `MenuItem`s.
  static member inline children (element: ReactElement) = prop.children element
  /// MenuList contents, normally `MenuItem`s.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// MenuList contents, normally `MenuItem`s.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// MenuList contents, normally `MenuItem`s.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// MenuList contents, normally `MenuItem`s.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// MenuList contents, normally `MenuItem`s.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, will allow focus on disabled items.
  static member inline disabledItemsFocusable (value: bool) = Interop.mkAttr "disabledItemsFocusable" value
  /// If `true`, the menu items will not wrap focus.
  static member inline disableListWrap (value: bool) = Interop.mkAttr "disableListWrap" value
  /// *Inherited from `list`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `list`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `list`*
  ///
  /// If `true`, compact vertical padding designed for keyboard and mouse input will be used for the list and list items. The prop is available to descendant components as the `dense` context.
  static member inline dense (value: bool) = Interop.mkAttr "dense" value
  /// *Inherited from `list`*
  ///
  /// If `true`, vertical padding will be removed from the list.
  static member inline disablePadding (value: bool) = Interop.mkAttr "disablePadding" value
  /// *Inherited from `list`*
  ///
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: ReactElement) = Interop.mkAttr "subheader" value
  /// *Inherited from `list`*
  ///
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (values: ReactElement seq) = Interop.mkAttr "subheader" values
  /// *Inherited from `list`*
  ///
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: string) = Interop.mkAttr "subheader" value
  /// *Inherited from `list`*
  ///
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (values: string seq) = Interop.mkAttr "subheader" values
  /// *Inherited from `list`*
  ///
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: int) = Interop.mkAttr "subheader" value
  /// *Inherited from `list`*
  ///
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader (value: float) = Interop.mkAttr "subheader" value

module menuList =

  /// The variant to use. Use `menu` to prevent selected items from impacting the initial focus and the vertical alignment relative to the anchor element.
  [<Erase>]
  type variant =
    static member inline menu = Interop.mkAttr "variant" "menu"
    static member inline selectedMenu = Interop.mkAttr "variant" "selectedMenu"


[<Erase>]
type mobileStepper =
  /// Set the active step (zero based index). Defines which dot is highlighted when the variant is 'dots'.
  static member inline activeStep (value: int) = Interop.mkAttr "activeStep" value
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (value: ReactElement) = Interop.mkAttr "backButton" value
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (values: ReactElement seq) = Interop.mkAttr "backButton" values
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (value: string) = Interop.mkAttr "backButton" value
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (values: string seq) = Interop.mkAttr "backButton" values
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (value: int) = Interop.mkAttr "backButton" value
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton (value: float) = Interop.mkAttr "backButton" value
  /// Props applied to the `LinearProgress` element.
  static member inline LinearProgressProps (props: IReactProperty list) = Interop.mkAttr "LinearProgressProps" (createObj !!props)
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (value: ReactElement) = Interop.mkAttr "nextButton" value
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (values: ReactElement seq) = Interop.mkAttr "nextButton" values
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (value: string) = Interop.mkAttr "nextButton" value
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (values: string seq) = Interop.mkAttr "nextButton" values
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (value: int) = Interop.mkAttr "nextButton" value
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton (value: float) = Interop.mkAttr "nextButton" value
  /// The total steps.
  static member inline steps (value: int) = Interop.mkAttr "steps" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// *Inherited from `paper`*
  ///
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value

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
type modal =
  /// A backdrop component. This prop enables custom backdrop rendering.
  static member inline BackdropComponent (value: ReactElementType) = Interop.mkAttr "BackdropComponent" value
  /// Props applied to the [`Backdrop`](https://material-ui.com/api/backdrop/) element.
  static member inline BackdropProps (props: IReactProperty list) = Interop.mkAttr "BackdropProps" (createObj !!props)
  /// A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// When set to true the Modal waits until a nested Transition is completed before closing.
  static member inline closeAfterTransition (value: bool) = Interop.mkAttr "closeAfterTransition" value
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: Element option) = Interop.mkAttr "container" element
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: ReactElement option) = Interop.mkAttr "container" element
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// If `true`, the modal will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any modal children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus (value: bool) = Interop.mkAttr "disableAutoFocus" value
  /// If `true`, clicking the backdrop will not fire `onClose`.
  static member inline disableBackdropClick (value: bool) = Interop.mkAttr "disableBackdropClick" value
  /// If `true`, the modal will not prevent focus from leaving the modal while open.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus (value: bool) = Interop.mkAttr "disableEnforceFocus" value
  /// If `true`, hitting escape will not fire `onClose`.
  static member inline disableEscapeKeyDown (value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  /// If `true`, the modal will not restore focus to previously focused element once modal is hidden.
  static member inline disableRestoreFocus (value: bool) = Interop.mkAttr "disableRestoreFocus" value
  /// Disable the scroll lock behavior.
  static member inline disableScrollLock (value: bool) = Interop.mkAttr "disableScrollLock" value
  /// If `true`, the backdrop is not rendered.
  static member inline hideBackdrop (value: bool) = Interop.mkAttr "hideBackdrop" value
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Modal.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick (handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  /// Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: Event -> ModalCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"escapeKeyDown"`, `"backdropClick"`.
  static member inline onClose (handler: ModalCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired when the escape key is pressed, `disableEscapeKeyDown` is false and the modal is in focus.
  static member inline onEscapeKeyDown (handler: Event -> unit) = Interop.mkAttr "onEscapeKeyDown" handler
  /// If `true`, the modal is open.
  static member inline open' (value: bool) = Interop.mkAttr "open" value


[<Erase>]
type nativeSelect =
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (element: ReactElement) = prop.children element
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The icon that displays the arrow.
  static member inline IconComponent (value: ReactElementType) = Interop.mkAttr "IconComponent" value
  /// An `Input` element; does not have to be a material-ui specific `Input`.
  static member inline input (value: ReactElement) = Interop.mkAttr "input" value
  /// Attributes applied to the `select` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Callback function fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback function fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The input value.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// *Inherited from `input`*
  ///
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// *Inherited from `input`*
  ///
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the `input` element will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the input will not have an underline.
  static member inline disableUnderline (value: bool) = Interop.mkAttr "disableUnderline" value
  /// *Inherited from `input`*
  ///
  /// End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// *Inherited from `input`*
  ///
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// *Inherited from `input`*
  ///
  /// The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// *Inherited from `input`*
  ///
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: string) = Interop.mkAttr "inputComponent" value
  /// *Inherited from `input`*
  ///
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// *Inherited from `input`*
  ///
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// *Inherited from `input`*
  ///
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// *Inherited from `input`*
  ///
  /// If `true`, a textarea element will be rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  /// *Inherited from `input`*
  ///
  /// Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// *Inherited from `input`*
  ///
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// *Inherited from `input`*
  ///
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// *Inherited from `input`*
  ///
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// *Inherited from `input`*
  ///
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax (value: int) = Interop.mkAttr "rowsMax" value
  /// *Inherited from `input`*
  ///
  /// Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// *Inherited from `input`*
  ///
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  /// *Inherited from `inputBase`*
  ///
  /// Callback fired when the input is blurred.
  ///
  /// Notice that the first argument (event) might be undefined.
  static member inline onBlur (handler: Event option -> unit) = Interop.mkAttr "onBlur" handler
  /// *Inherited from `inputBase`*
  ///
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline rowsMin (value: int) = Interop.mkAttr "rowsMin" value

module nativeSelect =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"

  /// *Inherited from `input`*
  ///
  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// *Inherited from `input`*
  ///
  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


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
  /// If `true`, the component will not only prevent server-side rendering. It will also defer the rendering of the children into a different screen frame.
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
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// The label of the input. It is only used for layout. The actual labelling is handled by `InputLabel`. If specified `labelWidth` is ignored.
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// The label of the input. It is only used for layout. The actual labelling is handled by `InputLabel`. If specified `labelWidth` is ignored.
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// The label of the input. It is only used for layout. The actual labelling is handled by `InputLabel`. If specified `labelWidth` is ignored.
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// The label of the input. It is only used for layout. The actual labelling is handled by `InputLabel`. If specified `labelWidth` is ignored.
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// The label of the input. It is only used for layout. The actual labelling is handled by `InputLabel`. If specified `labelWidth` is ignored.
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// The label of the input. It is only used for layout. The actual labelling is handled by `InputLabel`. If specified `labelWidth` is ignored.
  static member inline label (value: float) = Interop.mkAttr "label" value
  /// The width of the label. Is ignored if `label` is provided. Prefer `label` if the input label appears with a strike through.
  static member inline labelWidth (value: int) = Interop.mkAttr "labelWidth" value
  /// If `true`, a textarea element will be rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// If `true`, the outline is notched to accommodate the label.
  static member inline notched (value: bool) = Interop.mkAttr "notched" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax (value: int) = Interop.mkAttr "rowsMax" value
  /// Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `inputBase`*
  ///
  /// Callback fired when the input is blurred.
  ///
  /// Notice that the first argument (event) might be undefined.
  static member inline onBlur (handler: Event option -> unit) = Interop.mkAttr "onBlur" handler
  /// *Inherited from `inputBase`*
  ///
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline rowsMin (value: int) = Interop.mkAttr "rowsMin" value

module outlinedInput =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type pagination =
  /// Number of always visible pages at the beginning and end.
  static member inline boundaryCount (value: int) = Interop.mkAttr "boundaryCount" value
  /// The total number of pages.
  static member inline count (value: int) = Interop.mkAttr "count" value
  /// The page selected by default when the component is uncontrolled.
  static member inline defaultPage (value: int) = Interop.mkAttr "defaultPage" value
  /// If `true`, the pagination component will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Accepts a function which returns a string value that provides a user-friendly name for the current page.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  ///
  /// **Signature:**
  ///
  /// `function(type: string, page: number, selected: bool) => string`
  ///
  /// *type:* The link or button type to format ('page'
  static member inline getItemAriaLabel (getLabel: string -> int -> bool -> string) = Interop.mkAttr "getItemAriaLabel" (Func<_,_,_,_> (fun t p s -> getLabel t p s))
  /// If `true`, hide the next-page button.
  static member inline hideNextButton (value: bool) = Interop.mkAttr "hideNextButton" value
  /// If `true`, hide the previous-page button.
  static member inline hidePrevButton (value: bool) = Interop.mkAttr "hidePrevButton" value
  /// Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, page: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *page:* The page selected.
  static member inline onChange (handler: Event -> int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, page: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *page:* The page selected.
  static member inline onChange (handler: int -> unit) = Interop.mkAttr "onChange" (Func<_,_> (fun _ p -> handler p))
  /// The current page.
  static member inline page (value: int) = Interop.mkAttr "page" value
  /// Render the item.
  ///
  /// **Signature:**
  ///
  /// `function(params: PaginationRenderItemParams) => ReactNode`
  ///
  /// *params:* The props to spread on a PaginationItem.
  static member inline renderItem (render: PaginationRenderItemParams -> ReactElement) = Interop.mkAttr "renderItem" (Func<_,_> (fun p -> render p))
  /// If `true`, show the first-page button.
  static member inline showFirstButton (value: bool) = Interop.mkAttr "showFirstButton" value
  /// If `true`, show the last-page button.
  static member inline showLastButton (value: bool) = Interop.mkAttr "showLastButton" value
  /// Number of always visible pages before and after the current page.
  static member inline siblingCount (value: int) = Interop.mkAttr "siblingCount" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module pagination =

  /// The active color.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline standard = Interop.mkAttr "color" "standard"

  /// The shape of the pagination items.
  [<Erase>]
  type shape =
    static member inline round = Interop.mkAttr "shape" "round"
    static member inline rounded = Interop.mkAttr "shape" "rounded"

  /// The size of the pagination component.
  [<Erase>]
  type size =
    static member inline large = Interop.mkAttr "size" "large"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline text = Interop.mkAttr "variant" "text"


[<Erase>]
type paginationItem =
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the item will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// The current page number.
  static member inline page (value: int) = Interop.mkAttr "page" value
  /// If `true` the pagination item is selected.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module paginationItem =

  /// The active color.
  [<Erase>]
  type color =
    static member inline standard = Interop.mkAttr "color" "standard"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The shape of the pagination item.
  [<Erase>]
  type shape =
    static member inline round = Interop.mkAttr "shape" "round"
    static member inline rounded = Interop.mkAttr "shape" "rounded"

  /// The size of the pagination item.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"

  /// The type of pagination item.
  [<Erase>]
  type type' =
    static member inline page = Interop.mkAttr "type" "page"
    static member inline first = Interop.mkAttr "type" "first"
    static member inline last = Interop.mkAttr "type" "last"
    static member inline next = Interop.mkAttr "type" "next"
    static member inline previous = Interop.mkAttr "type" "previous"
    static member inline startEllipsis = Interop.mkAttr "type" "start-ellipsis"
    static member inline endEllipsis = Interop.mkAttr "type" "end-ellipsis"

  /// The pagination item variant.
  [<Erase>]
  type variant =
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


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
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value

module paper =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline elevation = Interop.mkAttr "variant" "elevation"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


[<Erase>]
type popover =
  /// A ref for imperative actions. It currently only supports updatePosition() action.
  static member inline action (ref: IRefValue<PopoverActions option>) = Interop.mkAttr "action" ref
  /// A ref for imperative actions. It currently only supports updatePosition() action.
  static member inline action (handler: PopoverActions -> unit) = Interop.mkAttr "action" handler
  /// A HTML element, or a function that returns it. It's used to set the position of the popover.
  static member inline anchorEl (value: Element option) = Interop.mkAttr "anchorEl" value
  /// A HTML element, or a function that returns it. It's used to set the position of the popover.
  static member inline anchorEl (getElement: unit -> Element option) = Interop.mkAttr "anchorEl" getElement
  /// A HTML element, or a function that returns it. It's used to set the position of the popover.
  static member inline anchorEl (ref: IRefValue<Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: PopoverOriginHorizontal, vertical: PopoverOriginVertical) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: int, vertical: PopoverOriginVertical) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  static member inline anchorOrigin (horizontal: PopoverOriginHorizontal, vertical: int) = Interop.mkAttr "anchorOrigin" (createObj [ "horizontal" ==> horizontal; "vertical" ==> vertical ])
  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
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
  /// A HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: Element option) = Interop.mkAttr "container" element
  /// A HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: ReactElement option) = Interop.mkAttr "container" element
  /// A HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// A HTML element, component instance, or function that returns either. The `container` will passed to the Modal component.
  ///
  /// By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// The elevation of the popover.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// This function is called in order to retrieve the content anchor element. It's the opposite of the `anchorEl` prop. The content anchor element should be an element inside the popover. It's used to correctly scroll and set the position of the popover. The positioning strategy tries to make the content anchor element just above the anchor element.
  static member inline getContentAnchorEl (handler: Element option -> unit) = Interop.mkAttr "getContentAnchorEl" handler
  /// Specifies how close to the edge of the window the popover can appear.
  static member inline marginThreshold (value: int) = Interop.mkAttr "marginThreshold" value
  /// Callback fired when the component requests to be closed.
  static member inline onClose (handler: Event -> PopoverCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed.
  static member inline onClose (handler: PopoverCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired before the component is entering.
  static member inline onEnter (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEnter" handler
  /// Callback fired when the component has entered.
  static member inline onEntered (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntered" handler
  /// Callback fired when the component is entering.
  static member inline onEntering (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntering" handler
  /// Callback fired before the component is exiting.
  static member inline onExit (handler: ReactElement -> unit) = Interop.mkAttr "onExit" handler
  /// Callback fired when the component has exited.
  static member inline onExited (handler: ReactElement -> unit) = Interop.mkAttr "onExited" handler
  /// Callback fired when the component is exiting.
  static member inline onExiting (handler: ReactElement -> unit) = Interop.mkAttr "onExiting" handler
  /// If `true`, the popover is visible.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props applied to the [`Paper`](https://material-ui.com/api/paper/) element.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
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
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)
  /// *Inherited from `modal`*
  ///
  /// A backdrop component. This prop enables custom backdrop rendering.
  static member inline BackdropComponent (value: ReactElementType) = Interop.mkAttr "BackdropComponent" value
  /// *Inherited from `modal`*
  ///
  /// Props applied to the [`Backdrop`](https://material-ui.com/api/backdrop/) element.
  static member inline BackdropProps (props: IReactProperty list) = Interop.mkAttr "BackdropProps" (createObj !!props)
  /// *Inherited from `modal`*
  ///
  /// When set to true the Modal waits until a nested Transition is completed before closing.
  static member inline closeAfterTransition (value: bool) = Interop.mkAttr "closeAfterTransition" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any modal children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus (value: bool) = Interop.mkAttr "disableAutoFocus" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, clicking the backdrop will not fire `onClose`.
  static member inline disableBackdropClick (value: bool) = Interop.mkAttr "disableBackdropClick" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not prevent focus from leaving the modal while open.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus (value: bool) = Interop.mkAttr "disableEnforceFocus" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, hitting escape will not fire `onClose`.
  static member inline disableEscapeKeyDown (value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  /// *Inherited from `modal`*
  ///
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the modal will not restore focus to previously focused element once modal is hidden.
  static member inline disableRestoreFocus (value: bool) = Interop.mkAttr "disableRestoreFocus" value
  /// *Inherited from `modal`*
  ///
  /// Disable the scroll lock behavior.
  static member inline disableScrollLock (value: bool) = Interop.mkAttr "disableScrollLock" value
  /// *Inherited from `modal`*
  ///
  /// If `true`, the backdrop is not rendered.
  static member inline hideBackdrop (value: bool) = Interop.mkAttr "hideBackdrop" value
  /// *Inherited from `modal`*
  ///
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Modal.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value
  /// *Inherited from `modal`*
  ///
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick (handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  /// *Inherited from `modal`*
  ///
  /// Callback fired when the escape key is pressed, `disableEscapeKeyDown` is false and the modal is in focus.
  static member inline onEscapeKeyDown (handler: Event -> unit) = Interop.mkAttr "onEscapeKeyDown" handler

module popover =

  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
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

  /// This determines which anchor prop to refer to to set the position of the popover.
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
  /// A HTML element, [referenceObject](https://popper.js.org/docs/v1/#referenceObject), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (value: Element option) = Interop.mkAttr "anchorEl" value
  /// A HTML element, [referenceObject](https://popper.js.org/docs/v1/#referenceObject), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (getElement: unit -> Element option) = Interop.mkAttr "anchorEl" getElement
  /// A HTML element, [referenceObject](https://popper.js.org/docs/v1/#referenceObject), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (referenceObject: obj) = Interop.mkAttr "anchorEl" referenceObject
  /// A HTML element, [referenceObject](https://popper.js.org/docs/v1/#referenceObject), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (getReferenceObject: unit -> obj) = Interop.mkAttr "anchorEl" getReferenceObject
  /// A HTML element, [referenceObject](https://popper.js.org/docs/v1/#referenceObject), or a function that returns either. It's used to set the position of the popper. The return value will passed as the reference object of the Popper instance.
  static member inline anchorEl (ref: IRefValue<Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
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
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: Element option) = Interop.mkAttr "container" element
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: ReactElement option) = Interop.mkAttr "container" element
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Popper.
  static member inline keepMounted (value: bool) = Interop.mkAttr "keepMounted" value
  /// Popper.js is based on a "plugin-like" architecture, most of its features are fully encapsulated "modifiers".
  ///
  /// A modifier is a function that is called each time Popper.js needs to compute the position of the popper. For this reason, modifiers should be very performant to avoid bottlenecks. To learn how to create a modifier, [read the modifiers documentation](https://popper.js.org/docs/v1/#modifiers).
  static member inline modifiers (value: 'a) = Interop.mkAttr "modifiers" value
  /// If `true`, the popper is visible.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Options provided to the [`popper.js`](https://popper.js.org/docs/v1/) instance.
  static member inline popperOptions (value: 'a) = Interop.mkAttr "popperOptions" value
  /// A ref that points to the used popper instance.
  static member inline popperRef (ref: IRefValue<Element option>) = Interop.mkAttr "popperRef" ref
  /// A ref that points to the used popper instance.
  static member inline popperRef (handler: Element -> unit) = Interop.mkAttr "popperRef" handler
  /// Help supporting a react-transition-group/Transition component.
  static member inline transition (value: bool) = Interop.mkAttr "transition" value

module popper =

  /// Popper placement.
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
type portal =
  /// The children to render into the `container`.
  static member inline children (element: ReactElement) = prop.children element
  /// The children to render into the `container`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The children to render into the `container`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The children to render into the `container`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The children to render into the `container`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The children to render into the `container`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: Element option) = Interop.mkAttr "container" element
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (element: ReactElement option) = Interop.mkAttr "container" element
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// A HTML element, component instance, or function that returns either. The `container` will have the portal children appended to it.
  ///
  /// By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container (getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal (value: bool) = Interop.mkAttr "disablePortal" value


[<Erase>]
type radio =
  /// If `true`, the component is checked.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon (element: ReactElement) = Interop.mkAttr "checkedIcon" element
  /// If `true`, the radio will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string). You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// The value of the component.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `iconButton`*
  ///
  /// If `true`, the keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)

module radio =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the radio. `small` is equivalent to the dense radio styling.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// *Inherited from `iconButton`*
  ///
  /// If given, uses a negative margin to counteract the padding on one side (this is often helpful for aligning the left or right side of the icon with content above or below, without ruining the border size and shape).
  [<Erase>]
  type edge =
    static member inline start = Interop.mkAttr "edge" "start"
    static member inline end' = Interop.mkAttr "edge" "end"
    static member inline false' = Interop.mkAttr "edge" false


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
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// The name used to reference the value of the control. If you don't provide this prop, it falls back to a randomly generated name.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// Callback fired when a radio button is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when a radio button is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// Value of the selected radio button.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// *Inherited from `formGroup`*
  ///
  /// Display group of elements in a compact row.
  static member inline row (value: bool) = Interop.mkAttr "row" value


[<Erase>]
type rating =
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: int) = Interop.mkAttr "defaultValue" value
  /// The default value. Use when the component is not controlled.
  static member inline defaultValue (value: float) = Interop.mkAttr "defaultValue" value
  /// If `true`, the rating will be disabled.
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
  /// Accepts a function which returns a string value that provides a user-friendly name for the current value of the rating.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  ///
  /// **Signature:**
  ///
  /// `function(value: number) => string`
  ///
  /// *value:* The rating label's value to format.
  static member inline getLabelText (getText: int -> string) = Interop.mkAttr "getLabelText" getText
  /// Accepts a function which returns a string value that provides a user-friendly name for the current value of the rating.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  ///
  /// **Signature:**
  ///
  /// `function(value: number) => string`
  ///
  /// *value:* The rating label's value to format.
  static member inline getLabelText (getText: float -> string) = Interop.mkAttr "getLabelText" getText
  /// The icon to display.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The component containing the icon.
  static member inline IconContainerComponent (value: ReactElementType) = Interop.mkAttr "IconContainerComponent" value
  /// Maximum rating.
  static member inline max (value: int) = Interop.mkAttr "max" value
  /// Maximum rating.
  static member inline max (value: float) = Interop.mkAttr "max" value
  /// The name attribute of the radio `input` elements. If `readOnly` is false, the prop is required, this input name`should be unique within the parent form.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: Event -> int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: Event -> float -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: float -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeActive (handler: Event -> int -> unit) = Interop.mkAttr "onChangeActive" (Func<_,_,_> handler)
  /// Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeActive (handler: Event -> float -> unit) = Interop.mkAttr "onChangeActive" (Func<_,_,_> handler)
  /// Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeActive (handler: int -> unit) = Interop.mkAttr "onChangeActive" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
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
  /// The rating value.
  static member inline value (value: int) = Interop.mkAttr "value" value
  /// The rating value.
  static member inline value (value: float) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module rating =

  /// The size of the rating.
  [<Erase>]
  type size =
    static member inline large = Interop.mkAttr "size" "large"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"


[<Erase>]
type rootRef =
  /// The wrapped element.
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// A ref that points to the first DOM node of the wrapped element.
  static member inline rootRef (ref: IRefValue<Element option>) = Interop.mkAttr "rootRef" ref
  /// A ref that points to the first DOM node of the wrapped element.
  static member inline rootRef (handler: Element -> unit) = Interop.mkAttr "rootRef" handler


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


[<Erase>]
type select =
  /// If `true`, the width of the popover will automatically be set according to the items inside the menu, otherwise it will be at least the width of the select input.
  static member inline autoWidth (value: bool) = Interop.mkAttr "autoWidth" value
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (element: ReactElement) = prop.children element
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, a value is displayed even if no items are selected.
  ///
  /// In order to display a meaningful value, a function should be passed to the `renderValue` prop which returns the value to be displayed when no items are selected. You can only use it when the `native` prop is `false` (default).
  static member inline displayEmpty (value: bool) = Interop.mkAttr "displayEmpty" value
  /// The icon that displays the arrow.
  static member inline IconComponent (value: ReactElementType) = Interop.mkAttr "IconComponent" value
  /// The `id` of the wrapper element or the `select` element when `native`.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// An `Input` element; does not have to be a material-ui specific `Input`.
  static member inline input (value: ReactElement) = Interop.mkAttr "input" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element. When `native` is `true`, the attributes are applied on the `select` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// See [OutlinedInput#label](https://material-ui.com/api/outlined-input/#props)
  static member inline label (value: ReactElement) = Interop.mkAttr "label" value
  /// See [OutlinedInput#label](https://material-ui.com/api/outlined-input/#props)
  static member inline label (values: ReactElement seq) = Interop.mkAttr "label" values
  /// See [OutlinedInput#label](https://material-ui.com/api/outlined-input/#props)
  static member inline label (value: string) = Interop.mkAttr "label" value
  /// See [OutlinedInput#label](https://material-ui.com/api/outlined-input/#props)
  static member inline label (values: string seq) = Interop.mkAttr "label" values
  /// See [OutlinedInput#label](https://material-ui.com/api/outlined-input/#props)
  static member inline label (value: int) = Interop.mkAttr "label" value
  /// See [OutlinedInput#label](https://material-ui.com/api/outlined-input/#props)
  static member inline label (value: float) = Interop.mkAttr "label" value
  /// The ID of an element that acts as an additional label. The Select will be labelled by the additional label and the selected value.
  static member inline labelId (value: string) = Interop.mkAttr "labelId" value
  /// See [OutlinedInput#label](https://material-ui.com/api/outlined-input/#props)
  static member inline labelWidth (value: int) = Interop.mkAttr "labelWidth" value
  /// Props applied to the [`Menu`](https://material-ui.com/api/menu/) element.
  static member inline MenuProps (props: IReactProperty list) = Interop.mkAttr "MenuProps" (createObj !!props)
  /// If `true`, `value` must be an array and the menu will support multiple selections.
  static member inline multiple (value: bool) = Interop.mkAttr "multiple" value
  /// If `true`, the component will be using a native `select` element.
  static member inline native (value: bool) = Interop.mkAttr "native" value
  /// Callback function fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, child?: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any).
  ///
  /// *child:* The react element that was selected when `native` is `false` (default).
  static member inline onChange (handler: Event -> ReactElement -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback function fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, child?: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (any).
  ///
  /// *child:* The react element that was selected when `native` is `false` (default).
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun (e: Event) _ -> handler !!e.Value))
  /// Callback fired when the component requests to be closed. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback fired when the component requests to be opened. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Control `select` open state. You can only use it when the `native` prop is `false` (default).
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> ReactElement) = Interop.mkAttr "renderValue" render
  /// Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> ReactElement seq) = Interop.mkAttr "renderValue" render
  /// Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> string) = Interop.mkAttr "renderValue" render
  /// Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> string seq) = Interop.mkAttr "renderValue" render
  /// Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> int) = Interop.mkAttr "renderValue" render
  /// Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactNode`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue (render: 'a -> float) = Interop.mkAttr "renderValue" render
  /// Props applied to the clickable div element.
  static member inline SelectDisplayProps (props: IReactProperty list) = Interop.mkAttr "SelectDisplayProps" (createObj !!props)
  /// The input value. Providing an empty string will select no options. This prop is required when the `native` prop is `false` (default). Set to an empty string `''` if you don't want any of the available options to be selected.
  ///
  /// If the value is an object it must have reference equality with the option in order to be selected. If the value is not an object, the string representation must match with the string representation of the option in order to be selected.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// *Inherited from `input`*
  ///
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the `input` element will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the input will not have an underline.
  static member inline disableUnderline (value: bool) = Interop.mkAttr "disableUnderline" value
  /// *Inherited from `input`*
  ///
  /// End `InputAdornment` for this component.
  static member inline endAdornment (element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// *Inherited from `input`*
  ///
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth (value: bool) = Interop.mkAttr "fullWidth" value
  /// *Inherited from `input`*
  ///
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: string) = Interop.mkAttr "inputComponent" value
  /// *Inherited from `input`*
  ///
  /// The component used for the `input` element. Either a string to use a HTML element or a component.
  static member inline inputComponent (value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// *Inherited from `input`*
  ///
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// *Inherited from `input`*
  ///
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// *Inherited from `input`*
  ///
  /// If `true`, a textarea element will be rendered.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  /// *Inherited from `input`*
  ///
  /// Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// *Inherited from `input`*
  ///
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// *Inherited from `input`*
  ///
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// *Inherited from `input`*
  ///
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// *Inherited from `input`*
  ///
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// *Inherited from `input`*
  ///
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax (value: int) = Interop.mkAttr "rowsMax" value
  /// *Inherited from `input`*
  ///
  /// Start `InputAdornment` for this component.
  static member inline startAdornment (element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// *Inherited from `input`*
  ///
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  /// *Inherited from `inputBase`*
  ///
  /// Callback fired when the input is blurred.
  ///
  /// Notice that the first argument (event) might be undefined.
  static member inline onBlur (handler: Event option -> unit) = Interop.mkAttr "onBlur" handler
  /// *Inherited from `inputBase`*
  ///
  /// Minimum number of rows to display when multiline option is set to true.
  static member inline rowsMin (value: int) = Interop.mkAttr "rowsMin" value

module select =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline filled = Interop.mkAttr "variant" "filled"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline standard = Interop.mkAttr "variant" "standard"

  /// *Inherited from `input`*
  ///
  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// *Inherited from `input`*
  ///
  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


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
  /// Width of the skeleton. Useful when the skeleton is inside an inline element with no width of its own.
  static member inline width (value: int) = Interop.mkAttr "width" value
  /// Width of the skeleton. Useful when the skeleton is inside an inline element with no width of its own.
  static member inline width (value: Styles.ICssUnit) = Interop.mkAttr "width" value

module skeleton =

  /// The animation. If `false` the animation effect is disabled.
  [<Erase>]
  type animation =
    static member inline pulse = Interop.mkAttr "animation" "pulse"
    static member inline wave = Interop.mkAttr "animation" "wave"
    static member inline false' = Interop.mkAttr "animation" false

  /// The type of content that will be rendered.
  [<Erase>]
  type variant =
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline rect = Interop.mkAttr "variant" "rect"
    static member inline circle = Interop.mkAttr "variant" "circle"


[<Erase>]
type slide =
  /// A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// If `true`, show the component; triggers the enter or exit animation.
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
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue (value: int) = Interop.mkAttr "defaultValue" value
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue (value: float) = Interop.mkAttr "defaultValue" value
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue (min: int, max: int) = Interop.mkAttr "defaultValue" (min, max)
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue (min: float, max: float) = Interop.mkAttr "defaultValue" (min, max)
  /// If `true`, the slider will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Accepts a function which returns a string value that provides a user-friendly name for the thumb labels of the slider.
  ///
  /// **Signature:**
  ///
  /// `function(index: number) => string`
  ///
  /// *index:* The thumb label's index to format.
  static member inline getAriaLabel (getLabel: int -> string) = Interop.mkAttr "getAriaLabel" getLabel
  /// Accepts a function which returns a string value that provides a user-friendly name for the current value of the slider.
  ///
  /// **Signature:**
  ///
  /// `function(value: number, index: number) => string`
  ///
  /// *value:* The thumb label's value to format.
  ///
  /// *index:* The thumb label's index to format.
  static member inline getAriaValueText (getText: int -> int -> string) = Interop.mkAttr "getAriaValueText" getText
  /// Accepts a function which returns a string value that provides a user-friendly name for the current value of the slider.
  ///
  /// **Signature:**
  ///
  /// `function(value: number, index: number) => string`
  ///
  /// *value:* The thumb label's value to format.
  ///
  /// *index:* The thumb label's index to format.
  static member inline getAriaValueText (getText: float -> int -> string) = Interop.mkAttr "getAriaValueText" getText
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks (value: bool) = Interop.mkAttr "marks" value
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks ([<ParamArray>] values: int []) = Interop.mkAttr "marks" (values |> Array.map (fun x -> createObj [ "value" ==> x ]))
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks ([<ParamArray>] values: float []) = Interop.mkAttr "marks" (values |> Array.map (fun x -> createObj [ "value" ==> x ]))
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks ([<ParamArray>] valuesAndLabels: (int * string option) []) = Interop.mkAttr "marks" (valuesAndLabels |> Array.map (fun (v, lb) -> createObj [ "value" ==> v; "label" ==> lb ]))
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks ([<ParamArray>] valuesAndLabels: (float * string option) []) = Interop.mkAttr "marks" (valuesAndLabels |> Array.map (fun (v, lb) -> createObj [ "value" ==> v; "label" ==> lb ]))
  /// The maximum allowed value of the slider. Should not be equal to min.
  static member inline max (value: int) = Interop.mkAttr "max" value
  /// The minimum allowed value of the slider. Should not be equal to max.
  static member inline min (value: int) = Interop.mkAttr "min" value
  /// Name attribute of the hidden `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: Event -> int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: Event -> float -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: int -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: float -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: Event -> int [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: Event -> float [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: int [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChange (handler: float [] -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> int -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> handler)
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> float -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> handler)
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: int -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: float -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> int [] -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> handler)
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: Event -> float [] -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> handler)
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: int [] -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number | number[]) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* The new value.
  static member inline onChangeCommitted (handler: float [] -> unit) = Interop.mkAttr "onChangeCommitted" (Func<_,_,_> (fun _ v -> handler v))
  /// A transformation function, to change the scale of the slider.
  static member inline scale (transform: int -> int) = Interop.mkAttr "scale" transform
  /// A transformation function, to change the scale of the slider.
  static member inline scale (transform: float -> float) = Interop.mkAttr "scale" transform
  /// The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
  ///
  /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step (value: int) = Interop.mkAttr "step" value
  /// The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
  ///
  /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step (value: float) = Interop.mkAttr "step" value
  /// The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
  ///
  /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step (value: int option) = Interop.mkAttr "step" value
  /// The component used to display the value label.
  static member inline ThumbComponent (value: ReactElementType) = Interop.mkAttr "ThumbComponent" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (value: int) = Interop.mkAttr "value" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (value: float) = Interop.mkAttr "value" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (min: int, max: int) = Interop.mkAttr "value" (min, max)
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value (min: float, max: float) = Interop.mkAttr "value" (min, max)
  /// The value label component.
  static member inline ValueLabelComponent (value: ReactElementType) = Interop.mkAttr "ValueLabelComponent" value
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
    /// The granularity with which the slider can step through values. (A "discrete" slider.) The `min` prop serves as the origin for the valid values. We recommend (max - min) to be evenly divisible by the step.
    ///
    /// When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
    static member inline step (value: float option) = Interop.mkAttr "step" value

module slider =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The slider orientation.
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The track presentation:
  ///
  /// - `normal` the track will render a bar representing the slider value. - `inverted` the track will render a bar representing the remaining slider value. - `false` the track will render without a bar.
  [<Erase>]
  type track =
    static member inline normal = Interop.mkAttr "track" "normal"
    static member inline false' = Interop.mkAttr "track" false
    static member inline inverted = Interop.mkAttr "track" "inverted"

  /// Controls when the value label is displayed:
  ///
  /// - `auto` the value label will display when the thumb is hovered or focused. - `on` will display persistently. - `off` will never display.
  [<Erase>]
  type valueLabelDisplay =
    static member inline on = Interop.mkAttr "valueLabelDisplay" "on"
    static member inline auto = Interop.mkAttr "valueLabelDisplay" "auto"
    static member inline off = Interop.mkAttr "valueLabelDisplay" "off"


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
  /// The number of milliseconds to wait before automatically calling the `onClose` function. `onClose` should then set the state of the `open` prop to hide the Snackbar. This behavior is disabled by default with the `null` value.
  static member inline autoHideDuration (value: int) = Interop.mkAttr "autoHideDuration" value
  /// The number of milliseconds to wait before automatically calling the `onClose` function. `onClose` should then set the state of the `open` prop to hide the Snackbar. This behavior is disabled by default with the `null` value.
  static member inline autoHideDuration (value: int option) = Interop.mkAttr "autoHideDuration" value
  /// Replace the `SnackbarContent` component.
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Props applied to the `ClickAwayListener` element.
  static member inline ClickAwayListenerProps (props: IReactProperty list) = Interop.mkAttr "ClickAwayListenerProps" (createObj !!props)
  /// Props applied to the [`SnackbarContent`](https://material-ui.com/api/snackbar-content/) element.
  static member inline ContentProps (props: IReactProperty list) = Interop.mkAttr "ContentProps" (createObj !!props)
  /// If `true`, the `autoHideDuration` timer will expire even if the window is not focused.
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
  /// Callback fired when the component requests to be closed. Typically `onClose` is used to set state in the parent component, which is used to control the `Snackbar` `open` prop. The `reason` parameter can optionally be used to control the response to `onClose`, for example ignoring `clickaway`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"timeout"` (`autoHideDuration` expired), `"clickaway"`.
  static member inline onClose (handler: Event -> SnackbarCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed. Typically `onClose` is used to set state in the parent component, which is used to control the `Snackbar` `open` prop. The `reason` parameter can optionally be used to control the response to `onClose`, for example ignoring `clickaway`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"timeout"` (`autoHideDuration` expired), `"clickaway"`.
  static member inline onClose (handler: SnackbarCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired before the transition is entering.
  static member inline onEnter (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEnter" handler
  /// Callback fired when the transition has entered.
  static member inline onEntered (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntered" handler
  /// Callback fired when the transition is entering.
  static member inline onEntering (handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntering" handler
  /// Callback fired before the transition is exiting.
  static member inline onExit (handler: ReactElement -> unit) = Interop.mkAttr "onExit" handler
  /// Callback fired when the transition has exited.
  static member inline onExited (handler: ReactElement -> unit) = Interop.mkAttr "onExited" handler
  /// Callback fired when the transition is exiting.
  static member inline onExiting (handler: ReactElement -> unit) = Interop.mkAttr "onExiting" handler
  /// If `true`, `Snackbar` is open.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The number of milliseconds to wait before dismissing after user interaction. If `autoHideDuration` prop isn't specified, it does nothing. If `autoHideDuration` prop is specified but `resumeHideDuration` isn't, we default to `autoHideDuration / 2` ms.
  static member inline resumeHideDuration (value: int) = Interop.mkAttr "resumeHideDuration" value
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module snackbar =

  /// The anchor of the `Snackbar`.
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
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// *Inherited from `paper`*
  ///
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value

module snackbarContent =

  /// *Inherited from `paper`*
  ///
  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline elevation = Interop.mkAttr "variant" "elevation"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


[<Erase>]
type speedDial =
  /// The aria-label of the button element. Also used to provide the `id` for the `SpeedDial` element and its children.
  static member inline ariaLabel (value: string) = Interop.mkAttr "ariaLabel" value
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (element: ReactElement) = prop.children element
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Props applied to the [`Fab`](https://material-ui.com/api/fab/) element.
  static member inline FabProps (props: IReactProperty list) = Interop.mkAttr "FabProps" (createObj !!props)
  /// If `true`, the SpeedDial will be hidden.
  static member inline hidden (value: bool) = Interop.mkAttr "hidden" value
  /// The icon to display in the SpeedDial Fab. The `SpeedDialIcon` component provides a default Icon with animation.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggle"`, `"blur"`, `"mouseLeave"`, `"escapeKeyDown"`.
  static member inline onClose (handler: Event -> SpeedDialCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggle"`, `"blur"`, `"mouseLeave"`, `"escapeKeyDown"`.
  static member inline onClose (handler: SpeedDialCloseReason -> unit) = Interop.mkAttr "onClose" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired when the component requests to be open.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggle"`, `"focus"`, `"mouseEnter"`.
  static member inline onOpen (handler: Event -> SpeedDialOpenReason -> unit) = Interop.mkAttr "onOpen" (Func<_,_,_> handler)
  /// Callback fired when the component requests to be open.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be: `"toggle"`, `"focus"`, `"mouseEnter"`.
  static member inline onOpen (handler: SpeedDialOpenReason -> unit) = Interop.mkAttr "onOpen" (Func<_,_,_> (fun _ v -> handler v))
  /// If `true`, the SpeedDial is open.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The icon to display in the SpeedDial Fab when the SpeedDial is open.
  static member inline openIcon (element: ReactElement) = Interop.mkAttr "openIcon" element
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
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
  /// Props applied to the [`Fab`](https://material-ui.com/api/fab/) component.
  static member inline FabProps (props: IReactProperty list) = Interop.mkAttr "FabProps" (createObj !!props)
  /// The Icon to display in the SpeedDial Fab.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// This prop is used to help implement the accessibility logic. If you don't provide this prop. It falls back to a randomly generated id.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// If `true`, the tooltip is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
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
  /// *Inherited from `tooltip`*
  ///
  /// If `true`, adds an arrow to the tooltip.
  static member inline arrow (value: bool) = Interop.mkAttr "arrow" value
  /// *Inherited from `tooltip`*
  ///
  /// Do not respond to focus events.
  static member inline disableFocusListener (value: bool) = Interop.mkAttr "disableFocusListener" value
  /// *Inherited from `tooltip`*
  ///
  /// Do not respond to hover events.
  static member inline disableHoverListener (value: bool) = Interop.mkAttr "disableHoverListener" value
  /// *Inherited from `tooltip`*
  ///
  /// Do not respond to long press touch events.
  static member inline disableTouchListener (value: bool) = Interop.mkAttr "disableTouchListener" value
  /// *Inherited from `tooltip`*
  ///
  /// The number of milliseconds to wait before showing the tooltip. This prop won't impact the enter touch delay (`enterTouchDelay`).
  static member inline enterDelay (value: int) = Interop.mkAttr "enterDelay" value
  /// *Inherited from `tooltip`*
  ///
  /// The number of milliseconds to wait before showing the tooltip when one was already recently opened.
  static member inline enterNextDelay (value: int) = Interop.mkAttr "enterNextDelay" value
  /// *Inherited from `tooltip`*
  ///
  /// The number of milliseconds a user must touch the element before showing the tooltip.
  static member inline enterTouchDelay (value: int) = Interop.mkAttr "enterTouchDelay" value
  /// *Inherited from `tooltip`*
  ///
  /// Makes a tooltip interactive, i.e. will not close when the user hovers over the tooltip before the `leaveDelay` is expired.
  static member inline interactive (value: bool) = Interop.mkAttr "interactive" value
  /// *Inherited from `tooltip`*
  ///
  /// The number of milliseconds to wait before hiding the tooltip. This prop won't impact the leave touch delay (`leaveTouchDelay`).
  static member inline leaveDelay (value: int) = Interop.mkAttr "leaveDelay" value
  /// *Inherited from `tooltip`*
  ///
  /// The number of milliseconds after the user stops touching an element before hiding the tooltip.
  static member inline leaveTouchDelay (value: int) = Interop.mkAttr "leaveTouchDelay" value
  /// *Inherited from `tooltip`*
  ///
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// *Inherited from `tooltip`*
  ///
  /// Callback fired when the component requests to be open.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// *Inherited from `tooltip`*
  ///
  /// The component used for the popper.
  static member inline PopperComponent (value: ReactElementType) = Interop.mkAttr "PopperComponent" value
  /// *Inherited from `tooltip`*
  ///
  /// Props applied to the [`Popper`](https://material-ui.com/api/popper/) element.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// *Inherited from `tooltip`*
  ///
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (value: ReactElement) = Interop.mkAttr "title" value
  /// *Inherited from `tooltip`*
  ///
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (values: ReactElement seq) = Interop.mkAttr "title" values
  /// *Inherited from `tooltip`*
  ///
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (value: string) = Interop.mkAttr "title" value
  /// *Inherited from `tooltip`*
  ///
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (values: string seq) = Interop.mkAttr "title" values
  /// *Inherited from `tooltip`*
  ///
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (value: int) = Interop.mkAttr "title" value
  /// *Inherited from `tooltip`*
  ///
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title (value: float) = Interop.mkAttr "title" value
  /// *Inherited from `tooltip`*
  ///
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// *Inherited from `tooltip`*
  ///
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
  static member inline TransitionProps (props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

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

  /// *Inherited from `tooltip`*
  ///
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
type speedDialIcon =
  /// The icon to display in the SpeedDial Floating Action Button.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The icon to display in the SpeedDial Floating Action Button when the SpeedDial is open.
  static member inline openIcon (element: ReactElement) = Interop.mkAttr "openIcon" element
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type step =
  /// Sets the step as active. Is passed to child components.
  static member inline active (value: bool) = Interop.mkAttr "active" value
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (element: ReactElement) = prop.children element
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Mark the step as completed. Is passed to child components.
  static member inline completed (value: bool) = Interop.mkAttr "completed" value
  /// Mark the step as disabled, will also disable the button if `StepButton` is a child of `Step`. Is passed to child components.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Expand the step.
  static member inline expanded (value: bool) = Interop.mkAttr "expanded" value


[<Erase>]
type stepButton =
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (element: ReactElement) = prop.children element
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
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
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


[<Erase>]
type stepConnector =
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type stepContent =
  /// Step content.
  static member inline children (element: ReactElement) = prop.children element
  /// Step content.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Step content.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Step content.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Step content.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Step content.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Adjust the duration of the content expand transition. Passed as a prop to the transition component.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// Adjust the duration of the content expand transition. Passed as a prop to the transition component.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
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
  /// Mark the step as failed.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// The label displayed in the step icon.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
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
  /// Mark the step as disabled, will also disable the button if `StepLabelButton` is a child of `StepLabel`. Is passed to child components.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Mark the step as failed.
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
  /// The component to render in place of the [`StepIcon`](https://material-ui.com/api/step-icon/).
  static member inline StepIconComponent (value: ReactElementType) = Interop.mkAttr "StepIconComponent" value
  /// Props applied to the [`StepIcon`](https://material-ui.com/api/step-icon/) element.
  static member inline StepIconProps (props: IReactProperty list) = Interop.mkAttr "StepIconProps" (createObj !!props)


[<Erase>]
type stepper =
  /// Set the active step (zero based index). Set to -1 to disable all the steps.
  static member inline activeStep (value: int) = Interop.mkAttr "activeStep" value
  /// If set to 'true' and orientation is horizontal, then the step label will be positioned under the icon.
  static member inline alternativeLabel (value: bool) = Interop.mkAttr "alternativeLabel" value
  /// Two or more `<Step />` components.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// An element to be placed between each step.
  static member inline connector (value: ReactElement) = Interop.mkAttr "connector" value
  /// If set the `Stepper` will not assist in controlling steps for linear flow.
  static member inline nonLinear (value: bool) = Interop.mkAttr "nonLinear" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `paper`*
  ///
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// *Inherited from `paper`*
  ///
  /// If `true`, rounded corners are disabled.
  static member inline square (value: bool) = Interop.mkAttr "square" value

module stepper =

  /// The stepper orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// *Inherited from `paper`*
  ///
  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline elevation = Interop.mkAttr "variant" "elevation"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


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
  /// The shape-rendering attribute. The behavior of the different options is described on the [MDN Web Docs](https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/shape-rendering). If you are having issues with blurry icons you should investigate this property.
  static member inline shapeRendering (value: string) = Interop.mkAttr "shapeRendering" value
  /// Provides a human-readable title for the element that contains it. https://www.w3.org/TR/SVG-access/#Equivalent
  static member inline titleAccess (value: string) = Interop.mkAttr "titleAccess" value
  /// Allows you to redefine what the coordinates without units mean inside an SVG element. For example, if the SVG element is 500 (width) by 200 (height), and you pass viewBox="0 0 50 20", this means that the coordinates inside the SVG will go from the top left corner (0,0) to bottom right (50,20) and each unit will be worth 10px.
  static member inline viewBox (value: string) = Interop.mkAttr "viewBox" value

module svgIcon =

  /// The color of the component. You can use the `htmlColor` prop to apply a color attribute to the SVG element.
  [<Erase>]
  type color =
    static member inline action = Interop.mkAttr "color" "action"
    static member inline disabled = Interop.mkAttr "color" "disabled"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The fontSize applied to the icon. Defaults to 24px, but can be configure to inherit font size.
  [<Erase>]
  type fontSize =
    static member inline default' = Interop.mkAttr "fontSize" "default"
    static member inline inherit' = Interop.mkAttr "fontSize" "inherit"
    static member inline large = Interop.mkAttr "fontSize" "large"
    static member inline small = Interop.mkAttr "fontSize" "small"


[<Erase>]
type swipeableDrawer =
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
  /// If `true`, touching the screen near the edge of the drawer will not slide in the drawer a bit to promote accidental discovery of the swipe gesture.
  static member inline disableDiscovery (value: bool) = Interop.mkAttr "disableDiscovery" value
  /// If `true`, swipe to open is disabled. This is useful in browsers where swiping triggers navigation actions. Swipe to open is disabled on iOS browsers by default.
  static member inline disableSwipeToOpen (value: bool) = Interop.mkAttr "disableSwipeToOpen" value
  /// Affects how far the drawer must be opened/closed to change his state. Specified as percent (0-1) of the width of the drawer
  static member inline hysteresis (value: float) = Interop.mkAttr "hysteresis" value
  /// Defines, from which (average) velocity on, the swipe is defined as complete although hysteresis isn't reached. Good threshold is between 250 - 1000 px/s
  static member inline minFlingVelocity (value: int) = Interop.mkAttr "minFlingVelocity" value
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback fired when the component requests to be opened.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// If `true`, the drawer is open.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The element is used to intercept the touch events on the edge.
  static member inline SwipeAreaProps (props: IReactProperty list) = Interop.mkAttr "SwipeAreaProps" (createObj !!props)
  /// The width of the left most (or right most) area in pixels where the drawer can be swiped open from.
  static member inline swipeAreaWidth (value: int) = Interop.mkAttr "swipeAreaWidth" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration (?enter: int, ?exit: int) = Interop.mkAttr "transitionDuration" (let x = createEmpty<obj> in (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
  /// *Inherited from `drawer`*
  ///
  /// The elevation of the drawer.
  static member inline elevation (value: int) = Interop.mkAttr "elevation" value
  /// *Inherited from `drawer`*
  ///
  /// Props applied to the [`Modal`](https://material-ui.com/api/modal/) element.
  static member inline ModalProps (props: IReactProperty list) = Interop.mkAttr "ModalProps" (createObj !!props)
  /// *Inherited from `drawer`*
  ///
  /// Props applied to the [`Paper`](https://material-ui.com/api/paper/) element.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// *Inherited from `drawer`*
  ///
  /// Props applied to the [`Slide`](https://material-ui.com/api/slide/) element.
  static member inline SlideProps (props: IReactProperty list) = Interop.mkAttr "SlideProps" (createObj !!props)

module swipeableDrawer =

  /// *Inherited from `drawer`*
  ///
  /// Side from which the drawer will appear.
  [<Erase>]
  type anchor =
    static member inline bottom = Interop.mkAttr "anchor" "bottom"
    static member inline left = Interop.mkAttr "anchor" "left"
    static member inline right = Interop.mkAttr "anchor" "right"
    static member inline top = Interop.mkAttr "anchor" "top"

  /// *Inherited from `drawer`*
  ///
  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline permanent = Interop.mkAttr "variant" "permanent"
    static member inline persistent = Interop.mkAttr "variant" "persistent"
    static member inline temporary = Interop.mkAttr "variant" "temporary"


[<Erase>]
type switch =
  /// If `true`, the component is checked.
  static member inline checked' (value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon (element: ReactElement) = Interop.mkAttr "checkedIcon" element
  /// If `true`, the switch will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon (element: ReactElement) = Interop.mkAttr "icon" element
  /// The id of the `input` element.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string). You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string). You can pull out the new checked state by accessing `event.target.checked` (boolean).
  static member inline onChange (handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
  /// If `true`, the `input` element will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// The value of the component. The browser uses "on" as the default value.
  static member inline value (value: string) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `iconButton`*
  ///
  /// If `true`, the keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)

module switch =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If given, uses a negative margin to counteract the padding on one side (this is often helpful for aligning the left or right side of the icon with content above or below, without ruining the border size and shape).
  [<Erase>]
  type edge =
    static member inline end' = Interop.mkAttr "edge" "end"
    static member inline start = Interop.mkAttr "edge" "start"
    static member inline false' = Interop.mkAttr "edge" false

  /// The size of the switch. `small` is equivalent to the dense switch styling.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"


[<Erase>]
type tab =
  /// This prop isn't supported. Use the `component` prop if you need to change the children structure.
  static member inline children  = UnsupportedProp ()
  /// If `true`, the tab will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon element.
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
  /// You can provide your own value. Otherwise, we fallback to the child position index.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// Tab labels appear in a single row. They can use a second line if needed.
  static member inline wrapped (value: bool) = Interop.mkAttr "wrapped" value
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


[<Erase>]
type tabContext =
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
  /// The value of the currently selected `Tab`.
  static member inline value (value: string) = Interop.mkAttr "value" value


[<Erase>]
type table =
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Set the header sticky.
  ///
  /// ⚠️ It doesn't work with IE 11.
  static member inline stickyHeader (value: bool) = Interop.mkAttr "stickyHeader" value

module table =

  /// Allows TableCells to inherit padding of the Table.
  [<Erase>]
  type padding =
    static member inline default' = Interop.mkAttr "padding" "default"
    static member inline checkbox = Interop.mkAttr "padding" "checkbox"
    static member inline none = Interop.mkAttr "padding" "none"

  /// Allows TableCells to inherit size of the Table.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"


[<Erase>]
type tableBody =
  /// The content of the component, normally `TableRow`.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component, normally `TableRow`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally `TableRow`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally `TableRow`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value


[<Erase>]
type tableCell =
  /// The table cell contents.
  static member inline children (element: ReactElement) = prop.children element
  /// The table cell contents.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The table cell contents.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The table cell contents.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The table cell contents.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The table cell contents.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// Set scope attribute.
  static member inline scope (value: string) = Interop.mkAttr "scope" value

module tableCell =

  /// Set the text-align on the table cell content.
  ///
  /// Monetary or generally number fields **should be right aligned** as that allows you to add them up quickly in your head without having to worry about decimals.
  [<Erase>]
  type align =
    static member inline center = Interop.mkAttr "align" "center"
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline justify = Interop.mkAttr "align" "justify"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline right = Interop.mkAttr "align" "right"

  /// Sets the padding applied to the cell. By default, the Table parent component set the value (`default`).
  [<Erase>]
  type padding =
    static member inline checkbox = Interop.mkAttr "padding" "checkbox"
    static member inline default' = Interop.mkAttr "padding" "default"
    static member inline none = Interop.mkAttr "padding" "none"

  /// Specify the size of the cell. By default, the Table parent component set the value (`medium`).
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// Set aria-sort direction.
  [<Erase>]
  type sortDirection =
    static member inline asc = Interop.mkAttr "sortDirection" "asc"
    static member inline desc = Interop.mkAttr "sortDirection" "desc"
    static member inline false' = Interop.mkAttr "sortDirection" false

  /// Specify the cell type. By default, the TableHead, TableBody or TableFooter parent component set the value.
  [<Erase>]
  type variant =
    static member inline body = Interop.mkAttr "variant" "body"
    static member inline footer = Interop.mkAttr "variant" "footer"
    static member inline head = Interop.mkAttr "variant" "head"


[<Erase>]
type tableContainer =
  /// The table itself, normally ``
  static member inline children (element: ReactElement) = prop.children element
  /// The table itself, normally ``
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The table itself, normally ``
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The table itself, normally ``
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The table itself, normally ``
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The table itself, normally ``
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value


[<Erase>]
type tableFooter =
  /// The content of the component, normally `TableRow`.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component, normally `TableRow`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally `TableRow`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally `TableRow`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value


[<Erase>]
type tableHead =
  /// The content of the component, normally `TableRow`.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the component, normally `TableRow`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally `TableRow`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally `TableRow`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value


[<Erase>]
type tablePagination =
  /// The component used for displaying the actions. Either a string to use a HTML element or a component.
  static member inline ActionsComponent (value: ReactElementType) = Interop.mkAttr "ActionsComponent" value
  /// Props applied to the back arrow [`IconButton`](https://material-ui.com/api/icon-button/) component.
  static member inline backIconButtonProps (props: IReactProperty list) = Interop.mkAttr "backIconButtonProps" (createObj !!props)
  /// Text label for the back arrow icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline backIconButtonText (value: string) = Interop.mkAttr "backIconButtonText" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// The total number of rows.
  ///
  /// To enable server side pagination for an unknown number of items, provide -1.
  static member inline count (value: int) = Interop.mkAttr "count" value
  /// Customize the displayed rows label. Invoked with a `{ from, to, count, page }` object.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline labelDisplayedRows (getLabel: {| from: int; ``to``: int; count: int |} -> ReactElement) = Interop.mkAttr "labelDisplayedRows" getLabel
  /// Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline labelRowsPerPage (value: ReactElement) = Interop.mkAttr "labelRowsPerPage" value
  /// Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline labelRowsPerPage (values: ReactElement seq) = Interop.mkAttr "labelRowsPerPage" values
  /// Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline labelRowsPerPage (value: string) = Interop.mkAttr "labelRowsPerPage" value
  /// Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline labelRowsPerPage (values: string seq) = Interop.mkAttr "labelRowsPerPage" values
  /// Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline labelRowsPerPage (value: int) = Interop.mkAttr "labelRowsPerPage" value
  /// Customize the rows per page label.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline labelRowsPerPage (value: float) = Interop.mkAttr "labelRowsPerPage" value
  /// Props applied to the next arrow [`IconButton`](https://material-ui.com/api/icon-button/) element.
  static member inline nextIconButtonProps (props: IReactProperty list) = Interop.mkAttr "nextIconButtonProps" (createObj !!props)
  /// Text label for the next arrow icon button.
  ///
  /// For localization purposes, you can use the provided [translations](https://material-ui.com/guides/localization/).
  static member inline nextIconButtonText (value: string) = Interop.mkAttr "nextIconButtonText" value
  /// Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, page: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *page:* The page selected.
  static member inline onChangePage (handler: Event -> int -> unit) = Interop.mkAttr "onChangePage" (Func<_,_,_> handler)
  /// Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, page: number) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *page:* The page selected.
  static member inline onChangePage (handler: int -> unit) = Interop.mkAttr "onChangePage" (Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired when the number of rows per page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onChangeRowsPerPage (handler: Event -> unit) = Interop.mkAttr "onChangeRowsPerPage" handler
  /// The zero-based index of the current page.
  static member inline page (value: int) = Interop.mkAttr "page" value
  /// The number of rows per page.
  static member inline rowsPerPage (value: int) = Interop.mkAttr "rowsPerPage" value
  /// Customizes the options of the rows per page select field. If less than two options are available, no select field will be displayed.
  static member inline rowsPerPageOptions ([<ParamArray>] values: int []) = Interop.mkAttr "rowsPerPageOptions" (ResizeArray values)
  /// Props applied to the rows per page [`Select`](https://material-ui.com/api/select/) element.
  static member inline SelectProps (props: IReactProperty list) = Interop.mkAttr "SelectProps" (createObj !!props)
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `tableCell`*
  ///
  /// Set scope attribute.
  static member inline scope (value: string) = Interop.mkAttr "scope" value

module tablePagination =

  /// *Inherited from `tableCell`*
  ///
  /// Set the text-align on the table cell content.
  ///
  /// Monetary or generally number fields **should be right aligned** as that allows you to add them up quickly in your head without having to worry about decimals.
  [<Erase>]
  type align =
    static member inline center = Interop.mkAttr "align" "center"
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline justify = Interop.mkAttr "align" "justify"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline right = Interop.mkAttr "align" "right"

  /// *Inherited from `tableCell`*
  ///
  /// Sets the padding applied to the cell. By default, the Table parent component set the value (`default`).
  [<Erase>]
  type padding =
    static member inline checkbox = Interop.mkAttr "padding" "checkbox"
    static member inline default' = Interop.mkAttr "padding" "default"
    static member inline none = Interop.mkAttr "padding" "none"

  /// *Inherited from `tableCell`*
  ///
  /// Specify the size of the cell. By default, the Table parent component set the value (`medium`).
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

  /// *Inherited from `tableCell`*
  ///
  /// Set aria-sort direction.
  [<Erase>]
  type sortDirection =
    static member inline asc = Interop.mkAttr "sortDirection" "asc"
    static member inline desc = Interop.mkAttr "sortDirection" "desc"
    static member inline false' = Interop.mkAttr "sortDirection" false

  /// *Inherited from `tableCell`*
  ///
  /// Specify the cell type. By default, the TableHead, TableBody or TableFooter parent component set the value.
  [<Erase>]
  type variant =
    static member inline body = Interop.mkAttr "variant" "body"
    static member inline footer = Interop.mkAttr "variant" "footer"
    static member inline head = Interop.mkAttr "variant" "head"


[<Erase>]
type tableRow =
  /// Should be valid `<tr>` children such as `TableCell`.
  static member inline children (element: ReactElement) = prop.children element
  /// Should be valid `<tr>` children such as `TableCell`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the table row will shade on hover.
  static member inline hover (value: bool) = Interop.mkAttr "hover" value
  /// If `true`, the table row will have the selected shading.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value


[<Erase>]
type tableSortLabel =
  /// If `true`, the label will have the active styling (should be true for the sorted column).
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
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)

module tableSortLabel =

  /// The current sort direction.
  [<Erase>]
  type direction =
    static member inline asc = Interop.mkAttr "direction" "asc"
    static member inline desc = Interop.mkAttr "direction" "desc"


[<Erase>]
type tabList =
  static member inline children (element: ReactElement) = prop.children element
  static member inline children (elements: ReactElement seq) = prop.children elements
  static member inline children (value: string) = Interop.mkAttr "children" value
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  static member inline children (value: int) = Interop.mkAttr "children" value
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// *Inherited from `tabs`*
  ///
  /// Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It supports two actions: `updateIndicator()` and `updateScrollButtons()`
  static member inline action (ref: IRefValue<TabsActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `tabs`*
  ///
  /// Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It supports two actions: `updateIndicator()` and `updateScrollButtons()`
  static member inline action (handler: TabsActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `tabs`*
  ///
  /// The label for the Tabs as a string.
  static member inline ariaLabel (value: string) = Interop.mkAttr "aria-label" value
  /// *Inherited from `tabs`*
  ///
  /// An id or list of ids separated by a space that label the Tabs.
  static member inline ariaLabelledby (value: string) = Interop.mkAttr "aria-labelledby" value
  /// *Inherited from `tabs`*
  ///
  /// If `true`, the tabs will be centered. This property is intended for large views.
  static member inline centered (value: bool) = Interop.mkAttr "centered" value
  /// *Inherited from `tabs`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `tabs`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `tabs`*
  ///
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* We default to the index of the child (number)
  static member inline onChange (handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// *Inherited from `tabs`*
  ///
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* We default to the index of the child (number)
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// *Inherited from `tabs`*
  ///
  /// The component used to render the scroll buttons.
  static member inline ScrollButtonComponent (value: ReactElementType) = Interop.mkAttr "ScrollButtonComponent" value
  /// *Inherited from `tabs`*
  ///
  /// If `true` the selected tab changes on focus. Otherwise it only changes on activation.
  static member inline selectionFollowsFocus (value: bool) = Interop.mkAttr "selectionFollowsFocus" value
  /// *Inherited from `tabs`*
  ///
  /// Props applied to the tab indicator element.
  static member inline TabIndicatorProps (props: IReactProperty list) = Interop.mkAttr "TabIndicatorProps" (createObj !!props)
  /// *Inherited from `tabs`*
  ///
  /// Props applied to the [`TabScrollButton`](https://material-ui.com/api/tab-scroll-button/) element.
  static member inline TabScrollButtonProps (props: IReactProperty list) = Interop.mkAttr "TabScrollButtonProps" (createObj !!props)
  /// *Inherited from `tabs`*
  ///
  /// The value of the currently selected `Tab`. If you don't want any selected `Tab`, you can set this property to `false`.
  static member inline value (value: 'a) = Interop.mkAttr "value" value

module tabList =

  /// *Inherited from `tabs`*
  ///
  /// Determines the color of the indicator.
  [<Erase>]
  type indicatorColor =
    static member inline primary = Interop.mkAttr "indicatorColor" "primary"
    static member inline secondary = Interop.mkAttr "indicatorColor" "secondary"

  /// *Inherited from `tabs`*
  ///
  /// The tabs orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// *Inherited from `tabs`*
  ///
  /// Determine behavior of scroll buttons when tabs are set to scroll:
  ///
  /// - `auto` will only present them when not all the items are visible. - `desktop` will only present them on medium and larger viewports. - `on` will always present them. - `off` will never present them.
  [<Erase>]
  type scrollButtons =
    static member inline auto = Interop.mkAttr "scrollButtons" "auto"
    static member inline desktop = Interop.mkAttr "scrollButtons" "desktop"
    static member inline off = Interop.mkAttr "scrollButtons" "off"
    static member inline on = Interop.mkAttr "scrollButtons" "on"

  /// *Inherited from `tabs`*
  ///
  /// Determines the color of the `Tab`.
  [<Erase>]
  type textColor =
    static member inline inherit' = Interop.mkAttr "textColor" "inherit"
    static member inline primary = Interop.mkAttr "textColor" "primary"
    static member inline secondary = Interop.mkAttr "textColor" "secondary"

  /// *Inherited from `tabs`*
  ///
  /// Determines additional display behavior of the tabs:
  ///
  ///  - `scrollable` will invoke scrolling properties and allow for horizontally scrolling (or swiping) of the tab bar. -`fullWidth` will make the tabs grow to use all the available space, which should be used for small views, like on mobile. - `standard` will render the default state.
  [<Erase>]
  type variant =
    static member inline fullWidth = Interop.mkAttr "variant" "fullWidth"
    static member inline scrollable = Interop.mkAttr "variant" "scrollable"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type tabPanel =
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
  /// The `value` of the corresponding `Tab`. Must use the index of the `Tab` when no `value` was passed to `Tab`.
  static member inline value (value: string) = Interop.mkAttr "value" value


[<Erase>]
type tabs =
  /// Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It supports two actions: `updateIndicator()` and `updateScrollButtons()`
  static member inline action (ref: IRefValue<TabsActions option>) = Interop.mkAttr "action" ref
  /// Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It supports two actions: `updateIndicator()` and `updateScrollButtons()`
  static member inline action (handler: TabsActions -> unit) = Interop.mkAttr "action" handler
  /// The label for the Tabs as a string.
  static member inline ariaLabel (value: string) = Interop.mkAttr "aria-label" value
  /// An id or list of ids separated by a space that label the Tabs.
  static member inline ariaLabelledby (value: string) = Interop.mkAttr "aria-labelledby" value
  /// If `true`, the tabs will be centered. This property is intended for large views.
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
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* We default to the index of the child (number)
  static member inline onChange (handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* We default to the index of the child (number)
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// The component used to render the scroll buttons.
  static member inline ScrollButtonComponent (value: ReactElementType) = Interop.mkAttr "ScrollButtonComponent" value
  /// If `true` the selected tab changes on focus. Otherwise it only changes on activation.
  static member inline selectionFollowsFocus (value: bool) = Interop.mkAttr "selectionFollowsFocus" value
  /// Props applied to the tab indicator element.
  static member inline TabIndicatorProps (props: IReactProperty list) = Interop.mkAttr "TabIndicatorProps" (createObj !!props)
  /// Props applied to the [`TabScrollButton`](https://material-ui.com/api/tab-scroll-button/) element.
  static member inline TabScrollButtonProps (props: IReactProperty list) = Interop.mkAttr "TabScrollButtonProps" (createObj !!props)
  /// The value of the currently selected `Tab`. If you don't want any selected `Tab`, you can set this property to `false`.
  static member inline value (value: 'a) = Interop.mkAttr "value" value

module tabs =

  /// Determines the color of the indicator.
  [<Erase>]
  type indicatorColor =
    static member inline primary = Interop.mkAttr "indicatorColor" "primary"
    static member inline secondary = Interop.mkAttr "indicatorColor" "secondary"

  /// The tabs orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// Determine behavior of scroll buttons when tabs are set to scroll:
  ///
  /// - `auto` will only present them when not all the items are visible. - `desktop` will only present them on medium and larger viewports. - `on` will always present them. - `off` will never present them.
  [<Erase>]
  type scrollButtons =
    static member inline auto = Interop.mkAttr "scrollButtons" "auto"
    static member inline desktop = Interop.mkAttr "scrollButtons" "desktop"
    static member inline off = Interop.mkAttr "scrollButtons" "off"
    static member inline on = Interop.mkAttr "scrollButtons" "on"

  /// Determines the color of the `Tab`.
  [<Erase>]
  type textColor =
    static member inline inherit' = Interop.mkAttr "textColor" "inherit"
    static member inline primary = Interop.mkAttr "textColor" "primary"
    static member inline secondary = Interop.mkAttr "textColor" "secondary"

  /// Determines additional display behavior of the tabs:
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
  /// If `true`, the element will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value

module tabScrollButton =

  /// Which direction should the button indicate?
  [<Erase>]
  type direction =
    static member inline left = Interop.mkAttr "direction" "left"
    static member inline right = Interop.mkAttr "direction" "right"

  /// The tabs orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"


[<Erase>]
type textareaAutosize =
  /// Use `rowsMin` instead. The prop will be removed in v5.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display.
  static member inline rowsMax (value: int) = Interop.mkAttr "rowsMax" value
  /// Minimum number of rows to display.
  static member inline rowsMin (value: int) = Interop.mkAttr "rowsMin" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type textField =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete (value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// The default value of the `input` element.
  static member inline defaultValue (value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the label will be displayed in an error state.
  static member inline error (value: bool) = Interop.mkAttr "error" value
  /// Props applied to the [`FormHelperText`](https://material-ui.com/api/form-helper-text/) element.
  static member inline FormHelperTextProps (props: IReactProperty list) = Interop.mkAttr "FormHelperTextProps" (createObj !!props)
  /// If `true`, the input will take up the full width of its container.
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
  /// The id of the `input` element. Use this prop to make `label` and `helperText` accessible for screen readers.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// Props applied to the [`InputLabel`](https://material-ui.com/api/input-label/) element.
  static member inline InputLabelProps (props: IReactProperty list) = Interop.mkAttr "InputLabelProps" (createObj !!props)
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps (props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Props applied to the Input element. It will be a [`FilledInput`](https://material-ui.com/api/filled-input/), [`OutlinedInput`](https://material-ui.com/api/outlined-input/) or [`Input`](https://material-ui.com/api/input/) component depending on the `variant` prop value.
  static member inline InputProps (props: IReactProperty list) = Interop.mkAttr "InputProps" (createObj !!props)
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: Element -> unit) = Interop.mkAttr "inputRef" handler
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
  /// If `true`, a textarea element will be rendered instead of an input.
  static member inline multiline (value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name (value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value` (string).
  static member inline onChange (handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder (value: string) = Interop.mkAttr "placeholder" value
  /// If `true`, the label is displayed as required and the `input` element` will be required.
  static member inline required (value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows (value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax (value: int) = Interop.mkAttr "rowsMax" value
  /// Render a [`Select`](https://material-ui.com/api/select/) element while passing the Input element to `Select` as `input` parameter. If this option is set you must pass the options of the select as children.
  static member inline select (value: bool) = Interop.mkAttr "select" value
  /// Props applied to the [`Select`](https://material-ui.com/api/select/) element.
  static member inline SelectProps (props: IReactProperty list) = Interop.mkAttr "SelectProps" (createObj !!props)
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type' (value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
  /// *Inherited from `formControl`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `formControl`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `formControl`*
  ///
  /// If `true`, the component will be displayed in focused state.
  static member inline focused (value: bool) = Interop.mkAttr "focused" value
  /// *Inherited from `formControl`*
  ///
  /// If `true`, the label will be hidden. This is used to increase density for a `FilledInput`. Be sure to add `aria-label` to the `input` element.
  static member inline hiddenLabel (value: bool) = Interop.mkAttr "hiddenLabel" value

module textField =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If `dense` or `normal`, will adjust vertical spacing of this and contained components.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"
    static member inline normal = Interop.mkAttr "margin" "normal"

  /// The size of the text field.
  [<Erase>]
  type size =
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"

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

module timeline =

  /// The position where the timeline's content should appear.
  [<Erase>]
  type align =
    static member inline alternate = Interop.mkAttr "align" "alternate"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline right = Interop.mkAttr "align" "right"


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

module timelineDot =

  /// The dot can have a different colors.
  [<Erase>]
  type color =
    static member inline grey = Interop.mkAttr "color" "grey"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The dot can appear filled or outlined.
  [<Erase>]
  type variant =
    static member inline default' = Interop.mkAttr "variant" "default"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


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


[<Erase>]
type toggleButton =
  /// The content of the button.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the button.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the button.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the button.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, the button will be disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled.
  static member inline disableFocusRipple (value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple (value: bool) = Interop.mkAttr "disableRipple" value
  /// If `true`, the button will be rendered in an active state.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  /// The value to associate with the button when selected in a ToggleButtonGroup.
  static member inline value (value: 'a) = Interop.mkAttr "value" value
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// *Inherited from `buttonBase`*
  ///
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action (handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple (value: bool) = Interop.mkAttr "centerRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// The component used for the root node. Either a string to use a HTML element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple (value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// If `true`, the base button will have a keyboard focus ripple.
  static member inline focusRipple (value: bool) = Interop.mkAttr "focusRipple" value
  /// *Inherited from `buttonBase`*
  ///
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName (value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// *Inherited from `buttonBase`*
  ///
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible (handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// *Inherited from `buttonBase`*
  ///
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps (props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)


[<Erase>]
type toggleButtonGroup =
  /// The content of the button.
  static member inline children (element: ReactElement) = prop.children element
  /// The content of the button.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// The content of the button.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// The content of the button.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, only allow one of the child ToggleButton values to be selected.
  static member inline exclusive (value: bool) = Interop.mkAttr "exclusive" value
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* of the selected buttons. When `exclusive` is true this is a single value; when false an array of selected values. If no value is selected and `exclusive` is true the value is null; when false an empty array.
  static member inline onChange (handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *value:* of the selected buttons. When `exclusive` is true this is a single value; when false an array of selected values. If no value is selected and `exclusive` is true the value is null; when false an empty array.
  static member inline onChange (handler: 'a -> unit) = Interop.mkAttr "onChange" (Func<_,_,_> (fun _ v -> handler v))
  /// The currently selected value within the group or an array of selected values when `exclusive` is false.
  ///
  /// The value must have reference equality with the option in order to be selected.
  static member inline value (value: 'toggleButtonValue option) = Interop.mkAttr "value" value
  /// The currently selected value within the group or an array of selected values when `exclusive` is false.
  ///
  /// The value must have reference equality with the option in order to be selected.
  static member inline value (values: 'toggleButtonValue []) = Interop.mkAttr "value" (ResizeArray values)

module toggleButtonGroup =

  /// The group orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The size of the buttons.
  [<Erase>]
  type size =
    static member inline large = Interop.mkAttr "size" "large"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline small = Interop.mkAttr "size" "small"


[<Erase>]
type toolbar =
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children (element: ReactElement) = prop.children element
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, disables gutter padding.
  static member inline disableGutters (value: bool) = Interop.mkAttr "disableGutters" value

module toolbar =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline regular = Interop.mkAttr "variant" "regular"
    static member inline dense = Interop.mkAttr "variant" "dense"


[<Erase>]
type tooltip =
  /// If `true`, adds an arrow to the tooltip.
  static member inline arrow (value: bool) = Interop.mkAttr "arrow" value
  /// Tooltip reference element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Do not respond to focus events.
  static member inline disableFocusListener (value: bool) = Interop.mkAttr "disableFocusListener" value
  /// Do not respond to hover events.
  static member inline disableHoverListener (value: bool) = Interop.mkAttr "disableHoverListener" value
  /// Do not respond to long press touch events.
  static member inline disableTouchListener (value: bool) = Interop.mkAttr "disableTouchListener" value
  /// The number of milliseconds to wait before showing the tooltip. This prop won't impact the enter touch delay (`enterTouchDelay`).
  static member inline enterDelay (value: int) = Interop.mkAttr "enterDelay" value
  /// The number of milliseconds to wait before showing the tooltip when one was already recently opened.
  static member inline enterNextDelay (value: int) = Interop.mkAttr "enterNextDelay" value
  /// The number of milliseconds a user must touch the element before showing the tooltip.
  static member inline enterTouchDelay (value: int) = Interop.mkAttr "enterTouchDelay" value
  /// This prop is used to help implement the accessibility logic. If you don't provide this prop. It falls back to a randomly generated id.
  static member inline id (value: string) = Interop.mkAttr "id" value
  /// Makes a tooltip interactive, i.e. will not close when the user hovers over the tooltip before the `leaveDelay` is expired.
  static member inline interactive (value: bool) = Interop.mkAttr "interactive" value
  /// The number of milliseconds to wait before hiding the tooltip. This prop won't impact the leave touch delay (`leaveTouchDelay`).
  static member inline leaveDelay (value: int) = Interop.mkAttr "leaveDelay" value
  /// The number of milliseconds after the user stops touching an element before hiding the tooltip.
  static member inline leaveTouchDelay (value: int) = Interop.mkAttr "leaveTouchDelay" value
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback fired when the component requests to be open.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback.
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// If `true`, the tooltip is shown.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// The component used for the popper.
  static member inline PopperComponent (value: ReactElementType) = Interop.mkAttr "PopperComponent" value
  /// Props applied to the [`Popper`](https://material-ui.com/api/popper/) element.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
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
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
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
  /// The id of the node.
  static member inline nodeId (value: string) = Interop.mkAttr "nodeId" value
  /// `onClick` handler for the icon container. Call `event.preventDefault()` to prevent `onNodeToggle` from being called.
  static member inline onIconClick (handler: Event -> unit) = Interop.mkAttr "onIconClick" handler
  /// `onClick` handler for the label container. Call `event.preventDefault()` to prevent `onNodeToggle` from being called.
  static member inline onLabelClick (handler: Event -> unit) = Interop.mkAttr "onLabelClick" handler
  /// The component used for the transition. [Follow this guide](https://material-ui.com/components/transitions/#transitioncomponent-prop) to learn more about the requirements for this component.
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Props applied to the [`Transition`](http://reactcommunity.org/react-transition-group/transition#Transition-props) element.
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
  /// The default icon displayed next to a end node. This is applied to all tree nodes and can be overridden by the TreeItem `icon` prop.
  static member inline defaultEndIcon (element: ReactElement) = Interop.mkAttr "defaultEndIcon" element
  /// Expanded node ids. (Uncontrolled)
  static member inline defaultExpanded ([<ParamArray>] nodeIds: string []) = Interop.mkAttr "defaultExpanded" nodeIds
  /// The default icon used to expand the node.
  static member inline defaultExpandIcon (element: ReactElement) = Interop.mkAttr "defaultExpandIcon" element
  /// The default icon displayed next to a parent node. This is applied to all parent nodes and can be overridden by the TreeItem `icon` prop.
  static member inline defaultParentIcon (element: ReactElement) = Interop.mkAttr "defaultParentIcon" element
  /// Selected node ids. (Uncontrolled) When `multiSelect` is true this takes an array of strings; when false (default) a string.
  static member inline defaultSelected (value: string) = Interop.mkAttr "defaultSelected" value
  /// Selected node ids. (Uncontrolled) When `multiSelect` is true this takes an array of strings; when false (default) a string.
  static member inline defaultSelected ([<ParamArray>] values: string []) = Interop.mkAttr "defaultSelected" values
  /// If `true` selection is disabled.
  static member inline disableSelection (value: bool) = Interop.mkAttr "disableSelection" value
  /// Expanded node ids. (Controlled)
  static member inline expanded ([<ParamArray>] nodeIds: string []) = Interop.mkAttr "expanded" nodeIds
  /// If true `ctrl` and `shift` will trigger multiselect.
  static member inline multiSelect (value: bool) = Interop.mkAttr "multiSelect" value
  /// Callback fired when tree items are selected/unselected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: array | string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* of the selected nodes. When `multiSelect` is true this is an array of strings; when false (default) a string.
  static member inline onNodeSelect (handler: Event -> string -> unit) = Interop.mkAttr "onNodeSelect" (Func<_,_,_> handler)
  /// Callback fired when tree items are selected/unselected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: array | string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* of the selected nodes. When `multiSelect` is true this is an array of strings; when false (default) a string.
  static member inline onNodeSelect (handler: Event -> string [] -> unit) = Interop.mkAttr "onNodeSelect" (Func<_,_,_> handler)
  /// Callback fired when tree items are expanded/collapsed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, nodeIds: array) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *nodeIds:* The ids of the expanded nodes.
  static member inline onNodeToggle (handler: Event -> string [] -> unit) = Interop.mkAttr "onNodeToggle" handler
  /// Selected node ids. (Controlled) When `multiSelect` is true this takes an array of strings; when false (default) a string.
  static member inline selected (value: string) = Interop.mkAttr "selected" value
  /// Selected node ids. (Controlled) When `multiSelect` is true this takes an array of strings; when false (default) a string.
  static member inline selected ([<ParamArray>] values: string []) = Interop.mkAttr "selected" values


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
  /// The component used for the root node. Either a string to use a HTML element or a component. Overrides the behavior of the `variantMapping` prop.
  static member inline component' (value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a HTML element or a component. Overrides the behavior of the `variantMapping` prop.
  static member inline component' (value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the text will have a bottom margin.
  static member inline gutterBottom (value: bool) = Interop.mkAttr "gutterBottom" value
  /// If `true`, the text will not wrap, but instead will truncate with a text overflow ellipsis.
  ///
  /// Note that text overflow can only happen with block or inline-block level elements (the element needs to have a width in order to overflow).
  static member inline noWrap (value: bool) = Interop.mkAttr "noWrap" value
  /// If `true`, the text will have a bottom margin.
  static member inline paragraph (value: bool) = Interop.mkAttr "paragraph" value
  /// The component maps the variant prop to a range of different HTML element types. For instance, subtitle1 to ``. If you wish to change that mapping, you can provide your own. Alternatively, you can use the `component` prop.
  static member inline variantMapping (?h1: string, ?h2: string, ?h3: string, ?h4: string, ?h5: string, ?h6: string, ?subtitle1: string, ?subtitle2: string, ?body1: string, ?body2: string) = Interop.mkAttr "variantMapping" (let x = createEmpty<obj> in (if h1.IsSome then x?``h1`` <- h1); (if h2.IsSome then x?``h2`` <- h2); (if h3.IsSome then x?``h3`` <- h3); (if h4.IsSome then x?``h4`` <- h4); (if h5.IsSome then x?``h5`` <- h5); (if h6.IsSome then x?``h6`` <- h6); (if subtitle1.IsSome then x?``subtitle1`` <- subtitle1); (if subtitle2.IsSome then x?``subtitle2`` <- subtitle2); (if body1.IsSome then x?``body1`` <- body1); (if body2.IsSome then x?``body2`` <- body2); x)

module typography =

  /// Set the text-align on the component.
  [<Erase>]
  type align =
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline center = Interop.mkAttr "align" "center"
    static member inline right = Interop.mkAttr "align" "right"
    static member inline justify = Interop.mkAttr "align" "justify"

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline initial = Interop.mkAttr "color" "initial"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline textPrimary = Interop.mkAttr "color" "textPrimary"
    static member inline textSecondary = Interop.mkAttr "color" "textSecondary"
    static member inline error = Interop.mkAttr "color" "error"

  /// Controls the display type
  [<Erase>]
  type display =
    static member inline initial = Interop.mkAttr "display" "initial"
    static member inline block = Interop.mkAttr "display" "block"
    static member inline inline' = Interop.mkAttr "display" "inline"

  /// Applies the theme typography styles.
  [<Erase>]
  type variant =
    static member inline h1 = Interop.mkAttr "variant" "h1"
    static member inline h2 = Interop.mkAttr "variant" "h2"
    static member inline h3 = Interop.mkAttr "variant" "h3"
    static member inline h4 = Interop.mkAttr "variant" "h4"
    static member inline h5 = Interop.mkAttr "variant" "h5"
    static member inline h6 = Interop.mkAttr "variant" "h6"
    static member inline subtitle1 = Interop.mkAttr "variant" "subtitle1"
    static member inline subtitle2 = Interop.mkAttr "variant" "subtitle2"
    static member inline body1 = Interop.mkAttr "variant" "body1"
    static member inline body2 = Interop.mkAttr "variant" "body2"
    static member inline caption = Interop.mkAttr "variant" "caption"
    static member inline button = Interop.mkAttr "variant" "button"
    static member inline overline = Interop.mkAttr "variant" "overline"
    static member inline srOnly = Interop.mkAttr "variant" "srOnly"
    static member inline inherit' = Interop.mkAttr "variant" "inherit"


[<Erase>]
type unstable_TrapFocus =
  /// A single child content element.
  static member inline children (element: ReactElement) = prop.children element
  /// A single child content element.
  static member inline children (elements: ReactElement seq) = prop.children elements
  /// A single child content element.
  static member inline children (value: string) = Interop.mkAttr "children" value
  /// A single child content element.
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  /// A single child content element.
  static member inline children (value: int) = Interop.mkAttr "children" value
  /// A single child content element.
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// If `true`, the trap focus will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any trap focus children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the trap focus less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus (value: bool) = Interop.mkAttr "disableAutoFocus" value
  /// If `true`, the trap focus will not prevent focus from leaving the trap focus while open.
  ///
  /// Generally this should never be set to `true` as it makes the trap focus less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus (value: bool) = Interop.mkAttr "disableEnforceFocus" value
  /// If `true`, the trap focus will not restore focus to previously focused element once trap focus is hidden.
  static member inline disableRestoreFocus (value: bool) = Interop.mkAttr "disableRestoreFocus" value
  /// Return the document to consider. We use it to implement the restore focus between different browser documents.
  static member inline getDoc (getDoc: unit -> Document) = Interop.mkAttr "getDoc" getDoc
  /// Do we still want to enforce the focus? This prop helps nesting TrapFocus elements.
  static member inline isEnabled (isEnabled: unit -> bool) = Interop.mkAttr "isEnabled" isEnabled
  /// If `true`, focus will be locked.
  static member inline open' (value: bool) = Interop.mkAttr "open" value


[<Erase>]
type zoom =
  /// A single child content element.
  static member inline children (value: ReactElement) = Interop.mkAttr "children" value
  /// Enable this prop if you encounter 'Function components cannot be given refs', use `unstable_createStrictModeTheme`, and can't forward the ref in the child component.
  static member inline disableStrictModeCompat (value: bool) = Interop.mkAttr "disableStrictModeCompat" value
  /// If `true`, the component will transition in.
  static member inline in' (value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout (?appear: int, ?enter: int, ?exit: int) = Interop.mkAttr "timeout" (let x = createEmpty<obj> in (if appear.IsSome then x?``appear`` <- appear); (if enter.IsSome then x?``enter`` <- enter); (if exit.IsSome then x?``exit`` <- exit); x)
