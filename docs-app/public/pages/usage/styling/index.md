# Styling using `makeStyles`

The `makeStyles` hook allows simple and powerful styling. Here is an example of Feliz.MaterialUI usage:

```f#
// Note that useStyles is a function that accepts props and returns
// the record you specify. The props are used for interpolated styles
// (demonstrated below) and you can simply use unit if you don't need it.
// If you don't (yet) use the defined useStyles function, you may need to
// annotate it as below to keep the compiler happy.
let useStyles : MyProps -> _ = Styles.makeStyles(fun styles theme ->
  // You return an anonymous record where each member is a list of styles
  {|
    // You must wrap the list of styles in styles.create
    drawer = styles.create [
      style.width (length.px 240)
      style.flexShrink 0
    ]
    
    // styles.create also has an overload allowing interpolated styles
    root = styles.create (fun myProps -> [
      style.display.flex
      style.userSelect.none
      if myProps.Page = Home then style.color Colors.green.``300``
    ])
    
    drawerPaper = styles.create [
      style.width (length.px 240)
      // You can use style.inner to create any nested style object.
      // Here is an example using breakpoint media queries from the theme:
      style.inner theme.breakpoints.downXs [
        style.backgroundColor.red
      ]
    ]
    
    toolbar = styles.create [
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
