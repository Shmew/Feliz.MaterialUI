# Styling using `makeStyles`

The `makeStyles` hook allows simple and powerful styling. Here is an example of Feliz.MaterialUI usage:

```f#
// Styles.makeStyles has several overloads; this is a common one.
// Note that useStyles is a function that accepts props and returns
// the record you specify. The props are used for interpolated styles
// (demonstrated below) and you can simply use unit if you don't need it.
let useStyles : MyProps -> _ = Styles.makeStyles(fun theme ->
  // You return an anonymous record where each member is a list of styles
  {|
    // You must wrap the list of styles in Styles.create
    drawer = Styles.create [
      style.width (length.px 240)
      style.flexShrink 0
    ]
    
    // Styles.create also has an overload allowing interpolated styles.
    // Note that you generally need to explicitly annotate the props type.
    root = Styles.create (fun (myProps: MyProps) -> [
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
      yield! theme.mixins.toolbar
    ]
  |}
)

let view props =
  // Call useStyles with the correct props (e.g. just () if you don't
  // use interpolated styles)
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
