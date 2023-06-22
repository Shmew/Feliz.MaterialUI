module MaterialIconsParser

open System
open System.IO
open FSharp.Data
open Domain

let parseIcons () =
    printfn "Processing Material Icons"

    let nodeModulesPath = @"../../../../../docs-app/node_modules"
    let iconsDirPath = nodeModulesPath + @"/@mui/icons-material"
    let iconTitles =
        Directory.GetFiles(iconsDirPath, "*.d.ts")
        |> Array.choose (fun f ->
            if Path.GetFileName(f) = "index.d.ts"
            then None
            else
                let fname = Path.GetFileName f
                fname.Split(".d.ts") |> Array.tryHead)

    iconTitles

    //let page = MaterialIconsPage.Load(HtmlCache.materialIconsFile)

    //let iconsCatalogDiv = page.Html.CssSelect("div[id|=\"demo\"] > div > div > div").Head

    //let iconSvgs = page.Html.CssSelect("#main-content > div > div > div > div > div > span > svg")

    //let iconTitles = [
    //    for i in iconSvgs do
    //        let rawTitle = i.AttributeValue("title")

    //        yield rawTitle
    //        yield rawTitle + "Outlined"
    //        yield rawTitle + "Rounded"
    //        yield rawTitle + "TwoTone"
    //        yield rawTitle + "Sharp"
    //]
