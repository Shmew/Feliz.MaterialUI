# The sx prop

MUI allows you to override component styles using [the `sx` prop](https://mui.com/system/getting-started/the-sx-prop/). Feliz.MaterialUI API tries to follow the original API, so for the details about the `sx` prop it is recommeded to look into [the official MUI documentation](https://mui.com/system/getting-started/the-sx-prop/).

For example, `sx` prop could take plain styles, just like vanilla `style` prop:

```fsharp
Mui.typography [
    typography.sx ([
        style.color "inherit"
        style.flexGrow 1
    ])
    // other typography props
]
```

It is possible to override styles for the inner elements (named "slots") of the component via their CSS classes and even use parameters of the current theme passing callback (that has Theme object as a parameter):

```fsharp
Mui.listItem [
    listItem.sx (fun (t: Theme) -> [
        style.innerSlot MuiClasses.listItem.root
            [style.paddingLeft (t.spacing 4)]
    ])
  // other listItem props
]
```

`style.innerSlot MuiClasses.listItem.root` used above is just a shorthand for `style.inner ("&" + MuiClasses.listItem.root)`. So if you want set some state, like `hover`, you can easily achieve that via string concat or interpolation: `style.innerSlot $"{MuiClasses.listItem.root}:hover"`.

Among other `sx` prop overloads, provided by Feliz.MaterialUI, there is a special one for MUI breakpoints:

```fsharp
Mui.drawer [
    drawer.sx (
        xs = [
            style.display.block
            style.innerSlot MuiClasses.drawer.paper [
                style.width (length.px 240)
                style.boxSizing.borderBox
            ]
        ]
    )
    // other drawer props
]
```
