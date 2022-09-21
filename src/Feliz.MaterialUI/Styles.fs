namespace Feliz.MaterialUI

open System
open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<EditorBrowsable(EditorBrowsableState.Never)>]
module StyleImports =

    let makeStyles_get (getStyles: Theme -> obj) : ('props -> 'a) = import "makeStyles" "@mui/styles"

    let makeStyles_getWithOpts (getStyles: Theme -> obj) (opts: MakeStylesOptions) : ('props -> 'a) =
        import "makeStyles" "@mui/styles"

    let makeStyles_obj (styles: obj) : ('props -> 'a) = import "makeStyles" "@mui/styles"

    let makeStyles_objWithOpts (styles: obj) (opts: MakeStylesOptions) : ('props -> 'a) =
        import "makeStyles" "@mui/styles"

    let responsiveFontSizes (theme: Theme) : Theme =
        import "responsiveFontSizes" "@mui/material/styles"

    let responsiveFontSizes_opts (theme: Theme) (opts: ResponsiveFontSizesOptions) : Theme =
        import "responsiveFontSizes" "@mui/material/styles"

    let createTheme_argsArray (theme: Theme, [<ParamArray>] extra: Theme []) : Theme =
        import "createTheme" "@mui/material/styles"

    let createTheme_unit () : Theme =
        import "createTheme" "@mui/material/styles"

    let useTheme () : Theme =
        import "useTheme" "@mui/material/styles"


type StyleCreator<'props>() =

    /// Use with `makeStyles` etc. when returning an (anonymous) record of style
    /// properties or functions. Simply unboxes the input to `string` (which it is
    /// at runtime when returned by the JSS styling solution), so that the
    /// properties can be used in `className` and `classes` props.
    member _.create(styles: #seq<IStyleAttribute>) =
        styles |> unbox |> createObj |> unbox<string>

    /// Use with `makeStyles` etc. when returning an (anonymous) record of style
    /// properties or functions. Simply unboxes the input to `string` (which it is
    /// at runtime when returned by the JSS styling solution), so that the
    /// properties can be used in `className` and `classes` props.
    member _.create(getStyles: 'props -> #seq<IStyleAttribute>) =
        (getStyles >> unbox >> createObj) |> unbox<string>

[<Erase>]
type Styles =

    /// This hook links a style sheet with a function component.
    ///
    /// The Material-UI documentation often calls the returned hook `useStyles`.
    /// It accepts one argument: the properties that will be used for
    /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
    static member inline makeStyles(getStyles: StyleCreator<'props> -> Theme -> 'a) : ('props -> 'a) =
        StyleImports.makeStyles_get (getStyles (StyleCreator()) >> toPlainJsObj)

    /// This hook links a style sheet with a function component.
    ///
    /// The Material-UI documentation often calls the returned hook `useStyles`.
    /// It accepts one argument: the properties that will be used for
    /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
    static member inline makeStyles
        (
            getStyles: StyleCreator<'props> -> Theme -> 'a,
            options: MakeStylesOptions
        ) : ('props -> 'a) =
        StyleImports.makeStyles_getWithOpts (getStyles (StyleCreator()) >> toPlainJsObj) options

    /// This hook returns the theme object so it can be used inside a function
    /// component.
    static member inline useTheme() : Theme = StyleImports.useTheme ()

    /// Generate a theme base on the incomplete theme object represented by the specified
    /// props, and deep merge any extra arguments with this theme.
    static member inline createTheme(props: IThemeProp list, [<ParamArray>] merge: Theme []) : Theme =
        let theme = !!props |> Object.fromFlatEntries :?> Theme
        StyleImports.createTheme_argsArray (theme, merge)

    /// Deep merge any extra arguments with the first theme.
    static member inline createTheme(theme: Theme, [<ParamArray>] merge: Theme []) : Theme =
        StyleImports.createTheme_argsArray (theme, merge)

    /// Returns a default theme object.
    static member inline createTheme() : Theme = StyleImports.createTheme_unit ()

    /// Generate responsive typography settings based on the options received.
    static member inline responsiveFontSizes(theme: Theme) : Theme = StyleImports.responsiveFontSizes theme

    /// Generate responsive typography settings based on the options received.
    static member inline responsiveFontSizes(theme: Theme, options: ResponsiveFontSizesOptions) : Theme =
        StyleImports.responsiveFontSizes_opts theme options

    static member inline createComponentOverride(componentStylesheetName: string, ?styleOverrides: seq<IStyleOverride>, ?variants: IComponentVariant []) : IComponentOverride =
        !! (componentStylesheetName,
            createObj [
                "styleOverrides", createObj !! (defaultArg styleOverrides [])
                "variants", variants
            ])

    static member inline createComponentVariant(props : seq<IReactProperty>, style : seq<IStyleAttribute>) : IComponentVariant =
        !! createObj [
            "props", createObj !!props
            "style", createObj !!style
        ]


[<Erase>]
type style =

    /// Allows nesting styles, for example for JSS selectors etc.
    static member inline inner (name: string) (styles: IStyleAttribute list) =
        Interop.mkStyle name (createObj !!styles)

    static member inline breakpoint (breakpointKey: IBreakpointKey) (styles: #seq<IStyleAttribute>) =
        Interop.mkStyle (string breakpointKey) (createObj !!styles)

    static member inline muiBreakpoints(
            ?xs: seq<IStyleAttribute>,
            ?sm: seq<IStyleAttribute>,
            ?md: seq<IStyleAttribute>,
            ?lg: seq<IStyleAttribute>,
            ?xl: seq<IStyleAttribute>
        ) =
        createObj !![
            MuiBreakpointKey.Xs, createObj !! (defaultArg xs [])
            MuiBreakpointKey.Sm, createObj !! (defaultArg sm [])
            MuiBreakpointKey.Md, createObj !! (defaultArg md [])
            MuiBreakpointKey.Lg, createObj !! (defaultArg lg [])
            MuiBreakpointKey.Xl, createObj !! (defaultArg xl [])
        ]

    //static member inline themeStylesOverride (callback: Theme -> #seq<IStyleAttribute>): 't =
    //    !!(Func<Theme, _> (fun theme -> let styleOverrides = callback theme in (createObj !!styleOverrides)))

    //static member inline breakpointThemeOverrides (overrides: (IBreakpointKey * (Theme -> #seq<IStyleAttribute>)) []) =
    //    overrides |> Array.map (fun (breakpoint, themeOverride) -> string breakpoint, style.themeStylesOverride themeOverride) |> !!createObj

    //static member inline themeBreakpointStylesOverrides (overrides: (Theme -> (IBreakpointKey * #seq<IStyleAttribute>) list) []) =
    //    overrides |> Array.map (fun themeBpOverride -> Func<Theme, _> (fun theme -> let bpStyles = themeBpOverride theme in (bpStyles |> List.map (fun (bp, styles) -> style.breakpoint bp styles) |> !!createObj)))
