namespace Feliz.MaterialUI

open System
open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz


[<EditorBrowsable(EditorBrowsableState.Never)>]
module StyleImports =

  let makeStyles_get (getStyles: Theme -> obj) : ('props -> 'a) =
    import "makeStyles" "@material-ui/core/styles"

  let makeStyles_getWithOpts (getStyles: Theme -> obj) (opts: MakeStylesOptions) : ('props -> 'a) =
    import "makeStyles" "@material-ui/core/styles"

  let makeStyles_obj (styles: obj) : ('props -> 'a) =
    import "makeStyles" "@material-ui/core/styles"

  let makeStyles_objWithOpts (styles: obj) (opts: MakeStylesOptions) : ('props -> 'a) =
    import "makeStyles" "@material-ui/core/styles"

  let responsiveFontSizes (theme: Theme) : Theme =
    import "responsiveFontSizes" "@material-ui/core/styles"

  let responsiveFontSizes_opts (theme: Theme) (opts: ResponsiveFontSizesOptions) : Theme =
    import "responsiveFontSizes" "@material-ui/core/styles"

  let createMuiTheme_argsArray (theme: Theme, [<ParamArray>] extra: Theme []) : Theme =
    import "createMuiTheme" "@material-ui/core/styles"

  let createMuiTheme_unit () : Theme =
    import "createMuiTheme" "@material-ui/core/styles"

  let useTheme () : Theme =
    import "useTheme" "@material-ui/core/styles"


type StyleCreator<'props>() =

  /// Use with `makeStyles` etc. when returning an (anonymous) record of style
  /// properties or functions. Simply unboxes the input to `string` (which it is
  /// at runtime when returned by the JSS styling solution), so that the
  /// properties can be used in `className` and `classes` props.
  member _.create (styles: #seq<IStyleAttribute>) =
    styles |> unbox |> createObj |> unbox<string>

  /// Use with `makeStyles` etc. when returning an (anonymous) record of style
  /// properties or functions. Simply unboxes the input to `string` (which it is
  /// at runtime when returned by the JSS styling solution), so that the
  /// properties can be used in `className` and `classes` props.
  member _.create (getStyles: 'props -> #seq<IStyleAttribute>) =
    (getStyles >> unbox >> createObj) |> unbox<string>


[<Erase>]
type Styles =

  /// This hook links a style sheet with a function component.
  ///
  /// The Material-UI documentation often calls the returned hook `useStyles`.
  /// It accepts one argument: the properties that will be used for
  /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
  static member inline makeStyles
      ( getStyles: StyleCreator<'props> -> Theme -> 'a
      ) : ('props -> 'a) =
    StyleImports.makeStyles_get (getStyles (StyleCreator()) >> toPlainJsObj)

  /// This hook links a style sheet with a function component.
  ///
  /// The Material-UI documentation often calls the returned hook `useStyles`.
  /// It accepts one argument: the properties that will be used for
  /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
  static member inline makeStyles
      ( getStyles: StyleCreator<'props> -> Theme -> 'a,
        options: MakeStylesOptions
      ) : ('props -> 'a) =
    StyleImports.makeStyles_getWithOpts (getStyles (StyleCreator()) >> toPlainJsObj) options

  /// This hook returns the theme object so it can be used inside a function
  /// component.
  static member inline useTheme() : Theme =
    StyleImports.useTheme ()

  /// Generate a theme base on the incomplete theme object represented by the specified
  /// props, and deep merge any extra arguments with this theme.
  static member inline createMuiTheme (props: IThemeProp list, [<ParamArray>] merge: Theme []) : Theme =
    let theme =
      !!props
      |> Object.fromFlatEntries
      :?> Theme
    StyleImports.createMuiTheme_argsArray(theme, merge)

  /// Deep merge any extra arguments with the first theme.
  static member inline createMuiTheme (theme: Theme, [<ParamArray>] merge: Theme []) : Theme =
    StyleImports.createMuiTheme_argsArray(theme, merge)

  /// Returns a default theme object.
  static member inline createMuiTheme () : Theme =
    StyleImports.createMuiTheme_unit ()

  /// Generate responsive typography settings based on the options received.
  static member inline responsiveFontSizes (theme: Theme) : Theme =
    StyleImports.responsiveFontSizes theme

  /// Generate responsive typography settings based on the options received.
  static member inline responsiveFontSizes (theme: Theme, options: ResponsiveFontSizesOptions) : Theme =
    StyleImports.responsiveFontSizes_opts theme options


[<Erase>]
type style =

  /// Allows nesting styles, for example for JSS selectors etc.
  // TODO: rename?
  static member inline inner (name: string) (styles: IStyleAttribute list) =
    Interop.mkStyle name (createObj !!styles)
