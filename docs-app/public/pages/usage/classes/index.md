# Classes

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
