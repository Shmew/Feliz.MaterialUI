namespace Feliz.MaterialUI

open System.ComponentModel
open Fable.Core

/// A unusable type that indicates that an inherited prop is not supported.
[<Erase; EditorBrowsable(EditorBrowsableState.Never)>]
type UnsupportedProp () = class end

type IOverrideStyleSheet = interface end
type IThemeProps = interface end
