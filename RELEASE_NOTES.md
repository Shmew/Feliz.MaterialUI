Changelog
=========
### 5.11.0-beta.3 (2023-06-21)
* Fix [issue #5](https://github.com/ArtemyB/Feliz.MaterialUI/issues/5).

### 5.11.0-beta.2 (2023-03-01)
* Update to Feliz >= 2 (and Fable.React >= 9).
* Update `react` NPM-package to v18, add `use-sync-external-store` NPM-package (required by `Feliz.UseElmish v2+`).
* Regenerate bindings for MUI v5.11.

### 5.10.0-alpha.6 (2023-02-15)
* Add `anchorPosition` prop (of `Popover` and `Menu`) overload with `float` parameters.

### 5.10.0-alpha.5 (2023-02-15)
* Fix `CreateFilterOptionsOptions` type definition (used for `Autocomplete` MUI component) to address recent FCS updates that makes the old definition incompilable (e.g. by Fable v4.0.0-theta-018).

### 5.10.0-alpha.4 (2022-10-31)

* Fixed Grid v2 component import.
* Corrected ThemeProvider component import (to import it from "@mui/material" instead of from "@mui/material/styles").
* Removed StylesProvider component (for being obsolete in MUI 5).
* Couple of minor code fixes to make the library compile with Fable 4.0.0-theta-014.

### 5.10.0-alpha.3 (2022-10-03)

* Fixed `componentsProps` prop bindings.
* Added `MuiComponents` module, containing raw imports for all the components (typed as `ReactElementType`).
* Added `style.innerSlot` helper, corrected return type of `style.muiBreakpoints` helper.

### 5.10.0-alpha.0 (2022-09-26)

* Updated for MUI v5 with corresponding API design changes (to reflect JS/TS MUI v5 API better).
* Added separate packages for icons (@mui/icons-material), MUI-X DatePickers Community and Pro (@mui/x-date-pickers and @mui/x-date-pickers-pro).
* Added new doc type signatures parsing and translation mechanism based on FParsec.

### 1.3.0 (2022-01-22)

* Updated for @material-ui/core 4.12 and @material-ui/lab 4.0.0-alpha.60
* Added special cases for `imageList`'s broken documentation
* Fixed markdown to docs to look for the correct markdown

### 1.2.6 (2021-02-09)

* Make some props accept subtypes of `Element` without requiring explicit casts ([#69](https://github.com/cmeeren/Feliz.MaterialUI/issues/69))

### 1.2.5 (2021-01-08)

* Fix problem with `int []` props such as `tablePagination.rowsPerPageOptions` ([#66](https://github.com/cmeeren/Feliz.MaterialUI/issues/66))

### 1.2.4

* Better support for Fable 3 ([#64](https://github.com/cmeeren/Feliz.MaterialUI/pull/64), thanks to [@alfonsogarciacaro](alfonsogarciacaro))

### 1.2.3

* Support FSharp.Core 5

### 1.2.2

* Added workaround for regression in Fable 3 ([#58](https://github.com/cmeeren/Feliz.MaterialUI/pull/58), thanks to [@inosik](https://github.com/inosik))

### 1.2.1

* Fixed the signature of `theme.overrides.muiCssBaseline.global'`

### 1.2.0

* Added the `stylesProvider` component

### 1.1.0

* Updated for @material-ui/core 4.11 and @material-ui/lab 4.0.0-alpha.56
* Breaking: `type'` prop removed from `buttonBase` and all inheriting components; use `prop.type'` from Feliz instead
* Component documentation now lists any required props

### 1.0.1

* Loosened FSharp.Core version requirements

### 1.0.0

* Updated for Feliz 1.1, @material-ui/core 4.9.14, and @material-ui/lab 4.0.0-alpha.53

### 0.15.0

* Updated from fixed MUI docs and for @material-ui/lab 4.0.0-alpha.49
* Breaking: `timeout` and `transitionDuration` props have had their optional argument list extended at the beginning. If you have used positional arguments instead of named arguments, you must change your code to use named arguments.

### 0.14.0

* Updated for @material-ui/lab 4.0.0-alpha.46

### 0.13.1

* Add support for localization
* Update from MUI docs

### 0.13.0

* Flattened the `classes` props, see updated docs

### 0.12.0

* Updated for @material-ui/core 4.9 and @material-ui/lab 4.0.0-alpha.41
* Add missing theme DSL props `shape`, `transitions`, and `zIndex`
* Fix name collisions in theme DSL
* Removed invalid `theme.typography.srOnly` from theme DSL

### 0.11.0

* Switched to custom unflatten implementation to avoid problems (see [#39](https://github.com/cmeeren/Feliz.MaterialUI/issues/39) and [hughsk/flat#94](https://github.com/hughsk/flat/issues/94))
- As a consequence of the above, removed (the read-only) `Theme.props` and `Theme.overrides`

### 0.10.1

* Fixed higher-arity `theme.spacing` overloads

### 0.10.0

* Breaking: New DSL for creating themes; properties on the `Theme` type and related types are now read-only. See [the updated theme docs](https://cmeeren.github.io/Feliz.MaterialUI/#usage/themes) for details.
* Breaking: Slight change to `makeStyles`. The required signature for your style function is now `fun styles theme -> {| ... |}` and you use the passed-in `styles.create` instead of the static `Styles.create`, which has been removed. This improves type safety for interpolated styles. See [the updated makeStyles docs](https://cmeeren.github.io/Feliz.MaterialUI/#usage/styling) for details.

### 0.9.0

* Breaking: `snackbarContent.role` is now a normal `string` property (not enum property) as per updated MUI docs
* Updated for @material-ui/lab 4.0.0-alpha.39
* Updated doc comments from MUI docs
* Added `float` overloads to relevant `rating` props

### 0.8.4

* Updated for @material-ui/core 4.8 and @material-ui/lab 4.0.0-alpha.36

### 0.8.3

* Update for @material-ui/lab 4.0.0-alpha.32

### 0.8.2

* Regenerated based on MUI API docs
* Fixed `themeProvider` import

### 0.8.0

* Regenerated based on MUI API docs
* Breaking: `buttonRef` props removed (no longer exist in MUI API docs)
* Breaking: `muiThemeProvider` is now `themeProvider` ([#27](https://github.com/cmeeren/Feliz.MaterialUI/issues/27))
* Updated for @material-ui/core 4.6
* Updated for @material-ui/lab 4.0.0-alpha.30 (new autocomplete component)

### 0.7.2

* Added warning to `@material-ui/lab` component docs

### 0.7.1

* Updated Feliz dependency

### 0.7.0

* Regenerated based on updated MUI docs

### 0.6.0

* Changed some `slider.marks` signatures
* Allow any sequence for props, not just `list`
* Some internal optimizations

### 0.5.0

* Disabled Feliz native DOM prop inheritance (seemingly broken due to F# compiler limitations, see [#20 (comment)](https://github.com/cmeeren/Feliz.MaterialUI/issues/20#issuecomment-540747363)). Inheritance within MUI props are now based on simply duplicating inherited props for child components, and Feliz’s `prop` must be used for non-MUI props.
* Improved `popover.anchorOrigin` and `popover.transformOrigin`
* Added `seq<ReactElement>` overload to all components that support it

### 0.4.01

* Added prop inheritance
* Updated Feliz dependency to 0.57

### 0.3.1

- Updated Feliz dependency and pinned the version to avoid breaking 0.x changes

### 0.3.0

* Support for Material-UI 4.5

### 0.2.0-alpha

* Regenerated bindings based on updated MUI docs

### 0.1.0-alpha

- Initial alpha release
