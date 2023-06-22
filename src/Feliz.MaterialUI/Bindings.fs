namespace Feliz.MaterialUI

open System.Globalization
open Fable.Core
open Fable.Core.JsInterop
open Browser.Types
open Feliz
open Feliz.Styles

type PaletteIntention =
    abstract light: string
    abstract main: string
    abstract dark: string
    abstract contrastText: string

[<StringEnum; RequireQualifiedAccess>]
type PaletteType =
    | Dark
    | Light

type CommonPalette =
    abstract black: string
    abstract white: string

type ActionPalette =
    abstract active: string
    abstract hover: string
    abstract hoverOpacity: float
    abstract selected: string
    abstract disabled: string
    abstract disabledBackground: string

type BackgroundPalette =
    abstract paper: string
    abstract ``default``: string

type TextPalette =
    abstract primary: string
    abstract secondary: string
    abstract disabled: string
    abstract hint: string

type Color =
    abstract ``50``: string
    abstract ``100``: string
    abstract ``200``: string
    abstract ``300``: string
    abstract ``400``: string
    abstract ``500``: string
    abstract ``600``: string
    abstract ``700``: string
    abstract ``800``: string
    abstract ``900``: string
    abstract A100: string
    abstract A200: string
    abstract A400: string
    abstract A700: string

type Palette =
    abstract common: CommonPalette
    abstract mode: PaletteType
    /// Used to represent primary interface elements for a user.
    abstract primary: PaletteIntention
    /// Used to represent secondary interface elements for a user.
    abstract secondary: PaletteIntention
    /// Used to represent interface elements that the user should be made aware of.
    abstract error: PaletteIntention
    /// Used to represent potentially dangerous actions or important messages.
    abstract warning: PaletteIntention
    /// Used to present information to the user that is neutral and not necessarily important.
    abstract info: PaletteIntention
    /// Used to indicate the successful completion of an action that user triggered.
    abstract success: PaletteIntention
    abstract grey: Color

    /// Used by `getContrastText` to maximize the contrast between the background and the
    /// text. Higher values increases the point at which a background color is considered
    /// light, and given a dark contrast text. Note that `contrastThreshold` follows a
    /// non-linear curve.
    abstract contrastThreshold: float

    abstract getContrastText: background: string -> string
    abstract augmentColor: color: Color * ?mainShade: string * ?lightShade: string * ?darkShade: string -> unit
    abstract augmentColor: color: PaletteIntention -> unit

    /// A higher value for will make calculated values for "light" lighter, and "dark"
    /// darker.
    abstract tonalOffset: float

    abstract text: TextPalette
    abstract divider: string
    abstract background: BackgroundPalette
    abstract action: ActionPalette

[<StringEnum; RequireQualifiedAccess>]
type Direction =
    | Ltr
    | Rtl

type Shape =
    abstract borderRadius: int

type ZIndex =
    abstract mobileStepper: int
    abstract speedDial: int
    abstract appBar: int
    abstract drawer: int
    abstract modal: int
    abstract snackbar: int
    abstract tooltip: int

type VariantTypography =
    abstract fontFamily: string
    abstract fontWeight: int
    abstract fontSize: string
    abstract lineHeight: string
    abstract letterSpacing: string
    abstract marginLeft: string option
    abstract color: string option
    abstract textTransform: string option

type Typography =
    /// Tells Material-UI what the font-size on the `<html>` element is. This is used to
    /// adjust the `rem` value so the calculated font size always matches the specification.
    abstract htmlFontSize: float

    abstract pxToRem: px: float -> string
    abstract round: px: float -> float
    abstract fontFamily: string
    abstract fontSize: float
    abstract fontWeightLight: int
    abstract fontWeightRegular: int
    abstract fontWeightMedium: int
    abstract fontWeightBold: int
    abstract h1: VariantTypography
    abstract h2: VariantTypography
    abstract h3: VariantTypography
    abstract h4: VariantTypography
    abstract h5: VariantTypography
    abstract h6: VariantTypography
    abstract subtitle1: VariantTypography
    abstract subtitle2: VariantTypography
    abstract body1: VariantTypography
    abstract body2: VariantTypography
    abstract button: VariantTypography
    abstract caption: VariantTypography
    abstract overline: VariantTypography


type BreakpointValues =
    abstract xs: int
    abstract sm: int
    abstract md: int
    abstract lg: int
    abstract xl: int


type IBreakpointKey = interface end


[<StringEnum; RequireQualifiedAccess>]
type MuiBreakpointKey =
    | Xs
    | Sm
    | Md
    | Lg
    | Xl
with
    interface IBreakpointKey


type BreakpointStyles = IBreakpointKey * seq<IStyleAttribute>


