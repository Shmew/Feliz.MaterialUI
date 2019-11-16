# Feliz.MaterialUI

[Feliz](https://github.com/Zaid-Ajaj/Feliz)-style Fable bindings for [Material-UI](https://material-ui.com/).

Documentation 
--------------

https://cmeeren.github.io/Feliz.MaterialUI/

Contributing
------------

This project uses `fake`, `paket`, and `femto` as .NET Core 3 local tools. Therefore, run `dotnet tool restore` to restore the necessary CLI tools before doing anything else. 

### Regular maintenance

1. Check for the latest versions of `@material-ui/core` and `@material-ui/lab`, and update the Femto versions in `Feliz.MaterialUI.fsproj` correspondingly
2. Run the `RegularMaintenance` target, which will update all packages and regenerate the bindings based on the live MUI docs
3. Check all changes to Feliz.MaterialUI and adjust the generator’s API parser as needed. Remember to check all doc comment updates too, since changes there may indicate that something must be changed elsewhere. Run the `RegenerateFromCache` (or run the generator project in VS) target to re-generate based on the recently downloaded HTML pages.
4. Update `Feliz.MaterialUI.fsproj` with a new version number and release notes
5. Update the changelog
6. Update relevant docs (typically in `docs-app/public/pages`, potentially also by adding menu items in `App.fs`)
7. Commit and tag the commit (this is what triggers deployment from  AppVeyor). For consistency, the tag should be identical to the version (e.g. `1.2.3`).
8. Push the changes and the tag to the repo. If AppVeyor build succeeds, the package is automatically published to NuGet.
9. Publish the docs by running the `Docs:Publish` target

Changelog
---------

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
