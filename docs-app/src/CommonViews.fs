module CommonViews

open Feliz
open Feliz.MaterialUI
open Feliz.ReactHighlight

let code = React.functionComponent(fun (language: string, code: string) ->
  Mui.paper [
    paper.elevation 0
    paper.children [
      Highlight.highlight [
        prop.className (if language = "f#" then "fsharp" else language)
        prop.text code
      ]
    ]
  ]
)