type Breakpoints =
    abstract keys: MuiBreakpointKey []
    abstract values: BreakpointValues

    /// Returns a media query string ready to be used with most styling solutions, which
    /// matches screen widths greater than and including the screen size given by the
    /// breakpoint key.
    abstract up: key: MuiBreakpointKey -> string

    /// Returns a media query string ready to be used with most styling solutions, which
    /// matches screen widths greater than and including the screen size given by the
    /// breakpoint key.
    abstract up: widthPx: int -> string

    /// Returns a media query string ready to be used with most styling solutions, which
    /// matches screen widths less than and including the screen size given by the
    /// breakpoint key.
    abstract down: key: MuiBreakpointKey -> string

    /// Returns a media query string ready to be used with most styling solutions, which
    /// matches screen widths less than and including the screen size given by the
    /// breakpoint key.
    abstract down: widthPx: int -> string

    /// Returns a media query string ready to be used with most styling solutions, which
    /// matches screen widths including the screen size given by the breakpoint key.
    abstract only: key: MuiBreakpointKey -> string

    /// Returns a media query string ready to be used with most styling solutions, which
    /// matches screen widths greater than the screen size given by the breakpoint key in
    /// the first argument and less than the the screen size given by the breakpoint key in
    /// the second argument.
    abstract between: start: MuiBreakpointKey * ``end``: MuiBreakpointKey -> string

[<AutoOpen>]
module Extensions =
    type Breakpoints with
        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `xs` sreen size.
        member inline this.upXs = this.up (MuiBreakpointKey.Xs)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `sm` sreen size.
        member inline this.upSm = this.up (MuiBreakpointKey.Sm)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `md` sreen size.
        member inline this.upMd = this.up (MuiBreakpointKey.Md)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `lg` sreen size.
        member inline this.upLg = this.up (MuiBreakpointKey.Lg)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `xl` sreen size.
        member inline this.upXl = this.up (MuiBreakpointKey.Xl)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `xs` screen size.
        member inline this.downXs = this.down (MuiBreakpointKey.Xs)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `sm` screen size.
        member inline this.downSm = this.down (MuiBreakpointKey.Sm)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `md` screen size.
        member inline this.downMd = this.down (MuiBreakpointKey.Md)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `lg` screen size.
        member inline this.downLg = this.down (MuiBreakpointKey.Lg)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than and including the `xl` screen size.
        member inline this.downXl = this.down (MuiBreakpointKey.Xl)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths including the `xs` screen size.
        member inline this.onlyXs = this.only (MuiBreakpointKey.Xs)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths including the `sm` screen size.
        member inline this.onlySm = this.only (MuiBreakpointKey.Sm)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths including the `md` screen size.
        member inline this.onlyMd = this.only (MuiBreakpointKey.Md)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths including the `lg` screen size.
        member inline this.onlyLg = this.only (MuiBreakpointKey.Lg)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths including the `xl` screen size.
        member inline this.onlyXl = this.only (MuiBreakpointKey.Xl)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `xs` screen size and less than the the `sm`
        /// screen size.
        member inline this.betweenXsSm = this.between (MuiBreakpointKey.Xs, MuiBreakpointKey.Sm)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `xs` screen size and less than the the `md`
        /// screen size.
        member inline this.betweenXsMd = this.between (MuiBreakpointKey.Xs, MuiBreakpointKey.Md)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `xs` screen size and less than the the `lg`
        /// screen size.
        member inline this.betweenXsLg = this.between (MuiBreakpointKey.Xs, MuiBreakpointKey.Lg)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `xs` screen size and less than the the `xl`
        /// screen size.
        member inline this.betweenXsXl = this.between (MuiBreakpointKey.Xs, MuiBreakpointKey.Xl)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `sm` screen size and less than the the `md`
        /// screen size.
        member inline this.betweenSmMd = this.between (MuiBreakpointKey.Sm, MuiBreakpointKey.Md)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `sm` screen size and less than the the `lg`
        /// screen size.
        member inline this.betweenSmLg = this.between (MuiBreakpointKey.Sm, MuiBreakpointKey.Lg)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `sm` screen size and less than the the `xl`
        /// screen size.
        member inline this.betweenSmXl = this.between (MuiBreakpointKey.Sm, MuiBreakpointKey.Xl)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `md` screen size and less than the the `lg`
        /// screen size.
        member inline this.betweenMdLg = this.between (MuiBreakpointKey.Md, MuiBreakpointKey.Lg)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `md` screen size and less than the the `xl`
        /// screen size.
        member inline this.betweenMdXl = this.between (MuiBreakpointKey.Md, MuiBreakpointKey.Xl)

        /// Returns a media query string ready to be used with most styling solutions, which
        /// matches screen widths greater than the `lg` screen size and less than the the `xl`
        /// screen size.
        member inline this.betweenLgXl = this.between (MuiBreakpointKey.Lg, MuiBreakpointKey.Xl)

