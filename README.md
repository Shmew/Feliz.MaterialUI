# Feliz.MaterialUI

[Feliz](https://github.com/Zaid-Ajaj/Feliz)-style Fable bindings for [Material-UI](https://material-ui.com/).

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

TODO

## Contributing

TODO

Dev/deployment checklist
------------------------

1. Make necessary changes to the code (e.g., run the generator)
2. Update the changelog
3. Update the version and release notes in the package info
4. Update the supported npm dependency versions for femto in the fsproj
5. Commit and tag the commit (this is what triggers deployment from  AppVeyor). For consistency, the tag should be identical to the version (e.g. `1.2.3`).
6. Push the changes and the tag to the repo. If AppVeyor build succeeds, the package is automatically published to NuGet.