module Main

open Fable.Core.JsInterop

importAll "../sass/main.sass"
importAll "../react-highlight-vs2019-custom.css"

open Feliz
open Feliz.Router
open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR


open Fable.Core.JsInterop
open Fable.Core.DynamicExtensions
open Browser.Dom

// This is a tweak to get rid of errors during react-markdown rendering.
// Taken from: https://github.com/remarkjs/react-markdown/issues/339#issuecomment-653396337
window.Item("process") <- {| cwd = fun () -> "" |}

Program.mkSimple App.init App.update App.AppView
#if DEBUG
|> Program.withDebugger
#endif
|> Program.withReactBatched "feliz-app"
|> Program.runWith (Router.currentUrl())