type Mixins =
    [<Emit("Object.entries($0.toolbar)")>]
    abstract toolbar: IStyleAttribute []

type Easing =
    abstract easeInOut: string
    abstract easeOut: string
    abstract easeIn: string
    abstract sharp: string

type Duration =
    abstract shortest: int
    abstract shorter: int
    abstract short: int
    abstract standard: int
    abstract complex: int
    abstract enteringScreen: int
    abstract leavingScreen: int

type TransitionOptions =
    abstract duration: int
    abstract easing: string
    abstract delay: int

type Transitions =
    abstract easing: Easing
    abstract duration: Duration
    abstract create: unit -> string
    abstract create: prop: string * ?options: TransitionOptions -> string
    abstract create: props: string [] * ?options: TransitionOptions -> string
    abstract getAutoHeightDuration: height: int -> int


type IStyleOverride = interface end

type IComponentOverride = interface end

type IComponentVariant =
    abstract props : seq<IReactProperty>
    abstract style : seq<IStyleAttribute>

type ComponentVariant = {
    props : seq<IReactProperty>
    style : seq<IStyleAttribute>
}

type IComponentOverrideEntry =
    abstract styleOverrides : seq<IStyleOverride>
    abstract variants : IComponentVariant []

//type ComponentTheme =
//    static member componentOverride(?styleOverrides: IStyleAttribute list, ?variants: #seq<IComponentVariant>) =
//        let styleOverrides = styleOverrides |> Option.map (fun s -> createObj !!s)
//        let variants = variants |> Option.map (fun (props, vstyles) -> {| props = createObj !!props; styles = createObj !!vstyles |})
//        ()
    //abstract defaultProps: ComponentsProps['MuiAlert'];
    //abstract styleOverrides: ComponentsOverrides<Theme>['MuiAlert'];
    //abstract variants?: ComponentsVariants['MuiAlert'];

type Theme =
    abstract components: seq<IComponentOverride>
    abstract breakpoints: Breakpoints
    abstract direction: Direction
    abstract mixins: Mixins
    abstract palette: Palette
    abstract shadows: string []
    abstract typography: Typography
    abstract spacing: a: int -> int
    abstract spacing: a: int * b: int -> ICssUnit
    abstract spacing: a: int * b: int * c: int -> ICssUnit
    abstract spacing: a: int * b: int * c: int * d: int -> ICssUnit
    abstract shape: Shape
    abstract transitions: Transitions
    abstract zIndex: ZIndex

    [<Emit("Object.entries($0)")>]
    abstract asPropArray: IThemeProp []


[<Erase>]
type Sx =
    | Styles of seq<IStyleAttribute>
    | Breakpoint of (IBreakpointKey * seq<IStyleAttribute>)
    | Callback of (Theme -> seq<IStyleAttribute>)


type MakeStylesOptions =
    /// The default theme to use if a theme isn't supplied through a Theme
    /// Provider.
    abstract defaultTheme: Theme with get, set

    /// The name of the style sheet. Useful for debugging. If the value isn't
    /// provided, it will try to fallback to the name of the component.
    abstract name: string with get, set

    /// When set to `false`, this sheet will opt-out the `rtl` transformation.
    /// When set to `true`, the styles are inversed. When set to `None`, it
    /// follows `theme.direction`.
    abstract flip: bool option with get, set

[<StringEnum; RequireQualifiedAccess>]
type TypographyVariant =
    | H1
    | H2
    | H3
    | H4
    | H5
    | H6
    | Subtitle1
    | Subtitle2
    | Overline
    | SrOnly
    | Body1
    | Body2
    | Caption
    | Button

type ResponsiveFontSizesOptions =
    /// Default to `['sm', 'md', 'lg']`.
    abstract breakpoints: MuiBreakpointKey [] with get, set

    /// Whether font sizes change slightly so line heights are preserved and align
    /// to Material Design's 4px line height grid. This requires a unitless line
    /// height in the theme's styles. Default to `false`.
    abstract disableAlign: bool with get, set

    /// This value determines the strength of font size resizing. The higher the
    /// value, the less difference there is between font sizes on small screens.
    /// The lower the value, the bigger font sizes for small screens. The value
    /// must be greater than 1. Default to 2.
    abstract factor: float with get, set

    /// The typography variants to handle. Default to all.
    abstract variants: TypographyVariant [] with get, set

type ButtonBaseActions =
    abstract focusVisible: unit -> bool

type ButtonUnstyledActions =
    abstract focusVisible: unit -> bool

