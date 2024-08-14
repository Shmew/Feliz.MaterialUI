module Samples.Usage.Localization.Localization

open Elmish
open Feliz
open Feliz.MaterialUI

[<ReactComponent>]
let LocalizationSample (sampleKey: string) =
    Mui.themeProvider [
        // createTheme as used below extends the existing theme, which is necessary due to
        // this documentation's styling solution; there is also a createMuiTheme overload
        // accepting theme props as the first argument as described in the theming
        // documentation.
        themeProvider.theme (fun theme -> Styles.createTheme (theme, Locale.svSE))
        themeProvider.children [
            Mui.container [
                container.maxWidth.xs
                container.children [
                    Mui.tablePagination [
                        tablePagination.count 20
                        tablePagination.rowsPerPage 10
                        tablePagination.page 1
                        tablePagination.component' "div"
                        tablePagination.onPageChange (fun _ -> ())
                    ]
                    Mui.autocomplete [
                        autocomplete.options [||]
                        prop.style [ style.width 300 ]
                        autocomplete.renderInput (fun parameters ->
                            Mui.textField [
                                yield! parameters.felizProps
                                textField.variant.outlined
                                textField.fullWidth true
                            ])
                    ]
                ]
            ]
        ]
    ]
