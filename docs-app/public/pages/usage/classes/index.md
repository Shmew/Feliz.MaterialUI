# Sx-prop and CSS Classes

Material-UI allows you to override component styles using the [`sx` prop](https://mui.com/system/getting-started/the-sx-prop/).

```fsharp
Mui.typography [
    typography.sx ([
        style.color "inherit"
        style.flexGrow 1
    ])
    // other typography props
]
```

It is also possible to override styles for the inner elements of the component via their CSS classes and also use parameters of the current theme:

```fsharp
Mui.listItem [
    listItem.sx (fun (t: Theme) -> [
        style.inner ("&" + listItem.classes.root)
            [style.paddingLeft (t.spacing 4)]
    ])
  // other listItem props
]
```

Feliz.MaterialUI provides different overloads for sx-prop, including the one for MUI breakpoints:
```fsharp
Mui.drawer [
    drawer.sx (
        xs = [
            style.display.block
            style.inner ("&" + drawer.classes.paper) [
                style.width (Constants.drawerWidth)
                style.boxSizing.borderBox
            ]
        ]
    )
    // other drawer props
]
```
