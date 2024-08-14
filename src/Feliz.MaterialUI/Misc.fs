namespace Feliz.MaterialUI

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz

/// A unusable type that indicates that an inherited prop is not supported.
[<Erase; EditorBrowsable(EditorBrowsableState.Never)>]
type UnsupportedProp () = class end

type IThemeProp = interface end


[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module Utils =

  [<Emit("Object.entries($0)"); EditorBrowsable(EditorBrowsableState.Never)>]
  let objectEntries (x: obj) : obj = jsNative

  let inline kvPairsToObjCallback (f: 'T -> seq<string * obj>): 'T -> 'Object =
    let inline g (x: 'T): 'U =
        let kvPairs = f x 
        unbox (createObj kvPairs)
    g

  let inline stylesCallback (f: 'T -> seq<IStyleAttribute>): 'T -> 'Object = kvPairsToObjCallback !!f
  let inline propsCallback (f: 'T -> seq<IReactProperty>): 'T -> 'Object = kvPairsToObjCallback !!f
