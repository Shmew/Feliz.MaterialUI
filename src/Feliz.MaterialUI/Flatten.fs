namespace Feliz.MaterialUI

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop

[<EditorBrowsable(EditorBrowsableState.Never)>]
module Object =
  [<Emit("$0 === undefined")>]
  let private isUndefined x = jsNative

  let fromFlatEntries (kvs: seq<string * obj>) : obj =
    let rec setProperty (target : obj) (key : string) (value : obj) =
      match key.IndexOf '.' with
      | -1 -> target?(key) <- value
      | sepIdx ->
        let topKey = key.Substring (0, sepIdx)
        let nestedKey = key.Substring (sepIdx + 1)
        if isUndefined target?(topKey) then
          target?(topKey) <- obj ()
        setProperty target?(topKey) nestedKey value

    let target = obj ()
    for (key, value) in kvs do
      setProperty target key value
    target

