module CommonViews

open Feliz
open Feliz.MaterialUI
open Feliz.ReactHighlight

[<ReactComponent>]
let Code (language: string) (code: string) =
    Mui.paper [
        paper.elevation 0
        paper.children [
            Highlight.highlight [
                prop.className (
                    if language = "f#" then
                        "fsharp"
                    else
                        language
                )
                prop.text code
            ]
        ]
    ]
