[<AutoOpen>]
module Feliz.Generator.Utils


module String =

  let prefix (prefix: string) s =
    prefix + s

  let trim (s: string) =
    s.Trim()

  let indent spacesPerLevel numLevels =
    prefix (String.replicate (numLevels * spacesPerLevel) " ")


module List =

  let trimEmptyLines list =
    list
    |> List.skipWhile ((=) "")
    |> List.rev
    |> List.skipWhile ((=) "")
    |> List.rev
