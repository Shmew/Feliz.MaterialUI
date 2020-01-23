namespace Feliz.MaterialUI

open System.ComponentModel
open Fable.Core.JsInterop


[<EditorBrowsable(EditorBrowsableState.Never)>]
type FlatOptions =
  abstract delimiter: string with get, set
  abstract safe: bool with get, set
  abstract object: bool with get, set
  abstract overwrite: bool with get, set
  abstract maxDepth: int with get, set
  abstract transformKey: string -> string with get, set


[<EditorBrowsable(EditorBrowsableState.Never)>]
type Flat =
  abstract flatten: original: obj * ?options: FlatOptions -> obj
  abstract unflatten: original: obj * ?options: FlatOptions -> obj



[<EditorBrowsable(EditorBrowsableState.Never)>]
module Flat =

  let flat : Flat = importDefault "flat"
