# Components imports

`MuiComponents` module contains raw imports for all the components, returned as `ReactElementType`. These imports could be useful in cases, such as the [`component` prop](https://mui.com/material-ui/guides/composition/#component-prop).

```fsharp
Mui.listItem [
    listItem.component' MuiComponents.link
    listItem.button true
    listItem.children "This is a link"
]
```

# Components CSS global classes

In component customization scenarios, such as overriding nested components styles via [`sx` prop](https://mui.com/material-ui/customization/how-to-customize/#the-sx-prop), it's necessary to know certain components class names. For that purpose Feliz.MaterialUI provides `MuiClasses` module, that contains all documented CSS global class names, e.g.:

```fsharp
MuiClasses.accordion.rounded
// returns string ".MuiAccordion-rounded"
```

All documented CSS global classes you can find in "CSS" section of the corresponding component's "Components API"-page. For example, for the `Accordion` component it is defined here: https://mui.com/material-ui/api/accordion/#css.
