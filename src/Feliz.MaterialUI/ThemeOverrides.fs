namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module themeOverrides =

  module theme =

    module overrides =

      [<Erase>]
      type muiAccordion =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordion.root", createObj !!styles)
        /// Styles applied to the root element unless `square={true}`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordion.rounded", createObj !!styles)
        /// State class applied to the root element if `expanded={true}`.
        static member inline expanded(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordion.expanded", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordion.disabled", createObj !!styles)
        /// Styles applied to the root element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordion.gutters", createObj !!styles)
        /// Styles applied to the region element, the container of the children.
        static member inline region(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordion.region", createObj !!styles)

      [<Erase>]
      type muiAccordionActions =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionActions.root", createObj !!styles)
        /// Styles applied to the root element unless `disableSpacing={true}`.
        static member inline spacing(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionActions.spacing", createObj !!styles)

      [<Erase>]
      type muiAccordionDetails =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionDetails.root", createObj !!styles)

      [<Erase>]
      type muiAccordionSummary =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionSummary.root", createObj !!styles)
        /// State class applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
        static member inline expanded(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionSummary.expanded", createObj !!styles)
        /// State class applied to the ButtonBase root element if the button is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionSummary.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionSummary.disabled", createObj !!styles)
        /// Styles applied to the root element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionSummary.gutters", createObj !!styles)
        /// Styles applied to the children wrapper element unless `disableGutters={true}`.
        static member inline contentGutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionSummary.contentGutters", createObj !!styles)
        /// Styles applied to the children wrapper element.
        static member inline content(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionSummary.content", createObj !!styles)
        /// Styles applied to the `expandIcon`'s wrapper element.
        static member inline expandIconWrapper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAccordionSummary.expandIconWrapper", createObj !!styles)

      [<Erase>]
      type muiAlert =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.root", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.standard", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"` and `color="success"`.
        static member inline standardSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.standardSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"` and `color="info"`.
        static member inline standardInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.standardInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"` and `color="warning"`.
        static member inline standardWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.standardWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"` and `color="error"`.
        static member inline standardError(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.standardError", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="success"`.
        static member inline outlinedSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.outlinedSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="info"`.
        static member inline outlinedInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.outlinedInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="warning"`.
        static member inline outlinedWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.outlinedWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="error"`.
        static member inline outlinedError(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.outlinedError", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="success"`.
        static member inline filledSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.filledSuccess", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="info"`.
        static member inline filledInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.filledInfo", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="warning"`.
        static member inline filledWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.filledWarning", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` and `color="error"`.
        static member inline filledError(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.filledError", createObj !!styles)
        /// Styles applied to the icon wrapper element.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.icon", createObj !!styles)
        /// Styles applied to the message wrapper element.
        static member inline message(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.message", createObj !!styles)
        /// Styles applied to the action wrapper element if `action` is provided.
        static member inline action(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlert.action", createObj !!styles)

      [<Erase>]
      type muiAlertTitle =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAlertTitle.root", createObj !!styles)

      [<Erase>]
      type muiAppBar =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.root", createObj !!styles)
        /// Styles applied to the root element if `position="fixed"`.
        static member inline positionFixed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.positionFixed", createObj !!styles)
        /// Styles applied to the root element if `position="absolute"`.
        static member inline positionAbsolute(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.positionAbsolute", createObj !!styles)
        /// Styles applied to the root element if `position="sticky"`.
        static member inline positionSticky(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.positionSticky", createObj !!styles)
        /// Styles applied to the root element if `position="static"`.
        static member inline positionStatic(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.positionStatic", createObj !!styles)
        /// Styles applied to the root element if `position="relative"`.
        static member inline positionRelative(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.positionRelative", createObj !!styles)
        /// Styles applied to the root element if `color="default"`.
        static member inline colorDefault(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.colorDefault", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `color="transparent"`.
        static member inline colorTransparent(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAppBar.colorTransparent", createObj !!styles)

      [<Erase>]
      type muiAutocomplete =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.root", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.fullWidth", createObj !!styles)
        /// State class applied to the root element if focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.focused", createObj !!styles)
        /// Styles applied to the tag elements, e.g. the chips.
        static member inline tag(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.tag", createObj !!styles)
        /// Styles applied to the tag elements, e.g. the chips if `size="small"`.
        static member inline tagSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.tagSizeSmall", createObj !!styles)
        /// Styles applied to the tag elements, e.g. the chips if `size="medium"`.
        static member inline tagSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.tagSizeMedium", createObj !!styles)
        /// Styles applied when the popup icon is rendered.
        static member inline hasPopupIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.hasPopupIcon", createObj !!styles)
        /// Styles applied when the clear icon is rendered.
        static member inline hasClearIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.hasClearIcon", createObj !!styles)
        /// Styles applied to the Input element.
        static member inline inputRoot(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.inputRoot", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.input", createObj !!styles)
        /// Styles applied to the input element if tag focused.
        static member inline inputFocused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.inputFocused", createObj !!styles)
        /// Styles applied to the endAdornment element.
        static member inline endAdornment(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.endAdornment", createObj !!styles)
        /// Styles applied to the clear indicator.
        static member inline clearIndicator(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.clearIndicator", createObj !!styles)
        /// Styles applied to the popup indicator.
        static member inline popupIndicator(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.popupIndicator", createObj !!styles)
        /// Styles applied to the popup indicator if the popup is open.
        static member inline popupIndicatorOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.popupIndicatorOpen", createObj !!styles)
        /// Styles applied to the popper element.
        static member inline popper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.popper", createObj !!styles)
        /// Styles applied to the popper element if `disablePortal={true}`.
        static member inline popperDisablePortal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.popperDisablePortal", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.paper", createObj !!styles)
        /// Styles applied to the listbox component.
        static member inline listbox(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.listbox", createObj !!styles)
        /// Styles applied to the loading wrapper.
        static member inline loading(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.loading", createObj !!styles)
        /// Styles applied to the no option wrapper.
        static member inline noOptions(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.noOptions", createObj !!styles)
        /// Styles applied to the option elements.
        static member inline option(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.option", createObj !!styles)
        /// Styles applied to the group's label elements.
        static member inline groupLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.groupLabel", createObj !!styles)
        /// Styles applied to the group's ul elements.
        static member inline groupUl(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAutocomplete.groupUl", createObj !!styles)

      [<Erase>]
      type muiAvatar =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatar.root", createObj !!styles)
        /// Styles applied to the root element if not `src` or `srcSet`.
        static member inline colorDefault(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatar.colorDefault", createObj !!styles)
        /// Styles applied to the root element if `variant="circular"`.
        static member inline circular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatar.circular", createObj !!styles)
        /// Styles applied to the root element if `variant="rounded"`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatar.rounded", createObj !!styles)
        /// Styles applied to the root element if `variant="square"`.
        static member inline square(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatar.square", createObj !!styles)
        /// Styles applied to the img element if either `src` or `srcSet` is defined.
        static member inline img(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatar.img", createObj !!styles)
        /// Styles applied to the fallback icon
        static member inline fallback(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatar.fallback", createObj !!styles)

      [<Erase>]
      type muiAvatarGroup =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatarGroup.root", createObj !!styles)
        /// Styles applied to the avatar elements.
        static member inline avatar(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiAvatarGroup.avatar", createObj !!styles)

      [<Erase>]
      type muiBackdrop =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBackdrop.root", createObj !!styles)
        /// Styles applied to the root element if `invisible={true}`.
        static member inline invisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBackdrop.invisible", createObj !!styles)

      [<Erase>]
      type muiBackdropUnstyled =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBackdropUnstyled.root", createObj !!styles)
        /// Styles applied to the root element if `invisible={true}`.
        static member inline invisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBackdropUnstyled.invisible", createObj !!styles)

      [<Erase>]
      type muiBadge =
        /// Class name applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.root", createObj !!styles)
        /// Class name applied to the badge `span` element.
        static member inline badge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.badge", createObj !!styles)
        /// Class name applied to the badge `span` element if `variant="dot"`.
        static member inline dot(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.dot", createObj !!styles)
        /// Class name applied to the badge `span` element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.standard", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }}`.
        static member inline anchorOriginTopRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginTopRight", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }}`.
        static member inline anchorOriginBottomRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginBottomRight", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }}`.
        static member inline anchorOriginTopLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginTopLeft", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }}`.
        static member inline anchorOriginBottomLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginBottomLeft", createObj !!styles)
        /// State class applied to the badge `span` element if `invisible={true}`.
        static member inline invisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.invisible", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.colorPrimary", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.colorSecondary", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="error"`.
        static member inline colorError(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.colorError", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="info"`.
        static member inline colorInfo(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.colorInfo", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="success"`.
        static member inline colorSuccess(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.colorSuccess", createObj !!styles)
        /// Styles applied to the badge `span` element if `color="warning"`.
        static member inline colorWarning(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.colorWarning", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }} overlap="rectangular"`.
        static member inline anchorOriginTopRightRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginTopRightRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }} overlap="rectangular"`.
        static member inline anchorOriginBottomRightRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginBottomRightRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }} overlap="rectangular"`.
        static member inline anchorOriginTopLeftRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginTopLeftRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }} overlap="rectangular"`.
        static member inline anchorOriginBottomLeftRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginBottomLeftRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }} overlap="circular"`.
        static member inline anchorOriginTopRightCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginTopRightCircular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }} overlap="circular"`.
        static member inline anchorOriginBottomRightCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginBottomRightCircular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }} overlap="circular"`.
        static member inline anchorOriginTopLeftCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginTopLeftCircular", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }} overlap="circular"`.
        static member inline anchorOriginBottomLeftCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.anchorOriginBottomLeftCircular", createObj !!styles)
        /// Class name applied to the badge `span` element if `overlap="rectangular"`.
        static member inline overlapRectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.overlapRectangular", createObj !!styles)
        /// Class name applied to the badge `span` element if `overlap="circular"`.
        static member inline overlapCircular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadge.overlapCircular", createObj !!styles)

      [<Erase>]
      type muiBadgeUnstyled =
        /// Class name applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.root", createObj !!styles)
        /// Class name applied to the badge `span` element.
        static member inline badge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.badge", createObj !!styles)
        /// Class name applied to the badge `span` element if `variant="dot"`.
        static member inline dot(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.dot", createObj !!styles)
        /// Class name applied to the badge `span` element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.standard", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }}`.
        static member inline anchorOriginTopRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.anchorOriginTopRight", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }}`.
        static member inline anchorOriginBottomRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.anchorOriginBottomRight", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }}`.
        static member inline anchorOriginTopLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.anchorOriginTopLeft", createObj !!styles)
        /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }}`.
        static member inline anchorOriginBottomLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.anchorOriginBottomLeft", createObj !!styles)
        /// State class applied to the badge `span` element if `invisible={true}`.
        static member inline invisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBadgeUnstyled.invisible", createObj !!styles)

      [<Erase>]
      type muiBottomNavigation =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBottomNavigation.root", createObj !!styles)

      [<Erase>]
      type muiBottomNavigationAction =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBottomNavigationAction.root", createObj !!styles)
        /// State class applied to the root element if selected.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBottomNavigationAction.selected", createObj !!styles)
        /// State class applied to the root element if `showLabel={false}` and not selected.
        static member inline iconOnly(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBottomNavigationAction.iconOnly", createObj !!styles)
        /// Styles applied to the label's span element.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBottomNavigationAction.label", createObj !!styles)

      [<Erase>]
      type muiBreadcrumbs =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBreadcrumbs.root", createObj !!styles)
        /// Styles applied to the ol element.
        static member inline ol(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBreadcrumbs.ol", createObj !!styles)
        /// Styles applied to the li element.
        static member inline li(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBreadcrumbs.li", createObj !!styles)
        /// Styles applied to the separator element.
        static member inline separator(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiBreadcrumbs.separator", createObj !!styles)

      [<Erase>]
      type muiButton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.root", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.text", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="inherit"`.
        static member inline textInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.textInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="primary"`.
        static member inline textPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.textPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
        static member inline textSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.textSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="inherit"`.
        static member inline outlinedInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.outlinedInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.outlinedSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"`.
        static member inline contained(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.contained", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="inherit"`.
        static member inline containedInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.containedInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
        static member inline containedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.containedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
        static member inline containedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.containedSecondary", createObj !!styles)
        /// Styles applied to the root element if `disableElevation={true}`.
        static member inline disableElevation(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.disableElevation", createObj !!styles)
        /// State class applied to the ButtonBase root element if the button is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.disabled", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="text"`.
        static member inline textSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.textSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="text"`.
        static member inline textSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.textSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="text"`.
        static member inline textSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.textSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="outlined"`.
        static member inline outlinedSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.outlinedSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="outlined"`.
        static member inline outlinedSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.outlinedSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="outlined"`.
        static member inline outlinedSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.outlinedSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="contained"`.
        static member inline containedSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.containedSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="contained"`.
        static member inline containedSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.containedSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="contained"`.
        static member inline containedSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.containedSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.sizeLarge", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.fullWidth", createObj !!styles)
        /// Styles applied to the startIcon element if supplied.
        static member inline startIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.startIcon", createObj !!styles)
        /// Styles applied to the endIcon element if supplied.
        static member inline endIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.endIcon", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="small"`.
        static member inline iconSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.iconSizeSmall", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="medium"`.
        static member inline iconSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.iconSizeMedium", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="large"`.
        static member inline iconSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButton.iconSizeLarge", createObj !!styles)

      [<Erase>]
      type muiButtonBase =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonBase.root", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonBase.disabled", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonBase.focusVisible", createObj !!styles)

      [<Erase>]
      type muiButtonGroup =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.root", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"`.
        static member inline contained(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.contained", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.text", createObj !!styles)
        /// Styles applied to the root element if `disableElevation={true}`.
        static member inline disableElevation(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.disableElevation", createObj !!styles)
        /// State class applied to the child elements if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.disabled", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.fullWidth", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.vertical", createObj !!styles)
        /// Styles applied to the children.
        static member inline grouped(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.grouped", createObj !!styles)
        /// Styles applied to the children if `orientation="horizontal"`.
        static member inline groupedHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedHorizontal", createObj !!styles)
        /// Styles applied to the children if `orientation="vertical"`.
        static member inline groupedVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedVertical", createObj !!styles)
        /// Styles applied to the children if `variant="text"`.
        static member inline groupedText(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedText", createObj !!styles)
        /// Styles applied to the children if `variant="text"` and `orientation="horizontal"`.
        static member inline groupedTextHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedTextHorizontal", createObj !!styles)
        /// Styles applied to the children if `variant="text"` and `orientation="vertical"`.
        static member inline groupedTextVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedTextVertical", createObj !!styles)
        /// Styles applied to the children if `variant="text"` and `color="primary"`.
        static member inline groupedTextPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedTextPrimary", createObj !!styles)
        /// Styles applied to the children if `variant="text"` and `color="secondary"`.
        static member inline groupedTextSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedTextSecondary", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"`.
        static member inline groupedOutlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedOutlined", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"` and `orientation="horizontal"`.
        static member inline groupedOutlinedHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedOutlinedHorizontal", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"` and `orientation="vertical"`.
        static member inline groupedOutlinedVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedOutlinedVertical", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"` and `color="primary"`.
        static member inline groupedOutlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedOutlinedPrimary", createObj !!styles)
        /// Styles applied to the children if `variant="outlined"` and `color="secondary"`.
        static member inline groupedOutlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedOutlinedSecondary", createObj !!styles)
        /// Styles applied to the children if `variant="contained"`.
        static member inline groupedContained(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedContained", createObj !!styles)
        /// Styles applied to the children if `variant="contained"` and `orientation="horizontal"`.
        static member inline groupedContainedHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedContainedHorizontal", createObj !!styles)
        /// Styles applied to the children if `variant="contained"` and `orientation="vertical"`.
        static member inline groupedContainedVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedContainedVertical", createObj !!styles)
        /// Styles applied to the children if `variant="contained"` and `color="primary"`.
        static member inline groupedContainedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedContainedPrimary", createObj !!styles)
        /// Styles applied to the children if `variant="contained"` and `color="secondary"`.
        static member inline groupedContainedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiButtonGroup.groupedContainedSecondary", createObj !!styles)

      [<Erase>]
      type muiCalendarPicker =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCalendarPicker.root", createObj !!styles)
        /// Styles applied to the transition group element.
        static member inline viewTransitionContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCalendarPicker.viewTransitionContainer", createObj !!styles)

      [<Erase>]
      type muiCalendarPickerSkeleton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCalendarPickerSkeleton.root", createObj !!styles)
        /// Styles applied to the week element.
        static member inline week(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCalendarPickerSkeleton.week", createObj !!styles)
        /// Styles applied to the day element.
        static member inline daySkeleton(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCalendarPickerSkeleton.daySkeleton", createObj !!styles)

      [<Erase>]
      type muiCard =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCard.root", createObj !!styles)

      [<Erase>]
      type muiCardActionArea =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardActionArea.root", createObj !!styles)
        /// State class applied to the ButtonBase root element if the action area is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardActionArea.focusVisible", createObj !!styles)
        /// Styles applied to the overlay that covers the action area when it is keyboard focused.
        static member inline focusHighlight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardActionArea.focusHighlight", createObj !!styles)

      [<Erase>]
      type muiCardActions =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardActions.root", createObj !!styles)
        /// Styles applied to the root element unless `disableSpacing={true}`.
        static member inline spacing(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardActions.spacing", createObj !!styles)

      [<Erase>]
      type muiCardContent =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardContent.root", createObj !!styles)

      [<Erase>]
      type muiCardHeader =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardHeader.root", createObj !!styles)
        /// Styles applied to the avatar element.
        static member inline avatar(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardHeader.avatar", createObj !!styles)
        /// Styles applied to the action element.
        static member inline action(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardHeader.action", createObj !!styles)
        /// Styles applied to the content wrapper element.
        static member inline content(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardHeader.content", createObj !!styles)
        /// Styles applied to the title Typography element.
        static member inline title(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardHeader.title", createObj !!styles)
        /// Styles applied to the subheader Typography element.
        static member inline subheader(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardHeader.subheader", createObj !!styles)

      [<Erase>]
      type muiCardMedia =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardMedia.root", createObj !!styles)
        /// Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.
        static member inline media(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardMedia.media", createObj !!styles)
        /// Styles applied to the root element if `component="picture or img"`.
        static member inline img(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCardMedia.img", createObj !!styles)

      [<Erase>]
      type muiCheckbox =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCheckbox.root", createObj !!styles)
        /// State class applied to the root element if `checked={true}`.
        static member inline checked'(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCheckbox.checked", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCheckbox.disabled", createObj !!styles)
        /// State class applied to the root element if `indeterminate={true}`.
        static member inline indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCheckbox.indeterminate", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCheckbox.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCheckbox.colorSecondary", createObj !!styles)

      [<Erase>]
      type muiChip =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.root", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.colorSecondary", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.disabled", createObj !!styles)
        /// Styles applied to the root element if `onClick` is defined or `clickable={true}`.
        static member inline clickable(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.clickable", createObj !!styles)
        /// Styles applied to the root element if `onClick` and `color="primary"` is defined or `clickable={true}`.
        static member inline clickableColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.clickableColorPrimary", createObj !!styles)
        /// Styles applied to the root element if `onClick` and `color="secondary"` is defined or `clickable={true}`.
        static member inline clickableColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.clickableColorSecondary", createObj !!styles)
        /// Styles applied to the root element if `onDelete` is defined.
        static member inline deletable(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deletable", createObj !!styles)
        /// Styles applied to the root element if `onDelete` and `color="primary"` is defined.
        static member inline deletableColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deletableColorPrimary", createObj !!styles)
        /// Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
        static member inline deletableColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deletableColorSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.outlinedSecondary", createObj !!styles)
        /// Styles applied to the avatar element.
        static member inline avatar(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.avatar", createObj !!styles)
        /// Styles applied to the avatar element if `size="small"`.
        static member inline avatarSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.avatarSmall", createObj !!styles)
        /// Styles applied to the avatar element if `size="medium"`.
        static member inline avatarMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.avatarMedium", createObj !!styles)
        /// Styles applied to the avatar element if `color="primary"`.
        static member inline avatarColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.avatarColorPrimary", createObj !!styles)
        /// Styles applied to the avatar element if `color="secondary"`.
        static member inline avatarColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.avatarColorSecondary", createObj !!styles)
        /// Styles applied to the icon element.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.icon", createObj !!styles)
        /// Styles applied to the icon element if `size="small"`.
        static member inline iconSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.iconSmall", createObj !!styles)
        /// Styles applied to the icon element if `size="medium"`.
        static member inline iconMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.iconMedium", createObj !!styles)
        /// Styles applied to the icon element if `color="primary"`.
        static member inline iconColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.iconColorPrimary", createObj !!styles)
        /// Styles applied to the icon element if `color="secondary"`.
        static member inline iconColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.iconColorSecondary", createObj !!styles)
        /// Styles applied to the label `span` element.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.label", createObj !!styles)
        /// Styles applied to the label `span` element if `size="small"`.
        static member inline labelSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.labelSmall", createObj !!styles)
        /// Styles applied to the label `span` element if `size="medium"`.
        static member inline labelMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.labelMedium", createObj !!styles)
        /// Styles applied to the deleteIcon element.
        static member inline deleteIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deleteIcon", createObj !!styles)
        /// Styles applied to the deleteIcon element if `size="small"`.
        static member inline deleteIconSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deleteIconSmall", createObj !!styles)
        /// Styles applied to the deleteIcon element if `size="medium"`.
        static member inline deleteIconMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deleteIconMedium", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="primary"` and `variant="filled"`.
        static member inline deleteIconColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deleteIconColorPrimary", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="filled"`.
        static member inline deleteIconColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deleteIconColorSecondary", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
        static member inline deleteIconOutlinedColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deleteIconOutlinedColorPrimary", createObj !!styles)
        /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.
        static member inline deleteIconOutlinedColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.deleteIconOutlinedColorSecondary", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiChip.focusVisible", createObj !!styles)

      [<Erase>]
      type muiCircularProgress =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.root", createObj !!styles)
        /// Styles applied to the root element if `variant="determinate"`.
        static member inline determinate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.determinate", createObj !!styles)
        /// Styles applied to the root element if `variant="indeterminate"`.
        static member inline indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.indeterminate", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.colorSecondary", createObj !!styles)
        /// Styles applied to the svg element.
        static member inline svg(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.svg", createObj !!styles)
        /// Styles applied to the `circle` svg path.
        static member inline circle(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.circle", createObj !!styles)
        /// Styles applied to the `circle` svg path if `variant="determinate"`.
        static member inline circleDeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.circleDeterminate", createObj !!styles)
        /// Styles applied to the `circle` svg path if `variant="indeterminate"`.
        static member inline circleIndeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.circleIndeterminate", createObj !!styles)
        /// Styles applied to the `circle` svg path if `disableShrink={true}`.
        static member inline circleDisableShrink(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCircularProgress.circleDisableShrink", createObj !!styles)

      [<Erase>]
      type muiClockPicker =
        /// Styles applied to the arrowSwitcher element.
        static member inline arrowSwitcher(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiClockPicker.arrowSwitcher", createObj !!styles)

      [<Erase>]
      type muiCollapse =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCollapse.root", createObj !!styles)
        /// State class applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCollapse.horizontal", createObj !!styles)
        /// Styles applied to the root element when the transition has entered.
        static member inline entered(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCollapse.entered", createObj !!styles)
        /// Styles applied to the root element when the transition has exited and `collapsedSize` = 0px.
        static member inline hidden(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCollapse.hidden", createObj !!styles)
        /// Styles applied to the outer wrapper element.
        static member inline wrapper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCollapse.wrapper", createObj !!styles)
        /// Styles applied to the inner wrapper element.
        static member inline wrapperInner(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiCollapse.wrapperInner", createObj !!styles)

      [<Erase>]
      type muiContainer =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiContainer.root", createObj !!styles)
        /// Styles applied to the root element if `disableGutters={true}`.
        static member inline disableGutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiContainer.disableGutters", createObj !!styles)
        /// Styles applied to the root element if `fixed={true}`.
        static member inline fixed'(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiContainer.fixed", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="xs"`.
        static member inline maxWidthXs(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiContainer.maxWidthXs", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="sm"`.
        static member inline maxWidthSm(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiContainer.maxWidthSm", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="md"`.
        static member inline maxWidthMd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiContainer.maxWidthMd", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="lg"`.
        static member inline maxWidthLg(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiContainer.maxWidthLg", createObj !!styles)
        /// Styles applied to the root element if `maxWidth="xl"`.
        static member inline maxWidthXl(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiContainer.maxWidthXl", createObj !!styles)

      [<Erase>]
      type muiDateRangePickerDay =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.root", createObj !!styles)
        /// Styles applied to the root element if `isHighlighting=true` and `outsideCurrentMonth=false`.
        static member inline rangeIntervalDayHighlight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.rangeIntervalDayHighlight", createObj !!styles)
        /// Styles applied to the root element if `isStartOfHighlighting=true` or `day` is the start of the month.
        static member inline rangeIntervalDayHighlightStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.rangeIntervalDayHighlightStart", createObj !!styles)
        /// Styles applied to the root element if `isEndOfHighlighting=true` or `day` is the end of the month.
        static member inline rangeIntervalDayHighlightEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.rangeIntervalDayHighlightEnd", createObj !!styles)
        /// Styles applied to the preview element.
        static member inline rangeIntervalPreview(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.rangeIntervalPreview", createObj !!styles)
        /// Styles applied to the root element if `isPreviewing=true` and `outsideCurrentMonth=false`.
        static member inline rangeIntervalDayPreview(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.rangeIntervalDayPreview", createObj !!styles)
        /// Styles applied to the root element if `isStartOfPreviewing=true` or `day` is the start of the month.
        static member inline rangeIntervalDayPreviewStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.rangeIntervalDayPreviewStart", createObj !!styles)
        /// Styles applied to the root element if `isEndOfPreviewing=true` or `day` is the end of the month.
        static member inline rangeIntervalDayPreviewEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.rangeIntervalDayPreviewEnd", createObj !!styles)
        /// Styles applied to the day element.
        static member inline day(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.day", createObj !!styles)
        /// Styles applied to the day element if `isHighlighting=false`.
        static member inline dayOutsideRangeInterval(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.dayOutsideRangeInterval", createObj !!styles)
        /// Styles applied to the day element if `selected=false` and `isHighlighting=true`.
        static member inline dayInsideRangeInterval(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.dayInsideRangeInterval", createObj !!styles)
        /// Styles applied to the day element if `selected=false`.
        static member inline notSelectedDate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDateRangePickerDay.notSelectedDate", createObj !!styles)

      [<Erase>]
      type muiDialog =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.root", createObj !!styles)
        /// Styles applied to the container element if `scroll="paper"`.
        static member inline scrollPaper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.scrollPaper", createObj !!styles)
        /// Styles applied to the container element if `scroll="body"`.
        static member inline scrollBody(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.scrollBody", createObj !!styles)
        /// Styles applied to the container element.
        static member inline container(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.container", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paper", createObj !!styles)
        /// Styles applied to the Paper component if `scroll="paper"`.
        static member inline paperScrollPaper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperScrollPaper", createObj !!styles)
        /// Styles applied to the Paper component if `scroll="body"`.
        static member inline paperScrollBody(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperScrollBody", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth=false`.
        static member inline paperWidthFalse(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperWidthFalse", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="xs"`.
        static member inline paperWidthXs(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperWidthXs", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="sm"`.
        static member inline paperWidthSm(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperWidthSm", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="md"`.
        static member inline paperWidthMd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperWidthMd", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="lg"`.
        static member inline paperWidthLg(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperWidthLg", createObj !!styles)
        /// Styles applied to the Paper component if `maxWidth="xl"`.
        static member inline paperWidthXl(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperWidthXl", createObj !!styles)
        /// Styles applied to the Paper component if `fullWidth={true}`.
        static member inline paperFullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperFullWidth", createObj !!styles)
        /// Styles applied to the Paper component if `fullScreen={true}`.
        static member inline paperFullScreen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialog.paperFullScreen", createObj !!styles)

      [<Erase>]
      type muiDialogActions =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialogActions.root", createObj !!styles)
        /// Styles applied to the root element unless `disableSpacing={true}`.
        static member inline spacing(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialogActions.spacing", createObj !!styles)

      [<Erase>]
      type muiDialogContent =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialogContent.root", createObj !!styles)
        /// Styles applied to the root element if `dividers={true}`.
        static member inline dividers(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialogContent.dividers", createObj !!styles)

      [<Erase>]
      type muiDialogContentText =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialogContentText.root", createObj !!styles)

      [<Erase>]
      type muiDialogTitle =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDialogTitle.root", createObj !!styles)

      [<Erase>]
      type muiDivider =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.root", createObj !!styles)
        /// Styles applied to the root element if `absolute={true}`.
        static member inline absolute(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.absolute", createObj !!styles)
        /// Styles applied to the root element if `variant="inset"`.
        static member inline inset(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.inset", createObj !!styles)
        /// Styles applied to the root element if `variant="fullWidth"`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.fullWidth", createObj !!styles)
        /// Styles applied to the root element if `light={true}`.
        static member inline light(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.light", createObj !!styles)
        /// Styles applied to the root element if `variant="middle"`.
        static member inline middle(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.middle", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.vertical", createObj !!styles)
        /// Styles applied to the root element if `flexItem={true}`.
        static member inline flexItem(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.flexItem", createObj !!styles)
        /// Styles applied to the root element if divider have text.
        static member inline withChildren(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.withChildren", createObj !!styles)
        /// Styles applied to the root element if divider have text and `orientation="vertical"`.
        static member inline withChildrenVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.withChildrenVertical", createObj !!styles)
        /// Styles applied to the root element if `textAlign="right" orientation="horizontal"`.
        static member inline textAlignRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.textAlignRight", createObj !!styles)
        /// Styles applied to the root element if `textAlign="left" orientation="horizontal"`.
        static member inline textAlignLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.textAlignLeft", createObj !!styles)
        /// Styles applied to the span children element if `orientation="horizontal"`.
        static member inline wrapper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.wrapper", createObj !!styles)
        /// Styles applied to the span children element if `orientation="vertical"`.
        static member inline wrapperVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDivider.wrapperVertical", createObj !!styles)

      [<Erase>]
      type muiDrawer =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.root", createObj !!styles)
        /// Styles applied to the root element if `variant="permanent or persistent"`.
        static member inline docked(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.docked", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paper", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="left"`.
        static member inline paperAnchorLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paperAnchorLeft", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="right"`.
        static member inline paperAnchorRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paperAnchorRight", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="top"`.
        static member inline paperAnchorTop(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paperAnchorTop", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="bottom"`.
        static member inline paperAnchorBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paperAnchorBottom", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="left"` and `variant` is not "temporary".
        static member inline paperAnchorDockedLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paperAnchorDockedLeft", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="top"` and `variant` is not "temporary".
        static member inline paperAnchorDockedTop(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paperAnchorDockedTop", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="right"` and `variant` is not "temporary".
        static member inline paperAnchorDockedRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paperAnchorDockedRight", createObj !!styles)
        /// Styles applied to the Paper component if `anchor="bottom"` and `variant` is not "temporary".
        static member inline paperAnchorDockedBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.paperAnchorDockedBottom", createObj !!styles)
        /// Styles applied to the Modal component.
        static member inline modal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiDrawer.modal", createObj !!styles)

      [<Erase>]
      type muiFab =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.root", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline primary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.primary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline secondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.secondary", createObj !!styles)
        /// Styles applied to the root element if `variant="extended"`.
        static member inline extended(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.extended", createObj !!styles)
        /// Styles applied to the root element if `variant="circular"`.
        static member inline circular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.circular", createObj !!styles)
        /// State class applied to the ButtonBase root element if the button is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.disabled", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `size="small"``.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"``.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFab.sizeMedium", createObj !!styles)

      [<Erase>]
      type muiFilledInput =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.root", createObj !!styles)
        /// Styles applied to the root element if color secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.colorSecondary", createObj !!styles)
        /// Styles applied to the root element unless `disableUnderline={true}`.
        static member inline underline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.underline", createObj !!styles)
        /// State class applied to the root element if the component is focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.focused", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.disabled", createObj !!styles)
        /// Styles applied to the root element if `startAdornment` is provided.
        static member inline adornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.adornedStart", createObj !!styles)
        /// Styles applied to the root element if `endAdornment` is provided.
        static member inline adornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.adornedEnd", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.error", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `multiline={true}`.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.multiline", createObj !!styles)
        /// Styles applied to the root element if `hiddenLabel={true}`.
        static member inline hiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.hiddenLabel", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.input", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline inputSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.inputSizeSmall", createObj !!styles)
        /// Styles applied to the `input` if in `  `.
        static member inline inputHiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.inputHiddenLabel", createObj !!styles)
        /// Styles applied to the input element if `multiline={true}`.
        static member inline inputMultiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.inputMultiline", createObj !!styles)
        /// Styles applied to the input element if `startAdornment` is provided.
        static member inline inputAdornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.inputAdornedStart", createObj !!styles)
        /// Styles applied to the input element if `endAdornment` is provided.
        static member inline inputAdornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFilledInput.inputAdornedEnd", createObj !!styles)

      [<Erase>]
      type muiFormControl =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControl.root", createObj !!styles)
        /// Styles applied to the root element if `margin="normal"`.
        static member inline marginNormal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControl.marginNormal", createObj !!styles)
        /// Styles applied to the root element if `margin="dense"`.
        static member inline marginDense(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControl.marginDense", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControl.fullWidth", createObj !!styles)

      [<Erase>]
      type muiFormControlLabel =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControlLabel.root", createObj !!styles)
        /// Styles applied to the root element if `labelPlacement="start"`.
        static member inline labelPlacementStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControlLabel.labelPlacementStart", createObj !!styles)
        /// Styles applied to the root element if `labelPlacement="top"`.
        static member inline labelPlacementTop(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControlLabel.labelPlacementTop", createObj !!styles)
        /// Styles applied to the root element if `labelPlacement="bottom"`.
        static member inline labelPlacementBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControlLabel.labelPlacementBottom", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControlLabel.disabled", createObj !!styles)
        /// Styles applied to the label's Typography component.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormControlLabel.label", createObj !!styles)

      [<Erase>]
      type muiFormGroup =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormGroup.root", createObj !!styles)
        /// Styles applied to the root element if `row={true}`.
        static member inline row(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormGroup.row", createObj !!styles)

      [<Erase>]
      type muiFormHelperText =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormHelperText.root", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormHelperText.error", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormHelperText.disabled", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormHelperText.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
        static member inline contained(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormHelperText.contained", createObj !!styles)
        /// State class applied to the root element if `focused={true}`.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormHelperText.focused", createObj !!styles)
        /// State class applied to the root element if `filled={true}`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormHelperText.filled", createObj !!styles)
        /// State class applied to the root element if `required={true}`.
        static member inline required(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormHelperText.required", createObj !!styles)

      [<Erase>]
      type muiFormLabel =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormLabel.root", createObj !!styles)
        /// Styles applied to the root element if the color is secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormLabel.colorSecondary", createObj !!styles)
        /// State class applied to the root element if `focused={true}`.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormLabel.focused", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormLabel.disabled", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormLabel.error", createObj !!styles)
        /// State class applied to the root element if `filled={true}`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormLabel.filled", createObj !!styles)
        /// State class applied to the root element if `required={true}`.
        static member inline required(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormLabel.required", createObj !!styles)
        /// Styles applied to the asterisk element.
        static member inline asterisk(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiFormLabel.asterisk", createObj !!styles)

      [<Erase>]
      type muiGrid =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.root", createObj !!styles)
        /// Styles applied to the root element if `container={true}`.
        static member inline container(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.container", createObj !!styles)
        /// Styles applied to the root element if `item={true}`.
        static member inline item(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.item", createObj !!styles)
        /// Styles applied to the root element if `zeroMinWidth={true}`.
        static member inline zeroMinWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.zeroMinWidth", createObj !!styles)
        /// Styles applied to the root element if `direction="column"`.
        static member inline directionXsColumn(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.direction-xs-column", createObj !!styles)
        /// Styles applied to the root element if `direction="column-reverse"`.
        static member inline directionXsColumnReverse(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.direction-xs-column-reverse", createObj !!styles)
        /// Styles applied to the root element if `direction="row-reverse"`.
        static member inline directionXsRowReverse(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.direction-xs-row-reverse", createObj !!styles)
        /// Styles applied to the root element if `wrap="nowrap"`.
        static member inline wrapXsNowrap(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.wrap-xs-nowrap", createObj !!styles)
        /// Styles applied to the root element if `wrap="reverse"`.
        static member inline wrapXsWrapReverse(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.wrap-xs-wrap-reverse", createObj !!styles)
        static member inline spacingXs1(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-1", createObj !!styles)
        static member inline spacingXs2(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-2", createObj !!styles)
        static member inline spacingXs3(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-3", createObj !!styles)
        static member inline spacingXs4(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-4", createObj !!styles)
        static member inline spacingXs5(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-5", createObj !!styles)
        static member inline spacingXs6(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-6", createObj !!styles)
        static member inline spacingXs7(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-7", createObj !!styles)
        static member inline spacingXs8(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-8", createObj !!styles)
        static member inline spacingXs9(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-9", createObj !!styles)
        static member inline spacingXs10(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.spacing-xs-10", createObj !!styles)
        static member inline gridXsAuto(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-auto", createObj !!styles)
        static member inline gridXsTrue(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-true", createObj !!styles)
        static member inline gridXs1(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-1", createObj !!styles)
        static member inline gridXs2(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-2", createObj !!styles)
        static member inline gridXs3(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-3", createObj !!styles)
        static member inline gridXs4(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-4", createObj !!styles)
        static member inline gridXs5(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-5", createObj !!styles)
        static member inline gridXs6(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-6", createObj !!styles)
        static member inline gridXs7(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-7", createObj !!styles)
        static member inline gridXs8(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-8", createObj !!styles)
        static member inline gridXs9(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-9", createObj !!styles)
        static member inline gridXs10(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-10", createObj !!styles)
        static member inline gridXs11(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-11", createObj !!styles)
        static member inline gridXs12(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiGrid.grid-xs-12", createObj !!styles)

      [<Erase>]
      type muiIcon =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.root", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `color="action"`.
        static member inline colorAction(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.colorAction", createObj !!styles)
        /// Styles applied to the root element if `color="error"`.
        static member inline colorError(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.colorError", createObj !!styles)
        /// Styles applied to the root element if `color="disabled"`.
        static member inline colorDisabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.colorDisabled", createObj !!styles)
        /// Styles applied to the root element if `fontSize="inherit"`.
        static member inline fontSizeInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.fontSizeInherit", createObj !!styles)
        /// Styles applied to the root element if `fontSize="small"`.
        static member inline fontSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.fontSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `fontSize="large"`.
        static member inline fontSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIcon.fontSizeLarge", createObj !!styles)

      [<Erase>]
      type muiIconButton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.root", createObj !!styles)
        /// Styles applied to the root element if `edge="start"`.
        static member inline edgeStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.edgeStart", createObj !!styles)
        /// Styles applied to the root element if `edge="end"`.
        static member inline edgeEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.edgeEnd", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.colorSecondary", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.disabled", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiIconButton.sizeLarge", createObj !!styles)

      [<Erase>]
      type muiImageList =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageList.root", createObj !!styles)
        /// Styles applied to the root element if `variant="masonry"`.
        static member inline masonry(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageList.masonry", createObj !!styles)
        /// Styles applied to the root element if `variant="quilted"`.
        static member inline quilted(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageList.quilted", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageList.standard", createObj !!styles)
        /// Styles applied to the root element if `variant="woven"`.
        static member inline woven(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageList.woven", createObj !!styles)

      [<Erase>]
      type muiImageListItem =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItem.root", createObj !!styles)
        /// Styles applied to an `img` element to ensure it covers the item.
        static member inline img(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItem.img", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItem.standard", createObj !!styles)
        /// Styles applied to the root element if `variant="woven"`.
        static member inline woven(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItem.woven", createObj !!styles)
        /// Styles applied to the root element if `variant="masonry"`.
        static member inline masonry(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItem.masonry", createObj !!styles)
        /// Styles applied to the root element if `variant="quilted"`.
        static member inline quilted(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItem.quilted", createObj !!styles)

      [<Erase>]
      type muiImageListItemBar =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.root", createObj !!styles)
        /// Styles applied to the root element if `position="bottom"`.
        static member inline positionBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.positionBottom", createObj !!styles)
        /// Styles applied to the root element if `position="top"`.
        static member inline positionTop(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.positionTop", createObj !!styles)
        /// Styles applied to the root element if `position="below"`.
        static member inline positionBelow(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.positionBelow", createObj !!styles)
        /// Styles applied to the title and subtitle container element.
        static member inline titleWrap(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.titleWrap", createObj !!styles)
        /// Styles applied to the title and subtitle container element if `position="below"`.
        static member inline titleWrapBelow(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.titleWrapBelow", createObj !!styles)
        /// Styles applied to the container element if `actionPosition="left"`.
        static member inline titleWrapActionPosLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.titleWrapActionPosLeft", createObj !!styles)
        /// Styles applied to the container element if `actionPosition="right"`.
        static member inline titleWrapActionPosRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.titleWrapActionPosRight", createObj !!styles)
        /// Styles applied to the title container element.
        static member inline title(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.title", createObj !!styles)
        /// Styles applied to the subtitle container element.
        static member inline subtitle(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.subtitle", createObj !!styles)
        /// Styles applied to the actionIcon if supplied.
        static member inline actionIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.actionIcon", createObj !!styles)
        /// Styles applied to the actionIcon if `actionPosition="left"`.
        static member inline actionIconActionPosLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiImageListItemBar.actionIconActionPosLeft", createObj !!styles)

      [<Erase>]
      type muiInput =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.root", createObj !!styles)
        /// Styles applied to the root element if the component is a descendant of `FormControl`.
        static member inline formControl(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.formControl", createObj !!styles)
        /// Styles applied to the root element if the component is focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.focused", createObj !!styles)
        /// Styles applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.disabled", createObj !!styles)
        /// Styles applied to the root element if color secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.colorSecondary", createObj !!styles)
        /// Styles applied to the root element unless `disableUnderline={true}`.
        static member inline underline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.underline", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.error", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `multiline={true}`.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.multiline", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.fullWidth", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.input", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline inputSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.inputSizeSmall", createObj !!styles)
        /// Styles applied to the input element if `multiline={true}`.
        static member inline inputMultiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.inputMultiline", createObj !!styles)
        /// Styles applied to the input element if `type="search"`.
        static member inline inputTypeSearch(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInput.inputTypeSearch", createObj !!styles)

      [<Erase>]
      type muiInputAdornment =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.root", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.standard", createObj !!styles)
        /// Styles applied to the root element if `position="start"`.
        static member inline positionStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.positionStart", createObj !!styles)
        /// Styles applied to the root element if `position="end"`.
        static member inline positionEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.positionEnd", createObj !!styles)
        /// Styles applied to the root element if `disablePointerEvents={true}`.
        static member inline disablePointerEvents(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.disablePointerEvents", createObj !!styles)
        /// Styles applied if the adornment is used inside <formcontrol hiddenlabel=""></formcontrol>.
        static member inline hiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.hiddenLabel", createObj !!styles)
        /// Styles applied if the adornment is used inside <formcontrol size="small"></formcontrol>.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputAdornment.sizeSmall", createObj !!styles)

      [<Erase>]
      type muiInputBase =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.root", createObj !!styles)
        /// Styles applied to the root element if the component is a descendant of `FormControl`.
        static member inline formControl(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.formControl", createObj !!styles)
        /// Styles applied to the root element if the component is focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.focused", createObj !!styles)
        /// Styles applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.disabled", createObj !!styles)
        /// Styles applied to the root element if `startAdornment` is provided.
        static member inline adornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.adornedStart", createObj !!styles)
        /// Styles applied to the root element if `endAdornment` is provided.
        static member inline adornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.adornedEnd", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.error", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `multiline={true}`.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.multiline", createObj !!styles)
        /// Styles applied to the root element if the color is secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.fullWidth", createObj !!styles)
        /// Styles applied to the root element if `hiddenLabel={true}`.
        static member inline hiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.hiddenLabel", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.input", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline inputSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.inputSizeSmall", createObj !!styles)
        /// Styles applied to the input element if `multiline={true}`.
        static member inline inputMultiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.inputMultiline", createObj !!styles)
        /// Styles applied to the input element if `type="search"`.
        static member inline inputTypeSearch(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.inputTypeSearch", createObj !!styles)
        /// Styles applied to the input element if `startAdornment` is provided.
        static member inline inputAdornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.inputAdornedStart", createObj !!styles)
        /// Styles applied to the input element if `endAdornment` is provided.
        static member inline inputAdornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.inputAdornedEnd", createObj !!styles)
        /// Styles applied to the input element if `hiddenLabel={true}`.
        static member inline inputHiddenLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputBase.inputHiddenLabel", createObj !!styles)

      [<Erase>]
      type muiInputLabel =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.root", createObj !!styles)
        /// State class applied to the root element if `focused={true}`.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.focused", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.disabled", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.error", createObj !!styles)
        /// State class applied to the root element if `required={true}`.
        static member inline required(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.required", createObj !!styles)
        /// State class applied to the asterisk element.
        static member inline asterisk(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.asterisk", createObj !!styles)
        /// Styles applied to the root element if the component is a descendant of `FormControl`.
        static member inline formControl(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.formControl", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.sizeSmall", createObj !!styles)
        /// Styles applied to the input element if `shrink={true}`.
        static member inline shrink(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.shrink", createObj !!styles)
        /// Styles applied to the input element unless `disableAnimation={true}`.
        static member inline animated(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.animated", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiInputLabel.standard", createObj !!styles)

      [<Erase>]
      type muiLinearProgress =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.root", createObj !!styles)
        /// Styles applied to the root and bar2 element if `color="primary"`; bar2 if `variant="buffer"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.colorPrimary", createObj !!styles)
        /// Styles applied to the root and bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="determinate"`.
        static member inline determinate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.determinate", createObj !!styles)
        /// Styles applied to the root element if `variant="indeterminate"`.
        static member inline indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.indeterminate", createObj !!styles)
        /// Styles applied to the root element if `variant="buffer"`.
        static member inline buffer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.buffer", createObj !!styles)
        /// Styles applied to the root element if `variant="query"`.
        static member inline query(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.query", createObj !!styles)
        /// Styles applied to the additional bar element if `variant="buffer"`.
        static member inline dashed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.dashed", createObj !!styles)
        /// Styles applied to the additional bar element if `variant="buffer"` and `color="primary"`.
        static member inline dashedColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.dashedColorPrimary", createObj !!styles)
        /// Styles applied to the additional bar element if `variant="buffer"` and `color="secondary"`.
        static member inline dashedColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.dashedColorSecondary", createObj !!styles)
        /// Styles applied to the layered bar1 and bar2 elements.
        static member inline bar(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.bar", createObj !!styles)
        /// Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
        static member inline barColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.barColorPrimary", createObj !!styles)
        /// Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
        static member inline barColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.barColorSecondary", createObj !!styles)
        /// Styles applied to the bar1 element if `variant="indeterminate or query"`.
        static member inline bar1Indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.bar1Indeterminate", createObj !!styles)
        /// Styles applied to the bar1 element if `variant="determinate"`.
        static member inline bar1Determinate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.bar1Determinate", createObj !!styles)
        /// Styles applied to the bar1 element if `variant="buffer"`.
        static member inline bar1Buffer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.bar1Buffer", createObj !!styles)
        /// Styles applied to the bar2 element if `variant="indeterminate or query"`.
        static member inline bar2Indeterminate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.bar2Indeterminate", createObj !!styles)
        /// Styles applied to the bar2 element if `variant="buffer"`.
        static member inline bar2Buffer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLinearProgress.bar2Buffer", createObj !!styles)

      [<Erase>]
      type muiLink =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLink.root", createObj !!styles)
        /// Styles applied to the root element if `underline="none"`.
        static member inline underlineNone(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLink.underlineNone", createObj !!styles)
        /// Styles applied to the root element if `underline="hover"`.
        static member inline underlineHover(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLink.underlineHover", createObj !!styles)
        /// Styles applied to the root element if `underline="always"`.
        static member inline underlineAlways(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLink.underlineAlways", createObj !!styles)
        /// Styles applied to the root element if `component="button"`.
        static member inline button(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLink.button", createObj !!styles)
        /// State class applied to the root element if the link is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLink.focusVisible", createObj !!styles)

      [<Erase>]
      type muiList =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiList.root", createObj !!styles)
        /// Styles applied to the root element unless `disablePadding={true}`.
        static member inline padding(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiList.padding", createObj !!styles)
        /// Styles applied to the root element if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiList.dense", createObj !!styles)
        /// Styles applied to the root element if a `subheader` is provided.
        static member inline subheader(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiList.subheader", createObj !!styles)

      [<Erase>]
      type muiListItem =
        /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.root", createObj !!styles)
        /// Styles applied to the container element if `children` includes `ListItemSecondaryAction`.
        static member inline container(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.container", createObj !!styles)
        /// State class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.focusVisible", createObj !!styles)
        /// Styles applied to the component element if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.dense", createObj !!styles)
        /// Styles applied to the component element if `alignItems="flex-start"`.
        static member inline alignItemsFlexStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.alignItemsFlexStart", createObj !!styles)
        /// State class applied to the inner `component` element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.disabled", createObj !!styles)
        /// Styles applied to the inner `component` element if `divider={true}`.
        static member inline divider(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.divider", createObj !!styles)
        /// Styles applied to the inner `component` element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.gutters", createObj !!styles)
        /// Styles applied to the root element unless `disablePadding={true}`.
        static member inline padding(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.padding", createObj !!styles)
        /// Styles applied to the inner `component` element if `button={true}`.
        static member inline button(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.button", createObj !!styles)
        /// Styles applied to the component element if `children` includes `ListItemSecondaryAction`.
        static member inline secondaryAction(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.secondaryAction", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItem.selected", createObj !!styles)

      [<Erase>]
      type muiListItemAvatar =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemAvatar.root", createObj !!styles)
        /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
        static member inline alignItemsFlexStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemAvatar.alignItemsFlexStart", createObj !!styles)

      [<Erase>]
      type muiListItemButton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemButton.root", createObj !!styles)
        /// State class applied to the `component`'s `focusVisibleClassName` prop.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemButton.focusVisible", createObj !!styles)
        /// Styles applied to the component element if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemButton.dense", createObj !!styles)
        /// Styles applied to the component element if `alignItems="flex-start"`.
        static member inline alignItemsFlexStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemButton.alignItemsFlexStart", createObj !!styles)
        /// State class applied to the inner `component` element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemButton.disabled", createObj !!styles)
        /// Styles applied to the inner `component` element if `divider={true}`.
        static member inline divider(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemButton.divider", createObj !!styles)
        /// Styles applied to the inner `component` element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemButton.gutters", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemButton.selected", createObj !!styles)

      [<Erase>]
      type muiListItemIcon =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemIcon.root", createObj !!styles)
        /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
        static member inline alignItemsFlexStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemIcon.alignItemsFlexStart", createObj !!styles)

      [<Erase>]
      type muiListItemSecondaryAction =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemSecondaryAction.root", createObj !!styles)
        /// Styles applied to the root element when the parent `ListItem` has `disableGutters={true}`.
        static member inline disableGutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemSecondaryAction.disableGutters", createObj !!styles)

      [<Erase>]
      type muiListItemText =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemText.root", createObj !!styles)
        /// Styles applied to the Typography component if primary and secondary are set.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemText.multiline", createObj !!styles)
        /// Styles applied to the Typography component if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemText.dense", createObj !!styles)
        /// Styles applied to the root element if `inset={true}`.
        static member inline inset(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemText.inset", createObj !!styles)
        /// Styles applied to the primary `Typography` component.
        static member inline primary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemText.primary", createObj !!styles)
        /// Styles applied to the secondary `Typography` component.
        static member inline secondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListItemText.secondary", createObj !!styles)

      [<Erase>]
      type muiListSubheader =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListSubheader.root", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListSubheader.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListSubheader.colorInherit", createObj !!styles)
        /// Styles applied to the inner `component` element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListSubheader.gutters", createObj !!styles)
        /// Styles applied to the root element if `inset={true}`.
        static member inline inset(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListSubheader.inset", createObj !!styles)
        /// Styles applied to the root element unless `disableSticky={true}`.
        static member inline sticky(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiListSubheader.sticky", createObj !!styles)

      [<Erase>]
      type muiLoadingButton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.root", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.text", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="inherit"`.
        static member inline textInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.textInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="primary"`.
        static member inline textPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.textPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
        static member inline textSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.textSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="inherit"`.
        static member inline outlinedInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.outlinedInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.outlinedSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"`.
        static member inline contained(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.contained", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="inherit"`.
        static member inline containedInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.containedInherit", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
        static member inline containedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.containedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
        static member inline containedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.containedSecondary", createObj !!styles)
        /// Styles applied to the root element if `disableElevation={true}`.
        static member inline disableElevation(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.disableElevation", createObj !!styles)
        /// State class applied to the ButtonBase root element if the button is keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.disabled", createObj !!styles)
        /// Styles applied to the root element if `color="inherit"`.
        static member inline colorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.colorInherit", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="text"`.
        static member inline textSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.textSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="text"`.
        static member inline textSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.textSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="text"`.
        static member inline textSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.textSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="outlined"`.
        static member inline outlinedSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.outlinedSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"` and `variant="outlined"`.
        static member inline outlinedSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.outlinedSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="outlined"`.
        static member inline outlinedSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.outlinedSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="contained"`.
        static member inline containedSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.containedSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="small"` and `variant="contained"`.
        static member inline containedSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.containedSizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"` and `variant="contained"`.
        static member inline containedSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.containedSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.sizeLarge", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}`.
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.fullWidth", createObj !!styles)
        /// Styles applied to the startIcon element if supplied.
        static member inline startIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.startIcon", createObj !!styles)
        /// Styles applied to the endIcon element if supplied.
        static member inline endIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.endIcon", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="small"`.
        static member inline iconSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.iconSizeSmall", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="medium"`.
        static member inline iconSizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.iconSizeMedium", createObj !!styles)
        /// Styles applied to the icon element if supplied and `size="large"`.
        static member inline iconSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.iconSizeLarge", createObj !!styles)
        /// Styles applied to the root element if `loading={true}`.
        static member inline loading(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.loading", createObj !!styles)
        /// Styles applied to the loadingIndicator element.
        static member inline loadingIndicator(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.loadingIndicator", createObj !!styles)
        /// Styles applied to the loadingIndicator element if `loadingPosition="center"`.
        static member inline loadingIndicatorCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.loadingIndicatorCenter", createObj !!styles)
        /// Styles applied to the loadingIndicator element if `loadingPosition="start"`.
        static member inline loadingIndicatorStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.loadingIndicatorStart", createObj !!styles)
        /// Styles applied to the loadingIndicator element if `loadingPosition="end"`.
        static member inline loadingIndicatorEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.loadingIndicatorEnd", createObj !!styles)
        /// Styles applied to the endIcon element if `loading={true}` and `loadingPosition="end"`.
        static member inline endIconLoadingEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.endIconLoadingEnd", createObj !!styles)
        /// Styles applied to the startIcon element if `loading={true}` and `loadingPosition="start"`.
        static member inline startIconLoadingStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiLoadingButton.startIconLoadingStart", createObj !!styles)

      [<Erase>]
      type muiMasonry =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMasonry.root", createObj !!styles)

      [<Erase>]
      type muiMenu =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenu.root", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenu.paper", createObj !!styles)
        /// Styles applied to the List component via `MenuList`.
        static member inline list(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenu.list", createObj !!styles)

      [<Erase>]
      type muiMenuItem =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenuItem.root", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenuItem.focusVisible", createObj !!styles)
        /// Styles applied to the root element if dense.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenuItem.dense", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenuItem.disabled", createObj !!styles)
        /// Styles applied to the root element if `divider={true}`.
        static member inline divider(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenuItem.divider", createObj !!styles)
        /// Styles applied to the inner `component` element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenuItem.gutters", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMenuItem.selected", createObj !!styles)

      [<Erase>]
      type muiMobileStepper =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMobileStepper.root", createObj !!styles)
        /// Styles applied to the root element if `position="bottom"`.
        static member inline positionBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMobileStepper.positionBottom", createObj !!styles)
        /// Styles applied to the root element if `position="top"`.
        static member inline positionTop(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMobileStepper.positionTop", createObj !!styles)
        /// Styles applied to the root element if `position="static"`.
        static member inline positionStatic(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMobileStepper.positionStatic", createObj !!styles)
        /// Styles applied to the dots container if `variant="dots"`.
        static member inline dots(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMobileStepper.dots", createObj !!styles)
        /// Styles applied to each dot if `variant="dots"`.
        static member inline dot(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMobileStepper.dot", createObj !!styles)
        /// Styles applied to a dot if `variant="dots"` and this is the active step.
        static member inline dotActive(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMobileStepper.dotActive", createObj !!styles)
        /// Styles applied to the Linear Progress component if `variant="progress"`.
        static member inline progress(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMobileStepper.progress", createObj !!styles)

      [<Erase>]
      type muiModal =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiModal.root", createObj !!styles)
        /// Styles applied to the root element if the `Modal` has exited.
        static member inline hidden(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiModal.hidden", createObj !!styles)

      [<Erase>]
      type muiModalUnstyled =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiModalUnstyled.root", createObj !!styles)
        /// Styles applied to the root element if the `Modal` has exited.
        static member inline hidden(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiModalUnstyled.hidden", createObj !!styles)

      [<Erase>]
      type muiMonthPicker =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiMonthPicker.root", createObj !!styles)

      [<Erase>]
      type muiNativeSelect =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.root", createObj !!styles)
        /// Styles applied to the select component `select` class.
        static member inline select(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.select", createObj !!styles)
        /// Styles applied to the select component if `multiple={true}`.
        static member inline multiple(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.multiple", createObj !!styles)
        /// Styles applied to the select component if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.filled", createObj !!styles)
        /// Styles applied to the select component if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.outlined", createObj !!styles)
        /// Styles applied to the select component if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.standard", createObj !!styles)
        /// State class applied to the select component `disabled` class.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.disabled", createObj !!styles)
        /// Styles applied to the icon component.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.icon", createObj !!styles)
        /// Styles applied to the icon component if the popup is open.
        static member inline iconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.iconOpen", createObj !!styles)
        /// Styles applied to the icon component if `variant="filled"`.
        static member inline iconFilled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.iconFilled", createObj !!styles)
        /// Styles applied to the icon component if `variant="outlined"`.
        static member inline iconOutlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.iconOutlined", createObj !!styles)
        /// Styles applied to the icon component if `variant="standard"`.
        static member inline iconStandard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.iconStandard", createObj !!styles)
        /// Styles applied to the underlying native input component.
        static member inline nativeInput(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiNativeSelect.nativeInput", createObj !!styles)

      [<Erase>]
      type muiOutlinedInput =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.root", createObj !!styles)
        /// Styles applied to the root element if the color is secondary.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if the component is focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.focused", createObj !!styles)
        /// Styles applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.disabled", createObj !!styles)
        /// Styles applied to the root element if `startAdornment` is provided.
        static member inline adornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.adornedStart", createObj !!styles)
        /// Styles applied to the root element if `endAdornment` is provided.
        static member inline adornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.adornedEnd", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.error", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `multiline={true}`.
        static member inline multiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.multiline", createObj !!styles)
        /// Styles applied to the NotchedOutline element.
        static member inline notchedOutline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.notchedOutline", createObj !!styles)
        /// Styles applied to the input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.input", createObj !!styles)
        /// Styles applied to the input element if `size="small"`.
        static member inline inputSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.inputSizeSmall", createObj !!styles)
        /// Styles applied to the input element if `multiline={true}`.
        static member inline inputMultiline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.inputMultiline", createObj !!styles)
        /// Styles applied to the input element if `startAdornment` is provided.
        static member inline inputAdornedStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.inputAdornedStart", createObj !!styles)
        /// Styles applied to the input element if `endAdornment` is provided.
        static member inline inputAdornedEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiOutlinedInput.inputAdornedEnd", createObj !!styles)

      [<Erase>]
      type muiPagination =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPagination.root", createObj !!styles)
        /// Styles applied to the ul element.
        static member inline ul(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPagination.ul", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPagination.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPagination.text", createObj !!styles)

      [<Erase>]
      type muiPaginationItem =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.root", createObj !!styles)
        /// Styles applied to the root element if `type="page"`.
        static member inline page(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.page", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.sizeLarge", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.text", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="primary"`.
        static member inline textPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.textPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
        static member inline textSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.textSecondary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.outlinedSecondary", createObj !!styles)
        /// Styles applied to the root element if `rounded="true"`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.rounded", createObj !!styles)
        /// Styles applied to the root element if `type="start-ellipsis"` or `type="end-ellipsis"`.
        static member inline ellipsis(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.ellipsis", createObj !!styles)
        /// Styles applyed to the root element if `type="first"` or type="last".
        static member inline firstLast(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.firstLast", createObj !!styles)
        /// Styles applyed to the root element if `type="previous"` or type="next".
        static member inline previousNext(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.previousNext", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.focusVisible", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.disabled", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.selected", createObj !!styles)
        /// Styles applied to the icon to display.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaginationItem.icon", createObj !!styles)

      [<Erase>]
      type muiPaper =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.root", createObj !!styles)
        /// Styles applied to the root element unless `square={true}`.
        static member inline rounded(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.rounded", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.outlined", createObj !!styles)
        /// Styles applied to the root element if `variant="elevation"`.
        static member inline elevation(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation", createObj !!styles)
        static member inline elevation0(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation0", createObj !!styles)
        static member inline elevation1(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation1", createObj !!styles)
        static member inline elevation2(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation2", createObj !!styles)
        static member inline elevation3(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation3", createObj !!styles)
        static member inline elevation4(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation4", createObj !!styles)
        static member inline elevation5(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation5", createObj !!styles)
        static member inline elevation6(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation6", createObj !!styles)
        static member inline elevation7(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation7", createObj !!styles)
        static member inline elevation8(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation8", createObj !!styles)
        static member inline elevation9(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation9", createObj !!styles)
        static member inline elevation10(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation10", createObj !!styles)
        static member inline elevation11(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation11", createObj !!styles)
        static member inline elevation12(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation12", createObj !!styles)
        static member inline elevation13(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation13", createObj !!styles)
        static member inline elevation14(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation14", createObj !!styles)
        static member inline elevation15(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation15", createObj !!styles)
        static member inline elevation16(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation16", createObj !!styles)
        static member inline elevation17(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation17", createObj !!styles)
        static member inline elevation18(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation18", createObj !!styles)
        static member inline elevation19(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation19", createObj !!styles)
        static member inline elevation20(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation20", createObj !!styles)
        static member inline elevation21(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation21", createObj !!styles)
        static member inline elevation22(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation22", createObj !!styles)
        static member inline elevation23(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation23", createObj !!styles)
        static member inline elevation24(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPaper.elevation24", createObj !!styles)

      [<Erase>]
      type muiPickersDay =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPickersDay.root", createObj !!styles)
        /// Styles applied to the root element if `disableMargin=false`.
        static member inline dayWithMargin(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPickersDay.dayWithMargin", createObj !!styles)
        /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=true`.
        static member inline dayOutsideMonth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPickersDay.dayOutsideMonth", createObj !!styles)
        /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=false`.
        static member inline hiddenDaySpacingFiller(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPickersDay.hiddenDaySpacingFiller", createObj !!styles)
        /// Styles applied to the root element if `disableHighlightToday=false` and `today=true`.
        static member inline today(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPickersDay.today", createObj !!styles)
        /// State class applied to the root element if `selected=true`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPickersDay.selected", createObj !!styles)
        /// State class applied to the root element if `disabled=true`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPickersDay.disabled", createObj !!styles)

      [<Erase>]
      type muiPopover =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPopover.root", createObj !!styles)
        /// Styles applied to the Paper component.
        static member inline paper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiPopover.paper", createObj !!styles)

      [<Erase>]
      type muiRadio =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRadio.root", createObj !!styles)
        /// State class applied to the root element if `checked={true}`.
        static member inline checked'(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRadio.checked", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRadio.disabled", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRadio.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRadio.colorSecondary", createObj !!styles)

      [<Erase>]
      type muiRating =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.root", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.sizeLarge", createObj !!styles)
        /// Styles applied to the root element if `readOnly={true}`.
        static member inline readOnly(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.readOnly", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.disabled", createObj !!styles)
        /// State class applied to the root element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.focusVisible", createObj !!styles)
        /// Visually hide an element.
        static member inline visuallyHidden(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.visuallyHidden", createObj !!styles)
        /// Styles applied to the label elements.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.label", createObj !!styles)
        /// Styles applied to the label of the "no value" input when it is active.
        static member inline labelEmptyValueActive(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.labelEmptyValueActive", createObj !!styles)
        /// Styles applied to the icon wrapping elements.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.icon", createObj !!styles)
        /// Styles applied to the icon wrapping elements when empty.
        static member inline iconEmpty(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.iconEmpty", createObj !!styles)
        /// Styles applied to the icon wrapping elements when filled.
        static member inline iconFilled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.iconFilled", createObj !!styles)
        /// Styles applied to the icon wrapping elements when hover.
        static member inline iconHover(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.iconHover", createObj !!styles)
        /// Styles applied to the icon wrapping elements when focus.
        static member inline iconFocus(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.iconFocus", createObj !!styles)
        /// Styles applied to the icon wrapping elements when active.
        static member inline iconActive(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.iconActive", createObj !!styles)
        /// Styles applied to the icon wrapping elements when decimals are necessary.
        static member inline decimal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiRating.decimal", createObj !!styles)

      [<Erase>]
      type muiScopedCssBaseline =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiScopedCssBaseline.root", createObj !!styles)

      [<Erase>]
      type muiSelect =
        /// Styles applied to the select component `select` class.
        static member inline select(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.select", createObj !!styles)
        /// Styles applied to the select component if `multiple={true}`.
        static member inline multiple(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.multiple", createObj !!styles)
        /// Styles applied to the select component if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.filled", createObj !!styles)
        /// Styles applied to the select component if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.outlined", createObj !!styles)
        /// Styles applied to the select component if `variant="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.standard", createObj !!styles)
        /// State class applied to the select component `disabled` class.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.disabled", createObj !!styles)
        /// Styles applied to the icon component.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.icon", createObj !!styles)
        /// Styles applied to the icon component if the popup is open.
        static member inline iconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.iconOpen", createObj !!styles)
        /// Styles applied to the icon component if `variant="filled"`.
        static member inline iconFilled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.iconFilled", createObj !!styles)
        /// Styles applied to the icon component if `variant="outlined"`.
        static member inline iconOutlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.iconOutlined", createObj !!styles)
        /// Styles applied to the icon component if `variant="standard"`.
        static member inline iconStandard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.iconStandard", createObj !!styles)
        /// Styles applied to the underlying native input component.
        static member inline nativeInput(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSelect.nativeInput", createObj !!styles)

      [<Erase>]
      type muiSkeleton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.root", createObj !!styles)
        /// Styles applied to the root element if `variant="text"`.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.text", createObj !!styles)
        /// Styles applied to the root element if `variant="rectangular"`.
        static member inline rectangular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.rectangular", createObj !!styles)
        /// Styles applied to the root element if `variant="circular"`.
        static member inline circular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.circular", createObj !!styles)
        /// Styles applied to the root element if `animation="pulse"`.
        static member inline pulse(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.pulse", createObj !!styles)
        /// Styles applied to the root element if `animation="wave"`.
        static member inline wave(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.wave", createObj !!styles)
        /// Styles applied when the component is passed children.
        static member inline withChildren(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.withChildren", createObj !!styles)
        /// Styles applied when the component is passed children and no width.
        static member inline fitContent(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.fitContent", createObj !!styles)
        /// Styles applied when the component is passed children and no height.
        static member inline heightAuto(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSkeleton.heightAuto", createObj !!styles)

      [<Erase>]
      type muiSlider =
        /// Class name applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.root", createObj !!styles)
        /// Class name applied to the root element if `marks` is provided with at least one label.
        static member inline marked(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.marked", createObj !!styles)
        /// Class name applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.vertical", createObj !!styles)
        /// State class applied to the root and thumb element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.disabled", createObj !!styles)
        /// State class applied to the root if a thumb is being dragged.
        static member inline dragging(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.dragging", createObj !!styles)
        /// Class name applied to the rail element.
        static member inline rail(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.rail", createObj !!styles)
        /// Class name applied to the track element.
        static member inline track(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.track", createObj !!styles)
        /// Class name applied to the root element if `track={false}`.
        static member inline trackFalse(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.trackFalse", createObj !!styles)
        /// Class name applied to the root element if `track="inverted"`.
        static member inline trackInverted(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.trackInverted", createObj !!styles)
        /// Class name applied to the thumb element.
        static member inline thumb(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.thumb", createObj !!styles)
        /// State class applied to the thumb element if it's active.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.active", createObj !!styles)
        /// State class applied to the thumb element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.focusVisible", createObj !!styles)
        /// Class name applied to the thumb label element.
        static member inline valueLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.valueLabel", createObj !!styles)
        /// Class name applied to the thumb label element if it's open.
        static member inline valueLabelOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.valueLabelOpen", createObj !!styles)
        /// Class name applied to the thumb label's circle element.
        static member inline valueLabelCircle(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.valueLabelCircle", createObj !!styles)
        /// Class name applied to the thumb label's label element.
        static member inline valueLabelLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.valueLabelLabel", createObj !!styles)
        /// Class name applied to the mark element.
        static member inline mark(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.mark", createObj !!styles)
        /// Class name applied to the mark element if active (depending on the value).
        static member inline markActive(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.markActive", createObj !!styles)
        /// Class name applied to the mark label element.
        static member inline markLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.markLabel", createObj !!styles)
        /// Class name applied to the mark label element if active (depending on the value).
        static member inline markLabelActive(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.markLabelActive", createObj !!styles)
        /// Class name applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.colorPrimary", createObj !!styles)
        /// Class name applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.colorSecondary", createObj !!styles)
        /// Class name applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.sizeSmall", createObj !!styles)
        /// Class name applied to the thumb element if `color="primary"`.
        static member inline thumbColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.thumbColorPrimary", createObj !!styles)
        /// Class name applied to the thumb element if `color="secondary"`.
        static member inline thumbColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.thumbColorSecondary", createObj !!styles)
        /// Class name applied to the thumb element if `size="small"`.
        static member inline thumbSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSlider.thumbSizeSmall", createObj !!styles)

      [<Erase>]
      type muiSliderUnstyled =
        /// Class name applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.root", createObj !!styles)
        /// Class name applied to the root element if `marks` is provided with at least one label.
        static member inline marked(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.marked", createObj !!styles)
        /// Class name applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.vertical", createObj !!styles)
        /// State class applied to the root and thumb element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.disabled", createObj !!styles)
        /// State class applied to the root if a thumb is being dragged.
        static member inline dragging(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.dragging", createObj !!styles)
        /// Class name applied to the rail element.
        static member inline rail(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.rail", createObj !!styles)
        /// Class name applied to the track element.
        static member inline track(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.track", createObj !!styles)
        /// Class name applied to the root element if `track={false}`.
        static member inline trackFalse(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.trackFalse", createObj !!styles)
        /// Class name applied to the root element if `track="inverted"`.
        static member inline trackInverted(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.trackInverted", createObj !!styles)
        /// Class name applied to the thumb element.
        static member inline thumb(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.thumb", createObj !!styles)
        /// State class applied to the thumb element if it's active.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.active", createObj !!styles)
        /// State class applied to the thumb element if keyboard focused.
        static member inline focusVisible(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.focusVisible", createObj !!styles)
        /// Class name applied to the thumb label element.
        static member inline valueLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.valueLabel", createObj !!styles)
        /// Class name applied to the thumb label element if it's open.
        static member inline valueLabelOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.valueLabelOpen", createObj !!styles)
        /// Class name applied to the thumb label's circle element.
        static member inline valueLabelCircle(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.valueLabelCircle", createObj !!styles)
        /// Class name applied to the thumb label's label element.
        static member inline valueLabelLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.valueLabelLabel", createObj !!styles)
        /// Class name applied to the mark element.
        static member inline mark(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.mark", createObj !!styles)
        /// Class name applied to the mark element if active (depending on the value).
        static member inline markActive(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.markActive", createObj !!styles)
        /// Class name applied to the mark label element.
        static member inline markLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.markLabel", createObj !!styles)
        /// Class name applied to the mark label element if active (depending on the value).
        static member inline markLabelActive(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSliderUnstyled.markLabelActive", createObj !!styles)

      [<Erase>]
      type muiSnackbar =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbar.root", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'top', 'center' }}`.
        static member inline anchorOriginTopCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbar.anchorOriginTopCenter", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'center' }}`.
        static member inline anchorOriginBottomCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbar.anchorOriginBottomCenter", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }}`.
        static member inline anchorOriginTopRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbar.anchorOriginTopRight", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }}`.
        static member inline anchorOriginBottomRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbar.anchorOriginBottomRight", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }}`.
        static member inline anchorOriginTopLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbar.anchorOriginTopLeft", createObj !!styles)
        /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }}`.
        static member inline anchorOriginBottomLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbar.anchorOriginBottomLeft", createObj !!styles)

      [<Erase>]
      type muiSnackbarContent =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbarContent.root", createObj !!styles)
        /// Styles applied to the message wrapper element.
        static member inline message(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbarContent.message", createObj !!styles)
        /// Styles applied to the action wrapper element if `action` is provided.
        static member inline action(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSnackbarContent.action", createObj !!styles)

      [<Erase>]
      type muiSpeedDial =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDial.root", createObj !!styles)
        /// Styles applied to the Fab component.
        static member inline fab(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDial.fab", createObj !!styles)
        /// Styles applied to the root element if direction="up"
        static member inline directionUp(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDial.directionUp", createObj !!styles)
        /// Styles applied to the root element if direction="down"
        static member inline directionDown(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDial.directionDown", createObj !!styles)
        /// Styles applied to the root element if direction="left"
        static member inline directionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDial.directionLeft", createObj !!styles)
        /// Styles applied to the root element if direction="right"
        static member inline directionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDial.directionRight", createObj !!styles)
        /// Styles applied to the actions (`children` wrapper) element.
        static member inline actions(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDial.actions", createObj !!styles)
        /// Styles applied to the actions (`children` wrapper) element if `open={false}`.
        static member inline actionsClosed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDial.actionsClosed", createObj !!styles)

      [<Erase>]
      type muiSpeedDialAction =
        /// Styles applied to the Fab component.
        static member inline fab(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialAction.fab", createObj !!styles)
        /// Styles applied to the Fab component if `open={false}`.
        static member inline fabClosed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialAction.fabClosed", createObj !!styles)
        /// Styles applied to the root element if `tooltipOpen={true}`.
        static member inline staticTooltip(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialAction.staticTooltip", createObj !!styles)
        /// Styles applied to the root element if `tooltipOpen={true}` and `open={false}`.
        static member inline staticTooltipClosed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialAction.staticTooltipClosed", createObj !!styles)
        /// Styles applied to the static tooltip label if `tooltipOpen={true}`.
        static member inline staticTooltipLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialAction.staticTooltipLabel", createObj !!styles)
        /// Styles applied to the root element if `tooltipOpen={true}` and `tooltipPlacement="left"``
        static member inline tooltipPlacementLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialAction.tooltipPlacementLeft", createObj !!styles)
        /// Styles applied to the root element if `tooltipOpen={true}` and `tooltipPlacement="right"``
        static member inline tooltipPlacementRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialAction.tooltipPlacementRight", createObj !!styles)

      [<Erase>]
      type muiSpeedDialIcon =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialIcon.root", createObj !!styles)
        /// Styles applied to the icon component.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialIcon.icon", createObj !!styles)
        /// Styles applied to the icon component if `open={true}`.
        static member inline iconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialIcon.iconOpen", createObj !!styles)
        /// Styles applied to the icon when an `openIcon` is provided and if `open={true}`.
        static member inline iconWithOpenIconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialIcon.iconWithOpenIconOpen", createObj !!styles)
        /// Styles applied to the `openIcon` if provided.
        static member inline openIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialIcon.openIcon", createObj !!styles)
        /// Styles applied to the `openIcon` if provided and if `open={true}`.
        static member inline openIconOpen(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSpeedDialIcon.openIconOpen", createObj !!styles)

      [<Erase>]
      type muiStep =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStep.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStep.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStep.vertical", createObj !!styles)
        /// Styles applied to the root element if `alternativeLabel={true}`.
        static member inline alternativeLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStep.alternativeLabel", createObj !!styles)
        /// State class applied to the root element if `completed={true}`.
        static member inline completed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStep.completed", createObj !!styles)

      [<Erase>]
      type muiStepButton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepButton.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepButton.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepButton.vertical", createObj !!styles)
        /// Styles applied to the `ButtonBase` touch-ripple.
        static member inline touchRipple(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepButton.touchRipple", createObj !!styles)

      [<Erase>]
      type muiStepConnector =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.vertical", createObj !!styles)
        /// Styles applied to the root element if `alternativeLabel={true}`.
        static member inline alternativeLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.alternativeLabel", createObj !!styles)
        /// State class applied to the root element if `active={true}`.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.active", createObj !!styles)
        /// State class applied to the root element if `completed={true}`.
        static member inline completed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.completed", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.disabled", createObj !!styles)
        /// Styles applied to the line element.
        static member inline line(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.line", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline lineHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.lineHorizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline lineVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepConnector.lineVertical", createObj !!styles)

      [<Erase>]
      type muiStepContent =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepContent.root", createObj !!styles)
        /// Styles applied to the root element if `last={true}` (controlled by `Step`).
        static member inline last(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepContent.last", createObj !!styles)
        /// Styles applied to the Transition component.
        static member inline transition(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepContent.transition", createObj !!styles)

      [<Erase>]
      type muiStepIcon =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepIcon.root", createObj !!styles)
        /// Styles applied to the SVG text element.
        static member inline text(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepIcon.text", createObj !!styles)
        /// State class applied to the root element if `active={true}`.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepIcon.active", createObj !!styles)
        /// State class applied to the root element if `completed={true}`.
        static member inline completed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepIcon.completed", createObj !!styles)
        /// State class applied to the root element if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepIcon.error", createObj !!styles)

      [<Erase>]
      type muiStepLabel =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.vertical", createObj !!styles)
        /// Styles applied to the label element that wraps `children`.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.label", createObj !!styles)
        /// State class applied to the label element if `active={true}`.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.active", createObj !!styles)
        /// State class applied to the label element if `completed={true}`.
        static member inline completed(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.completed", createObj !!styles)
        /// State class applied to the root and label elements if `error={true}`.
        static member inline error(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.error", createObj !!styles)
        /// State class applied to the root and label elements if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.disabled", createObj !!styles)
        /// Styles applied to the `icon` container element.
        static member inline iconContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.iconContainer", createObj !!styles)
        /// State class applied to the root and icon container and label if `alternativeLabel={true}`.
        static member inline alternativeLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.alternativeLabel", createObj !!styles)
        /// Styles applied to the container element which wraps label and `optional`.
        static member inline labelContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepLabel.labelContainer", createObj !!styles)

      [<Erase>]
      type muiStepper =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepper.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="horizontal"`.
        static member inline horizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepper.horizontal", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepper.vertical", createObj !!styles)
        /// Styles applied to the root element if `alternativeLabel={true}`.
        static member inline alternativeLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiStepper.alternativeLabel", createObj !!styles)

      [<Erase>]
      type muiSvgIcon =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.root", createObj !!styles)
        /// Styles applied to the root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.colorPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `color="action"`.
        static member inline colorAction(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.colorAction", createObj !!styles)
        /// Styles applied to the root element if `color="error"`.
        static member inline colorError(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.colorError", createObj !!styles)
        /// Styles applied to the root element if `color="disabled"`.
        static member inline colorDisabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.colorDisabled", createObj !!styles)
        /// Styles applied to the root element if `fontSize="inherit"`.
        static member inline fontSizeInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.fontSizeInherit", createObj !!styles)
        /// Styles applied to the root element if `fontSize="small"`.
        static member inline fontSizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.fontSizeSmall", createObj !!styles)
        /// Styles applied to the root element if `fontSize="large"`.
        static member inline fontSizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSvgIcon.fontSizeLarge", createObj !!styles)

      [<Erase>]
      type muiSwitch =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.root", createObj !!styles)
        /// Styles applied to the root element if `edge="start"`.
        static member inline edgeStart(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.edgeStart", createObj !!styles)
        /// Styles applied to the root element if `edge="end"`.
        static member inline edgeEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.edgeEnd", createObj !!styles)
        /// Styles applied to the internal `SwitchBase` component's `root` class.
        static member inline switchBase(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.switchBase", createObj !!styles)
        /// Styles applied to the internal SwitchBase component's root element if `color="primary"`.
        static member inline colorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.colorPrimary", createObj !!styles)
        /// Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
        static member inline colorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.colorSecondary", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.sizeMedium", createObj !!styles)
        /// State class applied to the internal `SwitchBase` component's `checked` class.
        static member inline checked'(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.checked", createObj !!styles)
        /// State class applied to the internal SwitchBase component's disabled class.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.disabled", createObj !!styles)
        /// Styles applied to the internal SwitchBase component's input element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.input", createObj !!styles)
        /// Styles used to create the thumb passed to the internal `SwitchBase` component `icon` prop.
        static member inline thumb(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.thumb", createObj !!styles)
        /// Styles applied to the track element.
        static member inline track(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiSwitch.track", createObj !!styles)

      [<Erase>]
      type muiTab =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.root", createObj !!styles)
        /// Styles applied to the root element if both `icon` and `label` are provided.
        static member inline labelIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.labelIcon", createObj !!styles)
        /// Styles applied to the root element if the parent [`Tabs`](/api/tabs/) has `textColor="inherit"`.
        static member inline textColorInherit(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.textColorInherit", createObj !!styles)
        /// Styles applied to the root element if the parent [`Tabs`](/api/tabs/) has `textColor="primary"`.
        static member inline textColorPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.textColorPrimary", createObj !!styles)
        /// Styles applied to the root element if the parent [`Tabs`](/api/tabs/) has `textColor="secondary"`.
        static member inline textColorSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.textColorSecondary", createObj !!styles)
        /// State class applied to the root element if `selected={true}` (controlled by the Tabs component).
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.selected", createObj !!styles)
        /// State class applied to the root element if `disabled={true}` (controlled by the Tabs component).
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.disabled", createObj !!styles)
        /// Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
        static member inline fullWidth(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.fullWidth", createObj !!styles)
        /// Styles applied to the root element if `wrapped={true}`.
        static member inline wrapped(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.wrapped", createObj !!styles)
        /// Styles applied to the wrapper element of `icon` if `icon` is provided.
        static member inline iconWrapper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTab.iconWrapper", createObj !!styles)

      [<Erase>]
      type muiTable =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTable.root", createObj !!styles)
        /// Styles applied to the root element if `stickyHeader={true}`.
        static member inline stickyHeader(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTable.stickyHeader", createObj !!styles)

      [<Erase>]
      type muiTableBody =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableBody.root", createObj !!styles)

      [<Erase>]
      type muiTableCell =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.root", createObj !!styles)
        /// Styles applied to the root element if `variant="head"` or `context.table.head`.
        static member inline head(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.head", createObj !!styles)
        /// Styles applied to the root element if `variant="body"` or `context.table.body`.
        static member inline body(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.body", createObj !!styles)
        /// Styles applied to the root element if `variant="footer"` or `context.table.footer`.
        static member inline footer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.footer", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `padding="checkbox"`.
        static member inline paddingCheckbox(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.paddingCheckbox", createObj !!styles)
        /// Styles applied to the root element if `padding="none"`.
        static member inline paddingNone(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.paddingNone", createObj !!styles)
        /// Styles applied to the root element if `align="left"`.
        static member inline alignLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.alignLeft", createObj !!styles)
        /// Styles applied to the root element if `align="center"`.
        static member inline alignCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.alignCenter", createObj !!styles)
        /// Styles applied to the root element if `align="right"`.
        static member inline alignRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.alignRight", createObj !!styles)
        /// Styles applied to the root element if `align="justify"`.
        static member inline alignJustify(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.alignJustify", createObj !!styles)
        /// Styles applied to the root element if `context.table.stickyHeader={true}`.
        static member inline stickyHeader(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableCell.stickyHeader", createObj !!styles)

      [<Erase>]
      type muiTableContainer =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableContainer.root", createObj !!styles)

      [<Erase>]
      type muiTableFooter =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableFooter.root", createObj !!styles)

      [<Erase>]
      type muiTableHead =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableHead.root", createObj !!styles)

      [<Erase>]
      type muiTablePagination =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.root", createObj !!styles)
        /// Styles applied to the Toolbar component.
        static member inline toolbar(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.toolbar", createObj !!styles)
        /// Styles applied to the spacer element.
        static member inline spacer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.spacer", createObj !!styles)
        /// Styles applied to the select label Typography element.
        static member inline selectLabel(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.selectLabel", createObj !!styles)
        /// Styles applied to the Select component `root` element.
        static member inline selectRoot(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.selectRoot", createObj !!styles)
        /// Styles applied to the Select component `select` class.
        static member inline select(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.select", createObj !!styles)
        /// Styles applied to the Select component `icon` class.
        static member inline selectIcon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.selectIcon", createObj !!styles)
        /// Styles applied to the Select component `root` element.
        static member inline input(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.input", createObj !!styles)
        /// Styles applied to the MenuItem component.
        static member inline menuItem(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.menuItem", createObj !!styles)
        /// Styles applied to the displayed rows Typography element.
        static member inline displayedRows(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.displayedRows", createObj !!styles)
        /// Styles applied to the internal `TablePaginationActions` component.
        static member inline actions(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTablePagination.actions", createObj !!styles)

      [<Erase>]
      type muiTableRow =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableRow.root", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableRow.selected", createObj !!styles)
        /// State class applied to the root element if `hover={true}`.
        static member inline hover(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableRow.hover", createObj !!styles)
        /// Styles applied to the root element if table variant="head".
        static member inline head(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableRow.head", createObj !!styles)
        /// Styles applied to the root element if table variant="footer".
        static member inline footer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableRow.footer", createObj !!styles)

      [<Erase>]
      type muiTableSortLabel =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableSortLabel.root", createObj !!styles)
        /// State class applied to the root element if `active={true}`.
        static member inline active(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableSortLabel.active", createObj !!styles)
        /// Styles applied to the icon component.
        static member inline icon(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableSortLabel.icon", createObj !!styles)
        /// Styles applied to the icon component if `direction="desc"`.
        static member inline iconDirectionDesc(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableSortLabel.iconDirectionDesc", createObj !!styles)
        /// Styles applied to the icon component if `direction="asc"`.
        static member inline iconDirectionAsc(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTableSortLabel.iconDirectionAsc", createObj !!styles)

      [<Erase>]
      type muiTabPanel =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabPanel.root", createObj !!styles)

      [<Erase>]
      type muiTabs =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.vertical", createObj !!styles)
        /// Styles applied to the flex container element.
        static member inline flexContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.flexContainer", createObj !!styles)
        /// Styles applied to the flex container element if `orientation="vertical"`.
        static member inline flexContainerVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.flexContainerVertical", createObj !!styles)
        /// Styles applied to the flex container element if `centered={true}`&`!variant="scrollable"`.
        static member inline centered(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.centered", createObj !!styles)
        /// Styles applied to the tablist element.
        static member inline scroller(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.scroller", createObj !!styles)
        /// Styles applied to the tablist element if `!variant="scrollable"`.
        static member inline fixed'(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.fixed", createObj !!styles)
        /// Styles applied to the tablist element if `variant="scrollable"` and `orientation="horizontal"`.
        static member inline scrollableX(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.scrollableX", createObj !!styles)
        /// Styles applied to the tablist element if `variant="scrollable"` and `orientation="vertical"`.
        static member inline scrollableY(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.scrollableY", createObj !!styles)
        /// Styles applied to the tablist element if `variant="scrollable"` and `visibleScrollbar={false}`.
        static member inline hideScrollbar(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.hideScrollbar", createObj !!styles)
        /// Styles applied to the ScrollButtonComponent component.
        static member inline scrollButtons(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.scrollButtons", createObj !!styles)
        /// Styles applied to the ScrollButtonComponent component if `allowScrollButtonsMobile={true}`.
        static member inline scrollButtonsHideMobile(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.scrollButtonsHideMobile", createObj !!styles)
        /// Styles applied to the TabIndicator component.
        static member inline indicator(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabs.indicator", createObj !!styles)

      [<Erase>]
      type muiTabScrollButton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabScrollButton.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabScrollButton.vertical", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTabScrollButton.disabled", createObj !!styles)

      [<Erase>]
      type muiTextField =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTextField.root", createObj !!styles)

      [<Erase>]
      type muiTimeline =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimeline.root", createObj !!styles)
        /// Styles applied to the root element if `position="left"`.
        static member inline positionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimeline.positionLeft", createObj !!styles)
        /// Styles applied to the root element if `position="right"`.
        static member inline positionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimeline.positionRight", createObj !!styles)
        /// Styles applied to the root element if `position="alternate"`.
        static member inline positionAlternate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimeline.positionAlternate", createObj !!styles)

      [<Erase>]
      type muiTimelineConnector =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineConnector.root", createObj !!styles)

      [<Erase>]
      type muiTimelineContent =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineContent.root", createObj !!styles)
        /// Styles applied to the root element if `position="right"`.
        static member inline positionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineContent.positionRight", createObj !!styles)
        /// Styles applied to the root element if `position="left"`.
        static member inline positionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineContent.positionLeft", createObj !!styles)
        /// Styles applied to the root element if `position="alternate"`.
        static member inline positionAlternate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineContent.positionAlternate", createObj !!styles)

      [<Erase>]
      type muiTimelineDot =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.root", createObj !!styles)
        /// Styles applied to the root element if `variant="filled"`.
        static member inline filled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.filled", createObj !!styles)
        /// Styles applied to the root element if `variant="outlined"`.
        static member inline outlined(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.outlined", createObj !!styles)
        /// Styles applied to the root element if `color="grey"` and `variant="filled"`.
        static member inline filledGrey(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.filledGrey", createObj !!styles)
        /// Styles applied to the root element if `color="grey"` and `variant="outlined"`.
        static member inline outlinedGrey(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.outlinedGrey", createObj !!styles)
        /// Styles applied to the root element if `color="primary"` and `variant="filled"`.
        static member inline filledPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.filledPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="primary"` and `variant="outlined"`.
        static member inline outlinedPrimary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.outlinedPrimary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"` and `variant="filled"`.
        static member inline filledSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.filledSecondary", createObj !!styles)
        /// Styles applied to the root element if `color="secondary"` and `variant="outlined"`.
        static member inline outlinedSecondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineDot.outlinedSecondary", createObj !!styles)

      [<Erase>]
      type muiTimelineItem =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineItem.root", createObj !!styles)
        /// Styles applied to the root element if `position="left"`.
        static member inline positionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineItem.positionLeft", createObj !!styles)
        /// Styles applied to the root element if `position="right"`.
        static member inline positionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineItem.positionRight", createObj !!styles)
        /// Styles applied to the root element if `position="alternate"`.
        static member inline positionAlternate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineItem.positionAlternate", createObj !!styles)
        /// Styles applied to the root element if TimelineOppositeContent isn't provided.
        static member inline missingOppositeContent(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineItem.missingOppositeContent", createObj !!styles)

      [<Erase>]
      type muiTimelineOppositeContent =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineOppositeContent.root", createObj !!styles)
        /// Styles applied to the root element if `position="right"`.
        static member inline positionRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineOppositeContent.positionRight", createObj !!styles)
        /// Styles applied to the root element if `position="left"`.
        static member inline positionLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineOppositeContent.positionLeft", createObj !!styles)
        /// Styles applied to the root element if `position="alternate"`.
        static member inline positionAlternate(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineOppositeContent.positionAlternate", createObj !!styles)

      [<Erase>]
      type muiTimelineSeparator =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTimelineSeparator.root", createObj !!styles)

      [<Erase>]
      type muiToggleButton =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.root", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.disabled", createObj !!styles)
        /// State class applied to the root element if `selected={true}`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.selected", createObj !!styles)
        /// State class applied to the root element if `color="standard"`.
        static member inline standard(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.standard", createObj !!styles)
        /// State class applied to the root element if `color="primary"`.
        static member inline primary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.primary", createObj !!styles)
        /// State class applied to the root element if `color="secondary"`.
        static member inline secondary(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.secondary", createObj !!styles)
        /// Styles applied to the root element if `size="small"`.
        static member inline sizeSmall(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.sizeSmall", createObj !!styles)
        /// Styles applied to the root element if `size="medium"`.
        static member inline sizeMedium(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.sizeMedium", createObj !!styles)
        /// Styles applied to the root element if `size="large"`.
        static member inline sizeLarge(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButton.sizeLarge", createObj !!styles)

      [<Erase>]
      type muiToggleButtonGroup =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButtonGroup.root", createObj !!styles)
        /// Styles applied to the root element if `orientation="vertical"`.
        static member inline vertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButtonGroup.vertical", createObj !!styles)
        /// State class applied to the root element if `disabled={true}`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButtonGroup.disabled", createObj !!styles)
        /// Styles applied to the children.
        static member inline grouped(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButtonGroup.grouped", createObj !!styles)
        /// Styles applied to the children if `orientation="horizontal"`.
        static member inline groupedHorizontal(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButtonGroup.groupedHorizontal", createObj !!styles)
        /// Styles applied to the children if `orientation="vertical"`.
        static member inline groupedVertical(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToggleButtonGroup.groupedVertical", createObj !!styles)

      [<Erase>]
      type muiToolbar =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToolbar.root", createObj !!styles)
        /// Styles applied to the root element unless `disableGutters={true}`.
        static member inline gutters(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToolbar.gutters", createObj !!styles)
        /// Styles applied to the root element if `variant="regular"`.
        static member inline regular(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToolbar.regular", createObj !!styles)
        /// Styles applied to the root element if `variant="dense"`.
        static member inline dense(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiToolbar.dense", createObj !!styles)

      [<Erase>]
      type muiTooltip =
        /// Styles applied to the Popper component.
        static member inline popper(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.popper", createObj !!styles)
        /// Styles applied to the Popper component unless `disableInteractive={true}`.
        static member inline popperInteractive(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.popperInteractive", createObj !!styles)
        /// Styles applied to the Popper component if `arrow={true}`.
        static member inline popperArrow(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.popperArrow", createObj !!styles)
        /// Styles applied to the Popper component unless the tooltip is open.
        static member inline popperClose(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.popperClose", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element.
        static member inline tooltip(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.tooltip", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `arrow={true}`.
        static member inline tooltipArrow(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.tooltipArrow", createObj !!styles)
        /// Styles applied to the arrow element.
        static member inline arrow(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.arrow", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
        static member inline touch(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.touch", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
        static member inline tooltipPlacementLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.tooltipPlacementLeft", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
        static member inline tooltipPlacementRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.tooltipPlacementRight", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
        static member inline tooltipPlacementTop(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.tooltipPlacementTop", createObj !!styles)
        /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
        static member inline tooltipPlacementBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTooltip.tooltipPlacementBottom", createObj !!styles)

      [<Erase>]
      type muiTreeItem =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.root", createObj !!styles)
        /// Styles applied to the transition component.
        static member inline group(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.group", createObj !!styles)
        /// Styles applied to the content element.
        static member inline content(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.content", createObj !!styles)
        /// State class applied to the content element when expanded.
        static member inline expanded(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.expanded", createObj !!styles)
        /// State class applied to the content element when selected.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.selected", createObj !!styles)
        /// State class applied to the content element when focused.
        static member inline focused(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.focused", createObj !!styles)
        /// State class applied to the element when disabled.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.disabled", createObj !!styles)
        /// Styles applied to the tree node icon.
        static member inline iconContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.iconContainer", createObj !!styles)
        /// Styles applied to the label element.
        static member inline label(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeItem.label", createObj !!styles)

      [<Erase>]
      type muiTreeView =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTreeView.root", createObj !!styles)

      [<Erase>]
      type muiTypography =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.root", createObj !!styles)
        /// Styles applied to the root element if `variant="body2"`.
        static member inline body2(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.body2", createObj !!styles)
        /// Styles applied to the root element if `variant="body1"`.
        static member inline body1(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.body1", createObj !!styles)
        /// Styles applied to the root element if `variant="caption"`.
        static member inline caption(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.caption", createObj !!styles)
        /// Styles applied to the root element if `variant="button"`.
        static member inline button(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.button", createObj !!styles)
        /// Styles applied to the root element if `variant="h1"`.
        static member inline h1(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.h1", createObj !!styles)
        /// Styles applied to the root element if `variant="h2"`.
        static member inline h2(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.h2", createObj !!styles)
        /// Styles applied to the root element if `variant="h3"`.
        static member inline h3(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.h3", createObj !!styles)
        /// Styles applied to the root element if `variant="h4"`.
        static member inline h4(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.h4", createObj !!styles)
        /// Styles applied to the root element if `variant="h5"`.
        static member inline h5(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.h5", createObj !!styles)
        /// Styles applied to the root element if `variant="h6"`.
        static member inline h6(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.h6", createObj !!styles)
        /// Styles applied to the root element if `variant="subtitle1"`.
        static member inline subtitle1(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.subtitle1", createObj !!styles)
        /// Styles applied to the root element if `variant="subtitle2"`.
        static member inline subtitle2(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.subtitle2", createObj !!styles)
        /// Styles applied to the root element if `variant="overline"`.
        static member inline overline(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.overline", createObj !!styles)
        /// Styles applied to the root element if `variant="inherit"`.
        static member inline inherit'(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.inherit", createObj !!styles)
        /// Styles applied to the root element if `align="left"`.
        static member inline alignLeft(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.alignLeft", createObj !!styles)
        /// Styles applied to the root element if `align="center"`.
        static member inline alignCenter(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.alignCenter", createObj !!styles)
        /// Styles applied to the root element if `align="right"`.
        static member inline alignRight(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.alignRight", createObj !!styles)
        /// Styles applied to the root element if `align="justify"`.
        static member inline alignJustify(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.alignJustify", createObj !!styles)
        /// Styles applied to the root element if `nowrap={true}`.
        static member inline noWrap(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.noWrap", createObj !!styles)
        /// Styles applied to the root element if `gutterBottom={true}`.
        static member inline gutterBottom(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.gutterBottom", createObj !!styles)
        /// Styles applied to the root element if `paragraph={true}`.
        static member inline paragraph(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiTypography.paragraph", createObj !!styles)

      [<Erase>]
      type muiYearPicker =
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("overrides.MuiYearPicker.root", createObj !!styles)
