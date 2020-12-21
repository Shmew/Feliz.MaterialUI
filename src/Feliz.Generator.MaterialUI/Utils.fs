[<AutoOpen>]
module Utils

open System.Text.RegularExpressions


let flip f x y = f y x


module String =

  let trim (s: string) =
    s.Trim ()

  /// Converts the first character to lowercase.
  let lowerFirst s =
    if s = "" then "" else s.Substring(0, 1).ToLower() + s.Substring(1)

  /// Converts the first character to lowercase.
  let upperFirst s =
    if s = "" then "" else s.Substring(0, 1).ToUpper() + s.Substring(1)

  /// Splits the string on the specified separator.
  let split (sep: string) (s: string) =
    s.Split(sep) |> Array.toList

  /// Removes invisible control characters, including tabs and newlines.
  let removeControlCharacters =
    // https://stackoverflow.com/a/40568888/2978652
    let r = Regex("\p{Cc}", RegexOptions.Compiled)
    fun (s: string) -> r.Replace(s, "")


module List =

  /// Returns the list after removing the first N elements. If the list has less
  /// than N elements, returns an empty list.
  let trySkip count list =
    if List.length list < count then [] else List.skip count list

  let trimEmptyLines list =
    list
    |> List.skipWhile ((=) "")
    |> List.rev
    |> List.skipWhile ((=) "")
    |> List.rev
