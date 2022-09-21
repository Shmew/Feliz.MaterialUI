namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module themeOverrides =

  module theme =

    module styleOverrides =

      [<Erase>]
      type muiAccordion =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAccordion", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordion.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element unless `square={true}`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordion.styleOverrides.rounded", createObj !!styles)
        /// State class applied to the root element if `expanded={true}`.
        static member inline expanded(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordion.styleOverrides.expanded", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordion.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordion.styleOverrides.gutters", createObj !!styles)
        /// Styles applied to the region element, the container of the children.
        static member inline region(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordion.styleOverrides.region", createObj !!styles)

      [<Erase>]
      type muiAccordionActions =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAccordionActions", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionActions.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element unless `disableSpacing={true}`.
        static member inline spacing(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionActions.styleOverrides.spacing", createObj !!styles)

      [<Erase>]
      type muiAccordionDetails =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAccordionDetails", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionDetails.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiAccordionSummary =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAccordionSummary", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionSummary.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
        static member inline expanded(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionSummary.styleOverrides.expanded", createObj !!styles)
        /// State class applied to the ButtonBase root element if the button is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionSummary.styleOverrides.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionSummary.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionSummary.styleOverrides.gutters", createObj !!styles)
        /// Styles applied to the children wrapper element unless `disableGutters={true}`.
        static member inline contentGutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionSummary.styleOverrides.contentGutters", createObj !!styles)
        /// Styles applied to the children wrapper element.
        static member inline content(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionSummary.styleOverrides.content", createObj !!styles)
        /// Styles applied to the `expandIcon`'s wrapper element.
        static member inline expandIconWrapper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAccordionSummary.styleOverrides.expandIconWrapper", createObj !!styles)

      [<Erase>]
      type muiAlert =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAlert", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.standard", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"` and `color="success"`.
        static member inline standardSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.standardSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"` and `color="info"`.
        static member inline standardInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.standardInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"` and `color="warning"`.
        static member inline standardWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.standardWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"` and `color="error"`.
        static member inline standardError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.standardError", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="success"`.
        static member inline outlinedSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.outlinedSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="info"`.
        static member inline outlinedInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.outlinedInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="warning"`.
        static member inline outlinedWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.outlinedWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="error"`.
        static member inline outlinedError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.outlinedError", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="success"`.
        static member inline filledSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.filledSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="info"`.
        static member inline filledInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.filledInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="warning"`.
        static member inline filledWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.filledWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="error"`.
        static member inline filledError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.filledError", createObj !!styles)
        /// Styles applied to the icon wrapper element.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.icon", createObj !!styles)
        /// Styles applied to the message wrapper element.
        static member inline message(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.message", createObj !!styles)
        /// Styles applied to the action wrapper element if `action` is provided.
        static member inline action(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlert.styleOverrides.action", createObj !!styles)

      [<Erase>]
      type muiAlertTitle =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAlertTitle", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAlertTitle.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiAppBar =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAppBar", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `position="fixed"`.
        static member inline positionFixed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.positionFixed", createObj !!styles)
        /// Styles applied to the root element if `position="absolute"`.
        static member inline positionAbsolute(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.positionAbsolute", createObj !!styles)
        /// Styles applied to the root element if `position="sticky"`.
        static member inline positionSticky(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.positionSticky", createObj !!styles)
        /// Styles applied to the root element if `position="static"`.
        static member inline positionStatic(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.positionStatic", createObj !!styles)
        /// Styles applied to the root element if `position="relative"`.
        static member inline positionRelative(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.positionRelative", createObj !!styles)
        /// Styles applied to the root element if `color="default"`.
        static member inline colorDefault(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.colorDefault", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `color="transparent"`.
        static member inline colorTransparent(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAppBar.styleOverrides.colorTransparent", createObj !!styles)

      [<Erase>]
      type muiAutocomplete =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAutocomplete", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.fullWidth", createObj !!styles)
        /// State class applied to the root element if focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.focused", createObj !!styles)
        /// Styles applied to the tag elements, e.g. the chips.
        static member inline tag(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.tag", createObj !!styles)
        /// Styles applied to the tag elements, e.g. the chips if `size="small"`.
        static member inline tagSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.tagSizeSmall", createObj !!styles)
        /// Styles applied to the tag elements, e.g. the chips if `size="medium"`.
        static member inline tagSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.tagSizeMedium", createObj !!styles)
        /// Styles applied when the popup icon is rendered.
        static member inline hasPopupIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.hasPopupIcon", createObj !!styles)
        /// Styles applied when the clear icon is rendered.
        static member inline hasClearIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.hasClearIcon", createObj !!styles)
        /// Styles applied to the Input element.
        static member inline inputRoot(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.inputRoot", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.input", createObj !!styles)
        /// Styles applied to the input element if the input is focused.
        static member inline inputFocused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.inputFocused", createObj !!styles)
        /// Styles applied to the endAdornment element.
        static member inline endAdornment(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.endAdornment", createObj !!styles)
        /// Styles applied to the clear indicator.
        static member inline clearIndicator(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.clearIndicator", createObj !!styles)
        /// Styles applied to the popup indicator.
        static member inline popupIndicator(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.popupIndicator", createObj !!styles)
        /// Styles applied to the popup indicator if the popup is open.
        static member inline popupIndicatorOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.popupIndicatorOpen", createObj !!styles)
        /// Styles applied to the popper element.
        static member inline popper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.popper", createObj !!styles)
        /// Styles applied to the popper element if `disablePortal={true}`.
        static member inline popperDisablePortal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.popperDisablePortal", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.paper", createObj !!styles)
        /// Styles applied to the listbox component.
        static member inline listbox(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.listbox", createObj !!styles)
        /// Styles applied to the loading wrapper.
        static member inline loading(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.loading", createObj !!styles)
        /// Styles applied to the no option wrapper.
        static member inline noOptions(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.noOptions", createObj !!styles)
        /// Styles applied to the option elements.
        static member inline option(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.option", createObj !!styles)
        /// Styles applied to the group's label elements.
        static member inline groupLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.groupLabel", createObj !!styles)
        /// Styles applied to the group's ul elements.
        static member inline groupUl(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAutocomplete.styleOverrides.groupUl", createObj !!styles)

      [<Erase>]
      type muiAvatar =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAvatar", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatar.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if not `src` or `srcSet`.
        static member inline colorDefault(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatar.styleOverrides.colorDefault", createObj !!styles)
        /// Styles applied to the root element if `variant="circular"`.
        static member inline circular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatar.styleOverrides.circular", createObj !!styles)
        /// Styles applied to the root element if `variant="rounded"`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatar.styleOverrides.rounded", createObj !!styles)
        /// Styles applied to the root element if `variant="square"`.
        static member inline square(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatar.styleOverrides.square", createObj !!styles)
        /// Styles applied to the img element if either `src` or `srcSet` is defined.
        static member inline img(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatar.styleOverrides.img", createObj !!styles)
        /// Styles applied to the fallback icon
        static member inline fallback(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatar.styleOverrides.fallback", createObj !!styles)

      [<Erase>]
      type muiAvatarGroup =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiAvatarGroup", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatarGroup.styleOverrides.root", createObj !!styles)
        /// Styles applied to the avatar elements.
        static member inline avatar(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiAvatarGroup.styleOverrides.avatar", createObj !!styles)

      [<Erase>]
      type muiBackdrop =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiBackdrop", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBackdrop.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `invisible={true}`.
        static member inline invisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBackdrop.styleOverrides.invisible", createObj !!styles)

      [<Erase>]
      type muiBadge =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiBadge", values)
        /// Class name applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.root", createObj !!styles)
        /// Class name applied to the badge `span` element.
        static member inline badge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.badge", createObj !!styles)
        /// Class name applied to the badge `span` element if `variant="dot"`.
        static member inline dot(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.dot", createObj !!styles)
        /// Class name applied to the badge `span` element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.standard", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }}`.
        static member inline anchorOriginTopRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginTopRight", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }}`.
        static member inline anchorOriginBottomRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginBottomRight", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }}`.
        static member inline anchorOriginTopLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginTopLeft", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }}`.
        static member inline anchorOriginBottomLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginBottomLeft", createObj !!styles)
        /// State class applied to the badge `span` element if `invisible={true}`.
        static member inline invisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.invisible", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="error"`.
        static member inline colorError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.colorError", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="info"`.
        static member inline colorInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.colorInfo", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="success"`.
        static member inline colorSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.colorSuccess", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="warning"`.
        static member inline colorWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.colorWarning", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }} overlap="rectangular"`.
        static member inline anchorOriginTopRightRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginTopRightRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }} overlap="rectangular"`.
        static member inline anchorOriginBottomRightRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginBottomRightRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }} overlap="rectangular"`.
        static member inline anchorOriginTopLeftRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginTopLeftRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }} overlap="rectangular"`.
        static member inline anchorOriginBottomLeftRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginBottomLeftRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }} overlap="circular"`.
        static member inline anchorOriginTopRightCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginTopRightCircular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }} overlap="circular"`.
        static member inline anchorOriginBottomRightCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginBottomRightCircular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }} overlap="circular"`.
        static member inline anchorOriginTopLeftCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginTopLeftCircular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }} overlap="circular"`.
        static member inline anchorOriginBottomLeftCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.anchorOriginBottomLeftCircular", createObj !!styles)
        /// Class name applied to the badge `span` element if `overlap="rectangular"`.
        static member inline overlapRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.overlapRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `overlap="circular"`.
        static member inline overlapCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBadge.styleOverrides.overlapCircular", createObj !!styles)

      [<Erase>]
      type muiBottomNavigation =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiBottomNavigation", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBottomNavigation.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiBottomNavigationAction =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiBottomNavigationAction", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBottomNavigationAction.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if selected.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBottomNavigationAction.styleOverrides.selected", createObj !!styles)
        /// State class applied to the root element if `showLabel={false}` and not selected.
        static member inline iconOnly(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBottomNavigationAction.styleOverrides.iconOnly", createObj !!styles)
        /// Styles applied to the label's span element.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBottomNavigationAction.styleOverrides.label", createObj !!styles)

      [<Erase>]
      type muiBreadcrumbs =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiBreadcrumbs", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBreadcrumbs.styleOverrides.root", createObj !!styles)
        /// Styles applied to the ol element.
        static member inline ol(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBreadcrumbs.styleOverrides.ol", createObj !!styles)
        /// Styles applied to the li element.
        static member inline li(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBreadcrumbs.styleOverrides.li", createObj !!styles)
        /// Styles applied to the separator element.
        static member inline separator(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiBreadcrumbs.styleOverrides.separator", createObj !!styles)

      [<Erase>]
      type muiButton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiButton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.text", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="inherit"`.
        static member inline textInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="primary"`.
        static member inline textPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
        static member inline textSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="success"`.
        static member inline textSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="error"`.
        static member inline textError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textError", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="info"`.
        static member inline textInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="warning"`.
        static member inline textWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="inherit"`.
        static member inline outlinedInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="success"`.
        static member inline outlinedSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="error"`.
        static member inline outlinedError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedError", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="info"`.
        static member inline outlinedInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="warning"`.
        static member inline outlinedWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"`.
        static member inline contained(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.contained", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="inherit"`.
        static member inline containedInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
        static member inline containedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
        static member inline containedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="success"`.
        static member inline containedSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="info"`.
        static member inline containedInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="error"`.
        static member inline containedError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedError", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="warning"`.
        static member inline containedWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedWarning", createObj !!styles)
        /// Styles applied to the root element if `disableElevation={true}`.
        static member inline disableElevation(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.disableElevation", createObj !!styles)
        /// State class applied to the ButtonBase root element if the button is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="text"`.
        static member inline textSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="text"`.
        static member inline textSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="text"`.
        static member inline textSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.textSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="outlined"`.
        static member inline outlinedSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="outlined"`.
        static member inline outlinedSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="outlined"`.
        static member inline outlinedSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.outlinedSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="contained"`.
        static member inline containedSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="contained"`.
        static member inline containedSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="contained"`.
        static member inline containedSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.containedSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.sizeLarge", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.fullWidth", createObj !!styles)
        /// Styles applied to the startIcon element if supplied.
        static member inline startIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.startIcon", createObj !!styles)
        /// Styles applied to the endIcon element if supplied.
        static member inline endIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.endIcon", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="small"`.
        static member inline iconSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.iconSizeSmall", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="medium"`.
        static member inline iconSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.iconSizeMedium", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="large"`.
        static member inline iconSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButton.styleOverrides.iconSizeLarge", createObj !!styles)

      [<Erase>]
      type muiButtonBase =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiButtonBase", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonBase.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonBase.styleOverrides.disabled", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonBase.styleOverrides.focusVisible", createObj !!styles)

      [<Erase>]
      type muiButtonGroup =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiButtonGroup", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"`.
        static member inline contained(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.contained", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.text", createObj !!styles)
        /// Styles applied to the root element if `disableElevation={true}`.
        static member inline disableElevation(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.disableElevation", createObj !!styles)
        /// State class applied to the child elements if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.fullWidth", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.vertical", createObj !!styles)
        /// Styles applied to the children.
        static member inline grouped(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.grouped", createObj !!styles)
        /// Styles applied to the children if `orientation="horizontal"`.
        static member inline groupedHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedHorizontal", createObj !!styles)
        /// Styles applied to the children if `orientation="vertical"`.
        static member inline groupedVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedVertical", createObj !!styles)
        /// Styles applied to the children if `variant="text"`.
        static member inline groupedText(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedText", createObj !!styles)
        /// Styles applied to the children if `variant="text"` and `orientation="horizontal"`.
        static member inline groupedTextHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedTextHorizontal", createObj !!styles)
        /// Styles applied to the children if `variant="text"` and `orientation="vertical"`.
        static member inline groupedTextVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedTextVertical", createObj !!styles)
        /// Styles applied to the children if `variant="text"` and `color="primary"`.
        static member inline groupedTextPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedTextPrimary", createObj !!styles)
        /// Styles applied to the children if `variant="text"` and `color="secondary"`.
        static member inline groupedTextSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedTextSecondary", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"`.
        static member inline groupedOutlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedOutlined", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"` and `orientation="horizontal"`.
        static member inline groupedOutlinedHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedOutlinedHorizontal", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"` and `orientation="vertical"`.
        static member inline groupedOutlinedVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedOutlinedVertical", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"` and `color="primary"`.
        static member inline groupedOutlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedOutlinedPrimary", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"` and `color="secondary"`.
        static member inline groupedOutlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedOutlinedSecondary", createObj !!styles)
        /// Styles applied to the children if `variant="contained"`.
        static member inline groupedContained(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedContained", createObj !!styles)
        /// Styles applied to the children if `variant="contained"` and `orientation="horizontal"`.
        static member inline groupedContainedHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedContainedHorizontal", createObj !!styles)
        /// Styles applied to the children if `variant="contained"` and `orientation="vertical"`.
        static member inline groupedContainedVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedContainedVertical", createObj !!styles)
        /// Styles applied to the children if `variant="contained"` and `color="primary"`.
        static member inline groupedContainedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedContainedPrimary", createObj !!styles)
        /// Styles applied to the children if `variant="contained"` and `color="secondary"`.
        static member inline groupedContainedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiButtonGroup.styleOverrides.groupedContainedSecondary", createObj !!styles)

      [<Erase>]
      type muiCard =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCard", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCard.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiCardActionArea =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCardActionArea", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardActionArea.styleOverrides.root", createObj !!styles)
        /// State class applied to the ButtonBase root element if the action area is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardActionArea.styleOverrides.focusVisible", createObj !!styles)
        /// Styles applied to the overlay that covers the action area when it is keyboard focused.
        static member inline focusHighlight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardActionArea.styleOverrides.focusHighlight", createObj !!styles)

      [<Erase>]
      type muiCardActions =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCardActions", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardActions.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element unless `disableSpacing={true}`.
        static member inline spacing(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardActions.styleOverrides.spacing", createObj !!styles)

      [<Erase>]
      type muiCardContent =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCardContent", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardContent.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiCardHeader =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCardHeader", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardHeader.styleOverrides.root", createObj !!styles)
        /// Styles applied to the avatar element.
        static member inline avatar(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardHeader.styleOverrides.avatar", createObj !!styles)
        /// Styles applied to the action element.
        static member inline action(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardHeader.styleOverrides.action", createObj !!styles)
        /// Styles applied to the content wrapper element.
        static member inline content(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardHeader.styleOverrides.content", createObj !!styles)
        /// Styles applied to the title Typography element.
        static member inline title(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardHeader.styleOverrides.title", createObj !!styles)
        /// Styles applied to the subheader Typography element.
        static member inline subheader(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardHeader.styleOverrides.subheader", createObj !!styles)

      [<Erase>]
      type muiCardMedia =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCardMedia", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardMedia.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.
        static member inline media(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardMedia.styleOverrides.media", createObj !!styles)
        /// Styles applied to the root element if `component="picture or img"`.
        static member inline img(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCardMedia.styleOverrides.img", createObj !!styles)

      [<Erase>]
      type muiCheckbox =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCheckbox", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCheckbox.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `checked={true}`.
        static member inline checked'(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCheckbox.styleOverrides.checked", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCheckbox.styleOverrides.disabled", createObj !!styles)
        /// State class applied to the root element if `indeterminate={true}`.
        static member inline indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCheckbox.styleOverrides.indeterminate", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCheckbox.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCheckbox.styleOverrides.colorSecondary", createObj !!styles)

      [<Erase>]
      type muiChip =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiChip", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.colorSecondary", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `onClick` is defined or `clickable={true}`.
        static member inline clickable(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.clickable", createObj !!styles)
        /// Styles applied to the root element if `onClick` and `color="primary"` is defined or `clickable={true}`.
        static member inline clickableColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.clickableColorPrimary", createObj !!styles)
        /// Styles applied to the root element if `onClick` and `color="secondary"` is defined or `clickable={true}`.
        static member inline clickableColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.clickableColorSecondary", createObj !!styles)
        /// Styles applied to the root element if `onDelete` is defined.
        static member inline deletable(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deletable", createObj !!styles)
        /// Styles applied to the root element if `onDelete` and `color="primary"` is defined.
        static member inline deletableColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deletableColorPrimary", createObj !!styles)
        /// Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
        static member inline deletableColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deletableColorSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.outlinedSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="primary"`.
        static member inline filledPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.filledPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="secondary"`.
        static member inline filledSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.filledSecondary", createObj !!styles)
        /// Styles applied to the avatar element.
        static member inline avatar(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.avatar", createObj !!styles)
        /// Styles applied to the avatar element if `size="small"`.
        static member inline avatarSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.avatarSmall", createObj !!styles)
        /// Styles applied to the avatar element if `size="medium"`.
        static member inline avatarMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.avatarMedium", createObj !!styles)
        /// Styles applied to the avatar element if `color="primary"`.
        static member inline avatarColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.avatarColorPrimary", createObj !!styles)
        /// Styles applied to the avatar element if `color="secondary"`.
        static member inline avatarColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.avatarColorSecondary", createObj !!styles)
        /// Styles applied to the icon element.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.icon", createObj !!styles)
        /// Styles applied to the icon element if `size="small"`.
        static member inline iconSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.iconSmall", createObj !!styles)
        /// Styles applied to the icon element if `size="medium"`.
        static member inline iconMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.iconMedium", createObj !!styles)
        /// Styles applied to the icon element if `color="primary"`.
        static member inline iconColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.iconColorPrimary", createObj !!styles)
        /// Styles applied to the icon element if `color="secondary"`.
        static member inline iconColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.iconColorSecondary", createObj !!styles)
        /// Styles applied to the label `span` element.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.label", createObj !!styles)
        /// Styles applied to the label `span` element if `size="small"`.
        static member inline labelSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.labelSmall", createObj !!styles)
        /// Styles applied to the label `span` element if `size="medium"`.
        static member inline labelMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.labelMedium", createObj !!styles)
        /// Styles applied to the deleteIcon element.
        static member inline deleteIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIcon", createObj !!styles)
        /// Styles applied to the deleteIcon element if `size="small"`.
        static member inline deleteIconSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIconSmall", createObj !!styles)
        /// Styles applied to the deleteIcon element if `size="medium"`.
        static member inline deleteIconMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIconMedium", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="primary"` and `variant="filled"`.
        static member inline deleteIconColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIconColorPrimary", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="filled"`.
        static member inline deleteIconColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIconColorSecondary", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
        static member inline deleteIconOutlinedColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIconOutlinedColorPrimary", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.
        static member inline deleteIconOutlinedColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIconOutlinedColorSecondary", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="primary"` and `variant="filled"`.
        static member inline deleteIconFilledColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIconFilledColorPrimary", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="filled"`.
        static member inline deleteIconFilledColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.deleteIconFilledColorSecondary", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiChip.styleOverrides.focusVisible", createObj !!styles)

      [<Erase>]
      type muiCircularProgress =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCircularProgress", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="determinate"`.
        static member inline determinate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.determinate", createObj !!styles)
        /// Styles applied to the root element if `variant="indeterminate"`.
        static member inline indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.indeterminate", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the svg element.
        static member inline svg(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.svg", createObj !!styles)
        /// Styles applied to the `circle` svg path.
        static member inline circle(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.circle", createObj !!styles)
        /// Styles applied to the `circle` svg path if `variant="determinate"`.
        static member inline circleDeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.circleDeterminate", createObj !!styles)
        /// Styles applied to the `circle` svg path if `variant="indeterminate"`.
        static member inline circleIndeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.circleIndeterminate", createObj !!styles)
        /// Styles applied to the `circle` svg path if `disableShrink={true}`.
        static member inline circleDisableShrink(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCircularProgress.styleOverrides.circleDisableShrink", createObj !!styles)

      [<Erase>]
      type muiCollapse =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCollapse", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCollapse.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCollapse.styleOverrides.horizontal", createObj !!styles)
        /// Styles applied to the root element when the transition has entered.
        static member inline entered(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCollapse.styleOverrides.entered", createObj !!styles)
        /// Styles applied to the root element when the transition has exited and `collapsedSize` = 0px.
        static member inline hidden(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCollapse.styleOverrides.hidden", createObj !!styles)
        /// Styles applied to the outer wrapper element.
        static member inline wrapper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCollapse.styleOverrides.wrapper", createObj !!styles)
        /// Styles applied to the inner wrapper element.
        static member inline wrapperInner(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCollapse.styleOverrides.wrapperInner", createObj !!styles)

      [<Erase>]
      type muiContainer =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiContainer", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiContainer.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `disableGutters={true}`.
        static member inline disableGutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiContainer.styleOverrides.disableGutters", createObj !!styles)
        /// Styles applied to the root element if `fixed={true}`.
        static member inline fixed'(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiContainer.styleOverrides.fixed", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="xs"`.
        static member inline maxWidthXs(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiContainer.styleOverrides.maxWidthXs", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="sm"`.
        static member inline maxWidthSm(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiContainer.styleOverrides.maxWidthSm", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="md"`.
        static member inline maxWidthMd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiContainer.styleOverrides.maxWidthMd", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="lg"`.
        static member inline maxWidthLg(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiContainer.styleOverrides.maxWidthLg", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="xl"`.
        static member inline maxWidthXl(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiContainer.styleOverrides.maxWidthXl", createObj !!styles)

      [<Erase>]
      type muiDialog =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDialog", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.root", createObj !!styles)
        /// Styles applied to the container element if `scroll="paper"`.
        static member inline scrollPaper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.scrollPaper", createObj !!styles)
        /// Styles applied to the container element if `scroll="body"`.
        static member inline scrollBody(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.scrollBody", createObj !!styles)
        /// Styles applied to the container element.
        static member inline container(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.container", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paper", createObj !!styles)
        /// Styles applied to the Paper component if `scroll="paper"`.
        static member inline paperScrollPaper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperScrollPaper", createObj !!styles)
        /// Styles applied to the Paper component if `scroll="body"`.
        static member inline paperScrollBody(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperScrollBody", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth=false`.
        static member inline paperWidthFalse(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperWidthFalse", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="xs"`.
        static member inline paperWidthXs(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperWidthXs", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="sm"`.
        static member inline paperWidthSm(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperWidthSm", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="md"`.
        static member inline paperWidthMd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperWidthMd", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="lg"`.
        static member inline paperWidthLg(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperWidthLg", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="xl"`.
        static member inline paperWidthXl(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperWidthXl", createObj !!styles)
        /// Styles applied to the Paper component if `fullWidth={true}`.
        static member inline paperFullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperFullWidth", createObj !!styles)
        /// Styles applied to the Paper component if `fullScreen={true}`.
        static member inline paperFullScreen(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialog.styleOverrides.paperFullScreen", createObj !!styles)

      [<Erase>]
      type muiDialogActions =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDialogActions", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialogActions.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element unless `disableSpacing={true}`.
        static member inline spacing(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialogActions.styleOverrides.spacing", createObj !!styles)

      [<Erase>]
      type muiDialogContent =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDialogContent", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialogContent.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `dividers={true}`.
        static member inline dividers(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialogContent.styleOverrides.dividers", createObj !!styles)

      [<Erase>]
      type muiDialogContentText =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDialogContentText", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialogContentText.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiDialogTitle =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDialogTitle", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDialogTitle.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiDivider =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDivider", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `absolute={true}`.
        static member inline absolute(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.absolute", createObj !!styles)
        /// Styles applied to the root element if `variant="inset"`.
        static member inline inset(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.inset", createObj !!styles)
        /// Styles applied to the root element if `variant="fullWidth"`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.fullWidth", createObj !!styles)
        /// Styles applied to the root element if `light={true}`.
        static member inline light(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.light", createObj !!styles)
        /// Styles applied to the root element if `variant="middle"`.
        static member inline middle(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.middle", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.vertical", createObj !!styles)
        /// Styles applied to the root element if `flexItem={true}`.
        static member inline flexItem(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.flexItem", createObj !!styles)
        /// Styles applied to the root element if divider have text.
        static member inline withChildren(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.withChildren", createObj !!styles)
        /// Styles applied to the root element if divider have text and `orientation="vertical"`.
        static member inline withChildrenVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.withChildrenVertical", createObj !!styles)
        /// Styles applied to the root element if `textAlign="right" orientation="horizontal"`.
        static member inline textAlignRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.textAlignRight", createObj !!styles)
        /// Styles applied to the root element if `textAlign="left" orientation="horizontal"`.
        static member inline textAlignLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.textAlignLeft", createObj !!styles)
        /// Styles applied to the span children element if `orientation="horizontal"`.
        static member inline wrapper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.wrapper", createObj !!styles)
        /// Styles applied to the span children element if `orientation="vertical"`.
        static member inline wrapperVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDivider.styleOverrides.wrapperVertical", createObj !!styles)

      [<Erase>]
      type muiDrawer =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDrawer", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="permanent or persistent"`.
        static member inline docked(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.docked", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paper", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="left"`.
        static member inline paperAnchorLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paperAnchorLeft", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="right"`.
        static member inline paperAnchorRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paperAnchorRight", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="top"`.
        static member inline paperAnchorTop(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paperAnchorTop", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="bottom"`.
        static member inline paperAnchorBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paperAnchorBottom", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="left"` and `variant` is not "temporary".
        static member inline paperAnchorDockedLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paperAnchorDockedLeft", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="top"` and `variant` is not "temporary".
        static member inline paperAnchorDockedTop(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paperAnchorDockedTop", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="right"` and `variant` is not "temporary".
        static member inline paperAnchorDockedRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paperAnchorDockedRight", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="bottom"` and `variant` is not "temporary".
        static member inline paperAnchorDockedBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.paperAnchorDockedBottom", createObj !!styles)
        /// Styles applied to the Modal component.
        static member inline modal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDrawer.styleOverrides.modal", createObj !!styles)

      [<Erase>]
      type muiFab =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiFab", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline primary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.primary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline secondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.secondary", createObj !!styles)
        /// Styles applied to the root element if `variant="extended"`.
        static member inline extended(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.extended", createObj !!styles)
        /// Styles applied to the root element if `variant="circular"`.
        static member inline circular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.circular", createObj !!styles)
        /// State class applied to the ButtonBase root element if the button is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `size="small"``.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"``.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFab.styleOverrides.sizeMedium", createObj !!styles)

      [<Erase>]
      type muiFilledInput =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiFilledInput", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if color secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element unless `disableUnderline={true}`.
        static member inline underline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.underline", createObj !!styles)
        /// State class applied to the root element if the component is focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.focused", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `startAdornment` is provided.
        static member inline adornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.adornedStart", createObj !!styles)
        /// Styles applied to the root element if `endAdornment` is provided.
        static member inline adornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.adornedEnd", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.error", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `multiline={true}`.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.multiline", createObj !!styles)
        /// Styles applied to the root element if `hiddenLabel={true}`.
        static member inline hiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.hiddenLabel", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.input", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline inputSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.inputSizeSmall", createObj !!styles)
        /// Styles applied to the `input` if in `  `.
        static member inline inputHiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.inputHiddenLabel", createObj !!styles)
        /// Styles applied to the input element if `multiline={true}`.
        static member inline inputMultiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.inputMultiline", createObj !!styles)
        /// Styles applied to the input element if `startAdornment` is provided.
        static member inline inputAdornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.inputAdornedStart", createObj !!styles)
        /// Styles applied to the input element if `endAdornment` is provided.
        static member inline inputAdornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFilledInput.styleOverrides.inputAdornedEnd", createObj !!styles)

      [<Erase>]
      type muiFormControl =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiFormControl", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControl.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `margin="normal"`.
        static member inline marginNormal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControl.styleOverrides.marginNormal", createObj !!styles)
        /// Styles applied to the root element if `margin="dense"`.
        static member inline marginDense(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControl.styleOverrides.marginDense", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControl.styleOverrides.fullWidth", createObj !!styles)

      [<Erase>]
      type muiFormControlLabel =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiFormControlLabel", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControlLabel.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `labelPlacement="start"`.
        static member inline labelPlacementStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControlLabel.styleOverrides.labelPlacementStart", createObj !!styles)
        /// Styles applied to the root element if `labelPlacement="top"`.
        static member inline labelPlacementTop(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControlLabel.styleOverrides.labelPlacementTop", createObj !!styles)
        /// Styles applied to the root element if `labelPlacement="bottom"`.
        static member inline labelPlacementBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControlLabel.styleOverrides.labelPlacementBottom", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControlLabel.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the label's Typography component.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControlLabel.styleOverrides.label", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormControlLabel.styleOverrides.error", createObj !!styles)

      [<Erase>]
      type muiFormGroup =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiFormGroup", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormGroup.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `row={true}`.
        static member inline row(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormGroup.styleOverrides.row", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormGroup.styleOverrides.error", createObj !!styles)

      [<Erase>]
      type muiFormHelperText =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiFormHelperText", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormHelperText.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormHelperText.styleOverrides.error", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormHelperText.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormHelperText.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
        static member inline contained(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormHelperText.styleOverrides.contained", createObj !!styles)
        /// State class applied to the root element if `focused={true}`.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormHelperText.styleOverrides.focused", createObj !!styles)
        /// State class applied to the root element if `filled={true}`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormHelperText.styleOverrides.filled", createObj !!styles)
        /// State class applied to the root element if `required={true}`.
        static member inline required(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormHelperText.styleOverrides.required", createObj !!styles)

      [<Erase>]
      type muiFormLabel =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiFormLabel", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormLabel.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if the color is secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormLabel.styleOverrides.colorSecondary", createObj !!styles)
        /// State class applied to the root element if `focused={true}`.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormLabel.styleOverrides.focused", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormLabel.styleOverrides.disabled", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormLabel.styleOverrides.error", createObj !!styles)
        /// State class applied to the root element if `filled={true}`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormLabel.styleOverrides.filled", createObj !!styles)
        /// State class applied to the root element if `required={true}`.
        static member inline required(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormLabel.styleOverrides.required", createObj !!styles)
        /// Styles applied to the asterisk element.
        static member inline asterisk(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiFormLabel.styleOverrides.asterisk", createObj !!styles)

      [<Erase>]
      type muiGrid =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiGrid", values)
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.root", createObj !!styles)
        static member inline container(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.container", createObj !!styles)
        static member inline item(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.item", createObj !!styles)
        static member inline zeroMinWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.zeroMinWidth", createObj !!styles)
        static member inline directionXsColumn(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.direction-xs-column", createObj !!styles)
        static member inline directionXsColumnReverse(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.direction-xs-column-reverse", createObj !!styles)
        static member inline directionXsRowReverse(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.direction-xs-row-reverse", createObj !!styles)
        static member inline wrapXsNowrap(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.wrap-xs-nowrap", createObj !!styles)
        static member inline wrapXsWrapReverse(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.wrap-xs-wrap-reverse", createObj !!styles)
        static member inline spacingXs1(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-1", createObj !!styles)
        static member inline spacingXs2(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-2", createObj !!styles)
        static member inline spacingXs3(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-3", createObj !!styles)
        static member inline spacingXs4(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-4", createObj !!styles)
        static member inline spacingXs5(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-5", createObj !!styles)
        static member inline spacingXs6(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-6", createObj !!styles)
        static member inline spacingXs7(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-7", createObj !!styles)
        static member inline spacingXs8(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-8", createObj !!styles)
        static member inline spacingXs9(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-9", createObj !!styles)
        static member inline spacingXs10(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.spacing-xs-10", createObj !!styles)
        static member inline gridXsAuto(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-auto", createObj !!styles)
        static member inline gridXsTrue(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-true", createObj !!styles)
        static member inline gridXs1(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-1", createObj !!styles)
        static member inline gridXs2(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-2", createObj !!styles)
        static member inline gridXs3(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-3", createObj !!styles)
        static member inline gridXs4(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-4", createObj !!styles)
        static member inline gridXs5(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-5", createObj !!styles)
        static member inline gridXs6(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-6", createObj !!styles)
        static member inline gridXs7(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-7", createObj !!styles)
        static member inline gridXs8(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-8", createObj !!styles)
        static member inline gridXs9(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-9", createObj !!styles)
        static member inline gridXs10(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-10", createObj !!styles)
        static member inline gridXs11(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-11", createObj !!styles)
        static member inline gridXs12(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiGrid.styleOverrides.grid-xs-12", createObj !!styles)

      [<Erase>]
      type muiIcon =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiIcon", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `color="action"`.
        static member inline colorAction(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.colorAction", createObj !!styles)
        /// Styles applied to the root element if `color="error"`.
        static member inline colorError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.colorError", createObj !!styles)
        /// Styles applied to the root element if `color="disabled"`.
        static member inline colorDisabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.colorDisabled", createObj !!styles)
        /// Styles applied to the root element if `fontSize="inherit"`.
        static member inline fontSizeInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.fontSizeInherit", createObj !!styles)
        /// Styles applied to the root element if `fontSize="small"`.
        static member inline fontSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.fontSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `fontSize="large"`.
        static member inline fontSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIcon.styleOverrides.fontSizeLarge", createObj !!styles)

      [<Erase>]
      type muiIconButton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiIconButton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `edge="start"`.
        static member inline edgeStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.edgeStart", createObj !!styles)
        /// Styles applied to the root element if `edge="end"`.
        static member inline edgeEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.edgeEnd", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.colorSecondary", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiIconButton.styleOverrides.sizeLarge", createObj !!styles)

      [<Erase>]
      type muiImageList =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiImageList", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageList.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="masonry"`.
        static member inline masonry(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageList.styleOverrides.masonry", createObj !!styles)
        /// Styles applied to the root element if `variant="quilted"`.
        static member inline quilted(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageList.styleOverrides.quilted", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageList.styleOverrides.standard", createObj !!styles)
        /// Styles applied to the root element if `variant="woven"`.
        static member inline woven(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageList.styleOverrides.woven", createObj !!styles)

      [<Erase>]
      type muiImageListItem =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiImageListItem", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItem.styleOverrides.root", createObj !!styles)
        /// Styles applied to an `img` element to ensure it covers the item.
        static member inline img(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItem.styleOverrides.img", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItem.styleOverrides.standard", createObj !!styles)
        /// Styles applied to the root element if `variant="woven"`.
        static member inline woven(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItem.styleOverrides.woven", createObj !!styles)
        /// Styles applied to the root element if `variant="masonry"`.
        static member inline masonry(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItem.styleOverrides.masonry", createObj !!styles)
        /// Styles applied to the root element if `variant="quilted"`.
        static member inline quilted(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItem.styleOverrides.quilted", createObj !!styles)

      [<Erase>]
      type muiImageListItemBar =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiImageListItemBar", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `position="bottom"`.
        static member inline positionBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.positionBottom", createObj !!styles)
        /// Styles applied to the root element if `position="top"`.
        static member inline positionTop(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.positionTop", createObj !!styles)
        /// Styles applied to the root element if `position="below"`.
        static member inline positionBelow(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.positionBelow", createObj !!styles)
        /// Styles applied to the title and subtitle container element.
        static member inline titleWrap(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.titleWrap", createObj !!styles)
        /// Styles applied to the title and subtitle container element if `position="below"`.
        static member inline titleWrapBelow(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.titleWrapBelow", createObj !!styles)
        /// Styles applied to the container element if `actionPosition="left"`.
        static member inline titleWrapActionPosLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.titleWrapActionPosLeft", createObj !!styles)
        /// Styles applied to the container element if `actionPosition="right"`.
        static member inline titleWrapActionPosRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.titleWrapActionPosRight", createObj !!styles)
        /// Styles applied to the title container element.
        static member inline title(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.title", createObj !!styles)
        /// Styles applied to the subtitle container element.
        static member inline subtitle(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.subtitle", createObj !!styles)
        /// Styles applied to the actionIcon if supplied.
        static member inline actionIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.actionIcon", createObj !!styles)
        /// Styles applied to the actionIcon if `actionPosition="left"`.
        static member inline actionIconActionPosLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiImageListItemBar.styleOverrides.actionIconActionPosLeft", createObj !!styles)

      [<Erase>]
      type muiInput =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiInput", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if the component is a descendant of `FormControl`.
        static member inline formControl(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.formControl", createObj !!styles)
        /// Styles applied to the root element if the component is focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.focused", createObj !!styles)
        /// Styles applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if color secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element unless `disableUnderline={true}`.
        static member inline underline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.underline", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.error", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `multiline={true}`.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.multiline", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.fullWidth", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.input", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline inputSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.inputSizeSmall", createObj !!styles)
        /// Styles applied to the input element if `multiline={true}`.
        static member inline inputMultiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.inputMultiline", createObj !!styles)
        /// Styles applied to the input element if `type="search"`.
        static member inline inputTypeSearch(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInput.styleOverrides.inputTypeSearch", createObj !!styles)

      [<Erase>]
      type muiInputAdornment =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiInputAdornment", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.standard", createObj !!styles)
        /// Styles applied to the root element if `position="start"`.
        static member inline positionStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.positionStart", createObj !!styles)
        /// Styles applied to the root element if `position="end"`.
        static member inline positionEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.positionEnd", createObj !!styles)
        /// Styles applied to the root element if `disablePointerEvents={true}`.
        static member inline disablePointerEvents(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.disablePointerEvents", createObj !!styles)
        /// Styles applied if the adornment is used inside <formcontrol hiddenlabel=""></formcontrol>.
        static member inline hiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.hiddenLabel", createObj !!styles)
        /// Styles applied if the adornment is used inside <formcontrol size="small"></formcontrol>.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputAdornment.styleOverrides.sizeSmall", createObj !!styles)

      [<Erase>]
      type muiInputBase =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiInputBase", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if the component is a descendant of `FormControl`.
        static member inline formControl(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.formControl", createObj !!styles)
        /// Styles applied to the root element if the component is focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.focused", createObj !!styles)
        /// Styles applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `startAdornment` is provided.
        static member inline adornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.adornedStart", createObj !!styles)
        /// Styles applied to the root element if `endAdornment` is provided.
        static member inline adornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.adornedEnd", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.error", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `multiline={true}`.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.multiline", createObj !!styles)
        /// Styles applied to the root element if the color is secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.fullWidth", createObj !!styles)
        /// Styles applied to the root element if `hiddenLabel={true}`.
        static member inline hiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.hiddenLabel", createObj !!styles)
        /// State class applied to the root element if `readOnly={true}`.
        static member inline readOnly(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.readOnly", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.input", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline inputSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.inputSizeSmall", createObj !!styles)
        /// Styles applied to the input element if `multiline={true}`.
        static member inline inputMultiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.inputMultiline", createObj !!styles)
        /// Styles applied to the input element if `type="search"`.
        static member inline inputTypeSearch(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.inputTypeSearch", createObj !!styles)
        /// Styles applied to the input element if `startAdornment` is provided.
        static member inline inputAdornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.inputAdornedStart", createObj !!styles)
        /// Styles applied to the input element if `endAdornment` is provided.
        static member inline inputAdornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.inputAdornedEnd", createObj !!styles)
        /// Styles applied to the input element if `hiddenLabel={true}`.
        static member inline inputHiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputBase.styleOverrides.inputHiddenLabel", createObj !!styles)

      [<Erase>]
      type muiInputLabel =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiInputLabel", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `focused={true}`.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.focused", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.disabled", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.error", createObj !!styles)
        /// State class applied to the root element if `required={true}`.
        static member inline required(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.required", createObj !!styles)
        /// State class applied to the asterisk element.
        static member inline asterisk(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.asterisk", createObj !!styles)
        /// Styles applied to the root element if the component is a descendant of `FormControl`.
        static member inline formControl(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.formControl", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the input element if `shrink={true}`.
        static member inline shrink(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.shrink", createObj !!styles)
        /// Styles applied to the input element unless `disableAnimation={true}`.
        static member inline animated(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.animated", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiInputLabel.styleOverrides.standard", createObj !!styles)

      [<Erase>]
      type muiLinearProgress =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiLinearProgress", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root and bar2 element if `color="primary"`; bar2 if `variant="buffer"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root and bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="determinate"`.
        static member inline determinate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.determinate", createObj !!styles)
        /// Styles applied to the root element if `variant="indeterminate"`.
        static member inline indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.indeterminate", createObj !!styles)
        /// Styles applied to the root element if `variant="buffer"`.
        static member inline buffer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.buffer", createObj !!styles)
        /// Styles applied to the root element if `variant="query"`.
        static member inline query(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.query", createObj !!styles)
        /// Styles applied to the additional bar element if `variant="buffer"`.
        static member inline dashed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.dashed", createObj !!styles)
        /// Styles applied to the additional bar element if `variant="buffer"` and `color="primary"`.
        static member inline dashedColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.dashedColorPrimary", createObj !!styles)
        /// Styles applied to the additional bar element if `variant="buffer"` and `color="secondary"`.
        static member inline dashedColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.dashedColorSecondary", createObj !!styles)
        /// Styles applied to the layered bar1 and bar2 elements.
        static member inline bar(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.bar", createObj !!styles)
        /// Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
        static member inline barColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.barColorPrimary", createObj !!styles)
        /// Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
        static member inline barColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.barColorSecondary", createObj !!styles)
        /// Styles applied to the bar1 element if `variant="indeterminate or query"`.
        static member inline bar1Indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.bar1Indeterminate", createObj !!styles)
        /// Styles applied to the bar1 element if `variant="determinate"`.
        static member inline bar1Determinate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.bar1Determinate", createObj !!styles)
        /// Styles applied to the bar1 element if `variant="buffer"`.
        static member inline bar1Buffer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.bar1Buffer", createObj !!styles)
        /// Styles applied to the bar2 element if `variant="indeterminate or query"`.
        static member inline bar2Indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.bar2Indeterminate", createObj !!styles)
        /// Styles applied to the bar2 element if `variant="buffer"`.
        static member inline bar2Buffer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLinearProgress.styleOverrides.bar2Buffer", createObj !!styles)

      [<Erase>]
      type muiLink =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiLink", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLink.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `underline="none"`.
        static member inline underlineNone(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLink.styleOverrides.underlineNone", createObj !!styles)
        /// Styles applied to the root element if `underline="hover"`.
        static member inline underlineHover(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLink.styleOverrides.underlineHover", createObj !!styles)
        /// Styles applied to the root element if `underline="always"`.
        static member inline underlineAlways(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLink.styleOverrides.underlineAlways", createObj !!styles)
        /// Styles applied to the root element if `component="button"`.
        static member inline button(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLink.styleOverrides.button", createObj !!styles)
        /// State class applied to the root element if the link is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLink.styleOverrides.focusVisible", createObj !!styles)

      [<Erase>]
      type muiList =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiList", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiList.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element unless `disablePadding={true}`.
        static member inline padding(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiList.styleOverrides.padding", createObj !!styles)
        /// Styles applied to the root element if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiList.styleOverrides.dense", createObj !!styles)
        /// Styles applied to the root element if a `subheader` is provided.
        static member inline subheader(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiList.styleOverrides.subheader", createObj !!styles)

      [<Erase>]
      type muiListItem =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiListItem", values)
        /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.root", createObj !!styles)
        /// Styles applied to the container element if `children` includes `ListItemSecondaryAction`.
        static member inline container(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.container", createObj !!styles)
        /// State class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.focusVisible", createObj !!styles)
        /// Styles applied to the component element if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.dense", createObj !!styles)
        /// Styles applied to the component element if `alignItems="flex-start"`.
        static member inline alignItemsFlexStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.alignItemsFlexStart", createObj !!styles)
        /// State class applied to the inner `component` element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the inner `component` element if `divider={true}`.
        static member inline divider(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.divider", createObj !!styles)
        /// Styles applied to the inner `component` element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.gutters", createObj !!styles)
        /// Styles applied to the root element unless `disablePadding={true}`.
        static member inline padding(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.padding", createObj !!styles)
        /// Styles applied to the inner `component` element if `button={true}`.
        static member inline button(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.button", createObj !!styles)
        /// Styles applied to the component element if `children` includes `ListItemSecondaryAction`.
        static member inline secondaryAction(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.secondaryAction", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItem.styleOverrides.selected", createObj !!styles)

      [<Erase>]
      type muiListItemAvatar =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiListItemAvatar", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemAvatar.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
        static member inline alignItemsFlexStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemAvatar.styleOverrides.alignItemsFlexStart", createObj !!styles)

      [<Erase>]
      type muiListItemButton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiListItemButton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemButton.styleOverrides.root", createObj !!styles)
        /// State class applied to the `component`'s `focusVisibleClassName` prop.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemButton.styleOverrides.focusVisible", createObj !!styles)
        /// Styles applied to the component element if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemButton.styleOverrides.dense", createObj !!styles)
        /// Styles applied to the component element if `alignItems="flex-start"`.
        static member inline alignItemsFlexStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemButton.styleOverrides.alignItemsFlexStart", createObj !!styles)
        /// State class applied to the inner `component` element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemButton.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the inner `component` element if `divider={true}`.
        static member inline divider(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemButton.styleOverrides.divider", createObj !!styles)
        /// Styles applied to the inner `component` element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemButton.styleOverrides.gutters", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemButton.styleOverrides.selected", createObj !!styles)

      [<Erase>]
      type muiListItemIcon =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiListItemIcon", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemIcon.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
        static member inline alignItemsFlexStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemIcon.styleOverrides.alignItemsFlexStart", createObj !!styles)

      [<Erase>]
      type muiListItemSecondaryAction =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiListItemSecondaryAction", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemSecondaryAction.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element when the parent `ListItem` has `disableGutters={true}`.
        static member inline disableGutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemSecondaryAction.styleOverrides.disableGutters", createObj !!styles)

      [<Erase>]
      type muiListItemText =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiListItemText", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemText.styleOverrides.root", createObj !!styles)
        /// Styles applied to the Typography component if primary and secondary are set.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemText.styleOverrides.multiline", createObj !!styles)
        /// Styles applied to the Typography component if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemText.styleOverrides.dense", createObj !!styles)
        /// Styles applied to the root element if `inset={true}`.
        static member inline inset(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemText.styleOverrides.inset", createObj !!styles)
        /// Styles applied to the primary `Typography` component.
        static member inline primary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemText.styleOverrides.primary", createObj !!styles)
        /// Styles applied to the secondary `Typography` component.
        static member inline secondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListItemText.styleOverrides.secondary", createObj !!styles)

      [<Erase>]
      type muiListSubheader =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiListSubheader", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListSubheader.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListSubheader.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListSubheader.styleOverrides.colorInherit", createObj !!styles)
        /// Styles applied to the inner `component` element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListSubheader.styleOverrides.gutters", createObj !!styles)
        /// Styles applied to the root element if `inset={true}`.
        static member inline inset(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListSubheader.styleOverrides.inset", createObj !!styles)
        /// Styles applied to the root element unless `disableSticky={true}`.
        static member inline sticky(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiListSubheader.styleOverrides.sticky", createObj !!styles)

      [<Erase>]
      type muiLoadingButton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiLoadingButton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.text", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="inherit"`.
        static member inline textInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="primary"`.
        static member inline textPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
        static member inline textSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="success"`.
        static member inline textSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="error"`.
        static member inline textError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textError", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="info"`.
        static member inline textInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="warning"`.
        static member inline textWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="inherit"`.
        static member inline outlinedInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="success"`.
        static member inline outlinedSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="error"`.
        static member inline outlinedError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedError", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="info"`.
        static member inline outlinedInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="warning"`.
        static member inline outlinedWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"`.
        static member inline contained(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.contained", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="inherit"`.
        static member inline containedInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
        static member inline containedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
        static member inline containedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="success"`.
        static member inline containedSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="info"`.
        static member inline containedInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="error"`.
        static member inline containedError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedError", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="warning"`.
        static member inline containedWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedWarning", createObj !!styles)
        /// Styles applied to the root element if `disableElevation={true}`.
        static member inline disableElevation(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.disableElevation", createObj !!styles)
        /// State class applied to the ButtonBase root element if the button is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="text"`.
        static member inline textSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="text"`.
        static member inline textSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="text"`.
        static member inline textSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.textSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="outlined"`.
        static member inline outlinedSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="outlined"`.
        static member inline outlinedSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="outlined"`.
        static member inline outlinedSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.outlinedSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="contained"`.
        static member inline containedSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="contained"`.
        static member inline containedSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="contained"`.
        static member inline containedSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.containedSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.sizeLarge", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.fullWidth", createObj !!styles)
        /// Styles applied to the startIcon element if supplied.
        static member inline startIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.startIcon", createObj !!styles)
        /// Styles applied to the endIcon element if supplied.
        static member inline endIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.endIcon", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="small"`.
        static member inline iconSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.iconSizeSmall", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="medium"`.
        static member inline iconSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.iconSizeMedium", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="large"`.
        static member inline iconSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.iconSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `loading={true}`.
        static member inline loading(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.loading", createObj !!styles)
        /// Styles applied to the loadingIndicator element.
        static member inline loadingIndicator(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.loadingIndicator", createObj !!styles)
        /// Styles applied to the loadingIndicator element if `loadingPosition="center"`.
        static member inline loadingIndicatorCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.loadingIndicatorCenter", createObj !!styles)
        /// Styles applied to the loadingIndicator element if `loadingPosition="start"`.
        static member inline loadingIndicatorStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.loadingIndicatorStart", createObj !!styles)
        /// Styles applied to the loadingIndicator element if `loadingPosition="end"`.
        static member inline loadingIndicatorEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.loadingIndicatorEnd", createObj !!styles)
        /// Styles applied to the endIcon element if `loading={true}` and `loadingPosition="end"`.
        static member inline endIconLoadingEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.endIconLoadingEnd", createObj !!styles)
        /// Styles applied to the startIcon element if `loading={true}` and `loadingPosition="start"`.
        static member inline startIconLoadingStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiLoadingButton.styleOverrides.startIconLoadingStart", createObj !!styles)

      [<Erase>]
      type muiMasonry =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiMasonry", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMasonry.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiMenu =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiMenu", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenu.styleOverrides.root", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenu.styleOverrides.paper", createObj !!styles)
        /// Styles applied to the List component via `MenuList`.
        static member inline list(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenu.styleOverrides.list", createObj !!styles)

      [<Erase>]
      type muiMenuItem =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiMenuItem", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenuItem.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenuItem.styleOverrides.focusVisible", createObj !!styles)
        /// Styles applied to the root element if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenuItem.styleOverrides.dense", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenuItem.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `divider={true}`.
        static member inline divider(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenuItem.styleOverrides.divider", createObj !!styles)
        /// Styles applied to the inner `component` element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenuItem.styleOverrides.gutters", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMenuItem.styleOverrides.selected", createObj !!styles)

      [<Erase>]
      type muiMobileStepper =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiMobileStepper", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMobileStepper.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `position="bottom"`.
        static member inline positionBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMobileStepper.styleOverrides.positionBottom", createObj !!styles)
        /// Styles applied to the root element if `position="top"`.
        static member inline positionTop(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMobileStepper.styleOverrides.positionTop", createObj !!styles)
        /// Styles applied to the root element if `position="static"`.
        static member inline positionStatic(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMobileStepper.styleOverrides.positionStatic", createObj !!styles)
        /// Styles applied to the dots container if `variant="dots"`.
        static member inline dots(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMobileStepper.styleOverrides.dots", createObj !!styles)
        /// Styles applied to each dot if `variant="dots"`.
        static member inline dot(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMobileStepper.styleOverrides.dot", createObj !!styles)
        /// Styles applied to a dot if `variant="dots"` and this is the active step.
        static member inline dotActive(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMobileStepper.styleOverrides.dotActive", createObj !!styles)
        /// Styles applied to the Linear Progress component if `variant="progress"`.
        static member inline progress(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMobileStepper.styleOverrides.progress", createObj !!styles)

      [<Erase>]
      type muiModal =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiModal", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiModal.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if the `Modal` has exited.
        static member inline hidden(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiModal.styleOverrides.hidden", createObj !!styles)

      [<Erase>]
      type muiNativeSelect =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiNativeSelect", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.root", createObj !!styles)
        /// Styles applied to the select component `select` class.
        static member inline select(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.select", createObj !!styles)
        /// Styles applied to the select component if `multiple={true}`.
        static member inline multiple(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.multiple", createObj !!styles)
        /// Styles applied to the select component if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.filled", createObj !!styles)
        /// Styles applied to the select component if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the select component if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.standard", createObj !!styles)
        /// State class applied to the select component `disabled` class.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the icon component.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.icon", createObj !!styles)
        /// Styles applied to the icon component if the popup is open.
        static member inline iconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.iconOpen", createObj !!styles)
        /// Styles applied to the icon component if `variant="filled"`.
        static member inline iconFilled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.iconFilled", createObj !!styles)
        /// Styles applied to the icon component if `variant="outlined"`.
        static member inline iconOutlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.iconOutlined", createObj !!styles)
        /// Styles applied to the icon component if `variant="standard"`.
        static member inline iconStandard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.iconStandard", createObj !!styles)
        /// Styles applied to the underlying native input component.
        static member inline nativeInput(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiNativeSelect.styleOverrides.nativeInput", createObj !!styles)

      [<Erase>]
      type muiOutlinedInput =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiOutlinedInput", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if the color is secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if the component is focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.focused", createObj !!styles)
        /// Styles applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `startAdornment` is provided.
        static member inline adornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.adornedStart", createObj !!styles)
        /// Styles applied to the root element if `endAdornment` is provided.
        static member inline adornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.adornedEnd", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.error", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `multiline={true}`.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.multiline", createObj !!styles)
        /// Styles applied to the NotchedOutline element.
        static member inline notchedOutline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.notchedOutline", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.input", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline inputSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.inputSizeSmall", createObj !!styles)
        /// Styles applied to the input element if `multiline={true}`.
        static member inline inputMultiline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.inputMultiline", createObj !!styles)
        /// Styles applied to the input element if `startAdornment` is provided.
        static member inline inputAdornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.inputAdornedStart", createObj !!styles)
        /// Styles applied to the input element if `endAdornment` is provided.
        static member inline inputAdornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiOutlinedInput.styleOverrides.inputAdornedEnd", createObj !!styles)

      [<Erase>]
      type muiPagination =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiPagination", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPagination.styleOverrides.root", createObj !!styles)
        /// Styles applied to the ul element.
        static member inline ul(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPagination.styleOverrides.ul", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPagination.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPagination.styleOverrides.text", createObj !!styles)

      [<Erase>]
      type muiPaginationItem =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiPaginationItem", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `type="page"`.
        static member inline page(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.page", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.sizeLarge", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.text", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="primary"`.
        static member inline textPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.textPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
        static member inline textSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.textSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.outlinedSecondary", createObj !!styles)
        /// Styles applied to the root element if `rounded="true"`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.rounded", createObj !!styles)
        /// Styles applied to the root element if `type="start-ellipsis"` or `type="end-ellipsis"`.
        static member inline ellipsis(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.ellipsis", createObj !!styles)
        /// Styles applyed to the root element if `type="first"` or type="last".
        static member inline firstLast(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.firstLast", createObj !!styles)
        /// Styles applyed to the root element if `type="previous"` or type="next".
        static member inline previousNext(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.previousNext", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.disabled", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.selected", createObj !!styles)
        /// Styles applied to the icon to display.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaginationItem.styleOverrides.icon", createObj !!styles)

      [<Erase>]
      type muiPaper =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiPaper", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element unless `square={true}`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.rounded", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="elevation"`.
        static member inline elevation(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation", createObj !!styles)
        static member inline elevation0(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation0", createObj !!styles)
        static member inline elevation1(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation1", createObj !!styles)
        static member inline elevation2(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation2", createObj !!styles)
        static member inline elevation3(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation3", createObj !!styles)
        static member inline elevation4(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation4", createObj !!styles)
        static member inline elevation5(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation5", createObj !!styles)
        static member inline elevation6(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation6", createObj !!styles)
        static member inline elevation7(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation7", createObj !!styles)
        static member inline elevation8(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation8", createObj !!styles)
        static member inline elevation9(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation9", createObj !!styles)
        static member inline elevation10(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation10", createObj !!styles)
        static member inline elevation11(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation11", createObj !!styles)
        static member inline elevation12(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation12", createObj !!styles)
        static member inline elevation13(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation13", createObj !!styles)
        static member inline elevation14(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation14", createObj !!styles)
        static member inline elevation15(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation15", createObj !!styles)
        static member inline elevation16(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation16", createObj !!styles)
        static member inline elevation17(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation17", createObj !!styles)
        static member inline elevation18(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation18", createObj !!styles)
        static member inline elevation19(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation19", createObj !!styles)
        static member inline elevation20(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation20", createObj !!styles)
        static member inline elevation21(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation21", createObj !!styles)
        static member inline elevation22(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation22", createObj !!styles)
        static member inline elevation23(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation23", createObj !!styles)
        static member inline elevation24(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPaper.styleOverrides.elevation24", createObj !!styles)

      [<Erase>]
      type muiPopover =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiPopover", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPopover.styleOverrides.root", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPopover.styleOverrides.paper", createObj !!styles)

      [<Erase>]
      type muiRadio =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiRadio", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRadio.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `checked={true}`.
        static member inline checked'(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRadio.styleOverrides.checked", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRadio.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRadio.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRadio.styleOverrides.colorSecondary", createObj !!styles)

      [<Erase>]
      type muiRating =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiRating", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.sizeLarge", createObj !!styles)
        /// Styles applied to the root element if `readOnly={true}`.
        static member inline readOnly(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.readOnly", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.disabled", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.focusVisible", createObj !!styles)
        /// Visually hide an element.
        static member inline visuallyHidden(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.visuallyHidden", createObj !!styles)
        /// Styles applied to the label elements.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.label", createObj !!styles)
        /// Styles applied to the label of the "no value" input when it is active.
        static member inline labelEmptyValueActive(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.labelEmptyValueActive", createObj !!styles)
        /// Styles applied to the icon wrapping elements.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.icon", createObj !!styles)
        /// Styles applied to the icon wrapping elements when empty.
        static member inline iconEmpty(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.iconEmpty", createObj !!styles)
        /// Styles applied to the icon wrapping elements when filled.
        static member inline iconFilled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.iconFilled", createObj !!styles)
        /// Styles applied to the icon wrapping elements when hover.
        static member inline iconHover(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.iconHover", createObj !!styles)
        /// Styles applied to the icon wrapping elements when focus.
        static member inline iconFocus(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.iconFocus", createObj !!styles)
        /// Styles applied to the icon wrapping elements when active.
        static member inline iconActive(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.iconActive", createObj !!styles)
        /// Styles applied to the icon wrapping elements when decimals are necessary.
        static member inline decimal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiRating.styleOverrides.decimal", createObj !!styles)

      [<Erase>]
      type muiScopedCssBaseline =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiScopedCssBaseline", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiScopedCssBaseline.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiSelect =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSelect", values)
        /// Styles applied to the select component `select` class.
        static member inline select(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.select", createObj !!styles)
        /// Styles applied to the select component if `multiple={true}`.
        static member inline multiple(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.multiple", createObj !!styles)
        /// Styles applied to the select component if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.filled", createObj !!styles)
        /// Styles applied to the select component if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the select component if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.standard", createObj !!styles)
        /// State class applied to the select component `disabled` class.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the icon component.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.icon", createObj !!styles)
        /// Styles applied to the icon component if the popup is open.
        static member inline iconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.iconOpen", createObj !!styles)
        /// Styles applied to the icon component if `variant="filled"`.
        static member inline iconFilled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.iconFilled", createObj !!styles)
        /// Styles applied to the icon component if `variant="outlined"`.
        static member inline iconOutlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.iconOutlined", createObj !!styles)
        /// Styles applied to the icon component if `variant="standard"`.
        static member inline iconStandard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.iconStandard", createObj !!styles)
        /// Styles applied to the underlying native input component.
        static member inline nativeInput(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSelect.styleOverrides.nativeInput", createObj !!styles)

      [<Erase>]
      type muiSkeleton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSkeleton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.text", createObj !!styles)
        /// Styles applied to the root element if `variant="rectangular"`.
        static member inline rectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.rectangular", createObj !!styles)
        /// Styles applied to the root element if `variant="rounded"`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.rounded", createObj !!styles)
        /// Styles applied to the root element if `variant="circular"`.
        static member inline circular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.circular", createObj !!styles)
        /// Styles applied to the root element if `animation="pulse"`.
        static member inline pulse(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.pulse", createObj !!styles)
        /// Styles applied to the root element if `animation="wave"`.
        static member inline wave(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.wave", createObj !!styles)
        /// Styles applied when the component is passed children.
        static member inline withChildren(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.withChildren", createObj !!styles)
        /// Styles applied when the component is passed children and no width.
        static member inline fitContent(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.fitContent", createObj !!styles)
        /// Styles applied when the component is passed children and no height.
        static member inline heightAuto(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSkeleton.styleOverrides.heightAuto", createObj !!styles)

      [<Erase>]
      type muiSlider =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSlider", values)
        /// Class name applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.root", createObj !!styles)
        /// Class name applied to the root element if `marks` is provided with at least one label.
        static member inline marked(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.marked", createObj !!styles)
        /// Class name applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.vertical", createObj !!styles)
        /// State class applied to the root and thumb element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.disabled", createObj !!styles)
        /// State class applied to the root if a thumb is being dragged.
        static member inline dragging(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.dragging", createObj !!styles)
        /// Class name applied to the rail element.
        static member inline rail(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.rail", createObj !!styles)
        /// Class name applied to the track element.
        static member inline track(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.track", createObj !!styles)
        /// Class name applied to the root element if `track={false}`.
        static member inline trackFalse(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.trackFalse", createObj !!styles)
        /// Class name applied to the root element if `track="inverted"`.
        static member inline trackInverted(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.trackInverted", createObj !!styles)
        /// Class name applied to the thumb element.
        static member inline thumb(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.thumb", createObj !!styles)
        /// State class applied to the thumb element if it's active.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.active", createObj !!styles)
        /// State class applied to the thumb element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.focusVisible", createObj !!styles)
        /// Class name applied to the thumb label element.
        static member inline valueLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.valueLabel", createObj !!styles)
        /// Class name applied to the thumb label element if it's open.
        static member inline valueLabelOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.valueLabelOpen", createObj !!styles)
        /// Class name applied to the thumb label's circle element.
        static member inline valueLabelCircle(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.valueLabelCircle", createObj !!styles)
        /// Class name applied to the thumb label's label element.
        static member inline valueLabelLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.valueLabelLabel", createObj !!styles)
        /// Class name applied to the mark element.
        static member inline mark(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.mark", createObj !!styles)
        /// Class name applied to the mark element if active (depending on the value).
        static member inline markActive(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.markActive", createObj !!styles)
        /// Class name applied to the mark label element.
        static member inline markLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.markLabel", createObj !!styles)
        /// Class name applied to the mark label element if active (depending on the value).
        static member inline markLabelActive(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.markLabelActive", createObj !!styles)
        /// Class name applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.colorPrimary", createObj !!styles)
        /// Class name applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.colorSecondary", createObj !!styles)
        /// Class name applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.sizeSmall", createObj !!styles)
        /// Class name applied to the thumb element if `color="primary"`.
        static member inline thumbColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.thumbColorPrimary", createObj !!styles)
        /// Class name applied to the thumb element if `color="secondary"`.
        static member inline thumbColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.thumbColorSecondary", createObj !!styles)
        /// Class name applied to the thumb element if `size="small"`.
        static member inline thumbSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSlider.styleOverrides.thumbSizeSmall", createObj !!styles)

      [<Erase>]
      type muiSnackbar =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSnackbar", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbar.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'top', 'center' }}`.
        static member inline anchorOriginTopCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbar.styleOverrides.anchorOriginTopCenter", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'center' }}`.
        static member inline anchorOriginBottomCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbar.styleOverrides.anchorOriginBottomCenter", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }}`.
        static member inline anchorOriginTopRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbar.styleOverrides.anchorOriginTopRight", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }}`.
        static member inline anchorOriginBottomRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbar.styleOverrides.anchorOriginBottomRight", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }}`.
        static member inline anchorOriginTopLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbar.styleOverrides.anchorOriginTopLeft", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }}`.
        static member inline anchorOriginBottomLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbar.styleOverrides.anchorOriginBottomLeft", createObj !!styles)

      [<Erase>]
      type muiSnackbarContent =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSnackbarContent", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbarContent.styleOverrides.root", createObj !!styles)
        /// Styles applied to the message wrapper element.
        static member inline message(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbarContent.styleOverrides.message", createObj !!styles)
        /// Styles applied to the action wrapper element if `action` is provided.
        static member inline action(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSnackbarContent.styleOverrides.action", createObj !!styles)

      [<Erase>]
      type muiSpeedDial =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSpeedDial", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDial.styleOverrides.root", createObj !!styles)
        /// Styles applied to the Fab component.
        static member inline fab(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDial.styleOverrides.fab", createObj !!styles)
        /// Styles applied to the root element if direction="up"
        static member inline directionUp(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDial.styleOverrides.directionUp", createObj !!styles)
        /// Styles applied to the root element if direction="down"
        static member inline directionDown(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDial.styleOverrides.directionDown", createObj !!styles)
        /// Styles applied to the root element if direction="left"
        static member inline directionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDial.styleOverrides.directionLeft", createObj !!styles)
        /// Styles applied to the root element if direction="right"
        static member inline directionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDial.styleOverrides.directionRight", createObj !!styles)
        /// Styles applied to the actions (`children` wrapper) element.
        static member inline actions(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDial.styleOverrides.actions", createObj !!styles)
        /// Styles applied to the actions (`children` wrapper) element if `open={false}`.
        static member inline actionsClosed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDial.styleOverrides.actionsClosed", createObj !!styles)

      [<Erase>]
      type muiSpeedDialAction =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSpeedDialAction", values)
        /// Styles applied to the Fab component.
        static member inline fab(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialAction.styleOverrides.fab", createObj !!styles)
        /// Styles applied to the Fab component if `open={false}`.
        static member inline fabClosed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialAction.styleOverrides.fabClosed", createObj !!styles)
        /// Styles applied to the root element if `tooltipOpen={true}`.
        static member inline staticTooltip(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialAction.styleOverrides.staticTooltip", createObj !!styles)
        /// Styles applied to the root element if `tooltipOpen={true}` and `open={false}`.
        static member inline staticTooltipClosed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialAction.styleOverrides.staticTooltipClosed", createObj !!styles)
        /// Styles applied to the static tooltip label if `tooltipOpen={true}`.
        static member inline staticTooltipLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialAction.styleOverrides.staticTooltipLabel", createObj !!styles)
        /// Styles applied to the root element if `tooltipOpen={true}` and `tooltipPlacement="left"``
        static member inline tooltipPlacementLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialAction.styleOverrides.tooltipPlacementLeft", createObj !!styles)
        /// Styles applied to the root element if `tooltipOpen={true}` and `tooltipPlacement="right"``
        static member inline tooltipPlacementRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialAction.styleOverrides.tooltipPlacementRight", createObj !!styles)

      [<Erase>]
      type muiSpeedDialIcon =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSpeedDialIcon", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialIcon.styleOverrides.root", createObj !!styles)
        /// Styles applied to the icon component.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialIcon.styleOverrides.icon", createObj !!styles)
        /// Styles applied to the icon component if `open={true}`.
        static member inline iconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialIcon.styleOverrides.iconOpen", createObj !!styles)
        /// Styles applied to the icon when an `openIcon` is provided and if `open={true}`.
        static member inline iconWithOpenIconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialIcon.styleOverrides.iconWithOpenIconOpen", createObj !!styles)
        /// Styles applied to the `openIcon` if provided.
        static member inline openIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialIcon.styleOverrides.openIcon", createObj !!styles)
        /// Styles applied to the `openIcon` if provided and if `open={true}`.
        static member inline openIconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSpeedDialIcon.styleOverrides.openIconOpen", createObj !!styles)

      [<Erase>]
      type muiStep =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiStep", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStep.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStep.styleOverrides.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStep.styleOverrides.vertical", createObj !!styles)
        /// Styles applied to the root element if `alternativeLabel={true}`.
        static member inline alternativeLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStep.styleOverrides.alternativeLabel", createObj !!styles)
        /// State class applied to the root element if `completed={true}`.
        static member inline completed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStep.styleOverrides.completed", createObj !!styles)

      [<Erase>]
      type muiStepButton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiStepButton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepButton.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepButton.styleOverrides.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepButton.styleOverrides.vertical", createObj !!styles)
        /// Styles applied to the `ButtonBase` touch-ripple.
        static member inline touchRipple(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepButton.styleOverrides.touchRipple", createObj !!styles)

      [<Erase>]
      type muiStepConnector =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiStepConnector", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.vertical", createObj !!styles)
        /// Styles applied to the root element if `alternativeLabel={true}`.
        static member inline alternativeLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.alternativeLabel", createObj !!styles)
        /// State class applied to the root element if `active={true}`.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.active", createObj !!styles)
        /// State class applied to the root element if `completed={true}`.
        static member inline completed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.completed", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the line element.
        static member inline line(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.line", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline lineHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.lineHorizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline lineVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepConnector.styleOverrides.lineVertical", createObj !!styles)

      [<Erase>]
      type muiStepContent =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiStepContent", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepContent.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `last={true}` (controlled by `Step`).
        static member inline last(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepContent.styleOverrides.last", createObj !!styles)
        /// Styles applied to the Transition component.
        static member inline transition(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepContent.styleOverrides.transition", createObj !!styles)

      [<Erase>]
      type muiStepIcon =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiStepIcon", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepIcon.styleOverrides.root", createObj !!styles)
        /// Styles applied to the SVG text element.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepIcon.styleOverrides.text", createObj !!styles)
        /// State class applied to the root element if `active={true}`.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepIcon.styleOverrides.active", createObj !!styles)
        /// State class applied to the root element if `completed={true}`.
        static member inline completed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepIcon.styleOverrides.completed", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepIcon.styleOverrides.error", createObj !!styles)

      [<Erase>]
      type muiStepLabel =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiStepLabel", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.vertical", createObj !!styles)
        /// Styles applied to the label element that wraps `children`.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.label", createObj !!styles)
        /// State class applied to the label element if `active={true}`.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.active", createObj !!styles)
        /// State class applied to the label element if `completed={true}`.
        static member inline completed(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.completed", createObj !!styles)
        /// State class applied to the root and label elements if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.error", createObj !!styles)
        /// State class applied to the root and label elements if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the `icon` container element.
        static member inline iconContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.iconContainer", createObj !!styles)
        /// State class applied to the root and icon container and label if `alternativeLabel={true}`.
        static member inline alternativeLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.alternativeLabel", createObj !!styles)
        /// Styles applied to the container element which wraps label and `optional`.
        static member inline labelContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepLabel.styleOverrides.labelContainer", createObj !!styles)

      [<Erase>]
      type muiStepper =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiStepper", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepper.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepper.styleOverrides.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepper.styleOverrides.vertical", createObj !!styles)
        /// Styles applied to the root element if `alternativeLabel={true}`.
        static member inline alternativeLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiStepper.styleOverrides.alternativeLabel", createObj !!styles)

      [<Erase>]
      type muiSvgIcon =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSvgIcon", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `color="action"`.
        static member inline colorAction(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.colorAction", createObj !!styles)
        /// Styles applied to the root element if `color="error"`.
        static member inline colorError(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.colorError", createObj !!styles)
        /// Styles applied to the root element if `color="disabled"`.
        static member inline colorDisabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.colorDisabled", createObj !!styles)
        /// Styles applied to the root element if `fontSize="inherit"`.
        static member inline fontSizeInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.fontSizeInherit", createObj !!styles)
        /// Styles applied to the root element if `fontSize="small"`.
        static member inline fontSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.fontSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `fontSize="large"`.
        static member inline fontSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSvgIcon.styleOverrides.fontSizeLarge", createObj !!styles)

      [<Erase>]
      type muiSwitch =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiSwitch", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `edge="start"`.
        static member inline edgeStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.edgeStart", createObj !!styles)
        /// Styles applied to the root element if `edge="end"`.
        static member inline edgeEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.edgeEnd", createObj !!styles)
        /// Styles applied to the internal `SwitchBase` component's `root` class.
        static member inline switchBase(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.switchBase", createObj !!styles)
        /// Styles applied to the internal SwitchBase component's root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.colorPrimary", createObj !!styles)
        /// Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.sizeMedium", createObj !!styles)
        /// State class applied to the internal `SwitchBase` component's `checked` class.
        static member inline checked'(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.checked", createObj !!styles)
        /// State class applied to the internal SwitchBase component's disabled class.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the internal SwitchBase component's input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.input", createObj !!styles)
        /// Styles used to create the thumb passed to the internal `SwitchBase` component `icon` prop.
        static member inline thumb(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.thumb", createObj !!styles)
        /// Styles applied to the track element.
        static member inline track(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiSwitch.styleOverrides.track", createObj !!styles)

      [<Erase>]
      type muiTab =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTab", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if both `icon` and `label` are provided.
        static member inline labelIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.labelIcon", createObj !!styles)
        /// Styles applied to the root element if the parent [`Tabs`](/material-ui/api/tabs/) has `textColor="inherit"`.
        static member inline textColorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.textColorInherit", createObj !!styles)
        /// Styles applied to the root element if the parent [`Tabs`](/material-ui/api/tabs/) has `textColor="primary"`.
        static member inline textColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.textColorPrimary", createObj !!styles)
        /// Styles applied to the root element if the parent [`Tabs`](/material-ui/api/tabs/) has `textColor="secondary"`.
        static member inline textColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.textColorSecondary", createObj !!styles)
        /// State class applied to the root element if `selected={true}` (controlled by the Tabs component).
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.selected", createObj !!styles)
        /// State class applied to the root element if `disabled={true}` (controlled by the Tabs component).
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.fullWidth", createObj !!styles)
        /// Styles applied to the root element if `wrapped={true}`.
        static member inline wrapped(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.wrapped", createObj !!styles)
        /// Styles applied to the wrapper element of `icon` if `icon` is provided.
        static member inline iconWrapper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTab.styleOverrides.iconWrapper", createObj !!styles)

      [<Erase>]
      type muiTable =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTable", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTable.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `stickyHeader={true}`.
        static member inline stickyHeader(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTable.styleOverrides.stickyHeader", createObj !!styles)

      [<Erase>]
      type muiTableBody =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTableBody", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableBody.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiTableCell =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTableCell", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="head"` or `context.table.head`.
        static member inline head(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.head", createObj !!styles)
        /// Styles applied to the root element if `variant="body"` or `context.table.body`.
        static member inline body(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.body", createObj !!styles)
        /// Styles applied to the root element if `variant="footer"` or `context.table.footer`.
        static member inline footer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.footer", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `padding="checkbox"`.
        static member inline paddingCheckbox(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.paddingCheckbox", createObj !!styles)
        /// Styles applied to the root element if `padding="none"`.
        static member inline paddingNone(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.paddingNone", createObj !!styles)
        /// Styles applied to the root element if `align="left"`.
        static member inline alignLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.alignLeft", createObj !!styles)
        /// Styles applied to the root element if `align="center"`.
        static member inline alignCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.alignCenter", createObj !!styles)
        /// Styles applied to the root element if `align="right"`.
        static member inline alignRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.alignRight", createObj !!styles)
        /// Styles applied to the root element if `align="justify"`.
        static member inline alignJustify(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.alignJustify", createObj !!styles)
        /// Styles applied to the root element if `context.table.stickyHeader={true}`.
        static member inline stickyHeader(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableCell.styleOverrides.stickyHeader", createObj !!styles)

      [<Erase>]
      type muiTableContainer =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTableContainer", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableContainer.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiTableFooter =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTableFooter", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableFooter.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiTableHead =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTableHead", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableHead.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiTablePagination =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTablePagination", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.root", createObj !!styles)
        /// Styles applied to the Toolbar component.
        static member inline toolbar(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.toolbar", createObj !!styles)
        /// Styles applied to the spacer element.
        static member inline spacer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.spacer", createObj !!styles)
        /// Styles applied to the select label Typography element.
        static member inline selectLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.selectLabel", createObj !!styles)
        /// Styles applied to the Select component `root` element.
        static member inline selectRoot(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.selectRoot", createObj !!styles)
        /// Styles applied to the Select component `select` class.
        static member inline select(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.select", createObj !!styles)
        /// Styles applied to the Select component `icon` class.
        static member inline selectIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.selectIcon", createObj !!styles)
        /// Styles applied to the Select component `root` element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.input", createObj !!styles)
        /// Styles applied to the MenuItem component.
        static member inline menuItem(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.menuItem", createObj !!styles)
        /// Styles applied to the displayed rows Typography element.
        static member inline displayedRows(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.displayedRows", createObj !!styles)
        /// Styles applied to the internal `TablePaginationActions` component.
        static member inline actions(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTablePagination.styleOverrides.actions", createObj !!styles)

      [<Erase>]
      type muiTableRow =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTableRow", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableRow.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableRow.styleOverrides.selected", createObj !!styles)
        /// State class applied to the root element if `hover={true}`.
        static member inline hover(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableRow.styleOverrides.hover", createObj !!styles)
        /// Styles applied to the root element if table variant="head".
        static member inline head(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableRow.styleOverrides.head", createObj !!styles)
        /// Styles applied to the root element if table variant="footer".
        static member inline footer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableRow.styleOverrides.footer", createObj !!styles)

      [<Erase>]
      type muiTableSortLabel =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTableSortLabel", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableSortLabel.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `active={true}`.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableSortLabel.styleOverrides.active", createObj !!styles)
        /// Styles applied to the icon component.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableSortLabel.styleOverrides.icon", createObj !!styles)
        /// Styles applied to the icon component if `direction="desc"`.
        static member inline iconDirectionDesc(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableSortLabel.styleOverrides.iconDirectionDesc", createObj !!styles)
        /// Styles applied to the icon component if `direction="asc"`.
        static member inline iconDirectionAsc(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTableSortLabel.styleOverrides.iconDirectionAsc", createObj !!styles)

      [<Erase>]
      type muiTabPanel =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTabPanel", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabPanel.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiTabs =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTabs", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.vertical", createObj !!styles)
        /// Styles applied to the flex container element.
        static member inline flexContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.flexContainer", createObj !!styles)
        /// Styles applied to the flex container element if `orientation="vertical"`.
        static member inline flexContainerVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.flexContainerVertical", createObj !!styles)
        /// Styles applied to the flex container element if `centered={true}`&`!variant="scrollable"`.
        static member inline centered(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.centered", createObj !!styles)
        /// Styles applied to the tablist element.
        static member inline scroller(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.scroller", createObj !!styles)
        /// Styles applied to the tablist element if `!variant="scrollable"`.
        static member inline fixed'(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.fixed", createObj !!styles)
        /// Styles applied to the tablist element if `variant="scrollable"` and `orientation="horizontal"`.
        static member inline scrollableX(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.scrollableX", createObj !!styles)
        /// Styles applied to the tablist element if `variant="scrollable"` and `orientation="vertical"`.
        static member inline scrollableY(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.scrollableY", createObj !!styles)
        /// Styles applied to the tablist element if `variant="scrollable"` and `visibleScrollbar={false}`.
        static member inline hideScrollbar(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.hideScrollbar", createObj !!styles)
        /// Styles applied to the ScrollButtonComponent component.
        static member inline scrollButtons(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.scrollButtons", createObj !!styles)
        /// Styles applied to the ScrollButtonComponent component if `allowScrollButtonsMobile={true}`.
        static member inline scrollButtonsHideMobile(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.scrollButtonsHideMobile", createObj !!styles)
        /// Styles applied to the TabIndicator component.
        static member inline indicator(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabs.styleOverrides.indicator", createObj !!styles)

      [<Erase>]
      type muiTabScrollButton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTabScrollButton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabScrollButton.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabScrollButton.styleOverrides.vertical", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTabScrollButton.styleOverrides.disabled", createObj !!styles)

      [<Erase>]
      type muiTextField =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTextField", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTextField.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiTimeline =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTimeline", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimeline.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `position="left"`.
        static member inline positionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimeline.styleOverrides.positionLeft", createObj !!styles)
        /// Styles applied to the root element if `position="right"`.
        static member inline positionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimeline.styleOverrides.positionRight", createObj !!styles)
        /// Styles applied to the root element if `position="alternate"`.
        static member inline positionAlternate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimeline.styleOverrides.positionAlternate", createObj !!styles)

      [<Erase>]
      type muiTimelineConnector =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTimelineConnector", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineConnector.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiTimelineContent =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTimelineContent", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineContent.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `position="right"`.
        static member inline positionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineContent.styleOverrides.positionRight", createObj !!styles)
        /// Styles applied to the root element if `position="left"`.
        static member inline positionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineContent.styleOverrides.positionLeft", createObj !!styles)
        /// Styles applied to the root element if `position="alternate"`.
        static member inline positionAlternate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineContent.styleOverrides.positionAlternate", createObj !!styles)

      [<Erase>]
      type muiTimelineDot =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTimelineDot", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.outlined", createObj !!styles)
        /// Styles applied to the root element if `color="grey"` and `variant="filled"`.
        static member inline filledGrey(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.filledGrey", createObj !!styles)
        /// Styles applied to the root element if `color="grey"` and `variant="outlined"`.
        static member inline outlinedGrey(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.outlinedGrey", createObj !!styles)
        /// Styles applied to the root element if `color="primary"` and `variant="filled"`.
        static member inline filledPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.filledPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="primary"` and `variant="outlined"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"` and `variant="filled"`.
        static member inline filledSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.filledSecondary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"` and `variant="outlined"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineDot.styleOverrides.outlinedSecondary", createObj !!styles)

      [<Erase>]
      type muiTimelineItem =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTimelineItem", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineItem.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `position="left"`.
        static member inline positionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineItem.styleOverrides.positionLeft", createObj !!styles)
        /// Styles applied to the root element if `position="right"`.
        static member inline positionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineItem.styleOverrides.positionRight", createObj !!styles)
        /// Styles applied to the root element if `position="alternate"`.
        static member inline positionAlternate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineItem.styleOverrides.positionAlternate", createObj !!styles)
        /// Styles applied to the root element if TimelineOppositeContent isn't provided.
        static member inline missingOppositeContent(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineItem.styleOverrides.missingOppositeContent", createObj !!styles)

      [<Erase>]
      type muiTimelineOppositeContent =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTimelineOppositeContent", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineOppositeContent.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `position="right"`.
        static member inline positionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineOppositeContent.styleOverrides.positionRight", createObj !!styles)
        /// Styles applied to the root element if `position="left"`.
        static member inline positionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineOppositeContent.styleOverrides.positionLeft", createObj !!styles)
        /// Styles applied to the root element if `position="alternate"`.
        static member inline positionAlternate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineOppositeContent.styleOverrides.positionAlternate", createObj !!styles)

      [<Erase>]
      type muiTimelineSeparator =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTimelineSeparator", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTimelineSeparator.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiToggleButton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiToggleButton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.root", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.disabled", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.selected", createObj !!styles)
        /// State class applied to the root element if `color="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.standard", createObj !!styles)
        /// State class applied to the root element if `color="primary"`.
        static member inline primary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.primary", createObj !!styles)
        /// State class applied to the root element if `color="secondary"`.
        static member inline secondary(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.secondary", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButton.styleOverrides.sizeLarge", createObj !!styles)

      [<Erase>]
      type muiToggleButtonGroup =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiToggleButtonGroup", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButtonGroup.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButtonGroup.styleOverrides.vertical", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButtonGroup.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the children.
        static member inline grouped(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButtonGroup.styleOverrides.grouped", createObj !!styles)
        /// Styles applied to the children if `orientation="horizontal"`.
        static member inline groupedHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButtonGroup.styleOverrides.groupedHorizontal", createObj !!styles)
        /// Styles applied to the children if `orientation="vertical"`.
        static member inline groupedVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToggleButtonGroup.styleOverrides.groupedVertical", createObj !!styles)

      [<Erase>]
      type muiToolbar =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiToolbar", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToolbar.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToolbar.styleOverrides.gutters", createObj !!styles)
        /// Styles applied to the root element if `variant="regular"`.
        static member inline regular(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToolbar.styleOverrides.regular", createObj !!styles)
        /// Styles applied to the root element if `variant="dense"`.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiToolbar.styleOverrides.dense", createObj !!styles)

      [<Erase>]
      type muiTooltip =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTooltip", values)
        /// Styles applied to the Popper component.
        static member inline popper(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.popper", createObj !!styles)
        /// Styles applied to the Popper component unless `disableInteractive={true}`.
        static member inline popperInteractive(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.popperInteractive", createObj !!styles)
        /// Styles applied to the Popper component if `arrow={true}`.
        static member inline popperArrow(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.popperArrow", createObj !!styles)
        /// Styles applied to the Popper component unless the tooltip is open.
        static member inline popperClose(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.popperClose", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element.
        static member inline tooltip(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.tooltip", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `arrow={true}`.
        static member inline tooltipArrow(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.tooltipArrow", createObj !!styles)
        /// Styles applied to the arrow element.
        static member inline arrow(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.arrow", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
        static member inline touch(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.touch", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
        static member inline tooltipPlacementLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.tooltipPlacementLeft", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
        static member inline tooltipPlacementRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.tooltipPlacementRight", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
        static member inline tooltipPlacementTop(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.tooltipPlacementTop", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
        static member inline tooltipPlacementBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTooltip.styleOverrides.tooltipPlacementBottom", createObj !!styles)

      [<Erase>]
      type muiTreeItem =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTreeItem", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.root", createObj !!styles)
        /// Styles applied to the transition component.
        static member inline group(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.group", createObj !!styles)
        /// Styles applied to the content element.
        static member inline content(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.content", createObj !!styles)
        /// State class applied to the content element when expanded.
        static member inline expanded(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.expanded", createObj !!styles)
        /// State class applied to the content element when selected.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.selected", createObj !!styles)
        /// State class applied to the content element when focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.focused", createObj !!styles)
        /// State class applied to the element when disabled.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.disabled", createObj !!styles)
        /// Styles applied to the tree node icon.
        static member inline iconContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.iconContainer", createObj !!styles)
        /// Styles applied to the label element.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeItem.styleOverrides.label", createObj !!styles)

      [<Erase>]
      type muiTreeView =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTreeView", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTreeView.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiTypography =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiTypography", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `variant="body2"`.
        static member inline body2(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.body2", createObj !!styles)
        /// Styles applied to the root element if `variant="body1"`.
        static member inline body1(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.body1", createObj !!styles)
        /// Styles applied to the root element if `variant="caption"`.
        static member inline caption(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.caption", createObj !!styles)
        /// Styles applied to the root element if `variant="button"`.
        static member inline button(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.button", createObj !!styles)
        /// Styles applied to the root element if `variant="h1"`.
        static member inline h1(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.h1", createObj !!styles)
        /// Styles applied to the root element if `variant="h2"`.
        static member inline h2(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.h2", createObj !!styles)
        /// Styles applied to the root element if `variant="h3"`.
        static member inline h3(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.h3", createObj !!styles)
        /// Styles applied to the root element if `variant="h4"`.
        static member inline h4(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.h4", createObj !!styles)
        /// Styles applied to the root element if `variant="h5"`.
        static member inline h5(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.h5", createObj !!styles)
        /// Styles applied to the root element if `variant="h6"`.
        static member inline h6(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.h6", createObj !!styles)
        /// Styles applied to the root element if `variant="subtitle1"`.
        static member inline subtitle1(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.subtitle1", createObj !!styles)
        /// Styles applied to the root element if `variant="subtitle2"`.
        static member inline subtitle2(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.subtitle2", createObj !!styles)
        /// Styles applied to the root element if `variant="overline"`.
        static member inline overline(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.overline", createObj !!styles)
        /// Styles applied to the root element if `variant="inherit"`.
        static member inline inherit'(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.inherit", createObj !!styles)
        /// Styles applied to the root element if `align="left"`.
        static member inline alignLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.alignLeft", createObj !!styles)
        /// Styles applied to the root element if `align="center"`.
        static member inline alignCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.alignCenter", createObj !!styles)
        /// Styles applied to the root element if `align="right"`.
        static member inline alignRight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.alignRight", createObj !!styles)
        /// Styles applied to the root element if `align="justify"`.
        static member inline alignJustify(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.alignJustify", createObj !!styles)
        /// Styles applied to the root element if `nowrap={true}`.
        static member inline noWrap(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.noWrap", createObj !!styles)
        /// Styles applied to the root element if `gutterBottom={true}`.
        static member inline gutterBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.gutterBottom", createObj !!styles)
        /// Styles applied to the root element if `paragraph={true}`.
        static member inline paragraph(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiTypography.styleOverrides.paragraph", createObj !!styles)

      [<Erase>]
      type muiCalendarPicker =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCalendarPicker", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPicker.styleOverrides.root", createObj !!styles)
        /// Styles applied to the transition group element.
        static member inline viewTransitionContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPicker.styleOverrides.viewTransitionContainer", createObj !!styles)

      [<Erase>]
      type muiCalendarPickerSkeleton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCalendarPickerSkeleton", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPickerSkeleton.styleOverrides.root", createObj !!styles)
        /// Styles applied to the week element.
        static member inline week(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPickerSkeleton.styleOverrides.week", createObj !!styles)
        /// Styles applied to the day element.
        static member inline daySkeleton(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPickerSkeleton.styleOverrides.daySkeleton", createObj !!styles)

      [<Erase>]
      type muiClockPicker =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiClockPicker", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiClockPicker.styleOverrides.root", createObj !!styles)
        /// Styles applied to the arrowSwitcher element.
        static member inline arrowSwitcher(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiClockPicker.styleOverrides.arrowSwitcher", createObj !!styles)

      [<Erase>]
      type muiDateRangePickerDay =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDateRangePickerDay", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `isHighlighting=true` and `outsideCurrentMonth=false`.
        static member inline rangeIntervalDayHighlight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayHighlight", createObj !!styles)
        /// Styles applied to the root element if `isStartOfHighlighting=true` or `day` is the start of the month.
        static member inline rangeIntervalDayHighlightStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayHighlightStart", createObj !!styles)
        /// Styles applied to the root element if `isEndOfHighlighting=true` or `day` is the end of the month.
        static member inline rangeIntervalDayHighlightEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayHighlightEnd", createObj !!styles)
        /// Styles applied to the preview element.
        static member inline rangeIntervalPreview(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalPreview", createObj !!styles)
        /// Styles applied to the root element if `isPreviewing=true` and `outsideCurrentMonth=false`.
        static member inline rangeIntervalDayPreview(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayPreview", createObj !!styles)
        /// Styles applied to the root element if `isStartOfPreviewing=true` or `day` is the start of the month.
        static member inline rangeIntervalDayPreviewStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayPreviewStart", createObj !!styles)
        /// Styles applied to the root element if `isEndOfPreviewing=true` or `day` is the end of the month.
        static member inline rangeIntervalDayPreviewEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayPreviewEnd", createObj !!styles)
        /// Styles applied to the day element.
        static member inline day(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.day", createObj !!styles)
        /// Styles applied to the day element if `isHighlighting=false`.
        static member inline dayOutsideRangeInterval(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.dayOutsideRangeInterval", createObj !!styles)
        /// Styles applied to the day element if `selected=false` and `isHighlighting=true`.
        static member inline dayInsideRangeInterval(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.dayInsideRangeInterval", createObj !!styles)
        /// Styles applied to the day element if `selected=false`.
        static member inline notSelectedDate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.notSelectedDate", createObj !!styles)

      [<Erase>]
      type muiMonthPicker =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiMonthPicker", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMonthPicker.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiPickersDay =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiPickersDay", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `disableMargin=false`.
        static member inline dayWithMargin(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.dayWithMargin", createObj !!styles)
        /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=true`.
        static member inline dayOutsideMonth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.dayOutsideMonth", createObj !!styles)
        /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=false`.
        static member inline hiddenDaySpacingFiller(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.hiddenDaySpacingFiller", createObj !!styles)
        /// Styles applied to the root element if `disableHighlightToday=false` and `today=true`.
        static member inline today(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.today", createObj !!styles)
        /// State class applied to the root element if `selected=true`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.selected", createObj !!styles)
        /// State class applied to the root element if `disabled=true`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.disabled", createObj !!styles)

      [<Erase>]
      type muiYearPicker =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiYearPicker", values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiYearPicker.styleOverrides.root", createObj !!styles)
