# Feliz.MaterialUI

[Feliz](https://github.com/Zaid-Ajaj/Feliz)-style Fable bindings for [Material-UI](https://material-ui.com/).

Current status
--------------

Feliz.MaterialUI is highly usable, but since we’re at `0.x` breaking changes (small or large) may happen at any time. While at `0.x` I will try to increment the minor version for breaking changes and the patch version for anything else. Note that in this context, changes to components from `@material-ui/lab` will never be considered breaking.

Feedback welcome!
-----------------

This project is still rather new. If you have suggestions for API improvements, please open an issue!

## Installation

Install the bindings:

- using dotnet: `dotnet add package Feliz.MaterialUI`
- using paket: `paket add Feliz.MaterialUI`

Install the required npm packages:

* using [Femto](https://github.com/Zaid-Ajaj/Femto) (preferred): `femto --resolve`
* using npm: `npm install @material-ui/core @material-ui/lab`
* using yarn: `yarn add @material-ui/core @material-ui/lab`

If not using Femto, you must manually check that the npm package versions are supported by Feliz.MaterialUI. You can find the currently supported versions in the `<NpmDependencies> ` node in [Feliz.MaterialUI.fsproj](https://github.com/cmeeren/Feliz.MaterialUI/blob/master/src/Feliz.MaterialUI/Feliz.MaterialUI.fsproj).

Remember to re-run `femto --resolve` (or manually check the supported package versions) each time you update Feliz.MaterialUI.

## Usage

Everything is available under the `Feliz.MaterialUI` namespace.

### Components/props

All components are available under `Mui`. Props are component-specific, and are available under the component name. For props that aren’t defined by Material-UI you simply use `prop` from Feliz.

```f#
let view model dispatch =
  Mui.textField [
    prop.className "myInput"
    textField.variant.filled
    textField.label "Input"
    textField.value model.SimpleText
    textField.onChange (SetSimpleText >> dispatch)
    textField.helperText ["Current value: "; model.SimpleText]
  ]
```

For convenience, when a “child” component forwards unknown props to a root/“parent” component, the props of the “parent” component are also available directly on the “child” component. For example, `appBar` forwards props to `paper`, so all of the `paper` props such as `elevation` are available directly on `appBar`:

```f#
Mui.appBar [
  appBar.elevation 16  // Forwarded to paper
  appBar.children [ ... ]
]
```

When a component supports children, the component function also has an overload that takes a list of children instead of a list of props:

```f#
Mui.paper [
  // Direct list of children, not props
  Mui.typography ...
  Mui.button ...
]

// The above is equivalent to this
Mui.paper [
  paper.children [
    Mui.typography ...
    Mui.button ...
  ]
]
```

Certain components also have other convenience overloads if you don’t need props. For example, `typography` has an overload accepting a string:

```f#
Mui.typography "Some text"

// The above is equivalent to this
Mui.typography [ prop.children (Html.text "Some text") ]
```

### Classes

Material-UI allows you to [override styles for elements inside components](https://material-ui.com/customization/components/#overriding-styles-with-classes) using the `classes` prop, allowing you to “piggyback” on existing Material-UI class names by injecting custom class names alongside them. The Feliz.MaterialUI API places all of the components’ classes under the `classes` type and looks like this:

```f#
Mui.appBar [
  appBar.classes [
    classes.appBar.positionFixed "myAppBarPositionFixed"
    classes.appBar.positionAbsolute "myAppBarPositionAbsolute"
    classes.appBar.colorDefault "myAppBarColorDefault"
  ]
]
```

### Styling using `makeStyles`

The `makeStyles` hook allows simple and powerful styling. Here is an example of Feliz.MaterialUI usage:

```f#
// Styles.makeStyles has several overloads; this is a common one
let useStyles : MyProps -> _ = Styles.makeStyles(fun theme ->
  // You return an anonymous record where each member is a list of styles
  {|
  	// You must wrap the list of styles in Styles.create
    drawer = Styles.create [
      style.width (length.px 240)
      style.flexShrink 0
    ]
    
    // Styles.create also has an overload allowing interpolated styles
    root = Styles.create (fun myProps -> [
      style.display.flex
      style.userSelect.none
      if myProps.Page = Home then style.color Colors.green.``300``
    ])
    
    drawerPaper = Styles.create [
      style.width (length.px 240)
      // You can use style.inner to create any nested style object.
      // Here is an example using breakpoint media queries from the theme:
      style.inner theme.breakpoints.downXs [
        style.backgroundColor.red
      ]
    ]
    
    toolbar = Styles.create [
      // The toolbar mixin is used like this
      yield! theme.mixins.toolbarStyles
    ]
  |}
)

let view props =
  // You call useStyles with the props used for interpolation (use () if you don't use interpolation)
  let c = useStyles props
  Mui.drawer [
    // Now you can use the props like normal (string) props
    prop.className c.drawer
    drawer.classes [
      classes.drawer.paper c.drawerPaper
    ]
    drawer.children [
      Html.div [ prop.className c.toolbar ]
      Mui.list [ ... ]
    ]
  ]
```

### Styling by creating a theme

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

### Other hooks

The [`useMediaQuery` hook](https://material-ui.com/components/use-media-query/) is available as `Hooks.useMediaQuery`.

Changelog
---------

### 0.8.0

* Regenerated based on MUI API docs
* Breaking: `buttonRef` props removed (no longer exist in docs)
* Breaking: `muiThemeProvider` is now `themeProvider` ([#27](https://github.com/cmeeren/Feliz.MaterialUI/issues/27))
* Updated for @material-ui/lab 4.0.0-alpha.30 (new autocomplete component)

### 0.7.2

* Added warning to `@material-ui/lab` component docs

### 0.7.1

* Updated Feliz dependency

### 0.7.0

* Regenerated based on updated MUI docs

### 0.6.0

* Changed some `slider.marks` signatures
* Allow any sequence for props, not just `list`
* Some internal optimizations

### 0.5.0

* Disabled Feliz native DOM prop inheritance (seemingly broken due to F# compiler limitations, see [#20 (comment)](https://github.com/cmeeren/Feliz.MaterialUI/issues/20#issuecomment-540747363)). Inheritance within MUI props are now based on simply duplicating inherited props for child components, and Feliz’s `prop` must be used for non-MUI props.
* Improved `popover.anchorOrigin` and `popover.transformOrigin`
* Added `seq<ReactElement>` overload to all components that support it

### 0.4.01

* Added prop inheritance
* Updated Feliz dependency to 0.57

### 0.3.1

- Updated Feliz dependency and pinned the version to avoid breaking 0.x changes

### 0.3.0

* Support for Material-UI 4.5

### 0.2.0-alpha

* Regenerated bindings based on updated MUI docs

### 0.1.0-alpha

- Initial alpha release

## Contributing

TODO

Dev/deployment checklist
------------------------

1. Make necessary changes to the code (e.g., run the generator)
   * Remember to always update the Feliz dependency as long as it’s at 0.x
2. Update the changelog
3. Update the version and release notes in the package info
4. Update the supported npm dependency versions for femto in the fsproj
5. Commit and tag the commit (this is what triggers deployment from  AppVeyor). For consistency, the tag should be identical to the version (e.g. `1.2.3`).
6. Push the changes and the tag to the repo. If AppVeyor build succeeds, the package is automatically published to NuGet.