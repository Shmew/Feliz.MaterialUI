﻿module MarkdonViewer

open Elmish
open Fable.React
open Fable.MaterialUI.Icons
open Fable.MaterialUI.MaterialDesignIcons
open Fable.SimpleHttp
open Feliz
open Feliz.ElmishComponents
open Feliz.Markdown
open Feliz.MaterialUI
open SampleViewer


type MarkdownContent = string
type Path = string list
type Url = string
type ErrorMessage = string
type StatusCode = int


type State =
  | Initial
  | Loading
  | Loaded of Result<Path * MarkdownContent, ErrorMessage>


type Msg =
  | StartLoad of path: string list
  | LoadCompleted of Result<Path * MarkdownContent, ErrorMessage>


let init path =
  Initial, Cmd.ofMsg (StartLoad path)


let update (msg: Msg) (state: State) =
  match msg with
  | StartLoad path ->
      let url = path |> String.concat "/"
      let loadMarkdown () =
        async {
          let! statusCode, responseText = Http.get url
          if statusCode = 200 then
            return Ok (path, responseText)
          else
            return Error (sprintf "Failed with status %i when loading %s" statusCode url)
        }

      Loading, Cmd.OfAsync.perform loadMarkdown () LoadCompleted

  | LoadCompleted res ->
      Loaded res, Cmd.none



let render (state: State) dispatch =
  match state with
  | Initial ->
      Html.none
  | Loading ->
      React.fragment [
        Mui.skeleton [
          skeleton.variant.text
          skeleton.height (length.em 3)
          skeleton.width 500
        ]
        Mui.skeleton [
          skeleton.variant.text
          skeleton.height (length.em 1)
          skeleton.width 300
        ]
        Mui.skeleton [
          skeleton.variant.text
          skeleton.height (length.em 1)
          skeleton.width 200
        ]
        Mui.skeleton [
          skeleton.variant.rect
          skeleton.height 200
          skeleton.width 500
        ]
      ]
  | Loaded (Ok (path, content)) ->
      React.fragment [
        Mui.tooltip [
          tooltip.title ("Edit this page")
          tooltip.children(
            Mui.iconButton [
              prop.style [
                style.floatStyle.right
              ]
              prop.href (sprintf "https://github.com/Shmew/Feliz.MaterialUI/edit/master/docs-app/public/%s" (String.concat "/" path))
              iconButton.component' "a"
              iconButton.children (pencilIcon [])
            ]
          )
        ]
        Markdown.markdown [
          markdown.source content
          markdown.escapeHtml false
          markdown.renderers [
            markdown.renderers.paragraph (fun props ->
              Mui.typography [
                typography.paragraph true
                typography.children props.children
              ]
            )
            markdown.renderers.link (fun props ->
              Mui.link [
                prop.href props.href
                link.children props.children
              ]
            )
            markdown.renderers.code (fun props ->
              if props.language = "sample" then
                let path = path.[0..path.Length - 2] @ [props.value]
                sampleViewer path
              else
                CommonViews.code (props.language, props.value)
            )
            markdown.renderers.heading (fun props ->
              Mui.typography [
                match props.level with
                | 1 -> typography.variant.h1
                | 2 -> typography.variant.h2
                | 3 -> typography.variant.h3
                | 4 -> typography.variant.h4
                | 5 -> typography.variant.h5
                | 6 -> typography.variant.h6
                | _ -> ()
                typography.paragraph true
                typography.children props.children
              ]
            )
          ]
        ]
      ]
  | Loaded (Error errorMsg) ->
      Mui.typography [
        typography.color.error
        typography.paragraph true
        typography.children errorMsg
      ]

let markdownViewer =
  React.memo(
    areEqual = equalsButFunctions,
    render = (
      fun (props: {| path: _ |}) ->
        React.elmishComponent("MarkdownLoader", init props.path, update, render)
    )
  )
