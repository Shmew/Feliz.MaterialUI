﻿module SampleViewer

#nowarn "44" // Supress "deprecated" warnings, caused by `Feliz.Markdown` package

open System
open Elmish
open Fable.Core
open Fable.Core.JsInterop
open Fable.SimpleHttp
open Feliz
open Feliz.UseElmish
open Feliz.Markdown
open Feliz.MaterialUI

let samples =
    Map.ofList [
        "Samples.Usage.Localization.Localization", Samples.Usage.Localization.Localization.LocalizationSample
        "Samples.Usage.Hooks.UseMediaQuery", Samples.Usage.Hooks.UseMediaQuery.UseMediaQuerySample
        "Samples.Components.Autocomplete.Autocomplete", Samples.Components.Autocomplete.Autocomplete.Autocomplete
        "Samples.Samples.SignIn.SignIn", Samples.Samples.SignIn.SignIn.SignIn
        "Samples.Samples.DateTimePickers.DateTimePickers", Samples.Samples.DateTimePickers.DateTimePickers.DateTimePickersSample
    ]

type Sample = ReactElement
type CodeBlock = string
type Path = string list
type Url = string
type ErrorMessage = string
type StatusCode = int

type State =
    | Initial
    | Loading
    | Loaded of Result<(string -> Sample) * CodeBlock * Path, ErrorMessage>

type Msg =
    | StartLoad of path: Path
    | LoadCompleted of Result<(string -> Sample) * CodeBlock * Path, ErrorMessage>

let init path = Initial, Cmd.ofMsg (StartLoad path)

let update (msg: Msg) (state: State) =
    match msg with
    | StartLoad path ->
        let url = path |> String.concat "/"

        let loadSource () =
            async {
                let! statusCode, responseText = Http.get url

                if statusCode = 200 then
                    let codeBlock = sprintf "```fsharp\n%s\n```" responseText
                    let sampleName = responseText.Split('\n').[0].Trim().Substring (7)

                    let sample =
                        samples.TryFind sampleName
                        |> Option.defaultWith (fun () _ ->
                            Mui.typography [
                                typography.sx (fun t -> [ style.color t.palette.error.main ])
                                typography.paragraph true
                                typography.children (sprintf "Sample not found: '%s'" sampleName)
                            ])

                    return Ok (sample, codeBlock, path)
                else
                    return Error (sprintf "Failed with status %i when loading %s" statusCode url)
            }

        Loading, Cmd.OfAsync.perform loadSource () LoadCompleted

    | LoadCompleted res -> Loaded res, Cmd.none

type DemoProps =
    {|
        GetSample: string -> Sample
        MarkdownCodeBlock: string
        Path: string list
    |}

//let useDemoStyles =
//    Styles.makeStyles (fun styles theme ->
//        let bgColor =
//            if theme.palette.mode = PaletteType.Light then
//                theme.palette.grey.``100``
//            else
//                theme.palette.grey.A400

//        {|
//            demoPaper =
//                styles.create [
//                    style.padding (theme.spacing 3)
//                    style.backgroundColor bgColor
//                ]
//            codePanel =
//                styles.create [
//                    style.backgroundColor bgColor
//                ]
//            resetSampleButton =
//                styles.create [
//                    style.floatStyle.right
//                    style.marginTop (-theme.spacing 2)
//                    style.marginRight (-theme.spacing 2)
//                ]
//        |})


