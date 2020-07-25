namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Feliz

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module classesProps =

  module accordion =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `square={false}`.
      static member inline rounded(className: string) : IReactProperty = unbox ("classes.rounded", className)
      /// Styles applied to the root element if `expanded={true}`.
      static member inline expanded(className: string) : IReactProperty = unbox ("classes.expanded", className)
      /// Styles applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
  
  
  module accordionActions =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disableSpacing={false}`.
      static member inline spacing(className: string) : IReactProperty = unbox ("classes.spacing", className)
  
  
  module accordionDetails =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module accordionSummary =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
      static member inline expanded(className: string) : IReactProperty = unbox ("classes.expanded", className)
      /// Pseudo-class applied to the root element if `focused={true}`.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the children wrapper element.
      static member inline content(className: string) : IReactProperty = unbox ("classes.content", className)
      /// Styles applied to the `IconButton` component when `expandIcon` is supplied.
      static member inline expandIcon(className: string) : IReactProperty = unbox ("classes.expandIcon", className)
  
  
  module alert =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `variant="standard"` and `color="success"`.
      static member inline standardSuccess(className: string) : IReactProperty = unbox ("classes.standardSuccess", className)
      /// Styles applied to the root element if `variant="standard"` and `color="info"`.
      static member inline standardInfo(className: string) : IReactProperty = unbox ("classes.standardInfo", className)
      /// Styles applied to the root element if `variant="standard"` and `color="warning"`.
      static member inline standardWarning(className: string) : IReactProperty = unbox ("classes.standardWarning", className)
      /// Styles applied to the root element if `variant="standard"` and `color="error"`.
      static member inline standardError(className: string) : IReactProperty = unbox ("classes.standardError", className)
      /// Styles applied to the root element if `variant="outlined"` and `color="success"`.
      static member inline outlinedSuccess(className: string) : IReactProperty = unbox ("classes.outlinedSuccess", className)
      /// Styles applied to the root element if `variant="outlined"` and `color="info"`.
      static member inline outlinedInfo(className: string) : IReactProperty = unbox ("classes.outlinedInfo", className)
      /// Styles applied to the root element if `variant="outlined"` and `color="warning"`.
      static member inline outlinedWarning(className: string) : IReactProperty = unbox ("classes.outlinedWarning", className)
      /// Styles applied to the root element if `variant="outlined"` and `color="error"`.
      static member inline outlinedError(className: string) : IReactProperty = unbox ("classes.outlinedError", className)
      /// Styles applied to the root element if `variant="filled"` and `color="success"`.
      static member inline filledSuccess(className: string) : IReactProperty = unbox ("classes.filledSuccess", className)
      /// Styles applied to the root element if `variant="filled"` and `color="info"`.
      static member inline filledInfo(className: string) : IReactProperty = unbox ("classes.filledInfo", className)
      /// Styles applied to the root element if `variant="filled"` and `color="warning"`.
      static member inline filledWarning(className: string) : IReactProperty = unbox ("classes.filledWarning", className)
      /// Styles applied to the root element if `variant="filled"` and `color="error"`.
      static member inline filledError(className: string) : IReactProperty = unbox ("classes.filledError", className)
      /// Styles applied to the icon wrapper element.
      static member inline icon(className: string) : IReactProperty = unbox ("classes.icon", className)
      /// Styles applied to the message wrapper element.
      static member inline message(className: string) : IReactProperty = unbox ("classes.message", className)
      /// Styles applied to the action wrapper element if `action` is provided.
      static member inline action(className: string) : IReactProperty = unbox ("classes.action", className)
  
  
  module alertTitle =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module appBar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `position="fixed"`.
      static member inline positionFixed(className: string) : IReactProperty = unbox ("classes.positionFixed", className)
      /// Styles applied to the root element if `position="absolute"`.
      static member inline positionAbsolute(className: string) : IReactProperty = unbox ("classes.positionAbsolute", className)
      /// Styles applied to the root element if `position="sticky"`.
      static member inline positionSticky(className: string) : IReactProperty = unbox ("classes.positionSticky", className)
      /// Styles applied to the root element if `position="static"`.
      static member inline positionStatic(className: string) : IReactProperty = unbox ("classes.positionStatic", className)
      /// Styles applied to the root element if `position="relative"`.
      static member inline positionRelative(className: string) : IReactProperty = unbox ("classes.positionRelative", className)
      /// Styles applied to the root element if `color="default"`.
      static member inline colorDefault(className: string) : IReactProperty = unbox ("classes.colorDefault", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit(className: string) : IReactProperty = unbox ("classes.colorInherit", className)
      /// Styles applied to the root element if `color="transparent"`.
      static member inline colorTransparent(className: string) : IReactProperty = unbox ("classes.colorTransparent", className)
  
  
  module autocomplete =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth(className: string) : IReactProperty = unbox ("classes.fullWidth", className)
      /// Pseudo-class applied to the root element if focused.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Styles applied to the tag elements, e.g. the chips.
      static member inline tag(className: string) : IReactProperty = unbox ("classes.tag", className)
      /// Styles applied to the tag elements, e.g. the chips if `size="small"`.
      static member inline tagSizeSmall(className: string) : IReactProperty = unbox ("classes.tagSizeSmall", className)
      /// Styles applied when the popup icon is rendered.
      static member inline hasPopupIcon(className: string) : IReactProperty = unbox ("classes.hasPopupIcon", className)
      /// Styles applied when the clear icon is rendered.
      static member inline hasClearIcon(className: string) : IReactProperty = unbox ("classes.hasClearIcon", className)
      /// Styles applied to the Input element.
      static member inline inputRoot(className: string) : IReactProperty = unbox ("classes.inputRoot", className)
      /// Styles applied to the input element.
      static member inline input(className: string) : IReactProperty = unbox ("classes.input", className)
      /// Styles applied to the input element if tag focused.
      static member inline inputFocused(className: string) : IReactProperty = unbox ("classes.inputFocused", className)
      /// Styles applied to the endAdornment element.
      static member inline endAdornment(className: string) : IReactProperty = unbox ("classes.endAdornment", className)
      /// Styles applied to the clear indicator.
      static member inline clearIndicator(className: string) : IReactProperty = unbox ("classes.clearIndicator", className)
      /// Styles applied to the clear indicator if the input is dirty.
      static member inline clearIndicatorDirty(className: string) : IReactProperty = unbox ("classes.clearIndicatorDirty", className)
      /// Styles applied to the popup indicator.
      static member inline popupIndicator(className: string) : IReactProperty = unbox ("classes.popupIndicator", className)
      /// Styles applied to the popup indicator if the popup is open.
      static member inline popupIndicatorOpen(className: string) : IReactProperty = unbox ("classes.popupIndicatorOpen", className)
      /// Styles applied to the popper element.
      static member inline popper(className: string) : IReactProperty = unbox ("classes.popper", className)
      /// Styles applied to the popper element if `disablePortal={true}`.
      static member inline popperDisablePortal(className: string) : IReactProperty = unbox ("classes.popperDisablePortal", className)
      /// Styles applied to the `Paper` component.
      static member inline paper(className: string) : IReactProperty = unbox ("classes.paper", className)
      /// Styles applied to the `listbox` component.
      static member inline listbox(className: string) : IReactProperty = unbox ("classes.listbox", className)
      /// Styles applied to the loading wrapper.
      static member inline loading(className: string) : IReactProperty = unbox ("classes.loading", className)
      /// Styles applied to the no option wrapper.
      static member inline noOptions(className: string) : IReactProperty = unbox ("classes.noOptions", className)
      /// Styles applied to the option elements.
      static member inline option(className: string) : IReactProperty = unbox ("classes.option", className)
      /// Styles applied to the group's label elements.
      static member inline groupLabel(className: string) : IReactProperty = unbox ("classes.groupLabel", className)
      /// Styles applied to the group's ul elements.
      static member inline groupUl(className: string) : IReactProperty = unbox ("classes.groupUl", className)
  
  
  module avatar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if not `src` or `srcSet`.
      static member inline colorDefault(className: string) : IReactProperty = unbox ("classes.colorDefault", className)
      /// Styles applied to the root element if `variant="circle"`.
      static member inline circle(className: string) : IReactProperty = unbox ("classes.circle", className)
      /// Styles applied to the root element if `variant="rounded"`.
      static member inline rounded(className: string) : IReactProperty = unbox ("classes.rounded", className)
      /// Styles applied to the root element if `variant="square"`.
      static member inline square(className: string) : IReactProperty = unbox ("classes.square", className)
      /// Styles applied to the img element if either `src` or `srcSet` is defined.
      static member inline img(className: string) : IReactProperty = unbox ("classes.img", className)
      /// Styles applied to the fallback icon
      static member inline fallback(className: string) : IReactProperty = unbox ("classes.fallback", className)
  
  
  module avatarGroup =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the avatar elements.
      static member inline avatar(className: string) : IReactProperty = unbox ("classes.avatar", className)
  
  
  module backdrop =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `invisible={true}`.
      static member inline invisible(className: string) : IReactProperty = unbox ("classes.invisible", className)
  
  
  module badge =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the badge `span` element.
      static member inline badge(className: string) : IReactProperty = unbox ("classes.badge", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `color="error"`.
      static member inline colorError(className: string) : IReactProperty = unbox ("classes.colorError", className)
      /// Styles applied to the root element if `variant="dot"`.
      static member inline dot(className: string) : IReactProperty = unbox ("classes.dot", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }} overlap="rectangle"`.
      static member inline anchorOriginTopRightRectangle(className: string) : IReactProperty = unbox ("classes.anchorOriginTopRightRectangle", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }} overlap="rectangle"`.
      static member inline anchorOriginBottomRightRectangle(className: string) : IReactProperty = unbox ("classes.anchorOriginBottomRightRectangle", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }} overlap="rectangle"`.
      static member inline anchorOriginTopLeftRectangle(className: string) : IReactProperty = unbox ("classes.anchorOriginTopLeftRectangle", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }} overlap="rectangle"`.
      static member inline anchorOriginBottomLeftRectangle(className: string) : IReactProperty = unbox ("classes.anchorOriginBottomLeftRectangle", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }} overlap="circle"`.
      static member inline anchorOriginTopRightCircle(className: string) : IReactProperty = unbox ("classes.anchorOriginTopRightCircle", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }} overlap="circle"`.
      static member inline anchorOriginBottomRightCircle(className: string) : IReactProperty = unbox ("classes.anchorOriginBottomRightCircle", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }} overlap="circle"`.
      static member inline anchorOriginTopLeftCircle(className: string) : IReactProperty = unbox ("classes.anchorOriginTopLeftCircle", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }} overlap="circle"`.
      static member inline anchorOriginBottomLeftCircle(className: string) : IReactProperty = unbox ("classes.anchorOriginBottomLeftCircle", className)
      /// Pseudo-class to the badge `span` element if `invisible={true}`.
      static member inline invisible(className: string) : IReactProperty = unbox ("classes.invisible", className)
  
  
  module bottomNavigation =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module bottomNavigationAction =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if selected.
      static member inline selected(className: string) : IReactProperty = unbox ("classes.selected", className)
      /// Pseudo-class applied to the root element if `showLabel={false}` and not selected.
      static member inline iconOnly(className: string) : IReactProperty = unbox ("classes.iconOnly", className)
      /// Styles applied to the span element that wraps the icon and label.
      static member inline wrapper(className: string) : IReactProperty = unbox ("classes.wrapper", className)
      /// Styles applied to the label's span element.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
  
  
  module breadcrumbs =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the ol element.
      static member inline ol(className: string) : IReactProperty = unbox ("classes.ol", className)
      /// Styles applied to the li element.
      static member inline li(className: string) : IReactProperty = unbox ("classes.li", className)
      /// Styles applied to the separator element.
      static member inline separator(className: string) : IReactProperty = unbox ("classes.separator", className)
  
  
  module button =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the span element that wraps the children.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
      /// Styles applied to the root element if `variant="text"`.
      static member inline text(className: string) : IReactProperty = unbox ("classes.text", className)
      /// Styles applied to the root element if `variant="text"` and `color="primary"`.
      static member inline textPrimary(className: string) : IReactProperty = unbox ("classes.textPrimary", className)
      /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
      static member inline textSecondary(className: string) : IReactProperty = unbox ("classes.textSecondary", className)
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined(className: string) : IReactProperty = unbox ("classes.outlined", className)
      /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
      static member inline outlinedPrimary(className: string) : IReactProperty = unbox ("classes.outlinedPrimary", className)
      /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
      static member inline outlinedSecondary(className: string) : IReactProperty = unbox ("classes.outlinedSecondary", className)
      /// Styles applied to the root element if `variant="contained"`.
      static member inline contained(className: string) : IReactProperty = unbox ("classes.contained", className)
      /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
      static member inline containedPrimary(className: string) : IReactProperty = unbox ("classes.containedPrimary", className)
      /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
      static member inline containedSecondary(className: string) : IReactProperty = unbox ("classes.containedSecondary", className)
      /// Styles applied to the root element if `disableElevation={true}`.
      static member inline disableElevation(className: string) : IReactProperty = unbox ("classes.disableElevation", className)
      /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("classes.focusVisible", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit(className: string) : IReactProperty = unbox ("classes.colorInherit", className)
      /// Styles applied to the root element if `size="small"` and `variant="text"`.
      static member inline textSizeSmall(className: string) : IReactProperty = unbox ("classes.textSizeSmall", className)
      /// Styles applied to the root element if `size="large"` and `variant="text"`.
      static member inline textSizeLarge(className: string) : IReactProperty = unbox ("classes.textSizeLarge", className)
      /// Styles applied to the root element if `size="small"` and `variant="outlined"`.
      static member inline outlinedSizeSmall(className: string) : IReactProperty = unbox ("classes.outlinedSizeSmall", className)
      /// Styles applied to the root element if `size="large"` and `variant="outlined"`.
      static member inline outlinedSizeLarge(className: string) : IReactProperty = unbox ("classes.outlinedSizeLarge", className)
      /// Styles applied to the root element if `size="small"` and `variant="contained"`.
      static member inline containedSizeSmall(className: string) : IReactProperty = unbox ("classes.containedSizeSmall", className)
      /// Styles applied to the root element if `size="large"` and `variant="contained"`.
      static member inline containedSizeLarge(className: string) : IReactProperty = unbox ("classes.containedSizeLarge", className)
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall(className: string) : IReactProperty = unbox ("classes.sizeSmall", className)
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge(className: string) : IReactProperty = unbox ("classes.sizeLarge", className)
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth(className: string) : IReactProperty = unbox ("classes.fullWidth", className)
      /// Styles applied to the startIcon element if supplied.
      static member inline startIcon(className: string) : IReactProperty = unbox ("classes.startIcon", className)
      /// Styles applied to the endIcon element if supplied.
      static member inline endIcon(className: string) : IReactProperty = unbox ("classes.endIcon", className)
      /// Styles applied to the icon element if supplied and `size="small"`.
      static member inline iconSizeSmall(className: string) : IReactProperty = unbox ("classes.iconSizeSmall", className)
      /// Styles applied to the icon element if supplied and `size="medium"`.
      static member inline iconSizeMedium(className: string) : IReactProperty = unbox ("classes.iconSizeMedium", className)
      /// Styles applied to the icon element if supplied and `size="large"`.
      static member inline iconSizeLarge(className: string) : IReactProperty = unbox ("classes.iconSizeLarge", className)
  
  
  module buttonBase =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Pseudo-class applied to the root element if keyboard focused.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("classes.focusVisible", className)
  
  
  module buttonGroup =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `variant="contained"`.
      static member inline contained(className: string) : IReactProperty = unbox ("classes.contained", className)
      /// Styles applied to the root element if `disableElevation={true}`.
      static member inline disableElevation(className: string) : IReactProperty = unbox ("classes.disableElevation", className)
      /// Pseudo-class applied to child elements if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth(className: string) : IReactProperty = unbox ("classes.fullWidth", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the children.
      static member inline grouped(className: string) : IReactProperty = unbox ("classes.grouped", className)
      /// Styles applied to the children if `orientation="horizontal"`.
      static member inline groupedHorizontal(className: string) : IReactProperty = unbox ("classes.groupedHorizontal", className)
      /// Styles applied to the children if `orientation="vertical"`.
      static member inline groupedVertical(className: string) : IReactProperty = unbox ("classes.groupedVertical", className)
      /// Styles applied to the children if `variant="text"`.
      static member inline groupedText(className: string) : IReactProperty = unbox ("classes.groupedText", className)
      /// Styles applied to the children if `variant="text"` and `orientation="horizontal"`.
      static member inline groupedTextHorizontal(className: string) : IReactProperty = unbox ("classes.groupedTextHorizontal", className)
      /// Styles applied to the children if `variant="text"` and `orientation="vertical"`.
      static member inline groupedTextVertical(className: string) : IReactProperty = unbox ("classes.groupedTextVertical", className)
      /// Styles applied to the children if `variant="text"` and `color="primary"`.
      static member inline groupedTextPrimary(className: string) : IReactProperty = unbox ("classes.groupedTextPrimary", className)
      /// Styles applied to the children if `variant="text"` and `color="secondary"`.
      static member inline groupedTextSecondary(className: string) : IReactProperty = unbox ("classes.groupedTextSecondary", className)
      /// Styles applied to the children if `variant="outlined"`.
      static member inline groupedOutlined(className: string) : IReactProperty = unbox ("classes.groupedOutlined", className)
      /// Styles applied to the children if `variant="outlined"` and `orientation="horizontal"`.
      static member inline groupedOutlinedHorizontal(className: string) : IReactProperty = unbox ("classes.groupedOutlinedHorizontal", className)
      /// Styles applied to the children if `variant="outlined"` and `orientation="vertical"`.
      static member inline groupedOutlinedVertical(className: string) : IReactProperty = unbox ("classes.groupedOutlinedVertical", className)
      /// Styles applied to the children if `variant="outlined"` and `color="primary"`.
      static member inline groupedOutlinedPrimary(className: string) : IReactProperty = unbox ("classes.groupedOutlinedPrimary", className)
      /// Styles applied to the children if `variant="outlined"` and `color="secondary"`.
      static member inline groupedOutlinedSecondary(className: string) : IReactProperty = unbox ("classes.groupedOutlinedSecondary", className)
      /// Styles applied to the children if `variant="contained"`.
      static member inline groupedContained(className: string) : IReactProperty = unbox ("classes.groupedContained", className)
      /// Styles applied to the children if `variant="contained"` and `orientation="horizontal"`.
      static member inline groupedContainedHorizontal(className: string) : IReactProperty = unbox ("classes.groupedContainedHorizontal", className)
      /// Styles applied to the children if `variant="contained"` and `orientation="vertical"`.
      static member inline groupedContainedVertical(className: string) : IReactProperty = unbox ("classes.groupedContainedVertical", className)
      /// Styles applied to the children if `variant="contained"` and `color="primary"`.
      static member inline groupedContainedPrimary(className: string) : IReactProperty = unbox ("classes.groupedContainedPrimary", className)
      /// Styles applied to the children if `variant="contained"` and `color="secondary"`.
      static member inline groupedContainedSecondary(className: string) : IReactProperty = unbox ("classes.groupedContainedSecondary", className)
  
  
  module card =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module cardActionArea =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the ButtonBase root element if the action area is keyboard focused.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("classes.focusVisible", className)
      /// Styles applied to the overlay that covers the action area when it is keyboard focused.
      static member inline focusHighlight(className: string) : IReactProperty = unbox ("classes.focusHighlight", className)
  
  
  module cardActions =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disableSpacing={false}`.
      static member inline spacing(className: string) : IReactProperty = unbox ("classes.spacing", className)
  
  
  module cardContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module cardHeader =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the avatar element.
      static member inline avatar(className: string) : IReactProperty = unbox ("classes.avatar", className)
      /// Styles applied to the action element.
      static member inline action(className: string) : IReactProperty = unbox ("classes.action", className)
      /// Styles applied to the content wrapper element.
      static member inline content(className: string) : IReactProperty = unbox ("classes.content", className)
      /// Styles applied to the title Typography element.
      static member inline title(className: string) : IReactProperty = unbox ("classes.title", className)
      /// Styles applied to the subheader Typography element.
      static member inline subheader(className: string) : IReactProperty = unbox ("classes.subheader", className)
  
  
  module cardMedia =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.
      static member inline media(className: string) : IReactProperty = unbox ("classes.media", className)
      /// Styles applied to the root element if `component="picture or img"`.
      static member inline img(className: string) : IReactProperty = unbox ("classes.img", className)
  
  
  module checkbox =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if `checked={true}`.
      static member inline checked'(className: string) : IReactProperty = unbox ("classes.checked", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Pseudo-class applied to the root element if `indeterminate={true}`.
      static member inline indeterminate(className: string) : IReactProperty = unbox ("classes.indeterminate", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
  
  
  module chip =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall(className: string) : IReactProperty = unbox ("classes.sizeSmall", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `onClick` is defined or `clickable={true}`.
      static member inline clickable(className: string) : IReactProperty = unbox ("classes.clickable", className)
      /// Styles applied to the root element if `onClick` and `color="primary"` is defined or `clickable={true}`.
      static member inline clickableColorPrimary(className: string) : IReactProperty = unbox ("classes.clickableColorPrimary", className)
      /// Styles applied to the root element if `onClick` and `color="secondary"` is defined or `clickable={true}`.
      static member inline clickableColorSecondary(className: string) : IReactProperty = unbox ("classes.clickableColorSecondary", className)
      /// Styles applied to the root element if `onDelete` is defined.
      static member inline deletable(className: string) : IReactProperty = unbox ("classes.deletable", className)
      /// Styles applied to the root element if `onDelete` and `color="primary"` is defined.
      static member inline deletableColorPrimary(className: string) : IReactProperty = unbox ("classes.deletableColorPrimary", className)
      /// Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
      static member inline deletableColorSecondary(className: string) : IReactProperty = unbox ("classes.deletableColorSecondary", className)
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined(className: string) : IReactProperty = unbox ("classes.outlined", className)
      /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
      static member inline outlinedPrimary(className: string) : IReactProperty = unbox ("classes.outlinedPrimary", className)
      /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
      static member inline outlinedSecondary(className: string) : IReactProperty = unbox ("classes.outlinedSecondary", className)
      /// Styles applied to the `avatar` element.
      static member inline avatar(className: string) : IReactProperty = unbox ("classes.avatar", className)
      /// Styles applied to the `avatar` element if `size="small"`.
      static member inline avatarSmall(className: string) : IReactProperty = unbox ("classes.avatarSmall", className)
      /// Styles applied to the `avatar` element if `color="primary"`.
      static member inline avatarColorPrimary(className: string) : IReactProperty = unbox ("classes.avatarColorPrimary", className)
      /// Styles applied to the `avatar` element if `color="secondary"`.
      static member inline avatarColorSecondary(className: string) : IReactProperty = unbox ("classes.avatarColorSecondary", className)
      /// Styles applied to the `icon` element.
      static member inline icon(className: string) : IReactProperty = unbox ("classes.icon", className)
      /// Styles applied to the `icon` element if `size="small"`.
      static member inline iconSmall(className: string) : IReactProperty = unbox ("classes.iconSmall", className)
      /// Styles applied to the `icon` element if `color="primary"`.
      static member inline iconColorPrimary(className: string) : IReactProperty = unbox ("classes.iconColorPrimary", className)
      /// Styles applied to the `icon` element if `color="secondary"`.
      static member inline iconColorSecondary(className: string) : IReactProperty = unbox ("classes.iconColorSecondary", className)
      /// Styles applied to the label `span` element.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
      /// Styles applied to the label `span` element if `size="small"`.
      static member inline labelSmall(className: string) : IReactProperty = unbox ("classes.labelSmall", className)
      /// Styles applied to the `deleteIcon` element.
      static member inline deleteIcon(className: string) : IReactProperty = unbox ("classes.deleteIcon", className)
      /// Styles applied to the `deleteIcon` element if `size="small"`.
      static member inline deleteIconSmall(className: string) : IReactProperty = unbox ("classes.deleteIconSmall", className)
      /// Styles applied to the deleteIcon element if `color="primary"` and `variant="default"`.
      static member inline deleteIconColorPrimary(className: string) : IReactProperty = unbox ("classes.deleteIconColorPrimary", className)
      /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="default"`.
      static member inline deleteIconColorSecondary(className: string) : IReactProperty = unbox ("classes.deleteIconColorSecondary", className)
      /// Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
      static member inline deleteIconOutlinedColorPrimary(className: string) : IReactProperty = unbox ("classes.deleteIconOutlinedColorPrimary", className)
      /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.
      static member inline deleteIconOutlinedColorSecondary(className: string) : IReactProperty = unbox ("classes.deleteIconOutlinedColorSecondary", className)
  
  
  module circularProgress =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `variant="static"`.
      static member inline static'(className: string) : IReactProperty = unbox ("classes.static", className)
      /// Styles applied to the root element if `variant="indeterminate"`.
      static member inline indeterminate(className: string) : IReactProperty = unbox ("classes.indeterminate", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the `svg` element.
      static member inline svg(className: string) : IReactProperty = unbox ("classes.svg", className)
      /// Styles applied to the `circle` svg path.
      static member inline circle(className: string) : IReactProperty = unbox ("classes.circle", className)
      /// Styles applied to the `circle` svg path if `variant="static"`.
      static member inline circleStatic(className: string) : IReactProperty = unbox ("classes.circleStatic", className)
      /// Styles applied to the `circle` svg path if `variant="indeterminate"`.
      static member inline circleIndeterminate(className: string) : IReactProperty = unbox ("classes.circleIndeterminate", className)
      /// Styles applied to the `circle` svg path if `disableShrink={true}`.
      static member inline circleDisableShrink(className: string) : IReactProperty = unbox ("classes.circleDisableShrink", className)
  
  
  module collapse =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the container element.
      static member inline container(className: string) : IReactProperty = unbox ("classes.container", className)
      /// Styles applied to the container element when the transition has entered.
      static member inline entered(className: string) : IReactProperty = unbox ("classes.entered", className)
      /// Styles applied to the container element when the transition has exited and `collapsedHeight` != 0px.
      static member inline hidden(className: string) : IReactProperty = unbox ("classes.hidden", className)
      /// Styles applied to the outer wrapper element.
      static member inline wrapper(className: string) : IReactProperty = unbox ("classes.wrapper", className)
      /// Styles applied to the inner wrapper element.
      static member inline wrapperInner(className: string) : IReactProperty = unbox ("classes.wrapperInner", className)
  
  
  module container =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disableGutters={true}`.
      static member inline disableGutters(className: string) : IReactProperty = unbox ("classes.disableGutters", className)
      /// Styles applied to the root element if `fixed={true}`.
      static member inline fixed'(className: string) : IReactProperty = unbox ("classes.fixed", className)
      /// Styles applied to the root element if `maxWidth="xs"`.
      static member inline maxWidthXs(className: string) : IReactProperty = unbox ("classes.maxWidthXs", className)
      /// Styles applied to the root element if `maxWidth="sm"`.
      static member inline maxWidthSm(className: string) : IReactProperty = unbox ("classes.maxWidthSm", className)
      /// Styles applied to the root element if `maxWidth="md"`.
      static member inline maxWidthMd(className: string) : IReactProperty = unbox ("classes.maxWidthMd", className)
      /// Styles applied to the root element if `maxWidth="lg"`.
      static member inline maxWidthLg(className: string) : IReactProperty = unbox ("classes.maxWidthLg", className)
      /// Styles applied to the root element if `maxWidth="xl"`.
      static member inline maxWidthXl(className: string) : IReactProperty = unbox ("classes.maxWidthXl", className)
  
  
  module cssBaseline =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Apply global styles.
      static member inline global'(className: string) : IReactProperty = unbox ("classes.@global", className)
  
  
  module dialog =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the container element if `scroll="paper"`.
      static member inline scrollPaper(className: string) : IReactProperty = unbox ("classes.scrollPaper", className)
      /// Styles applied to the container element if `scroll="body"`.
      static member inline scrollBody(className: string) : IReactProperty = unbox ("classes.scrollBody", className)
      /// Styles applied to the container element.
      static member inline container(className: string) : IReactProperty = unbox ("classes.container", className)
      /// Styles applied to the `Paper` component.
      static member inline paper(className: string) : IReactProperty = unbox ("classes.paper", className)
      /// Styles applied to the `Paper` component if `scroll="paper"`.
      static member inline paperScrollPaper(className: string) : IReactProperty = unbox ("classes.paperScrollPaper", className)
      /// Styles applied to the `Paper` component if `scroll="body"`.
      static member inline paperScrollBody(className: string) : IReactProperty = unbox ("classes.paperScrollBody", className)
      /// Styles applied to the `Paper` component if `maxWidth=false`.
      static member inline paperWidthFalse(className: string) : IReactProperty = unbox ("classes.paperWidthFalse", className)
      /// Styles applied to the `Paper` component if `maxWidth="xs"`.
      static member inline paperWidthXs(className: string) : IReactProperty = unbox ("classes.paperWidthXs", className)
      /// Styles applied to the `Paper` component if `maxWidth="sm"`.
      static member inline paperWidthSm(className: string) : IReactProperty = unbox ("classes.paperWidthSm", className)
      /// Styles applied to the `Paper` component if `maxWidth="md"`.
      static member inline paperWidthMd(className: string) : IReactProperty = unbox ("classes.paperWidthMd", className)
      /// Styles applied to the `Paper` component if `maxWidth="lg"`.
      static member inline paperWidthLg(className: string) : IReactProperty = unbox ("classes.paperWidthLg", className)
      /// Styles applied to the `Paper` component if `maxWidth="xl"`.
      static member inline paperWidthXl(className: string) : IReactProperty = unbox ("classes.paperWidthXl", className)
      /// Styles applied to the `Paper` component if `fullWidth={true}`.
      static member inline paperFullWidth(className: string) : IReactProperty = unbox ("classes.paperFullWidth", className)
      /// Styles applied to the `Paper` component if `fullScreen={true}`.
      static member inline paperFullScreen(className: string) : IReactProperty = unbox ("classes.paperFullScreen", className)
  
  
  module dialogActions =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disableSpacing={false}`.
      static member inline spacing(className: string) : IReactProperty = unbox ("classes.spacing", className)
  
  
  module dialogContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `dividers={true}`.
      static member inline dividers(className: string) : IReactProperty = unbox ("classes.dividers", className)
  
  
  module dialogContentText =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module dialogTitle =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module divider =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `absolute={true}`.
      static member inline absolute(className: string) : IReactProperty = unbox ("classes.absolute", className)
      /// Styles applied to the root element if `variant="inset"`.
      static member inline inset(className: string) : IReactProperty = unbox ("classes.inset", className)
      /// Styles applied to the root element if `light={true}`.
      static member inline light(className: string) : IReactProperty = unbox ("classes.light", className)
      /// Styles applied to the root element if `variant="middle"`.
      static member inline middle(className: string) : IReactProperty = unbox ("classes.middle", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the root element if `flexItem={true}`.
      static member inline flexItem(className: string) : IReactProperty = unbox ("classes.flexItem", className)
  
  
  module drawer =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `variant="permanent or persistent"`.
      static member inline docked(className: string) : IReactProperty = unbox ("classes.docked", className)
      /// Styles applied to the `Paper` component.
      static member inline paper(className: string) : IReactProperty = unbox ("classes.paper", className)
      /// Styles applied to the `Paper` component if `anchor="left"`.
      static member inline paperAnchorLeft(className: string) : IReactProperty = unbox ("classes.paperAnchorLeft", className)
      /// Styles applied to the `Paper` component if `anchor="right"`.
      static member inline paperAnchorRight(className: string) : IReactProperty = unbox ("classes.paperAnchorRight", className)
      /// Styles applied to the `Paper` component if `anchor="top"`.
      static member inline paperAnchorTop(className: string) : IReactProperty = unbox ("classes.paperAnchorTop", className)
      /// Styles applied to the `Paper` component if `anchor="bottom"`.
      static member inline paperAnchorBottom(className: string) : IReactProperty = unbox ("classes.paperAnchorBottom", className)
      /// Styles applied to the `Paper` component if `anchor="left"` and `variant` is not "temporary".
      static member inline paperAnchorDockedLeft(className: string) : IReactProperty = unbox ("classes.paperAnchorDockedLeft", className)
      /// Styles applied to the `Paper` component if `anchor="top"` and `variant` is not "temporary".
      static member inline paperAnchorDockedTop(className: string) : IReactProperty = unbox ("classes.paperAnchorDockedTop", className)
      /// Styles applied to the `Paper` component if `anchor="right"` and `variant` is not "temporary".
      static member inline paperAnchorDockedRight(className: string) : IReactProperty = unbox ("classes.paperAnchorDockedRight", className)
      /// Styles applied to the `Paper` component if `anchor="bottom"` and `variant` is not "temporary".
      static member inline paperAnchorDockedBottom(className: string) : IReactProperty = unbox ("classes.paperAnchorDockedBottom", className)
      /// Styles applied to the `Modal` component.
      static member inline modal(className: string) : IReactProperty = unbox ("classes.modal", className)
  
  
  module expansionPanel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `square={false}`.
      static member inline rounded(className: string) : IReactProperty = unbox ("classes.rounded", className)
      /// Styles applied to the root element if `expanded={true}`.
      static member inline expanded(className: string) : IReactProperty = unbox ("classes.expanded", className)
      /// Styles applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
  
  
  module expansionPanelActions =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disableSpacing={false}`.
      static member inline spacing(className: string) : IReactProperty = unbox ("classes.spacing", className)
  
  
  module expansionPanelDetails =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module expansionPanelSummary =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
      static member inline expanded(className: string) : IReactProperty = unbox ("classes.expanded", className)
      /// Pseudo-class applied to the root element if `focused={true}`.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the children wrapper element.
      static member inline content(className: string) : IReactProperty = unbox ("classes.content", className)
      /// Styles applied to the `IconButton` component when `expandIcon` is supplied.
      static member inline expandIcon(className: string) : IReactProperty = unbox ("classes.expandIcon", className)
  
  
  module fab =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the span element that wraps the children.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline primary(className: string) : IReactProperty = unbox ("classes.primary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline secondary(className: string) : IReactProperty = unbox ("classes.secondary", className)
      /// Styles applied to the root element if `variant="extended"`.
      static member inline extended(className: string) : IReactProperty = unbox ("classes.extended", className)
      /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("classes.focusVisible", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit(className: string) : IReactProperty = unbox ("classes.colorInherit", className)
      /// Styles applied to the root element if `size="small"``.
      static member inline sizeSmall(className: string) : IReactProperty = unbox ("classes.sizeSmall", className)
      /// Styles applied to the root element if `size="medium"``.
      static member inline sizeMedium(className: string) : IReactProperty = unbox ("classes.sizeMedium", className)
  
  
  module filledInput =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if color secondary.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `disableUnderline={false}`.
      static member inline underline(className: string) : IReactProperty = unbox ("classes.underline", className)
      /// Pseudo-class applied to the root element if the component is focused.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `startAdornment` is provided.
      static member inline adornedStart(className: string) : IReactProperty = unbox ("classes.adornedStart", className)
      /// Styles applied to the root element if `endAdornment` is provided.
      static member inline adornedEnd(className: string) : IReactProperty = unbox ("classes.adornedEnd", className)
      /// Pseudo-class applied to the root element if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
      /// Styles applied to the `input` element if `margin="dense"`.
      static member inline marginDense(className: string) : IReactProperty = unbox ("classes.marginDense", className)
      /// Styles applied to the root element if `multiline={true}`.
      static member inline multiline(className: string) : IReactProperty = unbox ("classes.multiline", className)
      /// Styles applied to the `input` element.
      static member inline input(className: string) : IReactProperty = unbox ("classes.input", className)
      /// Styles applied to the `input` element if `margin="dense"`.
      static member inline inputMarginDense(className: string) : IReactProperty = unbox ("classes.inputMarginDense", className)
      /// Styles applied to the `input` if in ``.
      static member inline inputHiddenLabel(className: string) : IReactProperty = unbox ("classes.inputHiddenLabel", className)
      /// Styles applied to the `input` element if `multiline={true}`.
      static member inline inputMultiline(className: string) : IReactProperty = unbox ("classes.inputMultiline", className)
      /// Styles applied to the `input` element if `startAdornment` is provided.
      static member inline inputAdornedStart(className: string) : IReactProperty = unbox ("classes.inputAdornedStart", className)
      /// Styles applied to the `input` element if `endAdornment` is provided.
      static member inline inputAdornedEnd(className: string) : IReactProperty = unbox ("classes.inputAdornedEnd", className)
  
  
  module formControl =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `margin="normal"`.
      static member inline marginNormal(className: string) : IReactProperty = unbox ("classes.marginNormal", className)
      /// Styles applied to the root element if `margin="dense"`.
      static member inline marginDense(className: string) : IReactProperty = unbox ("classes.marginDense", className)
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth(className: string) : IReactProperty = unbox ("classes.fullWidth", className)
  
  
  module formControlLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `labelPlacement="start"`.
      static member inline labelPlacementStart(className: string) : IReactProperty = unbox ("classes.labelPlacementStart", className)
      /// Styles applied to the root element if `labelPlacement="top"`.
      static member inline labelPlacementTop(className: string) : IReactProperty = unbox ("classes.labelPlacementTop", className)
      /// Styles applied to the root element if `labelPlacement="bottom"`.
      static member inline labelPlacementBottom(className: string) : IReactProperty = unbox ("classes.labelPlacementBottom", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the label's Typography component.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
  
  
  module formGroup =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `row={true}`.
      static member inline row(className: string) : IReactProperty = unbox ("classes.row", className)
  
  
  module formHelperText =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `margin="dense"`.
      static member inline marginDense(className: string) : IReactProperty = unbox ("classes.marginDense", className)
      /// Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
      static member inline contained(className: string) : IReactProperty = unbox ("classes.contained", className)
      /// Pseudo-class applied to the root element if `focused={true}`.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Pseudo-class applied to the root element if `filled={true}`.
      static member inline filled(className: string) : IReactProperty = unbox ("classes.filled", className)
      /// Pseudo-class applied to the root element if `required={true}`.
      static member inline required(className: string) : IReactProperty = unbox ("classes.required", className)
  
  
  module formLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if the color is secondary.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Pseudo-class applied to the root element if `focused={true}`.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Pseudo-class applied to the root element if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
      /// Pseudo-class applied to the root element if `filled={true}`.
      static member inline filled(className: string) : IReactProperty = unbox ("classes.filled", className)
      /// Pseudo-class applied to the root element if `required={true}`.
      static member inline required(className: string) : IReactProperty = unbox ("classes.required", className)
      /// Styles applied to the asterisk element.
      static member inline asterisk(className: string) : IReactProperty = unbox ("classes.asterisk", className)
  
  
  module grid =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `container={true}`.
      static member inline container(className: string) : IReactProperty = unbox ("classes.container", className)
      /// Styles applied to the root element if `item={true}`.
      static member inline item(className: string) : IReactProperty = unbox ("classes.item", className)
      /// Styles applied to the root element if `zeroMinWidth={true}`.
      static member inline zeroMinWidth(className: string) : IReactProperty = unbox ("classes.zeroMinWidth", className)
      static member inline directionXsColumn(className: string) : IReactProperty = unbox ("classes.direction-xs-column", className)
      static member inline directionXsColumnReverse(className: string) : IReactProperty = unbox ("classes.direction-xs-column-reverse", className)
      static member inline directionXsRowReverse(className: string) : IReactProperty = unbox ("classes.direction-xs-row-reverse", className)
      static member inline wrapXsNowrap(className: string) : IReactProperty = unbox ("classes.wrap-xs-nowrap", className)
      static member inline wrapXsWrapReverse(className: string) : IReactProperty = unbox ("classes.wrap-xs-wrap-reverse", className)
      static member inline alignItemsXsCenter(className: string) : IReactProperty = unbox ("classes.align-items-xs-center", className)
      static member inline alignItemsXsFlexStart(className: string) : IReactProperty = unbox ("classes.align-items-xs-flex-start", className)
      static member inline alignItemsXsFlexEnd(className: string) : IReactProperty = unbox ("classes.align-items-xs-flex-end", className)
      static member inline alignItemsXsBaseline(className: string) : IReactProperty = unbox ("classes.align-items-xs-baseline", className)
      static member inline alignContentXsCenter(className: string) : IReactProperty = unbox ("classes.align-content-xs-center", className)
      static member inline alignContentXsFlexStart(className: string) : IReactProperty = unbox ("classes.align-content-xs-flex-start", className)
      static member inline alignContentXsFlexEnd(className: string) : IReactProperty = unbox ("classes.align-content-xs-flex-end", className)
      static member inline alignContentXsSpaceBetween(className: string) : IReactProperty = unbox ("classes.align-content-xs-space-between", className)
      static member inline alignContentXsSpaceAround(className: string) : IReactProperty = unbox ("classes.align-content-xs-space-around", className)
      static member inline justifyXsCenter(className: string) : IReactProperty = unbox ("classes.justify-xs-center", className)
      static member inline justifyXsFlexEnd(className: string) : IReactProperty = unbox ("classes.justify-xs-flex-end", className)
      static member inline justifyXsSpaceBetween(className: string) : IReactProperty = unbox ("classes.justify-xs-space-between", className)
      static member inline justifyXsSpaceAround(className: string) : IReactProperty = unbox ("classes.justify-xs-space-around", className)
      static member inline justifyXsSpaceEvenly(className: string) : IReactProperty = unbox ("classes.justify-xs-space-evenly", className)
      static member inline spacingXs1(className: string) : IReactProperty = unbox ("classes.spacing-xs-1", className)
      static member inline spacingXs2(className: string) : IReactProperty = unbox ("classes.spacing-xs-2", className)
      static member inline spacingXs3(className: string) : IReactProperty = unbox ("classes.spacing-xs-3", className)
      static member inline spacingXs4(className: string) : IReactProperty = unbox ("classes.spacing-xs-4", className)
      static member inline spacingXs5(className: string) : IReactProperty = unbox ("classes.spacing-xs-5", className)
      static member inline spacingXs6(className: string) : IReactProperty = unbox ("classes.spacing-xs-6", className)
      static member inline spacingXs7(className: string) : IReactProperty = unbox ("classes.spacing-xs-7", className)
      static member inline spacingXs8(className: string) : IReactProperty = unbox ("classes.spacing-xs-8", className)
      static member inline spacingXs9(className: string) : IReactProperty = unbox ("classes.spacing-xs-9", className)
      static member inline spacingXs10(className: string) : IReactProperty = unbox ("classes.spacing-xs-10", className)
      static member inline gridXsAuto(className: string) : IReactProperty = unbox ("classes.grid-xs-auto", className)
      static member inline gridXsTrue(className: string) : IReactProperty = unbox ("classes.grid-xs-true", className)
      static member inline gridXs1(className: string) : IReactProperty = unbox ("classes.grid-xs-1", className)
      static member inline gridXs2(className: string) : IReactProperty = unbox ("classes.grid-xs-2", className)
      static member inline gridXs3(className: string) : IReactProperty = unbox ("classes.grid-xs-3", className)
      static member inline gridXs4(className: string) : IReactProperty = unbox ("classes.grid-xs-4", className)
      static member inline gridXs5(className: string) : IReactProperty = unbox ("classes.grid-xs-5", className)
      static member inline gridXs6(className: string) : IReactProperty = unbox ("classes.grid-xs-6", className)
      static member inline gridXs7(className: string) : IReactProperty = unbox ("classes.grid-xs-7", className)
      static member inline gridXs8(className: string) : IReactProperty = unbox ("classes.grid-xs-8", className)
      static member inline gridXs9(className: string) : IReactProperty = unbox ("classes.grid-xs-9", className)
      static member inline gridXs10(className: string) : IReactProperty = unbox ("classes.grid-xs-10", className)
      static member inline gridXs11(className: string) : IReactProperty = unbox ("classes.grid-xs-11", className)
      static member inline gridXs12(className: string) : IReactProperty = unbox ("classes.grid-xs-12", className)
  
  
  module gridList =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module gridListTile =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the `div` element that wraps the children.
      static member inline tile(className: string) : IReactProperty = unbox ("classes.tile", className)
      /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
      static member inline imgFullHeight(className: string) : IReactProperty = unbox ("classes.imgFullHeight", className)
      /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
      static member inline imgFullWidth(className: string) : IReactProperty = unbox ("classes.imgFullWidth", className)
  
  
  module gridListTileBar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `titlePosition="bottom"`.
      static member inline titlePositionBottom(className: string) : IReactProperty = unbox ("classes.titlePositionBottom", className)
      /// Styles applied to the root element if `titlePosition="top"`.
      static member inline titlePositionTop(className: string) : IReactProperty = unbox ("classes.titlePositionTop", className)
      /// Styles applied to the root element if a `subtitle` is provided.
      static member inline rootSubtitle(className: string) : IReactProperty = unbox ("classes.rootSubtitle", className)
      /// Styles applied to the title and subtitle container element.
      static member inline titleWrap(className: string) : IReactProperty = unbox ("classes.titleWrap", className)
      /// Styles applied to the container element if `actionPosition="left"`.
      static member inline titleWrapActionPosLeft(className: string) : IReactProperty = unbox ("classes.titleWrapActionPosLeft", className)
      /// Styles applied to the container element if `actionPosition="right"`.
      static member inline titleWrapActionPosRight(className: string) : IReactProperty = unbox ("classes.titleWrapActionPosRight", className)
      /// Styles applied to the title container element.
      static member inline title(className: string) : IReactProperty = unbox ("classes.title", className)
      /// Styles applied to the subtitle container element.
      static member inline subtitle(className: string) : IReactProperty = unbox ("classes.subtitle", className)
      /// Styles applied to the actionIcon if supplied.
      static member inline actionIcon(className: string) : IReactProperty = unbox ("classes.actionIcon", className)
      /// Styles applied to the actionIcon if `actionPosition="left"`.
      static member inline actionIconActionPosLeft(className: string) : IReactProperty = unbox ("classes.actionIconActionPosLeft", className)
  
  
  module icon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `color="action"`.
      static member inline colorAction(className: string) : IReactProperty = unbox ("classes.colorAction", className)
      /// Styles applied to the root element if `color="error"`.
      static member inline colorError(className: string) : IReactProperty = unbox ("classes.colorError", className)
      /// Styles applied to the root element if `color="disabled"`.
      static member inline colorDisabled(className: string) : IReactProperty = unbox ("classes.colorDisabled", className)
      /// Styles applied to the root element if `fontSize="inherit"`.
      static member inline fontSizeInherit(className: string) : IReactProperty = unbox ("classes.fontSizeInherit", className)
      /// Styles applied to the root element if `fontSize="small"`.
      static member inline fontSizeSmall(className: string) : IReactProperty = unbox ("classes.fontSizeSmall", className)
      /// Styles applied to the root element if `fontSize="large"`.
      static member inline fontSizeLarge(className: string) : IReactProperty = unbox ("classes.fontSizeLarge", className)
  
  
  module iconButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `edge="start"`.
      static member inline edgeStart(className: string) : IReactProperty = unbox ("classes.edgeStart", className)
      /// Styles applied to the root element if `edge="end"`.
      static member inline edgeEnd(className: string) : IReactProperty = unbox ("classes.edgeEnd", className)
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit(className: string) : IReactProperty = unbox ("classes.colorInherit", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall(className: string) : IReactProperty = unbox ("classes.sizeSmall", className)
      /// Styles applied to the children container element.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
  
  
  module input =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if the component is a descendant of `FormControl`.
      static member inline formControl(className: string) : IReactProperty = unbox ("classes.formControl", className)
      /// Styles applied to the root element if the component is focused.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Styles applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if color secondary.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `disableUnderline={false}`.
      static member inline underline(className: string) : IReactProperty = unbox ("classes.underline", className)
      /// Pseudo-class applied to the root element if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
      /// Styles applied to the `input` element if `margin="dense"`.
      static member inline marginDense(className: string) : IReactProperty = unbox ("classes.marginDense", className)
      /// Styles applied to the root element if `multiline={true}`.
      static member inline multiline(className: string) : IReactProperty = unbox ("classes.multiline", className)
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth(className: string) : IReactProperty = unbox ("classes.fullWidth", className)
      /// Styles applied to the `input` element.
      static member inline input(className: string) : IReactProperty = unbox ("classes.input", className)
      /// Styles applied to the `input` element if `margin="dense"`.
      static member inline inputMarginDense(className: string) : IReactProperty = unbox ("classes.inputMarginDense", className)
      /// Styles applied to the `input` element if `multiline={true}`.
      static member inline inputMultiline(className: string) : IReactProperty = unbox ("classes.inputMultiline", className)
      /// Styles applied to the `input` element if `type="search"`.
      static member inline inputTypeSearch(className: string) : IReactProperty = unbox ("classes.inputTypeSearch", className)
  
  
  module inputAdornment =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `variant="filled"`.
      static member inline filled(className: string) : IReactProperty = unbox ("classes.filled", className)
      /// Styles applied to the root element if `position="start"`.
      static member inline positionStart(className: string) : IReactProperty = unbox ("classes.positionStart", className)
      /// Styles applied to the root element if `position="end"`.
      static member inline positionEnd(className: string) : IReactProperty = unbox ("classes.positionEnd", className)
      /// Styles applied to the root element if `disablePointerEvents=true`.
      static member inline disablePointerEvents(className: string) : IReactProperty = unbox ("classes.disablePointerEvents", className)
      /// Styles applied if the adornment is used inside <formcontrol hiddenlabel=""></formcontrol>.
      static member inline hiddenLabel(className: string) : IReactProperty = unbox ("classes.hiddenLabel", className)
      /// Styles applied if the adornment is used inside <formcontrol margin="dense"></formcontrol>.
      static member inline marginDense(className: string) : IReactProperty = unbox ("classes.marginDense", className)
  
  
  module inputBase =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Apply global styles.
      static member inline global'(className: string) : IReactProperty = unbox ("classes.@global", className)
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if the component is a descendant of `FormControl`.
      static member inline formControl(className: string) : IReactProperty = unbox ("classes.formControl", className)
      /// Styles applied to the root element if the component is focused.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Styles applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `startAdornment` is provided.
      static member inline adornedStart(className: string) : IReactProperty = unbox ("classes.adornedStart", className)
      /// Styles applied to the root element if `endAdornment` is provided.
      static member inline adornedEnd(className: string) : IReactProperty = unbox ("classes.adornedEnd", className)
      /// Pseudo-class applied to the root element if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
      /// Styles applied to the `input` element if `margin="dense"`.
      static member inline marginDense(className: string) : IReactProperty = unbox ("classes.marginDense", className)
      /// Styles applied to the root element if `multiline={true}`.
      static member inline multiline(className: string) : IReactProperty = unbox ("classes.multiline", className)
      /// Styles applied to the root element if the color is secondary.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth(className: string) : IReactProperty = unbox ("classes.fullWidth", className)
      /// Styles applied to the `input` element.
      static member inline input(className: string) : IReactProperty = unbox ("classes.input", className)
      /// Styles applied to the `input` element if `margin="dense"`.
      static member inline inputMarginDense(className: string) : IReactProperty = unbox ("classes.inputMarginDense", className)
      /// Styles applied to the `input` element if `multiline={true}`.
      static member inline inputMultiline(className: string) : IReactProperty = unbox ("classes.inputMultiline", className)
      /// Styles applied to the `input` element if `type="search"`.
      static member inline inputTypeSearch(className: string) : IReactProperty = unbox ("classes.inputTypeSearch", className)
      /// Styles applied to the `input` element if `startAdornment` is provided.
      static member inline inputAdornedStart(className: string) : IReactProperty = unbox ("classes.inputAdornedStart", className)
      /// Styles applied to the `input` element if `endAdornment` is provided.
      static member inline inputAdornedEnd(className: string) : IReactProperty = unbox ("classes.inputAdornedEnd", className)
      /// Styles applied to the `input` element if `hiddenLabel={true}`.
      static member inline inputHiddenLabel(className: string) : IReactProperty = unbox ("classes.inputHiddenLabel", className)
  
  
  module inputLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if `focused={true}`.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Pseudo-class applied to the root element if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
      /// Pseudo-class applied to the root element if `required={true}`.
      static member inline required(className: string) : IReactProperty = unbox ("classes.required", className)
      /// Pseudo-class applied to the asterisk element.
      static member inline asterisk(className: string) : IReactProperty = unbox ("classes.asterisk", className)
      /// Styles applied to the root element if the component is a descendant of `FormControl`.
      static member inline formControl(className: string) : IReactProperty = unbox ("classes.formControl", className)
      /// Styles applied to the root element if `margin="dense"`.
      static member inline marginDense(className: string) : IReactProperty = unbox ("classes.marginDense", className)
      /// Styles applied to the `input` element if `shrink={true}`.
      static member inline shrink(className: string) : IReactProperty = unbox ("classes.shrink", className)
      /// Styles applied to the `input` element if `disableAnimation={false}`.
      static member inline animated(className: string) : IReactProperty = unbox ("classes.animated", className)
      /// Styles applied to the root element if `variant="filled"`.
      static member inline filled(className: string) : IReactProperty = unbox ("classes.filled", className)
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined(className: string) : IReactProperty = unbox ("classes.outlined", className)
  
  
  module linearProgress =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root and bar2 element if `color="primary"`; bar2 if `variant="buffer"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root and bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `variant="determinate"`.
      static member inline determinate(className: string) : IReactProperty = unbox ("classes.determinate", className)
      /// Styles applied to the root element if `variant="indeterminate"`.
      static member inline indeterminate(className: string) : IReactProperty = unbox ("classes.indeterminate", className)
      /// Styles applied to the root element if `variant="buffer"`.
      static member inline buffer(className: string) : IReactProperty = unbox ("classes.buffer", className)
      /// Styles applied to the root element if `variant="query"`.
      static member inline query(className: string) : IReactProperty = unbox ("classes.query", className)
      /// Styles applied to the additional bar element if `variant="buffer"`.
      static member inline dashed(className: string) : IReactProperty = unbox ("classes.dashed", className)
      /// Styles applied to the additional bar element if `variant="buffer"` and `color="primary"`.
      static member inline dashedColorPrimary(className: string) : IReactProperty = unbox ("classes.dashedColorPrimary", className)
      /// Styles applied to the additional bar element if `variant="buffer"` and `color="secondary"`.
      static member inline dashedColorSecondary(className: string) : IReactProperty = unbox ("classes.dashedColorSecondary", className)
      /// Styles applied to the layered bar1 and bar2 elements.
      static member inline bar(className: string) : IReactProperty = unbox ("classes.bar", className)
      /// Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
      static member inline barColorPrimary(className: string) : IReactProperty = unbox ("classes.barColorPrimary", className)
      /// Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
      static member inline barColorSecondary(className: string) : IReactProperty = unbox ("classes.barColorSecondary", className)
      /// Styles applied to the bar1 element if `variant="indeterminate or query"`.
      static member inline bar1Indeterminate(className: string) : IReactProperty = unbox ("classes.bar1Indeterminate", className)
      /// Styles applied to the bar1 element if `variant="determinate"`.
      static member inline bar1Determinate(className: string) : IReactProperty = unbox ("classes.bar1Determinate", className)
      /// Styles applied to the bar1 element if `variant="buffer"`.
      static member inline bar1Buffer(className: string) : IReactProperty = unbox ("classes.bar1Buffer", className)
      /// Styles applied to the bar2 element if `variant="indeterminate or query"`.
      static member inline bar2Indeterminate(className: string) : IReactProperty = unbox ("classes.bar2Indeterminate", className)
      /// Styles applied to the bar2 element if `variant="buffer"`.
      static member inline bar2Buffer(className: string) : IReactProperty = unbox ("classes.bar2Buffer", className)
  
  
  module link =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `underline="none"`.
      static member inline underlineNone(className: string) : IReactProperty = unbox ("classes.underlineNone", className)
      /// Styles applied to the root element if `underline="hover"`.
      static member inline underlineHover(className: string) : IReactProperty = unbox ("classes.underlineHover", className)
      /// Styles applied to the root element if `underline="always"`.
      static member inline underlineAlways(className: string) : IReactProperty = unbox ("classes.underlineAlways", className)
      /// Styles applied to the root element if `component="button"`.
      static member inline button(className: string) : IReactProperty = unbox ("classes.button", className)
      /// Pseudo-class applied to the root element if the link is keyboard focused.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("classes.focusVisible", className)
  
    /// `classes` prop applied to the [`Typography`](https://material-ui.com/api/typography/) element.
    [<Erase>]
    type TypographyClasses =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("TypographyClasses.root", className)
      /// Styles applied to the root element if `variant="body2"`.
      static member inline body2(className: string) : IReactProperty = unbox ("TypographyClasses.body2", className)
      /// Styles applied to the root element if `variant="body1"`.
      static member inline body1(className: string) : IReactProperty = unbox ("TypographyClasses.body1", className)
      /// Styles applied to the root element if `variant="caption"`.
      static member inline caption(className: string) : IReactProperty = unbox ("TypographyClasses.caption", className)
      /// Styles applied to the root element if `variant="button"`.
      static member inline button(className: string) : IReactProperty = unbox ("TypographyClasses.button", className)
      /// Styles applied to the root element if `variant="h1"`.
      static member inline h1(className: string) : IReactProperty = unbox ("TypographyClasses.h1", className)
      /// Styles applied to the root element if `variant="h2"`.
      static member inline h2(className: string) : IReactProperty = unbox ("TypographyClasses.h2", className)
      /// Styles applied to the root element if `variant="h3"`.
      static member inline h3(className: string) : IReactProperty = unbox ("TypographyClasses.h3", className)
      /// Styles applied to the root element if `variant="h4"`.
      static member inline h4(className: string) : IReactProperty = unbox ("TypographyClasses.h4", className)
      /// Styles applied to the root element if `variant="h5"`.
      static member inline h5(className: string) : IReactProperty = unbox ("TypographyClasses.h5", className)
      /// Styles applied to the root element if `variant="h6"`.
      static member inline h6(className: string) : IReactProperty = unbox ("TypographyClasses.h6", className)
      /// Styles applied to the root element if `variant="subtitle1"`.
      static member inline subtitle1(className: string) : IReactProperty = unbox ("TypographyClasses.subtitle1", className)
      /// Styles applied to the root element if `variant="subtitle2"`.
      static member inline subtitle2(className: string) : IReactProperty = unbox ("TypographyClasses.subtitle2", className)
      /// Styles applied to the root element if `variant="overline"`.
      static member inline overline(className: string) : IReactProperty = unbox ("TypographyClasses.overline", className)
      /// Styles applied to the root element if `variant="srOnly"`. Only accessible to screen readers.
      static member inline srOnly(className: string) : IReactProperty = unbox ("TypographyClasses.srOnly", className)
      /// Styles applied to the root element if `align="left"`.
      static member inline alignLeft(className: string) : IReactProperty = unbox ("TypographyClasses.alignLeft", className)
      /// Styles applied to the root element if `align="center"`.
      static member inline alignCenter(className: string) : IReactProperty = unbox ("TypographyClasses.alignCenter", className)
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight(className: string) : IReactProperty = unbox ("TypographyClasses.alignRight", className)
      /// Styles applied to the root element if `align="justify"`.
      static member inline alignJustify(className: string) : IReactProperty = unbox ("TypographyClasses.alignJustify", className)
      /// Styles applied to the root element if `nowrap={true}`.
      static member inline noWrap(className: string) : IReactProperty = unbox ("TypographyClasses.noWrap", className)
      /// Styles applied to the root element if `gutterBottom={true}`.
      static member inline gutterBottom(className: string) : IReactProperty = unbox ("TypographyClasses.gutterBottom", className)
      /// Styles applied to the root element if `paragraph={true}`.
      static member inline paragraph(className: string) : IReactProperty = unbox ("TypographyClasses.paragraph", className)
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit(className: string) : IReactProperty = unbox ("TypographyClasses.colorInherit", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("TypographyClasses.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("TypographyClasses.colorSecondary", className)
      /// Styles applied to the root element if `color="textPrimary"`.
      static member inline colorTextPrimary(className: string) : IReactProperty = unbox ("TypographyClasses.colorTextPrimary", className)
      /// Styles applied to the root element if `color="textSecondary"`.
      static member inline colorTextSecondary(className: string) : IReactProperty = unbox ("TypographyClasses.colorTextSecondary", className)
      /// Styles applied to the root element if `color="error"`.
      static member inline colorError(className: string) : IReactProperty = unbox ("TypographyClasses.colorError", className)
      /// Styles applied to the root element if `display="inline"`.
      static member inline displayInline(className: string) : IReactProperty = unbox ("TypographyClasses.displayInline", className)
      /// Styles applied to the root element if `display="block"`.
      static member inline displayBlock(className: string) : IReactProperty = unbox ("TypographyClasses.displayBlock", className)
  
  
  module list =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disablePadding={false}`.
      static member inline padding(className: string) : IReactProperty = unbox ("classes.padding", className)
      /// Styles applied to the root element if dense.
      static member inline dense(className: string) : IReactProperty = unbox ("classes.dense", className)
      /// Styles applied to the root element if a `subheader` is provided.
      static member inline subheader(className: string) : IReactProperty = unbox ("classes.subheader", className)
  
  
  module listItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the `container` element if `children` includes `ListItemSecondaryAction`.
      static member inline container(className: string) : IReactProperty = unbox ("classes.container", className)
      /// Pseudo-class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("classes.focusVisible", className)
      /// Styles applied to the `component` element if dense.
      static member inline dense(className: string) : IReactProperty = unbox ("classes.dense", className)
      /// Styles applied to the `component` element if `alignItems="flex-start"`.
      static member inline alignItemsFlexStart(className: string) : IReactProperty = unbox ("classes.alignItemsFlexStart", className)
      /// Pseudo-class applied to the inner `component` element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the inner `component` element if `divider={true}`.
      static member inline divider(className: string) : IReactProperty = unbox ("classes.divider", className)
      /// Styles applied to the inner `component` element if `disableGutters={false}`.
      static member inline gutters(className: string) : IReactProperty = unbox ("classes.gutters", className)
      /// Styles applied to the inner `component` element if `button={true}`.
      static member inline button(className: string) : IReactProperty = unbox ("classes.button", className)
      /// Styles applied to the `component` element if `children` includes `ListItemSecondaryAction`.
      static member inline secondaryAction(className: string) : IReactProperty = unbox ("classes.secondaryAction", className)
      /// Pseudo-class applied to the root element if `selected={true}`.
      static member inline selected(className: string) : IReactProperty = unbox ("classes.selected", className)
  
  
  module listItemAvatar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
      static member inline alignItemsFlexStart(className: string) : IReactProperty = unbox ("classes.alignItemsFlexStart", className)
  
  
  module listItemIcon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
      static member inline alignItemsFlexStart(className: string) : IReactProperty = unbox ("classes.alignItemsFlexStart", className)
  
  
  module listItemSecondaryAction =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module listItemText =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the `Typography` components if primary and secondary are set.
      static member inline multiline(className: string) : IReactProperty = unbox ("classes.multiline", className)
      /// Styles applied to the `Typography` components if dense.
      static member inline dense(className: string) : IReactProperty = unbox ("classes.dense", className)
      /// Styles applied to the root element if `inset={true}`.
      static member inline inset(className: string) : IReactProperty = unbox ("classes.inset", className)
      /// Styles applied to the primary `Typography` component.
      static member inline primary(className: string) : IReactProperty = unbox ("classes.primary", className)
      /// Styles applied to the secondary `Typography` component.
      static member inline secondary(className: string) : IReactProperty = unbox ("classes.secondary", className)
  
  
  module listSubheader =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit(className: string) : IReactProperty = unbox ("classes.colorInherit", className)
      /// Styles applied to the inner `component` element if `disableGutters={false}`.
      static member inline gutters(className: string) : IReactProperty = unbox ("classes.gutters", className)
      /// Styles applied to the root element if `inset={true}`.
      static member inline inset(className: string) : IReactProperty = unbox ("classes.inset", className)
      /// Styles applied to the root element if `disableSticky={false}`.
      static member inline sticky(className: string) : IReactProperty = unbox ("classes.sticky", className)
  
  
  module menu =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the `Paper` component.
      static member inline paper(className: string) : IReactProperty = unbox ("classes.paper", className)
      /// Styles applied to the `List` component via `MenuList`.
      static member inline list(className: string) : IReactProperty = unbox ("classes.list", className)
  
    /// `classes` prop applied to the [`Popover`](https://material-ui.com/api/popover/) element.
    [<Erase>]
    type PopoverClasses =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("PopoverClasses.root", className)
      /// Styles applied to the `Paper` component.
      static member inline paper(className: string) : IReactProperty = unbox ("PopoverClasses.paper", className)
  
  
  module menuItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disableGutters={false}`.
      static member inline gutters(className: string) : IReactProperty = unbox ("classes.gutters", className)
      /// Styles applied to the root element if `selected={true}`.
      static member inline selected(className: string) : IReactProperty = unbox ("classes.selected", className)
      /// Styles applied to the root element if dense.
      static member inline dense(className: string) : IReactProperty = unbox ("classes.dense", className)
  
    /// `classes` prop applied to the [`ListItem`](https://material-ui.com/api/list-item/) element.
    [<Erase>]
    type ListItemClasses =
      /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
      static member inline root(className: string) : IReactProperty = unbox ("ListItemClasses.root", className)
      /// Styles applied to the `container` element if `children` includes `ListItemSecondaryAction`.
      static member inline container(className: string) : IReactProperty = unbox ("ListItemClasses.container", className)
      /// Pseudo-class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("ListItemClasses.focusVisible", className)
      /// Styles applied to the `component` element if dense.
      static member inline dense(className: string) : IReactProperty = unbox ("ListItemClasses.dense", className)
      /// Styles applied to the `component` element if `alignItems="flex-start"`.
      static member inline alignItemsFlexStart(className: string) : IReactProperty = unbox ("ListItemClasses.alignItemsFlexStart", className)
      /// Pseudo-class applied to the inner `component` element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("ListItemClasses.disabled", className)
      /// Styles applied to the inner `component` element if `divider={true}`.
      static member inline divider(className: string) : IReactProperty = unbox ("ListItemClasses.divider", className)
      /// Styles applied to the inner `component` element if `disableGutters={false}`.
      static member inline gutters(className: string) : IReactProperty = unbox ("ListItemClasses.gutters", className)
      /// Styles applied to the inner `component` element if `button={true}`.
      static member inline button(className: string) : IReactProperty = unbox ("ListItemClasses.button", className)
      /// Styles applied to the `component` element if `children` includes `ListItemSecondaryAction`.
      static member inline secondaryAction(className: string) : IReactProperty = unbox ("ListItemClasses.secondaryAction", className)
      /// Pseudo-class applied to the root element if `selected={true}`.
      static member inline selected(className: string) : IReactProperty = unbox ("ListItemClasses.selected", className)
  
  
  module mobileStepper =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `position="bottom"`.
      static member inline positionBottom(className: string) : IReactProperty = unbox ("classes.positionBottom", className)
      /// Styles applied to the root element if `position="top"`.
      static member inline positionTop(className: string) : IReactProperty = unbox ("classes.positionTop", className)
      /// Styles applied to the root element if `position="static"`.
      static member inline positionStatic(className: string) : IReactProperty = unbox ("classes.positionStatic", className)
      /// Styles applied to the dots container if `variant="dots"`.
      static member inline dots(className: string) : IReactProperty = unbox ("classes.dots", className)
      /// Styles applied to each dot if `variant="dots"`.
      static member inline dot(className: string) : IReactProperty = unbox ("classes.dot", className)
      /// Styles applied to a dot if `variant="dots"` and this is the active step.
      static member inline dotActive(className: string) : IReactProperty = unbox ("classes.dotActive", className)
      /// Styles applied to the Linear Progress component if `variant="progress"`.
      static member inline progress(className: string) : IReactProperty = unbox ("classes.progress", className)
  
  
  module nativeSelect =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the select component `root` class.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the select component `select` class.
      static member inline select(className: string) : IReactProperty = unbox ("classes.select", className)
      /// Styles applied to the select component if `variant="filled"`.
      static member inline filled(className: string) : IReactProperty = unbox ("classes.filled", className)
      /// Styles applied to the select component if `variant="outlined"`.
      static member inline outlined(className: string) : IReactProperty = unbox ("classes.outlined", className)
      /// Styles applied to the select component `selectMenu` class.
      static member inline selectMenu(className: string) : IReactProperty = unbox ("classes.selectMenu", className)
      /// Pseudo-class applied to the select component `disabled` class.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the icon component.
      static member inline icon(className: string) : IReactProperty = unbox ("classes.icon", className)
      /// Styles applied to the icon component if the popup is open.
      static member inline iconOpen(className: string) : IReactProperty = unbox ("classes.iconOpen", className)
      /// Styles applied to the icon component if `variant="filled"`.
      static member inline iconFilled(className: string) : IReactProperty = unbox ("classes.iconFilled", className)
      /// Styles applied to the icon component if `variant="outlined"`.
      static member inline iconOutlined(className: string) : IReactProperty = unbox ("classes.iconOutlined", className)
      /// Styles applied to the underlying native input component.
      static member inline nativeInput(className: string) : IReactProperty = unbox ("classes.nativeInput", className)
  
  
  module outlinedInput =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if the color is secondary.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if the component is focused.
      static member inline focused(className: string) : IReactProperty = unbox ("classes.focused", className)
      /// Styles applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `startAdornment` is provided.
      static member inline adornedStart(className: string) : IReactProperty = unbox ("classes.adornedStart", className)
      /// Styles applied to the root element if `endAdornment` is provided.
      static member inline adornedEnd(className: string) : IReactProperty = unbox ("classes.adornedEnd", className)
      /// Pseudo-class applied to the root element if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
      /// Styles applied to the `input` element if `margin="dense"`.
      static member inline marginDense(className: string) : IReactProperty = unbox ("classes.marginDense", className)
      /// Styles applied to the root element if `multiline={true}`.
      static member inline multiline(className: string) : IReactProperty = unbox ("classes.multiline", className)
      /// Styles applied to the `NotchedOutline` element.
      static member inline notchedOutline(className: string) : IReactProperty = unbox ("classes.notchedOutline", className)
      /// Styles applied to the `input` element.
      static member inline input(className: string) : IReactProperty = unbox ("classes.input", className)
      /// Styles applied to the `input` element if `margin="dense"`.
      static member inline inputMarginDense(className: string) : IReactProperty = unbox ("classes.inputMarginDense", className)
      /// Styles applied to the `input` element if `multiline={true}`.
      static member inline inputMultiline(className: string) : IReactProperty = unbox ("classes.inputMultiline", className)
      /// Styles applied to the `input` element if `startAdornment` is provided.
      static member inline inputAdornedStart(className: string) : IReactProperty = unbox ("classes.inputAdornedStart", className)
      /// Styles applied to the `input` element if `endAdornment` is provided.
      static member inline inputAdornedEnd(className: string) : IReactProperty = unbox ("classes.inputAdornedEnd", className)
  
  
  module pagination =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the ul element.
      static member inline ul(className: string) : IReactProperty = unbox ("classes.ul", className)
  
  
  module paper =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `square={false}`.
      static member inline rounded(className: string) : IReactProperty = unbox ("classes.rounded", className)
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined(className: string) : IReactProperty = unbox ("classes.outlined", className)
      static member inline elevation0(className: string) : IReactProperty = unbox ("classes.elevation0", className)
      static member inline elevation1(className: string) : IReactProperty = unbox ("classes.elevation1", className)
      static member inline elevation2(className: string) : IReactProperty = unbox ("classes.elevation2", className)
      static member inline elevation3(className: string) : IReactProperty = unbox ("classes.elevation3", className)
      static member inline elevation4(className: string) : IReactProperty = unbox ("classes.elevation4", className)
      static member inline elevation5(className: string) : IReactProperty = unbox ("classes.elevation5", className)
      static member inline elevation6(className: string) : IReactProperty = unbox ("classes.elevation6", className)
      static member inline elevation7(className: string) : IReactProperty = unbox ("classes.elevation7", className)
      static member inline elevation8(className: string) : IReactProperty = unbox ("classes.elevation8", className)
      static member inline elevation9(className: string) : IReactProperty = unbox ("classes.elevation9", className)
      static member inline elevation10(className: string) : IReactProperty = unbox ("classes.elevation10", className)
      static member inline elevation11(className: string) : IReactProperty = unbox ("classes.elevation11", className)
      static member inline elevation12(className: string) : IReactProperty = unbox ("classes.elevation12", className)
      static member inline elevation13(className: string) : IReactProperty = unbox ("classes.elevation13", className)
      static member inline elevation14(className: string) : IReactProperty = unbox ("classes.elevation14", className)
      static member inline elevation15(className: string) : IReactProperty = unbox ("classes.elevation15", className)
      static member inline elevation16(className: string) : IReactProperty = unbox ("classes.elevation16", className)
      static member inline elevation17(className: string) : IReactProperty = unbox ("classes.elevation17", className)
      static member inline elevation18(className: string) : IReactProperty = unbox ("classes.elevation18", className)
      static member inline elevation19(className: string) : IReactProperty = unbox ("classes.elevation19", className)
      static member inline elevation20(className: string) : IReactProperty = unbox ("classes.elevation20", className)
      static member inline elevation21(className: string) : IReactProperty = unbox ("classes.elevation21", className)
      static member inline elevation22(className: string) : IReactProperty = unbox ("classes.elevation22", className)
      static member inline elevation23(className: string) : IReactProperty = unbox ("classes.elevation23", className)
      static member inline elevation24(className: string) : IReactProperty = unbox ("classes.elevation24", className)
  
  
  module popover =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the `Paper` component.
      static member inline paper(className: string) : IReactProperty = unbox ("classes.paper", className)
  
  
  module radio =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if `checked={true}`.
      static member inline checked'(className: string) : IReactProperty = unbox ("classes.checked", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
  
  
  module rating =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall(className: string) : IReactProperty = unbox ("classes.sizeSmall", className)
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge(className: string) : IReactProperty = unbox ("classes.sizeLarge", className)
      /// Styles applied to the root element if `readOnly={true}`.
      static member inline readOnly(className: string) : IReactProperty = unbox ("classes.readOnly", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Pseudo-class applied to the root element if keyboard focused.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("classes.focusVisible", className)
      /// Visually hide an element.
      static member inline visuallyhidden(className: string) : IReactProperty = unbox ("classes.visuallyhidden", className)
      /// Styles applied to the pristine label.
      static member inline pristine(className: string) : IReactProperty = unbox ("classes.pristine", className)
      /// Styles applied to the label elements.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
      /// Styles applied to the icon wrapping elements.
      static member inline icon(className: string) : IReactProperty = unbox ("classes.icon", className)
      /// Styles applied to the icon wrapping elements when empty.
      static member inline iconEmpty(className: string) : IReactProperty = unbox ("classes.iconEmpty", className)
      /// Styles applied to the icon wrapping elements when filled.
      static member inline iconFilled(className: string) : IReactProperty = unbox ("classes.iconFilled", className)
      /// Styles applied to the icon wrapping elements when hover.
      static member inline iconHover(className: string) : IReactProperty = unbox ("classes.iconHover", className)
      /// Styles applied to the icon wrapping elements when focus.
      static member inline iconFocus(className: string) : IReactProperty = unbox ("classes.iconFocus", className)
      /// Styles applied to the icon wrapping elements when active.
      static member inline iconActive(className: string) : IReactProperty = unbox ("classes.iconActive", className)
      /// Styles applied to the icon wrapping elements when decimals are necessary.
      static member inline decimal(className: string) : IReactProperty = unbox ("classes.decimal", className)
  
  
  module scopedCssBaseline =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module select =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the select component `root` class.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the select component `select` class.
      static member inline select(className: string) : IReactProperty = unbox ("classes.select", className)
      /// Styles applied to the select component if `variant="filled"`.
      static member inline filled(className: string) : IReactProperty = unbox ("classes.filled", className)
      /// Styles applied to the select component if `variant="outlined"`.
      static member inline outlined(className: string) : IReactProperty = unbox ("classes.outlined", className)
      /// Styles applied to the select component `selectMenu` class.
      static member inline selectMenu(className: string) : IReactProperty = unbox ("classes.selectMenu", className)
      /// Pseudo-class applied to the select component `disabled` class.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the icon component.
      static member inline icon(className: string) : IReactProperty = unbox ("classes.icon", className)
      /// Styles applied to the icon component if the popup is open.
      static member inline iconOpen(className: string) : IReactProperty = unbox ("classes.iconOpen", className)
      /// Styles applied to the icon component if `variant="filled"`.
      static member inline iconFilled(className: string) : IReactProperty = unbox ("classes.iconFilled", className)
      /// Styles applied to the icon component if `variant="outlined"`.
      static member inline iconOutlined(className: string) : IReactProperty = unbox ("classes.iconOutlined", className)
      /// Styles applied to the underlying native input component.
      static member inline nativeInput(className: string) : IReactProperty = unbox ("classes.nativeInput", className)
  
  
  module skeleton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `variant="text"`.
      static member inline text(className: string) : IReactProperty = unbox ("classes.text", className)
      /// Styles applied to the root element if `variant="rect"`.
      static member inline rect(className: string) : IReactProperty = unbox ("classes.rect", className)
      /// Styles applied to the root element if `variant="circle"`.
      static member inline circle(className: string) : IReactProperty = unbox ("classes.circle", className)
      /// Styles applied to the root element if `animation="pulse"`.
      static member inline pulse(className: string) : IReactProperty = unbox ("classes.pulse", className)
      /// Styles applied to the root element if `animation="wave"`.
      static member inline wave(className: string) : IReactProperty = unbox ("classes.wave", className)
      /// Styles applied when the component is passed children.
      static member inline withChildren(className: string) : IReactProperty = unbox ("classes.withChildren", className)
      /// Styles applied when the component is passed children and no width.
      static member inline fitContent(className: string) : IReactProperty = unbox ("classes.fitContent", className)
      /// Styles applied when the component is passed children and no height.
      static member inline heightAuto(className: string) : IReactProperty = unbox ("classes.heightAuto", className)
  
  
  module slider =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `marks` is provided with at least one label.
      static member inline marked(className: string) : IReactProperty = unbox ("classes.marked", className)
      /// Pseudo-class applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Pseudo-class applied to the root and thumb element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the rail element.
      static member inline rail(className: string) : IReactProperty = unbox ("classes.rail", className)
      /// Styles applied to the track element.
      static member inline track(className: string) : IReactProperty = unbox ("classes.track", className)
      /// Styles applied to the track element if `track={false}`.
      static member inline trackFalse(className: string) : IReactProperty = unbox ("classes.trackFalse", className)
      /// Styles applied to the track element if `track="inverted"`.
      static member inline trackInverted(className: string) : IReactProperty = unbox ("classes.trackInverted", className)
      /// Styles applied to the thumb element.
      static member inline thumb(className: string) : IReactProperty = unbox ("classes.thumb", className)
      /// Styles applied to the thumb element if `color="primary"`.
      static member inline thumbColorPrimary(className: string) : IReactProperty = unbox ("classes.thumbColorPrimary", className)
      /// Styles applied to the thumb element if `color="secondary"`.
      static member inline thumbColorSecondary(className: string) : IReactProperty = unbox ("classes.thumbColorSecondary", className)
      /// Pseudo-class applied to the thumb element if it's active.
      static member inline active(className: string) : IReactProperty = unbox ("classes.active", className)
      /// Pseudo-class applied to the thumb element if keyboard focused.
      static member inline focusVisible(className: string) : IReactProperty = unbox ("classes.focusVisible", className)
      /// Styles applied to the thumb label element.
      static member inline valueLabel(className: string) : IReactProperty = unbox ("classes.valueLabel", className)
      /// Styles applied to the mark element.
      static member inline mark(className: string) : IReactProperty = unbox ("classes.mark", className)
      /// Styles applied to the mark element if active (depending on the value).
      static member inline markActive(className: string) : IReactProperty = unbox ("classes.markActive", className)
      /// Styles applied to the mark label element.
      static member inline markLabel(className: string) : IReactProperty = unbox ("classes.markLabel", className)
      /// Styles applied to the mark label element if active (depending on the value).
      static member inline markLabelActive(className: string) : IReactProperty = unbox ("classes.markLabelActive", className)
  
  
  module snackbar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'center' }}`.
      static member inline anchorOriginTopCenter(className: string) : IReactProperty = unbox ("classes.anchorOriginTopCenter", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'center' }}`.
      static member inline anchorOriginBottomCenter(className: string) : IReactProperty = unbox ("classes.anchorOriginBottomCenter", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }}`.
      static member inline anchorOriginTopRight(className: string) : IReactProperty = unbox ("classes.anchorOriginTopRight", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }}`.
      static member inline anchorOriginBottomRight(className: string) : IReactProperty = unbox ("classes.anchorOriginBottomRight", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }}`.
      static member inline anchorOriginTopLeft(className: string) : IReactProperty = unbox ("classes.anchorOriginTopLeft", className)
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }}`.
      static member inline anchorOriginBottomLeft(className: string) : IReactProperty = unbox ("classes.anchorOriginBottomLeft", className)
  
  
  module snackbarContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the message wrapper element.
      static member inline message(className: string) : IReactProperty = unbox ("classes.message", className)
      /// Styles applied to the action wrapper element if `action` is provided.
      static member inline action(className: string) : IReactProperty = unbox ("classes.action", className)
  
  
  module speedDial =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the Fab component.
      static member inline fab(className: string) : IReactProperty = unbox ("classes.fab", className)
      /// Styles applied to the root if direction="up"
      static member inline directionUp(className: string) : IReactProperty = unbox ("classes.directionUp", className)
      /// Styles applied to the root if direction="down"
      static member inline directionDown(className: string) : IReactProperty = unbox ("classes.directionDown", className)
      /// Styles applied to the root if direction="left"
      static member inline directionLeft(className: string) : IReactProperty = unbox ("classes.directionLeft", className)
      /// Styles applied to the root if direction="right"
      static member inline directionRight(className: string) : IReactProperty = unbox ("classes.directionRight", className)
      /// Styles applied to the actions (`children` wrapper) element.
      static member inline actions(className: string) : IReactProperty = unbox ("classes.actions", className)
      /// Styles applied to the actions (`children` wrapper) element if `open={false}`.
      static member inline actionsClosed(className: string) : IReactProperty = unbox ("classes.actionsClosed", className)
  
  
  module speedDialAction =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the Fab component.
      static member inline fab(className: string) : IReactProperty = unbox ("classes.fab", className)
      /// Styles applied to the Fab component if `open={false}`.
      static member inline fabClosed(className: string) : IReactProperty = unbox ("classes.fabClosed", className)
      /// Styles applied to the root element if `tooltipOpen={true}`.
      static member inline staticTooltip(className: string) : IReactProperty = unbox ("classes.staticTooltip", className)
      /// Styles applied to the root element if `tooltipOpen={true}` and `open={false}`.
      static member inline staticTooltipClosed(className: string) : IReactProperty = unbox ("classes.staticTooltipClosed", className)
      /// Styles applied to the static tooltip label if `tooltipOpen={true}`.
      static member inline staticTooltipLabel(className: string) : IReactProperty = unbox ("classes.staticTooltipLabel", className)
      /// Styles applied to the root if `tooltipOpen={true}` and `tooltipPlacement="left"``
      static member inline tooltipPlacementLeft(className: string) : IReactProperty = unbox ("classes.tooltipPlacementLeft", className)
      /// Styles applied to the root if `tooltipOpen={true}` and `tooltipPlacement="right"``
      static member inline tooltipPlacementRight(className: string) : IReactProperty = unbox ("classes.tooltipPlacementRight", className)
  
    /// `classes` prop applied to the [`Tooltip`](https://material-ui.com/api/tooltip/) element.
    [<Erase>]
    type TooltipClasses =
      /// Styles applied to the Popper component.
      static member inline popper(className: string) : IReactProperty = unbox ("TooltipClasses.popper", className)
      /// Styles applied to the Popper component if `interactive={true}`.
      static member inline popperInteractive(className: string) : IReactProperty = unbox ("TooltipClasses.popperInteractive", className)
      /// Styles applied to the Popper component if `arrow={true}`.
      static member inline popperArrow(className: string) : IReactProperty = unbox ("TooltipClasses.popperArrow", className)
      /// Styles applied to the tooltip (label wrapper) element.
      static member inline tooltip(className: string) : IReactProperty = unbox ("TooltipClasses.tooltip", className)
      /// Styles applied to the tooltip (label wrapper) element if `arrow={true}`.
      static member inline tooltipArrow(className: string) : IReactProperty = unbox ("TooltipClasses.tooltipArrow", className)
      /// Styles applied to the arrow element.
      static member inline arrow(className: string) : IReactProperty = unbox ("TooltipClasses.arrow", className)
      /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
      static member inline touch(className: string) : IReactProperty = unbox ("TooltipClasses.touch", className)
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
      static member inline tooltipPlacementLeft(className: string) : IReactProperty = unbox ("TooltipClasses.tooltipPlacementLeft", className)
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
      static member inline tooltipPlacementRight(className: string) : IReactProperty = unbox ("TooltipClasses.tooltipPlacementRight", className)
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
      static member inline tooltipPlacementTop(className: string) : IReactProperty = unbox ("TooltipClasses.tooltipPlacementTop", className)
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
      static member inline tooltipPlacementBottom(className: string) : IReactProperty = unbox ("TooltipClasses.tooltipPlacementBottom", className)
  
  
  module speedDialIcon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the icon component.
      static member inline icon(className: string) : IReactProperty = unbox ("classes.icon", className)
      /// Styles applied to the icon component if `open={true}`.
      static member inline iconOpen(className: string) : IReactProperty = unbox ("classes.iconOpen", className)
      /// Styles applied to the icon when and `openIcon` is provided and if `open={true}`.
      static member inline iconWithOpenIconOpen(className: string) : IReactProperty = unbox ("classes.iconWithOpenIconOpen", className)
      /// Styles applied to the `openIcon` if provided.
      static member inline openIcon(className: string) : IReactProperty = unbox ("classes.openIcon", className)
      /// Styles applied to the `openIcon` if provided and if `open={true}`.
      static member inline openIconOpen(className: string) : IReactProperty = unbox ("classes.openIconOpen", className)
  
  
  module step =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal(className: string) : IReactProperty = unbox ("classes.horizontal", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the root element if `alternativeLabel={true}`.
      static member inline alternativeLabel(className: string) : IReactProperty = unbox ("classes.alternativeLabel", className)
      /// Pseudo-class applied to the root element if `completed={true}`.
      static member inline completed(className: string) : IReactProperty = unbox ("classes.completed", className)
  
  
  module stepButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal(className: string) : IReactProperty = unbox ("classes.horizontal", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the `ButtonBase` touch-ripple.
      static member inline touchRipple(className: string) : IReactProperty = unbox ("classes.touchRipple", className)
  
  
  module stepConnector =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal(className: string) : IReactProperty = unbox ("classes.horizontal", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the root element if `alternativeLabel={true}`.
      static member inline alternativeLabel(className: string) : IReactProperty = unbox ("classes.alternativeLabel", className)
      /// Pseudo-class applied to the root element if `active={true}`.
      static member inline active(className: string) : IReactProperty = unbox ("classes.active", className)
      /// Pseudo-class applied to the root element if `completed={true}`.
      static member inline completed(className: string) : IReactProperty = unbox ("classes.completed", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the line element.
      static member inline line(className: string) : IReactProperty = unbox ("classes.line", className)
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline lineHorizontal(className: string) : IReactProperty = unbox ("classes.lineHorizontal", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline lineVertical(className: string) : IReactProperty = unbox ("classes.lineVertical", className)
  
  
  module stepContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `last={true}` (controlled by `Step`).
      static member inline last(className: string) : IReactProperty = unbox ("classes.last", className)
      /// Styles applied to the Transition component.
      static member inline transition(className: string) : IReactProperty = unbox ("classes.transition", className)
  
  
  module stepIcon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the SVG text element.
      static member inline text(className: string) : IReactProperty = unbox ("classes.text", className)
      /// Pseudo-class applied to the root element if `active={true}`.
      static member inline active(className: string) : IReactProperty = unbox ("classes.active", className)
      /// Pseudo-class applied to the root element if `completed={true}`.
      static member inline completed(className: string) : IReactProperty = unbox ("classes.completed", className)
      /// Pseudo-class applied to the root element if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
  
  
  module stepLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal(className: string) : IReactProperty = unbox ("classes.horizontal", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the `Typography` component which wraps `children`.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
      /// Pseudo-class applied to the `Typography` component if `active={true}`.
      static member inline active(className: string) : IReactProperty = unbox ("classes.active", className)
      /// Pseudo-class applied to the `Typography` component if `completed={true}`.
      static member inline completed(className: string) : IReactProperty = unbox ("classes.completed", className)
      /// Pseudo-class applied to the root element and `Typography` component if `error={true}`.
      static member inline error(className: string) : IReactProperty = unbox ("classes.error", className)
      /// Pseudo-class applied to the root element and `Typography` component if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the `icon` container element.
      static member inline iconContainer(className: string) : IReactProperty = unbox ("classes.iconContainer", className)
      /// Pseudo-class applied to the root and icon container and `Typography` if `alternativeLabel={true}`.
      static member inline alternativeLabel(className: string) : IReactProperty = unbox ("classes.alternativeLabel", className)
      /// Styles applied to the container element which wraps `Typography` and `optional`.
      static member inline labelContainer(className: string) : IReactProperty = unbox ("classes.labelContainer", className)
  
  
  module stepper =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal(className: string) : IReactProperty = unbox ("classes.horizontal", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the root element if `alternativeLabel={true}`.
      static member inline alternativeLabel(className: string) : IReactProperty = unbox ("classes.alternativeLabel", className)
  
  
  module svgIcon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `color="action"`.
      static member inline colorAction(className: string) : IReactProperty = unbox ("classes.colorAction", className)
      /// Styles applied to the root element if `color="error"`.
      static member inline colorError(className: string) : IReactProperty = unbox ("classes.colorError", className)
      /// Styles applied to the root element if `color="disabled"`.
      static member inline colorDisabled(className: string) : IReactProperty = unbox ("classes.colorDisabled", className)
      /// Styles applied to the root element if `fontSize="inherit"`.
      static member inline fontSizeInherit(className: string) : IReactProperty = unbox ("classes.fontSizeInherit", className)
      /// Styles applied to the root element if `fontSize="small"`.
      static member inline fontSizeSmall(className: string) : IReactProperty = unbox ("classes.fontSizeSmall", className)
      /// Styles applied to the root element if `fontSize="large"`.
      static member inline fontSizeLarge(className: string) : IReactProperty = unbox ("classes.fontSizeLarge", className)
  
  
  module switch =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `edge="start"`.
      static member inline edgeStart(className: string) : IReactProperty = unbox ("classes.edgeStart", className)
      /// Styles applied to the root element if `edge="end"`.
      static member inline edgeEnd(className: string) : IReactProperty = unbox ("classes.edgeEnd", className)
      /// Styles applied to the internal `SwitchBase` component's `root` class.
      static member inline switchBase(className: string) : IReactProperty = unbox ("classes.switchBase", className)
      /// Styles applied to the internal SwitchBase component's root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall(className: string) : IReactProperty = unbox ("classes.sizeSmall", className)
      /// Pseudo-class applied to the internal `SwitchBase` component's `checked` class.
      static member inline checked'(className: string) : IReactProperty = unbox ("classes.checked", className)
      /// Pseudo-class applied to the internal SwitchBase component's disabled class.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the internal SwitchBase component's input element.
      static member inline input(className: string) : IReactProperty = unbox ("classes.input", className)
      /// Styles used to create the thumb passed to the internal `SwitchBase` component `icon` prop.
      static member inline thumb(className: string) : IReactProperty = unbox ("classes.thumb", className)
      /// Styles applied to the track element.
      static member inline track(className: string) : IReactProperty = unbox ("classes.track", className)
  
  
  module tab =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if both `icon` and `label` are provided.
      static member inline labelIcon(className: string) : IReactProperty = unbox ("classes.labelIcon", className)
      /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="inherit"`.
      static member inline textColorInherit(className: string) : IReactProperty = unbox ("classes.textColorInherit", className)
      /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="primary"`.
      static member inline textColorPrimary(className: string) : IReactProperty = unbox ("classes.textColorPrimary", className)
      /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="secondary"`.
      static member inline textColorSecondary(className: string) : IReactProperty = unbox ("classes.textColorSecondary", className)
      /// Pseudo-class applied to the root element if `selected={true}` (controlled by the Tabs component).
      static member inline selected(className: string) : IReactProperty = unbox ("classes.selected", className)
      /// Pseudo-class applied to the root element if `disabled={true}` (controlled by the Tabs component).
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
      static member inline fullWidth(className: string) : IReactProperty = unbox ("classes.fullWidth", className)
      /// Styles applied to the root element if `wrapped={true}`.
      static member inline wrapped(className: string) : IReactProperty = unbox ("classes.wrapped", className)
      /// Styles applied to the `icon` and `label`'s wrapper element.
      static member inline wrapper(className: string) : IReactProperty = unbox ("classes.wrapper", className)
  
  
  module table =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `stickyHeader={true}`.
      static member inline stickyHeader(className: string) : IReactProperty = unbox ("classes.stickyHeader", className)
  
  
  module tableBody =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module tableCell =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `variant="head"` or `context.table.head`.
      static member inline head(className: string) : IReactProperty = unbox ("classes.head", className)
      /// Styles applied to the root element if `variant="body"` or `context.table.body`.
      static member inline body(className: string) : IReactProperty = unbox ("classes.body", className)
      /// Styles applied to the root element if `variant="footer"` or `context.table.footer`.
      static member inline footer(className: string) : IReactProperty = unbox ("classes.footer", className)
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall(className: string) : IReactProperty = unbox ("classes.sizeSmall", className)
      /// Styles applied to the root element if `padding="checkbox"`.
      static member inline paddingCheckbox(className: string) : IReactProperty = unbox ("classes.paddingCheckbox", className)
      /// Styles applied to the root element if `padding="none"`.
      static member inline paddingNone(className: string) : IReactProperty = unbox ("classes.paddingNone", className)
      /// Styles applied to the root element if `align="left"`.
      static member inline alignLeft(className: string) : IReactProperty = unbox ("classes.alignLeft", className)
      /// Styles applied to the root element if `align="center"`.
      static member inline alignCenter(className: string) : IReactProperty = unbox ("classes.alignCenter", className)
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight(className: string) : IReactProperty = unbox ("classes.alignRight", className)
      /// Styles applied to the root element if `align="justify"`.
      static member inline alignJustify(className: string) : IReactProperty = unbox ("classes.alignJustify", className)
      /// Styles applied to the root element if `context.table.stickyHeader={true}`.
      static member inline stickyHeader(className: string) : IReactProperty = unbox ("classes.stickyHeader", className)
  
  
  module tableContainer =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module tableFooter =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module tableHead =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module tablePagination =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the Toolbar component.
      static member inline toolbar(className: string) : IReactProperty = unbox ("classes.toolbar", className)
      /// Styles applied to the spacer element.
      static member inline spacer(className: string) : IReactProperty = unbox ("classes.spacer", className)
      /// Styles applied to the caption Typography components if `variant="caption"`.
      static member inline caption(className: string) : IReactProperty = unbox ("classes.caption", className)
      /// Styles applied to the Select component root element.
      static member inline selectRoot(className: string) : IReactProperty = unbox ("classes.selectRoot", className)
      /// Styles applied to the Select component `select` class.
      static member inline select(className: string) : IReactProperty = unbox ("classes.select", className)
      /// Styles applied to the Select component `icon` class.
      static member inline selectIcon(className: string) : IReactProperty = unbox ("classes.selectIcon", className)
      /// Styles applied to the `InputBase` component.
      static member inline input(className: string) : IReactProperty = unbox ("classes.input", className)
      /// Styles applied to the MenuItem component.
      static member inline menuItem(className: string) : IReactProperty = unbox ("classes.menuItem", className)
      /// Styles applied to the internal `TablePaginationActions` component.
      static member inline actions(className: string) : IReactProperty = unbox ("classes.actions", className)
  
  
  module tableRow =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if `selected={true}`.
      static member inline selected(className: string) : IReactProperty = unbox ("classes.selected", className)
      /// Pseudo-class applied to the root element if `hover={true}`.
      static member inline hover(className: string) : IReactProperty = unbox ("classes.hover", className)
      /// Styles applied to the root element if table variant="head".
      static member inline head(className: string) : IReactProperty = unbox ("classes.head", className)
      /// Styles applied to the root element if table variant="footer".
      static member inline footer(className: string) : IReactProperty = unbox ("classes.footer", className)
  
  
  module tableSortLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if `active={true}`.
      static member inline active(className: string) : IReactProperty = unbox ("classes.active", className)
      /// Styles applied to the icon component.
      static member inline icon(className: string) : IReactProperty = unbox ("classes.icon", className)
      /// Styles applied to the icon component if `direction="desc"`.
      static member inline iconDirectionDesc(className: string) : IReactProperty = unbox ("classes.iconDirectionDesc", className)
      /// Styles applied to the icon component if `direction="asc"`.
      static member inline iconDirectionAsc(className: string) : IReactProperty = unbox ("classes.iconDirectionAsc", className)
  
  
  module tabPanel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module tabs =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the flex container element.
      static member inline flexContainer(className: string) : IReactProperty = unbox ("classes.flexContainer", className)
      /// Styles applied to the flex container element if `orientation="vertical"`.
      static member inline flexContainerVertical(className: string) : IReactProperty = unbox ("classes.flexContainerVertical", className)
      /// Styles applied to the flex container element if `centered={true}`&`!variant="scrollable"`.
      static member inline centered(className: string) : IReactProperty = unbox ("classes.centered", className)
      /// Styles applied to the tablist element.
      static member inline scroller(className: string) : IReactProperty = unbox ("classes.scroller", className)
      /// Styles applied to the tablist element if `!variant="scrollable"`.
      static member inline fixed'(className: string) : IReactProperty = unbox ("classes.fixed", className)
      /// Styles applied to the tablist element if `variant="scrollable"`.
      static member inline scrollable(className: string) : IReactProperty = unbox ("classes.scrollable", className)
      /// Styles applied to the `ScrollButtonComponent` component.
      static member inline scrollButtons(className: string) : IReactProperty = unbox ("classes.scrollButtons", className)
      /// Styles applied to the `ScrollButtonComponent` component if `scrollButtons="auto"` or scrollButtons="desktop"`.
      static member inline scrollButtonsDesktop(className: string) : IReactProperty = unbox ("classes.scrollButtonsDesktop", className)
      /// Styles applied to the `TabIndicator` component.
      static member inline indicator(className: string) : IReactProperty = unbox ("classes.indicator", className)
  
  
  module tabScrollButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
  
  
  module textField =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module timeline =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `align="left"`.
      static member inline alignLeft(className: string) : IReactProperty = unbox ("classes.alignLeft", className)
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight(className: string) : IReactProperty = unbox ("classes.alignRight", className)
      /// Styles applied to the root element if `align="alternate"`.
      static member inline alignAlternate(className: string) : IReactProperty = unbox ("classes.alignAlternate", className)
  
  
  module timelineConnector =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module timelineContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight(className: string) : IReactProperty = unbox ("classes.alignRight", className)
  
  
  module timelineDot =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `color="grey"` and `variant="default"`.
      static member inline defaultGrey(className: string) : IReactProperty = unbox ("classes.defaultGrey", className)
      /// Styles applied to the root element if `color="grey"` and `variant="outlined"`.
      static member inline outlinedGrey(className: string) : IReactProperty = unbox ("classes.outlinedGrey", className)
      /// Styles applied to the root element if `color="primary"` and `variant="default"`.
      static member inline defaultPrimary(className: string) : IReactProperty = unbox ("classes.defaultPrimary", className)
      /// Styles applied to the root element if `color="primary"` and `variant="outlined"`.
      static member inline outlinedPrimary(className: string) : IReactProperty = unbox ("classes.outlinedPrimary", className)
      /// Styles applied to the root element if `color="secondary"` and `variant="default"`.
      static member inline defaultSecondary(className: string) : IReactProperty = unbox ("classes.defaultSecondary", className)
      /// Styles applied to the root element if `color="secondary"` and `variant="outlined"`.
      static member inline outlinedSecondary(className: string) : IReactProperty = unbox ("classes.outlinedSecondary", className)
  
  
  module timelineItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `align="left"`.
      static member inline alignLeft(className: string) : IReactProperty = unbox ("classes.alignLeft", className)
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight(className: string) : IReactProperty = unbox ("classes.alignRight", className)
      /// Styles applied to the root element if `align="alternate"`.
      static member inline alignAlternate(className: string) : IReactProperty = unbox ("classes.alignAlternate", className)
      /// Styles applied to the root element if no there isn't TimelineOppositeContent provided.
      static member inline missingOppositeContent(className: string) : IReactProperty = unbox ("classes.missingOppositeContent", className)
      /// Styles applied to the timeline content node.
      static member inline content(className: string) : IReactProperty = unbox ("classes.content", className)
      /// Styles applied to the timeline opposite content node.
      static member inline oppositeContent(className: string) : IReactProperty = unbox ("classes.oppositeContent", className)
  
  
  module timelineOppositeContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight(className: string) : IReactProperty = unbox ("classes.alignRight", className)
  
  
  module timelineSeparator =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module toggleButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element if `disabled={true}`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
      /// Pseudo-class applied to the root element if `selected={true}`.
      static member inline selected(className: string) : IReactProperty = unbox ("classes.selected", className)
      /// Styles applied to the `label` wrapper element.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall(className: string) : IReactProperty = unbox ("classes.sizeSmall", className)
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge(className: string) : IReactProperty = unbox ("classes.sizeLarge", className)
  
  
  module toggleButtonGroup =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical(className: string) : IReactProperty = unbox ("classes.vertical", className)
      /// Styles applied to the children.
      static member inline grouped(className: string) : IReactProperty = unbox ("classes.grouped", className)
      /// Styles applied to the children if `orientation="horizontal"`.
      static member inline groupedHorizontal(className: string) : IReactProperty = unbox ("classes.groupedHorizontal", className)
      /// Styles applied to the children if `orientation="vertical"`.
      static member inline groupedVertical(className: string) : IReactProperty = unbox ("classes.groupedVertical", className)
  
  
  module toolbar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disableGutters={false}`.
      static member inline gutters(className: string) : IReactProperty = unbox ("classes.gutters", className)
      /// Styles applied to the root element if `variant="regular"`.
      static member inline regular(className: string) : IReactProperty = unbox ("classes.regular", className)
      /// Styles applied to the root element if `variant="dense"`.
      static member inline dense(className: string) : IReactProperty = unbox ("classes.dense", className)
  
  
  module tooltip =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the Popper component.
      static member inline popper(className: string) : IReactProperty = unbox ("classes.popper", className)
      /// Styles applied to the Popper component if `interactive={true}`.
      static member inline popperInteractive(className: string) : IReactProperty = unbox ("classes.popperInteractive", className)
      /// Styles applied to the Popper component if `arrow={true}`.
      static member inline popperArrow(className: string) : IReactProperty = unbox ("classes.popperArrow", className)
      /// Styles applied to the tooltip (label wrapper) element.
      static member inline tooltip(className: string) : IReactProperty = unbox ("classes.tooltip", className)
      /// Styles applied to the tooltip (label wrapper) element if `arrow={true}`.
      static member inline tooltipArrow(className: string) : IReactProperty = unbox ("classes.tooltipArrow", className)
      /// Styles applied to the arrow element.
      static member inline arrow(className: string) : IReactProperty = unbox ("classes.arrow", className)
      /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
      static member inline touch(className: string) : IReactProperty = unbox ("classes.touch", className)
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
      static member inline tooltipPlacementLeft(className: string) : IReactProperty = unbox ("classes.tooltipPlacementLeft", className)
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
      static member inline tooltipPlacementRight(className: string) : IReactProperty = unbox ("classes.tooltipPlacementRight", className)
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
      static member inline tooltipPlacementTop(className: string) : IReactProperty = unbox ("classes.tooltipPlacementTop", className)
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
      static member inline tooltipPlacementBottom(className: string) : IReactProperty = unbox ("classes.tooltipPlacementBottom", className)
  
  
  module treeItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Pseudo-class applied to the root element when expanded.
      static member inline expanded(className: string) : IReactProperty = unbox ("classes.expanded", className)
      /// Pseudo-class applied to the root element when selected.
      static member inline selected(className: string) : IReactProperty = unbox ("classes.selected", className)
      /// Styles applied to the `role="group"` element.
      static member inline group(className: string) : IReactProperty = unbox ("classes.group", className)
      /// Styles applied to the tree node content.
      static member inline content(className: string) : IReactProperty = unbox ("classes.content", className)
      /// Styles applied to the tree node icon and collapse/expand icon.
      static member inline iconContainer(className: string) : IReactProperty = unbox ("classes.iconContainer", className)
      /// Styles applied to the label element.
      static member inline label(className: string) : IReactProperty = unbox ("classes.label", className)
  
  
  module treeView =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module typography =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `variant="body2"`.
      static member inline body2(className: string) : IReactProperty = unbox ("classes.body2", className)
      /// Styles applied to the root element if `variant="body1"`.
      static member inline body1(className: string) : IReactProperty = unbox ("classes.body1", className)
      /// Styles applied to the root element if `variant="caption"`.
      static member inline caption(className: string) : IReactProperty = unbox ("classes.caption", className)
      /// Styles applied to the root element if `variant="button"`.
      static member inline button(className: string) : IReactProperty = unbox ("classes.button", className)
      /// Styles applied to the root element if `variant="h1"`.
      static member inline h1(className: string) : IReactProperty = unbox ("classes.h1", className)
      /// Styles applied to the root element if `variant="h2"`.
      static member inline h2(className: string) : IReactProperty = unbox ("classes.h2", className)
      /// Styles applied to the root element if `variant="h3"`.
      static member inline h3(className: string) : IReactProperty = unbox ("classes.h3", className)
      /// Styles applied to the root element if `variant="h4"`.
      static member inline h4(className: string) : IReactProperty = unbox ("classes.h4", className)
      /// Styles applied to the root element if `variant="h5"`.
      static member inline h5(className: string) : IReactProperty = unbox ("classes.h5", className)
      /// Styles applied to the root element if `variant="h6"`.
      static member inline h6(className: string) : IReactProperty = unbox ("classes.h6", className)
      /// Styles applied to the root element if `variant="subtitle1"`.
      static member inline subtitle1(className: string) : IReactProperty = unbox ("classes.subtitle1", className)
      /// Styles applied to the root element if `variant="subtitle2"`.
      static member inline subtitle2(className: string) : IReactProperty = unbox ("classes.subtitle2", className)
      /// Styles applied to the root element if `variant="overline"`.
      static member inline overline(className: string) : IReactProperty = unbox ("classes.overline", className)
      /// Styles applied to the root element if `variant="srOnly"`. Only accessible to screen readers.
      static member inline srOnly(className: string) : IReactProperty = unbox ("classes.srOnly", className)
      /// Styles applied to the root element if `align="left"`.
      static member inline alignLeft(className: string) : IReactProperty = unbox ("classes.alignLeft", className)
      /// Styles applied to the root element if `align="center"`.
      static member inline alignCenter(className: string) : IReactProperty = unbox ("classes.alignCenter", className)
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight(className: string) : IReactProperty = unbox ("classes.alignRight", className)
      /// Styles applied to the root element if `align="justify"`.
      static member inline alignJustify(className: string) : IReactProperty = unbox ("classes.alignJustify", className)
      /// Styles applied to the root element if `nowrap={true}`.
      static member inline noWrap(className: string) : IReactProperty = unbox ("classes.noWrap", className)
      /// Styles applied to the root element if `gutterBottom={true}`.
      static member inline gutterBottom(className: string) : IReactProperty = unbox ("classes.gutterBottom", className)
      /// Styles applied to the root element if `paragraph={true}`.
      static member inline paragraph(className: string) : IReactProperty = unbox ("classes.paragraph", className)
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit(className: string) : IReactProperty = unbox ("classes.colorInherit", className)
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary(className: string) : IReactProperty = unbox ("classes.colorPrimary", className)
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary(className: string) : IReactProperty = unbox ("classes.colorSecondary", className)
      /// Styles applied to the root element if `color="textPrimary"`.
      static member inline colorTextPrimary(className: string) : IReactProperty = unbox ("classes.colorTextPrimary", className)
      /// Styles applied to the root element if `color="textSecondary"`.
      static member inline colorTextSecondary(className: string) : IReactProperty = unbox ("classes.colorTextSecondary", className)
      /// Styles applied to the root element if `color="error"`.
      static member inline colorError(className: string) : IReactProperty = unbox ("classes.colorError", className)
      /// Styles applied to the root element if `display="inline"`.
      static member inline displayInline(className: string) : IReactProperty = unbox ("classes.displayInline", className)
      /// Styles applied to the root element if `display="block"`.
      static member inline displayBlock(className: string) : IReactProperty = unbox ("classes.displayBlock", className)
  
  