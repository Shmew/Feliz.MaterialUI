# Feliz.MaterialUI

[Feliz](https://github.com/Zaid-Ajaj/Feliz)-style Fable bindings for [Material-UI](https://material-ui.com/).

Documentation
--------------

https://cmeeren.github.io/Feliz.MaterialUI/

Contributing
------------

This project uses `fake`, `paket`, and `femto` as .NET Core 3 local tools. Therefore, run `dotnet tool restore` to restore the necessary CLI tools before doing anything else.

To run targets using Fake: `dotnet fake build -t TargetName`

### Regular maintenance

1. Run the `RegularMaintenance` target, which will update all packages as well as the Femto metadata in `Feliz.MaterialUI.fsproj`, and regenerate the bindings based on the live MUI docs
2. Check all changes to Feliz.MaterialUI and adjust the generator’s API parser as needed. Remember to check all doc comment updates too, since changes there may indicate that something must be changed elsewhere. Run the `RegenerateFromCache` target (or run the generator project in VS) to re-generate based on the recently downloaded HTML pages.
3. Update `Feliz.MaterialUI.fsproj` with a new version number and release notes
4. Update the changelog
5. Update relevant docs/samples (typically in `docs-app/public/pages`, potentially also by adding menu items in `App.fs`)
6. Run the `CiBuild` target to check that everything compiles
7. Run the `Docs:Run` target to verify that the docs are still working
8. Commit and tag the commit (this is what triggers deployment from  AppVeyor). For consistency, the tag should be identical to the version (e.g. `1.2.3`).
9. Push the changes and the tag to the repo. If AppVeyor build succeeds, the package is automatically published to NuGet.
10. Publish the docs by running the `Docs:Publish` target

Changelog
---------

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
