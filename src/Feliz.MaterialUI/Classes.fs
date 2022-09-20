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
      static member inline root : string = ".MuiAccordion-root"
      /// Styles applied to the root element unless `square={true}`.
      static member inline rounded : string = ".MuiAccordion-rounded"
      /// State class applied to the root element if `expanded={true}`.
      static member inline expanded : string = ".Mui-expanded"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element unless `disableGutters={true}`.
      static member inline gutters : string = ".MuiAccordion-gutters"
      /// Styles applied to the region element, the container of the children.
      static member inline region : string = ".MuiAccordion-region"
  
  
  module accordionActions =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAccordionActions-root"
      /// Styles applied to the root element unless `disableSpacing={true}`.
      static member inline spacing : string = ".MuiAccordionActions-spacing"
  
  
  module accordionDetails =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAccordionDetails-root"
  
  
  module accordionSummary =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAccordionSummary-root"
      /// State class applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
      static member inline expanded : string = ".Mui-expanded"
      /// State class applied to the ButtonBase root element if the button is keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element unless `disableGutters={true}`.
      static member inline gutters : string = ".MuiAccordionSummary-gutters"
      /// Styles applied to the children wrapper element unless `disableGutters={true}`.
      static member inline contentGutters : string = ".MuiAccordionSummary-contentGutters"
      /// Styles applied to the children wrapper element.
      static member inline content : string = ".MuiAccordionSummary-content"
      /// Styles applied to the `expandIcon`'s wrapper element.
      static member inline expandIconWrapper : string = ".MuiAccordionSummary-expandIconWrapper"
  
  
  module alert =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAlert-root"
      /// Styles applied to the root element if `variant="filled"`.
      static member inline filled : string = ".MuiAlert-filled"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiAlert-outlined"
      /// Styles applied to the root element if `variant="standard"`.
      static member inline standard : string = ".MuiAlert-standard"
      /// Styles applied to the root element if `variant="standard"` and `color="success"`.
      static member inline standardSuccess : string = ".MuiAlert-standardSuccess"
      /// Styles applied to the root element if `variant="standard"` and `color="info"`.
      static member inline standardInfo : string = ".MuiAlert-standardInfo"
      /// Styles applied to the root element if `variant="standard"` and `color="warning"`.
      static member inline standardWarning : string = ".MuiAlert-standardWarning"
      /// Styles applied to the root element if `variant="standard"` and `color="error"`.
      static member inline standardError : string = ".MuiAlert-standardError"
      /// Styles applied to the root element if `variant="outlined"` and `color="success"`.
      static member inline outlinedSuccess : string = ".MuiAlert-outlinedSuccess"
      /// Styles applied to the root element if `variant="outlined"` and `color="info"`.
      static member inline outlinedInfo : string = ".MuiAlert-outlinedInfo"
      /// Styles applied to the root element if `variant="outlined"` and `color="warning"`.
      static member inline outlinedWarning : string = ".MuiAlert-outlinedWarning"
      /// Styles applied to the root element if `variant="outlined"` and `color="error"`.
      static member inline outlinedError : string = ".MuiAlert-outlinedError"
      /// Styles applied to the root element if `variant="filled"` and `color="success"`.
      static member inline filledSuccess : string = ".MuiAlert-filledSuccess"
      /// Styles applied to the root element if `variant="filled"` and `color="info"`.
      static member inline filledInfo : string = ".MuiAlert-filledInfo"
      /// Styles applied to the root element if `variant="filled"` and `color="warning"`.
      static member inline filledWarning : string = ".MuiAlert-filledWarning"
      /// Styles applied to the root element if `variant="filled"` and `color="error"`.
      static member inline filledError : string = ".MuiAlert-filledError"
      /// Styles applied to the icon wrapper element.
      static member inline icon : string = ".MuiAlert-icon"
      /// Styles applied to the message wrapper element.
      static member inline message : string = ".MuiAlert-message"
      /// Styles applied to the action wrapper element if `action` is provided.
      static member inline action : string = ".MuiAlert-action"
  
  
  module alertTitle =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAlertTitle-root"
  
  
  module appBar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAppBar-root"
      /// Styles applied to the root element if `position="fixed"`.
      static member inline positionFixed : string = ".MuiAppBar-positionFixed"
      /// Styles applied to the root element if `position="absolute"`.
      static member inline positionAbsolute : string = ".MuiAppBar-positionAbsolute"
      /// Styles applied to the root element if `position="sticky"`.
      static member inline positionSticky : string = ".MuiAppBar-positionSticky"
      /// Styles applied to the root element if `position="static"`.
      static member inline positionStatic : string = ".MuiAppBar-positionStatic"
      /// Styles applied to the root element if `position="relative"`.
      static member inline positionRelative : string = ".MuiAppBar-positionRelative"
      /// Styles applied to the root element if `color="default"`.
      static member inline colorDefault : string = ".MuiAppBar-colorDefault"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiAppBar-colorPrimary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiAppBar-colorSecondary"
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit : string = ".MuiAppBar-colorInherit"
      /// Styles applied to the root element if `color="transparent"`.
      static member inline colorTransparent : string = ".MuiAppBar-colorTransparent"
  
  
  module autocomplete =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAutocomplete-root"
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth : string = ".MuiAutocomplete-fullWidth"
      /// State class applied to the root element if focused.
      static member inline focused : string = ".Mui-focused"
      /// Styles applied to the tag elements, e.g. the chips.
      static member inline tag : string = ".MuiAutocomplete-tag"
      /// Styles applied to the tag elements, e.g. the chips if `size="small"`.
      static member inline tagSizeSmall : string = ".MuiAutocomplete-tagSizeSmall"
      /// Styles applied to the tag elements, e.g. the chips if `size="medium"`.
      static member inline tagSizeMedium : string = ".MuiAutocomplete-tagSizeMedium"
      /// Styles applied when the popup icon is rendered.
      static member inline hasPopupIcon : string = ".MuiAutocomplete-hasPopupIcon"
      /// Styles applied when the clear icon is rendered.
      static member inline hasClearIcon : string = ".MuiAutocomplete-hasClearIcon"
      /// Styles applied to the Input element.
      static member inline inputRoot : string = ".MuiAutocomplete-inputRoot"
      /// Styles applied to the input element.
      static member inline input : string = ".MuiAutocomplete-input"
      /// Styles applied to the input element if the input is focused.
      static member inline inputFocused : string = ".MuiAutocomplete-inputFocused"
      /// Styles applied to the endAdornment element.
      static member inline endAdornment : string = ".MuiAutocomplete-endAdornment"
      /// Styles applied to the clear indicator.
      static member inline clearIndicator : string = ".MuiAutocomplete-clearIndicator"
      /// Styles applied to the popup indicator.
      static member inline popupIndicator : string = ".MuiAutocomplete-popupIndicator"
      /// Styles applied to the popup indicator if the popup is open.
      static member inline popupIndicatorOpen : string = ".MuiAutocomplete-popupIndicatorOpen"
      /// Styles applied to the popper element.
      static member inline popper : string = ".MuiAutocomplete-popper"
      /// Styles applied to the popper element if `disablePortal={true}`.
      static member inline popperDisablePortal : string = ".MuiAutocomplete-popperDisablePortal"
      /// Styles applied to the Paper component.
      static member inline paper : string = ".MuiAutocomplete-paper"
      /// Styles applied to the listbox component.
      static member inline listbox : string = ".MuiAutocomplete-listbox"
      /// Styles applied to the loading wrapper.
      static member inline loading : string = ".MuiAutocomplete-loading"
      /// Styles applied to the no option wrapper.
      static member inline noOptions : string = ".MuiAutocomplete-noOptions"
      /// Styles applied to the option elements.
      static member inline option : string = ".MuiAutocomplete-option"
      /// Styles applied to the group's label elements.
      static member inline groupLabel : string = ".MuiAutocomplete-groupLabel"
      /// Styles applied to the group's ul elements.
      static member inline groupUl : string = ".MuiAutocomplete-groupUl"
  
  
  module avatar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAvatar-root"
      /// Styles applied to the root element if not `src` or `srcSet`.
      static member inline colorDefault : string = ".MuiAvatar-colorDefault"
      /// Styles applied to the root element if `variant="circular"`.
      static member inline circular : string = ".MuiAvatar-circular"
      /// Styles applied to the root element if `variant="rounded"`.
      static member inline rounded : string = ".MuiAvatar-rounded"
      /// Styles applied to the root element if `variant="square"`.
      static member inline square : string = ".MuiAvatar-square"
      /// Styles applied to the img element if either `src` or `srcSet` is defined.
      static member inline img : string = ".MuiAvatar-img"
      /// Styles applied to the fallback icon
      static member inline fallback : string = ".MuiAvatar-fallback"
  
  
  module avatarGroup =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiAvatarGroup-root"
      /// Styles applied to the avatar elements.
      static member inline avatar : string = ".MuiAvatarGroup-avatar"
  
  
  module backdrop =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiBackdrop-root"
      /// Styles applied to the root element if `invisible={true}`.
      static member inline invisible : string = ".MuiBackdrop-invisible"
  
  
  module badge =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Class name applied to the root element.
      static member inline root : string = ".MuiBadge-root"
      /// Class name applied to the badge `span` element.
      static member inline badge : string = ".MuiBadge-badge"
      /// Class name applied to the badge `span` element if `variant="dot"`.
      static member inline dot : string = ".MuiBadge-dot"
      /// Class name applied to the badge `span` element if `variant="standard"`.
      static member inline standard : string = ".MuiBadge-standard"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }}`.
      static member inline anchorOriginTopRight : string = ".MuiBadge-anchorOriginTopRight"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }}`.
      static member inline anchorOriginBottomRight : string = ".MuiBadge-anchorOriginBottomRight"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }}`.
      static member inline anchorOriginTopLeft : string = ".MuiBadge-anchorOriginTopLeft"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }}`.
      static member inline anchorOriginBottomLeft : string = ".MuiBadge-anchorOriginBottomLeft"
      /// State class applied to the badge `span` element if `invisible={true}`.
      static member inline invisible : string = ".MuiBadge-invisible"
      /// Styles applied to the badge `span` element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiBadge-colorPrimary"
      /// Styles applied to the badge `span` element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiBadge-colorSecondary"
      /// Styles applied to the badge `span` element if `color="error"`.
      static member inline colorError : string = ".MuiBadge-colorError"
      /// Styles applied to the badge `span` element if `color="info"`.
      static member inline colorInfo : string = ".MuiBadge-colorInfo"
      /// Styles applied to the badge `span` element if `color="success"`.
      static member inline colorSuccess : string = ".MuiBadge-colorSuccess"
      /// Styles applied to the badge `span` element if `color="warning"`.
      static member inline colorWarning : string = ".MuiBadge-colorWarning"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }} overlap="rectangular"`.
      static member inline anchorOriginTopRightRectangular : string = ".MuiBadge-anchorOriginTopRightRectangular"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }} overlap="rectangular"`.
      static member inline anchorOriginBottomRightRectangular : string = ".MuiBadge-anchorOriginBottomRightRectangular"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }} overlap="rectangular"`.
      static member inline anchorOriginTopLeftRectangular : string = ".MuiBadge-anchorOriginTopLeftRectangular"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }} overlap="rectangular"`.
      static member inline anchorOriginBottomLeftRectangular : string = ".MuiBadge-anchorOriginBottomLeftRectangular"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'right' }} overlap="circular"`.
      static member inline anchorOriginTopRightCircular : string = ".MuiBadge-anchorOriginTopRightCircular"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'right' }} overlap="circular"`.
      static member inline anchorOriginBottomRightCircular : string = ".MuiBadge-anchorOriginBottomRightCircular"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'top', 'left' }} overlap="circular"`.
      static member inline anchorOriginTopLeftCircular : string = ".MuiBadge-anchorOriginTopLeftCircular"
      /// Class name applied to the badge `span` element if `anchorOrigin={{ 'bottom', 'left' }} overlap="circular"`.
      static member inline anchorOriginBottomLeftCircular : string = ".MuiBadge-anchorOriginBottomLeftCircular"
      /// Class name applied to the badge `span` element if `overlap="rectangular"`.
      static member inline overlapRectangular : string = ".MuiBadge-overlapRectangular"
      /// Class name applied to the badge `span` element if `overlap="circular"`.
      static member inline overlapCircular : string = ".MuiBadge-overlapCircular"
  
  
  module bottomNavigation =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiBottomNavigation-root"
  
  
  module bottomNavigationAction =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiBottomNavigationAction-root"
      /// State class applied to the root element if selected.
      static member inline selected : string = ".Mui-selected"
      /// State class applied to the root element if `showLabel={false}` and not selected.
      static member inline iconOnly : string = ".MuiBottomNavigationAction-iconOnly"
      /// Styles applied to the label's span element.
      static member inline label : string = ".MuiBottomNavigationAction-label"
  
  
  module breadcrumbs =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiBreadcrumbs-root"
      /// Styles applied to the ol element.
      static member inline ol : string = ".MuiBreadcrumbs-ol"
      /// Styles applied to the li element.
      static member inline li : string = ".MuiBreadcrumbs-li"
      /// Styles applied to the separator element.
      static member inline separator : string = ".MuiBreadcrumbs-separator"
  
  
  module button =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiButton-root"
      /// Styles applied to the root element if `variant="text"`.
      static member inline text : string = ".MuiButton-text"
      /// Styles applied to the root element if `variant="text"` and `color="inherit"`.
      static member inline textInherit : string = ".MuiButton-textInherit"
      /// Styles applied to the root element if `variant="text"` and `color="primary"`.
      static member inline textPrimary : string = ".MuiButton-textPrimary"
      /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
      static member inline textSecondary : string = ".MuiButton-textSecondary"
      /// Styles applied to the root element if `variant="text"` and `color="success"`.
      static member inline textSuccess : string = ".MuiButton-textSuccess"
      /// Styles applied to the root element if `variant="text"` and `color="error"`.
      static member inline textError : string = ".MuiButton-textError"
      /// Styles applied to the root element if `variant="text"` and `color="info"`.
      static member inline textInfo : string = ".MuiButton-textInfo"
      /// Styles applied to the root element if `variant="text"` and `color="warning"`.
      static member inline textWarning : string = ".MuiButton-textWarning"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiButton-outlined"
      /// Styles applied to the root element if `variant="outlined"` and `color="inherit"`.
      static member inline outlinedInherit : string = ".MuiButton-outlinedInherit"
      /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
      static member inline outlinedPrimary : string = ".MuiButton-outlinedPrimary"
      /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
      static member inline outlinedSecondary : string = ".MuiButton-outlinedSecondary"
      /// Styles applied to the root element if `variant="outlined"` and `color="success"`.
      static member inline outlinedSuccess : string = ".MuiButton-outlinedSuccess"
      /// Styles applied to the root element if `variant="outlined"` and `color="error"`.
      static member inline outlinedError : string = ".MuiButton-outlinedError"
      /// Styles applied to the root element if `variant="outlined"` and `color="info"`.
      static member inline outlinedInfo : string = ".MuiButton-outlinedInfo"
      /// Styles applied to the root element if `variant="outlined"` and `color="warning"`.
      static member inline outlinedWarning : string = ".MuiButton-outlinedWarning"
      /// Styles applied to the root element if `variant="contained"`.
      static member inline contained : string = ".MuiButton-contained"
      /// Styles applied to the root element if `variant="contained"` and `color="inherit"`.
      static member inline containedInherit : string = ".MuiButton-containedInherit"
      /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
      static member inline containedPrimary : string = ".MuiButton-containedPrimary"
      /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
      static member inline containedSecondary : string = ".MuiButton-containedSecondary"
      /// Styles applied to the root element if `variant="contained"` and `color="success"`.
      static member inline containedSuccess : string = ".MuiButton-containedSuccess"
      /// Styles applied to the root element if `variant="contained"` and `color="info"`.
      static member inline containedInfo : string = ".MuiButton-containedInfo"
      /// Styles applied to the root element if `variant="contained"` and `color="error"`.
      static member inline containedError : string = ".MuiButton-containedError"
      /// Styles applied to the root element if `variant="contained"` and `color="warning"`.
      static member inline containedWarning : string = ".MuiButton-containedWarning"
      /// Styles applied to the root element if `disableElevation={true}`.
      static member inline disableElevation : string = ".MuiButton-disableElevation"
      /// State class applied to the ButtonBase root element if the button is keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit : string = ".MuiButton-colorInherit"
      /// Styles applied to the root element if `size="small"` and `variant="text"`.
      static member inline textSizeSmall : string = ".MuiButton-textSizeSmall"
      /// Styles applied to the root element if `size="medium"` and `variant="text"`.
      static member inline textSizeMedium : string = ".MuiButton-textSizeMedium"
      /// Styles applied to the root element if `size="large"` and `variant="text"`.
      static member inline textSizeLarge : string = ".MuiButton-textSizeLarge"
      /// Styles applied to the root element if `size="small"` and `variant="outlined"`.
      static member inline outlinedSizeSmall : string = ".MuiButton-outlinedSizeSmall"
      /// Styles applied to the root element if `size="medium"` and `variant="outlined"`.
      static member inline outlinedSizeMedium : string = ".MuiButton-outlinedSizeMedium"
      /// Styles applied to the root element if `size="large"` and `variant="outlined"`.
      static member inline outlinedSizeLarge : string = ".MuiButton-outlinedSizeLarge"
      /// Styles applied to the root element if `size="small"` and `variant="contained"`.
      static member inline containedSizeSmall : string = ".MuiButton-containedSizeSmall"
      /// Styles applied to the root element if `size="medium"` and `variant="contained"`.
      static member inline containedSizeMedium : string = ".MuiButton-containedSizeMedium"
      /// Styles applied to the root element if `size="large"` and `variant="contained"`.
      static member inline containedSizeLarge : string = ".MuiButton-containedSizeLarge"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiButton-sizeSmall"
      /// Styles applied to the root element if `size="medium"`.
      static member inline sizeMedium : string = ".MuiButton-sizeMedium"
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge : string = ".MuiButton-sizeLarge"
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth : string = ".MuiButton-fullWidth"
      /// Styles applied to the startIcon element if supplied.
      static member inline startIcon : string = ".MuiButton-startIcon"
      /// Styles applied to the endIcon element if supplied.
      static member inline endIcon : string = ".MuiButton-endIcon"
      /// Styles applied to the icon element if supplied and `size="small"`.
      static member inline iconSizeSmall : string = ".MuiButton-iconSizeSmall"
      /// Styles applied to the icon element if supplied and `size="medium"`.
      static member inline iconSizeMedium : string = ".MuiButton-iconSizeMedium"
      /// Styles applied to the icon element if supplied and `size="large"`.
      static member inline iconSizeLarge : string = ".MuiButton-iconSizeLarge"
  
  
  module buttonBase =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiButtonBase-root"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// State class applied to the root element if keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
  
  
  module buttonGroup =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiButtonGroup-root"
      /// Styles applied to the root element if `variant="contained"`.
      static member inline contained : string = ".MuiButtonGroup-contained"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiButtonGroup-outlined"
      /// Styles applied to the root element if `variant="text"`.
      static member inline text : string = ".MuiButtonGroup-text"
      /// Styles applied to the root element if `disableElevation={true}`.
      static member inline disableElevation : string = ".MuiButtonGroup-disableElevation"
      /// State class applied to the child elements if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth : string = ".MuiButtonGroup-fullWidth"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiButtonGroup-vertical"
      /// Styles applied to the children.
      static member inline grouped : string = ".MuiButtonGroup-grouped"
      /// Styles applied to the children if `orientation="horizontal"`.
      static member inline groupedHorizontal : string = ".MuiButtonGroup-groupedHorizontal"
      /// Styles applied to the children if `orientation="vertical"`.
      static member inline groupedVertical : string = ".MuiButtonGroup-groupedVertical"
      /// Styles applied to the children if `variant="text"`.
      static member inline groupedText : string = ".MuiButtonGroup-groupedText"
      /// Styles applied to the children if `variant="text"` and `orientation="horizontal"`.
      static member inline groupedTextHorizontal : string = ".MuiButtonGroup-groupedTextHorizontal"
      /// Styles applied to the children if `variant="text"` and `orientation="vertical"`.
      static member inline groupedTextVertical : string = ".MuiButtonGroup-groupedTextVertical"
      /// Styles applied to the children if `variant="text"` and `color="primary"`.
      static member inline groupedTextPrimary : string = ".MuiButtonGroup-groupedTextPrimary"
      /// Styles applied to the children if `variant="text"` and `color="secondary"`.
      static member inline groupedTextSecondary : string = ".MuiButtonGroup-groupedTextSecondary"
      /// Styles applied to the children if `variant="outlined"`.
      static member inline groupedOutlined : string = ".MuiButtonGroup-groupedOutlined"
      /// Styles applied to the children if `variant="outlined"` and `orientation="horizontal"`.
      static member inline groupedOutlinedHorizontal : string = ".MuiButtonGroup-groupedOutlinedHorizontal"
      /// Styles applied to the children if `variant="outlined"` and `orientation="vertical"`.
      static member inline groupedOutlinedVertical : string = ".MuiButtonGroup-groupedOutlinedVertical"
      /// Styles applied to the children if `variant="outlined"` and `color="primary"`.
      static member inline groupedOutlinedPrimary : string = ".MuiButtonGroup-groupedOutlinedPrimary"
      /// Styles applied to the children if `variant="outlined"` and `color="secondary"`.
      static member inline groupedOutlinedSecondary : string = ".MuiButtonGroup-groupedOutlinedSecondary"
      /// Styles applied to the children if `variant="contained"`.
      static member inline groupedContained : string = ".MuiButtonGroup-groupedContained"
      /// Styles applied to the children if `variant="contained"` and `orientation="horizontal"`.
      static member inline groupedContainedHorizontal : string = ".MuiButtonGroup-groupedContainedHorizontal"
      /// Styles applied to the children if `variant="contained"` and `orientation="vertical"`.
      static member inline groupedContainedVertical : string = ".MuiButtonGroup-groupedContainedVertical"
      /// Styles applied to the children if `variant="contained"` and `color="primary"`.
      static member inline groupedContainedPrimary : string = ".MuiButtonGroup-groupedContainedPrimary"
      /// Styles applied to the children if `variant="contained"` and `color="secondary"`.
      static member inline groupedContainedSecondary : string = ".MuiButtonGroup-groupedContainedSecondary"
  
  
  module card =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCard-root"
  
  
  module cardActionArea =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCardActionArea-root"
      /// State class applied to the ButtonBase root element if the action area is keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// Styles applied to the overlay that covers the action area when it is keyboard focused.
      static member inline focusHighlight : string = ".MuiCardActionArea-focusHighlight"
  
  
  module cardActions =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCardActions-root"
      /// Styles applied to the root element unless `disableSpacing={true}`.
      static member inline spacing : string = ".MuiCardActions-spacing"
  
  
  module cardContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCardContent-root"
  
  
  module cardHeader =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCardHeader-root"
      /// Styles applied to the avatar element.
      static member inline avatar : string = ".MuiCardHeader-avatar"
      /// Styles applied to the action element.
      static member inline action : string = ".MuiCardHeader-action"
      /// Styles applied to the content wrapper element.
      static member inline content : string = ".MuiCardHeader-content"
      /// Styles applied to the title Typography element.
      static member inline title : string = ".MuiCardHeader-title"
      /// Styles applied to the subheader Typography element.
      static member inline subheader : string = ".MuiCardHeader-subheader"
  
  
  module cardMedia =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCardMedia-root"
      /// Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.
      static member inline media : string = ".MuiCardMedia-media"
      /// Styles applied to the root element if `component="picture or img"`.
      static member inline img : string = ".MuiCardMedia-img"
  
  
  module checkbox =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCheckbox-root"
      /// State class applied to the root element if `checked={true}`.
      static member inline checked' : string = ".Mui-checked"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// State class applied to the root element if `indeterminate={true}`.
      static member inline indeterminate : string = ".MuiCheckbox-indeterminate"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiCheckbox-colorPrimary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiCheckbox-colorSecondary"
  
  
  module chip =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiChip-root"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiChip-sizeSmall"
      /// Styles applied to the root element if `size="medium"`.
      static member inline sizeMedium : string = ".MuiChip-sizeMedium"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiChip-colorPrimary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiChip-colorSecondary"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `onClick` is defined or `clickable={true}`.
      static member inline clickable : string = ".MuiChip-clickable"
      /// Styles applied to the root element if `onClick` and `color="primary"` is defined or `clickable={true}`.
      static member inline clickableColorPrimary : string = ".MuiChip-clickableColorPrimary"
      /// Styles applied to the root element if `onClick` and `color="secondary"` is defined or `clickable={true}`.
      static member inline clickableColorSecondary : string = ".MuiChip-clickableColorSecondary"
      /// Styles applied to the root element if `onDelete` is defined.
      static member inline deletable : string = ".MuiChip-deletable"
      /// Styles applied to the root element if `onDelete` and `color="primary"` is defined.
      static member inline deletableColorPrimary : string = ".MuiChip-deletableColorPrimary"
      /// Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
      static member inline deletableColorSecondary : string = ".MuiChip-deletableColorSecondary"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiChip-outlined"
      /// Styles applied to the root element if `variant="filled"`.
      static member inline filled : string = ".MuiChip-filled"
      /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
      static member inline outlinedPrimary : string = ".MuiChip-outlinedPrimary"
      /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
      static member inline outlinedSecondary : string = ".MuiChip-outlinedSecondary"
      /// Styles applied to the root element if `variant="filled"` and `color="primary"`.
      static member inline filledPrimary : string = ".MuiChip-filledPrimary"
      /// Styles applied to the root element if `variant="filled"` and `color="secondary"`.
      static member inline filledSecondary : string = ".MuiChip-filledSecondary"
      /// Styles applied to the avatar element.
      static member inline avatar : string = ".MuiChip-avatar"
      /// Styles applied to the avatar element if `size="small"`.
      static member inline avatarSmall : string = ".MuiChip-avatarSmall"
      /// Styles applied to the avatar element if `size="medium"`.
      static member inline avatarMedium : string = ".MuiChip-avatarMedium"
      /// Styles applied to the avatar element if `color="primary"`.
      static member inline avatarColorPrimary : string = ".MuiChip-avatarColorPrimary"
      /// Styles applied to the avatar element if `color="secondary"`.
      static member inline avatarColorSecondary : string = ".MuiChip-avatarColorSecondary"
      /// Styles applied to the icon element.
      static member inline icon : string = ".MuiChip-icon"
      /// Styles applied to the icon element if `size="small"`.
      static member inline iconSmall : string = ".MuiChip-iconSmall"
      /// Styles applied to the icon element if `size="medium"`.
      static member inline iconMedium : string = ".MuiChip-iconMedium"
      /// Styles applied to the icon element if `color="primary"`.
      static member inline iconColorPrimary : string = ".MuiChip-iconColorPrimary"
      /// Styles applied to the icon element if `color="secondary"`.
      static member inline iconColorSecondary : string = ".MuiChip-iconColorSecondary"
      /// Styles applied to the label `span` element.
      static member inline label : string = ".MuiChip-label"
      /// Styles applied to the label `span` element if `size="small"`.
      static member inline labelSmall : string = ".MuiChip-labelSmall"
      /// Styles applied to the label `span` element if `size="medium"`.
      static member inline labelMedium : string = ".MuiChip-labelMedium"
      /// Styles applied to the deleteIcon element.
      static member inline deleteIcon : string = ".MuiChip-deleteIcon"
      /// Styles applied to the deleteIcon element if `size="small"`.
      static member inline deleteIconSmall : string = ".MuiChip-deleteIconSmall"
      /// Styles applied to the deleteIcon element if `size="medium"`.
      static member inline deleteIconMedium : string = ".MuiChip-deleteIconMedium"
      /// Styles applied to the deleteIcon element if `color="primary"` and `variant="filled"`.
      static member inline deleteIconColorPrimary : string = ".MuiChip-deleteIconColorPrimary"
      /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="filled"`.
      static member inline deleteIconColorSecondary : string = ".MuiChip-deleteIconColorSecondary"
      /// Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
      static member inline deleteIconOutlinedColorPrimary : string = ".MuiChip-deleteIconOutlinedColorPrimary"
      /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.
      static member inline deleteIconOutlinedColorSecondary : string = ".MuiChip-deleteIconOutlinedColorSecondary"
      /// Styles applied to the deleteIcon element if `color="primary"` and `variant="filled"`.
      static member inline deleteIconFilledColorPrimary : string = ".MuiChip-deleteIconFilledColorPrimary"
      /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="filled"`.
      static member inline deleteIconFilledColorSecondary : string = ".MuiChip-deleteIconFilledColorSecondary"
      /// State class applied to the root element if keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
  
  
  module circularProgress =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCircularProgress-root"
      /// Styles applied to the root element if `variant="determinate"`.
      static member inline determinate : string = ".MuiCircularProgress-determinate"
      /// Styles applied to the root element if `variant="indeterminate"`.
      static member inline indeterminate : string = ".MuiCircularProgress-indeterminate"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiCircularProgress-colorPrimary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiCircularProgress-colorSecondary"
      /// Styles applied to the svg element.
      static member inline svg : string = ".MuiCircularProgress-svg"
      /// Styles applied to the `circle` svg path.
      static member inline circle : string = ".MuiCircularProgress-circle"
      /// Styles applied to the `circle` svg path if `variant="determinate"`.
      static member inline circleDeterminate : string = ".MuiCircularProgress-circleDeterminate"
      /// Styles applied to the `circle` svg path if `variant="indeterminate"`.
      static member inline circleIndeterminate : string = ".MuiCircularProgress-circleIndeterminate"
      /// Styles applied to the `circle` svg path if `disableShrink={true}`.
      static member inline circleDisableShrink : string = ".MuiCircularProgress-circleDisableShrink"
  
  
  module collapse =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCollapse-root"
      /// State class applied to the root element if `orientation="horizontal"`.
      static member inline horizontal : string = ".MuiCollapse-horizontal"
      /// Styles applied to the root element when the transition has entered.
      static member inline entered : string = ".MuiCollapse-entered"
      /// Styles applied to the root element when the transition has exited and `collapsedSize` = 0px.
      static member inline hidden : string = ".MuiCollapse-hidden"
      /// Styles applied to the outer wrapper element.
      static member inline wrapper : string = ".MuiCollapse-wrapper"
      /// Styles applied to the inner wrapper element.
      static member inline wrapperInner : string = ".MuiCollapse-wrapperInner"
  
  
  module container =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiContainer-root"
      /// Styles applied to the root element if `disableGutters={true}`.
      static member inline disableGutters : string = ".MuiContainer-disableGutters"
      /// Styles applied to the root element if `fixed={true}`.
      static member inline fixed' : string = ".MuiContainer-fixed"
      /// Styles applied to the root element if `maxWidth="xs"`.
      static member inline maxWidthXs : string = ".MuiContainer-maxWidthXs"
      /// Styles applied to the root element if `maxWidth="sm"`.
      static member inline maxWidthSm : string = ".MuiContainer-maxWidthSm"
      /// Styles applied to the root element if `maxWidth="md"`.
      static member inline maxWidthMd : string = ".MuiContainer-maxWidthMd"
      /// Styles applied to the root element if `maxWidth="lg"`.
      static member inline maxWidthLg : string = ".MuiContainer-maxWidthLg"
      /// Styles applied to the root element if `maxWidth="xl"`.
      static member inline maxWidthXl : string = ".MuiContainer-maxWidthXl"
  
  
  module dialog =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiDialog-root"
      /// Styles applied to the container element if `scroll="paper"`.
      static member inline scrollPaper : string = ".MuiDialog-scrollPaper"
      /// Styles applied to the container element if `scroll="body"`.
      static member inline scrollBody : string = ".MuiDialog-scrollBody"
      /// Styles applied to the container element.
      static member inline container : string = ".MuiDialog-container"
      /// Styles applied to the Paper component.
      static member inline paper : string = ".MuiDialog-paper"
      /// Styles applied to the Paper component if `scroll="paper"`.
      static member inline paperScrollPaper : string = ".MuiDialog-paperScrollPaper"
      /// Styles applied to the Paper component if `scroll="body"`.
      static member inline paperScrollBody : string = ".MuiDialog-paperScrollBody"
      /// Styles applied to the Paper component if `maxWidth=false`.
      static member inline paperWidthFalse : string = ".MuiDialog-paperWidthFalse"
      /// Styles applied to the Paper component if `maxWidth="xs"`.
      static member inline paperWidthXs : string = ".MuiDialog-paperWidthXs"
      /// Styles applied to the Paper component if `maxWidth="sm"`.
      static member inline paperWidthSm : string = ".MuiDialog-paperWidthSm"
      /// Styles applied to the Paper component if `maxWidth="md"`.
      static member inline paperWidthMd : string = ".MuiDialog-paperWidthMd"
      /// Styles applied to the Paper component if `maxWidth="lg"`.
      static member inline paperWidthLg : string = ".MuiDialog-paperWidthLg"
      /// Styles applied to the Paper component if `maxWidth="xl"`.
      static member inline paperWidthXl : string = ".MuiDialog-paperWidthXl"
      /// Styles applied to the Paper component if `fullWidth={true}`.
      static member inline paperFullWidth : string = ".MuiDialog-paperFullWidth"
      /// Styles applied to the Paper component if `fullScreen={true}`.
      static member inline paperFullScreen : string = ".MuiDialog-paperFullScreen"
  
  
  module dialogActions =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiDialogActions-root"
      /// Styles applied to the root element unless `disableSpacing={true}`.
      static member inline spacing : string = ".MuiDialogActions-spacing"
  
  
  module dialogContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiDialogContent-root"
      /// Styles applied to the root element if `dividers={true}`.
      static member inline dividers : string = ".MuiDialogContent-dividers"
  
  
  module dialogContentText =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiDialogContentText-root"
  
  
  module dialogTitle =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiDialogTitle-root"
  
  
  module divider =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiDivider-root"
      /// Styles applied to the root element if `absolute={true}`.
      static member inline absolute : string = ".MuiDivider-absolute"
      /// Styles applied to the root element if `variant="inset"`.
      static member inline inset : string = ".MuiDivider-inset"
      /// Styles applied to the root element if `variant="fullWidth"`.
      static member inline fullWidth : string = ".MuiDivider-fullWidth"
      /// Styles applied to the root element if `light={true}`.
      static member inline light : string = ".MuiDivider-light"
      /// Styles applied to the root element if `variant="middle"`.
      static member inline middle : string = ".MuiDivider-middle"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiDivider-vertical"
      /// Styles applied to the root element if `flexItem={true}`.
      static member inline flexItem : string = ".MuiDivider-flexItem"
      /// Styles applied to the root element if divider have text.
      static member inline withChildren : string = ".MuiDivider-withChildren"
      /// Styles applied to the root element if divider have text and `orientation="vertical"`.
      static member inline withChildrenVertical : string = ".MuiDivider-withChildrenVertical"
      /// Styles applied to the root element if `textAlign="right" orientation="horizontal"`.
      static member inline textAlignRight : string = ".MuiDivider-textAlignRight"
      /// Styles applied to the root element if `textAlign="left" orientation="horizontal"`.
      static member inline textAlignLeft : string = ".MuiDivider-textAlignLeft"
      /// Styles applied to the span children element if `orientation="horizontal"`.
      static member inline wrapper : string = ".MuiDivider-wrapper"
      /// Styles applied to the span children element if `orientation="vertical"`.
      static member inline wrapperVertical : string = ".MuiDivider-wrapperVertical"
  
  
  module drawer =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiDrawer-root"
      /// Styles applied to the root element if `variant="permanent or persistent"`.
      static member inline docked : string = ".MuiDrawer-docked"
      /// Styles applied to the Paper component.
      static member inline paper : string = ".MuiDrawer-paper"
      /// Styles applied to the Paper component if `anchor="left"`.
      static member inline paperAnchorLeft : string = ".MuiDrawer-paperAnchorLeft"
      /// Styles applied to the Paper component if `anchor="right"`.
      static member inline paperAnchorRight : string = ".MuiDrawer-paperAnchorRight"
      /// Styles applied to the Paper component if `anchor="top"`.
      static member inline paperAnchorTop : string = ".MuiDrawer-paperAnchorTop"
      /// Styles applied to the Paper component if `anchor="bottom"`.
      static member inline paperAnchorBottom : string = ".MuiDrawer-paperAnchorBottom"
      /// Styles applied to the Paper component if `anchor="left"` and `variant` is not "temporary".
      static member inline paperAnchorDockedLeft : string = ".MuiDrawer-paperAnchorDockedLeft"
      /// Styles applied to the Paper component if `anchor="top"` and `variant` is not "temporary".
      static member inline paperAnchorDockedTop : string = ".MuiDrawer-paperAnchorDockedTop"
      /// Styles applied to the Paper component if `anchor="right"` and `variant` is not "temporary".
      static member inline paperAnchorDockedRight : string = ".MuiDrawer-paperAnchorDockedRight"
      /// Styles applied to the Paper component if `anchor="bottom"` and `variant` is not "temporary".
      static member inline paperAnchorDockedBottom : string = ".MuiDrawer-paperAnchorDockedBottom"
      /// Styles applied to the Modal component.
      static member inline modal : string = ".MuiDrawer-modal"
  
  
  module fab =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiFab-root"
      /// Styles applied to the root element if `color="primary"`.
      static member inline primary : string = ".MuiFab-primary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline secondary : string = ".MuiFab-secondary"
      /// Styles applied to the root element if `variant="extended"`.
      static member inline extended : string = ".MuiFab-extended"
      /// Styles applied to the root element if `variant="circular"`.
      static member inline circular : string = ".MuiFab-circular"
      /// State class applied to the ButtonBase root element if the button is keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit : string = ".MuiFab-colorInherit"
      /// Styles applied to the root element if `size="small"``.
      static member inline sizeSmall : string = ".MuiFab-sizeSmall"
      /// Styles applied to the root element if `size="medium"``.
      static member inline sizeMedium : string = ".MuiFab-sizeMedium"
  
  
  module filledInput =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiFilledInput-root"
      /// Styles applied to the root element if color secondary.
      static member inline colorSecondary : string = ".MuiFilledInput-colorSecondary"
      /// Styles applied to the root element unless `disableUnderline={true}`.
      static member inline underline : string = ".MuiFilledInput-underline"
      /// State class applied to the root element if the component is focused.
      static member inline focused : string = ".Mui-focused"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `startAdornment` is provided.
      static member inline adornedStart : string = ".MuiFilledInput-adornedStart"
      /// Styles applied to the root element if `endAdornment` is provided.
      static member inline adornedEnd : string = ".MuiFilledInput-adornedEnd"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
      /// Styles applied to the input element if `size="small"`.
      static member inline sizeSmall : string = ".MuiFilledInput-sizeSmall"
      /// Styles applied to the root element if `multiline={true}`.
      static member inline multiline : string = ".MuiFilledInput-multiline"
      /// Styles applied to the root element if `hiddenLabel={true}`.
      static member inline hiddenLabel : string = ".MuiFilledInput-hiddenLabel"
      /// Styles applied to the input element.
      static member inline input : string = ".MuiFilledInput-input"
      /// Styles applied to the input element if `size="small"`.
      static member inline inputSizeSmall : string = ".MuiFilledInput-inputSizeSmall"
      /// Styles applied to the `input` if in `  `.
      static member inline inputHiddenLabel : string = ".MuiFilledInput-inputHiddenLabel"
      /// Styles applied to the input element if `multiline={true}`.
      static member inline inputMultiline : string = ".MuiFilledInput-inputMultiline"
      /// Styles applied to the input element if `startAdornment` is provided.
      static member inline inputAdornedStart : string = ".MuiFilledInput-inputAdornedStart"
      /// Styles applied to the input element if `endAdornment` is provided.
      static member inline inputAdornedEnd : string = ".MuiFilledInput-inputAdornedEnd"
  
  
  module formControl =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiFormControl-root"
      /// Styles applied to the root element if `margin="normal"`.
      static member inline marginNormal : string = ".MuiFormControl-marginNormal"
      /// Styles applied to the root element if `margin="dense"`.
      static member inline marginDense : string = ".MuiFormControl-marginDense"
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth : string = ".MuiFormControl-fullWidth"
  
  
  module formControlLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiFormControlLabel-root"
      /// Styles applied to the root element if `labelPlacement="start"`.
      static member inline labelPlacementStart : string = ".MuiFormControlLabel-labelPlacementStart"
      /// Styles applied to the root element if `labelPlacement="top"`.
      static member inline labelPlacementTop : string = ".MuiFormControlLabel-labelPlacementTop"
      /// Styles applied to the root element if `labelPlacement="bottom"`.
      static member inline labelPlacementBottom : string = ".MuiFormControlLabel-labelPlacementBottom"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the label's Typography component.
      static member inline label : string = ".MuiFormControlLabel-label"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
  
  
  module formGroup =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiFormGroup-root"
      /// Styles applied to the root element if `row={true}`.
      static member inline row : string = ".MuiFormGroup-row"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
  
  
  module formHelperText =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiFormHelperText-root"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiFormHelperText-sizeSmall"
      /// Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
      static member inline contained : string = ".MuiFormHelperText-contained"
      /// State class applied to the root element if `focused={true}`.
      static member inline focused : string = ".Mui-focused"
      /// State class applied to the root element if `filled={true}`.
      static member inline filled : string = ".MuiFormHelperText-filled"
      /// State class applied to the root element if `required={true}`.
      static member inline required : string = ".Mui-required"
  
  
  module formLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiFormLabel-root"
      /// Styles applied to the root element if the color is secondary.
      static member inline colorSecondary : string = ".MuiFormLabel-colorSecondary"
      /// State class applied to the root element if `focused={true}`.
      static member inline focused : string = ".Mui-focused"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
      /// State class applied to the root element if `filled={true}`.
      static member inline filled : string = ".MuiFormLabel-filled"
      /// State class applied to the root element if `required={true}`.
      static member inline required : string = ".Mui-required"
      /// Styles applied to the asterisk element.
      static member inline asterisk : string = ".MuiFormLabel-asterisk"
  
  
  module grid =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      static member inline root : string = ".MuiGrid-root"
      static member inline container : string = ".MuiGrid-container"
      static member inline item : string = ".MuiGrid-item"
      static member inline zeroMinWidth : string = ".MuiGrid-zeroMinWidth"
      static member inline directionXsColumn : string = ".MuiGrid-direction-xs-column"
      static member inline directionXsColumnReverse : string = ".MuiGrid-direction-xs-column-reverse"
      static member inline directionXsRowReverse : string = ".MuiGrid-direction-xs-row-reverse"
      static member inline wrapXsNowrap : string = ".MuiGrid-wrap-xs-nowrap"
      static member inline wrapXsWrapReverse : string = ".MuiGrid-wrap-xs-wrap-reverse"
      static member inline spacingXs1 : string = ".MuiGrid-spacing-xs-1"
      static member inline spacingXs2 : string = ".MuiGrid-spacing-xs-2"
      static member inline spacingXs3 : string = ".MuiGrid-spacing-xs-3"
      static member inline spacingXs4 : string = ".MuiGrid-spacing-xs-4"
      static member inline spacingXs5 : string = ".MuiGrid-spacing-xs-5"
      static member inline spacingXs6 : string = ".MuiGrid-spacing-xs-6"
      static member inline spacingXs7 : string = ".MuiGrid-spacing-xs-7"
      static member inline spacingXs8 : string = ".MuiGrid-spacing-xs-8"
      static member inline spacingXs9 : string = ".MuiGrid-spacing-xs-9"
      static member inline spacingXs10 : string = ".MuiGrid-spacing-xs-10"
      static member inline gridXsAuto : string = ".MuiGrid-grid-xs-auto"
      static member inline gridXsTrue : string = ".MuiGrid-grid-xs-true"
      static member inline gridXs1 : string = ".MuiGrid-grid-xs-1"
      static member inline gridXs2 : string = ".MuiGrid-grid-xs-2"
      static member inline gridXs3 : string = ".MuiGrid-grid-xs-3"
      static member inline gridXs4 : string = ".MuiGrid-grid-xs-4"
      static member inline gridXs5 : string = ".MuiGrid-grid-xs-5"
      static member inline gridXs6 : string = ".MuiGrid-grid-xs-6"
      static member inline gridXs7 : string = ".MuiGrid-grid-xs-7"
      static member inline gridXs8 : string = ".MuiGrid-grid-xs-8"
      static member inline gridXs9 : string = ".MuiGrid-grid-xs-9"
      static member inline gridXs10 : string = ".MuiGrid-grid-xs-10"
      static member inline gridXs11 : string = ".MuiGrid-grid-xs-11"
      static member inline gridXs12 : string = ".MuiGrid-grid-xs-12"
  
  
  module icon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiIcon-root"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiIcon-colorPrimary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiIcon-colorSecondary"
      /// Styles applied to the root element if `color="action"`.
      static member inline colorAction : string = ".MuiIcon-colorAction"
      /// Styles applied to the root element if `color="error"`.
      static member inline colorError : string = ".MuiIcon-colorError"
      /// Styles applied to the root element if `color="disabled"`.
      static member inline colorDisabled : string = ".MuiIcon-colorDisabled"
      /// Styles applied to the root element if `fontSize="inherit"`.
      static member inline fontSizeInherit : string = ".MuiIcon-fontSizeInherit"
      /// Styles applied to the root element if `fontSize="small"`.
      static member inline fontSizeSmall : string = ".MuiIcon-fontSizeSmall"
      /// Styles applied to the root element if `fontSize="large"`.
      static member inline fontSizeLarge : string = ".MuiIcon-fontSizeLarge"
  
  
  module iconButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiIconButton-root"
      /// Styles applied to the root element if `edge="start"`.
      static member inline edgeStart : string = ".MuiIconButton-edgeStart"
      /// Styles applied to the root element if `edge="end"`.
      static member inline edgeEnd : string = ".MuiIconButton-edgeEnd"
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit : string = ".MuiIconButton-colorInherit"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiIconButton-colorPrimary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiIconButton-colorSecondary"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiIconButton-sizeSmall"
      /// Styles applied to the root element if `size="medium"`.
      static member inline sizeMedium : string = ".MuiIconButton-sizeMedium"
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge : string = ".MuiIconButton-sizeLarge"
  
  
  module imageList =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiImageList-root"
      /// Styles applied to the root element if `variant="masonry"`.
      static member inline masonry : string = ".MuiImageList-masonry"
      /// Styles applied to the root element if `variant="quilted"`.
      static member inline quilted : string = ".MuiImageList-quilted"
      /// Styles applied to the root element if `variant="standard"`.
      static member inline standard : string = ".MuiImageList-standard"
      /// Styles applied to the root element if `variant="woven"`.
      static member inline woven : string = ".MuiImageList-woven"
  
  
  module imageListItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiImageListItem-root"
      /// Styles applied to an `img` element to ensure it covers the item.
      static member inline img : string = ".MuiImageListItem-img"
      /// Styles applied to the root element if `variant="standard"`.
      static member inline standard : string = ".MuiImageListItem-standard"
      /// Styles applied to the root element if `variant="woven"`.
      static member inline woven : string = ".MuiImageListItem-woven"
      /// Styles applied to the root element if `variant="masonry"`.
      static member inline masonry : string = ".MuiImageListItem-masonry"
      /// Styles applied to the root element if `variant="quilted"`.
      static member inline quilted : string = ".MuiImageListItem-quilted"
  
  
  module imageListItemBar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiImageListItemBar-root"
      /// Styles applied to the root element if `position="bottom"`.
      static member inline positionBottom : string = ".MuiImageListItemBar-positionBottom"
      /// Styles applied to the root element if `position="top"`.
      static member inline positionTop : string = ".MuiImageListItemBar-positionTop"
      /// Styles applied to the root element if `position="below"`.
      static member inline positionBelow : string = ".MuiImageListItemBar-positionBelow"
      /// Styles applied to the title and subtitle container element.
      static member inline titleWrap : string = ".MuiImageListItemBar-titleWrap"
      /// Styles applied to the title and subtitle container element if `position="below"`.
      static member inline titleWrapBelow : string = ".MuiImageListItemBar-titleWrapBelow"
      /// Styles applied to the container element if `actionPosition="left"`.
      static member inline titleWrapActionPosLeft : string = ".MuiImageListItemBar-titleWrapActionPosLeft"
      /// Styles applied to the container element if `actionPosition="right"`.
      static member inline titleWrapActionPosRight : string = ".MuiImageListItemBar-titleWrapActionPosRight"
      /// Styles applied to the title container element.
      static member inline title : string = ".MuiImageListItemBar-title"
      /// Styles applied to the subtitle container element.
      static member inline subtitle : string = ".MuiImageListItemBar-subtitle"
      /// Styles applied to the actionIcon if supplied.
      static member inline actionIcon : string = ".MuiImageListItemBar-actionIcon"
      /// Styles applied to the actionIcon if `actionPosition="left"`.
      static member inline actionIconActionPosLeft : string = ".MuiImageListItemBar-actionIconActionPosLeft"
  
  
  module input =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiInput-root"
      /// Styles applied to the root element if the component is a descendant of `FormControl`.
      static member inline formControl : string = ".MuiInput-formControl"
      /// Styles applied to the root element if the component is focused.
      static member inline focused : string = ".Mui-focused"
      /// Styles applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if color secondary.
      static member inline colorSecondary : string = ".MuiInput-colorSecondary"
      /// Styles applied to the root element unless `disableUnderline={true}`.
      static member inline underline : string = ".MuiInput-underline"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
      /// Styles applied to the input element if `size="small"`.
      static member inline sizeSmall : string = ".MuiInput-sizeSmall"
      /// Styles applied to the root element if `multiline={true}`.
      static member inline multiline : string = ".MuiInput-multiline"
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth : string = ".MuiInput-fullWidth"
      /// Styles applied to the input element.
      static member inline input : string = ".MuiInput-input"
      /// Styles applied to the input element if `size="small"`.
      static member inline inputSizeSmall : string = ".MuiInput-inputSizeSmall"
      /// Styles applied to the input element if `multiline={true}`.
      static member inline inputMultiline : string = ".MuiInput-inputMultiline"
      /// Styles applied to the input element if `type="search"`.
      static member inline inputTypeSearch : string = ".MuiInput-inputTypeSearch"
  
  
  module inputAdornment =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiInputAdornment-root"
      /// Styles applied to the root element if `variant="filled"`.
      static member inline filled : string = ".MuiInputAdornment-filled"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiInputAdornment-outlined"
      /// Styles applied to the root element if `variant="standard"`.
      static member inline standard : string = ".MuiInputAdornment-standard"
      /// Styles applied to the root element if `position="start"`.
      static member inline positionStart : string = ".MuiInputAdornment-positionStart"
      /// Styles applied to the root element if `position="end"`.
      static member inline positionEnd : string = ".MuiInputAdornment-positionEnd"
      /// Styles applied to the root element if `disablePointerEvents={true}`.
      static member inline disablePointerEvents : string = ".MuiInputAdornment-disablePointerEvents"
      /// Styles applied if the adornment is used inside <formcontrol hiddenlabel=""></formcontrol>.
      static member inline hiddenLabel : string = ".MuiInputAdornment-hiddenLabel"
      /// Styles applied if the adornment is used inside <formcontrol size="small"></formcontrol>.
      static member inline sizeSmall : string = ".MuiInputAdornment-sizeSmall"
  
  
  module inputBase =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiInputBase-root"
      /// Styles applied to the root element if the component is a descendant of `FormControl`.
      static member inline formControl : string = ".MuiInputBase-formControl"
      /// Styles applied to the root element if the component is focused.
      static member inline focused : string = ".Mui-focused"
      /// Styles applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `startAdornment` is provided.
      static member inline adornedStart : string = ".MuiInputBase-adornedStart"
      /// Styles applied to the root element if `endAdornment` is provided.
      static member inline adornedEnd : string = ".MuiInputBase-adornedEnd"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
      /// Styles applied to the input element if `size="small"`.
      static member inline sizeSmall : string = ".MuiInputBase-sizeSmall"
      /// Styles applied to the root element if `multiline={true}`.
      static member inline multiline : string = ".MuiInputBase-multiline"
      /// Styles applied to the root element if the color is secondary.
      static member inline colorSecondary : string = ".MuiInputBase-colorSecondary"
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth : string = ".MuiInputBase-fullWidth"
      /// Styles applied to the root element if `hiddenLabel={true}`.
      static member inline hiddenLabel : string = ".MuiInputBase-hiddenLabel"
      /// State class applied to the root element if `readOnly={true}`.
      static member inline readOnly : string = ".MuiInputBase-readOnly"
      /// Styles applied to the input element.
      static member inline input : string = ".MuiInputBase-input"
      /// Styles applied to the input element if `size="small"`.
      static member inline inputSizeSmall : string = ".MuiInputBase-inputSizeSmall"
      /// Styles applied to the input element if `multiline={true}`.
      static member inline inputMultiline : string = ".MuiInputBase-inputMultiline"
      /// Styles applied to the input element if `type="search"`.
      static member inline inputTypeSearch : string = ".MuiInputBase-inputTypeSearch"
      /// Styles applied to the input element if `startAdornment` is provided.
      static member inline inputAdornedStart : string = ".MuiInputBase-inputAdornedStart"
      /// Styles applied to the input element if `endAdornment` is provided.
      static member inline inputAdornedEnd : string = ".MuiInputBase-inputAdornedEnd"
      /// Styles applied to the input element if `hiddenLabel={true}`.
      static member inline inputHiddenLabel : string = ".MuiInputBase-inputHiddenLabel"
  
  
  module inputLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiInputLabel-root"
      /// State class applied to the root element if `focused={true}`.
      static member inline focused : string = ".Mui-focused"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
      /// State class applied to the root element if `required={true}`.
      static member inline required : string = ".Mui-required"
      /// State class applied to the asterisk element.
      static member inline asterisk : string = ".MuiInputLabel-asterisk"
      /// Styles applied to the root element if the component is a descendant of `FormControl`.
      static member inline formControl : string = ".MuiInputLabel-formControl"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiInputLabel-sizeSmall"
      /// Styles applied to the input element if `shrink={true}`.
      static member inline shrink : string = ".MuiInputLabel-shrink"
      /// Styles applied to the input element unless `disableAnimation={true}`.
      static member inline animated : string = ".MuiInputLabel-animated"
      /// Styles applied to the root element if `variant="filled"`.
      static member inline filled : string = ".MuiInputLabel-filled"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiInputLabel-outlined"
      /// Styles applied to the root element if `variant="standard"`.
      static member inline standard : string = ".MuiInputLabel-standard"
  
  
  module linearProgress =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiLinearProgress-root"
      /// Styles applied to the root and bar2 element if `color="primary"`; bar2 if `variant="buffer"`.
      static member inline colorPrimary : string = ".MuiLinearProgress-colorPrimary"
      /// Styles applied to the root and bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
      static member inline colorSecondary : string = ".MuiLinearProgress-colorSecondary"
      /// Styles applied to the root element if `variant="determinate"`.
      static member inline determinate : string = ".MuiLinearProgress-determinate"
      /// Styles applied to the root element if `variant="indeterminate"`.
      static member inline indeterminate : string = ".MuiLinearProgress-indeterminate"
      /// Styles applied to the root element if `variant="buffer"`.
      static member inline buffer : string = ".MuiLinearProgress-buffer"
      /// Styles applied to the root element if `variant="query"`.
      static member inline query : string = ".MuiLinearProgress-query"
      /// Styles applied to the additional bar element if `variant="buffer"`.
      static member inline dashed : string = ".MuiLinearProgress-dashed"
      /// Styles applied to the additional bar element if `variant="buffer"` and `color="primary"`.
      static member inline dashedColorPrimary : string = ".MuiLinearProgress-dashedColorPrimary"
      /// Styles applied to the additional bar element if `variant="buffer"` and `color="secondary"`.
      static member inline dashedColorSecondary : string = ".MuiLinearProgress-dashedColorSecondary"
      /// Styles applied to the layered bar1 and bar2 elements.
      static member inline bar : string = ".MuiLinearProgress-bar"
      /// Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
      static member inline barColorPrimary : string = ".MuiLinearProgress-barColorPrimary"
      /// Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
      static member inline barColorSecondary : string = ".MuiLinearProgress-barColorSecondary"
      /// Styles applied to the bar1 element if `variant="indeterminate or query"`.
      static member inline bar1Indeterminate : string = ".MuiLinearProgress-bar1Indeterminate"
      /// Styles applied to the bar1 element if `variant="determinate"`.
      static member inline bar1Determinate : string = ".MuiLinearProgress-bar1Determinate"
      /// Styles applied to the bar1 element if `variant="buffer"`.
      static member inline bar1Buffer : string = ".MuiLinearProgress-bar1Buffer"
      /// Styles applied to the bar2 element if `variant="indeterminate or query"`.
      static member inline bar2Indeterminate : string = ".MuiLinearProgress-bar2Indeterminate"
      /// Styles applied to the bar2 element if `variant="buffer"`.
      static member inline bar2Buffer : string = ".MuiLinearProgress-bar2Buffer"
  
  
  module link =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiLink-root"
      /// Styles applied to the root element if `underline="none"`.
      static member inline underlineNone : string = ".MuiLink-underlineNone"
      /// Styles applied to the root element if `underline="hover"`.
      static member inline underlineHover : string = ".MuiLink-underlineHover"
      /// Styles applied to the root element if `underline="always"`.
      static member inline underlineAlways : string = ".MuiLink-underlineAlways"
      /// Styles applied to the root element if `component="button"`.
      static member inline button : string = ".MuiLink-button"
      /// State class applied to the root element if the link is keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
  
    /// `classes` prop applied to the
    ///
    ///   [`Typography`](https://mui.com/material-ui/api/typography/) element.
    [<Erase>]
    type TypographyClasses =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTypography-root"
      /// Styles applied to the root element if `variant="body2"`.
      static member inline body2 : string = ".MuiTypography-body2"
      /// Styles applied to the root element if `variant="body1"`.
      static member inline body1 : string = ".MuiTypography-body1"
      /// Styles applied to the root element if `variant="caption"`.
      static member inline caption : string = ".MuiTypography-caption"
      /// Styles applied to the root element if `variant="button"`.
      static member inline button : string = ".MuiTypography-button"
      /// Styles applied to the root element if `variant="h1"`.
      static member inline h1 : string = ".MuiTypography-h1"
      /// Styles applied to the root element if `variant="h2"`.
      static member inline h2 : string = ".MuiTypography-h2"
      /// Styles applied to the root element if `variant="h3"`.
      static member inline h3 : string = ".MuiTypography-h3"
      /// Styles applied to the root element if `variant="h4"`.
      static member inline h4 : string = ".MuiTypography-h4"
      /// Styles applied to the root element if `variant="h5"`.
      static member inline h5 : string = ".MuiTypography-h5"
      /// Styles applied to the root element if `variant="h6"`.
      static member inline h6 : string = ".MuiTypography-h6"
      /// Styles applied to the root element if `variant="subtitle1"`.
      static member inline subtitle1 : string = ".MuiTypography-subtitle1"
      /// Styles applied to the root element if `variant="subtitle2"`.
      static member inline subtitle2 : string = ".MuiTypography-subtitle2"
      /// Styles applied to the root element if `variant="overline"`.
      static member inline overline : string = ".MuiTypography-overline"
      /// Styles applied to the root element if `variant="inherit"`.
      static member inline inherit' : string = ".MuiTypography-inherit"
      /// Styles applied to the root element if `align="left"`.
      static member inline alignLeft : string = ".MuiTypography-alignLeft"
      /// Styles applied to the root element if `align="center"`.
      static member inline alignCenter : string = ".MuiTypography-alignCenter"
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight : string = ".MuiTypography-alignRight"
      /// Styles applied to the root element if `align="justify"`.
      static member inline alignJustify : string = ".MuiTypography-alignJustify"
      /// Styles applied to the root element if `nowrap={true}`.
      static member inline noWrap : string = ".MuiTypography-noWrap"
      /// Styles applied to the root element if `gutterBottom={true}`.
      static member inline gutterBottom : string = ".MuiTypography-gutterBottom"
      /// Styles applied to the root element if `paragraph={true}`.
      static member inline paragraph : string = ".MuiTypography-paragraph"
  
  
  module list =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiList-root"
      /// Styles applied to the root element unless `disablePadding={true}`.
      static member inline padding : string = ".MuiList-padding"
      /// Styles applied to the root element if dense.
      static member inline dense : string = ".MuiList-dense"
      /// Styles applied to the root element if a `subheader` is provided.
      static member inline subheader : string = ".MuiList-subheader"
  
  
  module listItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
      static member inline root : string = ".MuiListItem-root"
      /// Styles applied to the container element if `children` includes `ListItemSecondaryAction`.
      static member inline container : string = ".MuiListItem-container"
      /// State class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// Styles applied to the component element if dense.
      static member inline dense : string = ".MuiListItem-dense"
      /// Styles applied to the component element if `alignItems="flex-start"`.
      static member inline alignItemsFlexStart : string = ".MuiListItem-alignItemsFlexStart"
      /// State class applied to the inner `component` element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the inner `component` element if `divider={true}`.
      static member inline divider : string = ".MuiListItem-divider"
      /// Styles applied to the inner `component` element unless `disableGutters={true}`.
      static member inline gutters : string = ".MuiListItem-gutters"
      /// Styles applied to the root element unless `disablePadding={true}`.
      static member inline padding : string = ".MuiListItem-padding"
      /// Styles applied to the inner `component` element if `button={true}`.
      static member inline button : string = ".MuiListItem-button"
      /// Styles applied to the component element if `children` includes `ListItemSecondaryAction`.
      static member inline secondaryAction : string = ".MuiListItem-secondaryAction"
      /// State class applied to the root element if `selected={true}`.
      static member inline selected : string = ".Mui-selected"
  
  
  module listItemAvatar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiListItemAvatar-root"
      /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
      static member inline alignItemsFlexStart : string = ".MuiListItemAvatar-alignItemsFlexStart"
  
  
  module listItemButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiListItemButton-root"
      /// State class applied to the `component`'s `focusVisibleClassName` prop.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// Styles applied to the component element if dense.
      static member inline dense : string = ".MuiListItemButton-dense"
      /// Styles applied to the component element if `alignItems="flex-start"`.
      static member inline alignItemsFlexStart : string = ".MuiListItemButton-alignItemsFlexStart"
      /// State class applied to the inner `component` element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the inner `component` element if `divider={true}`.
      static member inline divider : string = ".MuiListItemButton-divider"
      /// Styles applied to the inner `component` element unless `disableGutters={true}`.
      static member inline gutters : string = ".MuiListItemButton-gutters"
      /// State class applied to the root element if `selected={true}`.
      static member inline selected : string = ".Mui-selected"
  
  
  module listItemIcon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiListItemIcon-root"
      /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
      static member inline alignItemsFlexStart : string = ".MuiListItemIcon-alignItemsFlexStart"
  
  
  module listItemSecondaryAction =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiListItemSecondaryAction-root"
      /// Styles applied to the root element when the parent `ListItem` has `disableGutters={true}`.
      static member inline disableGutters : string = ".MuiListItemSecondaryAction-disableGutters"
  
  
  module listItemText =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiListItemText-root"
      /// Styles applied to the Typography component if primary and secondary are set.
      static member inline multiline : string = ".MuiListItemText-multiline"
      /// Styles applied to the Typography component if dense.
      static member inline dense : string = ".MuiListItemText-dense"
      /// Styles applied to the root element if `inset={true}`.
      static member inline inset : string = ".MuiListItemText-inset"
      /// Styles applied to the primary `Typography` component.
      static member inline primary : string = ".MuiListItemText-primary"
      /// Styles applied to the secondary `Typography` component.
      static member inline secondary : string = ".MuiListItemText-secondary"
  
  
  module listSubheader =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiListSubheader-root"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiListSubheader-colorPrimary"
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit : string = ".MuiListSubheader-colorInherit"
      /// Styles applied to the inner `component` element unless `disableGutters={true}`.
      static member inline gutters : string = ".MuiListSubheader-gutters"
      /// Styles applied to the root element if `inset={true}`.
      static member inline inset : string = ".MuiListSubheader-inset"
      /// Styles applied to the root element unless `disableSticky={true}`.
      static member inline sticky : string = ".MuiListSubheader-sticky"
  
  
  module loadingButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiLoadingButton-root"
      /// Styles applied to the root element if `variant="text"`.
      static member inline text : string = ".MuiLoadingButton-text"
      /// Styles applied to the root element if `variant="text"` and `color="inherit"`.
      static member inline textInherit : string = ".MuiLoadingButton-textInherit"
      /// Styles applied to the root element if `variant="text"` and `color="primary"`.
      static member inline textPrimary : string = ".MuiLoadingButton-textPrimary"
      /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
      static member inline textSecondary : string = ".MuiLoadingButton-textSecondary"
      /// Styles applied to the root element if `variant="text"` and `color="success"`.
      static member inline textSuccess : string = ".MuiLoadingButton-textSuccess"
      /// Styles applied to the root element if `variant="text"` and `color="error"`.
      static member inline textError : string = ".MuiLoadingButton-textError"
      /// Styles applied to the root element if `variant="text"` and `color="info"`.
      static member inline textInfo : string = ".MuiLoadingButton-textInfo"
      /// Styles applied to the root element if `variant="text"` and `color="warning"`.
      static member inline textWarning : string = ".MuiLoadingButton-textWarning"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiLoadingButton-outlined"
      /// Styles applied to the root element if `variant="outlined"` and `color="inherit"`.
      static member inline outlinedInherit : string = ".MuiLoadingButton-outlinedInherit"
      /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
      static member inline outlinedPrimary : string = ".MuiLoadingButton-outlinedPrimary"
      /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
      static member inline outlinedSecondary : string = ".MuiLoadingButton-outlinedSecondary"
      /// Styles applied to the root element if `variant="outlined"` and `color="success"`.
      static member inline outlinedSuccess : string = ".MuiLoadingButton-outlinedSuccess"
      /// Styles applied to the root element if `variant="outlined"` and `color="error"`.
      static member inline outlinedError : string = ".MuiLoadingButton-outlinedError"
      /// Styles applied to the root element if `variant="outlined"` and `color="info"`.
      static member inline outlinedInfo : string = ".MuiLoadingButton-outlinedInfo"
      /// Styles applied to the root element if `variant="outlined"` and `color="warning"`.
      static member inline outlinedWarning : string = ".MuiLoadingButton-outlinedWarning"
      /// Styles applied to the root element if `variant="contained"`.
      static member inline contained : string = ".MuiLoadingButton-contained"
      /// Styles applied to the root element if `variant="contained"` and `color="inherit"`.
      static member inline containedInherit : string = ".MuiLoadingButton-containedInherit"
      /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
      static member inline containedPrimary : string = ".MuiLoadingButton-containedPrimary"
      /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
      static member inline containedSecondary : string = ".MuiLoadingButton-containedSecondary"
      /// Styles applied to the root element if `variant="contained"` and `color="success"`.
      static member inline containedSuccess : string = ".MuiLoadingButton-containedSuccess"
      /// Styles applied to the root element if `variant="contained"` and `color="info"`.
      static member inline containedInfo : string = ".MuiLoadingButton-containedInfo"
      /// Styles applied to the root element if `variant="contained"` and `color="error"`.
      static member inline containedError : string = ".MuiLoadingButton-containedError"
      /// Styles applied to the root element if `variant="contained"` and `color="warning"`.
      static member inline containedWarning : string = ".MuiLoadingButton-containedWarning"
      /// Styles applied to the root element if `disableElevation={true}`.
      static member inline disableElevation : string = ".MuiLoadingButton-disableElevation"
      /// State class applied to the ButtonBase root element if the button is keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `color="inherit"`.
      static member inline colorInherit : string = ".MuiLoadingButton-colorInherit"
      /// Styles applied to the root element if `size="small"` and `variant="text"`.
      static member inline textSizeSmall : string = ".MuiLoadingButton-textSizeSmall"
      /// Styles applied to the root element if `size="medium"` and `variant="text"`.
      static member inline textSizeMedium : string = ".MuiLoadingButton-textSizeMedium"
      /// Styles applied to the root element if `size="large"` and `variant="text"`.
      static member inline textSizeLarge : string = ".MuiLoadingButton-textSizeLarge"
      /// Styles applied to the root element if `size="small"` and `variant="outlined"`.
      static member inline outlinedSizeSmall : string = ".MuiLoadingButton-outlinedSizeSmall"
      /// Styles applied to the root element if `size="medium"` and `variant="outlined"`.
      static member inline outlinedSizeMedium : string = ".MuiLoadingButton-outlinedSizeMedium"
      /// Styles applied to the root element if `size="large"` and `variant="outlined"`.
      static member inline outlinedSizeLarge : string = ".MuiLoadingButton-outlinedSizeLarge"
      /// Styles applied to the root element if `size="small"` and `variant="contained"`.
      static member inline containedSizeSmall : string = ".MuiLoadingButton-containedSizeSmall"
      /// Styles applied to the root element if `size="medium"` and `variant="contained"`.
      static member inline containedSizeMedium : string = ".MuiLoadingButton-containedSizeMedium"
      /// Styles applied to the root element if `size="large"` and `variant="contained"`.
      static member inline containedSizeLarge : string = ".MuiLoadingButton-containedSizeLarge"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiLoadingButton-sizeSmall"
      /// Styles applied to the root element if `size="medium"`.
      static member inline sizeMedium : string = ".MuiLoadingButton-sizeMedium"
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge : string = ".MuiLoadingButton-sizeLarge"
      /// Styles applied to the root element if `fullWidth={true}`.
      static member inline fullWidth : string = ".MuiLoadingButton-fullWidth"
      /// Styles applied to the startIcon element if supplied.
      static member inline startIcon : string = ".MuiLoadingButton-startIcon"
      /// Styles applied to the endIcon element if supplied.
      static member inline endIcon : string = ".MuiLoadingButton-endIcon"
      /// Styles applied to the icon element if supplied and `size="small"`.
      static member inline iconSizeSmall : string = ".MuiLoadingButton-iconSizeSmall"
      /// Styles applied to the icon element if supplied and `size="medium"`.
      static member inline iconSizeMedium : string = ".MuiLoadingButton-iconSizeMedium"
      /// Styles applied to the icon element if supplied and `size="large"`.
      static member inline iconSizeLarge : string = ".MuiLoadingButton-iconSizeLarge"
      /// Styles applied to the root element if `loading={true}`.
      static member inline loading : string = ".MuiLoadingButton-loading"
      /// Styles applied to the loadingIndicator element.
      static member inline loadingIndicator : string = ".MuiLoadingButton-loadingIndicator"
      /// Styles applied to the loadingIndicator element if `loadingPosition="center"`.
      static member inline loadingIndicatorCenter : string = ".MuiLoadingButton-loadingIndicatorCenter"
      /// Styles applied to the loadingIndicator element if `loadingPosition="start"`.
      static member inline loadingIndicatorStart : string = ".MuiLoadingButton-loadingIndicatorStart"
      /// Styles applied to the loadingIndicator element if `loadingPosition="end"`.
      static member inline loadingIndicatorEnd : string = ".MuiLoadingButton-loadingIndicatorEnd"
      /// Styles applied to the endIcon element if `loading={true}` and `loadingPosition="end"`.
      static member inline endIconLoadingEnd : string = ".MuiLoadingButton-endIconLoadingEnd"
      /// Styles applied to the startIcon element if `loading={true}` and `loadingPosition="start"`.
      static member inline startIconLoadingStart : string = ".MuiLoadingButton-startIconLoadingStart"
  
  
  module masonry =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiMasonry-root"
  
  
  module menu =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiMenu-root"
      /// Styles applied to the Paper component.
      static member inline paper : string = ".MuiMenu-paper"
      /// Styles applied to the List component via `MenuList`.
      static member inline list : string = ".MuiMenu-list"
  
    /// `classes` prop applied to the
    ///
    ///   [`Popover`](https://mui.com/material-ui/api/popover/) element.
    [<Erase>]
    type PopoverClasses =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiPopover-root"
      /// Styles applied to the Paper component.
      static member inline paper : string = ".MuiPopover-paper"
  
  
  module menuItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiMenuItem-root"
      /// State class applied to the root element if keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// Styles applied to the root element if dense.
      static member inline dense : string = ".MuiMenuItem-dense"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `divider={true}`.
      static member inline divider : string = ".MuiMenuItem-divider"
      /// Styles applied to the inner `component` element unless `disableGutters={true}`.
      static member inline gutters : string = ".MuiMenuItem-gutters"
      /// State class applied to the root element if `selected={true}`.
      static member inline selected : string = ".Mui-selected"
  
  
  module mobileStepper =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiMobileStepper-root"
      /// Styles applied to the root element if `position="bottom"`.
      static member inline positionBottom : string = ".MuiMobileStepper-positionBottom"
      /// Styles applied to the root element if `position="top"`.
      static member inline positionTop : string = ".MuiMobileStepper-positionTop"
      /// Styles applied to the root element if `position="static"`.
      static member inline positionStatic : string = ".MuiMobileStepper-positionStatic"
      /// Styles applied to the dots container if `variant="dots"`.
      static member inline dots : string = ".MuiMobileStepper-dots"
      /// Styles applied to each dot if `variant="dots"`.
      static member inline dot : string = ".MuiMobileStepper-dot"
      /// Styles applied to a dot if `variant="dots"` and this is the active step.
      static member inline dotActive : string = ".MuiMobileStepper-dotActive"
      /// Styles applied to the Linear Progress component if `variant="progress"`.
      static member inline progress : string = ".MuiMobileStepper-progress"
  
  
  module modal =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiModal-root"
      /// Styles applied to the root element if the `Modal` has exited.
      static member inline hidden : string = ".MuiModal-hidden"
  
  
  module nativeSelect =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiNativeSelect-root"
      /// Styles applied to the select component `select` class.
      static member inline select : string = ".MuiNativeSelect-select"
      /// Styles applied to the select component if `multiple={true}`.
      static member inline multiple : string = ".MuiNativeSelect-multiple"
      /// Styles applied to the select component if `variant="filled"`.
      static member inline filled : string = ".MuiNativeSelect-filled"
      /// Styles applied to the select component if `variant="outlined"`.
      static member inline outlined : string = ".MuiNativeSelect-outlined"
      /// Styles applied to the select component if `variant="standard"`.
      static member inline standard : string = ".MuiNativeSelect-standard"
      /// State class applied to the select component `disabled` class.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the icon component.
      static member inline icon : string = ".MuiNativeSelect-icon"
      /// Styles applied to the icon component if the popup is open.
      static member inline iconOpen : string = ".MuiNativeSelect-iconOpen"
      /// Styles applied to the icon component if `variant="filled"`.
      static member inline iconFilled : string = ".MuiNativeSelect-iconFilled"
      /// Styles applied to the icon component if `variant="outlined"`.
      static member inline iconOutlined : string = ".MuiNativeSelect-iconOutlined"
      /// Styles applied to the icon component if `variant="standard"`.
      static member inline iconStandard : string = ".MuiNativeSelect-iconStandard"
      /// Styles applied to the underlying native input component.
      static member inline nativeInput : string = ".MuiNativeSelect-nativeInput"
  
  
  module outlinedInput =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiOutlinedInput-root"
      /// Styles applied to the root element if the color is secondary.
      static member inline colorSecondary : string = ".MuiOutlinedInput-colorSecondary"
      /// Styles applied to the root element if the component is focused.
      static member inline focused : string = ".Mui-focused"
      /// Styles applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `startAdornment` is provided.
      static member inline adornedStart : string = ".MuiOutlinedInput-adornedStart"
      /// Styles applied to the root element if `endAdornment` is provided.
      static member inline adornedEnd : string = ".MuiOutlinedInput-adornedEnd"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
      /// Styles applied to the input element if `size="small"`.
      static member inline sizeSmall : string = ".MuiOutlinedInput-sizeSmall"
      /// Styles applied to the root element if `multiline={true}`.
      static member inline multiline : string = ".MuiOutlinedInput-multiline"
      /// Styles applied to the NotchedOutline element.
      static member inline notchedOutline : string = ".MuiOutlinedInput-notchedOutline"
      /// Styles applied to the input element.
      static member inline input : string = ".MuiOutlinedInput-input"
      /// Styles applied to the input element if `size="small"`.
      static member inline inputSizeSmall : string = ".MuiOutlinedInput-inputSizeSmall"
      /// Styles applied to the input element if `multiline={true}`.
      static member inline inputMultiline : string = ".MuiOutlinedInput-inputMultiline"
      /// Styles applied to the input element if `startAdornment` is provided.
      static member inline inputAdornedStart : string = ".MuiOutlinedInput-inputAdornedStart"
      /// Styles applied to the input element if `endAdornment` is provided.
      static member inline inputAdornedEnd : string = ".MuiOutlinedInput-inputAdornedEnd"
  
  
  module pagination =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiPagination-root"
      /// Styles applied to the ul element.
      static member inline ul : string = ".MuiPagination-ul"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiPagination-outlined"
      /// Styles applied to the root element if `variant="text"`.
      static member inline text : string = ".MuiPagination-text"
  
  
  module paginationItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiPaginationItem-root"
      /// Styles applied to the root element if `type="page"`.
      static member inline page : string = ".MuiPaginationItem-page"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiPaginationItem-sizeSmall"
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge : string = ".MuiPaginationItem-sizeLarge"
      /// Styles applied to the root element if `variant="text"`.
      static member inline text : string = ".MuiPaginationItem-text"
      /// Styles applied to the root element if `variant="text"` and `color="primary"`.
      static member inline textPrimary : string = ".MuiPaginationItem-textPrimary"
      /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
      static member inline textSecondary : string = ".MuiPaginationItem-textSecondary"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiPaginationItem-outlined"
      /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
      static member inline outlinedPrimary : string = ".MuiPaginationItem-outlinedPrimary"
      /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
      static member inline outlinedSecondary : string = ".MuiPaginationItem-outlinedSecondary"
      /// Styles applied to the root element if `rounded="true"`.
      static member inline rounded : string = ".MuiPaginationItem-rounded"
      /// Styles applied to the root element if `type="start-ellipsis"` or `type="end-ellipsis"`.
      static member inline ellipsis : string = ".MuiPaginationItem-ellipsis"
      /// Styles applyed to the root element if `type="first"` or type="last".
      static member inline firstLast : string = ".MuiPaginationItem-firstLast"
      /// Styles applyed to the root element if `type="previous"` or type="next".
      static member inline previousNext : string = ".MuiPaginationItem-previousNext"
      /// State class applied to the root element if keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// State class applied to the root element if `selected={true}`.
      static member inline selected : string = ".Mui-selected"
      /// Styles applied to the icon to display.
      static member inline icon : string = ".MuiPaginationItem-icon"
  
  
  module paper =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiPaper-root"
      /// Styles applied to the root element unless `square={true}`.
      static member inline rounded : string = ".MuiPaper-rounded"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiPaper-outlined"
      /// Styles applied to the root element if `variant="elevation"`.
      static member inline elevation : string = ".MuiPaper-elevation"
      static member inline elevation0 : string = ".MuiPaper-elevation0"
      static member inline elevation1 : string = ".MuiPaper-elevation1"
      static member inline elevation2 : string = ".MuiPaper-elevation2"
      static member inline elevation3 : string = ".MuiPaper-elevation3"
      static member inline elevation4 : string = ".MuiPaper-elevation4"
      static member inline elevation5 : string = ".MuiPaper-elevation5"
      static member inline elevation6 : string = ".MuiPaper-elevation6"
      static member inline elevation7 : string = ".MuiPaper-elevation7"
      static member inline elevation8 : string = ".MuiPaper-elevation8"
      static member inline elevation9 : string = ".MuiPaper-elevation9"
      static member inline elevation10 : string = ".MuiPaper-elevation10"
      static member inline elevation11 : string = ".MuiPaper-elevation11"
      static member inline elevation12 : string = ".MuiPaper-elevation12"
      static member inline elevation13 : string = ".MuiPaper-elevation13"
      static member inline elevation14 : string = ".MuiPaper-elevation14"
      static member inline elevation15 : string = ".MuiPaper-elevation15"
      static member inline elevation16 : string = ".MuiPaper-elevation16"
      static member inline elevation17 : string = ".MuiPaper-elevation17"
      static member inline elevation18 : string = ".MuiPaper-elevation18"
      static member inline elevation19 : string = ".MuiPaper-elevation19"
      static member inline elevation20 : string = ".MuiPaper-elevation20"
      static member inline elevation21 : string = ".MuiPaper-elevation21"
      static member inline elevation22 : string = ".MuiPaper-elevation22"
      static member inline elevation23 : string = ".MuiPaper-elevation23"
      static member inline elevation24 : string = ".MuiPaper-elevation24"
  
  
  module popover =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiPopover-root"
      /// Styles applied to the Paper component.
      static member inline paper : string = ".MuiPopover-paper"
  
  
  module radio =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiRadio-root"
      /// State class applied to the root element if `checked={true}`.
      static member inline checked' : string = ".Mui-checked"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiRadio-colorPrimary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiRadio-colorSecondary"
  
  
  module rating =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiRating-root"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiRating-sizeSmall"
      /// Styles applied to the root element if `size="medium"`.
      static member inline sizeMedium : string = ".MuiRating-sizeMedium"
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge : string = ".MuiRating-sizeLarge"
      /// Styles applied to the root element if `readOnly={true}`.
      static member inline readOnly : string = ".MuiRating-readOnly"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// State class applied to the root element if keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// Visually hide an element.
      static member inline visuallyHidden : string = ".MuiRating-visuallyHidden"
      /// Styles applied to the label elements.
      static member inline label : string = ".MuiRating-label"
      /// Styles applied to the label of the "no value" input when it is active.
      static member inline labelEmptyValueActive : string = ".MuiRating-labelEmptyValueActive"
      /// Styles applied to the icon wrapping elements.
      static member inline icon : string = ".MuiRating-icon"
      /// Styles applied to the icon wrapping elements when empty.
      static member inline iconEmpty : string = ".MuiRating-iconEmpty"
      /// Styles applied to the icon wrapping elements when filled.
      static member inline iconFilled : string = ".MuiRating-iconFilled"
      /// Styles applied to the icon wrapping elements when hover.
      static member inline iconHover : string = ".MuiRating-iconHover"
      /// Styles applied to the icon wrapping elements when focus.
      static member inline iconFocus : string = ".MuiRating-iconFocus"
      /// Styles applied to the icon wrapping elements when active.
      static member inline iconActive : string = ".MuiRating-iconActive"
      /// Styles applied to the icon wrapping elements when decimals are necessary.
      static member inline decimal : string = ".MuiRating-decimal"
  
  
  module scopedCssBaseline =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiScopedCssBaseline-root"
  
  
  module select =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the select component `select` class.
      static member inline select : string = ".MuiSelect-select"
      /// Styles applied to the select component if `multiple={true}`.
      static member inline multiple : string = ".MuiSelect-multiple"
      /// Styles applied to the select component if `variant="filled"`.
      static member inline filled : string = ".MuiSelect-filled"
      /// Styles applied to the select component if `variant="outlined"`.
      static member inline outlined : string = ".MuiSelect-outlined"
      /// Styles applied to the select component if `variant="standard"`.
      static member inline standard : string = ".MuiSelect-standard"
      /// State class applied to the select component `disabled` class.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the icon component.
      static member inline icon : string = ".MuiSelect-icon"
      /// Styles applied to the icon component if the popup is open.
      static member inline iconOpen : string = ".MuiSelect-iconOpen"
      /// Styles applied to the icon component if `variant="filled"`.
      static member inline iconFilled : string = ".MuiSelect-iconFilled"
      /// Styles applied to the icon component if `variant="outlined"`.
      static member inline iconOutlined : string = ".MuiSelect-iconOutlined"
      /// Styles applied to the icon component if `variant="standard"`.
      static member inline iconStandard : string = ".MuiSelect-iconStandard"
      /// Styles applied to the underlying native input component.
      static member inline nativeInput : string = ".MuiSelect-nativeInput"
  
  
  module skeleton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiSkeleton-root"
      /// Styles applied to the root element if `variant="text"`.
      static member inline text : string = ".MuiSkeleton-text"
      /// Styles applied to the root element if `variant="rectangular"`.
      static member inline rectangular : string = ".MuiSkeleton-rectangular"
      /// Styles applied to the root element if `variant="rounded"`.
      static member inline rounded : string = ".MuiSkeleton-rounded"
      /// Styles applied to the root element if `variant="circular"`.
      static member inline circular : string = ".MuiSkeleton-circular"
      /// Styles applied to the root element if `animation="pulse"`.
      static member inline pulse : string = ".MuiSkeleton-pulse"
      /// Styles applied to the root element if `animation="wave"`.
      static member inline wave : string = ".MuiSkeleton-wave"
      /// Styles applied when the component is passed children.
      static member inline withChildren : string = ".MuiSkeleton-withChildren"
      /// Styles applied when the component is passed children and no width.
      static member inline fitContent : string = ".MuiSkeleton-fitContent"
      /// Styles applied when the component is passed children and no height.
      static member inline heightAuto : string = ".MuiSkeleton-heightAuto"
  
  
  module slider =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Class name applied to the root element.
      static member inline root : string = ".MuiSlider-root"
      /// Class name applied to the root element if `marks` is provided with at least one label.
      static member inline marked : string = ".MuiSlider-marked"
      /// Class name applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiSlider-vertical"
      /// State class applied to the root and thumb element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// State class applied to the root if a thumb is being dragged.
      static member inline dragging : string = ".MuiSlider-dragging"
      /// Class name applied to the rail element.
      static member inline rail : string = ".MuiSlider-rail"
      /// Class name applied to the track element.
      static member inline track : string = ".MuiSlider-track"
      /// Class name applied to the root element if `track={false}`.
      static member inline trackFalse : string = ".MuiSlider-trackFalse"
      /// Class name applied to the root element if `track="inverted"`.
      static member inline trackInverted : string = ".MuiSlider-trackInverted"
      /// Class name applied to the thumb element.
      static member inline thumb : string = ".MuiSlider-thumb"
      /// State class applied to the thumb element if it's active.
      static member inline active : string = ".Mui-active"
      /// State class applied to the thumb element if keyboard focused.
      static member inline focusVisible : string = ".Mui-focusVisible"
      /// Class name applied to the thumb label element.
      static member inline valueLabel : string = ".MuiSlider-valueLabel"
      /// Class name applied to the thumb label element if it's open.
      static member inline valueLabelOpen : string = ".MuiSlider-valueLabelOpen"
      /// Class name applied to the thumb label's circle element.
      static member inline valueLabelCircle : string = ".MuiSlider-valueLabelCircle"
      /// Class name applied to the thumb label's label element.
      static member inline valueLabelLabel : string = ".MuiSlider-valueLabelLabel"
      /// Class name applied to the mark element.
      static member inline mark : string = ".MuiSlider-mark"
      /// Class name applied to the mark element if active (depending on the value).
      static member inline markActive : string = ".MuiSlider-markActive"
      /// Class name applied to the mark label element.
      static member inline markLabel : string = ".MuiSlider-markLabel"
      /// Class name applied to the mark label element if active (depending on the value).
      static member inline markLabelActive : string = ".MuiSlider-markLabelActive"
      /// Class name applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiSlider-colorPrimary"
      /// Class name applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiSlider-colorSecondary"
      /// Class name applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiSlider-sizeSmall"
      /// Class name applied to the thumb element if `color="primary"`.
      static member inline thumbColorPrimary : string = ".MuiSlider-thumbColorPrimary"
      /// Class name applied to the thumb element if `color="secondary"`.
      static member inline thumbColorSecondary : string = ".MuiSlider-thumbColorSecondary"
      /// Class name applied to the thumb element if `size="small"`.
      static member inline thumbSizeSmall : string = ".MuiSlider-thumbSizeSmall"
  
  
  module snackbar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiSnackbar-root"
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'center' }}`.
      static member inline anchorOriginTopCenter : string = ".MuiSnackbar-anchorOriginTopCenter"
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'center' }}`.
      static member inline anchorOriginBottomCenter : string = ".MuiSnackbar-anchorOriginBottomCenter"
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }}`.
      static member inline anchorOriginTopRight : string = ".MuiSnackbar-anchorOriginTopRight"
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }}`.
      static member inline anchorOriginBottomRight : string = ".MuiSnackbar-anchorOriginBottomRight"
      /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }}`.
      static member inline anchorOriginTopLeft : string = ".MuiSnackbar-anchorOriginTopLeft"
      /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }}`.
      static member inline anchorOriginBottomLeft : string = ".MuiSnackbar-anchorOriginBottomLeft"
  
  
  module snackbarContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiSnackbarContent-root"
      /// Styles applied to the message wrapper element.
      static member inline message : string = ".MuiSnackbarContent-message"
      /// Styles applied to the action wrapper element if `action` is provided.
      static member inline action : string = ".MuiSnackbarContent-action"
  
  
  module speedDial =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiSpeedDial-root"
      /// Styles applied to the Fab component.
      static member inline fab : string = ".MuiSpeedDial-fab"
      /// Styles applied to the root element if direction="up"
      static member inline directionUp : string = ".MuiSpeedDial-directionUp"
      /// Styles applied to the root element if direction="down"
      static member inline directionDown : string = ".MuiSpeedDial-directionDown"
      /// Styles applied to the root element if direction="left"
      static member inline directionLeft : string = ".MuiSpeedDial-directionLeft"
      /// Styles applied to the root element if direction="right"
      static member inline directionRight : string = ".MuiSpeedDial-directionRight"
      /// Styles applied to the actions (`children` wrapper) element.
      static member inline actions : string = ".MuiSpeedDial-actions"
      /// Styles applied to the actions (`children` wrapper) element if `open={false}`.
      static member inline actionsClosed : string = ".MuiSpeedDial-actionsClosed"
  
  
  module speedDialAction =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the Fab component.
      static member inline fab : string = ".MuiSpeedDialAction-fab"
      /// Styles applied to the Fab component if `open={false}`.
      static member inline fabClosed : string = ".MuiSpeedDialAction-fabClosed"
      /// Styles applied to the root element if `tooltipOpen={true}`.
      static member inline staticTooltip : string = ".MuiSpeedDialAction-staticTooltip"
      /// Styles applied to the root element if `tooltipOpen={true}` and `open={false}`.
      static member inline staticTooltipClosed : string = ".MuiSpeedDialAction-staticTooltipClosed"
      /// Styles applied to the static tooltip label if `tooltipOpen={true}`.
      static member inline staticTooltipLabel : string = ".MuiSpeedDialAction-staticTooltipLabel"
      /// Styles applied to the root element if `tooltipOpen={true}` and `tooltipPlacement="left"``
      static member inline tooltipPlacementLeft : string = ".MuiSpeedDialAction-tooltipPlacementLeft"
      /// Styles applied to the root element if `tooltipOpen={true}` and `tooltipPlacement="right"``
      static member inline tooltipPlacementRight : string = ".MuiSpeedDialAction-tooltipPlacementRight"
  
    /// `classes` prop applied to the
    ///
    ///   [`Tooltip`](https://mui.com/material-ui/api/tooltip/) element.
    [<Erase>]
    type TooltipClasses =
      /// Styles applied to the Popper component.
      static member inline popper : string = ".MuiTooltip-popper"
      /// Styles applied to the Popper component unless `disableInteractive={true}`.
      static member inline popperInteractive : string = ".MuiTooltip-popperInteractive"
      /// Styles applied to the Popper component if `arrow={true}`.
      static member inline popperArrow : string = ".MuiTooltip-popperArrow"
      /// Styles applied to the Popper component unless the tooltip is open.
      static member inline popperClose : string = ".MuiTooltip-popperClose"
      /// Styles applied to the tooltip (label wrapper) element.
      static member inline tooltip : string = ".MuiTooltip-tooltip"
      /// Styles applied to the tooltip (label wrapper) element if `arrow={true}`.
      static member inline tooltipArrow : string = ".MuiTooltip-tooltipArrow"
      /// Styles applied to the arrow element.
      static member inline arrow : string = ".MuiTooltip-arrow"
      /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
      static member inline touch : string = ".MuiTooltip-touch"
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
      static member inline tooltipPlacementLeft : string = ".MuiTooltip-tooltipPlacementLeft"
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
      static member inline tooltipPlacementRight : string = ".MuiTooltip-tooltipPlacementRight"
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
      static member inline tooltipPlacementTop : string = ".MuiTooltip-tooltipPlacementTop"
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
      static member inline tooltipPlacementBottom : string = ".MuiTooltip-tooltipPlacementBottom"
  
  
  module speedDialIcon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiSpeedDialIcon-root"
      /// Styles applied to the icon component.
      static member inline icon : string = ".MuiSpeedDialIcon-icon"
      /// Styles applied to the icon component if `open={true}`.
      static member inline iconOpen : string = ".MuiSpeedDialIcon-iconOpen"
      /// Styles applied to the icon when an `openIcon` is provided and if `open={true}`.
      static member inline iconWithOpenIconOpen : string = ".MuiSpeedDialIcon-iconWithOpenIconOpen"
      /// Styles applied to the `openIcon` if provided.
      static member inline openIcon : string = ".MuiSpeedDialIcon-openIcon"
      /// Styles applied to the `openIcon` if provided and if `open={true}`.
      static member inline openIconOpen : string = ".MuiSpeedDialIcon-openIconOpen"
  
  
  module step =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiStep-root"
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal : string = ".MuiStep-horizontal"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiStep-vertical"
      /// Styles applied to the root element if `alternativeLabel={true}`.
      static member inline alternativeLabel : string = ".MuiStep-alternativeLabel"
      /// State class applied to the root element if `completed={true}`.
      static member inline completed : string = ".Mui-completed"
  
  
  module stepButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiStepButton-root"
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal : string = ".MuiStepButton-horizontal"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiStepButton-vertical"
      /// Styles applied to the `ButtonBase` touch-ripple.
      static member inline touchRipple : string = ".MuiStepButton-touchRipple"
  
  
  module stepConnector =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiStepConnector-root"
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal : string = ".MuiStepConnector-horizontal"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiStepConnector-vertical"
      /// Styles applied to the root element if `alternativeLabel={true}`.
      static member inline alternativeLabel : string = ".MuiStepConnector-alternativeLabel"
      /// State class applied to the root element if `active={true}`.
      static member inline active : string = ".Mui-active"
      /// State class applied to the root element if `completed={true}`.
      static member inline completed : string = ".Mui-completed"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the line element.
      static member inline line : string = ".MuiStepConnector-line"
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline lineHorizontal : string = ".MuiStepConnector-lineHorizontal"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline lineVertical : string = ".MuiStepConnector-lineVertical"
  
  
  module stepContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiStepContent-root"
      /// Styles applied to the root element if `last={true}` (controlled by `Step`).
      static member inline last : string = ".MuiStepContent-last"
      /// Styles applied to the Transition component.
      static member inline transition : string = ".MuiStepContent-transition"
  
  
  module stepIcon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiStepIcon-root"
      /// Styles applied to the SVG text element.
      static member inline text : string = ".MuiStepIcon-text"
      /// State class applied to the root element if `active={true}`.
      static member inline active : string = ".Mui-active"
      /// State class applied to the root element if `completed={true}`.
      static member inline completed : string = ".Mui-completed"
      /// State class applied to the root element if `error={true}`.
      static member inline error : string = ".Mui-error"
  
  
  module stepLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiStepLabel-root"
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal : string = ".MuiStepLabel-horizontal"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiStepLabel-vertical"
      /// Styles applied to the label element that wraps `children`.
      static member inline label : string = ".MuiStepLabel-label"
      /// State class applied to the label element if `active={true}`.
      static member inline active : string = ".Mui-active"
      /// State class applied to the label element if `completed={true}`.
      static member inline completed : string = ".Mui-completed"
      /// State class applied to the root and label elements if `error={true}`.
      static member inline error : string = ".Mui-error"
      /// State class applied to the root and label elements if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the `icon` container element.
      static member inline iconContainer : string = ".MuiStepLabel-iconContainer"
      /// State class applied to the root and icon container and label if `alternativeLabel={true}`.
      static member inline alternativeLabel : string = ".MuiStepLabel-alternativeLabel"
      /// Styles applied to the container element which wraps label and `optional`.
      static member inline labelContainer : string = ".MuiStepLabel-labelContainer"
  
  
  module stepper =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiStepper-root"
      /// Styles applied to the root element if `orientation="horizontal"`.
      static member inline horizontal : string = ".MuiStepper-horizontal"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiStepper-vertical"
      /// Styles applied to the root element if `alternativeLabel={true}`.
      static member inline alternativeLabel : string = ".MuiStepper-alternativeLabel"
  
  
  module svgIcon =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiSvgIcon-root"
      /// Styles applied to the root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiSvgIcon-colorPrimary"
      /// Styles applied to the root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiSvgIcon-colorSecondary"
      /// Styles applied to the root element if `color="action"`.
      static member inline colorAction : string = ".MuiSvgIcon-colorAction"
      /// Styles applied to the root element if `color="error"`.
      static member inline colorError : string = ".MuiSvgIcon-colorError"
      /// Styles applied to the root element if `color="disabled"`.
      static member inline colorDisabled : string = ".MuiSvgIcon-colorDisabled"
      /// Styles applied to the root element if `fontSize="inherit"`.
      static member inline fontSizeInherit : string = ".MuiSvgIcon-fontSizeInherit"
      /// Styles applied to the root element if `fontSize="small"`.
      static member inline fontSizeSmall : string = ".MuiSvgIcon-fontSizeSmall"
      /// Styles applied to the root element if `fontSize="large"`.
      static member inline fontSizeLarge : string = ".MuiSvgIcon-fontSizeLarge"
  
  
  module switch =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiSwitch-root"
      /// Styles applied to the root element if `edge="start"`.
      static member inline edgeStart : string = ".MuiSwitch-edgeStart"
      /// Styles applied to the root element if `edge="end"`.
      static member inline edgeEnd : string = ".MuiSwitch-edgeEnd"
      /// Styles applied to the internal `SwitchBase` component's `root` class.
      static member inline switchBase : string = ".MuiSwitch-switchBase"
      /// Styles applied to the internal SwitchBase component's root element if `color="primary"`.
      static member inline colorPrimary : string = ".MuiSwitch-colorPrimary"
      /// Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
      static member inline colorSecondary : string = ".MuiSwitch-colorSecondary"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiSwitch-sizeSmall"
      /// Styles applied to the root element if `size="medium"`.
      static member inline sizeMedium : string = ".MuiSwitch-sizeMedium"
      /// State class applied to the internal `SwitchBase` component's `checked` class.
      static member inline checked' : string = ".Mui-checked"
      /// State class applied to the internal SwitchBase component's disabled class.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the internal SwitchBase component's input element.
      static member inline input : string = ".MuiSwitch-input"
      /// Styles used to create the thumb passed to the internal `SwitchBase` component `icon` prop.
      static member inline thumb : string = ".MuiSwitch-thumb"
      /// Styles applied to the track element.
      static member inline track : string = ".MuiSwitch-track"
  
  
  module tab =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTab-root"
      /// Styles applied to the root element if both `icon` and `label` are provided.
      static member inline labelIcon : string = ".MuiTab-labelIcon"
      /// Styles applied to the root element if the parent [`Tabs`](/material-ui/api/tabs/) has `textColor="inherit"`.
      static member inline textColorInherit : string = ".MuiTab-textColorInherit"
      /// Styles applied to the root element if the parent [`Tabs`](/material-ui/api/tabs/) has `textColor="primary"`.
      static member inline textColorPrimary : string = ".MuiTab-textColorPrimary"
      /// Styles applied to the root element if the parent [`Tabs`](/material-ui/api/tabs/) has `textColor="secondary"`.
      static member inline textColorSecondary : string = ".MuiTab-textColorSecondary"
      /// State class applied to the root element if `selected={true}` (controlled by the Tabs component).
      static member inline selected : string = ".Mui-selected"
      /// State class applied to the root element if `disabled={true}` (controlled by the Tabs component).
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
      static member inline fullWidth : string = ".MuiTab-fullWidth"
      /// Styles applied to the root element if `wrapped={true}`.
      static member inline wrapped : string = ".MuiTab-wrapped"
      /// Styles applied to the wrapper element of `icon` if `icon` is provided.
      static member inline iconWrapper : string = ".MuiTab-iconWrapper"
  
  
  module table =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTable-root"
      /// Styles applied to the root element if `stickyHeader={true}`.
      static member inline stickyHeader : string = ".MuiTable-stickyHeader"
  
  
  module tableBody =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTableBody-root"
  
  
  module tableCell =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTableCell-root"
      /// Styles applied to the root element if `variant="head"` or `context.table.head`.
      static member inline head : string = ".MuiTableCell-head"
      /// Styles applied to the root element if `variant="body"` or `context.table.body`.
      static member inline body : string = ".MuiTableCell-body"
      /// Styles applied to the root element if `variant="footer"` or `context.table.footer`.
      static member inline footer : string = ".MuiTableCell-footer"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiTableCell-sizeSmall"
      /// Styles applied to the root element if `size="medium"`.
      static member inline sizeMedium : string = ".MuiTableCell-sizeMedium"
      /// Styles applied to the root element if `padding="checkbox"`.
      static member inline paddingCheckbox : string = ".MuiTableCell-paddingCheckbox"
      /// Styles applied to the root element if `padding="none"`.
      static member inline paddingNone : string = ".MuiTableCell-paddingNone"
      /// Styles applied to the root element if `align="left"`.
      static member inline alignLeft : string = ".MuiTableCell-alignLeft"
      /// Styles applied to the root element if `align="center"`.
      static member inline alignCenter : string = ".MuiTableCell-alignCenter"
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight : string = ".MuiTableCell-alignRight"
      /// Styles applied to the root element if `align="justify"`.
      static member inline alignJustify : string = ".MuiTableCell-alignJustify"
      /// Styles applied to the root element if `context.table.stickyHeader={true}`.
      static member inline stickyHeader : string = ".MuiTableCell-stickyHeader"
  
  
  module tableContainer =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTableContainer-root"
  
  
  module tableFooter =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTableFooter-root"
  
  
  module tableHead =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTableHead-root"
  
  
  module tablePagination =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTablePagination-root"
      /// Styles applied to the Toolbar component.
      static member inline toolbar : string = ".MuiTablePagination-toolbar"
      /// Styles applied to the spacer element.
      static member inline spacer : string = ".MuiTablePagination-spacer"
      /// Styles applied to the select label Typography element.
      static member inline selectLabel : string = ".MuiTablePagination-selectLabel"
      /// Styles applied to the Select component `root` element.
      static member inline selectRoot : string = ".MuiTablePagination-selectRoot"
      /// Styles applied to the Select component `select` class.
      static member inline select : string = ".MuiTablePagination-select"
      /// Styles applied to the Select component `icon` class.
      static member inline selectIcon : string = ".MuiTablePagination-selectIcon"
      /// Styles applied to the Select component `root` element.
      static member inline input : string = ".MuiTablePagination-input"
      /// Styles applied to the MenuItem component.
      static member inline menuItem : string = ".MuiTablePagination-menuItem"
      /// Styles applied to the displayed rows Typography element.
      static member inline displayedRows : string = ".MuiTablePagination-displayedRows"
      /// Styles applied to the internal `TablePaginationActions` component.
      static member inline actions : string = ".MuiTablePagination-actions"
  
  
  module tableRow =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTableRow-root"
      /// State class applied to the root element if `selected={true}`.
      static member inline selected : string = ".Mui-selected"
      /// State class applied to the root element if `hover={true}`.
      static member inline hover : string = ".MuiTableRow-hover"
      /// Styles applied to the root element if table variant="head".
      static member inline head : string = ".MuiTableRow-head"
      /// Styles applied to the root element if table variant="footer".
      static member inline footer : string = ".MuiTableRow-footer"
  
  
  module tableSortLabel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTableSortLabel-root"
      /// State class applied to the root element if `active={true}`.
      static member inline active : string = ".Mui-active"
      /// Styles applied to the icon component.
      static member inline icon : string = ".MuiTableSortLabel-icon"
      /// Styles applied to the icon component if `direction="desc"`.
      static member inline iconDirectionDesc : string = ".MuiTableSortLabel-iconDirectionDesc"
      /// Styles applied to the icon component if `direction="asc"`.
      static member inline iconDirectionAsc : string = ".MuiTableSortLabel-iconDirectionAsc"
  
  
  module tabPanel =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTabPanel-root"
  
  
  module tabs =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTabs-root"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiTabs-vertical"
      /// Styles applied to the flex container element.
      static member inline flexContainer : string = ".MuiTabs-flexContainer"
      /// Styles applied to the flex container element if `orientation="vertical"`.
      static member inline flexContainerVertical : string = ".MuiTabs-flexContainerVertical"
      /// Styles applied to the flex container element if `centered={true}`&`!variant="scrollable"`.
      static member inline centered : string = ".MuiTabs-centered"
      /// Styles applied to the tablist element.
      static member inline scroller : string = ".MuiTabs-scroller"
      /// Styles applied to the tablist element if `!variant="scrollable"`.
      static member inline fixed' : string = ".MuiTabs-fixed"
      /// Styles applied to the tablist element if `variant="scrollable"` and `orientation="horizontal"`.
      static member inline scrollableX : string = ".MuiTabs-scrollableX"
      /// Styles applied to the tablist element if `variant="scrollable"` and `orientation="vertical"`.
      static member inline scrollableY : string = ".MuiTabs-scrollableY"
      /// Styles applied to the tablist element if `variant="scrollable"` and `visibleScrollbar={false}`.
      static member inline hideScrollbar : string = ".MuiTabs-hideScrollbar"
      /// Styles applied to the ScrollButtonComponent component.
      static member inline scrollButtons : string = ".MuiTabs-scrollButtons"
      /// Styles applied to the ScrollButtonComponent component if `allowScrollButtonsMobile={true}`.
      static member inline scrollButtonsHideMobile : string = ".MuiTabs-scrollButtonsHideMobile"
      /// Styles applied to the TabIndicator component.
      static member inline indicator : string = ".MuiTabs-indicator"
  
  
  module tabScrollButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTabScrollButton-root"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiTabScrollButton-vertical"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
  
  
  module textField =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTextField-root"
  
  
  module timeline =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTimeline-root"
      /// Styles applied to the root element if `position="left"`.
      static member inline positionLeft : string = ".MuiTimeline-positionLeft"
      /// Styles applied to the root element if `position="right"`.
      static member inline positionRight : string = ".MuiTimeline-positionRight"
      /// Styles applied to the root element if `position="alternate"`.
      static member inline positionAlternate : string = ".MuiTimeline-positionAlternate"
  
  
  module timelineConnector =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTimelineConnector-root"
  
  
  module timelineContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTimelineContent-root"
      /// Styles applied to the root element if `position="right"`.
      static member inline positionRight : string = ".MuiTimelineContent-positionRight"
      /// Styles applied to the root element if `position="left"`.
      static member inline positionLeft : string = ".MuiTimelineContent-positionLeft"
      /// Styles applied to the root element if `position="alternate"`.
      static member inline positionAlternate : string = ".MuiTimelineContent-positionAlternate"
  
  
  module timelineDot =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTimelineDot-root"
      /// Styles applied to the root element if `variant="filled"`.
      static member inline filled : string = ".MuiTimelineDot-filled"
      /// Styles applied to the root element if `variant="outlined"`.
      static member inline outlined : string = ".MuiTimelineDot-outlined"
      /// Styles applied to the root element if `color="grey"` and `variant="filled"`.
      static member inline filledGrey : string = ".MuiTimelineDot-filledGrey"
      /// Styles applied to the root element if `color="grey"` and `variant="outlined"`.
      static member inline outlinedGrey : string = ".MuiTimelineDot-outlinedGrey"
      /// Styles applied to the root element if `color="primary"` and `variant="filled"`.
      static member inline filledPrimary : string = ".MuiTimelineDot-filledPrimary"
      /// Styles applied to the root element if `color="primary"` and `variant="outlined"`.
      static member inline outlinedPrimary : string = ".MuiTimelineDot-outlinedPrimary"
      /// Styles applied to the root element if `color="secondary"` and `variant="filled"`.
      static member inline filledSecondary : string = ".MuiTimelineDot-filledSecondary"
      /// Styles applied to the root element if `color="secondary"` and `variant="outlined"`.
      static member inline outlinedSecondary : string = ".MuiTimelineDot-outlinedSecondary"
  
  
  module timelineItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTimelineItem-root"
      /// Styles applied to the root element if `position="left"`.
      static member inline positionLeft : string = ".MuiTimelineItem-positionLeft"
      /// Styles applied to the root element if `position="right"`.
      static member inline positionRight : string = ".MuiTimelineItem-positionRight"
      /// Styles applied to the root element if `position="alternate"`.
      static member inline positionAlternate : string = ".MuiTimelineItem-positionAlternate"
      /// Styles applied to the root element if TimelineOppositeContent isn't provided.
      static member inline missingOppositeContent : string = ".MuiTimelineItem-missingOppositeContent"
  
  
  module timelineOppositeContent =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTimelineOppositeContent-root"
      /// Styles applied to the root element if `position="right"`.
      static member inline positionRight : string = ".MuiTimelineOppositeContent-positionRight"
      /// Styles applied to the root element if `position="left"`.
      static member inline positionLeft : string = ".MuiTimelineOppositeContent-positionLeft"
      /// Styles applied to the root element if `position="alternate"`.
      static member inline positionAlternate : string = ".MuiTimelineOppositeContent-positionAlternate"
  
  
  module timelineSeparator =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTimelineSeparator-root"
  
  
  module toggleButton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiToggleButton-root"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// State class applied to the root element if `selected={true}`.
      static member inline selected : string = ".Mui-selected"
      /// State class applied to the root element if `color="standard"`.
      static member inline standard : string = ".MuiToggleButton-standard"
      /// State class applied to the root element if `color="primary"`.
      static member inline primary : string = ".MuiToggleButton-primary"
      /// State class applied to the root element if `color="secondary"`.
      static member inline secondary : string = ".MuiToggleButton-secondary"
      /// Styles applied to the root element if `size="small"`.
      static member inline sizeSmall : string = ".MuiToggleButton-sizeSmall"
      /// Styles applied to the root element if `size="medium"`.
      static member inline sizeMedium : string = ".MuiToggleButton-sizeMedium"
      /// Styles applied to the root element if `size="large"`.
      static member inline sizeLarge : string = ".MuiToggleButton-sizeLarge"
  
  
  module toggleButtonGroup =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiToggleButtonGroup-root"
      /// Styles applied to the root element if `orientation="vertical"`.
      static member inline vertical : string = ".MuiToggleButtonGroup-vertical"
      /// State class applied to the root element if `disabled={true}`.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the children.
      static member inline grouped : string = ".MuiToggleButtonGroup-grouped"
      /// Styles applied to the children if `orientation="horizontal"`.
      static member inline groupedHorizontal : string = ".MuiToggleButtonGroup-groupedHorizontal"
      /// Styles applied to the children if `orientation="vertical"`.
      static member inline groupedVertical : string = ".MuiToggleButtonGroup-groupedVertical"
  
  
  module toolbar =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiToolbar-root"
      /// Styles applied to the root element unless `disableGutters={true}`.
      static member inline gutters : string = ".MuiToolbar-gutters"
      /// Styles applied to the root element if `variant="regular"`.
      static member inline regular : string = ".MuiToolbar-regular"
      /// Styles applied to the root element if `variant="dense"`.
      static member inline dense : string = ".MuiToolbar-dense"
  
  
  module tooltip =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the Popper component.
      static member inline popper : string = ".MuiTooltip-popper"
      /// Styles applied to the Popper component unless `disableInteractive={true}`.
      static member inline popperInteractive : string = ".MuiTooltip-popperInteractive"
      /// Styles applied to the Popper component if `arrow={true}`.
      static member inline popperArrow : string = ".MuiTooltip-popperArrow"
      /// Styles applied to the Popper component unless the tooltip is open.
      static member inline popperClose : string = ".MuiTooltip-popperClose"
      /// Styles applied to the tooltip (label wrapper) element.
      static member inline tooltip : string = ".MuiTooltip-tooltip"
      /// Styles applied to the tooltip (label wrapper) element if `arrow={true}`.
      static member inline tooltipArrow : string = ".MuiTooltip-tooltipArrow"
      /// Styles applied to the arrow element.
      static member inline arrow : string = ".MuiTooltip-arrow"
      /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
      static member inline touch : string = ".MuiTooltip-touch"
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
      static member inline tooltipPlacementLeft : string = ".MuiTooltip-tooltipPlacementLeft"
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
      static member inline tooltipPlacementRight : string = ".MuiTooltip-tooltipPlacementRight"
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
      static member inline tooltipPlacementTop : string = ".MuiTooltip-tooltipPlacementTop"
      /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
      static member inline tooltipPlacementBottom : string = ".MuiTooltip-tooltipPlacementBottom"
  
  
  module treeItem =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTreeItem-root"
      /// Styles applied to the transition component.
      static member inline group : string = ".MuiTreeItem-group"
      /// Styles applied to the content element.
      static member inline content : string = ".MuiTreeItem-content"
      /// State class applied to the content element when expanded.
      static member inline expanded : string = ".Mui-expanded"
      /// State class applied to the content element when selected.
      static member inline selected : string = ".Mui-selected"
      /// State class applied to the content element when focused.
      static member inline focused : string = ".Mui-focused"
      /// State class applied to the element when disabled.
      static member inline disabled : string = ".Mui-disabled"
      /// Styles applied to the tree node icon.
      static member inline iconContainer : string = ".MuiTreeItem-iconContainer"
      /// Styles applied to the label element.
      static member inline label : string = ".MuiTreeItem-label"
  
  
  module treeView =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTreeView-root"
  
  
  module typography =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiTypography-root"
      /// Styles applied to the root element if `variant="body2"`.
      static member inline body2 : string = ".MuiTypography-body2"
      /// Styles applied to the root element if `variant="body1"`.
      static member inline body1 : string = ".MuiTypography-body1"
      /// Styles applied to the root element if `variant="caption"`.
      static member inline caption : string = ".MuiTypography-caption"
      /// Styles applied to the root element if `variant="button"`.
      static member inline button : string = ".MuiTypography-button"
      /// Styles applied to the root element if `variant="h1"`.
      static member inline h1 : string = ".MuiTypography-h1"
      /// Styles applied to the root element if `variant="h2"`.
      static member inline h2 : string = ".MuiTypography-h2"
      /// Styles applied to the root element if `variant="h3"`.
      static member inline h3 : string = ".MuiTypography-h3"
      /// Styles applied to the root element if `variant="h4"`.
      static member inline h4 : string = ".MuiTypography-h4"
      /// Styles applied to the root element if `variant="h5"`.
      static member inline h5 : string = ".MuiTypography-h5"
      /// Styles applied to the root element if `variant="h6"`.
      static member inline h6 : string = ".MuiTypography-h6"
      /// Styles applied to the root element if `variant="subtitle1"`.
      static member inline subtitle1 : string = ".MuiTypography-subtitle1"
      /// Styles applied to the root element if `variant="subtitle2"`.
      static member inline subtitle2 : string = ".MuiTypography-subtitle2"
      /// Styles applied to the root element if `variant="overline"`.
      static member inline overline : string = ".MuiTypography-overline"
      /// Styles applied to the root element if `variant="inherit"`.
      static member inline inherit' : string = ".MuiTypography-inherit"
      /// Styles applied to the root element if `align="left"`.
      static member inline alignLeft : string = ".MuiTypography-alignLeft"
      /// Styles applied to the root element if `align="center"`.
      static member inline alignCenter : string = ".MuiTypography-alignCenter"
      /// Styles applied to the root element if `align="right"`.
      static member inline alignRight : string = ".MuiTypography-alignRight"
      /// Styles applied to the root element if `align="justify"`.
      static member inline alignJustify : string = ".MuiTypography-alignJustify"
      /// Styles applied to the root element if `nowrap={true}`.
      static member inline noWrap : string = ".MuiTypography-noWrap"
      /// Styles applied to the root element if `gutterBottom={true}`.
      static member inline gutterBottom : string = ".MuiTypography-gutterBottom"
      /// Styles applied to the root element if `paragraph={true}`.
      static member inline paragraph : string = ".MuiTypography-paragraph"
  
  
  module calendarPickerSkeleton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiCalendarPickerSkeleton-root"
      /// Styles applied to the week element.
      static member inline week : string = ".MuiCalendarPickerSkeleton-week"
      /// Styles applied to the day element.
      static member inline daySkeleton : string = ".MuiCalendarPickerSkeleton-daySkeleton"
  
  
  module clockPicker =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiClockPicker-root"
      /// Styles applied to the arrowSwitcher element.
      static member inline arrowSwitcher : string = ".MuiClockPicker-arrowSwitcher"
  
  
  module dateRangePickerDay =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiDateRangePickerDay-root"
      /// Styles applied to the root element if `isHighlighting=true` and `outsideCurrentMonth=false`.
      static member inline rangeIntervalDayHighlight : string = ".MuiDateRangePickerDay-rangeIntervalDayHighlight"
      /// Styles applied to the root element if `isStartOfHighlighting=true` or `day` is the start of the month.
      static member inline rangeIntervalDayHighlightStart : string = ".MuiDateRangePickerDay-rangeIntervalDayHighlightStart"
      /// Styles applied to the root element if `isEndOfHighlighting=true` or `day` is the end of the month.
      static member inline rangeIntervalDayHighlightEnd : string = ".MuiDateRangePickerDay-rangeIntervalDayHighlightEnd"
      /// Styles applied to the preview element.
      static member inline rangeIntervalPreview : string = ".MuiDateRangePickerDay-rangeIntervalPreview"
      /// Styles applied to the root element if `isPreviewing=true` and `outsideCurrentMonth=false`.
      static member inline rangeIntervalDayPreview : string = ".MuiDateRangePickerDay-rangeIntervalDayPreview"
      /// Styles applied to the root element if `isStartOfPreviewing=true` or `day` is the start of the month.
      static member inline rangeIntervalDayPreviewStart : string = ".MuiDateRangePickerDay-rangeIntervalDayPreviewStart"
      /// Styles applied to the root element if `isEndOfPreviewing=true` or `day` is the end of the month.
      static member inline rangeIntervalDayPreviewEnd : string = ".MuiDateRangePickerDay-rangeIntervalDayPreviewEnd"
      /// Styles applied to the day element.
      static member inline day : string = ".MuiDateRangePickerDay-day"
      /// Styles applied to the day element if `isHighlighting=false`.
      static member inline dayOutsideRangeInterval : string = ".MuiDateRangePickerDay-dayOutsideRangeInterval"
      /// Styles applied to the day element if `selected=false` and `isHighlighting=true`.
      static member inline dayInsideRangeInterval : string = ".MuiDateRangePickerDay-dayInsideRangeInterval"
      /// Styles applied to the day element if `selected=false`.
      static member inline notSelectedDate : string = ".MuiDateRangePickerDay-notSelectedDate"
  
  
  module monthPicker =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiMonthPicker-root"
  
  
  module pickersDay =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root : string = ".MuiPickersDay-root"
      /// Styles applied to the root element if `disableMargin=false`.
      static member inline dayWithMargin : string = ".MuiPickersDay-dayWithMargin"
      /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=true`.
      static member inline dayOutsideMonth : string = ".MuiPickersDay-dayOutsideMonth"
      /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=false`.
      static member inline hiddenDaySpacingFiller : string = ".MuiPickersDay-hiddenDaySpacingFiller"
      /// Styles applied to the root element if `disableHighlightToday=false` and `today=true`.
      static member inline today : string = ".MuiPickersDay-today"
      /// State class applied to the root element if `selected=true`.
      static member inline selected : string = ".Mui-selected"
      /// State class applied to the root element if `disabled=true`.
      static member inline disabled : string = ".Mui-disabled"
  
  