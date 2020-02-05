module App

open Fable.Core.JsInterop
open Fable.React
open Fable.MaterialUI.Icons
open Fable.MaterialUI.MaterialDesignIcons
open Feliz
open Feliz.MaterialUI
open Feliz.Router
open MarkdonViewer


[<RequireQualifiedAccess>]
module Url =

  let [<Literal>] pages = "pages"
  let [<Literal>] usage = "usage"
  let [<Literal>] ecosystem = "ecosystem"
  let [<Literal>] components = "components"
  let [<Literal>] installation = "installation"
  let [<Literal>] components_props = "components-props"
  let [<Literal>] classes = "classes"
  let [<Literal>] styling = "styling"
  let [<Literal>] themes = "themes"
  let [<Literal>] hooks = "hooks"
  let [<Literal>] autocomplete = "autocomplete"
  let [<Literal>] samples = "samples"
  let [<Literal>] signIn = "sign-in"
  let [<Literal>] indexMd = "index.md"


type ThemeMode =
  | Light
  | Dark


type Model = {
  CurrentPath: string list
  CustomThemeMode: ThemeMode option
}


type Msg =
  | SetPath of string list
  | ToggleCustomThemeMode


let init () = {
  CurrentPath = []
  CustomThemeMode = None
}


let update (msg: Msg) (m: Model) =
  match msg with
  | SetPath segments ->
      { m with CurrentPath = segments }
  | ToggleCustomThemeMode ->
      { m with
          CustomThemeMode =
            match m.CustomThemeMode with
            | None -> Some Dark
            | Some Dark -> Some Light
            | Some Light -> None
      }


let private useStyles = Styles.makeStyles(fun styles theme ->
  let drawerWidth = 240
  {|
    root = styles.create [
      style.display.flex
    ]
    appBar = styles.create [
      style.zIndex (theme.zIndex.drawer + 1)
    ]
    appBarTitle = styles.create [
      style.flexGrow 1
    ]
    drawer = styles.create [
      style.width (length.px drawerWidth)
      style.flexShrink 0  // TODO: Does this do anything?
    ]
    drawerPaper = styles.create [
      style.width (length.px drawerWidth)
    ]
    content = styles.create [
      style.width 0  // TODO: is there a better way to prevent long code boxes extending past the screen?
      style.flexGrow 1
      style.padding (theme.spacing 3)
    ]
    nestedMenuItem = styles.create [
      style.paddingLeft (theme.spacing 4)
    ]
    toolbar = styles.create [
      yield! theme.mixins.toolbar
    ]
  |}
)


module Theme =

  let defaultTheme = Styles.createMuiTheme()

  let light = Styles.createMuiTheme([
    theme.palette.type'.light
    theme.palette.primary Colors.indigo
    theme.palette.secondary Colors.pink
    theme.palette.background.default' "#fff"
    theme.typography.h1.fontSize "3rem"
    theme.typography.h2.fontSize "2rem"
    theme.typography.h3.fontSize "1.5rem"
  ])

  let dark = Styles.createMuiTheme([
    theme.palette.type'.dark
    theme.palette.primary Colors.lightBlue
    theme.palette.secondary Colors.pink
    theme.palette.background.default' defaultTheme.palette.grey.``900``
    theme.typography.h1.fontSize "3rem"
    theme.typography.h2.fontSize "2rem"
    theme.typography.h3.fontSize "1.5rem"

    theme.overrides.muiAppBar.colorDefault [
      style.backgroundColor defaultTheme.palette.grey.A400
    ]
    theme.overrides.muiPaper.root [
      style.backgroundColor defaultTheme.palette.grey.A400
    ]
    theme.overrides.muiDrawer.paper [
      style.backgroundColor defaultTheme.palette.grey.``900``
    ]

    theme.props.muiAppBar [
      appBar.color.default'
    ]
  ])