[<ReactMemoComponent>]
let Demo (getSample: string -> Sample) (markdownCodeBlock: string) (path: string list) = //(props: DemoProps) =
    //let c = useDemoStyles ()
    let isExpanded, setIsExpanded = React.useState false
    let sampleKey, updateSampleKey = React.useStateWithUpdater 0

    let theme = Styles.useTheme()

    let bgColor = React.useMemo (
        (fun () ->
            if theme.palette.mode = PaletteType.Light then
                theme.palette.grey.``100``
            else
                theme.palette.grey.A700
        ), [| theme.palette.mode; theme.palette.grey |]
    )
        

    let sample =
        React.useMemo ((fun () -> getSample (string sampleKey)), [| string sampleKey |])

    Html.div [

        // Sample
        Mui.paper [
            //paper.classes.root c.demoPaper
            paper.sx [
                style.padding (theme.spacing 3)
                style.backgroundColor bgColor
            ]
            prop.children [
                Mui.tooltip [
                    tooltip.title ("Reset sample")
                    tooltip.children (
                        Mui.iconButton [
                            //iconButton.classes.root c.resetSampleButton
                            iconButton.sx [
                                style.floatStyle.right
                                style.marginTop (-theme.spacing 2)
                                style.marginRight (-theme.spacing 2)
                            ]
                            button.children (Feliz.MaterialUI.Icons.undoIcon [])
                            prop.onClick (fun _ -> updateSampleKey (fun k -> k + 1))
                        ]
                    )
                ]
                sample
            ]
            paper.elevation 0
        ]

        Mui.grid [
            grid.container
            grid.sx [ style.justifyContent.flexEnd; style.flexDirection.row ]
            grid.children [
                // GitHub button
                Mui.tooltip [
                    tooltip.title (
                        if isExpanded then
                            "Hide code"
                        else
                            "Show code"
                    )
                    tooltip.children (
                        Mui.iconButton [
                            prop.onClick (fun _ -> setIsExpanded (not isExpanded))
                            iconButton.color.inherit'
                            iconButton.children (Feliz.MaterialUI.Icons.codeIcon [])
                        ]
                    )
                ]

                // GitHub button
                Mui.tooltip [
                    tooltip.title "View the source on GitHub"
                    tooltip.children (
                        Mui.iconButton [
                            prop.href (
                                Constants.SourceRepoDocsAppArticleDirEditUrl + (String.concat "/" path)
                            )
                            iconButton.component' "a"
                            iconButton.color.inherit'
                            iconButton.children (Feliz.MaterialUI.Icons.gitHubIcon [])
                        ]
                    )
                ]
            ]
        ]

        // Code
        Mui.collapse [
            collapse.in' isExpanded
            collapse.sx [
                style.display.block;
                style.inner ("&" + MuiClasses.collapse.wrapperInner) [
                    style.backgroundColor bgColor
                ]
            ]
            collapse.children [
                Markdown.markdown [
                    //prop.className c.codePanel
                    markdown.source markdownCodeBlock
                    markdown.escapeHtml false
                    markdown.renderers [
                        markdown.renderers.code (fun props -> CommonViews.Code props.language props.value)
                    ]
                ]
            ]
        ]

        //Mui.expansionPanel [
        //  prop.className c.codePanel
        //  expansionPanel.expanded isExpanded
        //  expansionPanel.onChange setIsExpanded
        //  expansionPanel.children [
        //    Mui.expansionPanelSummary [
        //      expansionPanelSummary.expandIcon (expandMoreIcon [])
        //      expansionPanelSummary.children [
        //        Mui.typography (if isExpanded then "Hide code" else "Show code")

        //      ]
        //    ]
        //    Mui.expansionPanelDetails [

        //    ]
        //  ]
        //]

        ]


[<ReactComponent>]
let SampleViewer path =
    let state, dispatch = React.useElmish((init path), update, [| !!path |])

    match state with
    | Initial -> Html.none
    | Loading ->
        React.fragment [
            Mui.skeleton [
                skeleton.variant.rectangular
                skeleton.height 400
            ]
        ]
    | Loaded (Ok (getSample, codeBlock, path)) ->
        Demo getSample codeBlock path

    | Loaded (Error errorMsg) ->
        Mui.typography [
            typography.sx (fun t -> [ style.color t.palette.error.main ])
            typography.paragraph true
            typography.children errorMsg
        ]
