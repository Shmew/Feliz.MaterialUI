# Components/props

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

Names that are reserved F# keywords generally end with a prime/apostrophe (`'`), e.g.:

```f#
Mui.radio [
  radio.checked' true
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
