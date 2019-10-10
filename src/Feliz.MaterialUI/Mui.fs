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

  let createElement (el: ReactElementType) (properties: IReactProperty list) : ReactElement =
    reactElement el (createObj !!properties)

[<Erase>]
type Mui =

  static member inline muiThemeProvider props = createElement (importDefault "@material-ui/core/styles/MuiThemeProvider") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline appBar props = createElement (importDefault "@material-ui/core/AppBar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline appBar (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/AppBar") [ appBarProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline avatar props = createElement (importDefault "@material-ui/core/Avatar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline avatar (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Avatar") [ avatarProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline backdrop props = createElement (importDefault "@material-ui/core/Backdrop") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline backdrop (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Backdrop") [ backdropProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline badge props = createElement (importDefault "@material-ui/core/Badge") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline badge (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Badge") [ badgeProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline bottomNavigation props = createElement (importDefault "@material-ui/core/BottomNavigation") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline bottomNavigation (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/BottomNavigation") [ bottomNavigationProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline bottomNavigationAction props = createElement (importDefault "@material-ui/core/BottomNavigationAction") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline breadcrumbs props = createElement (importDefault "@material-ui/core/Breadcrumbs") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline breadcrumbs (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Breadcrumbs") [ breadcrumbsProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline button props = createElement (importDefault "@material-ui/core/Button") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline button (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Button") [ buttonProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline buttonBase props = createElement (importDefault "@material-ui/core/ButtonBase") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline buttonBase (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ButtonBase") [ buttonBaseProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline buttonGroup props = createElement (importDefault "@material-ui/core/ButtonGroup") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline buttonGroup (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ButtonGroup") [ buttonGroupProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline card props = createElement (importDefault "@material-ui/core/Card") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline card (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Card") [ cardProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline cardActionArea props = createElement (importDefault "@material-ui/core/CardActionArea") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline cardActionArea (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/CardActionArea") [ cardActionAreaProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardActions props = createElement (importDefault "@material-ui/core/CardActions") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardActions (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/CardActions") [ cardActionsProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardContent props = createElement (importDefault "@material-ui/core/CardContent") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardContent (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/CardContent") [ cardContentProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardHeader props = createElement (importDefault "@material-ui/core/CardHeader") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardMedia props = createElement (importDefault "@material-ui/core/CardMedia") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardMedia (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/CardMedia") [ cardMediaProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline checkbox props = createElement (importDefault "@material-ui/core/Checkbox") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline chip props = createElement (importDefault "@material-ui/core/Chip") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline circularProgress props = createElement (importDefault "@material-ui/core/CircularProgress") props

  /// The component cannot hold a ref.
  static member inline clickAwayListener props = createElement (importDefault "@material-ui/core/ClickAwayListener") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline collapse props = createElement (importDefault "@material-ui/core/Collapse") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline collapse (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Collapse") [ collapseProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline container props = createElement (importDefault "@material-ui/core/Container") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline container (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Container") [ containerProps.children (children :> ReactElement seq) ]

  /// The component cannot hold a ref.
  static member inline cssBaseline props = createElement (importDefault "@material-ui/core/CssBaseline") props

  /// The component cannot hold a ref.
  static member inline cssBaseline (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/CssBaseline") [ cssBaselineProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  static member inline dialog props = createElement (importDefault "@material-ui/core/Dialog") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  static member inline dialog (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Dialog") [ dialogProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogActions props = createElement (importDefault "@material-ui/core/DialogActions") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogActions (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/DialogActions") [ dialogActionsProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogContent props = createElement (importDefault "@material-ui/core/DialogContent") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogContent (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/DialogContent") [ dialogContentProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline dialogContentText props = createElement (importDefault "@material-ui/core/DialogContentText") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline dialogContentText (text: string) = createElement (importDefault "@material-ui/core/DialogContentText") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline dialogContentText (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/DialogContentText") [ dialogContentTextProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogTitle props = createElement (importDefault "@material-ui/core/DialogTitle") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogTitle (text: string) = createElement (importDefault "@material-ui/core/DialogTitle") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogTitle (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/DialogTitle") [ dialogTitleProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline divider props = createElement (importDefault "@material-ui/core/Divider") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline drawer props = createElement (importDefault "@material-ui/core/Drawer") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline drawer (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Drawer") [ drawerProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline expansionPanel props = createElement (importDefault "@material-ui/core/ExpansionPanel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline expansionPanel (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ExpansionPanel") [ expansionPanelProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline expansionPanelActions props = createElement (importDefault "@material-ui/core/ExpansionPanelActions") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline expansionPanelActions (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ExpansionPanelActions") [ expansionPanelActionsProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline expansionPanelDetails props = createElement (importDefault "@material-ui/core/ExpansionPanelDetails") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline expansionPanelDetails (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ExpansionPanelDetails") [ expansionPanelDetailsProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline expansionPanelSummary props = createElement (importDefault "@material-ui/core/ExpansionPanelSummary") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline expansionPanelSummary (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ExpansionPanelSummary") [ expansionPanelSummaryProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline fab props = createElement (importDefault "@material-ui/core/Fab") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline fab (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Fab") [ fabProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline fade props = createElement (importDefault "@material-ui/core/Fade") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline filledInput props = createElement (importDefault "@material-ui/core/FilledInput") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formControl props = createElement (importDefault "@material-ui/core/FormControl") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formControl (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/FormControl") [ formControlProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formControlLabel props = createElement (importDefault "@material-ui/core/FormControlLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formGroup props = createElement (importDefault "@material-ui/core/FormGroup") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formGroup (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/FormGroup") [ formGroupProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formHelperText props = createElement (importDefault "@material-ui/core/FormHelperText") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formHelperText (text: string) = createElement (importDefault "@material-ui/core/FormHelperText") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formHelperText (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/FormHelperText") [ formHelperTextProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formLabel props = createElement (importDefault "@material-ui/core/FormLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formLabel (text: string) = createElement (importDefault "@material-ui/core/FormLabel") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formLabel (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/FormLabel") [ formLabelProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline grid props = createElement (importDefault "@material-ui/core/Grid") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline grid (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Grid") [ gridProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridList props = createElement (importDefault "@material-ui/core/GridList") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridList (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/GridList") [ gridListProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridListTile props = createElement (importDefault "@material-ui/core/GridListTile") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridListTile (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/GridListTile") [ gridListTileProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridListTileBar props = createElement (importDefault "@material-ui/core/GridListTileBar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline grow props = createElement (importDefault "@material-ui/core/Grow") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline hidden props = createElement (importDefault "@material-ui/core/Hidden") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline hidden (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Hidden") [ hiddenProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline icon props = createElement (importDefault "@material-ui/core/Icon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline icon (name: string) = createElement (importDefault "@material-ui/core/Icon") [ prop.children (Html.text name) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline icon (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Icon") [ iconProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline iconButton props = createElement (importDefault "@material-ui/core/IconButton") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline iconButton (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/IconButton") [ iconButtonProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline input props = createElement (importDefault "@material-ui/core/Input") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline inputAdornment props = createElement (importDefault "@material-ui/core/InputAdornment") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline inputAdornment (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/InputAdornment") [ inputAdornmentProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline inputBase props = createElement (importDefault "@material-ui/core/InputBase") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormLabel](https://material-ui.com/api/form-label/)).
  static member inline inputLabel props = createElement (importDefault "@material-ui/core/InputLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormLabel](https://material-ui.com/api/form-label/)).
  static member inline inputLabel (text: string) = createElement (importDefault "@material-ui/core/InputLabel") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormLabel](https://material-ui.com/api/form-label/)).
  static member inline inputLabel (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/InputLabel") [ inputLabelProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline linearProgress props = createElement (importDefault "@material-ui/core/LinearProgress") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline link props = createElement (importDefault "@material-ui/core/Link") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline link (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Link") [ linkProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline list props = createElement (importDefault "@material-ui/core/List") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline list (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/List") [ listProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItem props = createElement (importDefault "@material-ui/core/ListItem") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItem (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ListItem") [ listItemProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemAvatar props = createElement (importDefault "@material-ui/core/ListItemAvatar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemIcon props = createElement (importDefault "@material-ui/core/ListItemIcon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemSecondaryAction props = createElement (importDefault "@material-ui/core/ListItemSecondaryAction") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemSecondaryAction (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ListItemSecondaryAction") [ listItemSecondaryActionProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemText props = createElement (importDefault "@material-ui/core/ListItemText") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemText (primary: string) = createElement (importDefault "@material-ui/core/ListItemText") [ listItemText.primary primary ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemText (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ListItemText") [ listItemTextProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listSubheader props = createElement (importDefault "@material-ui/core/ListSubheader") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listSubheader (text: string) = createElement (importDefault "@material-ui/core/ListSubheader") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listSubheader (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/ListSubheader") [ listSubheaderProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Popover](https://material-ui.com/api/popover/)).
  static member inline menu props = createElement (importDefault "@material-ui/core/Menu") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Popover](https://material-ui.com/api/popover/)).
  static member inline menu (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Menu") [ menuProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ListItem](https://material-ui.com/api/list-item/)).
  static member inline menuItem props = createElement (importDefault "@material-ui/core/MenuItem") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ListItem](https://material-ui.com/api/list-item/)).
  static member inline menuItem (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/MenuItem") [ menuItemProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([List](https://material-ui.com/api/list/)).
  static member inline menuList props = createElement (importDefault "@material-ui/core/MenuList") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([List](https://material-ui.com/api/list/)).
  static member inline menuList (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/MenuList") [ menuListProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline mobileStepper props = createElement (importDefault "@material-ui/core/MobileStepper") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline modal props = createElement (importDefault "@material-ui/core/Modal") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  static member inline nativeSelect props = createElement (importDefault "@material-ui/core/NativeSelect") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  static member inline nativeSelect (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/NativeSelect") [ nativeSelectProps.children (children :> ReactElement seq) ]

  /// The component cannot hold a ref.
  static member inline noSsr props = createElement (importDefault "@material-ui/core/NoSsr") props

  /// The component cannot hold a ref.
  static member inline noSsr (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/NoSsr") [ noSsrProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline outlinedInput props = createElement (importDefault "@material-ui/core/OutlinedInput") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline paper props = createElement (importDefault "@material-ui/core/Paper") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline paper (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Paper") [ paperProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  static member inline popover props = createElement (importDefault "@material-ui/core/Popover") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  static member inline popover (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Popover") [ popoverProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline popper props = createElement (importDefault "@material-ui/core/Popper") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline popper (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Popper") [ popperProps.children (children :> ReactElement seq) ]

  /// The component cannot hold a ref.
  static member inline portal props = createElement (importDefault "@material-ui/core/Portal") props

  /// The component cannot hold a ref.
  static member inline portal (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Portal") [ portalProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline radio props = createElement (importDefault "@material-ui/core/Radio") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormGroup](https://material-ui.com/api/form-group/)).
  static member inline radioGroup props = createElement (importDefault "@material-ui/core/RadioGroup") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormGroup](https://material-ui.com/api/form-group/)).
  static member inline radioGroup (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/RadioGroup") [ radioGroupProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline rating props = createElement (importDefault "@material-ui/lab/Rating") props

  /// The component cannot hold a ref.
  static member inline rootRef props = createElement (importDefault "@material-ui/core/RootRef") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  static member inline select props = createElement (importDefault "@material-ui/core/Select") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  static member inline select (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Select") [ selectProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline skeleton props = createElement (importDefault "@material-ui/lab/Skeleton") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline slide props = createElement (importDefault "@material-ui/core/Slide") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline slider props = createElement (importDefault "@material-ui/core/Slider") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline snackbar props = createElement (importDefault "@material-ui/core/Snackbar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline snackbarContent props = createElement (importDefault "@material-ui/core/SnackbarContent") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline speedDial props = createElement (importDefault "@material-ui/lab/SpeedDial") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline speedDial (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/lab/SpeedDial") [ speedDialProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Tooltip](https://material-ui.com/api/tooltip/)).
  static member inline speedDialAction props = createElement (importDefault "@material-ui/lab/SpeedDialAction") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline speedDialIcon props = createElement (importDefault "@material-ui/lab/SpeedDialIcon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline step props = createElement (importDefault "@material-ui/core/Step") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline step (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Step") [ stepProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline stepButton props = createElement (importDefault "@material-ui/core/StepButton") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline stepButton (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/StepButton") [ stepButtonProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepConnector props = createElement (importDefault "@material-ui/core/StepConnector") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepContent props = createElement (importDefault "@material-ui/core/StepContent") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepContent (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/StepContent") [ stepContentProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepIcon props = createElement (importDefault "@material-ui/core/StepIcon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepLabel props = createElement (importDefault "@material-ui/core/StepLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepLabel (text: string) = createElement (importDefault "@material-ui/core/StepLabel") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepLabel (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/StepLabel") [ stepLabelProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline stepper props = createElement (importDefault "@material-ui/core/Stepper") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline stepper (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Stepper") [ stepperProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline svgIcon props = createElement (importDefault "@material-ui/core/SvgIcon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline svgIcon (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/SvgIcon") [ svgIconProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Drawer](https://material-ui.com/api/drawer/)).
  static member inline swipeableDrawer props = createElement (importDefault "@material-ui/core/SwipeableDrawer") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Drawer](https://material-ui.com/api/drawer/)).
  static member inline swipeableDrawer (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/SwipeableDrawer") [ swipeableDrawerProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline switch props = createElement (importDefault "@material-ui/core/Switch") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline tab props = createElement (importDefault "@material-ui/core/Tab") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline table props = createElement (importDefault "@material-ui/core/Table") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline table (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Table") [ tableProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableBody props = createElement (importDefault "@material-ui/core/TableBody") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableBody (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/TableBody") [ tableBodyProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableCell props = createElement (importDefault "@material-ui/core/TableCell") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableCell (text: string) = createElement (importDefault "@material-ui/core/TableCell") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableCell (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/TableCell") [ tableCellProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableFooter props = createElement (importDefault "@material-ui/core/TableFooter") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableFooter (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/TableFooter") [ tableFooterProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableHead props = createElement (importDefault "@material-ui/core/TableHead") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableHead (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/TableHead") [ tableHeadProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([TableCell](https://material-ui.com/api/table-cell/)).
  static member inline tablePagination props = createElement (importDefault "@material-ui/core/TablePagination") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableRow props = createElement (importDefault "@material-ui/core/TableRow") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableRow (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/TableRow") [ tableRowProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline tableSortLabel props = createElement (importDefault "@material-ui/core/TableSortLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline tableSortLabel (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/TableSortLabel") [ tableSortLabelProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tabs props = createElement (importDefault "@material-ui/core/Tabs") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tabs (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Tabs") [ tabsProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline textareaAutosize props = createElement (importDefault "@material-ui/core/TextareaAutosize") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormControl](https://material-ui.com/api/form-control/)).
  static member inline textField props = createElement (importDefault "@material-ui/core/TextField") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline toggleButton props = createElement (importDefault "@material-ui/lab/ToggleButton") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline toggleButton (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/lab/ToggleButton") [ toggleButtonProps.children (children :> ReactElement seq) ]

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline toggleButtonGroup props = createElement (importDefault "@material-ui/lab/ToggleButtonGroup") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline toggleButtonGroup (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/lab/ToggleButtonGroup") [ toggleButtonGroupProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline toolbar props = createElement (importDefault "@material-ui/core/Toolbar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline toolbar (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Toolbar") [ toolbarProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tooltip props = createElement (importDefault "@material-ui/core/Tooltip") props

  /// The `ref` is attached to an Imperative Handle. Have a look at the [implementation of the component](https://github.com/mui-org/material-ui/blob/master/packages/material-ui/src/ButtonBase/TouchRipple.js) for more detail.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline touchRipple props = createElement (importDefault "@material-ui/core/ButtonBase/TouchRipple.js/TouchRipple") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline treeItem props = createElement (importDefault "@material-ui/lab/TreeItem") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline treeItem (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/lab/TreeItem") [ treeItemProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline treeView props = createElement (importDefault "@material-ui/lab/TreeView") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline treeView (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/lab/TreeView") [ treeViewProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline typography props = createElement (importDefault "@material-ui/core/Typography") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline typography (text: string) = createElement (importDefault "@material-ui/core/Typography") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline typography (children: #seq<ReactElement>) = createElement (importDefault "@material-ui/core/Typography") [ typographyProps.children (children :> ReactElement seq) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline zoom props = createElement (importDefault "@material-ui/core/Zoom") props