type PopoverActions =
    abstract updatePosition: unit -> unit

type TabsActions =
    abstract updateIndicator: unit -> unit
    abstract updateScrollButtons: unit -> unit

[<StringEnum; RequireQualifiedAccess>]
type DialogCloseReason =
    | EscapeKeyDown
    | BackdropClick

[<StringEnum; RequireQualifiedAccess>]
type MenuCloseReason =
    | EscapeKeyDown
    | BackdropClick
    | TabKeyDown

[<StringEnum; RequireQualifiedAccess>]
type ModalCloseReason =
    | EscapeKeyDown
    | BackdropClick

[<StringEnum; RequireQualifiedAccess>]
type PopoverCloseReason =
    | EscapeKeyDown
    | BackdropClick

[<StringEnum; RequireQualifiedAccess>]
type SnackbarCloseReason =
    | Timeout
    | Clickaway

[<StringEnum; RequireQualifiedAccess>]
type SpeedDialCloseReason =
    | Toggle
    | Blur
    | MouseLeave
    | EscapeKeyDown

[<StringEnum; RequireQualifiedAccess>]
type SpeedDialOpenReason =
    | Toggle
    | Focus
    | MouseEnter

[<StringEnum; RequireQualifiedAccess>]
type PopoverOriginHorizontal =
    | Left
    | Center
    | Right

[<StringEnum; RequireQualifiedAccess>]
type PopoverOriginVertical =
    | Top
    | Center
    | Bottom

[<StringEnum; RequireQualifiedAccess>]
type AutocompleteInputChangeReason =
    /// User input.
    | Input
    /// Programmatic change.
    | Reset
    | Clear

[<StringEnum; RequireQualifiedAccess>]
type AutocompleteHighlightChangeReason =
    | Keyboard
    | Auto
    | Mouse

[<StringEnum; RequireQualifiedAccess>]
type AutocompleteMatchFrom =
    | Any
    | Start

[<StringEnum; RequireQualifiedAccess>]
type AutocompleteOnChangeReason =
    | [<CompiledName("create-option")>] CreateOption
    | [<CompiledName("select-option")>] SelectOption
    | [<CompiledName("remove-option")>] RemoveOption
    | Blur
    | Clear

[<StringEnum; RequireQualifiedAccess>]
type DatePickerView =
    | Day
    | Month
    | Year

[<StringEnum; RequireQualifiedAccess>]
type TimePickerView =
    | Seconds
    | Minutes
    | Hours

[<StringEnum; RequireQualifiedAccess>]
type DateTimePickerView =
    | Seconds
    | Minutes
    | Hours
    | Day
    | Month
    | Year

type CreateFilterOptionsOptions<'Option> =
    abstract ignoreAccents: bool with get, set
    abstract ignoreCase: bool with get, set
    abstract matchFrom: AutocompleteMatchFrom with get, set
    abstract stringify : ('Option -> string) with get, set
    abstract trim: bool with get, set

type AutocompleteFilterOptionsState =
    abstract inputValue: string

type AutocompleteRenderOptionState =
    abstract inputValue: string
    abstract selected: bool

type AutocompleteRenderValueState =
    abstract className: string
    abstract onDelete: Event -> unit

type PropsObject =
    /// Gets all properties on this object as Feliz properties you can `yield!`.
    [<Emit("Object.entries($0)")>]
    abstract felizProps: IReactProperty []

type AutocompleteRenderInputParams_InputLabelProps =
    inherit PropsObject

type AutocompleteRenderInputParams_InputProps =
    inherit PropsObject

    [<Emit("[\"className\", $0.className]")>]
    abstract className: IReactProperty

    [<Emit("[\"startAdornment\", $0.startAdornment]")>]
    abstract startAdornment: IReactProperty

    [<Emit("[\"endAdornment\", $0.endAdornment]")>]
    abstract endAdornment: IReactProperty

type AutocompleteRenderInputParams_inputProps =
    inherit PropsObject

type AutocompleteRenderInputParams =
    inherit PropsObject
    abstract InputLabelProps: AutocompleteRenderInputParams_InputLabelProps
    abstract InputProps: AutocompleteRenderInputParams_InputProps
    abstract inputProps: AutocompleteRenderInputParams_inputProps

    [<Emit("[\"ref\", $0.ref]")>]
    abstract ref: IReactProperty

type AutocompleteRenderGroupParams =
    inherit PropsObject

type PaginationRenderItemParams =
    inherit PropsObject

[<StringEnum>]
type FlexDirection =
    | [<CompiledName "column">] Column
    | [<CompiledName "row">] Row
    | [<CompiledName "column-reverse">] ColumnReverse
    | [<CompiledName "row-reverse">] RowReverse
