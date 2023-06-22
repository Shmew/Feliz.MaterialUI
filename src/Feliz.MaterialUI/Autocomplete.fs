namespace Feliz.MaterialUI

open System
open System.ComponentModel
open Fable.Core.JsInterop

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module AutocompleteHelpers =

    [<EditorBrowsable(EditorBrowsableState.Never)>]
    let createFilterOptions
        (config: CreateFilterOptionsOptions<'Option>)
        : Func<'Option [], AutocompleteFilterOptionsState, 'Option []> =
        import "createFilterOptions" "@mui/material/Autocomplete"

type Autocomplete =

    static member inline createFilterOptions<'Option>
        (
            ?ignoreAccents: bool,
            ?ignoreCase: bool,
            ?matchFrom: AutocompleteMatchFrom,
            ?stringify: 'Option -> string,
            ?trim: bool
        ) : 'Option [] -> AutocompleteFilterOptionsState -> 'Option [] =
        let opts =
            jsOptions<CreateFilterOptionsOptions<'Option>> (fun o ->
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
