namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core

/// Override or extend the styles applied to components.
module classes =

  type IAppBarClasses = interface end
  
  [<Erase>]
  type appBar =
    /// Styles applied to the root element.
    static member inline root(className: string) : IAppBarClasses = unbox ("root", className)
    /// Styles applied to the root element if `position="fixed"`.
    static member inline positionFixed(className: string) : IAppBarClasses = unbox ("positionFixed", className)
    /// Styles applied to the root element if `position="absolute"`.
    static member inline positionAbsolute(className: string) : IAppBarClasses = unbox ("positionAbsolute", className)
    /// Styles applied to the root element if `position="sticky"`.
    static member inline positionSticky(className: string) : IAppBarClasses = unbox ("positionSticky", className)
    /// Styles applied to the root element if `position="static"`.
    static member inline positionStatic(className: string) : IAppBarClasses = unbox ("positionStatic", className)
    /// Styles applied to the root element if `position="relative"`.
    static member inline positionRelative(className: string) : IAppBarClasses = unbox ("positionRelative", className)
    /// Styles applied to the root element if `color="default"`.
    static member inline colorDefault(className: string) : IAppBarClasses = unbox ("colorDefault", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : IAppBarClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : IAppBarClasses = unbox ("colorSecondary", className)


  type IAutocompleteClasses = interface end
  
  [<Erase>]
  type autocomplete =
    /// Styles applied to the root element.
    static member inline root(className: string) : IAutocompleteClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if focused.
    static member inline focused(className: string) : IAutocompleteClasses = unbox ("focused", className)
    /// Styles applied to the tag elements, e.g. the chips.
    static member inline tag(className: string) : IAutocompleteClasses = unbox ("tag", className)
    /// Styles applied to the tag elements, e.g. the chips if `size="small"`.
    static member inline tagSizeSmall(className: string) : IAutocompleteClasses = unbox ("tagSizeSmall", className)
    /// Styles applied to the Input element.
    static member inline inputRoot(className: string) : IAutocompleteClasses = unbox ("inputRoot", className)
    /// Styles applied to the input element.
    static member inline input(className: string) : IAutocompleteClasses = unbox ("input", className)
    /// Styles applied to the input element if tag focused.
    static member inline inputFocused(className: string) : IAutocompleteClasses = unbox ("inputFocused", className)
    /// Styles applied to the endAdornment element.
    static member inline endAdornment(className: string) : IAutocompleteClasses = unbox ("endAdornment", className)
    /// Styles applied to the clear indictator.
    static member inline clearIndicator(className: string) : IAutocompleteClasses = unbox ("clearIndicator", className)
    /// Styles applied to the clear indictator if the input is dirty.
    static member inline clearIndicatorDirty(className: string) : IAutocompleteClasses = unbox ("clearIndicatorDirty", className)
    /// Styles applied to the popup indictator.
    static member inline popupIndicator(className: string) : IAutocompleteClasses = unbox ("popupIndicator", className)
    /// Styles applied to the popup indictator if the popup is open.
    static member inline popupIndicatorOpen(className: string) : IAutocompleteClasses = unbox ("popupIndicatorOpen", className)
    /// Styles applied to the popper element.
    static member inline popper(className: string) : IAutocompleteClasses = unbox ("popper", className)
    /// Styles applied to the popper element if `disablePortal={true}`.
    static member inline popperDisablePortal(className: string) : IAutocompleteClasses = unbox ("popperDisablePortal", className)
    /// Styles applied to the `Paper` component.
    static member inline paper(className: string) : IAutocompleteClasses = unbox ("paper", className)
    /// Styles applied to the `listbox` component.
    static member inline listbox(className: string) : IAutocompleteClasses = unbox ("listbox", className)
    /// Styles applied to the loading wrapper.
    static member inline loading(className: string) : IAutocompleteClasses = unbox ("loading", className)
    /// Styles applied to the no option wrapper.
    static member inline noOptions(className: string) : IAutocompleteClasses = unbox ("noOptions", className)
    /// Styles applied to the option elements.
    static member inline option(className: string) : IAutocompleteClasses = unbox ("option", className)
    /// Styles applied to the group's label elements.
    static member inline groupLabel(className: string) : IAutocompleteClasses = unbox ("groupLabel", className)
    /// Styles applied to the group's ul elements.
    static member inline groupUl(className: string) : IAutocompleteClasses = unbox ("groupUl", className)


  type IAvatarClasses = interface end
  
  [<Erase>]
  type avatar =
    /// Styles applied to the root element.
    static member inline root(className: string) : IAvatarClasses = unbox ("root", className)
    /// Styles applied to the root element if not `src` or `srcSet`.
    static member inline colorDefault(className: string) : IAvatarClasses = unbox ("colorDefault", className)
    /// Styles applied to the root element if `variant="circle"`.
    static member inline circle(className: string) : IAvatarClasses = unbox ("circle", className)
    /// Styles applied to the root element if `variant="rounded"`.
    static member inline rounded(className: string) : IAvatarClasses = unbox ("rounded", className)
    /// Styles applied to the root element if `variant="square"`.
    static member inline square(className: string) : IAvatarClasses = unbox ("square", className)
    /// Styles applied to the img element if either `src` or `srcSet` is defined.
    static member inline img(className: string) : IAvatarClasses = unbox ("img", className)
    /// Styles applied to the fallback icon
    static member inline fallback(className: string) : IAvatarClasses = unbox ("fallback", className)


  type IAvatarGroupClasses = interface end
  
  [<Erase>]
  type avatarGroup =
    /// Styles applied to the root element.
    static member inline root(className: string) : IAvatarGroupClasses = unbox ("root", className)
    /// Styles applied to the avatar elements.
    static member inline avatar(className: string) : IAvatarGroupClasses = unbox ("avatar", className)


  type IBackdropClasses = interface end
  
  [<Erase>]
  type backdrop =
    /// Styles applied to the root element.
    static member inline root(className: string) : IBackdropClasses = unbox ("root", className)
    /// Styles applied to the root element if `invisible={true}`.
    static member inline invisible(className: string) : IBackdropClasses = unbox ("invisible", className)


  type IBadgeClasses = interface end
  
  [<Erase>]
  type badge =
    /// Styles applied to the root element.
    static member inline root(className: string) : IBadgeClasses = unbox ("root", className)
    /// Styles applied to the badge `span` element.
    static member inline badge(className: string) : IBadgeClasses = unbox ("badge", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : IBadgeClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : IBadgeClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(className: string) : IBadgeClasses = unbox ("colorError", className)
    /// Styles applied to the root element if `variant="dot"`.
    static member inline dot(className: string) : IBadgeClasses = unbox ("dot", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }} overlap="rectangle"`.
    static member inline anchorOriginTopRightRectangle(className: string) : IBadgeClasses = unbox ("anchorOriginTopRightRectangle", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }} overlap="rectangle"`.
    static member inline anchorOriginBottomRightRectangle(className: string) : IBadgeClasses = unbox ("anchorOriginBottomRightRectangle", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }} overlap="rectangle"`.
    static member inline anchorOriginTopLeftRectangle(className: string) : IBadgeClasses = unbox ("anchorOriginTopLeftRectangle", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }} overlap="rectangle"`.
    static member inline anchorOriginBottomLeftRectangle(className: string) : IBadgeClasses = unbox ("anchorOriginBottomLeftRectangle", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }} overlap="circle"`.
    static member inline anchorOriginTopRightCircle(className: string) : IBadgeClasses = unbox ("anchorOriginTopRightCircle", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }} overlap="circle"`.
    static member inline anchorOriginBottomRightCircle(className: string) : IBadgeClasses = unbox ("anchorOriginBottomRightCircle", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }} overlap="circle"`.
    static member inline anchorOriginTopLeftCircle(className: string) : IBadgeClasses = unbox ("anchorOriginTopLeftCircle", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }} overlap="circle"`.
    static member inline anchorOriginBottomLeftCircle(className: string) : IBadgeClasses = unbox ("anchorOriginBottomLeftCircle", className)
    /// Pseudo-class to the badge `span` element if `invisible={true}`.
    static member inline invisible(className: string) : IBadgeClasses = unbox ("invisible", className)


  type IBottomNavigationClasses = interface end
  
  [<Erase>]
  type bottomNavigation =
    /// Styles applied to the root element.
    static member inline root(className: string) : IBottomNavigationClasses = unbox ("root", className)


  type IBottomNavigationActionClasses = interface end
  
  [<Erase>]
  type bottomNavigationAction =
    /// Styles applied to the root element.
    static member inline root(className: string) : IBottomNavigationActionClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if selected.
    static member inline selected(className: string) : IBottomNavigationActionClasses = unbox ("selected", className)
    /// Pseudo-class applied to the root element if `showLabel={false}` and not selected.
    static member inline iconOnly(className: string) : IBottomNavigationActionClasses = unbox ("iconOnly", className)
    /// Styles applied to the span element that wraps the icon and label.
    static member inline wrapper(className: string) : IBottomNavigationActionClasses = unbox ("wrapper", className)
    /// Styles applied to the label's span element.
    static member inline label(className: string) : IBottomNavigationActionClasses = unbox ("label", className)


  type IBreadcrumbsClasses = interface end
  
  [<Erase>]
  type breadcrumbs =
    /// Styles applied to the root element.
    static member inline root(className: string) : IBreadcrumbsClasses = unbox ("root", className)
    /// Styles applied to the ol element.
    static member inline ol(className: string) : IBreadcrumbsClasses = unbox ("ol", className)
    /// Styles applied to the li element.
    static member inline li(className: string) : IBreadcrumbsClasses = unbox ("li", className)
    /// Styles applied to the separator element.
    static member inline separator(className: string) : IBreadcrumbsClasses = unbox ("separator", className)


  type IButtonClasses = interface end
  
  [<Erase>]
  type button =
    /// Styles applied to the root element.
    static member inline root(className: string) : IButtonClasses = unbox ("root", className)
    /// Styles applied to the span element that wraps the children.
    static member inline label(className: string) : IButtonClasses = unbox ("label", className)
    /// Styles applied to the root element if `variant="text"`.
    static member inline text(className: string) : IButtonClasses = unbox ("text", className)
    /// Styles applied to the root element if `variant="text"` and `color="primary"`.
    static member inline textPrimary(className: string) : IButtonClasses = unbox ("textPrimary", className)
    /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
    static member inline textSecondary(className: string) : IButtonClasses = unbox ("textSecondary", className)
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(className: string) : IButtonClasses = unbox ("outlined", className)
    /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
    static member inline outlinedPrimary(className: string) : IButtonClasses = unbox ("outlinedPrimary", className)
    /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
    static member inline outlinedSecondary(className: string) : IButtonClasses = unbox ("outlinedSecondary", className)
    /// Styles applied to the root element if `variant="contained"`.
    static member inline contained(className: string) : IButtonClasses = unbox ("contained", className)
    /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
    static member inline containedPrimary(className: string) : IButtonClasses = unbox ("containedPrimary", className)
    /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
    static member inline containedSecondary(className: string) : IButtonClasses = unbox ("containedSecondary", className)
    /// Styles applied to the root element if `disableElevation={true}`.
    static member inline disableElevation(className: string) : IButtonClasses = unbox ("disableElevation", className)
    /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
    static member inline focusVisible(className: string) : IButtonClasses = unbox ("focusVisible", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IButtonClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(className: string) : IButtonClasses = unbox ("colorInherit", className)
    /// Styles applied to the root element if `size="small"` and `variant="text"`.
    static member inline textSizeSmall(className: string) : IButtonClasses = unbox ("textSizeSmall", className)
    /// Styles applied to the root element if `size="large"` and `variant="text"`.
    static member inline textSizeLarge(className: string) : IButtonClasses = unbox ("textSizeLarge", className)
    /// Styles applied to the root element if `size="small"` and `variant="outlined"`.
    static member inline outlinedSizeSmall(className: string) : IButtonClasses = unbox ("outlinedSizeSmall", className)
    /// Styles applied to the root element if `size="large"` and `variant="outlined"`.
    static member inline outlinedSizeLarge(className: string) : IButtonClasses = unbox ("outlinedSizeLarge", className)
    /// Styles applied to the root element if `size="small"` and `variant="contained"`.
    static member inline containedSizeSmall(className: string) : IButtonClasses = unbox ("containedSizeSmall", className)
    /// Styles applied to the root element if `size="large"` and `variant="contained"`.
    static member inline containedSizeLarge(className: string) : IButtonClasses = unbox ("containedSizeLarge", className)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(className: string) : IButtonClasses = unbox ("sizeSmall", className)
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(className: string) : IButtonClasses = unbox ("sizeLarge", className)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(className: string) : IButtonClasses = unbox ("fullWidth", className)
    /// Styles applied to the startIcon element if supplied.
    static member inline startIcon(className: string) : IButtonClasses = unbox ("startIcon", className)
    /// Styles applied to the endIcon element if supplied.
    static member inline endIcon(className: string) : IButtonClasses = unbox ("endIcon", className)
    /// Styles applied to the icon element if supplied and `size="small"`.
    static member inline iconSizeSmall(className: string) : IButtonClasses = unbox ("iconSizeSmall", className)
    /// Styles applied to the icon element if supplied and `size="medium"`.
    static member inline iconSizeMedium(className: string) : IButtonClasses = unbox ("iconSizeMedium", className)
    /// Styles applied to the icon element if supplied and `size="large"`.
    static member inline iconSizeLarge(className: string) : IButtonClasses = unbox ("iconSizeLarge", className)


  type IButtonBaseClasses = interface end
  
  [<Erase>]
  type buttonBase =
    /// Styles applied to the root element.
    static member inline root(className: string) : IButtonBaseClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IButtonBaseClasses = unbox ("disabled", className)
    /// Pseudo-class applied to the root element if keyboard focused.
    static member inline focusVisible(className: string) : IButtonBaseClasses = unbox ("focusVisible", className)


  type IButtonGroupClasses = interface end
  
  [<Erase>]
  type buttonGroup =
    /// Styles applied to the root element.
    static member inline root(className: string) : IButtonGroupClasses = unbox ("root", className)
    /// Styles applied to the root element if `variant="contained"`.
    static member inline contained(className: string) : IButtonGroupClasses = unbox ("contained", className)
    /// Pseudo-class applied to child elements if `disabled={true}`.
    static member inline disabled(className: string) : IButtonGroupClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(className: string) : IButtonGroupClasses = unbox ("fullWidth", className)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(className: string) : IButtonGroupClasses = unbox ("vertical", className)
    /// Styles applied to the children.
    static member inline grouped(className: string) : IButtonGroupClasses = unbox ("grouped", className)
    /// Styles applied to the children if `orientation="horizontal"`.
    static member inline groupedHorizontal(className: string) : IButtonGroupClasses = unbox ("groupedHorizontal", className)
    /// Styles applied to the children if `orientation="vertical"`.
    static member inline groupedVertical(className: string) : IButtonGroupClasses = unbox ("groupedVertical", className)
    /// Styles applied to the children if `variant="text"`.
    static member inline groupedText(className: string) : IButtonGroupClasses = unbox ("groupedText", className)
    /// Styles applied to the children if `variant="text"` and `orientation="horizontal"`.
    static member inline groupedTextHorizontal(className: string) : IButtonGroupClasses = unbox ("groupedTextHorizontal", className)
    /// Styles applied to the children if `variant="text"` and `orientation="vertical"`.
    static member inline groupedTextVertical(className: string) : IButtonGroupClasses = unbox ("groupedTextVertical", className)
    /// Styles applied to the children if `variant="text"` and `color="primary"`.
    static member inline groupedTextPrimary(className: string) : IButtonGroupClasses = unbox ("groupedTextPrimary", className)
    /// Styles applied to the children if `variant="text"` and `color="secondary"`.
    static member inline groupedTextSecondary(className: string) : IButtonGroupClasses = unbox ("groupedTextSecondary", className)
    /// Styles applied to the children if `variant="outlined"`.
    static member inline groupedOutlined(className: string) : IButtonGroupClasses = unbox ("groupedOutlined", className)
    /// Styles applied to the children if `variant="outlined"` and `orientation="horizontal"`.
    static member inline groupedOutlinedHorizontal(className: string) : IButtonGroupClasses = unbox ("groupedOutlinedHorizontal", className)
    /// Styles applied to the children if `variant="outlined"` and `orientation="vertical"`.
    static member inline groupedOutlinedVertical(className: string) : IButtonGroupClasses = unbox ("groupedOutlinedVertical", className)
    /// Styles applied to the children if `variant="outlined"` and `color="primary"`.
    static member inline groupedOutlinedPrimary(className: string) : IButtonGroupClasses = unbox ("groupedOutlinedPrimary", className)
    /// Styles applied to the children if `variant="outlined"` and `color="secondary"`.
    static member inline groupedOutlinedSecondary(className: string) : IButtonGroupClasses = unbox ("groupedOutlinedSecondary", className)
    /// Styles applied to the children if `variant="contained"`.
    static member inline groupedContained(className: string) : IButtonGroupClasses = unbox ("groupedContained", className)
    /// Styles applied to the children if `variant="contained"` and `orientation="horizontal"`.
    static member inline groupedContainedHorizontal(className: string) : IButtonGroupClasses = unbox ("groupedContainedHorizontal", className)
    /// Styles applied to the children if `variant="contained"` and `orientation="vertical"`.
    static member inline groupedContainedVertical(className: string) : IButtonGroupClasses = unbox ("groupedContainedVertical", className)
    /// Styles applied to the children if `variant="contained"` and `color="primary"`.
    static member inline groupedContainedPrimary(className: string) : IButtonGroupClasses = unbox ("groupedContainedPrimary", className)
    /// Styles applied to the children if `variant="contained"` and `color="secondary"`.
    static member inline groupedContainedSecondary(className: string) : IButtonGroupClasses = unbox ("groupedContainedSecondary", className)


  type ICardClasses = interface end
  
  [<Erase>]
  type card =
    /// Styles applied to the root element.
    static member inline root(className: string) : ICardClasses = unbox ("root", className)


  type ICardActionAreaClasses = interface end
  
  [<Erase>]
  type cardActionArea =
    /// Styles applied to the root element.
    static member inline root(className: string) : ICardActionAreaClasses = unbox ("root", className)
    /// Pseudo-class applied to the ButtonBase root element if the action area is keyboard focused.
    static member inline focusVisible(className: string) : ICardActionAreaClasses = unbox ("focusVisible", className)
    /// Styles applied to the overlay that covers the action area when it is keyboard focused.
    static member inline focusHighlight(className: string) : ICardActionAreaClasses = unbox ("focusHighlight", className)


  type ICardActionsClasses = interface end
  
  [<Erase>]
  type cardActions =
    /// Styles applied to the root element.
    static member inline root(className: string) : ICardActionsClasses = unbox ("root", className)
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(className: string) : ICardActionsClasses = unbox ("spacing", className)


  type ICardContentClasses = interface end
  
  [<Erase>]
  type cardContent =
    /// Styles applied to the root element.
    static member inline root(className: string) : ICardContentClasses = unbox ("root", className)


  type ICardHeaderClasses = interface end
  
  [<Erase>]
  type cardHeader =
    /// Styles applied to the root element.
    static member inline root(className: string) : ICardHeaderClasses = unbox ("root", className)
    /// Styles applied to the avatar element.
    static member inline avatar(className: string) : ICardHeaderClasses = unbox ("avatar", className)
    /// Styles applied to the action element.
    static member inline action(className: string) : ICardHeaderClasses = unbox ("action", className)
    /// Styles applied to the content wrapper element.
    static member inline content(className: string) : ICardHeaderClasses = unbox ("content", className)
    /// Styles applied to the title Typography element.
    static member inline title(className: string) : ICardHeaderClasses = unbox ("title", className)
    /// Styles applied to the subheader Typography element.
    static member inline subheader(className: string) : ICardHeaderClasses = unbox ("subheader", className)


  type ICardMediaClasses = interface end
  
  [<Erase>]
  type cardMedia =
    /// Styles applied to the root element.
    static member inline root(className: string) : ICardMediaClasses = unbox ("root", className)
    /// Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.
    static member inline media(className: string) : ICardMediaClasses = unbox ("media", className)
    /// Styles applied to the root element if `component="picture or img"`.
    static member inline img(className: string) : ICardMediaClasses = unbox ("img", className)


  type ICheckboxClasses = interface end
  
  [<Erase>]
  type checkbox =
    /// Styles applied to the root element.
    static member inline root(className: string) : ICheckboxClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if `checked={true}`.
    static member inline checked'(className: string) : ICheckboxClasses = unbox ("checked", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : ICheckboxClasses = unbox ("disabled", className)
    /// Pseudo-class applied to the root element if `indeterminate={true}`.
    static member inline indeterminate(className: string) : ICheckboxClasses = unbox ("indeterminate", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : ICheckboxClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : ICheckboxClasses = unbox ("colorSecondary", className)


  type IChipClasses = interface end
  
  [<Erase>]
  type chip =
    /// Styles applied to the root element.
    static member inline root(className: string) : IChipClasses = unbox ("root", className)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(className: string) : IChipClasses = unbox ("sizeSmall", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : IChipClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : IChipClasses = unbox ("colorSecondary", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IChipClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `onClick` is defined or `clickable={true}`.
    static member inline clickable(className: string) : IChipClasses = unbox ("clickable", className)
    /// Styles applied to the root element if `onClick` and `color="primary"` is defined or `clickable={true}`.
    static member inline clickableColorPrimary(className: string) : IChipClasses = unbox ("clickableColorPrimary", className)
    /// Styles applied to the root element if `onClick` and `color="secondary"` is defined or `clickable={true}`.
    static member inline clickableColorSecondary(className: string) : IChipClasses = unbox ("clickableColorSecondary", className)
    /// Styles applied to the root element if `onDelete` is defined.
    static member inline deletable(className: string) : IChipClasses = unbox ("deletable", className)
    /// Styles applied to the root element if `onDelete` and `color="primary"` is defined.
    static member inline deletableColorPrimary(className: string) : IChipClasses = unbox ("deletableColorPrimary", className)
    /// Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
    static member inline deletableColorSecondary(className: string) : IChipClasses = unbox ("deletableColorSecondary", className)
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(className: string) : IChipClasses = unbox ("outlined", className)
    /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
    static member inline outlinedPrimary(className: string) : IChipClasses = unbox ("outlinedPrimary", className)
    /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
    static member inline outlinedSecondary(className: string) : IChipClasses = unbox ("outlinedSecondary", className)
    /// Styles applied to the `avatar` element.
    static member inline avatar(className: string) : IChipClasses = unbox ("avatar", className)
    /// Styles applied to the `avatar` element if `size="small"`.
    static member inline avatarSmall(className: string) : IChipClasses = unbox ("avatarSmall", className)
    /// Styles applied to the `avatar` element if `color="primary"`.
    static member inline avatarColorPrimary(className: string) : IChipClasses = unbox ("avatarColorPrimary", className)
    /// Styles applied to the `avatar` element if `color="secondary"`.
    static member inline avatarColorSecondary(className: string) : IChipClasses = unbox ("avatarColorSecondary", className)
    /// Styles applied to the `icon` element.
    static member inline icon(className: string) : IChipClasses = unbox ("icon", className)
    /// Styles applied to the `icon` element if `size="small"`.
    static member inline iconSmall(className: string) : IChipClasses = unbox ("iconSmall", className)
    /// Styles applied to the `icon` element if `color="primary"`.
    static member inline iconColorPrimary(className: string) : IChipClasses = unbox ("iconColorPrimary", className)
    /// Styles applied to the `icon` element if `color="secondary"`.
    static member inline iconColorSecondary(className: string) : IChipClasses = unbox ("iconColorSecondary", className)
    /// Styles applied to the label `span` element`.
    static member inline label(className: string) : IChipClasses = unbox ("label", className)
    static member inline labelSmall(className: string) : IChipClasses = unbox ("labelSmall", className)
    /// Styles applied to the `deleteIcon` element.
    static member inline deleteIcon(className: string) : IChipClasses = unbox ("deleteIcon", className)
    /// Styles applied to the `deleteIcon` element if `size="small"`.
    static member inline deleteIconSmall(className: string) : IChipClasses = unbox ("deleteIconSmall", className)
    /// Styles applied to the deleteIcon element if `color="primary"` and `variant="default"`.
    static member inline deleteIconColorPrimary(className: string) : IChipClasses = unbox ("deleteIconColorPrimary", className)
    /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="default"`.
    static member inline deleteIconColorSecondary(className: string) : IChipClasses = unbox ("deleteIconColorSecondary", className)
    /// Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
    static member inline deleteIconOutlinedColorPrimary(className: string) : IChipClasses = unbox ("deleteIconOutlinedColorPrimary", className)
    /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.
    static member inline deleteIconOutlinedColorSecondary(className: string) : IChipClasses = unbox ("deleteIconOutlinedColorSecondary", className)


  type ICircularProgressClasses = interface end
  
  [<Erase>]
  type circularProgress =
    /// Styles applied to the root element.
    static member inline root(className: string) : ICircularProgressClasses = unbox ("root", className)
    /// Styles applied to the root element if `variant="static"`.
    static member inline static'(className: string) : ICircularProgressClasses = unbox ("static", className)
    /// Styles applied to the root element if `variant="indeterminate"`.
    static member inline indeterminate(className: string) : ICircularProgressClasses = unbox ("indeterminate", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : ICircularProgressClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : ICircularProgressClasses = unbox ("colorSecondary", className)
    /// Styles applied to the `svg` element.
    static member inline svg(className: string) : ICircularProgressClasses = unbox ("svg", className)
    /// Styles applied to the `circle` svg path.
    static member inline circle(className: string) : ICircularProgressClasses = unbox ("circle", className)
    /// Styles applied to the `circle` svg path if `variant="static"`.
    static member inline circleStatic(className: string) : ICircularProgressClasses = unbox ("circleStatic", className)
    /// Styles applied to the `circle` svg path if `variant="indeterminate"`.
    static member inline circleIndeterminate(className: string) : ICircularProgressClasses = unbox ("circleIndeterminate", className)
    /// Styles applied to the `circle` svg path if `disableShrink={true}`.
    static member inline circleDisableShrink(className: string) : ICircularProgressClasses = unbox ("circleDisableShrink", className)


  type IClickAwayListenerClasses = interface end


  type ICollapseClasses = interface end
  
  [<Erase>]
  type collapse =
    /// Styles applied to the container element.
    static member inline container(className: string) : ICollapseClasses = unbox ("container", className)
    /// Styles applied to the container element when the transition has entered.
    static member inline entered(className: string) : ICollapseClasses = unbox ("entered", className)
    /// Styles applied to the container element when the transition has exited and `collapsedHeight` != 0px.
    static member inline hidden(className: string) : ICollapseClasses = unbox ("hidden", className)
    /// Styles applied to the outer wrapper element.
    static member inline wrapper(className: string) : ICollapseClasses = unbox ("wrapper", className)
    /// Styles applied to the inner wrapper element.
    static member inline wrapperInner(className: string) : ICollapseClasses = unbox ("wrapperInner", className)


  type IContainerClasses = interface end
  
  [<Erase>]
  type container =
    /// Styles applied to the root element.
    static member inline root(className: string) : IContainerClasses = unbox ("root", className)
    /// Styles applied to the root element if `disableGutters={true}`.
    static member inline disableGutters(className: string) : IContainerClasses = unbox ("disableGutters", className)
    /// Styles applied to the root element if `fixed={true}`.
    static member inline fixed'(className: string) : IContainerClasses = unbox ("fixed", className)
    /// Styles applied to the root element if `maxWidth="xs"`.
    static member inline maxWidthXs(className: string) : IContainerClasses = unbox ("maxWidthXs", className)
    /// Styles applied to the root element if `maxWidth="sm"`.
    static member inline maxWidthSm(className: string) : IContainerClasses = unbox ("maxWidthSm", className)
    /// Styles applied to the root element if `maxWidth="md"`.
    static member inline maxWidthMd(className: string) : IContainerClasses = unbox ("maxWidthMd", className)
    /// Styles applied to the root element if `maxWidth="lg"`.
    static member inline maxWidthLg(className: string) : IContainerClasses = unbox ("maxWidthLg", className)
    /// Styles applied to the root element if `maxWidth="xl"`.
    static member inline maxWidthXl(className: string) : IContainerClasses = unbox ("maxWidthXl", className)


  type ICssBaselineClasses = interface end


  type IDialogClasses = interface end
  
  [<Erase>]
  type dialog =
    /// Styles applied to the root element.
    static member inline root(className: string) : IDialogClasses = unbox ("root", className)
    /// Styles applied to the container element if `scroll="paper"`.
    static member inline scrollPaper(className: string) : IDialogClasses = unbox ("scrollPaper", className)
    /// Styles applied to the container element if `scroll="body"`.
    static member inline scrollBody(className: string) : IDialogClasses = unbox ("scrollBody", className)
    /// Styles applied to the container element.
    static member inline container(className: string) : IDialogClasses = unbox ("container", className)
    /// Styles applied to the `Paper` component.
    static member inline paper(className: string) : IDialogClasses = unbox ("paper", className)
    /// Styles applied to the `Paper` component if `scroll="paper"`.
    static member inline paperScrollPaper(className: string) : IDialogClasses = unbox ("paperScrollPaper", className)
    /// Styles applied to the `Paper` component if `scroll="body"`.
    static member inline paperScrollBody(className: string) : IDialogClasses = unbox ("paperScrollBody", className)
    /// Styles applied to the `Paper` component if `maxWidth=false`.
    static member inline paperWidthFalse(className: string) : IDialogClasses = unbox ("paperWidthFalse", className)
    /// Styles applied to the `Paper` component if `maxWidth="xs"`.
    static member inline paperWidthXs(className: string) : IDialogClasses = unbox ("paperWidthXs", className)
    /// Styles applied to the `Paper` component if `maxWidth="sm"`.
    static member inline paperWidthSm(className: string) : IDialogClasses = unbox ("paperWidthSm", className)
    /// Styles applied to the `Paper` component if `maxWidth="md"`.
    static member inline paperWidthMd(className: string) : IDialogClasses = unbox ("paperWidthMd", className)
    /// Styles applied to the `Paper` component if `maxWidth="lg"`.
    static member inline paperWidthLg(className: string) : IDialogClasses = unbox ("paperWidthLg", className)
    /// Styles applied to the `Paper` component if `maxWidth="xl"`.
    static member inline paperWidthXl(className: string) : IDialogClasses = unbox ("paperWidthXl", className)
    /// Styles applied to the `Paper` component if `fullWidth={true}`.
    static member inline paperFullWidth(className: string) : IDialogClasses = unbox ("paperFullWidth", className)
    /// Styles applied to the `Paper` component if `fullScreen={true}`.
    static member inline paperFullScreen(className: string) : IDialogClasses = unbox ("paperFullScreen", className)


  type IDialogActionsClasses = interface end
  
  [<Erase>]
  type dialogActions =
    /// Styles applied to the root element.
    static member inline root(className: string) : IDialogActionsClasses = unbox ("root", className)
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(className: string) : IDialogActionsClasses = unbox ("spacing", className)


  type IDialogContentClasses = interface end
  
  [<Erase>]
  type dialogContent =
    /// Styles applied to the root element.
    static member inline root(className: string) : IDialogContentClasses = unbox ("root", className)
    /// Styles applied to the root element if `dividers={true}`.
    static member inline dividers(className: string) : IDialogContentClasses = unbox ("dividers", className)


  type IDialogContentTextClasses = interface end
  
  [<Erase>]
  type dialogContentText =
    /// Styles applied to the root element.
    static member inline root(className: string) : IDialogContentTextClasses = unbox ("root", className)


  type IDialogTitleClasses = interface end
  
  [<Erase>]
  type dialogTitle =
    /// Styles applied to the root element.
    static member inline root(className: string) : IDialogTitleClasses = unbox ("root", className)


  type IDividerClasses = interface end
  
  [<Erase>]
  type divider =
    /// Styles applied to the root element.
    static member inline root(className: string) : IDividerClasses = unbox ("root", className)
    /// Styles applied to the root element if `absolute={true}`.
    static member inline absolute(className: string) : IDividerClasses = unbox ("absolute", className)
    /// Styles applied to the root element if `variant="inset"`.
    static member inline inset(className: string) : IDividerClasses = unbox ("inset", className)
    /// Styles applied to the root element if `light={true}`.
    static member inline light(className: string) : IDividerClasses = unbox ("light", className)
    /// Styles applied to the root element if `variant="middle"`.
    static member inline middle(className: string) : IDividerClasses = unbox ("middle", className)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(className: string) : IDividerClasses = unbox ("vertical", className)


  type IDrawerClasses = interface end
  
  [<Erase>]
  type drawer =
    /// Styles applied to the root element.
    static member inline root(className: string) : IDrawerClasses = unbox ("root", className)
    /// Styles applied to the root element if `variant="permanent or persistent"`.
    static member inline docked(className: string) : IDrawerClasses = unbox ("docked", className)
    /// Styles applied to the `Paper` component.
    static member inline paper(className: string) : IDrawerClasses = unbox ("paper", className)
    /// Styles applied to the `Paper` component if `anchor="left"`.
    static member inline paperAnchorLeft(className: string) : IDrawerClasses = unbox ("paperAnchorLeft", className)
    /// Styles applied to the `Paper` component if `anchor="right"`.
    static member inline paperAnchorRight(className: string) : IDrawerClasses = unbox ("paperAnchorRight", className)
    /// Styles applied to the `Paper` component if `anchor="top"`.
    static member inline paperAnchorTop(className: string) : IDrawerClasses = unbox ("paperAnchorTop", className)
    /// Styles applied to the `Paper` component if `anchor="bottom"`.
    static member inline paperAnchorBottom(className: string) : IDrawerClasses = unbox ("paperAnchorBottom", className)
    /// Styles applied to the `Paper` component if `anchor="left"` and `variant` is not "temporary".
    static member inline paperAnchorDockedLeft(className: string) : IDrawerClasses = unbox ("paperAnchorDockedLeft", className)
    /// Styles applied to the `Paper` component if `anchor="top"` and `variant` is not "temporary".
    static member inline paperAnchorDockedTop(className: string) : IDrawerClasses = unbox ("paperAnchorDockedTop", className)
    /// Styles applied to the `Paper` component if `anchor="right"` and `variant` is not "temporary".
    static member inline paperAnchorDockedRight(className: string) : IDrawerClasses = unbox ("paperAnchorDockedRight", className)
    /// Styles applied to the `Paper` component if `anchor="bottom"` and `variant` is not "temporary".
    static member inline paperAnchorDockedBottom(className: string) : IDrawerClasses = unbox ("paperAnchorDockedBottom", className)
    /// Styles applied to the `Modal` component.
    static member inline modal(className: string) : IDrawerClasses = unbox ("modal", className)


  type IExpansionPanelClasses = interface end
  
  [<Erase>]
  type expansionPanel =
    /// Styles applied to the root element.
    static member inline root(className: string) : IExpansionPanelClasses = unbox ("root", className)
    /// Styles applied to the root element if `square={false}`.
    static member inline rounded(className: string) : IExpansionPanelClasses = unbox ("rounded", className)
    /// Styles applied to the root element if `expanded={true}`.
    static member inline expanded(className: string) : IExpansionPanelClasses = unbox ("expanded", className)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IExpansionPanelClasses = unbox ("disabled", className)


  type IExpansionPanelActionsClasses = interface end
  
  [<Erase>]
  type expansionPanelActions =
    /// Styles applied to the root element.
    static member inline root(className: string) : IExpansionPanelActionsClasses = unbox ("root", className)
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(className: string) : IExpansionPanelActionsClasses = unbox ("spacing", className)


  type IExpansionPanelDetailsClasses = interface end
  
  [<Erase>]
  type expansionPanelDetails =
    /// Styles applied to the root element.
    static member inline root(className: string) : IExpansionPanelDetailsClasses = unbox ("root", className)


  type IExpansionPanelSummaryClasses = interface end
  
  [<Erase>]
  type expansionPanelSummary =
    /// Styles applied to the root element.
    static member inline root(className: string) : IExpansionPanelSummaryClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
    static member inline expanded(className: string) : IExpansionPanelSummaryClasses = unbox ("expanded", className)
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(className: string) : IExpansionPanelSummaryClasses = unbox ("focused", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IExpansionPanelSummaryClasses = unbox ("disabled", className)
    /// Styles applied to the children wrapper element.
    static member inline content(className: string) : IExpansionPanelSummaryClasses = unbox ("content", className)
    /// Styles applied to the `IconButton` component when `expandIcon` is supplied.
    static member inline expandIcon(className: string) : IExpansionPanelSummaryClasses = unbox ("expandIcon", className)


  type IFabClasses = interface end
  
  [<Erase>]
  type fab =
    /// Styles applied to the root element.
    static member inline root(className: string) : IFabClasses = unbox ("root", className)
    /// Styles applied to the span element that wraps the children.
    static member inline label(className: string) : IFabClasses = unbox ("label", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline primary(className: string) : IFabClasses = unbox ("primary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline secondary(className: string) : IFabClasses = unbox ("secondary", className)
    /// Styles applied to the root element if `variant="extended"`.
    static member inline extended(className: string) : IFabClasses = unbox ("extended", className)
    /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
    static member inline focusVisible(className: string) : IFabClasses = unbox ("focusVisible", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IFabClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(className: string) : IFabClasses = unbox ("colorInherit", className)
    /// Styles applied to the root element if `size="small"``.
    static member inline sizeSmall(className: string) : IFabClasses = unbox ("sizeSmall", className)
    /// Styles applied to the root element if `size="medium"``.
    static member inline sizeMedium(className: string) : IFabClasses = unbox ("sizeMedium", className)


  type IFadeClasses = interface end


  type IFilledInputClasses = interface end
  
  [<Erase>]
  type filledInput =
    /// Styles applied to the root element.
    static member inline root(className: string) : IFilledInputClasses = unbox ("root", className)
    /// Styles applied to the root element if color secondary.
    static member inline colorSecondary(className: string) : IFilledInputClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `disableUnderline={false}`.
    static member inline underline(className: string) : IFilledInputClasses = unbox ("underline", className)
    /// Pseudo-class applied to the root element if the component is focused.
    static member inline focused(className: string) : IFilledInputClasses = unbox ("focused", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IFilledInputClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(className: string) : IFilledInputClasses = unbox ("adornedStart", className)
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(className: string) : IFilledInputClasses = unbox ("adornedEnd", className)
    /// Styles applied to the root element if `error={true}`.
    static member inline error(className: string) : IFilledInputClasses = unbox ("error", className)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(className: string) : IFilledInputClasses = unbox ("marginDense", className)
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(className: string) : IFilledInputClasses = unbox ("multiline", className)
    /// Styles applied to the `input` element.
    static member inline input(className: string) : IFilledInputClasses = unbox ("input", className)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(className: string) : IFilledInputClasses = unbox ("inputMarginDense", className)
    /// Styles applied to the `input` if in ``.
    static member inline inputHiddenLabel(className: string) : IFilledInputClasses = unbox ("inputHiddenLabel", className)
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(className: string) : IFilledInputClasses = unbox ("inputMultiline", className)
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(className: string) : IFilledInputClasses = unbox ("inputAdornedStart", className)
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(className: string) : IFilledInputClasses = unbox ("inputAdornedEnd", className)


  type IFormControlClasses = interface end
  
  [<Erase>]
  type formControl =
    /// Styles applied to the root element.
    static member inline root(className: string) : IFormControlClasses = unbox ("root", className)
    /// Styles applied to the root element if `margin="normal"`.
    static member inline marginNormal(className: string) : IFormControlClasses = unbox ("marginNormal", className)
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(className: string) : IFormControlClasses = unbox ("marginDense", className)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(className: string) : IFormControlClasses = unbox ("fullWidth", className)


  type IFormControlLabelClasses = interface end
  
  [<Erase>]
  type formControlLabel =
    /// Styles applied to the root element.
    static member inline root(className: string) : IFormControlLabelClasses = unbox ("root", className)
    /// Styles applied to the root element if `labelPlacement="start"`.
    static member inline labelPlacementStart(className: string) : IFormControlLabelClasses = unbox ("labelPlacementStart", className)
    /// Styles applied to the root element if `labelPlacement="top"`.
    static member inline labelPlacementTop(className: string) : IFormControlLabelClasses = unbox ("labelPlacementTop", className)
    /// Styles applied to the root element if `labelPlacement="bottom"`.
    static member inline labelPlacementBottom(className: string) : IFormControlLabelClasses = unbox ("labelPlacementBottom", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IFormControlLabelClasses = unbox ("disabled", className)
    /// Styles applied to the label's Typography component.
    static member inline label(className: string) : IFormControlLabelClasses = unbox ("label", className)


  type IFormGroupClasses = interface end
  
  [<Erase>]
  type formGroup =
    /// Styles applied to the root element.
    static member inline root(className: string) : IFormGroupClasses = unbox ("root", className)
    /// Styles applied to the root element if `row={true}`.
    static member inline row(className: string) : IFormGroupClasses = unbox ("row", className)


  type IFormHelperTextClasses = interface end
  
  [<Erase>]
  type formHelperText =
    /// Styles applied to the root element.
    static member inline root(className: string) : IFormHelperTextClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(className: string) : IFormHelperTextClasses = unbox ("error", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IFormHelperTextClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(className: string) : IFormHelperTextClasses = unbox ("marginDense", className)
    /// Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
    static member inline contained(className: string) : IFormHelperTextClasses = unbox ("contained", className)
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(className: string) : IFormHelperTextClasses = unbox ("focused", className)
    /// Pseudo-class applied to the root element if `filled={true}`.
    static member inline filled(className: string) : IFormHelperTextClasses = unbox ("filled", className)
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(className: string) : IFormHelperTextClasses = unbox ("required", className)


  type IFormLabelClasses = interface end
  
  [<Erase>]
  type formLabel =
    /// Styles applied to the root element.
    static member inline root(className: string) : IFormLabelClasses = unbox ("root", className)
    /// Styles applied to the root element if the color is secondary.
    static member inline colorSecondary(className: string) : IFormLabelClasses = unbox ("colorSecondary", className)
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(className: string) : IFormLabelClasses = unbox ("focused", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IFormLabelClasses = unbox ("disabled", className)
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(className: string) : IFormLabelClasses = unbox ("error", className)
    /// Pseudo-class applied to the root element if `filled={true}`.
    static member inline filled(className: string) : IFormLabelClasses = unbox ("filled", className)
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(className: string) : IFormLabelClasses = unbox ("required", className)
    /// Styles applied to the asterisk element.
    static member inline asterisk(className: string) : IFormLabelClasses = unbox ("asterisk", className)


  type IGridClasses = interface end
  
  [<Erase>]
  type grid =
    /// Styles applied to the root element
    static member inline root(className: string) : IGridClasses = unbox ("root", className)
    /// Styles applied to the root element if `container={true}`.
    static member inline container(className: string) : IGridClasses = unbox ("container", className)
    /// Styles applied to the root element if `item={true}`.
    static member inline item(className: string) : IGridClasses = unbox ("item", className)
    /// Styles applied to the root element if `zeroMinWidth={true}`.
    static member inline zeroMinWidth(className: string) : IGridClasses = unbox ("zeroMinWidth", className)
    static member inline directionXsColumn(className: string) : IGridClasses = unbox ("direction-xs-column", className)
    static member inline directionXsColumnReverse(className: string) : IGridClasses = unbox ("direction-xs-column-reverse", className)
    static member inline directionXsRowReverse(className: string) : IGridClasses = unbox ("direction-xs-row-reverse", className)
    static member inline wrapXsNowrap(className: string) : IGridClasses = unbox ("wrap-xs-nowrap", className)
    static member inline wrapXsWrapReverse(className: string) : IGridClasses = unbox ("wrap-xs-wrap-reverse", className)
    static member inline alignItemsXsCenter(className: string) : IGridClasses = unbox ("align-items-xs-center", className)
    static member inline alignItemsXsFlexStart(className: string) : IGridClasses = unbox ("align-items-xs-flex-start", className)
    static member inline alignItemsXsFlexEnd(className: string) : IGridClasses = unbox ("align-items-xs-flex-end", className)
    static member inline alignItemsXsBaseline(className: string) : IGridClasses = unbox ("align-items-xs-baseline", className)
    static member inline alignContentXsCenter(className: string) : IGridClasses = unbox ("align-content-xs-center", className)
    static member inline alignContentXsFlexStart(className: string) : IGridClasses = unbox ("align-content-xs-flex-start", className)
    static member inline alignContentXsFlexEnd(className: string) : IGridClasses = unbox ("align-content-xs-flex-end", className)
    static member inline alignContentXsSpaceBetween(className: string) : IGridClasses = unbox ("align-content-xs-space-between", className)
    static member inline alignContentXsSpaceAround(className: string) : IGridClasses = unbox ("align-content-xs-space-around", className)
    static member inline justifyXsCenter(className: string) : IGridClasses = unbox ("justify-xs-center", className)
    static member inline justifyXsFlexEnd(className: string) : IGridClasses = unbox ("justify-xs-flex-end", className)
    static member inline justifyXsSpaceBetween(className: string) : IGridClasses = unbox ("justify-xs-space-between", className)
    static member inline justifyXsSpaceAround(className: string) : IGridClasses = unbox ("justify-xs-space-around", className)
    static member inline justifyXsSpaceEvenly(className: string) : IGridClasses = unbox ("justify-xs-space-evenly", className)
    static member inline spacingXs1(className: string) : IGridClasses = unbox ("spacing-xs-1", className)
    static member inline spacingXs2(className: string) : IGridClasses = unbox ("spacing-xs-2", className)
    static member inline spacingXs3(className: string) : IGridClasses = unbox ("spacing-xs-3", className)
    static member inline spacingXs4(className: string) : IGridClasses = unbox ("spacing-xs-4", className)
    static member inline spacingXs5(className: string) : IGridClasses = unbox ("spacing-xs-5", className)
    static member inline spacingXs6(className: string) : IGridClasses = unbox ("spacing-xs-6", className)
    static member inline spacingXs7(className: string) : IGridClasses = unbox ("spacing-xs-7", className)
    static member inline spacingXs8(className: string) : IGridClasses = unbox ("spacing-xs-8", className)
    static member inline spacingXs9(className: string) : IGridClasses = unbox ("spacing-xs-9", className)
    static member inline spacingXs10(className: string) : IGridClasses = unbox ("spacing-xs-10", className)
    static member inline gridXsAuto(className: string) : IGridClasses = unbox ("grid-xs-auto", className)
    static member inline gridXsTrue(className: string) : IGridClasses = unbox ("grid-xs-true", className)
    static member inline gridXs1(className: string) : IGridClasses = unbox ("grid-xs-1", className)
    static member inline gridXs2(className: string) : IGridClasses = unbox ("grid-xs-2", className)
    static member inline gridXs3(className: string) : IGridClasses = unbox ("grid-xs-3", className)
    static member inline gridXs4(className: string) : IGridClasses = unbox ("grid-xs-4", className)
    static member inline gridXs5(className: string) : IGridClasses = unbox ("grid-xs-5", className)
    static member inline gridXs6(className: string) : IGridClasses = unbox ("grid-xs-6", className)
    static member inline gridXs7(className: string) : IGridClasses = unbox ("grid-xs-7", className)
    static member inline gridXs8(className: string) : IGridClasses = unbox ("grid-xs-8", className)
    static member inline gridXs9(className: string) : IGridClasses = unbox ("grid-xs-9", className)
    static member inline gridXs10(className: string) : IGridClasses = unbox ("grid-xs-10", className)
    static member inline gridXs11(className: string) : IGridClasses = unbox ("grid-xs-11", className)
    static member inline gridXs12(className: string) : IGridClasses = unbox ("grid-xs-12", className)


  type IGridListClasses = interface end
  
  [<Erase>]
  type gridList =
    /// Styles applied to the root element.
    static member inline root(className: string) : IGridListClasses = unbox ("root", className)


  type IGridListTileClasses = interface end
  
  [<Erase>]
  type gridListTile =
    /// Styles applied to the root element.
    static member inline root(className: string) : IGridListTileClasses = unbox ("root", className)
    /// Styles applied to the `div` element that wraps the children.
    static member inline tile(className: string) : IGridListTileClasses = unbox ("tile", className)
    /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
    static member inline imgFullHeight(className: string) : IGridListTileClasses = unbox ("imgFullHeight", className)
    /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
    static member inline imgFullWidth(className: string) : IGridListTileClasses = unbox ("imgFullWidth", className)


  type IGridListTileBarClasses = interface end
  
  [<Erase>]
  type gridListTileBar =
    /// Styles applied to the root element.
    static member inline root(className: string) : IGridListTileBarClasses = unbox ("root", className)
    /// Styles applied to the root element if `titlePosition="bottom"`.
    static member inline titlePositionBottom(className: string) : IGridListTileBarClasses = unbox ("titlePositionBottom", className)
    /// Styles applied to the root element if `titlePosition="top"`.
    static member inline titlePositionTop(className: string) : IGridListTileBarClasses = unbox ("titlePositionTop", className)
    /// Styles applied to the root element if a `subtitle` is provided.
    static member inline rootSubtitle(className: string) : IGridListTileBarClasses = unbox ("rootSubtitle", className)
    /// Styles applied to the title and subtitle container element.
    static member inline titleWrap(className: string) : IGridListTileBarClasses = unbox ("titleWrap", className)
    /// Styles applied to the container element if `actionPosition="left"`.
    static member inline titleWrapActionPosLeft(className: string) : IGridListTileBarClasses = unbox ("titleWrapActionPosLeft", className)
    /// Styles applied to the container element if `actionPosition="right"`.
    static member inline titleWrapActionPosRight(className: string) : IGridListTileBarClasses = unbox ("titleWrapActionPosRight", className)
    /// Styles applied to the title container element.
    static member inline title(className: string) : IGridListTileBarClasses = unbox ("title", className)
    /// Styles applied to the subtitle container element.
    static member inline subtitle(className: string) : IGridListTileBarClasses = unbox ("subtitle", className)
    /// Styles applied to the actionIcon if supplied.
    static member inline actionIcon(className: string) : IGridListTileBarClasses = unbox ("actionIcon", className)
    /// Styles applied to the actionIcon if `actionPosition="left"`.
    static member inline actionIconActionPosLeft(className: string) : IGridListTileBarClasses = unbox ("actionIconActionPosLeft", className)


  type IGrowClasses = interface end


  type IHiddenClasses = interface end


  type IIconClasses = interface end
  
  [<Erase>]
  type icon =
    /// Styles applied to the root element.
    static member inline root(className: string) : IIconClasses = unbox ("root", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : IIconClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : IIconClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `color="action"`.
    static member inline colorAction(className: string) : IIconClasses = unbox ("colorAction", className)
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(className: string) : IIconClasses = unbox ("colorError", className)
    /// Styles applied to the root element if `color="disabled"`.
    static member inline colorDisabled(className: string) : IIconClasses = unbox ("colorDisabled", className)
    static member inline fontSizeInherit(className: string) : IIconClasses = unbox ("fontSizeInherit", className)
    /// Styles applied to the root element if `fontSize="small"`.
    static member inline fontSizeSmall(className: string) : IIconClasses = unbox ("fontSizeSmall", className)
    /// Styles applied to the root element if `fontSize="large"`.
    static member inline fontSizeLarge(className: string) : IIconClasses = unbox ("fontSizeLarge", className)


  type IIconButtonClasses = interface end
  
  [<Erase>]
  type iconButton =
    /// Styles applied to the root element.
    static member inline root(className: string) : IIconButtonClasses = unbox ("root", className)
    /// Styles applied to the root element if `edge="start"`.
    static member inline edgeStart(className: string) : IIconButtonClasses = unbox ("edgeStart", className)
    /// Styles applied to the root element if `edge="end"`.
    static member inline edgeEnd(className: string) : IIconButtonClasses = unbox ("edgeEnd", className)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(className: string) : IIconButtonClasses = unbox ("colorInherit", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : IIconButtonClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : IIconButtonClasses = unbox ("colorSecondary", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IIconButtonClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(className: string) : IIconButtonClasses = unbox ("sizeSmall", className)
    /// Styles applied to the children container element.
    static member inline label(className: string) : IIconButtonClasses = unbox ("label", className)


  type IInputClasses = interface end
  
  [<Erase>]
  type input =
    /// Styles applied to the root element.
    static member inline root(className: string) : IInputClasses = unbox ("root", className)
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(className: string) : IInputClasses = unbox ("formControl", className)
    /// Styles applied to the root element if the component is focused.
    static member inline focused(className: string) : IInputClasses = unbox ("focused", className)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IInputClasses = unbox ("disabled", className)
    /// Styles applied to the root element if color secondary.
    static member inline colorSecondary(className: string) : IInputClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `disableUnderline={false}`.
    static member inline underline(className: string) : IInputClasses = unbox ("underline", className)
    /// Styles applied to the root element if `error={true}`.
    static member inline error(className: string) : IInputClasses = unbox ("error", className)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(className: string) : IInputClasses = unbox ("marginDense", className)
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(className: string) : IInputClasses = unbox ("multiline", className)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(className: string) : IInputClasses = unbox ("fullWidth", className)
    /// Styles applied to the `input` element.
    static member inline input(className: string) : IInputClasses = unbox ("input", className)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(className: string) : IInputClasses = unbox ("inputMarginDense", className)
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(className: string) : IInputClasses = unbox ("inputMultiline", className)
    /// Styles applied to the `input` element if `type="search"`.
    static member inline inputTypeSearch(className: string) : IInputClasses = unbox ("inputTypeSearch", className)


  type IInputAdornmentClasses = interface end
  
  [<Erase>]
  type inputAdornment =
    /// Styles applied to the root element.
    static member inline root(className: string) : IInputAdornmentClasses = unbox ("root", className)
    /// Styles applied to the root element if `variant="filled"`.
    static member inline filled(className: string) : IInputAdornmentClasses = unbox ("filled", className)
    /// Styles applied to the root element if `position="start"`.
    static member inline positionStart(className: string) : IInputAdornmentClasses = unbox ("positionStart", className)
    /// Styles applied to the root element if `position="end"`.
    static member inline positionEnd(className: string) : IInputAdornmentClasses = unbox ("positionEnd", className)
    /// Styles applied to the root element if `disablePointerEvents=true`.
    static member inline disablePointerEvents(className: string) : IInputAdornmentClasses = unbox ("disablePointerEvents", className)
    /// Styles applied if the adornment is used inside <formcontrol hiddenlabel=""></formcontrol>.
    static member inline hiddenLabel(className: string) : IInputAdornmentClasses = unbox ("hiddenLabel", className)
    /// Styles applied if the adornment is used inside <formcontrol margin="dense"></formcontrol>.
    static member inline marginDense(className: string) : IInputAdornmentClasses = unbox ("marginDense", className)


  type IInputBaseClasses = interface end
  
  [<Erase>]
  type inputBase =
    /// Styles applied to the root element.
    static member inline root(className: string) : IInputBaseClasses = unbox ("root", className)
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(className: string) : IInputBaseClasses = unbox ("formControl", className)
    /// Styles applied to the root element if the component is focused.
    static member inline focused(className: string) : IInputBaseClasses = unbox ("focused", className)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IInputBaseClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(className: string) : IInputBaseClasses = unbox ("adornedStart", className)
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(className: string) : IInputBaseClasses = unbox ("adornedEnd", className)
    /// Styles applied to the root element if `error={true}`.
    static member inline error(className: string) : IInputBaseClasses = unbox ("error", className)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(className: string) : IInputBaseClasses = unbox ("marginDense", className)
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(className: string) : IInputBaseClasses = unbox ("multiline", className)
    /// Styles applied to the root element if the color is secondary.
    static member inline colorSecondary(className: string) : IInputBaseClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(className: string) : IInputBaseClasses = unbox ("fullWidth", className)
    /// Styles applied to the `input` element.
    static member inline input(className: string) : IInputBaseClasses = unbox ("input", className)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(className: string) : IInputBaseClasses = unbox ("inputMarginDense", className)
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(className: string) : IInputBaseClasses = unbox ("inputMultiline", className)
    /// Styles applied to the `input` element if `type="search"`.
    static member inline inputTypeSearch(className: string) : IInputBaseClasses = unbox ("inputTypeSearch", className)
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(className: string) : IInputBaseClasses = unbox ("inputAdornedStart", className)
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(className: string) : IInputBaseClasses = unbox ("inputAdornedEnd", className)
    /// Styles applied to the `input` element if `hiddenLabel={true}`.
    static member inline inputHiddenLabel(className: string) : IInputBaseClasses = unbox ("inputHiddenLabel", className)


  type IInputLabelClasses = interface end
  
  [<Erase>]
  type inputLabel =
    /// Styles applied to the root element.
    static member inline root(className: string) : IInputLabelClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(className: string) : IInputLabelClasses = unbox ("focused", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IInputLabelClasses = unbox ("disabled", className)
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(className: string) : IInputLabelClasses = unbox ("error", className)
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(className: string) : IInputLabelClasses = unbox ("required", className)
    /// Pseudo-class applied to the asterisk element.
    static member inline asterisk(className: string) : IInputLabelClasses = unbox ("asterisk", className)
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(className: string) : IInputLabelClasses = unbox ("formControl", className)
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(className: string) : IInputLabelClasses = unbox ("marginDense", className)
    /// Styles applied to the `input` element if `shrink={true}`.
    static member inline shrink(className: string) : IInputLabelClasses = unbox ("shrink", className)
    /// Styles applied to the `input` element if `disableAnimation={false}`.
    static member inline animated(className: string) : IInputLabelClasses = unbox ("animated", className)
    /// Styles applied to the root element if `variant="filled"`.
    static member inline filled(className: string) : IInputLabelClasses = unbox ("filled", className)
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(className: string) : IInputLabelClasses = unbox ("outlined", className)


  type ILinearProgressClasses = interface end
  
  [<Erase>]
  type linearProgress =
    /// Styles applied to the root element.
    static member inline root(className: string) : ILinearProgressClasses = unbox ("root", className)
    /// Styles applied to the root and bar2 element if `color="primary"`; bar2 if `variant-"buffer"`.
    static member inline colorPrimary(className: string) : ILinearProgressClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root and bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
    static member inline colorSecondary(className: string) : ILinearProgressClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `variant="determinate"`.
    static member inline determinate(className: string) : ILinearProgressClasses = unbox ("determinate", className)
    /// Styles applied to the root element if `variant="indeterminate"`.
    static member inline indeterminate(className: string) : ILinearProgressClasses = unbox ("indeterminate", className)
    /// Styles applied to the root element if `variant="buffer"`.
    static member inline buffer(className: string) : ILinearProgressClasses = unbox ("buffer", className)
    /// Styles applied to the root element if `variant="query"`.
    static member inline query(className: string) : ILinearProgressClasses = unbox ("query", className)
    /// Styles applied to the additional bar element if `variant="buffer"`.
    static member inline dashed(className: string) : ILinearProgressClasses = unbox ("dashed", className)
    /// Styles applied to the additional bar element if `variant="buffer"` and `color="primary"`.
    static member inline dashedColorPrimary(className: string) : ILinearProgressClasses = unbox ("dashedColorPrimary", className)
    /// Styles applied to the additional bar element if `variant="buffer"` and `color="secondary"`.
    static member inline dashedColorSecondary(className: string) : ILinearProgressClasses = unbox ("dashedColorSecondary", className)
    /// Styles applied to the layered bar1 and bar2 elements.
    static member inline bar(className: string) : ILinearProgressClasses = unbox ("bar", className)
    /// Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
    static member inline barColorPrimary(className: string) : ILinearProgressClasses = unbox ("barColorPrimary", className)
    /// Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
    static member inline barColorSecondary(className: string) : ILinearProgressClasses = unbox ("barColorSecondary", className)
    /// Styles applied to the bar1 element if `variant="indeterminate or query"`.
    static member inline bar1Indeterminate(className: string) : ILinearProgressClasses = unbox ("bar1Indeterminate", className)
    /// Styles applied to the bar1 element if `variant="determinate"`.
    static member inline bar1Determinate(className: string) : ILinearProgressClasses = unbox ("bar1Determinate", className)
    /// Styles applied to the bar1 element if `variant="buffer"`.
    static member inline bar1Buffer(className: string) : ILinearProgressClasses = unbox ("bar1Buffer", className)
    /// Styles applied to the bar2 element if `variant="indeterminate or query"`.
    static member inline bar2Indeterminate(className: string) : ILinearProgressClasses = unbox ("bar2Indeterminate", className)
    /// Styles applied to the bar2 element if `variant="buffer"`.
    static member inline bar2Buffer(className: string) : ILinearProgressClasses = unbox ("bar2Buffer", className)


  type ILinkClasses = interface end
  
  [<Erase>]
  type link =
    /// Styles applied to the root element.
    static member inline root(className: string) : ILinkClasses = unbox ("root", className)
    /// Styles applied to the root element if `underline="none"`.
    static member inline underlineNone(className: string) : ILinkClasses = unbox ("underlineNone", className)
    /// Styles applied to the root element if `underline="hover"`.
    static member inline underlineHover(className: string) : ILinkClasses = unbox ("underlineHover", className)
    /// Styles applied to the root element if `underline="always"`.
    static member inline underlineAlways(className: string) : ILinkClasses = unbox ("underlineAlways", className)
    /// Styles applied to the root element if `component="button"`.
    static member inline button(className: string) : ILinkClasses = unbox ("button", className)
    /// Pseudo-class applied to the root element if the link is keyboard focused.
    static member inline focusVisible(className: string) : ILinkClasses = unbox ("focusVisible", className)


  type IListClasses = interface end
  
  [<Erase>]
  type list =
    /// Styles applied to the root element.
    static member inline root(className: string) : IListClasses = unbox ("root", className)
    /// Styles applied to the root element if `disablePadding={false}`.
    static member inline padding(className: string) : IListClasses = unbox ("padding", className)
    /// Styles applied to the root element if dense.
    static member inline dense(className: string) : IListClasses = unbox ("dense", className)
    /// Styles applied to the root element if a `subheader` is provided.
    static member inline subheader(className: string) : IListClasses = unbox ("subheader", className)


  type IListItemClasses = interface end
  
  [<Erase>]
  type listItem =
    /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
    static member inline root(className: string) : IListItemClasses = unbox ("root", className)
    /// Styles applied to the `container` element if `children` includes `ListItemSecondaryAction`.
    static member inline container(className: string) : IListItemClasses = unbox ("container", className)
    /// Pseudo-class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
    static member inline focusVisible(className: string) : IListItemClasses = unbox ("focusVisible", className)
    /// Styles applied to the `component` element if dense.
    static member inline dense(className: string) : IListItemClasses = unbox ("dense", className)
    /// Styles applied to the `component` element if `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(className: string) : IListItemClasses = unbox ("alignItemsFlexStart", className)
    /// Pseudo-class applied to the inner `component` element if `disabled={true}`.
    static member inline disabled(className: string) : IListItemClasses = unbox ("disabled", className)
    /// Styles applied to the inner `component` element if `divider={true}`.
    static member inline divider(className: string) : IListItemClasses = unbox ("divider", className)
    /// Styles applied to the inner `component` element if `disableGutters={false}`.
    static member inline gutters(className: string) : IListItemClasses = unbox ("gutters", className)
    /// Styles applied to the inner `component` element if `button={true}`.
    static member inline button(className: string) : IListItemClasses = unbox ("button", className)
    /// Styles applied to the `component` element if `children` includes `ListItemSecondaryAction`.
    static member inline secondaryAction(className: string) : IListItemClasses = unbox ("secondaryAction", className)
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(className: string) : IListItemClasses = unbox ("selected", className)


  type IListItemAvatarClasses = interface end
  
  [<Erase>]
  type listItemAvatar =
    /// Styles applied to the root element.
    static member inline root(className: string) : IListItemAvatarClasses = unbox ("root", className)
    /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(className: string) : IListItemAvatarClasses = unbox ("alignItemsFlexStart", className)


  type IListItemIconClasses = interface end
  
  [<Erase>]
  type listItemIcon =
    /// Styles applied to the root element.
    static member inline root(className: string) : IListItemIconClasses = unbox ("root", className)
    /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(className: string) : IListItemIconClasses = unbox ("alignItemsFlexStart", className)


  type IListItemSecondaryActionClasses = interface end
  
  [<Erase>]
  type listItemSecondaryAction =
    /// Styles applied to the root element.
    static member inline root(className: string) : IListItemSecondaryActionClasses = unbox ("root", className)


  type IListItemTextClasses = interface end
  
  [<Erase>]
  type listItemText =
    /// Styles applied to the root element.
    static member inline root(className: string) : IListItemTextClasses = unbox ("root", className)
    /// Styles applied to the `Typography` components if primary and secondary are set.
    static member inline multiline(className: string) : IListItemTextClasses = unbox ("multiline", className)
    /// Styles applied to the `Typography` components if dense.
    static member inline dense(className: string) : IListItemTextClasses = unbox ("dense", className)
    /// Styles applied to the root element if `inset={true}`.
    static member inline inset(className: string) : IListItemTextClasses = unbox ("inset", className)
    /// Styles applied to the primary `Typography` component.
    static member inline primary(className: string) : IListItemTextClasses = unbox ("primary", className)
    /// Styles applied to the secondary `Typography` component.
    static member inline secondary(className: string) : IListItemTextClasses = unbox ("secondary", className)


  type IListSubheaderClasses = interface end
  
  [<Erase>]
  type listSubheader =
    /// Styles applied to the root element.
    static member inline root(className: string) : IListSubheaderClasses = unbox ("root", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : IListSubheaderClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(className: string) : IListSubheaderClasses = unbox ("colorInherit", className)
    /// Styles applied to the inner `component` element if `disableGutters={false}`.
    static member inline gutters(className: string) : IListSubheaderClasses = unbox ("gutters", className)
    /// Styles applied to the root element if `inset={true}`.
    static member inline inset(className: string) : IListSubheaderClasses = unbox ("inset", className)
    /// Styles applied to the root element if `disableSticky={false}`.
    static member inline sticky(className: string) : IListSubheaderClasses = unbox ("sticky", className)


  type IMenuClasses = interface end
  
  [<Erase>]
  type menu =
    /// Styles applied to the `Paper` component.
    static member inline paper(className: string) : IMenuClasses = unbox ("paper", className)
    /// Styles applied to the `List` component via `MenuList`.
    static member inline list(className: string) : IMenuClasses = unbox ("list", className)


  type IMenuItemClasses = interface end
  
  [<Erase>]
  type menuItem =
    /// Styles applied to the root element.
    static member inline root(className: string) : IMenuItemClasses = unbox ("root", className)
    /// Styles applied to the root element if `disableGutters={false}`.
    static member inline gutters(className: string) : IMenuItemClasses = unbox ("gutters", className)
    /// Styles applied to the root element if `selected={true}`.
    static member inline selected(className: string) : IMenuItemClasses = unbox ("selected", className)
    /// Styles applied to the root element if dense.
    static member inline dense(className: string) : IMenuItemClasses = unbox ("dense", className)


  type IMenuListClasses = interface end


  type IMobileStepperClasses = interface end
  
  [<Erase>]
  type mobileStepper =
    /// Styles applied to the root element.
    static member inline root(className: string) : IMobileStepperClasses = unbox ("root", className)
    /// Styles applied to the root element if `position="bottom"`.
    static member inline positionBottom(className: string) : IMobileStepperClasses = unbox ("positionBottom", className)
    /// Styles applied to the root element if `position="top"`.
    static member inline positionTop(className: string) : IMobileStepperClasses = unbox ("positionTop", className)
    /// Styles applied to the root element if `position="static"`.
    static member inline positionStatic(className: string) : IMobileStepperClasses = unbox ("positionStatic", className)
    /// Styles applied to the dots container if `variant="dots"`.
    static member inline dots(className: string) : IMobileStepperClasses = unbox ("dots", className)
    /// Styles applied to each dot if `variant="dots"`.
    static member inline dot(className: string) : IMobileStepperClasses = unbox ("dot", className)
    /// Styles applied to a dot if `variant="dots"` and this is the active step.
    static member inline dotActive(className: string) : IMobileStepperClasses = unbox ("dotActive", className)
    /// Styles applied to the Linear Progress component if `variant="progress"`.
    static member inline progress(className: string) : IMobileStepperClasses = unbox ("progress", className)


  type IModalClasses = interface end


  type INativeSelectClasses = interface end
  
  [<Erase>]
  type nativeSelect =
    /// Styles applied to the select component `root` class.
    static member inline root(className: string) : INativeSelectClasses = unbox ("root", className)
    /// Styles applied to the select component `select` class.
    static member inline select(className: string) : INativeSelectClasses = unbox ("select", className)
    /// Styles applied to the select component if `variant="filled"`.
    static member inline filled(className: string) : INativeSelectClasses = unbox ("filled", className)
    /// Styles applied to the select component if `variant="outlined"`.
    static member inline outlined(className: string) : INativeSelectClasses = unbox ("outlined", className)
    /// Styles applied to the select component `selectMenu` class.
    static member inline selectMenu(className: string) : INativeSelectClasses = unbox ("selectMenu", className)
    /// Pseudo-class applied to the select component `disabled` class.
    static member inline disabled(className: string) : INativeSelectClasses = unbox ("disabled", className)
    /// Styles applied to the icon component.
    static member inline icon(className: string) : INativeSelectClasses = unbox ("icon", className)
    /// Styles applied to the icon component if the popup is open.
    static member inline iconOpen(className: string) : INativeSelectClasses = unbox ("iconOpen", className)
    /// Styles applied to the icon component if `variant="filled"`.
    static member inline iconFilled(className: string) : INativeSelectClasses = unbox ("iconFilled", className)
    /// Styles applied to the icon component if `variant="outlined"`.
    static member inline iconOutlined(className: string) : INativeSelectClasses = unbox ("iconOutlined", className)


  type INoSsrClasses = interface end


  type IOutlinedInputClasses = interface end
  
  [<Erase>]
  type outlinedInput =
    /// Styles applied to the root element.
    static member inline root(className: string) : IOutlinedInputClasses = unbox ("root", className)
    /// Styles applied to the root element if the color is secondary.
    static member inline colorSecondary(className: string) : IOutlinedInputClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if the component is focused.
    static member inline focused(className: string) : IOutlinedInputClasses = unbox ("focused", className)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IOutlinedInputClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(className: string) : IOutlinedInputClasses = unbox ("adornedStart", className)
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(className: string) : IOutlinedInputClasses = unbox ("adornedEnd", className)
    /// Styles applied to the root element if `error={true}`.
    static member inline error(className: string) : IOutlinedInputClasses = unbox ("error", className)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(className: string) : IOutlinedInputClasses = unbox ("marginDense", className)
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(className: string) : IOutlinedInputClasses = unbox ("multiline", className)
    /// Styles applied to the `NotchedOutline` element.
    static member inline notchedOutline(className: string) : IOutlinedInputClasses = unbox ("notchedOutline", className)
    /// Styles applied to the `input` element.
    static member inline input(className: string) : IOutlinedInputClasses = unbox ("input", className)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(className: string) : IOutlinedInputClasses = unbox ("inputMarginDense", className)
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(className: string) : IOutlinedInputClasses = unbox ("inputMultiline", className)
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(className: string) : IOutlinedInputClasses = unbox ("inputAdornedStart", className)
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(className: string) : IOutlinedInputClasses = unbox ("inputAdornedEnd", className)


  type IPaperClasses = interface end
  
  [<Erase>]
  type paper =
    /// Styles applied to the root element.
    static member inline root(className: string) : IPaperClasses = unbox ("root", className)
    /// Styles applied to the root element if `square={false}`.
    static member inline rounded(className: string) : IPaperClasses = unbox ("rounded", className)
    static member inline elevation0(className: string) : IPaperClasses = unbox ("elevation0", className)
    static member inline elevation1(className: string) : IPaperClasses = unbox ("elevation1", className)
    static member inline elevation2(className: string) : IPaperClasses = unbox ("elevation2", className)
    static member inline elevation3(className: string) : IPaperClasses = unbox ("elevation3", className)
    static member inline elevation4(className: string) : IPaperClasses = unbox ("elevation4", className)
    static member inline elevation5(className: string) : IPaperClasses = unbox ("elevation5", className)
    static member inline elevation6(className: string) : IPaperClasses = unbox ("elevation6", className)
    static member inline elevation7(className: string) : IPaperClasses = unbox ("elevation7", className)
    static member inline elevation8(className: string) : IPaperClasses = unbox ("elevation8", className)
    static member inline elevation9(className: string) : IPaperClasses = unbox ("elevation9", className)
    static member inline elevation10(className: string) : IPaperClasses = unbox ("elevation10", className)
    static member inline elevation11(className: string) : IPaperClasses = unbox ("elevation11", className)
    static member inline elevation12(className: string) : IPaperClasses = unbox ("elevation12", className)
    static member inline elevation13(className: string) : IPaperClasses = unbox ("elevation13", className)
    static member inline elevation14(className: string) : IPaperClasses = unbox ("elevation14", className)
    static member inline elevation15(className: string) : IPaperClasses = unbox ("elevation15", className)
    static member inline elevation16(className: string) : IPaperClasses = unbox ("elevation16", className)
    static member inline elevation17(className: string) : IPaperClasses = unbox ("elevation17", className)
    static member inline elevation18(className: string) : IPaperClasses = unbox ("elevation18", className)
    static member inline elevation19(className: string) : IPaperClasses = unbox ("elevation19", className)
    static member inline elevation20(className: string) : IPaperClasses = unbox ("elevation20", className)
    static member inline elevation21(className: string) : IPaperClasses = unbox ("elevation21", className)
    static member inline elevation22(className: string) : IPaperClasses = unbox ("elevation22", className)
    static member inline elevation23(className: string) : IPaperClasses = unbox ("elevation23", className)
    static member inline elevation24(className: string) : IPaperClasses = unbox ("elevation24", className)


  type IPopoverClasses = interface end
  
  [<Erase>]
  type popover =
    /// Styles applied to the root element
    static member inline root(className: string) : IPopoverClasses = unbox ("root", className)
    /// Styles applied to the `Paper` component.
    static member inline paper(className: string) : IPopoverClasses = unbox ("paper", className)


  type IPopperClasses = interface end


  type IPortalClasses = interface end


  type IRadioClasses = interface end
  
  [<Erase>]
  type radio =
    /// Styles applied to the root element.
    static member inline root(className: string) : IRadioClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if `checked={true}`.
    static member inline checked'(className: string) : IRadioClasses = unbox ("checked", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IRadioClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : IRadioClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : IRadioClasses = unbox ("colorSecondary", className)


  type IRadioGroupClasses = interface end


  type IRatingClasses = interface end
  
  [<Erase>]
  type rating =
    /// Styles applied to the root element.
    static member inline root(className: string) : IRatingClasses = unbox ("root", className)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(className: string) : IRatingClasses = unbox ("sizeSmall", className)
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(className: string) : IRatingClasses = unbox ("sizeLarge", className)
    /// Styles applied to the root element if `readOnly={true}`.
    static member inline readOnly(className: string) : IRatingClasses = unbox ("readOnly", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IRatingClasses = unbox ("disabled", className)
    /// Pseudo-class applied to the root element if keyboard focused.
    static member inline focusVisible(className: string) : IRatingClasses = unbox ("focusVisible", className)
    /// Visually hide an element.
    static member inline visuallyhidden(className: string) : IRatingClasses = unbox ("visuallyhidden", className)
    /// Styles applied to the pristine label.
    static member inline pristine(className: string) : IRatingClasses = unbox ("pristine", className)
    /// Styles applied to the label elements.
    static member inline label(className: string) : IRatingClasses = unbox ("label", className)
    /// Styles applied to the icon wrapping elements.
    static member inline icon(className: string) : IRatingClasses = unbox ("icon", className)
    /// Styles applied to the icon wrapping elements when empty.
    static member inline iconEmpty(className: string) : IRatingClasses = unbox ("iconEmpty", className)
    /// Styles applied to the icon wrapping elements when filled.
    static member inline iconFilled(className: string) : IRatingClasses = unbox ("iconFilled", className)
    /// Styles applied to the icon wrapping elements when hover.
    static member inline iconHover(className: string) : IRatingClasses = unbox ("iconHover", className)
    /// Styles applied to the icon wrapping elements when focus.
    static member inline iconFocus(className: string) : IRatingClasses = unbox ("iconFocus", className)
    /// Styles applied to the icon wrapping elements when active.
    static member inline iconActive(className: string) : IRatingClasses = unbox ("iconActive", className)
    /// Styles applied to the icon wrapping elements when decimals are necessary.
    static member inline decimal(className: string) : IRatingClasses = unbox ("decimal", className)


  type IRootRefClasses = interface end


  type ISelectClasses = interface end
  
  [<Erase>]
  type select =
    /// Styles applied to the select component `root` class.
    static member inline root(className: string) : ISelectClasses = unbox ("root", className)
    /// Styles applied to the select component `select` class.
    static member inline select(className: string) : ISelectClasses = unbox ("select", className)
    /// Styles applied to the select component if `variant="filled"`.
    static member inline filled(className: string) : ISelectClasses = unbox ("filled", className)
    /// Styles applied to the select component if `variant="outlined"`.
    static member inline outlined(className: string) : ISelectClasses = unbox ("outlined", className)
    /// Styles applied to the select component `selectMenu` class.
    static member inline selectMenu(className: string) : ISelectClasses = unbox ("selectMenu", className)
    /// Pseudo-class applied to the select component `disabled` class.
    static member inline disabled(className: string) : ISelectClasses = unbox ("disabled", className)
    /// Styles applied to the icon component.
    static member inline icon(className: string) : ISelectClasses = unbox ("icon", className)
    /// Styles applied to the icon component if the popup is open.
    static member inline iconOpen(className: string) : ISelectClasses = unbox ("iconOpen", className)
    /// Styles applied to the icon component if `variant="filled"`.
    static member inline iconFilled(className: string) : ISelectClasses = unbox ("iconFilled", className)
    /// Styles applied to the icon component if `variant="outlined"`.
    static member inline iconOutlined(className: string) : ISelectClasses = unbox ("iconOutlined", className)


  type ISkeletonClasses = interface end
  
  [<Erase>]
  type skeleton =
    /// Styles applied to the root element.
    static member inline root(className: string) : ISkeletonClasses = unbox ("root", className)
    /// Styles applied to the root element if `variant="text"`.
    static member inline text(className: string) : ISkeletonClasses = unbox ("text", className)
    /// Styles applied to the root element if `variant="rect"`.
    static member inline rect(className: string) : ISkeletonClasses = unbox ("rect", className)
    /// Styles applied to the root element if `variant="circle"`.
    static member inline circle(className: string) : ISkeletonClasses = unbox ("circle", className)
    /// Styles applied to the root element if `disabledAnimate={false}`.
    static member inline animate(className: string) : ISkeletonClasses = unbox ("animate", className)


  type ISlideClasses = interface end


  type ISliderClasses = interface end
  
  [<Erase>]
  type slider =
    /// Styles applied to the root element.
    static member inline root(className: string) : ISliderClasses = unbox ("root", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : ISliderClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : ISliderClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `marks` is provided with at least one label.
    static member inline marked(className: string) : ISliderClasses = unbox ("marked", className)
    /// Pseudo-class applied to the root element if `orientation="vertical"`.
    static member inline vertical(className: string) : ISliderClasses = unbox ("vertical", className)
    /// Pseudo-class applied to the root and thumb element if `disabled={true}`.
    static member inline disabled(className: string) : ISliderClasses = unbox ("disabled", className)
    /// Styles applied to the rail element.
    static member inline rail(className: string) : ISliderClasses = unbox ("rail", className)
    /// Styles applied to the track element.
    static member inline track(className: string) : ISliderClasses = unbox ("track", className)
    /// Styles applied to the track element if `track={false}`.
    static member inline trackFalse(className: string) : ISliderClasses = unbox ("trackFalse", className)
    /// Styles applied to the track element if `track="inverted"`.
    static member inline trackInverted(className: string) : ISliderClasses = unbox ("trackInverted", className)
    /// Styles applied to the thumb element.
    static member inline thumb(className: string) : ISliderClasses = unbox ("thumb", className)
    /// Styles applied to the thumb element if `color="primary"`.
    static member inline thumbColorPrimary(className: string) : ISliderClasses = unbox ("thumbColorPrimary", className)
    /// Styles applied to the thumb element if `color="secondary"`.
    static member inline thumbColorSecondary(className: string) : ISliderClasses = unbox ("thumbColorSecondary", className)
    /// Pseudo-class applied to the thumb element if it's active.
    static member inline active(className: string) : ISliderClasses = unbox ("active", className)
    /// Pseudo-class applied to the thumb element if keyboard focused.
    static member inline focusVisible(className: string) : ISliderClasses = unbox ("focusVisible", className)
    /// Styles applied to the thumb label element.
    static member inline valueLabel(className: string) : ISliderClasses = unbox ("valueLabel", className)
    /// Styles applied to the mark element.
    static member inline mark(className: string) : ISliderClasses = unbox ("mark", className)
    /// Styles applied to the mark element if active (depending on the value).
    static member inline markActive(className: string) : ISliderClasses = unbox ("markActive", className)
    /// Styles applied to the mark label element.
    static member inline markLabel(className: string) : ISliderClasses = unbox ("markLabel", className)
    /// Styles applied to the mark label element if active (depending on the value).
    static member inline markLabelActive(className: string) : ISliderClasses = unbox ("markLabelActive", className)


  type ISnackbarClasses = interface end
  
  [<Erase>]
  type snackbar =
    /// Styles applied to the root element.
    static member inline root(className: string) : ISnackbarClasses = unbox ("root", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'center' }}`.
    static member inline anchorOriginTopCenter(className: string) : ISnackbarClasses = unbox ("anchorOriginTopCenter", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'center' }}`.
    static member inline anchorOriginBottomCenter(className: string) : ISnackbarClasses = unbox ("anchorOriginBottomCenter", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }}`.
    static member inline anchorOriginTopRight(className: string) : ISnackbarClasses = unbox ("anchorOriginTopRight", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }}`.
    static member inline anchorOriginBottomRight(className: string) : ISnackbarClasses = unbox ("anchorOriginBottomRight", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }}`.
    static member inline anchorOriginTopLeft(className: string) : ISnackbarClasses = unbox ("anchorOriginTopLeft", className)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }}`.
    static member inline anchorOriginBottomLeft(className: string) : ISnackbarClasses = unbox ("anchorOriginBottomLeft", className)


  type ISnackbarContentClasses = interface end
  
  [<Erase>]
  type snackbarContent =
    /// Styles applied to the root element.
    static member inline root(className: string) : ISnackbarContentClasses = unbox ("root", className)
    /// Styles applied to the message wrapper element.
    static member inline message(className: string) : ISnackbarContentClasses = unbox ("message", className)
    /// Styles applied to the action wrapper element if `action` is provided.
    static member inline action(className: string) : ISnackbarContentClasses = unbox ("action", className)


  type ISpeedDialClasses = interface end
  
  [<Erase>]
  type speedDial =
    /// Styles applied to the root element.
    static member inline root(className: string) : ISpeedDialClasses = unbox ("root", className)
    /// Styles applied to the Fab component.
    static member inline fab(className: string) : ISpeedDialClasses = unbox ("fab", className)
    /// Styles applied to the root if direction="up"
    static member inline directionUp(className: string) : ISpeedDialClasses = unbox ("directionUp", className)
    /// Styles applied to the root if direction="down"
    static member inline directionDown(className: string) : ISpeedDialClasses = unbox ("directionDown", className)
    /// Styles applied to the root if direction="left"
    static member inline directionLeft(className: string) : ISpeedDialClasses = unbox ("directionLeft", className)
    /// Styles applied to the root if direction="right"
    static member inline directionRight(className: string) : ISpeedDialClasses = unbox ("directionRight", className)
    /// Styles applied to the actions (`children` wrapper) element.
    static member inline actions(className: string) : ISpeedDialClasses = unbox ("actions", className)
    /// Styles applied to the actions (`children` wrapper) element if `open={false}`.
    static member inline actionsClosed(className: string) : ISpeedDialClasses = unbox ("actionsClosed", className)


  type ISpeedDialActionClasses = interface end
  
  [<Erase>]
  type speedDialAction =
    /// Styles applied to the Fab component.
    static member inline fab(className: string) : ISpeedDialActionClasses = unbox ("fab", className)
    /// Styles applied to the Fab component if `open={false}`.
    static member inline fabClosed(className: string) : ISpeedDialActionClasses = unbox ("fabClosed", className)
    /// Styles applied to the root element if `tooltipOpen={true}`.
    static member inline staticTooltip(className: string) : ISpeedDialActionClasses = unbox ("staticTooltip", className)
    /// Styles applied to the root element if `tooltipOpen={true}` and `open={false}`.
    static member inline staticTooltipClosed(className: string) : ISpeedDialActionClasses = unbox ("staticTooltipClosed", className)
    /// Styles applied to the static tooltip label if `tooltipOpen={true}`.
    static member inline staticTooltipLabel(className: string) : ISpeedDialActionClasses = unbox ("staticTooltipLabel", className)
    /// Styles applied to the root if `tooltipOpen={true}` and `tooltipPlacement="left"``
    static member inline tooltipPlacementLeft(className: string) : ISpeedDialActionClasses = unbox ("tooltipPlacementLeft", className)
    /// Styles applied to the root if `tooltipOpen={true}` and `tooltipPlacement="right"``
    static member inline tooltipPlacementRight(className: string) : ISpeedDialActionClasses = unbox ("tooltipPlacementRight", className)


  type ISpeedDialIconClasses = interface end
  
  [<Erase>]
  type speedDialIcon =
    /// Styles applied to the root element.
    static member inline root(className: string) : ISpeedDialIconClasses = unbox ("root", className)
    /// Styles applied to the icon component.
    static member inline icon(className: string) : ISpeedDialIconClasses = unbox ("icon", className)
    /// Styles applied to the icon component if `open={true}`.
    static member inline iconOpen(className: string) : ISpeedDialIconClasses = unbox ("iconOpen", className)
    /// Styles applied to the icon when and `openIcon` is provided and if `open={true}`.
    static member inline iconWithOpenIconOpen(className: string) : ISpeedDialIconClasses = unbox ("iconWithOpenIconOpen", className)
    /// Styles applied to the `openIcon` if provided.
    static member inline openIcon(className: string) : ISpeedDialIconClasses = unbox ("openIcon", className)
    /// Styles applied to the `openIcon` if provided and if `open={true}`.
    static member inline openIconOpen(className: string) : ISpeedDialIconClasses = unbox ("openIconOpen", className)


  type IStepClasses = interface end
  
  [<Erase>]
  type step =
    /// Styles applied to the root element.
    static member inline root(className: string) : IStepClasses = unbox ("root", className)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(className: string) : IStepClasses = unbox ("horizontal", className)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(className: string) : IStepClasses = unbox ("vertical", className)
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(className: string) : IStepClasses = unbox ("alternativeLabel", className)
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(className: string) : IStepClasses = unbox ("completed", className)


  type IStepButtonClasses = interface end
  
  [<Erase>]
  type stepButton =
    /// Styles applied to the root element.
    static member inline root(className: string) : IStepButtonClasses = unbox ("root", className)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(className: string) : IStepButtonClasses = unbox ("horizontal", className)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(className: string) : IStepButtonClasses = unbox ("vertical", className)
    /// Styles applied to the `ButtonBase` touch-ripple.
    static member inline touchRipple(className: string) : IStepButtonClasses = unbox ("touchRipple", className)


  type IStepConnectorClasses = interface end
  
  [<Erase>]
  type stepConnector =
    /// Styles applied to the root element.
    static member inline root(className: string) : IStepConnectorClasses = unbox ("root", className)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(className: string) : IStepConnectorClasses = unbox ("horizontal", className)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(className: string) : IStepConnectorClasses = unbox ("vertical", className)
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(className: string) : IStepConnectorClasses = unbox ("alternativeLabel", className)
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(className: string) : IStepConnectorClasses = unbox ("active", className)
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(className: string) : IStepConnectorClasses = unbox ("completed", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IStepConnectorClasses = unbox ("disabled", className)
    /// Styles applied to the line element.
    static member inline line(className: string) : IStepConnectorClasses = unbox ("line", className)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline lineHorizontal(className: string) : IStepConnectorClasses = unbox ("lineHorizontal", className)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline lineVertical(className: string) : IStepConnectorClasses = unbox ("lineVertical", className)


  type IStepContentClasses = interface end
  
  [<Erase>]
  type stepContent =
    /// Styles applied to the root element.
    static member inline root(className: string) : IStepContentClasses = unbox ("root", className)
    /// Styles applied to the root element if `last={true}` (controlled by `Step`).
    static member inline last(className: string) : IStepContentClasses = unbox ("last", className)
    /// Styles applied to the Transition component.
    static member inline transition(className: string) : IStepContentClasses = unbox ("transition", className)


  type IStepIconClasses = interface end
  
  [<Erase>]
  type stepIcon =
    /// Styles applied to the root element.
    static member inline root(className: string) : IStepIconClasses = unbox ("root", className)
    /// Styles applied to the SVG text element.
    static member inline text(className: string) : IStepIconClasses = unbox ("text", className)
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(className: string) : IStepIconClasses = unbox ("active", className)
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(className: string) : IStepIconClasses = unbox ("completed", className)
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(className: string) : IStepIconClasses = unbox ("error", className)


  type IStepLabelClasses = interface end
  
  [<Erase>]
  type stepLabel =
    /// Styles applied to the root element.
    static member inline root(className: string) : IStepLabelClasses = unbox ("root", className)
    /// Styles applied to the root element if `orientation="horizontal".
    static member inline horizontal(className: string) : IStepLabelClasses = unbox ("horizontal", className)
    /// Styles applied to the root element if `orientation="vertical".
    static member inline vertical(className: string) : IStepLabelClasses = unbox ("vertical", className)
    /// Styles applied to the `Typography` component which wraps `children`.
    static member inline label(className: string) : IStepLabelClasses = unbox ("label", className)
    /// Pseudo-class applied to the `Typography` component if `active={true}`.
    static member inline active(className: string) : IStepLabelClasses = unbox ("active", className)
    /// Pseudo-class applied to the `Typography` component if `completed={true}`.
    static member inline completed(className: string) : IStepLabelClasses = unbox ("completed", className)
    /// Pseudo-class applied to the root element and `Typography` component if `error={true}`.
    static member inline error(className: string) : IStepLabelClasses = unbox ("error", className)
    /// Pseudo-class applied to the root element and `Typography` component if `disabled={true}`.
    static member inline disabled(className: string) : IStepLabelClasses = unbox ("disabled", className)
    /// Styles applied to the `icon` container element.
    static member inline iconContainer(className: string) : IStepLabelClasses = unbox ("iconContainer", className)
    /// Pseudo-class applied to the root and icon container and `Typography` if `alternativeLabel={true}`.
    static member inline alternativeLabel(className: string) : IStepLabelClasses = unbox ("alternativeLabel", className)
    /// Styles applied to the container element which wraps `Typography` and `optional`.
    static member inline labelContainer(className: string) : IStepLabelClasses = unbox ("labelContainer", className)


  type IStepperClasses = interface end
  
  [<Erase>]
  type stepper =
    /// Styles applied to the root element.
    static member inline root(className: string) : IStepperClasses = unbox ("root", className)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(className: string) : IStepperClasses = unbox ("horizontal", className)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(className: string) : IStepperClasses = unbox ("vertical", className)
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(className: string) : IStepperClasses = unbox ("alternativeLabel", className)


  type ISvgIconClasses = interface end
  
  [<Erase>]
  type svgIcon =
    /// Styles applied to the root element.
    static member inline root(className: string) : ISvgIconClasses = unbox ("root", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : ISvgIconClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : ISvgIconClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `color="action"`.
    static member inline colorAction(className: string) : ISvgIconClasses = unbox ("colorAction", className)
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(className: string) : ISvgIconClasses = unbox ("colorError", className)
    /// Styles applied to the root element if `color="disabled"`.
    static member inline colorDisabled(className: string) : ISvgIconClasses = unbox ("colorDisabled", className)
    /// Styles applied to the root element if `fontSize="inherit"`.
    static member inline fontSizeInherit(className: string) : ISvgIconClasses = unbox ("fontSizeInherit", className)
    /// Styles applied to the root element if `fontSize="small"`.
    static member inline fontSizeSmall(className: string) : ISvgIconClasses = unbox ("fontSizeSmall", className)
    /// Styles applied to the root element if `fontSize="large"`.
    static member inline fontSizeLarge(className: string) : ISvgIconClasses = unbox ("fontSizeLarge", className)


  type ISwipeableDrawerClasses = interface end


  type ISwitchClasses = interface end
  
  [<Erase>]
  type switch =
    /// Styles applied to the root element.
    static member inline root(className: string) : ISwitchClasses = unbox ("root", className)
    /// Styles applied to the root element if `edge="start"`.
    static member inline edgeStart(className: string) : ISwitchClasses = unbox ("edgeStart", className)
    /// Styles applied to the root element if `edge="end"`.
    static member inline edgeEnd(className: string) : ISwitchClasses = unbox ("edgeEnd", className)
    /// Styles applied to the internal `SwitchBase` component's `root` class.
    static member inline switchBase(className: string) : ISwitchClasses = unbox ("switchBase", className)
    /// Styles applied to the internal SwitchBase component's root element if `color="primary"`.
    static member inline colorPrimary(className: string) : ISwitchClasses = unbox ("colorPrimary", className)
    /// Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : ISwitchClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(className: string) : ISwitchClasses = unbox ("sizeSmall", className)
    /// Pseudo-class applied to the internal `SwitchBase` component's `checked` class.
    static member inline checked'(className: string) : ISwitchClasses = unbox ("checked", className)
    /// Pseudo-class applied to the internal SwitchBase component's disabled class.
    static member inline disabled(className: string) : ISwitchClasses = unbox ("disabled", className)
    /// Styles applied to the internal SwitchBase component's input element.
    static member inline input(className: string) : ISwitchClasses = unbox ("input", className)
    /// Styles used to create the thumb passed to the internal `SwitchBase` component `icon` prop.
    static member inline thumb(className: string) : ISwitchClasses = unbox ("thumb", className)
    /// Styles applied to the track element.
    static member inline track(className: string) : ISwitchClasses = unbox ("track", className)


  type ITabClasses = interface end
  
  [<Erase>]
  type tab =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITabClasses = unbox ("root", className)
    /// Styles applied to the root element if both `icon` and `label` are provided.
    static member inline labelIcon(className: string) : ITabClasses = unbox ("labelIcon", className)
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="inherit"`.
    static member inline textColorInherit(className: string) : ITabClasses = unbox ("textColorInherit", className)
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="primary"`.
    static member inline textColorPrimary(className: string) : ITabClasses = unbox ("textColorPrimary", className)
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="secondary"`.
    static member inline textColorSecondary(className: string) : ITabClasses = unbox ("textColorSecondary", className)
    /// Pseudo-class applied to the root element if `selected={true}` (controlled by the Tabs component).
    static member inline selected(className: string) : ITabClasses = unbox ("selected", className)
    /// Pseudo-class applied to the root element if `disabled={true}` (controlled by the Tabs component).
    static member inline disabled(className: string) : ITabClasses = unbox ("disabled", className)
    /// Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
    static member inline fullWidth(className: string) : ITabClasses = unbox ("fullWidth", className)
    /// Styles applied to the root element if `wrapped={true}`.
    static member inline wrapped(className: string) : ITabClasses = unbox ("wrapped", className)
    /// Styles applied to the `icon` and `label`'s wrapper element.
    static member inline wrapper(className: string) : ITabClasses = unbox ("wrapper", className)


  type ITableClasses = interface end
  
  [<Erase>]
  type table =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITableClasses = unbox ("root", className)
    /// Styles applied to the root element if `stickyHeader={true}`.
    static member inline stickyHeader(className: string) : ITableClasses = unbox ("stickyHeader", className)


  type ITableBodyClasses = interface end
  
  [<Erase>]
  type tableBody =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITableBodyClasses = unbox ("root", className)


  type ITableCellClasses = interface end
  
  [<Erase>]
  type tableCell =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITableCellClasses = unbox ("root", className)
    /// Styles applied to the root element if `variant="head"` or `context.table.head`.
    static member inline head(className: string) : ITableCellClasses = unbox ("head", className)
    /// Styles applied to the root element if `variant="body"` or `context.table.body`.
    static member inline body(className: string) : ITableCellClasses = unbox ("body", className)
    /// Styles applied to the root element if `variant="footer"` or `context.table.footer`.
    static member inline footer(className: string) : ITableCellClasses = unbox ("footer", className)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(className: string) : ITableCellClasses = unbox ("sizeSmall", className)
    /// Styles applied to the root element if `padding="checkbox"`.
    static member inline paddingCheckbox(className: string) : ITableCellClasses = unbox ("paddingCheckbox", className)
    /// Styles applied to the root element if `padding="none"`.
    static member inline paddingNone(className: string) : ITableCellClasses = unbox ("paddingNone", className)
    /// Styles applied to the root element if `align="left"`.
    static member inline alignLeft(className: string) : ITableCellClasses = unbox ("alignLeft", className)
    /// Styles applied to the root element if `align="center"`.
    static member inline alignCenter(className: string) : ITableCellClasses = unbox ("alignCenter", className)
    /// Styles applied to the root element if `align="right"`.
    static member inline alignRight(className: string) : ITableCellClasses = unbox ("alignRight", className)
    /// Styles applied to the root element if `align="justify"`.
    static member inline alignJustify(className: string) : ITableCellClasses = unbox ("alignJustify", className)
    /// Styles applied to the root element if `context.table.stickyHeader={true}`.
    static member inline stickyHeader(className: string) : ITableCellClasses = unbox ("stickyHeader", className)


  type ITableContainerClasses = interface end
  
  [<Erase>]
  type tableContainer =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITableContainerClasses = unbox ("root", className)


  type ITableFooterClasses = interface end
  
  [<Erase>]
  type tableFooter =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITableFooterClasses = unbox ("root", className)


  type ITableHeadClasses = interface end
  
  [<Erase>]
  type tableHead =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITableHeadClasses = unbox ("root", className)


  type ITablePaginationClasses = interface end
  
  [<Erase>]
  type tablePagination =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITablePaginationClasses = unbox ("root", className)
    /// Styles applied to the Toolbar component.
    static member inline toolbar(className: string) : ITablePaginationClasses = unbox ("toolbar", className)
    /// Styles applied to the spacer element.
    static member inline spacer(className: string) : ITablePaginationClasses = unbox ("spacer", className)
    /// Styles applied to the caption Typography components if `variant="caption"`.
    static member inline caption(className: string) : ITablePaginationClasses = unbox ("caption", className)
    /// Styles applied to the Select component root element.
    static member inline selectRoot(className: string) : ITablePaginationClasses = unbox ("selectRoot", className)
    /// Styles applied to the Select component `select` class.
    static member inline select(className: string) : ITablePaginationClasses = unbox ("select", className)
    /// Styles applied to the Select component `icon` class.
    static member inline selectIcon(className: string) : ITablePaginationClasses = unbox ("selectIcon", className)
    /// Styles applied to the `InputBase` component.
    static member inline input(className: string) : ITablePaginationClasses = unbox ("input", className)
    /// Styles applied to the MenuItem component.
    static member inline menuItem(className: string) : ITablePaginationClasses = unbox ("menuItem", className)
    /// Styles applied to the internal `TablePaginationActions` component.
    static member inline actions(className: string) : ITablePaginationClasses = unbox ("actions", className)


  type ITableRowClasses = interface end
  
  [<Erase>]
  type tableRow =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITableRowClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(className: string) : ITableRowClasses = unbox ("selected", className)
    /// Pseudo-class applied to the root element if `hover={true}`.
    static member inline hover(className: string) : ITableRowClasses = unbox ("hover", className)
    /// Styles applied to the root element if table variant="head".
    static member inline head(className: string) : ITableRowClasses = unbox ("head", className)
    /// Styles applied to the root element if table variant="footer".
    static member inline footer(className: string) : ITableRowClasses = unbox ("footer", className)


  type ITableSortLabelClasses = interface end
  
  [<Erase>]
  type tableSortLabel =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITableSortLabelClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(className: string) : ITableSortLabelClasses = unbox ("active", className)
    /// Styles applied to the icon component.
    static member inline icon(className: string) : ITableSortLabelClasses = unbox ("icon", className)
    /// Styles applied to the icon component if `direction="desc"`.
    static member inline iconDirectionDesc(className: string) : ITableSortLabelClasses = unbox ("iconDirectionDesc", className)
    /// Styles applied to the icon component if `direction="asc"`.
    static member inline iconDirectionAsc(className: string) : ITableSortLabelClasses = unbox ("iconDirectionAsc", className)


  type ITabsClasses = interface end
  
  [<Erase>]
  type tabs =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITabsClasses = unbox ("root", className)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(className: string) : ITabsClasses = unbox ("vertical", className)
    /// Styles applied to the flex container element.
    static member inline flexContainer(className: string) : ITabsClasses = unbox ("flexContainer", className)
    /// Styles applied to the flex container element if `orientation="vertical"`.
    static member inline flexContainerVertical(className: string) : ITabsClasses = unbox ("flexContainerVertical", className)
    /// Styles applied to the flex container element if `centered={true}`&`!variant="scrollable"`.
    static member inline centered(className: string) : ITabsClasses = unbox ("centered", className)
    /// Styles applied to the tablist element.
    static member inline scroller(className: string) : ITabsClasses = unbox ("scroller", className)
    /// Styles applied to the tablist element if `!variant="scrollable"`.
    static member inline fixed'(className: string) : ITabsClasses = unbox ("fixed", className)
    /// Styles applied to the tablist element if `variant="scrollable"`.
    static member inline scrollable(className: string) : ITabsClasses = unbox ("scrollable", className)
    /// Styles applied to the `ScrollButtonComponent` component.
    static member inline scrollButtons(className: string) : ITabsClasses = unbox ("scrollButtons", className)
    /// Styles applied to the `ScrollButtonComponent` component if `scrollButtons="auto"` or scrollButtons="desktop"`.
    static member inline scrollButtonsDesktop(className: string) : ITabsClasses = unbox ("scrollButtonsDesktop", className)
    /// Styles applied to the `TabIndicator` component.
    static member inline indicator(className: string) : ITabsClasses = unbox ("indicator", className)


  type ITextareaAutosizeClasses = interface end


  type ITextFieldClasses = interface end
  
  [<Erase>]
  type textField =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITextFieldClasses = unbox ("root", className)


  type IToggleButtonClasses = interface end
  
  [<Erase>]
  type toggleButton =
    /// Styles applied to the root element.
    static member inline root(className: string) : IToggleButtonClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(className: string) : IToggleButtonClasses = unbox ("disabled", className)
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(className: string) : IToggleButtonClasses = unbox ("selected", className)
    /// Styles applied to the `label` wrapper element.
    static member inline label(className: string) : IToggleButtonClasses = unbox ("label", className)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(className: string) : IToggleButtonClasses = unbox ("sizeSmall", className)
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(className: string) : IToggleButtonClasses = unbox ("sizeLarge", className)


  type IToggleButtonGroupClasses = interface end
  
  [<Erase>]
  type toggleButtonGroup =
    /// Styles applied to the root element.
    static member inline root(className: string) : IToggleButtonGroupClasses = unbox ("root", className)
    /// Styles applied to the children.
    static member inline grouped(className: string) : IToggleButtonGroupClasses = unbox ("grouped", className)
    /// Styles applied to the children if `size="small"`.
    static member inline groupedSizeSmall(className: string) : IToggleButtonGroupClasses = unbox ("groupedSizeSmall", className)
    /// Styles applied to the children if `size="large"`.
    static member inline groupedSizeLarge(className: string) : IToggleButtonGroupClasses = unbox ("groupedSizeLarge", className)


  type IToolbarClasses = interface end
  
  [<Erase>]
  type toolbar =
    /// Styles applied to the root element.
    static member inline root(className: string) : IToolbarClasses = unbox ("root", className)
    /// Styles applied to the root element if `disableGutters={false}`.
    static member inline gutters(className: string) : IToolbarClasses = unbox ("gutters", className)
    /// Styles applied to the root element if `variant="regular"`.
    static member inline regular(className: string) : IToolbarClasses = unbox ("regular", className)
    /// Styles applied to the root element if `variant="dense"`.
    static member inline dense(className: string) : IToolbarClasses = unbox ("dense", className)


  type ITooltipClasses = interface end
  
  [<Erase>]
  type tooltip =
    /// Styles applied to the Popper component.
    static member inline popper(className: string) : ITooltipClasses = unbox ("popper", className)
    /// Styles applied to the Popper component if `interactive={true}`.
    static member inline popperInteractive(className: string) : ITooltipClasses = unbox ("popperInteractive", className)
    /// Styles applied to the Popper component if `arrow={true}`.
    static member inline popperArrow(className: string) : ITooltipClasses = unbox ("popperArrow", className)
    /// Styles applied to the tooltip (label wrapper) element.
    static member inline tooltip(className: string) : ITooltipClasses = unbox ("tooltip", className)
    /// Styles applied to the tooltip (label wrapper) element if `arrow={true}`.
    static member inline tooltipArrow(className: string) : ITooltipClasses = unbox ("tooltipArrow", className)
    /// Styles applied to the arrow element.
    static member inline arrow(className: string) : ITooltipClasses = unbox ("arrow", className)
    /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
    static member inline touch(className: string) : ITooltipClasses = unbox ("touch", className)
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
    static member inline tooltipPlacementLeft(className: string) : ITooltipClasses = unbox ("tooltipPlacementLeft", className)
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
    static member inline tooltipPlacementRight(className: string) : ITooltipClasses = unbox ("tooltipPlacementRight", className)
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
    static member inline tooltipPlacementTop(className: string) : ITooltipClasses = unbox ("tooltipPlacementTop", className)
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
    static member inline tooltipPlacementBottom(className: string) : ITooltipClasses = unbox ("tooltipPlacementBottom", className)


  type ITouchRippleClasses = interface end
  
  [<Erase>]
  type touchRipple =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITouchRippleClasses = unbox ("root", className)
    /// Styles applied to the internal `Ripple` components `ripple` class.
    static member inline ripple(className: string) : ITouchRippleClasses = unbox ("ripple", className)
    /// Styles applied to the internal `Ripple` components `rippleVisible` class.
    static member inline rippleVisible(className: string) : ITouchRippleClasses = unbox ("rippleVisible", className)
    /// Styles applied to the internal `Ripple` components `ripplePulsate` class.
    static member inline ripplePulsate(className: string) : ITouchRippleClasses = unbox ("ripplePulsate", className)
    /// Styles applied to the internal `Ripple` components `child` class.
    static member inline child(className: string) : ITouchRippleClasses = unbox ("child", className)
    /// Styles applied to the internal `Ripple` components `childLeaving` class.
    static member inline childLeaving(className: string) : ITouchRippleClasses = unbox ("childLeaving", className)
    /// Styles applied to the internal `Ripple` components `childPulsate` class.
    static member inline childPulsate(className: string) : ITouchRippleClasses = unbox ("childPulsate", className)


  type ITreeItemClasses = interface end
  
  [<Erase>]
  type treeItem =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITreeItemClasses = unbox ("root", className)
    /// Pseudo-class applied to the root element when expanded.
    static member inline expanded(className: string) : ITreeItemClasses = unbox ("expanded", className)
    /// Styles applied to the `role="group"` element.
    static member inline group(className: string) : ITreeItemClasses = unbox ("group", className)
    /// Styles applied to the tree node content.
    static member inline content(className: string) : ITreeItemClasses = unbox ("content", className)
    /// Styles applied to the tree node icon and collapse/expand icon.
    static member inline iconContainer(className: string) : ITreeItemClasses = unbox ("iconContainer", className)
    /// Styles applied to the label element.
    static member inline label(className: string) : ITreeItemClasses = unbox ("label", className)


  type ITreeViewClasses = interface end
  
  [<Erase>]
  type treeView =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITreeViewClasses = unbox ("root", className)


  type ITypographyClasses = interface end
  
  [<Erase>]
  type typography =
    /// Styles applied to the root element.
    static member inline root(className: string) : ITypographyClasses = unbox ("root", className)
    /// Styles applied to the root element if `variant="body2"`.
    static member inline body2(className: string) : ITypographyClasses = unbox ("body2", className)
    /// Styles applied to the root element if `variant="body1"`.
    static member inline body1(className: string) : ITypographyClasses = unbox ("body1", className)
    /// Styles applied to the root element if `variant="caption"`.
    static member inline caption(className: string) : ITypographyClasses = unbox ("caption", className)
    /// Styles applied to the root element if `variant="button"`.
    static member inline button(className: string) : ITypographyClasses = unbox ("button", className)
    /// Styles applied to the root element if `variant="h1"`.
    static member inline h1(className: string) : ITypographyClasses = unbox ("h1", className)
    /// Styles applied to the root element if `variant="h2"`.
    static member inline h2(className: string) : ITypographyClasses = unbox ("h2", className)
    /// Styles applied to the root element if `variant="h3"`.
    static member inline h3(className: string) : ITypographyClasses = unbox ("h3", className)
    /// Styles applied to the root element if `variant="h4"`.
    static member inline h4(className: string) : ITypographyClasses = unbox ("h4", className)
    /// Styles applied to the root element if `variant="h5"`.
    static member inline h5(className: string) : ITypographyClasses = unbox ("h5", className)
    /// Styles applied to the root element if `variant="h6"`.
    static member inline h6(className: string) : ITypographyClasses = unbox ("h6", className)
    /// Styles applied to the root element if `variant="subtitle1"`.
    static member inline subtitle1(className: string) : ITypographyClasses = unbox ("subtitle1", className)
    /// Styles applied to the root element if `variant="subtitle2"`.
    static member inline subtitle2(className: string) : ITypographyClasses = unbox ("subtitle2", className)
    /// Styles applied to the root element if `variant="overline"`.
    static member inline overline(className: string) : ITypographyClasses = unbox ("overline", className)
    /// Styles applied to the root element if `variant="srOnly"`. Only accessible to screen readers.
    static member inline srOnly(className: string) : ITypographyClasses = unbox ("srOnly", className)
    /// Styles applied to the root element if `align="left"`.
    static member inline alignLeft(className: string) : ITypographyClasses = unbox ("alignLeft", className)
    /// Styles applied to the root element if `align="center"`.
    static member inline alignCenter(className: string) : ITypographyClasses = unbox ("alignCenter", className)
    /// Styles applied to the root element if `align="right"`.
    static member inline alignRight(className: string) : ITypographyClasses = unbox ("alignRight", className)
    /// Styles applied to the root element if `align="justify"`.
    static member inline alignJustify(className: string) : ITypographyClasses = unbox ("alignJustify", className)
    /// Styles applied to the root element if `nowrap={true}`.
    static member inline noWrap(className: string) : ITypographyClasses = unbox ("noWrap", className)
    /// Styles applied to the root element if `gutterBottom={true}`.
    static member inline gutterBottom(className: string) : ITypographyClasses = unbox ("gutterBottom", className)
    /// Styles applied to the root element if `paragraph={true}`.
    static member inline paragraph(className: string) : ITypographyClasses = unbox ("paragraph", className)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(className: string) : ITypographyClasses = unbox ("colorInherit", className)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(className: string) : ITypographyClasses = unbox ("colorPrimary", className)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(className: string) : ITypographyClasses = unbox ("colorSecondary", className)
    /// Styles applied to the root element if `color="textPrimary"`.
    static member inline colorTextPrimary(className: string) : ITypographyClasses = unbox ("colorTextPrimary", className)
    /// Styles applied to the root element if `color="textSecondary"`.
    static member inline colorTextSecondary(className: string) : ITypographyClasses = unbox ("colorTextSecondary", className)
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(className: string) : ITypographyClasses = unbox ("colorError", className)
    /// Styles applied to the root element if `display="inline"`.
    static member inline displayInline(className: string) : ITypographyClasses = unbox ("displayInline", className)
    /// Styles applied to the root element if `display="block"`.
    static member inline displayBlock(className: string) : ITypographyClasses = unbox ("displayBlock", className)


  type IZoomClasses = interface end

