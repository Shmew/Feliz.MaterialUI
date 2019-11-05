module App

open Fable.React
open Feliz
open Feliz.MaterialUI

type Page =
  | Home
  | Autocomplete
  static member All = [ Home; Autocomplete ]

let pageTitle = function
  | Home -> "Home"
  | Autocomplete -> "Autocomplete"

type Model = {
  Page: Page
  Autocomplete: Autocomplete.Model
}

type Msg =
  | Navigate of Page
  | AutocompleteMsg of Autocomplete.Msg

let init () = {
  Page = Home
  Autocomplete = Autocomplete.init ()
}

let update (msg: Msg) (m: Model) =
  match msg with
  | Navigate page -> { m with Page = page }
  | AutocompleteMsg msg' -> { m with Autocomplete = Autocomplete.update msg' m.Autocomplete }

let private useStyles = Styles.makeStyles(fun theme ->
  let drawerWidth = 240
  {|
    root = Styles.create [
      style.display.flex
    ]
    appBar = Styles.create [
      style.zIndex (theme.zIndex.drawer + 1)
    ]
    drawer = Styles.create [
      style.width (length.px drawerWidth)
      style.flexShrink 0
    ]
    drawerPaper = Styles.create [
      style.width (length.px drawerWidth)
    ]
    content = Styles.create [
      style.flexGrow 1
      style.padding (theme.spacing 3)
    ]
    toolbar = Styles.create [
      yield! theme.mixins.toolbarStyles
    ]
  |}
)

let private theme = Styles.createMuiTheme()

let private pageListItem model dispatch page =
  Mui.listItem [
    prop.key (pageTitle page)
    prop.onClick (fun _ -> Navigate page |> dispatch)
    listItem.button true
    listItem.divider ((page = Home))
    listItem.selected (model.Page = page)
    listItem.children [
      Mui.listItemText (pageTitle page)
    ]
  ]

let private pageView model dispatch =
  match model.Page with
  | Home -> Mui.typography "TODO"
  | Autocomplete -> Autocomplete.AutocompletePage(model.Autocomplete, AutocompleteMsg >> dispatch)


let RootView = FunctionComponent.Of((fun (model, dispatch) ->
  let c = useStyles model
  Mui.themeProvider [
    themeProvider.theme theme
    themeProvider.children [
      Html.div [
        prop.className c.root
        prop.children [
          Mui.cssBaseline []
          Mui.appBar [
            prop.className c.appBar
            appBar.position.fixed'
            appBar.children [
              Mui.toolbar [
                Mui.typography [
                  typography.variant.h6
                  typography.color.inherit'
                  typography.children (pageTitle model.Page)
                ]
              ]
            ]
          ]
          Mui.drawer [
            prop.className c.drawer
            drawer.variant.permanent
            drawer.classes [
              classes.drawer.paper c.drawerPaper
            ]
            drawer.children [
              Html.div [ prop.className c.toolbar ]
              Mui.list [
                list.component' "nav"
                list.children (Page.All |> List.map (pageListItem model dispatch) |> ofList)
              ]
            ]
          ]
          Html.main [
            prop.className c.content
            prop.children [
              Html.div [ prop.className c.toolbar ]
              pageView model dispatch
            ]
          ]
        ]
      ]
    ]
  ]
), "RootView", memoEqualsButFunctions)

let view model dispatch =
  RootView (model, dispatch)
