module App

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Dom
open Feliz
open Feliz.MaterialUI
open Feliz.Router
open MarkdonViewer

module MuiIcons = Feliz.MaterialUI.Icons

[<RequireQualifiedAccess>]
module Url =

    [<Literal>]
    let pages = "pages"

    [<Literal>]
    let usage = "usage"

    [<Literal>]
    let ecosystem = "ecosystem"

    [<Literal>]
    let components = "components"

    [<Literal>]
    let installation = "installation"

    [<Literal>]
    let components_props = "components-props"

    [<Literal>]
    let classes = "classes"

    [<Literal>]
    let styling = "styling"

    [<Literal>]
    let themes = "themes"

    [<Literal>]
    let localization = "localization"

    [<Literal>]
    let hooks = "hooks"

    [<Literal>]
    let autocomplete = "autocomplete"

    [<Literal>]
    let samples = "samples"

    [<Literal>]
    let signIn = "sign-in"

    [<Literal>]
    let indexMd = "index.md"

    [<Literal>]
    let datePickers = "date-time-pickers"

    [<Literal>]
    let componentsClassesAndImports = "components-classes-and-imports"

    [<Literal>]
    let sxProp = "sx-prop"

type ThemeMode =
    | Light
    | Dark

type Model =
    {
        CurrentPath: string list
        CustomThemeMode: ThemeMode option
    }

type Msg =
    | SetPath of string list
    | ToggleCustomThemeMode

let init (path) =
    {
        CurrentPath = path
        CustomThemeMode = None
    }

let update (msg: Msg) (m: Model) =
    match msg with
    | SetPath segments -> { m with CurrentPath = segments }
    | ToggleCustomThemeMode ->
        { m with
            CustomThemeMode =
                match m.CustomThemeMode with
                | None -> Some Dark
                | Some Dark -> Some Light
                | Some Light -> None
        }

module Constants =
    let [<Literal>] drawerWidth = 300

//let private useStyles =
//    Styles.makeStyles (fun styles theme ->

//        {|
//            root = styles.create [ style.display.flex ]
//            appBar =
//                styles.create [
//                    style.zIndex (theme.zIndex.drawer + 1)
//                ]
//            appBarTitle = styles.create [ style.flexGrow 1 ]
//            drawer =
//                styles.create [
//                    style.width (length.px Constants.drawerWidth)
//                    style.flexShrink 0 // TODO: Does this do anything?
//                ]
//            drawerPaper =
//                styles.create [
//                    style.width (length.px Constants.drawerWidth)
//                ]
//            content =
//                styles.create [
//                    style.width 0 // TODO: is there a better way to prevent long code boxes extending past the screen?
//                    style.flexGrow 1
//                    style.padding (theme.spacing 3)
//                ]
//            nestedMenuItem =
//                styles.create [
//                    style.paddingLeft (theme.spacing 4)
//                ]
//            toolbar =
//                styles.create [
//                    yield! theme.mixins.toolbar
//                ]
//        |})

module Theme =

    let defaultTheme = Styles.createTheme ()

    let light =
        Styles.createTheme (
            [
                theme.palette.mode.light
                theme.palette.primary Colors.indigo
                theme.palette.secondary Colors.pink
                theme.palette.background.default' "#fff"
                theme.typography.h1.fontSize "3rem"
                theme.typography.h2.fontSize "2rem"
                theme.typography.h3.fontSize "1.5rem"
            ]
        )

    let dark =
        Styles.createTheme (
            [
                theme.palette.mode.dark
                theme.palette.primary Colors.lightBlue
                theme.palette.secondary Colors.pink
                theme.palette.background.default' defaultTheme.palette.grey.``900``
                theme.typography.h1.fontSize "3rem"
                theme.typography.h2.fontSize "2rem"
                theme.typography.h3.fontSize "1.5rem"

                theme.styleOverrides.muiAppBar.colorDefault [
                    style.backgroundColor defaultTheme.palette.grey.A700
                ]
                theme.styleOverrides.muiPaper.root [
                    style.backgroundColor defaultTheme.palette.grey.A700
                ]
                theme.styleOverrides.muiDrawer.paper [
                    style.backgroundColor defaultTheme.palette.grey.``900``
                ]

                theme.defaultProps.muiAppBar [
                    appBar.color.default'
                ]
            ]
        )


[<ReactComponent>]
let Toolbar model dispatch =
    //let c = useStyles ()

    Mui.toolbar [
        Mui.typography [
            typography.variant.h6
            typography.sx ([
                style.color "inherit"
                style.flexGrow 1
            ])
            typography.children "Feliz.MaterialUI"
        ]

        // Light/dark mode button
        Mui.tooltip [
            tooltip.title (
                match model.CustomThemeMode with
                | None -> "Using system light/dark theme"
                | Some Light -> "Using light theme"
                | Some Dark -> "Using dark theme"
            )
            tooltip.children (
                Mui.iconButton [
                    prop.onClick (fun _ -> dispatch ToggleCustomThemeMode)
                    iconButton.color.inherit'
                    iconButton.children [
                        match model.CustomThemeMode with
                        | None -> MuiIcons.brightnessAutoIcon []
                        | Some Light -> MuiIcons.brightness7Icon []
                        | Some Dark -> MuiIcons.brightness4Icon []
                    ]
                ]
            )
        ]

        // GitHub button
        Mui.tooltip [
            tooltip.title "Feliz.MaterialUI on GitHub"
            tooltip.children (
                Mui.iconButton [
                    prop.href Constants.SourceRepoUrl
                    iconButton.component' "a"
                    iconButton.color.inherit'
                    iconButton.children (MuiIcons.gitHubIcon [])
                ]
            )
        ]
    ]


