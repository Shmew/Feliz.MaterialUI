module Main

open Fable.Core.JsInterop

importAll "../sass/main.sass"

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkSimple App.init App.update App.view
#if DEBUG
|> Program.withDebugger
#endif
|> Program.withReactSynchronous "feliz-app"
|> Program.run
