module Program

open System.IO
open Feliz.Generator


[<EntryPoint>]
let main argv =
//  if argv |> Array.contains "--refresh" then
  HtmlCache.refresh
  |> Async.RunSynchronously

  let api = ApiParser.parseApi ()
  File.WriteAllText(@"../../../../Feliz.MaterialUI/Mui.fs", Render.componentDocument api.GeneratorComponentApi)
  File.WriteAllText(@"../../../../Feliz.MaterialUI/Props.fs", Render.propsDocument api.GeneratorComponentApi)
  File.WriteAllText(@"../../../../Feliz.MaterialUI/Classes.fs", Render.classesDocument api)
  File.WriteAllText(@"../../../../Feliz.MaterialUI/ThemeProps.fs", Render.themePropsDocument api)
  File.WriteAllText(@"../../../../Feliz.MaterialUI/ThemeOverrides.fs", Render.themeOverridesDocument api)

  let localization = LocalizationParser.parse ()
  File.WriteAllText(@"../../../../Feliz.MaterialUI/Localization.fs", Render.localizationDocument localization)

  0
