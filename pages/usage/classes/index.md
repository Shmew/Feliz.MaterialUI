# Classes

Material-UI allows you to [override styles for elements inside components](https://material-ui.com/customization/components/#overriding-styles-with-classes) using the `classes` prop, allowing you to “piggyback” on existing Material-UI class names by injecting custom class names alongside them. The Feliz.MaterialUI API flattens these props, meaning you use each overridable class as a normal prop:

```f#
Mui.appBar [
  appBar.classes.positionFixed "myAppBarPositionFixed"
  appBar.classes.positionAbsolute "myAppBarPositionAbsolute"
  appBar.classes.colorDefault "myAppBarColorDefault"
  // other appBar props
]
```

Note that for MUI components,  `componentName.classes.root` is the same as  just using `prop.className` from Feliz.
