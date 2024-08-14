module Program

open System.IO
open Feliz.Generator

let (</>) path1 path2 = Path.Combine(path1, path2)

let writeMuiComponentsApiFiles
    (additionalOpens: string list)
    (directoryPath: string)
    (api: Domain.MuiComponentApi) =
    File.WriteAllText(directoryPath </> "MuiComponents.fs", Render.componentImportsDocument api)
    File.WriteAllText(directoryPath </> "Mui.fs", Render.componentDocument additionalOpens api.GeneratorComponentApi)
    File.WriteAllText(directoryPath </> "Props.fs", Render.propsDocument api.GeneratorComponentApi)
    File.WriteAllText(directoryPath </> "ClassNames.fs", Render.classesGlobalNamesDocument additionalOpens api)
    File.WriteAllText(directoryPath </> "ClassesProps.fs", Render.classesPropsDocument additionalOpens api)
    File.WriteAllText(directoryPath </> "ThemeProps.fs", Render.themePropsDocument additionalOpens api)
    File.WriteAllText(directoryPath </> "ThemeOverrides.fs", Render.themeOverridesDocument additionalOpens api)

[<EntryPoint>]
let main argv =
    if argv |> Array.contains "--refresh" then
        HtmlCache.refresh |> Async.RunSynchronously
    
    let api = ApiParser.parseApi ()
    do api |> writeMuiComponentsApiFiles [] @"../../../../Feliz.MaterialUI"

    let datePickersCommunityApi = ApiParser.parseDatePickersApi false
    do datePickersCommunityApi
        |> writeMuiComponentsApiFiles ["open Feliz.MaterialUI"] @"../../../../Feliz.MuiX.DatePickers"

    let datePickersProApi = ApiParser.parseDatePickersApi true
    do datePickersProApi
        |> writeMuiComponentsApiFiles ["open Feliz.MaterialUI"] @"../../../../Feliz.MuiX.DatePickersPro"

    let localization = LocalizationParser.parse ()
    File.WriteAllText(@"../../../../Feliz.MaterialUI/Localization.fs", Render.localizationDocument localization)

    let icons = MaterialIconsParser.parseIcons()
    File.WriteAllText(@"../../../../Feliz.MaterialUI.Icons/MaterialIcons.fs", Render.materialIconsDocument icons)
    0
