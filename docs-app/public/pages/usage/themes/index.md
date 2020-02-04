# Styling by creating a theme

You use `Styles.createMuiTheme` to create a theme. The DSL for creating a theme is similar to the normal Feliz element/prop syntax, except that everything is flattened (except props and overrides, which have one level of nesting where you specify the props/styles as usual).

```f#
let defaultTheme = Styles.createMuiTheme()


let lightTheme = Styles.createMuiTheme([
  theme.palette.type'.light
  theme.palette.primary Colors.indigo
  theme.palette.secondary Colors.pink
  // Note that to avoid name collisions, the deepest palette props have
  // an extra ' in their parent names
  theme.palette.error'.main "#f00"
  theme.palette.background.default' "#fff"
  theme.typography.h1.fontSize "3rem"
  theme.typography.h2.fontSize "2rem"
  theme.typography.h3.fontSize "1.5rem"
])


let darkTheme = Styles.createMuiTheme([
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
```

Setting the theme using `themeProvider`
---------------------------------------

Simply use the desired theme directly as the argument to `themeProvider.theme`, as shown in the MUI docs:

```f#
let App = FunctionComponent.Of((fun (model, dispatch) ->
  let isDarkMode = Hooks.useMediaQuery "@media (prefers-color-scheme: dark)"
  Mui.themeProvider [
    themeProvider.theme (if isDarkMode then darkTheme else lightTheme)
    themeProvider.children [
      // ...
    ]
  ]
```

Extending an existing theme using `themeProvider`
-------------------------------------------------

The `themeProvider` component can be used to extend the existing theme. Use the `themeProvider.theme` overload accepting a `Theme -> Theme` argument (note that you can’t call the argument `theme` because it will shadow the `theme` module, which is the theme DSL entry point):

```f#
Mui.themeProvider [
  themeProvider.theme (fun existingTheme ->
    Styles.createMuiTheme([  // Create a new theme
      yield! existingTheme.asPropArray  // Insert all the existing theme props
      theme.palette.primary Colors.orange  // Override any theme props above
    ])
  )
  themeProvider.children [
    // ...
  ]
]
```

Note that, [as mentioned in the MUI docs](https://material-ui.com/customization/theming/#a-note-on-performance), extending the theme this way carries a performance penalty.
