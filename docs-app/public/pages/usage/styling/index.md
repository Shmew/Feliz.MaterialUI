# Styling

MUI v5 is using [emotion](https://emotion.sh) as styling engine by default. But Feliz.MaterialUI does not contain any bindings to it. Also there aren't any external publicly available Fable-packages for now. Luckily MUI does not impose any serious restrictions on applying different styling solutions. So, for example you can try using Fable-exclusives like [FSS.Feliz](https://bjorn-strom.github.io/FSS/#/page/feliz) or/and [Zanaptak.TypedCssClasses](https://github.com/zanaptak/TypedCssClasses). Or you can simply use plain CSS, [SASS](https://sass-lang.com/), etc.

The official guide on MUI's styling libraries interoperability can be found [here](https://mui.com/material-ui/guides/interoperability/).

## Styling using `makeStyles`

Styling via `makeStyles` hook, that was one of the main means in Material UI v4, became deprecated in MUI v5. Despite being still present in Feliz.MaterialUI library, it hasn't been ported and tested. Techinally this styling method is supported by MUI v5, but with the changes that require proper adoption in Feliz.MaterialUI. The official notes regarding that case could be seen [here](https://mui.com/material-ui/guides/interoperability/#jss-tss).