let toolbar model dispatch =
  let c = useStyles ()
  Mui.toolbar [
    Mui.typography [
      typography.variant.h6
      typography.color.inherit'
      typography.children "Feliz.MaterialUI"
      typography.classes.root c.appBarTitle
    ]

    // Light/dark mode button
    Mui.tooltip [
      tooltip.title(
        match model.CustomThemeMode with
        | None -> "Using system light/dark theme"
        | Some Light -> "Using light theme"
        | Some Dark -> "Using dark theme"
      )
      tooltip.children(
        Mui.iconButton [
          prop.onClick (fun _ -> dispatch ToggleCustomThemeMode)
          iconButton.color.inherit'
          iconButton.children [
            match model.CustomThemeMode with
            | None -> brightnessAutoIcon []
            | Some Light -> brightness7Icon []
            | Some Dark -> brightness4Icon []
          ]
        ]
      )
    ]

    // GitHub button
    Mui.tooltip [
      tooltip.title "Feliz.MaterialUI on GitHub"
      tooltip.children(
        Mui.iconButton [
          prop.href "https://github.com/cmeeren/Feliz.MaterialUI"
          iconButton.component' "a"
          iconButton.color.inherit'
          iconButton.children (gitHubIcon [])
        ]
      )
    ]
  ]


let menuContainer = React.functionComponent(fun (name: string, pathPrefix: string, currentPath: string list, children: seq<ReactElement>) ->
  let isInPath =
    match currentPath with
    | hd::_ when hd = pathPrefix -> true
    | _ -> false
  let isOpen, setIsOpen = React.useState true
  React.fragment [
    Mui.listItem [
      prop.onClick (fun _ -> setIsOpen (not isOpen))
      listItem.button true
      listItem.children [
        Mui.listItemText name
      ]
    ]
    Mui.collapse [
      collapse.in' (isInPath || isOpen)
      collapse.children [
        Mui.list [
          list.disablePadding true
          list.children children
        ]
      ]
    ]
  ]
)


let drawer model dispatch =
  let c = useStyles ()

  let menuItem isNested (name: string) path =
    let fragment = "#" + (path |> String.concat "/")
    Mui.listItem [
      prop.key fragment
      prop.href fragment
      if isNested then
        listItem.classes.root c.nestedMenuItem
      listItem.button true
      listItem.component' "a"
      listItem.selected ((model.CurrentPath = path))
      listItem.children [
        Mui.listItemText name
      ]
    ]

  Mui.drawer [
    drawer.classes.root c.drawer
    drawer.variant.permanent
    drawer.classes.paper c.drawerPaper
    drawer.children [
      Html.div [ prop.className c.toolbar ]
      Mui.list [
        list.component' "nav"
        list.children [
          menuItem false "Home" []
          menuContainer ("Usage", Url.usage, model.CurrentPath, [
            menuItem true "Installation" [Url.usage; Url.installation]
            menuItem true "Components/props" [Url.usage; Url.components_props]
            menuItem true "Classes" [Url.usage; Url.classes]
            menuItem true "Styling using makeStyles" [Url.usage; Url.styling]
            menuItem true "Styling using themes" [Url.usage; Url.themes]
            menuItem true "Other hooks" [Url.usage; Url.hooks]
          ])
          menuItem false "Ecosystem" [Url.ecosystem]
          menuContainer ("Components", Url.components, model.CurrentPath, [
            menuItem true "Autocomplete" [Url.components; Url.autocomplete]
          ])
          menuContainer ("Samples", Url.samples, model.CurrentPath, [
            menuItem true "Sign-in" [Url.samples; Url.signIn]
          ])
        ]
      ]
    ]
  ]


let App = FunctionComponent.Of((fun (model, dispatch) ->
  let isDarkMode = Hooks.useMediaQuery "@media (prefers-color-scheme: dark)"
  let systemThemeMode = if isDarkMode then Dark else Light
  let c = useStyles ()
  Router.router [
    Router.onUrlChanged (SetPath >> dispatch)
    Router.application [
      Mui.themeProvider [
        themeProvider.theme (
          match model.CustomThemeMode |> Option.defaultValue systemThemeMode with
          | Dark -> Theme.dark
          | Light -> Theme.light
        )
        themeProvider.children [
          Mui.cssBaseline []
          Html.div [
            prop.className c.root
            prop.children [
              Mui.cssBaseline []
              Mui.appBar [
                appBar.classes.root c.appBar
                appBar.position.fixed'
                appBar.children [
                  toolbar model dispatch
                ]
              ]
              drawer model dispatch
              Html.main [
                prop.className c.content
                prop.children [
                  Html.div [ prop.className c.toolbar ]
                  markdownViewer {| path = (Url.pages :: model.CurrentPath @ [Url.indexMd]) |}
                ]
              ]
            ]
          ]
        ]
      ]
    ]
  ]
), "App", memoEqualsButFunctions)

let view model dispatch =
  App (model, dispatch)
