namespace Feliz.MaterialUI

open System.ComponentModel
open Fable.Core

/// A unusable type that indicates that an inherited prop is not supported.
[<Erase; EditorBrowsable(EditorBrowsableState.Never)>]
type UnsupportedProp () = class end

type IThemeProp = interface end


[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module Utils =

  [<Emit("Object.entries($0)"); EditorBrowsable(EditorBrowsableState.Never)>]
  let inline objectEntries (x: obj) : obj = jsNative
