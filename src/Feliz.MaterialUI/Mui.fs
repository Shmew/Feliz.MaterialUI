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

  static member inline themeProvider props = createElement (import "ThemeProvider" "@material-ui/core/styles") props

  /// This component allows you to change the behavior of the styling solution. It makes the options available down the React tree thanks to the context.
  ///
  /// It should preferably be used at **the root of your component tree**.
  static member inline stylesProvider props = createElement (import "StylesProvider" "@material-ui/core/styles") props

  static member inline accordion props = createElement (importDefault "@mui/material/Accordion") props

  static member inline accordion (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Accordion") [ Feliz.MaterialUI.accordion.children (children :> ReactElement seq) ]

  static member inline accordionActions props = createElement (importDefault "@mui/material/AccordionActions") props

  static member inline accordionActions (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AccordionActions") [ Feliz.MaterialUI.accordionActions.children (children :> ReactElement seq) ]

  static member inline accordionDetails props = createElement (importDefault "@mui/material/AccordionDetails") props

  static member inline accordionDetails (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AccordionDetails") [ Feliz.MaterialUI.accordionDetails.children (children :> ReactElement seq) ]

  static member inline accordionSummary props = createElement (importDefault "@mui/material/AccordionSummary") props

  static member inline accordionSummary (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AccordionSummary") [ Feliz.MaterialUI.accordionSummary.children (children :> ReactElement seq) ]

  static member inline alert props = createElement (importDefault "@mui/material/Alert") props

  static member inline alert (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Alert") [ Feliz.MaterialUI.alert.children (children :> ReactElement seq) ]

  static member inline alertTitle props = createElement (importDefault "@mui/material/AlertTitle") props

  static member inline alertTitle (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AlertTitle") [ Feliz.MaterialUI.alertTitle.children (children :> ReactElement seq) ]

  static member inline appBar props = createElement (importDefault "@mui/material/AppBar") props

  static member inline appBar (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AppBar") [ Feliz.MaterialUI.appBar.children (children :> ReactElement seq) ]

  static member inline autocomplete props = createElement (importDefault "@mui/material/Autocomplete") props

  static member inline avatar props = createElement (importDefault "@mui/material/Avatar") props

  static member inline avatar (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Avatar") [ Feliz.MaterialUI.avatar.children (children :> ReactElement seq) ]

  static member inline avatarGroup props = createElement (importDefault "@mui/material/AvatarGroup") props

  static member inline avatarGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/AvatarGroup") [ Feliz.MaterialUI.avatarGroup.children (children :> ReactElement seq) ]

  static member inline backdrop props = createElement (importDefault "@mui/material/Backdrop") props

  static member inline backdrop (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Backdrop") [ Feliz.MaterialUI.backdrop.children (children :> ReactElement seq) ]

  static member inline backdropUnstyled props = createElement (importDefault "@mui/base/BackdropUnstyled") props

  static member inline backdropUnstyled (children: #seq<ReactElement>) = createElement (importDefault "@mui/base/BackdropUnstyled") [ Feliz.MaterialUI.backdropUnstyled.children (children :> ReactElement seq) ]

  static member inline badge props = createElement (importDefault "@mui/material/Badge") props

  static member inline badge (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Badge") [ Feliz.MaterialUI.badge.children (children :> ReactElement seq) ]

  static member inline badgeUnstyled props = createElement (importDefault "@mui/base/BadgeUnstyled") props

  static member inline badgeUnstyled (children: #seq<ReactElement>) = createElement (importDefault "@mui/base/BadgeUnstyled") [ Feliz.MaterialUI.badgeUnstyled.children (children :> ReactElement seq) ]

  static member inline bottomNavigation props = createElement (importDefault "@mui/material/BottomNavigation") props

  static member inline bottomNavigation (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/BottomNavigation") [ Feliz.MaterialUI.bottomNavigation.children (children :> ReactElement seq) ]

  static member inline bottomNavigationAction props = createElement (importDefault "@mui/material/BottomNavigationAction") props

  static member inline breadcrumbs props = createElement (importDefault "@mui/material/Breadcrumbs") props

  static member inline breadcrumbs (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Breadcrumbs") [ Feliz.MaterialUI.breadcrumbs.children (children :> ReactElement seq) ]

  static member inline button props = createElement (importDefault "@mui/material/Button") props

  static member inline button (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Button") [ Feliz.MaterialUI.button.children (children :> ReactElement seq) ]

  static member inline buttonBase props = createElement (importDefault "@mui/material/ButtonBase") props

  static member inline buttonBase (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ButtonBase") [ Feliz.MaterialUI.buttonBase.children (children :> ReactElement seq) ]

  static member inline buttonGroup props = createElement (importDefault "@mui/material/ButtonGroup") props

  static member inline buttonGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ButtonGroup") [ Feliz.MaterialUI.buttonGroup.children (children :> ReactElement seq) ]

  static member inline buttonUnstyled props = createElement (importDefault "@mui/base/ButtonUnstyled") props

  static member inline calendarPicker props = createElement (importDefault "@mui/lab/CalendarPicker") props

  static member inline calendarPickerSkeleton props = createElement (importDefault "@mui/lab/CalendarPickerSkeleton") props

  static member inline card props = createElement (importDefault "@mui/material/Card") props

  static member inline card (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Card") [ Feliz.MaterialUI.card.children (children :> ReactElement seq) ]

  static member inline cardActionArea props = createElement (importDefault "@mui/material/CardActionArea") props

  static member inline cardActionArea (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CardActionArea") [ Feliz.MaterialUI.cardActionArea.children (children :> ReactElement seq) ]

  static member inline cardActions props = createElement (importDefault "@mui/material/CardActions") props

  static member inline cardActions (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CardActions") [ Feliz.MaterialUI.cardActions.children (children :> ReactElement seq) ]

  static member inline cardContent props = createElement (importDefault "@mui/material/CardContent") props

  static member inline cardContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CardContent") [ Feliz.MaterialUI.cardContent.children (children :> ReactElement seq) ]

  static member inline cardHeader props = createElement (importDefault "@mui/material/CardHeader") props

  static member inline cardMedia props = createElement (importDefault "@mui/material/CardMedia") props

  static member inline cardMedia (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CardMedia") [ Feliz.MaterialUI.cardMedia.children (children :> ReactElement seq) ]

  static member inline checkbox props = createElement (importDefault "@mui/material/Checkbox") props

  static member inline chip props = createElement (importDefault "@mui/material/Chip") props

  static member inline circularProgress props = createElement (importDefault "@mui/material/CircularProgress") props

  static member inline clickAwayListener props = createElement (importDefault "@mui/base/ClickAwayListener") props

  static member inline clockPicker props = createElement (importDefault "@mui/lab/ClockPicker") props

  static member inline collapse props = createElement (importDefault "@mui/material/Collapse") props

  static member inline collapse (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Collapse") [ Feliz.MaterialUI.collapse.children (children :> ReactElement seq) ]

  static member inline container props = createElement (importDefault "@mui/material/Container") props

  static member inline container (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Container") [ Feliz.MaterialUI.container.children (children :> ReactElement seq) ]

  static member inline cssBaseline props = createElement (importDefault "@mui/material/CssBaseline") props

  static member inline cssBaseline (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/CssBaseline") [ Feliz.MaterialUI.cssBaseline.children (children :> ReactElement seq) ]

  static member inline datePicker props = createElement (importDefault "@mui/lab/DatePicker") props

  static member inline dateRangePicker props = createElement (importDefault "@mui/lab/DateRangePicker") props

  static member inline dateRangePickerDay props = createElement (importDefault "@mui/lab/DateRangePickerDay") props

  static member inline dateRangePickerDay (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/DateRangePickerDay") [ Feliz.MaterialUI.dateRangePickerDay.children (children :> ReactElement seq) ]

  static member inline dateTimePicker props = createElement (importDefault "@mui/lab/DateTimePicker") props

  static member inline desktopDatePicker props = createElement (importDefault "@mui/lab/DesktopDatePicker") props

  static member inline desktopDateRangePicker props = createElement (importDefault "@mui/lab/DesktopDateRangePicker") props

  static member inline desktopDateTimePicker props = createElement (importDefault "@mui/lab/DesktopDateTimePicker") props

  static member inline desktopTimePicker props = createElement (importDefault "@mui/lab/DesktopTimePicker") props

  static member inline dialog props = createElement (importDefault "@mui/material/Dialog") props

  static member inline dialog (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Dialog") [ Feliz.MaterialUI.dialog.children (children :> ReactElement seq) ]

  static member inline dialogActions props = createElement (importDefault "@mui/material/DialogActions") props

  static member inline dialogActions (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/DialogActions") [ Feliz.MaterialUI.dialogActions.children (children :> ReactElement seq) ]

  static member inline dialogContent props = createElement (importDefault "@mui/material/DialogContent") props

  static member inline dialogContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/DialogContent") [ Feliz.MaterialUI.dialogContent.children (children :> ReactElement seq) ]

  static member inline dialogContentText props = createElement (importDefault "@mui/material/DialogContentText") props

  static member inline dialogContentText (text: string) = createElement (importDefault "@mui/material/DialogContentText") [ prop.children (Html.text text) ]

  static member inline dialogContentText (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/DialogContentText") [ Feliz.MaterialUI.dialogContentText.children (children :> ReactElement seq) ]

  static member inline dialogTitle props = createElement (importDefault "@mui/material/DialogTitle") props

  static member inline dialogTitle (text: string) = createElement (importDefault "@mui/material/DialogTitle") [ prop.children (Html.text text) ]

  static member inline dialogTitle (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/DialogTitle") [ Feliz.MaterialUI.dialogTitle.children (children :> ReactElement seq) ]

  static member inline divider props = createElement (importDefault "@mui/material/Divider") props

  static member inline divider (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Divider") [ Feliz.MaterialUI.divider.children (children :> ReactElement seq) ]

  static member inline drawer props = createElement (importDefault "@mui/material/Drawer") props

  static member inline drawer (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Drawer") [ Feliz.MaterialUI.drawer.children (children :> ReactElement seq) ]

  static member inline fab props = createElement (importDefault "@mui/material/Fab") props

  static member inline fab (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Fab") [ Feliz.MaterialUI.fab.children (children :> ReactElement seq) ]

  static member inline fade props = createElement (importDefault "@mui/material/Fade") props

  static member inline filledInput props = createElement (importDefault "@mui/material/FilledInput") props

  static member inline formControl props = createElement (importDefault "@mui/material/FormControl") props

  static member inline formControl (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/FormControl") [ Feliz.MaterialUI.formControl.children (children :> ReactElement seq) ]

  static member inline formControlLabel props = createElement (importDefault "@mui/material/FormControlLabel") props

  static member inline formControlUnstyled props = createElement (importDefault "@mui/base/FormControlUnstyled") props

  static member inline formControlUnstyled (children: #seq<ReactElement>) = createElement (importDefault "@mui/base/FormControlUnstyled") [ Feliz.MaterialUI.formControlUnstyled.children (children :> ReactElement seq) ]

  static member inline formGroup props = createElement (importDefault "@mui/material/FormGroup") props

  static member inline formGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/FormGroup") [ Feliz.MaterialUI.formGroup.children (children :> ReactElement seq) ]

  static member inline formHelperText props = createElement (importDefault "@mui/material/FormHelperText") props

  static member inline formHelperText (text: string) = createElement (importDefault "@mui/material/FormHelperText") [ prop.children (Html.text text) ]

  static member inline formHelperText (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/FormHelperText") [ Feliz.MaterialUI.formHelperText.children (children :> ReactElement seq) ]

  static member inline formLabel props = createElement (importDefault "@mui/material/FormLabel") props

  static member inline formLabel (text: string) = createElement (importDefault "@mui/material/FormLabel") [ prop.children (Html.text text) ]

  static member inline formLabel (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/FormLabel") [ Feliz.MaterialUI.formLabel.children (children :> ReactElement seq) ]

  static member inline globalStyles props = createElement (importDefault "@mui/material/GlobalStyles") props

  static member inline grid props = createElement (importDefault "@mui/material/Grid") props

  static member inline grid (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Grid") [ Feliz.MaterialUI.grid.children (children :> ReactElement seq) ]

  static member inline grow props = createElement (importDefault "@mui/material/Grow") props

  static member inline hidden props = createElement (importDefault "@mui/material/Hidden") props

  static member inline hidden (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Hidden") [ Feliz.MaterialUI.hidden.children (children :> ReactElement seq) ]

  static member inline icon props = createElement (importDefault "@mui/material/Icon") props

  static member inline icon (name: string) = createElement (importDefault "@mui/material/Icon") [ prop.children (Html.text name) ]

  static member inline icon (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Icon") [ Feliz.MaterialUI.icon.children (children :> ReactElement seq) ]

  static member inline iconButton props = createElement (importDefault "@mui/material/IconButton") props

  static member inline iconButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/IconButton") [ Feliz.MaterialUI.iconButton.children (children :> ReactElement seq) ]

  static member inline imageList props = createElement (importDefault "@mui/material/ImageList") props

  static member inline imageList (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ImageList") [ Feliz.MaterialUI.imageList.children (children :> ReactElement seq) ]

  static member inline imageListItem props = createElement (importDefault "@mui/material/ImageListItem") props

  static member inline imageListItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ImageListItem") [ Feliz.MaterialUI.imageListItem.children (children :> ReactElement seq) ]

  static member inline imageListItemBar props = createElement (importDefault "@mui/material/ImageListItemBar") props

  static member inline input props = createElement (importDefault "@mui/material/Input") props

  static member inline inputAdornment props = createElement (importDefault "@mui/material/InputAdornment") props

  static member inline inputAdornment (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/InputAdornment") [ Feliz.MaterialUI.inputAdornment.children (children :> ReactElement seq) ]

  static member inline inputBase props = createElement (importDefault "@mui/material/InputBase") props

  static member inline inputLabel props = createElement (importDefault "@mui/material/InputLabel") props

  static member inline inputLabel (text: string) = createElement (importDefault "@mui/material/InputLabel") [ prop.children (Html.text text) ]

  static member inline inputLabel (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/InputLabel") [ Feliz.MaterialUI.inputLabel.children (children :> ReactElement seq) ]

  static member inline inputUnstyled props = createElement (importDefault "@mui/base/InputUnstyled") props

  static member inline linearProgress props = createElement (importDefault "@mui/material/LinearProgress") props

  static member inline link props = createElement (importDefault "@mui/material/Link") props

  static member inline link (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Link") [ Feliz.MaterialUI.link.children (children :> ReactElement seq) ]

  static member inline list props = createElement (importDefault "@mui/material/List") props

  static member inline list (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/List") [ Feliz.MaterialUI.list.children (children :> ReactElement seq) ]

  static member inline listItem props = createElement (importDefault "@mui/material/ListItem") props

  static member inline listItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItem") [ Feliz.MaterialUI.listItem.children (children :> ReactElement seq) ]

  static member inline listItemAvatar props = createElement (importDefault "@mui/material/ListItemAvatar") props

  static member inline listItemAvatar (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemAvatar") [ Feliz.MaterialUI.listItemAvatar.children (children :> ReactElement seq) ]

  static member inline listItemButton props = createElement (importDefault "@mui/material/ListItemButton") props

  static member inline listItemButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemButton") [ Feliz.MaterialUI.listItemButton.children (children :> ReactElement seq) ]

  static member inline listItemIcon props = createElement (importDefault "@mui/material/ListItemIcon") props

  static member inline listItemIcon (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemIcon") [ Feliz.MaterialUI.listItemIcon.children (children :> ReactElement seq) ]

  static member inline listItemSecondaryAction props = createElement (importDefault "@mui/material/ListItemSecondaryAction") props

  static member inline listItemSecondaryAction (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemSecondaryAction") [ Feliz.MaterialUI.listItemSecondaryAction.children (children :> ReactElement seq) ]

  static member inline listItemText props = createElement (importDefault "@mui/material/ListItemText") props

  static member inline listItemText (primary: string) = createElement (importDefault "@mui/material/ListItemText") [ listItemText.primary primary ]

  static member inline listItemText (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListItemText") [ Feliz.MaterialUI.listItemText.children (children :> ReactElement seq) ]

  static member inline listSubheader props = createElement (importDefault "@mui/material/ListSubheader") props

  static member inline listSubheader (text: string) = createElement (importDefault "@mui/material/ListSubheader") [ prop.children (Html.text text) ]

  static member inline listSubheader (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ListSubheader") [ Feliz.MaterialUI.listSubheader.children (children :> ReactElement seq) ]

  static member inline loadingButton props = createElement (importDefault "@mui/lab/LoadingButton") props

  static member inline loadingButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/LoadingButton") [ Feliz.MaterialUI.loadingButton.children (children :> ReactElement seq) ]

  static member inline masonry props = createElement (importDefault "@mui/lab/Masonry") props

  static member inline masonry (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/Masonry") [ Feliz.MaterialUI.masonry.children (children :> ReactElement seq) ]

  static member inline menu props = createElement (importDefault "@mui/material/Menu") props

  static member inline menu (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Menu") [ Feliz.MaterialUI.menu.children (children :> ReactElement seq) ]

  static member inline menuItem props = createElement (importDefault "@mui/material/MenuItem") props

  static member inline menuItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/MenuItem") [ Feliz.MaterialUI.menuItem.children (children :> ReactElement seq) ]

  static member inline menuList props = createElement (importDefault "@mui/material/MenuList") props

  static member inline menuList (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/MenuList") [ Feliz.MaterialUI.menuList.children (children :> ReactElement seq) ]

  static member inline mobileDatePicker props = createElement (importDefault "@mui/lab/MobileDatePicker") props

  static member inline mobileDateRangePicker props = createElement (importDefault "@mui/lab/MobileDateRangePicker") props

  static member inline mobileDateTimePicker props = createElement (importDefault "@mui/lab/MobileDateTimePicker") props

  static member inline mobileStepper props = createElement (importDefault "@mui/material/MobileStepper") props

  static member inline mobileTimePicker props = createElement (importDefault "@mui/lab/MobileTimePicker") props

  static member inline modal props = createElement (importDefault "@mui/material/Modal") props

  static member inline modalUnstyled props = createElement (importDefault "@mui/base/ModalUnstyled") props

  static member inline monthPicker props = createElement (importDefault "@mui/lab/MonthPicker") props

  static member inline nativeSelect props = createElement (importDefault "@mui/material/NativeSelect") props

  static member inline nativeSelect (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/NativeSelect") [ Feliz.MaterialUI.nativeSelect.children (children :> ReactElement seq) ]

  static member inline noSsr props = createElement (importDefault "@mui/base/NoSsr") props

  static member inline noSsr (children: #seq<ReactElement>) = createElement (importDefault "@mui/base/NoSsr") [ Feliz.MaterialUI.noSsr.children (children :> ReactElement seq) ]

  static member inline outlinedInput props = createElement (importDefault "@mui/material/OutlinedInput") props

  static member inline pagination props = createElement (importDefault "@mui/material/Pagination") props

  static member inline paginationItem props = createElement (importDefault "@mui/material/PaginationItem") props

  static member inline paper props = createElement (importDefault "@mui/material/Paper") props

  static member inline paper (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Paper") [ Feliz.MaterialUI.paper.children (children :> ReactElement seq) ]

  static member inline pickersDay props = createElement (importDefault "@mui/lab/PickersDay") props

  static member inline pickersDay (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/PickersDay") [ Feliz.MaterialUI.pickersDay.children (children :> ReactElement seq) ]

  static member inline popover props = createElement (importDefault "@mui/material/Popover") props

  static member inline popover (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Popover") [ Feliz.MaterialUI.popover.children (children :> ReactElement seq) ]

  static member inline popper props = createElement (importDefault "@mui/material/Popper") props

  static member inline popper (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Popper") [ Feliz.MaterialUI.popper.children (children :> ReactElement seq) ]

  static member inline popperUnstyled props = createElement (importDefault "@mui/base/PopperUnstyled") props

  static member inline portal props = createElement (importDefault "@mui/base/Portal") props

  static member inline portal (children: #seq<ReactElement>) = createElement (importDefault "@mui/base/Portal") [ Feliz.MaterialUI.portal.children (children :> ReactElement seq) ]

  static member inline radio props = createElement (importDefault "@mui/material/Radio") props

  static member inline radioGroup props = createElement (importDefault "@mui/material/RadioGroup") props

  static member inline radioGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/RadioGroup") [ Feliz.MaterialUI.radioGroup.children (children :> ReactElement seq) ]

  static member inline rating props = createElement (importDefault "@mui/material/Rating") props

  static member inline scopedCssBaseline props = createElement (importDefault "@mui/material/ScopedCssBaseline") props

  static member inline scopedCssBaseline (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ScopedCssBaseline") [ Feliz.MaterialUI.scopedCssBaseline.children (children :> ReactElement seq) ]

  static member inline select props = createElement (importDefault "@mui/material/Select") props

  static member inline select (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Select") [ Feliz.MaterialUI.select.children (children :> ReactElement seq) ]

  static member inline skeleton props = createElement (importDefault "@mui/material/Skeleton") props

  static member inline skeleton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Skeleton") [ Feliz.MaterialUI.skeleton.children (children :> ReactElement seq) ]

  static member inline slide props = createElement (importDefault "@mui/material/Slide") props

  static member inline slider props = createElement (importDefault "@mui/material/Slider") props

  static member inline sliderUnstyled props = createElement (importDefault "@mui/base/SliderUnstyled") props

  static member inline snackbar props = createElement (importDefault "@mui/material/Snackbar") props

  static member inline snackbarContent props = createElement (importDefault "@mui/material/SnackbarContent") props

  static member inline speedDial props = createElement (importDefault "@mui/material/SpeedDial") props

  static member inline speedDial (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/SpeedDial") [ Feliz.MaterialUI.speedDial.children (children :> ReactElement seq) ]

  static member inline speedDialAction props = createElement (importDefault "@mui/material/SpeedDialAction") props

  static member inline speedDialIcon props = createElement (importDefault "@mui/material/SpeedDialIcon") props

  static member inline stack props = createElement (importDefault "@mui/material/Stack") props

  static member inline stack (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Stack") [ Feliz.MaterialUI.stack.children (children :> ReactElement seq) ]

  static member inline staticDatePicker props = createElement (importDefault "@mui/lab/StaticDatePicker") props

  static member inline staticDateRangePicker props = createElement (importDefault "@mui/lab/StaticDateRangePicker") props

  static member inline staticDateTimePicker props = createElement (importDefault "@mui/lab/StaticDateTimePicker") props

  static member inline staticTimePicker props = createElement (importDefault "@mui/lab/StaticTimePicker") props

  static member inline step props = createElement (importDefault "@mui/material/Step") props

  static member inline step (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Step") [ Feliz.MaterialUI.step.children (children :> ReactElement seq) ]

  static member inline stepButton props = createElement (importDefault "@mui/material/StepButton") props

  static member inline stepButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/StepButton") [ Feliz.MaterialUI.stepButton.children (children :> ReactElement seq) ]

  static member inline stepConnector props = createElement (importDefault "@mui/material/StepConnector") props

  static member inline stepContent props = createElement (importDefault "@mui/material/StepContent") props

  static member inline stepContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/StepContent") [ Feliz.MaterialUI.stepContent.children (children :> ReactElement seq) ]

  static member inline stepIcon props = createElement (importDefault "@mui/material/StepIcon") props

  static member inline stepLabel props = createElement (importDefault "@mui/material/StepLabel") props

  static member inline stepLabel (text: string) = createElement (importDefault "@mui/material/StepLabel") [ prop.children (Html.text text) ]

  static member inline stepLabel (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/StepLabel") [ Feliz.MaterialUI.stepLabel.children (children :> ReactElement seq) ]

  static member inline stepper props = createElement (importDefault "@mui/material/Stepper") props

  static member inline stepper (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Stepper") [ Feliz.MaterialUI.stepper.children (children :> ReactElement seq) ]

  static member inline svgIcon props = createElement (importDefault "@mui/material/SvgIcon") props

  static member inline svgIcon (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/SvgIcon") [ Feliz.MaterialUI.svgIcon.children (children :> ReactElement seq) ]

  static member inline swipeableDrawer props = createElement (importDefault "@mui/material/SwipeableDrawer") props

  static member inline swipeableDrawer (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/SwipeableDrawer") [ Feliz.MaterialUI.swipeableDrawer.children (children :> ReactElement seq) ]

  static member inline switch props = createElement (importDefault "@mui/material/Switch") props

  static member inline switchUnstyled props = createElement (importDefault "@mui/base/SwitchUnstyled") props

  static member inline tab props = createElement (importDefault "@mui/material/Tab") props

  static member inline tabContext props = createElement (importDefault "@mui/lab/TabContext") props

  static member inline tabContext (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TabContext") [ Feliz.MaterialUI.tabContext.children (children :> ReactElement seq) ]

  static member inline table props = createElement (importDefault "@mui/material/Table") props

  static member inline table (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Table") [ Feliz.MaterialUI.table.children (children :> ReactElement seq) ]

  static member inline tableBody props = createElement (importDefault "@mui/material/TableBody") props

  static member inline tableBody (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableBody") [ Feliz.MaterialUI.tableBody.children (children :> ReactElement seq) ]

  static member inline tableCell props = createElement (importDefault "@mui/material/TableCell") props

  static member inline tableCell (text: string) = createElement (importDefault "@mui/material/TableCell") [ prop.children (Html.text text) ]

  static member inline tableCell (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableCell") [ Feliz.MaterialUI.tableCell.children (children :> ReactElement seq) ]

  static member inline tableContainer props = createElement (importDefault "@mui/material/TableContainer") props

  static member inline tableContainer (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableContainer") [ Feliz.MaterialUI.tableContainer.children (children :> ReactElement seq) ]

  static member inline tableFooter props = createElement (importDefault "@mui/material/TableFooter") props

  static member inline tableFooter (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableFooter") [ Feliz.MaterialUI.tableFooter.children (children :> ReactElement seq) ]

  static member inline tableHead props = createElement (importDefault "@mui/material/TableHead") props

  static member inline tableHead (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableHead") [ Feliz.MaterialUI.tableHead.children (children :> ReactElement seq) ]

  static member inline tablePagination props = createElement (importDefault "@mui/material/TablePagination") props

  static member inline tablePaginationUnstyled props = createElement (importDefault "@mui/base/TablePaginationUnstyled") props

  static member inline tableRow props = createElement (importDefault "@mui/material/TableRow") props

  static member inline tableRow (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableRow") [ Feliz.MaterialUI.tableRow.children (children :> ReactElement seq) ]

  static member inline tableSortLabel props = createElement (importDefault "@mui/material/TableSortLabel") props

  static member inline tableSortLabel (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TableSortLabel") [ Feliz.MaterialUI.tableSortLabel.children (children :> ReactElement seq) ]

  static member inline tabList props = createElement (importDefault "@mui/lab/TabList") props

  static member inline tabList (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TabList") [ Feliz.MaterialUI.tabList.children (children :> ReactElement seq) ]

  static member inline tabPanel props = createElement (importDefault "@mui/lab/TabPanel") props

  static member inline tabPanel (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TabPanel") [ Feliz.MaterialUI.tabPanel.children (children :> ReactElement seq) ]

  static member inline tabPanelUnstyled props = createElement (importDefault "@mui/base/TabPanelUnstyled") props

  static member inline tabPanelUnstyled (children: #seq<ReactElement>) = createElement (importDefault "@mui/base/TabPanelUnstyled") [ Feliz.MaterialUI.tabPanelUnstyled.children (children :> ReactElement seq) ]

  static member inline tabs props = createElement (importDefault "@mui/material/Tabs") props

  static member inline tabs (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Tabs") [ Feliz.MaterialUI.tabs.children (children :> ReactElement seq) ]

  static member inline tabScrollButton props = createElement (importDefault "@mui/material/TabScrollButton") props

  static member inline tabScrollButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/TabScrollButton") [ Feliz.MaterialUI.tabScrollButton.children (children :> ReactElement seq) ]

  static member inline tabsListUnstyled props = createElement (importDefault "@mui/base/TabsListUnstyled") props

  static member inline tabsListUnstyled (children: #seq<ReactElement>) = createElement (importDefault "@mui/base/TabsListUnstyled") [ Feliz.MaterialUI.tabsListUnstyled.children (children :> ReactElement seq) ]

  static member inline tabsUnstyled props = createElement (importDefault "@mui/base/TabsUnstyled") props

  static member inline tabsUnstyled (children: #seq<ReactElement>) = createElement (importDefault "@mui/base/TabsUnstyled") [ Feliz.MaterialUI.tabsUnstyled.children (children :> ReactElement seq) ]

  static member inline tabUnstyled props = createElement (importDefault "@mui/base/TabUnstyled") props

  static member inline textareaAutosize props = createElement (importDefault "@mui/base/TextareaAutosize") props

  static member inline textField props = createElement (importDefault "@mui/material/TextField") props

  static member inline timeline props = createElement (importDefault "@mui/lab/Timeline") props

  static member inline timeline (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/Timeline") [ Feliz.MaterialUI.timeline.children (children :> ReactElement seq) ]

  static member inline timelineConnector props = createElement (importDefault "@mui/lab/TimelineConnector") props

  static member inline timelineConnector (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineConnector") [ Feliz.MaterialUI.timelineConnector.children (children :> ReactElement seq) ]

  static member inline timelineContent props = createElement (importDefault "@mui/lab/TimelineContent") props

  static member inline timelineContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineContent") [ Feliz.MaterialUI.timelineContent.children (children :> ReactElement seq) ]

  static member inline timelineDot props = createElement (importDefault "@mui/lab/TimelineDot") props

  static member inline timelineDot (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineDot") [ Feliz.MaterialUI.timelineDot.children (children :> ReactElement seq) ]

  static member inline timelineItem props = createElement (importDefault "@mui/lab/TimelineItem") props

  static member inline timelineItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineItem") [ Feliz.MaterialUI.timelineItem.children (children :> ReactElement seq) ]

  static member inline timelineOppositeContent props = createElement (importDefault "@mui/lab/TimelineOppositeContent") props

  static member inline timelineOppositeContent (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineOppositeContent") [ Feliz.MaterialUI.timelineOppositeContent.children (children :> ReactElement seq) ]

  static member inline timelineSeparator props = createElement (importDefault "@mui/lab/TimelineSeparator") props

  static member inline timelineSeparator (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TimelineSeparator") [ Feliz.MaterialUI.timelineSeparator.children (children :> ReactElement seq) ]

  static member inline timePicker props = createElement (importDefault "@mui/lab/TimePicker") props

  static member inline toggleButton props = createElement (importDefault "@mui/material/ToggleButton") props

  static member inline toggleButton (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ToggleButton") [ Feliz.MaterialUI.toggleButton.children (children :> ReactElement seq) ]

  static member inline toggleButtonGroup props = createElement (importDefault "@mui/material/ToggleButtonGroup") props

  static member inline toggleButtonGroup (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/ToggleButtonGroup") [ Feliz.MaterialUI.toggleButtonGroup.children (children :> ReactElement seq) ]

  static member inline toolbar props = createElement (importDefault "@mui/material/Toolbar") props

  static member inline toolbar (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Toolbar") [ Feliz.MaterialUI.toolbar.children (children :> ReactElement seq) ]

  static member inline tooltip props = createElement (importDefault "@mui/material/Tooltip") props

  static member inline treeItem props = createElement (importDefault "@mui/lab/TreeItem") props

  static member inline treeItem (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TreeItem") [ Feliz.MaterialUI.treeItem.children (children :> ReactElement seq) ]

  static member inline treeView props = createElement (importDefault "@mui/lab/TreeView") props

  static member inline treeView (children: #seq<ReactElement>) = createElement (importDefault "@mui/lab/TreeView") [ Feliz.MaterialUI.treeView.children (children :> ReactElement seq) ]

  static member inline typography props = createElement (importDefault "@mui/material/Typography") props

  static member inline typography (text: string) = createElement (importDefault "@mui/material/Typography") [ prop.children (Html.text text) ]

  static member inline typography (children: #seq<ReactElement>) = createElement (importDefault "@mui/material/Typography") [ Feliz.MaterialUI.typography.children (children :> ReactElement seq) ]

  static member inline unstable_TrapFocus props = createElement (importDefault "@mui/base/Unstable_TrapFocus") props

  static member inline yearPicker props = createElement (importDefault "@mui/lab/YearPicker") props

  static member inline zoom props = createElement (importDefault "@mui/material/Zoom") props
