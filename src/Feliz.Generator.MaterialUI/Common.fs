[<AutoOpen>]
module Common

open FSharp.Data
open ReverseMarkdown


type ComponentApiPage = HtmlProvider<"cache/api/app-bar.html">

type LocalizationPage = HtmlProvider<"cache/guides/localization.html">


let kebabCaseToCamelCase (s: string) =
  let pieces = s.Split("-")
  if pieces.Length > 1 then
    pieces |> Array.iteri (fun i piece ->
      if i > 0 then
        pieces.[i] <- piece.Substring(0, 1).ToUpper() + piece.Substring(1)
    )
    pieces |> String.concat ""
  else s


let prefixUnderscoreToNumbers (s: string) =
  if s.Length > 0 && s |> Seq.head |> System.Char.IsNumber
  then "_" + s
  else s


let trimStart (start: char) (str: string) =
  str.TrimStart(start)


let appendApostropheToReservedKeywords =
  let reserved =
    [
      "checked"; "static"; "fixed"; "inline"; "default"; "component";
      "inherit"; "open"; "type"; "true"; "false"; "in"; "end"; "global"
    ]
    |> Set.ofList
  fun s -> if reserved.Contains s then s + "'" else s


let private markdownConverter =
  Converter(
    Config(
      GithubFlavored=true,
      RemoveComments=true,
      SmartHrefHandling=true,
      UnknownTags=Config.UnknownTagsOption.PassThrough
    )
  )


let docElementsToMarkdownLines (nodes: HtmlNode list) =
  (nodes
  |> Seq.map (fun x -> x.ToString().Replace("\r\n", "<br><br>"))
  |> String.concat ""
  |> fun s -> s.Replace("href=\"/", "href=\"https://material-ui.com/")
  |> fun s -> s.Replace("</code><code>", "</code> <code>")
  |> markdownConverter.Convert)
  |> fun s -> System.Text.RegularExpressions.Regex.Replace(s, "\r\n\r\n(\r\n)+", "\r\n\r\n")
  |> String.split "\r\n"
  |> List.trimEmptyLines
  |> List.map String.removeControlCharacters
