namespace Feliz.MaterialUI

open System
open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.Styles


[<Erase>]
type theme =
  static member inline spacing (px: int) : IThemeProp = unbox ("spacing", px)
  static member inline spacing (factorToSpacing: int -> ICssUnit) : IThemeProp = unbox ("spacing", factorToSpacing)

  static member inline componentVariants(
        componentStylesheetName: string,
        [<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []
    ) : IThemeProp =

    let variants =
        values |> Array.map (fun cv ->
            {|
                props = createObj !!cv.props
                style = createObj !!cv.style
            |})
    let componentVariantsKey = sprintf "components.%s.variants" componentStylesheetName
    unbox (componentVariantsKey, variants)
  

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module themeStatic =

  module theme =


    [<Erase>]
    type direction =
      static member inline ltr : IThemeProp = unbox ("direction", "ltr")
      static member inline rtl : IThemeProp = unbox ("direction", "rtl")


    [<Erase>]
    type palette =
      static member inline primary (color: Color) : IThemeProp = unbox ("palette.primary", color)
      static member inline secondary (color: Color) : IThemeProp = unbox ("palette.secondary", color)
      static member inline error (color: Color) : IThemeProp = unbox ("palette.error", color)
      static member inline warning (color: Color) : IThemeProp = unbox ("palette.warning", color)
      static member inline info (color: Color) : IThemeProp = unbox ("palette.info", color)
      static member inline success (color: Color) : IThemeProp = unbox ("palette.success", color)
      static member inline grey (color: Color) : IThemeProp = unbox ("palette.grey", color)
      /// Used by `getContrastText` to maximize the contrast between the background and the
      /// text. Higher values increases the point at which a background color is considered
      /// light, and given a dark contrast text. Note that `contrastThreshold` follows a
      /// non-linear curve.
      static member inline contrastThreshold (threshold: float) : IThemeProp = unbox ("palette.contrastThreshold", threshold)
      /// Used by `getContrastText` to maximize the contrast between the background and the
      /// text. Higher values increases the point at which a background color is considered
      /// light, and given a dark contrast text. Note that `contrastThreshold` follows a
      /// non-linear curve.
      static member inline contrastThreshold (threshold: int) : IThemeProp = unbox ("palette.contrastThreshold", threshold)
      /// A higher value for will make calculated values for "light" lighter, and "dark"
      /// darker.
      static member inline tonalOffset (threshold: float) : IThemeProp = unbox ("palette.tonalOffset", threshold)
      /// A higher value for will make calculated values for "light" lighter, and "dark"
      /// darker.
      static member inline tonalOffset (threshold: int) : IThemeProp = unbox ("palette.tonalOffset", threshold)
      static member inline divider (color: string) : IThemeProp = unbox ("palette.divider", color)


    module palette =

      [<Erase>]
      type common =
        static member inline black (color: string) : IThemeProp = unbox ("palette.common.black", color)
        static member inline white (color: string) : IThemeProp = unbox ("palette.common.white", color)


      [<Erase>]
      type mode =
        static member inline light : IThemeProp = unbox ("palette.mode", "light")
        static member inline dark : IThemeProp = unbox ("palette.mode", "dark")

      [<Erase>]
      type primary' =
        static member inline light (color: string) : IThemeProp = unbox ("palette.primary.light", color)
        static member inline main (color: string) : IThemeProp = unbox ("palette.primary.main", color)
        static member inline dark (color: string) : IThemeProp = unbox ("palette.primary.dark", color)
        static member inline contrastText (color: string) : IThemeProp = unbox ("palette.primary.contrastText", color)

      [<Erase>]
      type secondary' =
        static member inline light (color: string) : IThemeProp = unbox ("palette.secondary.light", color)
        static member inline main (color: string) : IThemeProp = unbox ("palette.secondary.main", color)
        static member inline dark (color: string) : IThemeProp = unbox ("palette.secondary.dark", color)
        static member inline contrastText (color: string) : IThemeProp = unbox ("palette.secondary.contrastText", color)

      [<Erase>]
      type error' =
        static member inline light (color: string) : IThemeProp = unbox ("palette.error.light", color)
        static member inline main (color: string) : IThemeProp = unbox ("palette.error.main", color)
        static member inline dark (color: string) : IThemeProp = unbox ("palette.error.dark", color)
        static member inline contrastText (color: string) : IThemeProp = unbox ("palette.error.contrastText", color)

      [<Erase>]
      type warning' =
        static member inline light (color: string) : IThemeProp = unbox ("palette.warning.light", color)
        static member inline main (color: string) : IThemeProp = unbox ("palette.warning.main", color)
        static member inline dark (color: string) : IThemeProp = unbox ("palette.warning.dark", color)
        static member inline contrastText (color: string) : IThemeProp = unbox ("palette.warning.contrastText", color)

      [<Erase>]
      type info' =
        static member inline light (color: string) : IThemeProp = unbox ("palette.info.light", color)
        static member inline main (color: string) : IThemeProp = unbox ("palette.info.main", color)
        static member inline dark (color: string) : IThemeProp = unbox ("palette.info.dark", color)
        static member inline contrastText (color: string) : IThemeProp = unbox ("palette.info.contrastText", color)

      [<Erase>]
      type success' =
        static member inline light (color: string) : IThemeProp = unbox ("palette.success.light", color)
        static member inline main (color: string) : IThemeProp = unbox ("palette.success.main", color)
        static member inline dark (color: string) : IThemeProp = unbox ("palette.success.dark", color)
        static member inline contrastText (color: string) : IThemeProp = unbox ("palette.success.contrastText", color)

      [<Erase>]
      type text =
        static member inline primary (color: string) : IThemeProp = unbox ("palette.text.primary", color)
        static member inline secondary (color: string) : IThemeProp = unbox ("palette.text.secondary", color)
        static member inline disabled (color: string) : IThemeProp = unbox ("palette.text.disabled", color)
        static member inline hint (color: string) : IThemeProp = unbox ("palette.text.hint", color)

      [<Erase>]
      type background =
        static member inline paper (color: string) : IThemeProp = unbox ("palette.background.paper", color)
        static member inline default' (color: string) : IThemeProp = unbox ("palette.background.default", color)

      [<Erase>]
      type action =
        static member inline active (color: string) : IThemeProp = unbox ("palette.action.active", color)
        static member inline hover (color: string) : IThemeProp = unbox ("palette.action.hover", color)
        static member inline hoverOpacity (value: float) : IThemeProp = unbox ("palette.action.hoverOpacity", value)
        static member inline selected (color: string) : IThemeProp = unbox ("palette.action.selected", color)
        static member inline disabled (color: string) : IThemeProp = unbox ("palette.action.disabled", color)
        static member inline disabledBackground (color: string) : IThemeProp = unbox ("palette.action.disabledBackground", color)

    [<Erase>]
    type typography =
      /// Tells Material-UI what the font-size on the `<html>` element is. This is used to
      /// adjust the `rem` value so the calculated font size always matches the
      /// specification.
      static member inline htmlFontSize (value: int) : IThemeProp = unbox ("typography.htmlFontSize", value)
      /// Tells Material-UI what the font-size on the `<html>` element is. This is used to
      /// adjust the `rem` value so the calculated font size always matches the
      /// specification.
      static member inline htmlFontSize (value: float) : IThemeProp = unbox ("typography.htmlFontSize", value)
      static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.fontFamily", value)
      static member inline fontSize (value: int) : IThemeProp = unbox ("typography.fontSize", value)
      static member inline fontSize (value: float) : IThemeProp = unbox ("typography.fontSize", value)
      static member inline fontWeightLight (value: int) : IThemeProp = unbox ("typography.fontWeightLight", value)
      static member inline fontWeightRegular (value: int) : IThemeProp = unbox ("typography.fontWeightRegular", value)
      static member inline fontWeightMedium (value: int) : IThemeProp = unbox ("typography.fontWeightMedium", value)
      static member inline fontWeightBold (value: int) : IThemeProp = unbox ("typography.fontWeightBold", value)

    module typography =

      [<Erase>]
      type h1 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.h1.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.h1.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.h1.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.h1.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.h1.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.h1.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.h1.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.h1.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.h1.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.h1.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.h1.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.h1.textTransform", value)

      [<Erase>]
      type h2 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.h2.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.h2.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.h2.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.h2.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.h2.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.h2.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.h2.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.h2.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.h2.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.h2.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.h2.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.h2.textTransform", value)

      [<Erase>]
      type h3 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.h3.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.h3.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.h3.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.h3.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.h3.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.h3.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.h3.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.h3.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.h3.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.h3.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.h3.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.h3.textTransform", value)

      [<Erase>]
      type h4 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.h4.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.h4.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.h4.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.h4.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.h4.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.h4.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.h4.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.h4.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.h4.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.h4.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.h4.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.h4.textTransform", value)

      [<Erase>]
      type h5 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.h5.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.h5.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.h5.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.h5.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.h5.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.h5.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.h5.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.h5.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.h5.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.h5.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.h5.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.h5.textTransform", value)

      [<Erase>]
      type h6 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.h6.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.h6.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.h6.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.h6.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.h6.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.h6.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.h6.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.h6.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.h6.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.h6.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.h6.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.h6.textTransform", value)

      [<Erase>]
      type subtitle1 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.subtitle1.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.subtitle1.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.subtitle1.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.subtitle1.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.subtitle1.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.subtitle1.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.subtitle1.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.subtitle1.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.subtitle1.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.subtitle1.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.subtitle1.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.subtitle1.textTransform", value)

      [<Erase>]
      type subtitle2 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.subtitle2.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.subtitle2.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.subtitle2.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.subtitle2.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.subtitle2.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.subtitle2.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.subtitle2.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.subtitle2.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.subtitle2.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.subtitle2.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.subtitle2.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.subtitle2.textTransform", value)

      [<Erase>]
      type body1 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.body1.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.body1.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.body1.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.body1.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.body1.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.body1.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.body1.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.body1.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.body1.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.body1.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.body1.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.body1.textTransform", value)

      [<Erase>]
      type body2 =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.body2.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.body2.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.body2.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.body2.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.body2.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.body2.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.body2.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.body2.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.body2.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.body2.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.body2.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.body2.textTransform", value)

      [<Erase>]
      type button =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.button.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.button.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.button.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.button.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.button.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.button.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.button.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.button.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.button.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.button.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.button.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.button.textTransform", value)

      [<Erase>]
      type caption =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.caption.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.caption.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.caption.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.caption.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.caption.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.caption.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.caption.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.caption.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.caption.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.caption.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.caption.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.caption.textTransform", value)

      [<Erase>]
      type overline =
        static member inline fontFamily (value: string) : IThemeProp = unbox ("typography.overline.fontFamily", value)
        static member inline fontWeight (value: int) : IThemeProp = unbox ("typography.overline.fontWeight", value)
        static member inline fontSize (value: int) : IThemeProp = unbox ("typography.overline.fontSize", value)
        static member inline fontSize (value: float) : IThemeProp = unbox ("typography.overline.fontSize", value)
        static member inline fontSize (value: ICssUnit) : IThemeProp = unbox ("typography.overline.fontSize", value)
        static member inline fontSize (value: string) : IThemeProp = unbox ("typography.overline.fontSize", value)
        static member inline lineHeight (value: int) : IThemeProp = unbox ("typography.overline.lineHeight", value)
        static member inline lineHeight (value: float) : IThemeProp = unbox ("typography.overline.lineHeight", value)
        static member inline letterSpacing (value: ICssUnit) : IThemeProp = unbox ("typography.overline.letterSpacing", value)
        static member inline marginLeft (value: ICssUnit) : IThemeProp = unbox ("typography.overline.marginLeft", value)
        static member inline color (value: string) : IThemeProp = unbox ("typography.overline.color", value)
        static member inline textTransform (value: string) : IThemeProp = unbox ("typography.overline.textTransform", value)


    [<Erase>]
    type shape =
      static member inline borderRadius (value: int) = unbox ("shape.borderRadius", value)


    module transitions =

      [<Erase>]
      type easing =
        static member inline easeInOut (value: string) = unbox ("transitions.easing.easeInOut", value)
        static member inline easeOut (value: string) = unbox ("transitions.easing.easeOut", value)
        static member inline easeIn (value: string) = unbox ("transitions.easing.easeIn", value)
        static member inline sharp (value: string) = unbox ("transitions.easing.sharp", value)

      [<Erase>]
      type duration =
        static member inline shortest (value: int) = unbox ("transitions.duration.shortest", value)
        static member inline shorter (value: int) = unbox ("transitions.duration.shorter", value)
        static member inline short (value: int) = unbox ("transitions.duration.short", value)
        static member inline standard (value: int) = unbox ("transitions.duration.standard", value)
        static member inline complex (value: int) = unbox ("transitions.duration.complex", value)
        static member inline enteringScreen (value: int) = unbox ("transitions.duration.enteringScreen", value)
        static member inline leavingScreen (value: int) = unbox ("transitions.duration.leavingScreen", value)


    [<Erase>]
    type zIndex =
      static member inline mobileStepper (value: int) = unbox ("zIndex.mobileStepper", value)
      static member inline speedDial (value: int) = unbox ("zIndex.speedDial", value)
      static member inline appBar (value: int) = unbox ("zIndex.appBar", value)
      static member inline drawer (value: int) = unbox ("zIndex.drawer", value)
      static member inline modal (value: int) = unbox ("zIndex.modal", value)
      static member inline snackbar (value: int) = unbox ("zIndex.snackbar", value)
      static member inline tooltip (value: int) = unbox ("zIndex.tooltip", value)
