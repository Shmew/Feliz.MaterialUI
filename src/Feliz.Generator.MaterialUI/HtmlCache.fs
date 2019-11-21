module HtmlCache

open System
open System.IO
open System.Net.Http
open FSharp.Data

let baseUrl = "https://material-ui.com"
let apiFolder = @"..\..\..\cache\Api"

let private downloadUrl (url: string) =
  async {
    Console.WriteLine(sprintf "Downloading %s" url)
    use client = new HttpClient()
    let! html = client.GetStringAsync(url) |> Async.AwaitTask
    let name =
      url.Split("/", StringSplitOptions.RemoveEmptyEntries)
      |> Array.last
    let filename = sprintf @"%s\%s.html" apiFolder name
    do! File.WriteAllTextAsync(filename, html, Text.Encoding.UTF8) |> Async.AwaitTask
  }

let refresh =
  async {
    let! testPage = ComponentApiPage.AsyncLoad(baseUrl + "/api/app-bar")

    let apiPageUrls =
      testPage.Html.CssSelect("nav ul li").[2].CssSelect("ul li")
      |> List.map (fun menuItem ->
        let relUrl = menuItem.CssSelect("a").[0].AttributeValue("href")
        baseUrl + relUrl
      )

    do!
      apiPageUrls
      |> List.map downloadUrl
      |> Async.Parallel
      |> Async.Ignore
  }

let getFiles () =
  Directory.GetFiles(apiFolder, "*.html")
  |> Array.sortBy (fun s -> s.Substring(0, s.LastIndexOf ".").Replace("-", ""))
