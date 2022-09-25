module Samples.Samples.DateTimePickers.DateTimePickers

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.DateFunctions
open Feliz
open Feliz.MaterialUI
open Feliz.MaterialUI.X


[<ReactComponent>]
let DateTimePickersSample (key: string) =

    let dtValue, setDtValue = React.useState<DateTime option>(Some DateTime.Now)
    
    MuiX.localizationProvider[
        localizationProvider.dateAdapter.dateFns
        localizationProvider.children [
            Mui.container [
                container.children [
                    MuiX.dateTimePicker [
                        dateTimePicker.ampm false
                        dateTimePicker.inputFormat "dd.MM.yyyy HH:mm"
                        dateTimePicker.onChange (fun dt _ -> setDtValue dt)
                        dateTimePicker.renderInput (fun props -> Mui.textField props)
                        dateTimePicker.value dtValue
                    ]
                ]
            ]
        ]
    ]
