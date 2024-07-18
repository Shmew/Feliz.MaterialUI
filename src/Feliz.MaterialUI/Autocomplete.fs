namespace Feliz.MaterialUI

open System
open System.ComponentModel
open Fable.Core.JsInterop

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module AutocompleteHelpers =

  [<EditorBrowsable(EditorBrowsableState.Never)>]
  let createFilterOptions (config: CreateFilterOptionsOptions<_>) : Func<'option [], AutocompleteFilterOptionsState, 'option []> =
    import "createFilterOptions" "@material-ui/lab/Autocomplete"

type Autocomplete =

  static member createFilterOptions<'option>
      ( ?ignoreAccents: bool,
        ?ignoreCase: bool,
        ?matchFrom: AutocompleteMatchFrom,
        ?stringify: 'option -> string,
        ?trim: bool
      ) : 'option [] -> AutocompleteFilterOptionsState -> 'option []
      =
    let opts = jsOptions<CreateFilterOptionsOptions<_>>(fun o ->
      if ignoreAccents.IsSome then o.ignoreAccents <- ignoreAccents.Value
      if ignoreCase.IsSome then o.ignoreCase <- ignoreCase.Value
      if matchFrom.IsSome then o.matchFrom <- matchFrom.Value
      if stringify.IsSome then o.stringify <- stringify.Value
      if trim.IsSome then o.trim <- trim.Value
    )
    let filter = createFilterOptions opts
    fun opts state -> filter.Invoke(opts, state)
