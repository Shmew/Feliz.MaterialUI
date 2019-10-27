# Feliz.MaterialUI

[Feliz](https://github.com/Zaid-Ajaj/Feliz)-style Fable bindings for [Material-UI](https://material-ui.com/).

Current status
--------------

Highly usable, but since we’re at `0.x` breaking changes (minor or major) may happen at any time.

## Installation

Install the bindings:

- using dotnet: `dotnet add package Feliz.MaterialUI`
- using paket: `paket add Feliz.MaterialUI`

Install the required npm packages:

* using [Femto](https://github.com/Zaid-Ajaj/Femto): `femto --resolve`
* using npm: `npm install @material-ui/core @material-ui/lab`
* using yarn: `yarn add @material-ui/core @material-ui/lab`

## Usage

TODO

Changelog
---------

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

### 0.4.0

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

## Contributing

TODO

Dev/deployment checklist
------------------------

1. Make necessary changes to the code (e.g., run the generator)
   * Remember to always update the Feliz dependency as long as it’s at 0.x
2. Update the changelog
3. Update the version and release notes in the package info
4. Update the supported npm dependency versions for femto in the fsproj
5. Commit and tag the commit (this is what triggers deployment from  AppVeyor). For consistency, the tag should be identical to the version (e.g. `1.2.3`).
6. Push the changes and the tag to the repo. If AppVeyor build succeeds, the package is automatically published to NuGet.