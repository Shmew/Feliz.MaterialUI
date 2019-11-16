# Styling by creating a theme

You use `Styles.createMuiTheme` to create a theme. You can then pass the theme to e.g. `Mui.muiThemeProvider`. You use the `overrides` type to specify component style overrides, and the `themeProps` type to specify default component props.

```f#
let theme = Styles.createMuiTheme(jsOptions<Theme>(fun t ->
  t.palette <- jsOptions<Palette>(fun p ->
    p.``type`` <- PaletteType.Dark
    p.primary <- !^Colors.blueGrey
    p.secondary <- !^Colors.purple
  )

  // Globally override component styles
  t.setOverrides [
    overrides.muiButtonBase [
      overrides.muiButtonBase.root [
        style.fontWeight.bold
        style.inner "&$disabled" [
          style.backgroundColor.aquaMarine
        ]
      ]
    ]
    overrides.muiAvatar [
      overrides.muiAvatar.img [
        style.borderWidth 10
        style.borderColor.black
        style.borderStyle.solid
      ]
    ]
  ]

  // Globally override component props
  t.setProps [
    themeProps.muiButton [
      button.size.small
    ]
    themeProps.muiDialog [
      dialog.fullScreen true
    ]
  ]
))
```
