﻿module Program

open System.IO
open Feliz.Generator


// TODO: Separate core and lab? Exclude lab?
// TODO: How to hide MuiHelpers?
// TODO: remove "Mui" prefix for ThemeProps and/or ThemeOverrides?


[<EntryPoint>]
let main argv =
  async {
    //do! HtmlCache.refresh
    let api = ApiParser.parseApi ()
    File.WriteAllText(@"..\..\..\..\Feliz.MaterialUI\Mui.fs", Render.componentDocument api.GeneratorComponentApi)
    File.WriteAllText(@"..\..\..\..\Feliz.MaterialUI\Props.fs", Render.propsDocument api.GeneratorComponentApi)
    File.WriteAllText(@"..\..\..\..\Feliz.MaterialUI\Classes.fs", Render.classesDocument api)
    File.WriteAllText(@"..\..\..\..\Feliz.MaterialUI\ThemeProps.fs", Render.themePropsDocument api)
    File.WriteAllText(@"..\..\..\..\Feliz.MaterialUI\ThemeOverrides.fs", Render.themeOverridesDocument api)
    return 0
  }
  |> Async.RunSynchronously