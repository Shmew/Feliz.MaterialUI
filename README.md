# Feliz.MaterialUI

[Feliz](https://github.com/Zaid-Ajaj/Feliz)-style Fable bindings for [MUI (aka Material-UI)](https://mui.com).

Documentation
--------------

https://artemyb.github.io/Feliz.MaterialUI/

Contributing
------------

This project uses `fable`, `paket` and `femto` as .NET local tools. Therefore, `dotnet tool restore` is needed to work with the project. However `build.cmd` and `build.sh` scripts already include this step.

To run build targets using cmd or Powershell:
```cmd
build.cmd TargetName
```
or using bash:
```bash
build.sh TargetName
```

### Regular maintenance

1. Run the `RegularMaintenance` target, which will update all packages as well as the Femto metadata in `Feliz.MaterialUI.fsproj`, `Feliz.MaterialUI.Icons.fsproj`, `Feliz.MuiX.DatePickers.fsproj` and `Feliz.MuiX.DatePickersPro.fsproj`, and regenerate the bindings based on the live MUI docs.
2. Check all changes to Feliz.MaterialUI and adjust the generator’s API parser as needed. Remember to check all doc comment updates too, since changes there may indicate that something must be changed elsewhere. Run the `RegenerateFromCache` target (or run the generator project in VS) to re-generate based on the recently downloaded HTML pages.
3. Update the version number in `Feliz.MaterialUI.fsproj`, `Feliz.MaterialUI.Icons.fsproj`, `Feliz.MuiX.DatePickers.fsproj` and `Feliz.MuiX.DatePickersPro.fsproj`.
4. Update `RELEASE_NOTES.md`
5. Update relevant docs/samples (typically in `docs-app/public/pages`, potentially also by adding menu items in `App.fs`)
6. Run the `CiBuild` target to check that everything compiles
7. Run the `Docs:Run` target to verify that the docs are still working
8. Commit and tag the commit (this is what triggers deployment from  AppVeyor). For consistency, the tag should be identical to the version (e.g. `1.2.3`).
9. Push the changes and the tag to the repo. If AppVeyor build succeeds, the package is automatically published to NuGet.
10. Publish the docs by running the `Docs:Publish` target.

