module Samples.Usage.Hooks.UseMediaQuery

open Elmish
open Feliz
open Feliz.MaterialUI

type private Props = { key: string }

[<ReactComponent>]
let UseMediaQuerySample (sampleKey: string) =
    let isDarkMode = Hooks.useMediaQuery "(prefers-color-scheme: dark)"

    Html.div [
        Mui.typography [
            typography.children (
                "System dark mode is currently " +
                (if isDarkMode then "enabled" else "disabled")
            )
        ]
    ]
