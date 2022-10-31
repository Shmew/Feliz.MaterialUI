namespace Feliz.MaterialUI

open System
open System.ComponentModel
open Fable.Core.JsInterop

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module AutocompleteHelpers =

    [<EditorBrowsable(EditorBrowsableState.Never)>]
    let createFilterOptions
        (config: CreateFilterOptionsOptions)
        : Func<'option [], AutocompleteFilterOptionsState, 'option []> =
        import "createFilterOptions" "@mui/material/Autocomplete"

type Autocomplete =

    static member inline createFilterOptions<'option>
        (
            ?ignoreAccents: bool,
            ?ignoreCase: bool,
            ?matchFrom: AutocompleteMatchFrom,
            ?stringify: 'option -> string,
            ?trim: bool
        ) : 'option [] -> AutocompleteFilterOptionsState -> 'option [] =
        let opts =
            jsOptions<CreateFilterOptionsOptions> (fun o ->
                if ignoreAccents.IsSome then
                    o.ignoreAccents <- ignoreAccents.Value

                if ignoreCase.IsSome then
                    o.ignoreCase <- ignoreCase.Value

                if matchFrom.IsSome then
                    o.matchFrom <- matchFrom.Value

                if stringify.IsSome then
                    o.stringify <- stringify.Value

                if trim.IsSome then o.trim <- trim.Value)

        let filter = createFilterOptions opts
        fun opts state -> filter.Invoke(opts, state)
