module Samples.Usage.Hooks.UseMediaQuery

open Elmish
open Feliz
open Feliz.MaterialUI


type private Props = { key: string }


let private sample = React.functionComponent("UseMediaQuery", (fun props -> props.key), fun _ ->
  let isDarkMode = Hooks.useMediaQuery "@media (prefers-color-scheme: dark)"
  [
    Mui.typography [
      typography.children ("System dark mode is currently " + if isDarkMode then "enabled" else "disabled")
    ]
  ])


let getSample (key: string) =
  sample { key = key }