[<ReactComponent>]
let MenuContainer (name: string) (pathPrefix: string) (currentPath: string list) (children: seq<ReactElement>) =
    let isInPath =
        match currentPath with
        | hd :: _ when hd = pathPrefix -> true
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


[<ReactComponent>]
let Drawer model dispatch =
    //let c = useStyles ()

    let menuItem isNested (name: string) (path: string list) =
        let fragment = Router.format(path)

        Mui.listItem [
            prop.key fragment
            prop.href fragment
            listItem.sx [|
                if isNested then
                    (fun (t: Theme) -> [
                        style.innerSlot MuiClasses.listItem.root
                            [style.paddingLeft (t.spacing 4)]
                    ])
            |]
            listItem.button true
            listItem.component' "a"
            listItem.selected ((model.CurrentPath = path))
            listItem.children [
                Mui.listItemText [
                    listItemText.inset isNested
                    listItemText.primary name
                    listItemText.primaryTypographyProps [
                        typography.noWrap false
                    ]
                ]
            ]
        ]
    
    Mui.drawer [
        //drawer.classes.root c.drawer
        //drawer.classes.paper c.drawerPaper
        drawer.sx [
            //style.display.block
            style.width Constants.drawerWidth
            style.flexShrink 0
            style.innerSlot MuiClasses.drawer.paper [
                style.width (Constants.drawerWidth)
                style.boxSizing.borderBox
                //style.flexShrink 0 // TODO: Does this do anything?]
            ]
        ]
        drawer.variant.permanent; drawer.open' true
        drawer.children [
            //Html.div [ prop.className c.toolbar ]
            //Mui.box [box.sx (fun t -> t.mixins.toolbar)]
            Mui.toolbar []
            Mui.list [
                list.component' "nav"
                list.children [
                    menuItem false "Home" []
                    (MenuContainer
                        "Usage"
                        Url.usage
                        model.CurrentPath
                        [
                            menuItem true "Installation" [ Url.usage; Url.installation ]
                            menuItem true "Components/props" [ Url.usage; Url.components_props ]
                            menuItem true "Components imports and global CSS classes" [ Url.usage; Url.componentsClassesAndImports]
                            menuItem true "Styling" [ Url.usage; Url.styling ]
                            menuItem true "Styling via the sx prop" [ Url.usage; Url.sxProp ]
                            menuItem true "Styling via classes" [Url.usage; Url.classes]
                            menuItem true "Theming" [ Url.usage; Url.themes ]
                            menuItem true "Localization" [ Url.usage; Url.localization ]
                            menuItem true "Other hooks" [ Url.usage; Url.hooks ]
                        ]
                    )
                    menuItem false "Ecosystem" [ Url.ecosystem ]
                    (MenuContainer
                        "Components"
                        Url.components
                        model.CurrentPath
                        [
                            menuItem true "Autocomplete" [ Url.components; Url.autocomplete ]
                        ]
                    )
                    (MenuContainer
                        "Samples"
                        Url.samples
                        model.CurrentPath
                        [
                            menuItem true "Sign-in" [ Url.samples; Url.signIn ]
                            menuItem true "Date Pickers" [Url.samples; Url.datePickers]
                        ]
                    )
                ]
            ]
        ]
    ]

[<ReactComponent>]
let AppView model dispatch =
    let isDarkMode = Hooks.useMediaQuery "(prefers-color-scheme: dark)"
    let systemThemeMode = if isDarkMode then Dark else Light
    //let c = useStyles ()
    //let t = Styles.useTheme()

    React.router [
        router.onUrlChanged (SetPath >> dispatch)
        router.hashMode
        router.children [
            Mui.themeProvider [
                themeProvider.theme (
                    model.CustomThemeMode
                    |> Option.defaultValue systemThemeMode
                    |> function
                        | Dark ->  Theme.dark
                        | Light -> Theme.light
                )
                themeProvider.children [
                    Mui.box [
                        //prop.className c.root
                        box.sx (fun t -> [
                            style.display.flex
                        ])
                        box.children [
                            Mui.cssBaseline []

                            Mui.appBar [
                                appBar.position.fixed'
                                appBar.sx (fun t -> [
                                    //style.width (length.calc (sprintf "100%% - %ipx" Constants.drawerWidth))
                                    //style.marginLeft (length.px Constants.drawerWidth)
                                    style.zIndex (t.zIndex.drawer + 1)
                                ])
                                appBar.children [
                                    Toolbar model dispatch
                                ]
                            ]
                            
                            Mui.box [
                                box.component' "nav"
                                box.sx [
                                    style.width (length.px Constants.drawerWidth)
                                    style.flexShrink 0
                                ]
                                box.children (Drawer model dispatch)
                            ]

                            Mui.box [
                                box.component' "main"
                                box.sx [
                                    style.flexGrow 1
                                    style.padding 3
                                    style.width (length.calc (sprintf "100%% - %ipx" Constants.drawerWidth))
                                ]
                                //prop.className c.content

                                box.children [
                                    Mui.toolbar []
                                    //Html.div [ prop.className c.toolbar ]
                                    //Mui.box [ box.sx(fun t -> t.mixins.toolbar) ]
                                    MarkdownViewer
                                        (Url.pages :: model.CurrentPath @ [ Url.indexMd ])
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
