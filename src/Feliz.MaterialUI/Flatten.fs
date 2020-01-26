namespace Feliz.MaterialUI

module internal Object =

  open Fable.Core
  open Fable.Core.JS
  open Fable.Core.JsInterop

  [<Emit("""
function setProperty(target, key, value) {
  const sepIdx = key.indexOf('.')
  if (sepIdx === -1) {
    target[key] = value
  } else {
    const topKey = key.substring(0, sepIdx)
    const nestedKey = key.substring(sepIdx + 1)
    if (target[topKey] === undefined) {
      target[topKey] = {}
    }
    setProperty(target[topKey], nestedKey, value)
  }
}

const target = {}
for (let kv of $0) {
  setProperty(target, kv[0], kv[1])
}

return target
""")>]
  let fromFlatEntries (kvs: seq<string * obj>) : obj = jsNative
