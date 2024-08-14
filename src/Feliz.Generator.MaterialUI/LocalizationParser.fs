module LocalizationParser

open System
open Domain

let parse () =

    Console.WriteLine("Processing localization")
    let page = LocalizationPage.Load(HtmlCache.localizationFile)

    let locales =
        page.Tables.``Supported locales``.Rows
        |> Array.map (fun r ->
            { Name = r.Locale
              ImportName = r.``Import name`` })
        |> Array.toList

    { Locales = locales }
