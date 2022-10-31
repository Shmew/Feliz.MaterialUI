namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module MuiHelpers =

  open Fable.React

  let reactElement (el: ReactElementType) (props: 'a) : ReactElement =
    import "createElement" "react"

  let reactElementTag (tag: string) (props: 'a) : ReactElement =
    import "createElement" "react"

  let createElement (el: ReactElementType) (properties: IReactProperty seq) : ReactElement =
    reactElement el (!!properties |> Object.fromFlatEntries)

  let createElementTag (tag: string) (properties: IReactProperty seq) : ReactElement =
    reactElementTag tag (!!properties |> Object.fromFlatEntries)

[<Erase>]
type Mui =

  static member inline themeProvider props = createElement (import "ThemeProvider" "@mui/material") props

  /// This component allows you to change styes import precedence and thereby override default MUI styles.
  /// Documentation: https://mui.com/material-ui/guides/interoperability/#css-injection-order
  static member inline styledEngineProvider props = createElement (import "StyledEngineProvider" "@mui/material/styles") props

  /// If you are using Emotion and have a custom cache in your app, it will override the one coming from MUI.
  /// In order for the injection order to still be correct, you need to add the prepend option.
  static member inline cacheProvider props = createElement (import "CacheProvider" "@emotion/react") props

  /// The responsive layout grid adapts to screen size and orientation, ensuring consistency across layouts.
  /// Props from the `grid` component could be used, except the `item` and `zeroMinWidth`, which have been removed in Grid v2.
  static member inline grid2 props = createElement (import "default" "@mui/material/Unstable_Grid2") props

  static member inline accordion props = createElement (import "Accordion" "@mui/material") props

  static member inline accordion (children: #seq<ReactElement>) = createElement (import "Accordion" "@mui/material") [ accordion.children (children :> seq<ReactElement>) ]

  static member inline accordionActions props = createElement (import "AccordionActions" "@mui/material") props

  static member inline accordionActions (children: #seq<ReactElement>) = createElement (import "AccordionActions" "@mui/material") [ accordionActions.children (children :> seq<ReactElement>) ]

  static member inline accordionDetails props = createElement (import "AccordionDetails" "@mui/material") props

  static member inline accordionDetails (children: #seq<ReactElement>) = createElement (import "AccordionDetails" "@mui/material") [ accordionDetails.children (children :> seq<ReactElement>) ]

  static member inline accordionSummary props = createElement (import "AccordionSummary" "@mui/material") props

  static member inline accordionSummary (children: #seq<ReactElement>) = createElement (import "AccordionSummary" "@mui/material") [ accordionSummary.children (children :> seq<ReactElement>) ]

  static member inline alert props = createElement (import "Alert" "@mui/material") props

  static member inline alert (children: #seq<ReactElement>) = createElement (import "Alert" "@mui/material") [ alert.children (children :> seq<ReactElement>) ]

  static member inline alertTitle props = createElement (import "AlertTitle" "@mui/material") props

  static member inline alertTitle (children: #seq<ReactElement>) = createElement (import "AlertTitle" "@mui/material") [ alertTitle.children (children :> seq<ReactElement>) ]

  static member inline appBar props = createElement (import "AppBar" "@mui/material") props

  static member inline appBar (children: #seq<ReactElement>) = createElement (import "AppBar" "@mui/material") [ appBar.children (children :> seq<ReactElement>) ]

  static member inline autocomplete props = createElement (import "Autocomplete" "@mui/material") props

  static member inline avatar props = createElement (import "Avatar" "@mui/material") props

  static member inline avatar (children: #seq<ReactElement>) = createElement (import "Avatar" "@mui/material") [ avatar.children (children :> seq<ReactElement>) ]

  static member inline avatarGroup props = createElement (import "AvatarGroup" "@mui/material") props

  static member inline avatarGroup (children: #seq<ReactElement>) = createElement (import "AvatarGroup" "@mui/material") [ avatarGroup.children (children :> seq<ReactElement>) ]

  static member inline backdrop props = createElement (import "Backdrop" "@mui/material") props

  static member inline backdrop (children: #seq<ReactElement>) = createElement (import "Backdrop" "@mui/material") [ backdrop.children (children :> seq<ReactElement>) ]

  static member inline badge props = createElement (import "Badge" "@mui/material") props

  static member inline badge (children: #seq<ReactElement>) = createElement (import "Badge" "@mui/material") [ badge.children (children :> seq<ReactElement>) ]

  static member inline bottomNavigation props = createElement (import "BottomNavigation" "@mui/material") props

  static member inline bottomNavigation (children: #seq<ReactElement>) = createElement (import "BottomNavigation" "@mui/material") [ bottomNavigation.children (children :> seq<ReactElement>) ]

  static member inline bottomNavigationAction props = createElement (import "BottomNavigationAction" "@mui/material") props

  static member inline box props = createElement (import "Box" "@mui/material") props

  static member inline box (children: #seq<ReactElement>) = createElement (import "Box" "@mui/material") [ box.children (children :> seq<ReactElement>) ]

  static member inline breadcrumbs props = createElement (import "Breadcrumbs" "@mui/material") props

  static member inline breadcrumbs (children: #seq<ReactElement>) = createElement (import "Breadcrumbs" "@mui/material") [ breadcrumbs.children (children :> seq<ReactElement>) ]

  static member inline button props = createElement (import "Button" "@mui/material") props

  static member inline button (children: #seq<ReactElement>) = createElement (import "Button" "@mui/material") [ button.children (children :> seq<ReactElement>) ]

  static member inline buttonBase props = createElement (import "ButtonBase" "@mui/material") props

  static member inline buttonBase (children: #seq<ReactElement>) = createElement (import "ButtonBase" "@mui/material") [ buttonBase.children (children :> seq<ReactElement>) ]

  static member inline buttonGroup props = createElement (import "ButtonGroup" "@mui/material") props

  static member inline buttonGroup (children: #seq<ReactElement>) = createElement (import "ButtonGroup" "@mui/material") [ buttonGroup.children (children :> seq<ReactElement>) ]

  static member inline card props = createElement (import "Card" "@mui/material") props

  static member inline card (children: #seq<ReactElement>) = createElement (import "Card" "@mui/material") [ card.children (children :> seq<ReactElement>) ]

  static member inline cardActionArea props = createElement (import "CardActionArea" "@mui/material") props

  static member inline cardActionArea (children: #seq<ReactElement>) = createElement (import "CardActionArea" "@mui/material") [ cardActionArea.children (children :> seq<ReactElement>) ]

  static member inline cardActions props = createElement (import "CardActions" "@mui/material") props

  static member inline cardActions (children: #seq<ReactElement>) = createElement (import "CardActions" "@mui/material") [ cardActions.children (children :> seq<ReactElement>) ]

  static member inline cardContent props = createElement (import "CardContent" "@mui/material") props

  static member inline cardContent (children: #seq<ReactElement>) = createElement (import "CardContent" "@mui/material") [ cardContent.children (children :> seq<ReactElement>) ]

  static member inline cardHeader props = createElement (import "CardHeader" "@mui/material") props

  static member inline cardMedia props = createElement (import "CardMedia" "@mui/material") props

  static member inline cardMedia (children: #seq<ReactElement>) = createElement (import "CardMedia" "@mui/material") [ cardMedia.children (children :> seq<ReactElement>) ]

  static member inline checkbox props = createElement (import "Checkbox" "@mui/material") props

  static member inline chip props = createElement (import "Chip" "@mui/material") props

  static member inline circularProgress props = createElement (import "CircularProgress" "@mui/material") props

  static member inline collapse props = createElement (import "Collapse" "@mui/material") props

  static member inline collapse (children: #seq<ReactElement>) = createElement (import "Collapse" "@mui/material") [ collapse.children (children :> seq<ReactElement>) ]

  static member inline container props = createElement (import "Container" "@mui/material") props

  static member inline container (children: #seq<ReactElement>) = createElement (import "Container" "@mui/material") [ container.children (children :> seq<ReactElement>) ]

  static member inline cssBaseline props = createElement (import "CssBaseline" "@mui/material") props

  static member inline cssBaseline (children: #seq<ReactElement>) = createElement (import "CssBaseline" "@mui/material") [ cssBaseline.children (children :> seq<ReactElement>) ]

  static member inline dialog props = createElement (import "Dialog" "@mui/material") props

  static member inline dialog (children: #seq<ReactElement>) = createElement (import "Dialog" "@mui/material") [ dialog.children (children :> seq<ReactElement>) ]

  static member inline dialogActions props = createElement (import "DialogActions" "@mui/material") props

  static member inline dialogActions (children: #seq<ReactElement>) = createElement (import "DialogActions" "@mui/material") [ dialogActions.children (children :> seq<ReactElement>) ]

  static member inline dialogContent props = createElement (import "DialogContent" "@mui/material") props

  static member inline dialogContent (children: #seq<ReactElement>) = createElement (import "DialogContent" "@mui/material") [ dialogContent.children (children :> seq<ReactElement>) ]

  static member inline dialogContentText props = createElement (import "DialogContentText" "@mui/material") props

  static member inline dialogContentText (text: string) = createElement (import "DialogContentText" "@mui/material") [ prop.children (Html.text text) ]

  static member inline dialogContentText (children: #seq<ReactElement>) = createElement (import "DialogContentText" "@mui/material") [ dialogContentText.children (children :> seq<ReactElement>) ]

  static member inline dialogTitle props = createElement (import "DialogTitle" "@mui/material") props

  static member inline dialogTitle (text: string) = createElement (import "DialogTitle" "@mui/material") [ prop.children (Html.text text) ]

  static member inline dialogTitle (children: #seq<ReactElement>) = createElement (import "DialogTitle" "@mui/material") [ dialogTitle.children (children :> seq<ReactElement>) ]

  static member inline divider props = createElement (import "Divider" "@mui/material") props

  static member inline divider (children: #seq<ReactElement>) = createElement (import "Divider" "@mui/material") [ divider.children (children :> seq<ReactElement>) ]

  static member inline drawer props = createElement (import "Drawer" "@mui/material") props

  static member inline drawer (children: #seq<ReactElement>) = createElement (import "Drawer" "@mui/material") [ drawer.children (children :> seq<ReactElement>) ]

  static member inline fab props = createElement (import "Fab" "@mui/material") props

  static member inline fab (children: #seq<ReactElement>) = createElement (import "Fab" "@mui/material") [ fab.children (children :> seq<ReactElement>) ]

  static member inline fade props = createElement (import "Fade" "@mui/material") props

  static member inline filledInput props = createElement (import "FilledInput" "@mui/material") props

  static member inline formControl props = createElement (import "FormControl" "@mui/material") props

  static member inline formControl (children: #seq<ReactElement>) = createElement (import "FormControl" "@mui/material") [ formControl.children (children :> seq<ReactElement>) ]

  static member inline formControlLabel props = createElement (import "FormControlLabel" "@mui/material") props

  static member inline formGroup props = createElement (import "FormGroup" "@mui/material") props

  static member inline formGroup (children: #seq<ReactElement>) = createElement (import "FormGroup" "@mui/material") [ formGroup.children (children :> seq<ReactElement>) ]

  static member inline formHelperText props = createElement (import "FormHelperText" "@mui/material") props

  static member inline formHelperText (text: string) = createElement (import "FormHelperText" "@mui/material") [ prop.children (Html.text text) ]

  static member inline formHelperText (children: #seq<ReactElement>) = createElement (import "FormHelperText" "@mui/material") [ formHelperText.children (children :> seq<ReactElement>) ]

  static member inline formLabel props = createElement (import "FormLabel" "@mui/material") props

  static member inline formLabel (text: string) = createElement (import "FormLabel" "@mui/material") [ prop.children (Html.text text) ]

  static member inline formLabel (children: #seq<ReactElement>) = createElement (import "FormLabel" "@mui/material") [ formLabel.children (children :> seq<ReactElement>) ]

  static member inline globalStyles props = createElement (import "GlobalStyles" "@mui/material") props

  static member inline grid props = createElement (import "Grid" "@mui/material") props

  static member inline grid (children: #seq<ReactElement>) = createElement (import "Grid" "@mui/material") [ grid.children (children :> seq<ReactElement>) ]

  static member inline grow props = createElement (import "Grow" "@mui/material") props

  static member inline hidden props = createElement (import "Hidden" "@mui/material") props

  static member inline hidden (children: #seq<ReactElement>) = createElement (import "Hidden" "@mui/material") [ hidden.children (children :> seq<ReactElement>) ]

  static member inline icon props = createElement (import "Icon" "@mui/material") props

  static member inline icon (name: string) = createElement (import "Icon" "@mui/material") [ prop.children (Html.text name) ]

  static member inline icon (children: #seq<ReactElement>) = createElement (import "Icon" "@mui/material") [ icon.children (children :> seq<ReactElement>) ]

  static member inline iconButton props = createElement (import "IconButton" "@mui/material") props

  static member inline iconButton (children: #seq<ReactElement>) = createElement (import "IconButton" "@mui/material") [ iconButton.children (children :> seq<ReactElement>) ]

  static member inline imageList props = createElement (import "ImageList" "@mui/material") props

  static member inline imageList (children: #seq<ReactElement>) = createElement (import "ImageList" "@mui/material") [ imageList.children (children :> seq<ReactElement>) ]

  static member inline imageListItem props = createElement (import "ImageListItem" "@mui/material") props

  static member inline imageListItem (children: #seq<ReactElement>) = createElement (import "ImageListItem" "@mui/material") [ imageListItem.children (children :> seq<ReactElement>) ]

  static member inline imageListItemBar props = createElement (import "ImageListItemBar" "@mui/material") props

  static member inline input props = createElement (import "Input" "@mui/material") props

  static member inline inputAdornment props = createElement (import "InputAdornment" "@mui/material") props

  static member inline inputAdornment (children: #seq<ReactElement>) = createElement (import "InputAdornment" "@mui/material") [ inputAdornment.children (children :> seq<ReactElement>) ]

  static member inline inputBase props = createElement (import "InputBase" "@mui/material") props

  static member inline inputLabel props = createElement (import "InputLabel" "@mui/material") props

  static member inline inputLabel (text: string) = createElement (import "InputLabel" "@mui/material") [ prop.children (Html.text text) ]

  static member inline inputLabel (children: #seq<ReactElement>) = createElement (import "InputLabel" "@mui/material") [ inputLabel.children (children :> seq<ReactElement>) ]

  static member inline linearProgress props = createElement (import "LinearProgress" "@mui/material") props

  static member inline link props = createElement (import "Link" "@mui/material") props

  static member inline link (children: #seq<ReactElement>) = createElement (import "Link" "@mui/material") [ link.children (children :> seq<ReactElement>) ]

  static member inline list props = createElement (import "List" "@mui/material") props

  static member inline list (children: #seq<ReactElement>) = createElement (import "List" "@mui/material") [ list.children (children :> seq<ReactElement>) ]

  static member inline listItem props = createElement (import "ListItem" "@mui/material") props

  static member inline listItem (children: #seq<ReactElement>) = createElement (import "ListItem" "@mui/material") [ listItem.children (children :> seq<ReactElement>) ]

  static member inline listItemAvatar props = createElement (import "ListItemAvatar" "@mui/material") props

  static member inline listItemAvatar (children: #seq<ReactElement>) = createElement (import "ListItemAvatar" "@mui/material") [ listItemAvatar.children (children :> seq<ReactElement>) ]

  static member inline listItemButton props = createElement (import "ListItemButton" "@mui/material") props

  static member inline listItemButton (children: #seq<ReactElement>) = createElement (import "ListItemButton" "@mui/material") [ listItemButton.children (children :> seq<ReactElement>) ]

  static member inline listItemIcon props = createElement (import "ListItemIcon" "@mui/material") props

  static member inline listItemIcon (children: #seq<ReactElement>) = createElement (import "ListItemIcon" "@mui/material") [ listItemIcon.children (children :> seq<ReactElement>) ]

  static member inline listItemSecondaryAction props = createElement (import "ListItemSecondaryAction" "@mui/material") props

  static member inline listItemSecondaryAction (children: #seq<ReactElement>) = createElement (import "ListItemSecondaryAction" "@mui/material") [ listItemSecondaryAction.children (children :> seq<ReactElement>) ]

  static member inline listItemText props = createElement (import "ListItemText" "@mui/material") props

  static member inline listItemText (primary: string) = createElement (import "ListItemText" "@mui/material") [ listItemText.primary primary ]

  static member inline listItemText (children: #seq<ReactElement>) = createElement (import "ListItemText" "@mui/material") [ listItemText.children (children :> seq<ReactElement>) ]

  static member inline listSubheader props = createElement (import "ListSubheader" "@mui/material") props

  static member inline listSubheader (text: string) = createElement (import "ListSubheader" "@mui/material") [ prop.children (Html.text text) ]

  static member inline listSubheader (children: #seq<ReactElement>) = createElement (import "ListSubheader" "@mui/material") [ listSubheader.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline loadingButton props = createElement (import "LoadingButton" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline loadingButton (children: #seq<ReactElement>) = createElement (import "LoadingButton" "@mui/lab") [ loadingButton.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline masonry props = createElement (import "Masonry" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline masonry (children: #seq<ReactElement>) = createElement (import "Masonry" "@mui/lab") [ masonry.children (children :> seq<ReactElement>) ]

  static member inline menu props = createElement (import "Menu" "@mui/material") props

  static member inline menu (children: #seq<ReactElement>) = createElement (import "Menu" "@mui/material") [ menu.children (children :> seq<ReactElement>) ]

  static member inline menuItem props = createElement (import "MenuItem" "@mui/material") props

  static member inline menuItem (children: #seq<ReactElement>) = createElement (import "MenuItem" "@mui/material") [ menuItem.children (children :> seq<ReactElement>) ]

  static member inline menuList props = createElement (import "MenuList" "@mui/material") props

  static member inline menuList (children: #seq<ReactElement>) = createElement (import "MenuList" "@mui/material") [ menuList.children (children :> seq<ReactElement>) ]

  static member inline mobileStepper props = createElement (import "MobileStepper" "@mui/material") props

  static member inline modal props = createElement (import "Modal" "@mui/material") props

  static member inline nativeSelect props = createElement (import "NativeSelect" "@mui/material") props

  static member inline nativeSelect (children: #seq<ReactElement>) = createElement (import "NativeSelect" "@mui/material") [ nativeSelect.children (children :> seq<ReactElement>) ]

  static member inline outlinedInput props = createElement (import "OutlinedInput" "@mui/material") props

  static member inline pagination props = createElement (import "Pagination" "@mui/material") props

  static member inline paginationItem props = createElement (import "PaginationItem" "@mui/material") props

  static member inline paper props = createElement (import "Paper" "@mui/material") props

  static member inline paper (children: #seq<ReactElement>) = createElement (import "Paper" "@mui/material") [ paper.children (children :> seq<ReactElement>) ]

  static member inline popover props = createElement (import "Popover" "@mui/material") props

  static member inline popover (children: #seq<ReactElement>) = createElement (import "Popover" "@mui/material") [ popover.children (children :> seq<ReactElement>) ]

  static member inline popper props = createElement (import "Popper" "@mui/material") props

  static member inline popper (children: #seq<ReactElement>) = createElement (import "Popper" "@mui/material") [ popper.children (children :> seq<ReactElement>) ]

  static member inline radio props = createElement (import "Radio" "@mui/material") props

  static member inline radioGroup props = createElement (import "RadioGroup" "@mui/material") props

  static member inline radioGroup (children: #seq<ReactElement>) = createElement (import "RadioGroup" "@mui/material") [ radioGroup.children (children :> seq<ReactElement>) ]

  static member inline rating props = createElement (import "Rating" "@mui/material") props

  static member inline scopedCssBaseline props = createElement (import "ScopedCssBaseline" "@mui/material") props

  static member inline scopedCssBaseline (children: #seq<ReactElement>) = createElement (import "ScopedCssBaseline" "@mui/material") [ scopedCssBaseline.children (children :> seq<ReactElement>) ]

  static member inline select props = createElement (import "Select" "@mui/material") props

  static member inline select (children: #seq<ReactElement>) = createElement (import "Select" "@mui/material") [ select.children (children :> seq<ReactElement>) ]

  static member inline skeleton props = createElement (import "Skeleton" "@mui/material") props

  static member inline skeleton (children: #seq<ReactElement>) = createElement (import "Skeleton" "@mui/material") [ skeleton.children (children :> seq<ReactElement>) ]

  static member inline slide props = createElement (import "Slide" "@mui/material") props

  static member inline slider props = createElement (import "Slider" "@mui/material") props

  static member inline snackbar props = createElement (import "Snackbar" "@mui/material") props

  static member inline snackbarContent props = createElement (import "SnackbarContent" "@mui/material") props

  static member inline speedDial props = createElement (import "SpeedDial" "@mui/material") props

  static member inline speedDial (children: #seq<ReactElement>) = createElement (import "SpeedDial" "@mui/material") [ speedDial.children (children :> seq<ReactElement>) ]

  static member inline speedDialAction props = createElement (import "SpeedDialAction" "@mui/material") props

  static member inline speedDialIcon props = createElement (import "SpeedDialIcon" "@mui/material") props

  static member inline stack props = createElement (import "Stack" "@mui/material") props

  static member inline stack (children: #seq<ReactElement>) = createElement (import "Stack" "@mui/material") [ stack.children (children :> seq<ReactElement>) ]

  static member inline step props = createElement (import "Step" "@mui/material") props

  static member inline step (children: #seq<ReactElement>) = createElement (import "Step" "@mui/material") [ step.children (children :> seq<ReactElement>) ]

  static member inline stepButton props = createElement (import "StepButton" "@mui/material") props

  static member inline stepButton (children: #seq<ReactElement>) = createElement (import "StepButton" "@mui/material") [ stepButton.children (children :> seq<ReactElement>) ]

  static member inline stepConnector props = createElement (import "StepConnector" "@mui/material") props

  static member inline stepContent props = createElement (import "StepContent" "@mui/material") props

  static member inline stepContent (children: #seq<ReactElement>) = createElement (import "StepContent" "@mui/material") [ stepContent.children (children :> seq<ReactElement>) ]

  static member inline stepIcon props = createElement (import "StepIcon" "@mui/material") props

  static member inline stepLabel props = createElement (import "StepLabel" "@mui/material") props

  static member inline stepLabel (text: string) = createElement (import "StepLabel" "@mui/material") [ prop.children (Html.text text) ]

  static member inline stepLabel (children: #seq<ReactElement>) = createElement (import "StepLabel" "@mui/material") [ stepLabel.children (children :> seq<ReactElement>) ]

  static member inline stepper props = createElement (import "Stepper" "@mui/material") props

  static member inline stepper (children: #seq<ReactElement>) = createElement (import "Stepper" "@mui/material") [ stepper.children (children :> seq<ReactElement>) ]

  static member inline svgIcon props = createElement (import "SvgIcon" "@mui/material") props

  static member inline svgIcon (children: #seq<ReactElement>) = createElement (import "SvgIcon" "@mui/material") [ svgIcon.children (children :> seq<ReactElement>) ]

  static member inline swipeableDrawer props = createElement (import "SwipeableDrawer" "@mui/material") props

  static member inline swipeableDrawer (children: #seq<ReactElement>) = createElement (import "SwipeableDrawer" "@mui/material") [ swipeableDrawer.children (children :> seq<ReactElement>) ]

  static member inline switch props = createElement (import "Switch" "@mui/material") props

  static member inline tab props = createElement (import "Tab" "@mui/material") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabContext props = createElement (import "TabContext" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabContext (children: #seq<ReactElement>) = createElement (import "TabContext" "@mui/lab") [ tabContext.children (children :> seq<ReactElement>) ]

  static member inline table props = createElement (import "Table" "@mui/material") props

  static member inline table (children: #seq<ReactElement>) = createElement (import "Table" "@mui/material") [ table.children (children :> seq<ReactElement>) ]

  static member inline tableBody props = createElement (import "TableBody" "@mui/material") props

  static member inline tableBody (children: #seq<ReactElement>) = createElement (import "TableBody" "@mui/material") [ tableBody.children (children :> seq<ReactElement>) ]

  static member inline tableCell props = createElement (import "TableCell" "@mui/material") props

  static member inline tableCell (text: string) = createElement (import "TableCell" "@mui/material") [ prop.children (Html.text text) ]

  static member inline tableCell (children: #seq<ReactElement>) = createElement (import "TableCell" "@mui/material") [ tableCell.children (children :> seq<ReactElement>) ]

  static member inline tableContainer props = createElement (import "TableContainer" "@mui/material") props

  static member inline tableContainer (children: #seq<ReactElement>) = createElement (import "TableContainer" "@mui/material") [ tableContainer.children (children :> seq<ReactElement>) ]

  static member inline tableFooter props = createElement (import "TableFooter" "@mui/material") props

  static member inline tableFooter (children: #seq<ReactElement>) = createElement (import "TableFooter" "@mui/material") [ tableFooter.children (children :> seq<ReactElement>) ]

  static member inline tableHead props = createElement (import "TableHead" "@mui/material") props

  static member inline tableHead (children: #seq<ReactElement>) = createElement (import "TableHead" "@mui/material") [ tableHead.children (children :> seq<ReactElement>) ]

  static member inline tablePagination props = createElement (import "TablePagination" "@mui/material") props

  static member inline tableRow props = createElement (import "TableRow" "@mui/material") props

  static member inline tableRow (children: #seq<ReactElement>) = createElement (import "TableRow" "@mui/material") [ tableRow.children (children :> seq<ReactElement>) ]

  static member inline tableSortLabel props = createElement (import "TableSortLabel" "@mui/material") props

  static member inline tableSortLabel (children: #seq<ReactElement>) = createElement (import "TableSortLabel" "@mui/material") [ tableSortLabel.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabList props = createElement (import "TabList" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabList (children: #seq<ReactElement>) = createElement (import "TabList" "@mui/lab") [ tabList.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabPanel props = createElement (import "TabPanel" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabPanel (children: #seq<ReactElement>) = createElement (import "TabPanel" "@mui/lab") [ tabPanel.children (children :> seq<ReactElement>) ]

  static member inline tabs props = createElement (import "Tabs" "@mui/material") props

  static member inline tabs (children: #seq<ReactElement>) = createElement (import "Tabs" "@mui/material") [ tabs.children (children :> seq<ReactElement>) ]

  static member inline tabScrollButton props = createElement (import "TabScrollButton" "@mui/material") props

  static member inline tabScrollButton (children: #seq<ReactElement>) = createElement (import "TabScrollButton" "@mui/material") [ tabScrollButton.children (children :> seq<ReactElement>) ]

  static member inline textField props = createElement (import "TextField" "@mui/material") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timeline props = createElement (import "Timeline" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timeline (children: #seq<ReactElement>) = createElement (import "Timeline" "@mui/lab") [ timeline.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineConnector props = createElement (import "TimelineConnector" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineConnector (children: #seq<ReactElement>) = createElement (import "TimelineConnector" "@mui/lab") [ timelineConnector.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineContent props = createElement (import "TimelineContent" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineContent (children: #seq<ReactElement>) = createElement (import "TimelineContent" "@mui/lab") [ timelineContent.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineDot props = createElement (import "TimelineDot" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineDot (children: #seq<ReactElement>) = createElement (import "TimelineDot" "@mui/lab") [ timelineDot.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineItem props = createElement (import "TimelineItem" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineItem (children: #seq<ReactElement>) = createElement (import "TimelineItem" "@mui/lab") [ timelineItem.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineOppositeContent props = createElement (import "TimelineOppositeContent" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineOppositeContent (children: #seq<ReactElement>) = createElement (import "TimelineOppositeContent" "@mui/lab") [ timelineOppositeContent.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineSeparator props = createElement (import "TimelineSeparator" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineSeparator (children: #seq<ReactElement>) = createElement (import "TimelineSeparator" "@mui/lab") [ timelineSeparator.children (children :> seq<ReactElement>) ]

  static member inline toggleButton props = createElement (import "ToggleButton" "@mui/material") props

  static member inline toggleButton (children: #seq<ReactElement>) = createElement (import "ToggleButton" "@mui/material") [ toggleButton.children (children :> seq<ReactElement>) ]

  static member inline toggleButtonGroup props = createElement (import "ToggleButtonGroup" "@mui/material") props

  static member inline toggleButtonGroup (children: #seq<ReactElement>) = createElement (import "ToggleButtonGroup" "@mui/material") [ toggleButtonGroup.children (children :> seq<ReactElement>) ]

  static member inline toolbar props = createElement (import "Toolbar" "@mui/material") props

  static member inline toolbar (children: #seq<ReactElement>) = createElement (import "Toolbar" "@mui/material") [ toolbar.children (children :> seq<ReactElement>) ]

  static member inline tooltip props = createElement (import "Tooltip" "@mui/material") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline treeItem props = createElement (import "TreeItem" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline treeItem (children: #seq<ReactElement>) = createElement (import "TreeItem" "@mui/lab") [ treeItem.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline treeView props = createElement (import "TreeView" "@mui/lab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline treeView (children: #seq<ReactElement>) = createElement (import "TreeView" "@mui/lab") [ treeView.children (children :> seq<ReactElement>) ]

  static member inline typography props = createElement (import "Typography" "@mui/material") props

  static member inline typography (text: string) = createElement (import "Typography" "@mui/material") [ prop.children (Html.text text) ]

  static member inline typography (children: #seq<ReactElement>) = createElement (import "Typography" "@mui/material") [ typography.children (children :> seq<ReactElement>) ]

  static member inline zoom props = createElement (import "Zoom" "@mui/material") props
