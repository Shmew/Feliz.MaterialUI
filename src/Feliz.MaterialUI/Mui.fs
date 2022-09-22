namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module MuiHelpers =

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

  static member inline themeProvider props = createElement (import "ThemeProvider" "@mui/material/styles") props

  /// This component allows you to change the behavior of the styling solution. It makes the options available down the React tree thanks to the context.
  ///
  /// It should preferably be used at **the root of your component tree**.
  static member inline stylesProvider props = createElement (import "StylesProvider" "@mui/styles") props

  /// This component allows you to change styes import precedence and thereby override default MUI styles.
  /// Documentation: https://mui.com/material-ui/guides/interoperability/#css-injection-order
  static member inline styledEngineProvider props = createElement (import "StyledEngineProvider" "@mui/material/styles") props

  /// If you are using Emotion and have a custom cache in your app, it will override the one coming from MUI.
  /// In order for the injection order to still be correct, you need to add the prepend option.
  static member inline cacheProvider props = createElement (import "CacheProvider" "@emotion/react") props

  static member inline accordion props = createElement (importDefault "@mui/material/Accordion") props

  static member inline accordion (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Accordion") [ Feliz.MaterialUI.accordion.children (children :> seq<ReactElement>) ]

  static member inline accordionActions props = createElement (importDefault "@mui/material/AccordionActions") props

  static member inline accordionActions (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AccordionActions") [ Feliz.MaterialUI.accordionActions.children (children :> seq<ReactElement>) ]

  static member inline accordionDetails props = createElement (importDefault "@mui/material/AccordionDetails") props

  static member inline accordionDetails (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AccordionDetails") [ Feliz.MaterialUI.accordionDetails.children (children :> seq<ReactElement>) ]

  static member inline accordionSummary props = createElement (importDefault "@mui/material/AccordionSummary") props

  static member inline accordionSummary (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AccordionSummary") [ Feliz.MaterialUI.accordionSummary.children (children :> seq<ReactElement>) ]

  static member inline alert props = createElement (importDefault "@mui/material/Alert") props

  static member inline alert (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Alert") [ Feliz.MaterialUI.alert.children (children :> seq<ReactElement>) ]

  static member inline alertTitle props = createElement (importDefault "@mui/material/AlertTitle") props

  static member inline alertTitle (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AlertTitle") [ Feliz.MaterialUI.alertTitle.children (children :> seq<ReactElement>) ]

  static member inline appBar props = createElement (importDefault "@mui/material/AppBar") props

  static member inline appBar (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AppBar") [ Feliz.MaterialUI.appBar.children (children :> seq<ReactElement>) ]

  static member inline autocomplete props = createElement (importDefault "@mui/material/Autocomplete") props

  static member inline avatar props = createElement (importDefault "@mui/material/Avatar") props

  static member inline avatar (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Avatar") [ Feliz.MaterialUI.avatar.children (children :> seq<ReactElement>) ]

  static member inline avatarGroup props = createElement (importDefault "@mui/material/AvatarGroup") props

  static member inline avatarGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AvatarGroup") [ Feliz.MaterialUI.avatarGroup.children (children :> seq<ReactElement>) ]

  static member inline backdrop props = createElement (importDefault "@mui/material/Backdrop") props

  static member inline backdrop (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Backdrop") [ Feliz.MaterialUI.backdrop.children (children :> seq<ReactElement>) ]

  static member inline badge props = createElement (importDefault "@mui/material/Badge") props

  static member inline badge (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Badge") [ Feliz.MaterialUI.badge.children (children :> seq<ReactElement>) ]

  static member inline bottomNavigation props = createElement (importDefault "@mui/material/BottomNavigation") props

  static member inline bottomNavigation (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/BottomNavigation") [ Feliz.MaterialUI.bottomNavigation.children (children :> seq<ReactElement>) ]

  static member inline bottomNavigationAction props = createElement (importDefault "@mui/material/BottomNavigationAction") props

  static member inline box props = createElement (importDefault "@mui/material/Box") props

  static member inline box (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Box") [ Feliz.MaterialUI.box.children (children :> seq<ReactElement>) ]

  static member inline breadcrumbs props = createElement (importDefault "@mui/material/Breadcrumbs") props

  static member inline breadcrumbs (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Breadcrumbs") [ Feliz.MaterialUI.breadcrumbs.children (children :> seq<ReactElement>) ]

  static member inline button props = createElement (importDefault "@mui/material/Button") props

  static member inline button (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Button") [ Feliz.MaterialUI.button.children (children :> seq<ReactElement>) ]

  static member inline buttonBase props = createElement (importDefault "@mui/material/ButtonBase") props

  static member inline buttonBase (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ButtonBase") [ Feliz.MaterialUI.buttonBase.children (children :> seq<ReactElement>) ]

  static member inline buttonGroup props = createElement (importDefault "@mui/material/ButtonGroup") props

  static member inline buttonGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ButtonGroup") [ Feliz.MaterialUI.buttonGroup.children (children :> seq<ReactElement>) ]

  static member inline card props = createElement (importDefault "@mui/material/Card") props

  static member inline card (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Card") [ Feliz.MaterialUI.card.children (children :> seq<ReactElement>) ]

  static member inline cardActionArea props = createElement (importDefault "@mui/material/CardActionArea") props

  static member inline cardActionArea (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CardActionArea") [ Feliz.MaterialUI.cardActionArea.children (children :> seq<ReactElement>) ]

  static member inline cardActions props = createElement (importDefault "@mui/material/CardActions") props

  static member inline cardActions (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CardActions") [ Feliz.MaterialUI.cardActions.children (children :> seq<ReactElement>) ]

  static member inline cardContent props = createElement (importDefault "@mui/material/CardContent") props

  static member inline cardContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CardContent") [ Feliz.MaterialUI.cardContent.children (children :> seq<ReactElement>) ]

  static member inline cardHeader props = createElement (importDefault "@mui/material/CardHeader") props

  static member inline cardMedia props = createElement (importDefault "@mui/material/CardMedia") props

  static member inline cardMedia (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CardMedia") [ Feliz.MaterialUI.cardMedia.children (children :> seq<ReactElement>) ]

  static member inline checkbox props = createElement (importDefault "@mui/material/Checkbox") props

  static member inline chip props = createElement (importDefault "@mui/material/Chip") props

  static member inline circularProgress props = createElement (importDefault "@mui/material/CircularProgress") props

  static member inline collapse props = createElement (importDefault "@mui/material/Collapse") props

  static member inline collapse (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Collapse") [ Feliz.MaterialUI.collapse.children (children :> seq<ReactElement>) ]

  static member inline container props = createElement (importDefault "@mui/material/Container") props

  static member inline container (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Container") [ Feliz.MaterialUI.container.children (children :> seq<ReactElement>) ]

  static member inline cssBaseline props = createElement (importDefault "@mui/material/CssBaseline") props

  static member inline cssBaseline (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CssBaseline") [ Feliz.MaterialUI.cssBaseline.children (children :> seq<ReactElement>) ]

  static member inline dialog props = createElement (importDefault "@mui/material/Dialog") props

  static member inline dialog (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Dialog") [ Feliz.MaterialUI.dialog.children (children :> seq<ReactElement>) ]

  static member inline dialogActions props = createElement (importDefault "@mui/material/DialogActions") props

  static member inline dialogActions (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/DialogActions") [ Feliz.MaterialUI.dialogActions.children (children :> seq<ReactElement>) ]

  static member inline dialogContent props = createElement (importDefault "@mui/material/DialogContent") props

  static member inline dialogContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/DialogContent") [ Feliz.MaterialUI.dialogContent.children (children :> seq<ReactElement>) ]

  static member inline dialogContentText props = createElement (importDefault "@mui/material/DialogContentText") props

  static member inline dialogContentText (text: string) = createElement (importDefault "@mui/material/DialogContentText") [ prop.children (Html.text text) ]

  static member inline dialogContentText (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/DialogContentText") [ Feliz.MaterialUI.dialogContentText.children (children :> seq<ReactElement>) ]

  static member inline dialogTitle props = createElement (importDefault "@mui/material/DialogTitle") props

  static member inline dialogTitle (text: string) = createElement (importDefault "@mui/material/DialogTitle") [ prop.children (Html.text text) ]

  static member inline dialogTitle (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/DialogTitle") [ Feliz.MaterialUI.dialogTitle.children (children :> seq<ReactElement>) ]

  static member inline divider props = createElement (importDefault "@mui/material/Divider") props

  static member inline divider (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Divider") [ Feliz.MaterialUI.divider.children (children :> seq<ReactElement>) ]

  static member inline drawer props = createElement (importDefault "@mui/material/Drawer") props

  static member inline drawer (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Drawer") [ Feliz.MaterialUI.drawer.children (children :> seq<ReactElement>) ]

  static member inline fab props = createElement (importDefault "@mui/material/Fab") props

  static member inline fab (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Fab") [ Feliz.MaterialUI.fab.children (children :> seq<ReactElement>) ]

  static member inline fade props = createElement (importDefault "@mui/material/Fade") props

  static member inline filledInput props = createElement (importDefault "@mui/material/FilledInput") props

  static member inline formControl props = createElement (importDefault "@mui/material/FormControl") props

  static member inline formControl (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/FormControl") [ Feliz.MaterialUI.formControl.children (children :> seq<ReactElement>) ]

  static member inline formControlLabel props = createElement (importDefault "@mui/material/FormControlLabel") props

  static member inline formGroup props = createElement (importDefault "@mui/material/FormGroup") props

  static member inline formGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/FormGroup") [ Feliz.MaterialUI.formGroup.children (children :> seq<ReactElement>) ]

  static member inline formHelperText props = createElement (importDefault "@mui/material/FormHelperText") props

  static member inline formHelperText (text: string) = createElement (importDefault "@mui/material/FormHelperText") [ prop.children (Html.text text) ]

  static member inline formHelperText (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/FormHelperText") [ Feliz.MaterialUI.formHelperText.children (children :> seq<ReactElement>) ]

  static member inline formLabel props = createElement (importDefault "@mui/material/FormLabel") props

  static member inline formLabel (text: string) = createElement (importDefault "@mui/material/FormLabel") [ prop.children (Html.text text) ]

  static member inline formLabel (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/FormLabel") [ Feliz.MaterialUI.formLabel.children (children :> seq<ReactElement>) ]

  static member inline globalStyles props = createElement (importDefault "@mui/material/GlobalStyles") props

  static member inline grid props = createElement (importDefault "@mui/material/Grid") props

  static member inline grid (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Grid") [ Feliz.MaterialUI.grid.children (children :> seq<ReactElement>) ]

  static member inline grow props = createElement (importDefault "@mui/material/Grow") props

  static member inline hidden props = createElement (importDefault "@mui/material/Hidden") props

  static member inline hidden (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Hidden") [ Feliz.MaterialUI.hidden.children (children :> seq<ReactElement>) ]

  static member inline icon props = createElement (importDefault "@mui/material/Icon") props

  static member inline icon (name: string) = createElement (importDefault "@mui/material/Icon") [ prop.children (Html.text name) ]

  static member inline icon (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Icon") [ Feliz.MaterialUI.icon.children (children :> seq<ReactElement>) ]

  static member inline iconButton props = createElement (importDefault "@mui/material/IconButton") props

  static member inline iconButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/IconButton") [ Feliz.MaterialUI.iconButton.children (children :> seq<ReactElement>) ]

  static member inline imageList props = createElement (importDefault "@mui/material/ImageList") props

  static member inline imageList (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ImageList") [ Feliz.MaterialUI.imageList.children (children :> seq<ReactElement>) ]

  static member inline imageListItem props = createElement (importDefault "@mui/material/ImageListItem") props

  static member inline imageListItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ImageListItem") [ Feliz.MaterialUI.imageListItem.children (children :> seq<ReactElement>) ]

  static member inline imageListItemBar props = createElement (importDefault "@mui/material/ImageListItemBar") props

  static member inline input props = createElement (importDefault "@mui/material/Input") props

  static member inline inputAdornment props = createElement (importDefault "@mui/material/InputAdornment") props

  static member inline inputAdornment (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/InputAdornment") [ Feliz.MaterialUI.inputAdornment.children (children :> seq<ReactElement>) ]

  static member inline inputBase props = createElement (importDefault "@mui/material/InputBase") props

  static member inline inputLabel props = createElement (importDefault "@mui/material/InputLabel") props

  static member inline inputLabel (text: string) = createElement (importDefault "@mui/material/InputLabel") [ prop.children (Html.text text) ]

  static member inline inputLabel (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/InputLabel") [ Feliz.MaterialUI.inputLabel.children (children :> seq<ReactElement>) ]

  static member inline linearProgress props = createElement (importDefault "@mui/material/LinearProgress") props

  static member inline link props = createElement (importDefault "@mui/material/Link") props

  static member inline link (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Link") [ Feliz.MaterialUI.link.children (children :> seq<ReactElement>) ]

  static member inline list props = createElement (importDefault "@mui/material/List") props

  static member inline list (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/List") [ Feliz.MaterialUI.list.children (children :> seq<ReactElement>) ]

  static member inline listItem props = createElement (importDefault "@mui/material/ListItem") props

  static member inline listItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItem") [ Feliz.MaterialUI.listItem.children (children :> seq<ReactElement>) ]

  static member inline listItemAvatar props = createElement (importDefault "@mui/material/ListItemAvatar") props

  static member inline listItemAvatar (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemAvatar") [ Feliz.MaterialUI.listItemAvatar.children (children :> seq<ReactElement>) ]

  static member inline listItemButton props = createElement (importDefault "@mui/material/ListItemButton") props

  static member inline listItemButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemButton") [ Feliz.MaterialUI.listItemButton.children (children :> seq<ReactElement>) ]

  static member inline listItemIcon props = createElement (importDefault "@mui/material/ListItemIcon") props

  static member inline listItemIcon (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemIcon") [ Feliz.MaterialUI.listItemIcon.children (children :> seq<ReactElement>) ]

  static member inline listItemSecondaryAction props = createElement (importDefault "@mui/material/ListItemSecondaryAction") props

  static member inline listItemSecondaryAction (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemSecondaryAction") [ Feliz.MaterialUI.listItemSecondaryAction.children (children :> seq<ReactElement>) ]

  static member inline listItemText props = createElement (importDefault "@mui/material/ListItemText") props

  static member inline listItemText (primary: string) = createElement (importDefault "@mui/material/ListItemText") [ listItemText.primary primary ]

  static member inline listItemText (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemText") [ Feliz.MaterialUI.listItemText.children (children :> seq<ReactElement>) ]

  static member inline listSubheader props = createElement (importDefault "@mui/material/ListSubheader") props

  static member inline listSubheader (text: string) = createElement (importDefault "@mui/material/ListSubheader") [ prop.children (Html.text text) ]

  static member inline listSubheader (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListSubheader") [ Feliz.MaterialUI.listSubheader.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline loadingButton props = createElement (importDefault "@mui/lab/LoadingButton") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline loadingButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/LoadingButton") [ Feliz.MaterialUI.loadingButton.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline masonry props = createElement (importDefault "@mui/lab/Masonry") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline masonry (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/Masonry") [ Feliz.MaterialUI.masonry.children (children :> seq<ReactElement>) ]

  static member inline menu props = createElement (importDefault "@mui/material/Menu") props

  static member inline menu (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Menu") [ Feliz.MaterialUI.menu.children (children :> seq<ReactElement>) ]

  static member inline menuItem props = createElement (importDefault "@mui/material/MenuItem") props

  static member inline menuItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/MenuItem") [ Feliz.MaterialUI.menuItem.children (children :> seq<ReactElement>) ]

  static member inline menuList props = createElement (importDefault "@mui/material/MenuList") props

  static member inline menuList (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/MenuList") [ Feliz.MaterialUI.menuList.children (children :> seq<ReactElement>) ]

  static member inline mobileStepper props = createElement (importDefault "@mui/material/MobileStepper") props

  static member inline modal props = createElement (importDefault "@mui/material/Modal") props

  static member inline nativeSelect props = createElement (importDefault "@mui/material/NativeSelect") props

  static member inline nativeSelect (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/NativeSelect") [ Feliz.MaterialUI.nativeSelect.children (children :> seq<ReactElement>) ]

  static member inline outlinedInput props = createElement (importDefault "@mui/material/OutlinedInput") props

  static member inline pagination props = createElement (importDefault "@mui/material/Pagination") props

  static member inline paginationItem props = createElement (importDefault "@mui/material/PaginationItem") props

  static member inline paper props = createElement (importDefault "@mui/material/Paper") props

  static member inline paper (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Paper") [ Feliz.MaterialUI.paper.children (children :> seq<ReactElement>) ]

  static member inline popover props = createElement (importDefault "@mui/material/Popover") props

  static member inline popover (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Popover") [ Feliz.MaterialUI.popover.children (children :> seq<ReactElement>) ]

  static member inline popper props = createElement (importDefault "@mui/material/Popper") props

  static member inline popper (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Popper") [ Feliz.MaterialUI.popper.children (children :> seq<ReactElement>) ]

  static member inline radio props = createElement (importDefault "@mui/material/Radio") props

  static member inline radioGroup props = createElement (importDefault "@mui/material/RadioGroup") props

  static member inline radioGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/RadioGroup") [ Feliz.MaterialUI.radioGroup.children (children :> seq<ReactElement>) ]

  static member inline rating props = createElement (importDefault "@mui/material/Rating") props

  static member inline scopedCssBaseline props = createElement (importDefault "@mui/material/ScopedCssBaseline") props

  static member inline scopedCssBaseline (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ScopedCssBaseline") [ Feliz.MaterialUI.scopedCssBaseline.children (children :> seq<ReactElement>) ]

  static member inline select props = createElement (importDefault "@mui/material/Select") props

  static member inline select (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Select") [ Feliz.MaterialUI.select.children (children :> seq<ReactElement>) ]

  static member inline skeleton props = createElement (importDefault "@mui/material/Skeleton") props

  static member inline skeleton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Skeleton") [ Feliz.MaterialUI.skeleton.children (children :> seq<ReactElement>) ]

  static member inline slide props = createElement (importDefault "@mui/material/Slide") props

  static member inline slider props = createElement (importDefault "@mui/material/Slider") props

  static member inline snackbar props = createElement (importDefault "@mui/material/Snackbar") props

  static member inline snackbarContent props = createElement (importDefault "@mui/material/SnackbarContent") props

  static member inline speedDial props = createElement (importDefault "@mui/material/SpeedDial") props

  static member inline speedDial (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/SpeedDial") [ Feliz.MaterialUI.speedDial.children (children :> seq<ReactElement>) ]

  static member inline speedDialAction props = createElement (importDefault "@mui/material/SpeedDialAction") props

  static member inline speedDialIcon props = createElement (importDefault "@mui/material/SpeedDialIcon") props

  static member inline stack props = createElement (importDefault "@mui/material/Stack") props

  static member inline stack (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Stack") [ Feliz.MaterialUI.stack.children (children :> seq<ReactElement>) ]

  static member inline step props = createElement (importDefault "@mui/material/Step") props

  static member inline step (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Step") [ Feliz.MaterialUI.step.children (children :> seq<ReactElement>) ]

  static member inline stepButton props = createElement (importDefault "@mui/material/StepButton") props

  static member inline stepButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/StepButton") [ Feliz.MaterialUI.stepButton.children (children :> seq<ReactElement>) ]

  static member inline stepConnector props = createElement (importDefault "@mui/material/StepConnector") props

  static member inline stepContent props = createElement (importDefault "@mui/material/StepContent") props

  static member inline stepContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/StepContent") [ Feliz.MaterialUI.stepContent.children (children :> seq<ReactElement>) ]

  static member inline stepIcon props = createElement (importDefault "@mui/material/StepIcon") props

  static member inline stepLabel props = createElement (importDefault "@mui/material/StepLabel") props

  static member inline stepLabel (text: string) = createElement (importDefault "@mui/material/StepLabel") [ prop.children (Html.text text) ]

  static member inline stepLabel (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/StepLabel") [ Feliz.MaterialUI.stepLabel.children (children :> seq<ReactElement>) ]

  static member inline stepper props = createElement (importDefault "@mui/material/Stepper") props

  static member inline stepper (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Stepper") [ Feliz.MaterialUI.stepper.children (children :> seq<ReactElement>) ]

  static member inline svgIcon props = createElement (importDefault "@mui/material/SvgIcon") props

  static member inline svgIcon (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/SvgIcon") [ Feliz.MaterialUI.svgIcon.children (children :> seq<ReactElement>) ]

  static member inline swipeableDrawer props = createElement (importDefault "@mui/material/SwipeableDrawer") props

  static member inline swipeableDrawer (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/SwipeableDrawer") [ Feliz.MaterialUI.swipeableDrawer.children (children :> seq<ReactElement>) ]

  static member inline switch props = createElement (importDefault "@mui/material/Switch") props

  static member inline tab props = createElement (importDefault "@mui/material/Tab") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabContext props = createElement (importDefault "@mui/lab/TabContext") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabContext (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TabContext") [ Feliz.MaterialUI.tabContext.children (children :> seq<ReactElement>) ]

  static member inline table props = createElement (importDefault "@mui/material/Table") props

  static member inline table (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Table") [ Feliz.MaterialUI.table.children (children :> seq<ReactElement>) ]

  static member inline tableBody props = createElement (importDefault "@mui/material/TableBody") props

  static member inline tableBody (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableBody") [ Feliz.MaterialUI.tableBody.children (children :> seq<ReactElement>) ]

  static member inline tableCell props = createElement (importDefault "@mui/material/TableCell") props

  static member inline tableCell (text: string) = createElement (importDefault "@mui/material/TableCell") [ prop.children (Html.text text) ]

  static member inline tableCell (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableCell") [ Feliz.MaterialUI.tableCell.children (children :> seq<ReactElement>) ]

  static member inline tableContainer props = createElement (importDefault "@mui/material/TableContainer") props

  static member inline tableContainer (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableContainer") [ Feliz.MaterialUI.tableContainer.children (children :> seq<ReactElement>) ]

  static member inline tableFooter props = createElement (importDefault "@mui/material/TableFooter") props

  static member inline tableFooter (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableFooter") [ Feliz.MaterialUI.tableFooter.children (children :> seq<ReactElement>) ]

  static member inline tableHead props = createElement (importDefault "@mui/material/TableHead") props

  static member inline tableHead (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableHead") [ Feliz.MaterialUI.tableHead.children (children :> seq<ReactElement>) ]

  static member inline tablePagination props = createElement (importDefault "@mui/material/TablePagination") props

  static member inline tableRow props = createElement (importDefault "@mui/material/TableRow") props

  static member inline tableRow (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableRow") [ Feliz.MaterialUI.tableRow.children (children :> seq<ReactElement>) ]

  static member inline tableSortLabel props = createElement (importDefault "@mui/material/TableSortLabel") props

  static member inline tableSortLabel (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableSortLabel") [ Feliz.MaterialUI.tableSortLabel.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabList props = createElement (importDefault "@mui/lab/TabList") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabList (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TabList") [ Feliz.MaterialUI.tabList.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabPanel props = createElement (importDefault "@mui/lab/TabPanel") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline tabPanel (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TabPanel") [ Feliz.MaterialUI.tabPanel.children (children :> seq<ReactElement>) ]

  static member inline tabs props = createElement (importDefault "@mui/material/Tabs") props

  static member inline tabs (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Tabs") [ Feliz.MaterialUI.tabs.children (children :> seq<ReactElement>) ]

  static member inline tabScrollButton props = createElement (importDefault "@mui/material/TabScrollButton") props

  static member inline tabScrollButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TabScrollButton") [ Feliz.MaterialUI.tabScrollButton.children (children :> seq<ReactElement>) ]

  static member inline textField props = createElement (importDefault "@mui/material/TextField") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timeline props = createElement (importDefault "@mui/lab/Timeline") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timeline (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/Timeline") [ Feliz.MaterialUI.timeline.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineConnector props = createElement (importDefault "@mui/lab/TimelineConnector") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineConnector (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineConnector") [ Feliz.MaterialUI.timelineConnector.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineContent props = createElement (importDefault "@mui/lab/TimelineContent") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineContent") [ Feliz.MaterialUI.timelineContent.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineDot props = createElement (importDefault "@mui/lab/TimelineDot") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineDot (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineDot") [ Feliz.MaterialUI.timelineDot.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineItem props = createElement (importDefault "@mui/lab/TimelineItem") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineItem") [ Feliz.MaterialUI.timelineItem.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineOppositeContent props = createElement (importDefault "@mui/lab/TimelineOppositeContent") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineOppositeContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineOppositeContent") [ Feliz.MaterialUI.timelineOppositeContent.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineSeparator props = createElement (importDefault "@mui/lab/TimelineSeparator") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline timelineSeparator (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineSeparator") [ Feliz.MaterialUI.timelineSeparator.children (children :> seq<ReactElement>) ]

  static member inline toggleButton props = createElement (importDefault "@mui/material/ToggleButton") props

  static member inline toggleButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ToggleButton") [ Feliz.MaterialUI.toggleButton.children (children :> seq<ReactElement>) ]

  static member inline toggleButtonGroup props = createElement (importDefault "@mui/material/ToggleButtonGroup") props

  static member inline toggleButtonGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ToggleButtonGroup") [ Feliz.MaterialUI.toggleButtonGroup.children (children :> seq<ReactElement>) ]

  static member inline toolbar props = createElement (importDefault "@mui/material/Toolbar") props

  static member inline toolbar (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Toolbar") [ Feliz.MaterialUI.toolbar.children (children :> seq<ReactElement>) ]

  static member inline tooltip props = createElement (importDefault "@mui/material/Tooltip") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline treeItem props = createElement (importDefault "@mui/lab/TreeItem") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline treeItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TreeItem") [ Feliz.MaterialUI.treeItem.children (children :> seq<ReactElement>) ]

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline treeView props = createElement (importDefault "@mui/lab/TreeView") props

  /// **This is an experimental component from @mui/lab. Breaking changes may occur at any time.**
  ///
  static member inline treeView (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TreeView") [ Feliz.MaterialUI.treeView.children (children :> seq<ReactElement>) ]

  static member inline typography props = createElement (importDefault "@mui/material/Typography") props

  static member inline typography (text: string) = createElement (importDefault "@mui/material/Typography") [ prop.children (Html.text text) ]

  static member inline typography (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Typography") [ Feliz.MaterialUI.typography.children (children :> seq<ReactElement>) ]

  static member inline zoom props = createElement (importDefault "@mui/material/Zoom") props

  static member inline calendarPicker props = createElement (importDefault "@mui/x-date-pickers-pro/CalendarPicker") props

  static member inline calendarPickerSkeleton props = createElement (importDefault "@mui/x-date-pickers-pro/CalendarPickerSkeleton") props

  static member inline clockPicker props = createElement (importDefault "@mui/x-date-pickers-pro/ClockPicker") props

  static member inline datePicker props = createElement (importDefault "@mui/x-date-pickers-pro/DatePicker") props

  static member inline dateRangePicker props = createElement (importDefault "@mui/x-date-pickers-pro/DateRangePicker") props

  static member inline dateRangePickerDay props = createElement (importDefault "@mui/x-date-pickers-pro/DateRangePickerDay") props

  static member inline dateTimePicker props = createElement (importDefault "@mui/x-date-pickers-pro/DateTimePicker") props

  static member inline desktopDatePicker props = createElement (importDefault "@mui/x-date-pickers-pro/DesktopDatePicker") props

  static member inline desktopDateRangePicker props = createElement (importDefault "@mui/x-date-pickers-pro/DesktopDateRangePicker") props

  static member inline desktopDateTimePicker props = createElement (importDefault "@mui/x-date-pickers-pro/DesktopDateTimePicker") props

  static member inline desktopTimePicker props = createElement (importDefault "@mui/x-date-pickers-pro/DesktopTimePicker") props

  static member inline localizationProvider props = createElement (importDefault "@mui/x-date-pickers-pro/LocalizationProvider") props

  static member inline localizationProvider (children: #seq<ReactElement>) = createElement (importDefault "@mui/x-date-pickers-pro/LocalizationProvider") [ Feliz.MaterialUI.localizationProvider.children (children :> seq<ReactElement>) ]

  static member inline mobileDatePicker props = createElement (importDefault "@mui/x-date-pickers-pro/MobileDatePicker") props

  static member inline mobileDateRangePicker props = createElement (importDefault "@mui/x-date-pickers-pro/MobileDateRangePicker") props

  static member inline mobileDateTimePicker props = createElement (importDefault "@mui/x-date-pickers-pro/MobileDateTimePicker") props

  static member inline mobileTimePicker props = createElement (importDefault "@mui/x-date-pickers-pro/MobileTimePicker") props

  static member inline monthPicker props = createElement (importDefault "@mui/x-date-pickers-pro/MonthPicker") props

  static member inline pickersDay props = createElement (importDefault "@mui/x-date-pickers-pro/PickersDay") props

  static member inline staticDatePicker props = createElement (importDefault "@mui/x-date-pickers-pro/StaticDatePicker") props

  static member inline staticDateRangePicker props = createElement (importDefault "@mui/x-date-pickers-pro/StaticDateRangePicker") props

  static member inline staticDateTimePicker props = createElement (importDefault "@mui/x-date-pickers-pro/StaticDateTimePicker") props

  static member inline staticTimePicker props = createElement (importDefault "@mui/x-date-pickers-pro/StaticTimePicker") props

  static member inline timePicker props = createElement (importDefault "@mui/x-date-pickers-pro/TimePicker") props

  static member inline yearPicker props = createElement (importDefault "@mui/x-date-pickers-pro/YearPicker") props
