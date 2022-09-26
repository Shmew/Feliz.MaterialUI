open System
open System.Text.Json
open Fake.Core
open Fake.Core.Xml
open Fake.DotNet
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.IO.FileSystemOperators

let execContext = Context.FakeExecutionContext.Create false "build.fsx" [ ]
Context.setExecutionContext (Context.RuntimeContext.Fake execContext)

let getExitCode (res: ProcessResult) = res.ExitCode

let failIfNonZero (exitCode: int) =
    if exitCode <> 0 then
        failwithf "Failed with exit code %i" exitCode

module NpmPackages =

    let [<Literal>] muiMaterial = "@mui/material"
    let [<Literal>] muiLab = "@mui/lab"
    let [<Literal>] muiIconsMaterial = "@mui/icons-material"
    let [<Literal>] muiXDatePickers = "@mui/x-date-pickers"
    let [<Literal>] muiXDatePickersPro = "@mui/x-date-pickers-pro"


let root = __SOURCE_DIRECTORY__ </> ".."

let slnPath = root </> "Feliz.MaterialUI.sln"

let srcPath = root </> "src"


let muiGeneratorProjDirPath = srcPath </> "Feliz.Generator.MaterialUI"

let muiGeneratorReleaseAppPath = muiGeneratorProjDirPath </> "bin" </> "Release" </> "net6.0"


let docsAppDirPath = root </> "docs-app"

let docsAppSrcDirPath = docsAppDirPath </> "src"


let muiLibProjectPath = srcPath </> "Feliz.MaterialUI" </> "Feliz.MaterialUI.fsproj"
let muiIconsLibProjectPath = srcPath </> "Feliz.MaterialUI.Icons" </> "Feliz.MaterialUI.Icons.fsproj"
let muiXDatePickersProjPath = srcPath </> "Feliz.MuiX.DatePickers" </> "Feliz.MuiX.DatePickers.fsproj"
let muiXDatePickersProProjPath = srcPath </> "Feliz.MuiX.DatePickersPro" </> "Feliz.MuiX.DatePickersPro.fsproj"


let DotnetExecFromRoot command args =
    DotNet.exec (fun c -> { c with WorkingDirectory = root }) command args


Target.create "Clean" (fun _ ->
    !! $"{root}/**/bin"
    ++ $"{root}/**/obj"
    ++ $"{root}/**/dist"
    ++ $"{root}/**/deploy"
    ++ $"{root}/**/*.fable"
    -- $"{root}/**/node_modules/**"
    |> Shell.cleanDirs)

Target.create "DotNetRestore" (fun _ -> DotNet.restore id slnPath)

Target.create "Build" (fun _ ->
    DotNet.build (fun c -> { c with Configuration = DotNet.BuildConfiguration.Release }) slnPath)

Target.create "RegenerateFromLive" (fun _ ->
    DotNet.exec
        // Set working directory to output directory to get same paths as when running in VS
        (fun c -> { c with WorkingDirectory = muiGeneratorReleaseAppPath })
        "run"
        "--project ../../.. -- --refresh"
    |> getExitCode
    |> failIfNonZero)

Target.create "RegenerateFromCache" (fun _ ->
    DotNet.exec
        // Set working directory to output directory to get same paths as when running in VS
        (fun c -> { c with WorkingDirectory = muiGeneratorReleaseAppPath })
        "run"
        "--project ../../.."
    |> getExitCode
    |> failIfNonZero)

Target.create "Pack" (fun _ ->
    DotnetExecFromRoot "paket" "pack dist"
    |> getExitCode
    |> failIfNonZero)

Target.create "Docs:NpmInstall" (fun _ ->
    Pnpm.install (fun c -> { c with WorkingDirectory = docsAppDirPath }))

Target.create "Docs:Run" (fun _ ->
    Pnpm.exec "start" (fun c -> { c with WorkingDirectory = docsAppDirPath }))

Target.create "Docs:Build" (fun _ ->
    Pnpm.run "build" (fun c -> { c with WorkingDirectory = docsAppDirPath }))

Target.create "Docs:Publish" (fun _ ->
    Shell.Exec("node", "publish.js", docsAppDirPath)
    |> failIfNonZero)

Target.create "UpdatePackages" (fun _ ->
    DotnetExecFromRoot "paket" "update"
    |> getExitCode
    |> failIfNonZero

    Pnpm.exec "up" (fun c -> { c with WorkingDirectory = docsAppDirPath })

    DotnetExecFromRoot "femto" $"--resolve {docsAppSrcDirPath}"
    |> getExitCode
    |> failIfNonZero)

Target.create "UpdateFemtoVersionMetadata" (fun _ ->
    let npm = ProcessUtils.findFilesOnPath "npm" |> Seq.head

    let getLatestNpmPackageStableVersion (packageName: string) =
        CreateProcess.fromRawCommand
            npm
            [ "show"
              packageName
              "versions"
              "--json" ]
        |> CreateProcess.withWorkingDirectory docsAppDirPath
        |> CreateProcess.redirectOutput
        |> Proc.run
        |> fun r -> r.Result.Output
        |> fun s ->
            printfn "%s" s
            s
        |> JsonSerializer.Deserialize<seq<string>>
        |> Seq.map SemVer.parse
        |> Seq.filter (fun v -> v.PreRelease.IsNone)
        |> Seq.last

    let latestCoreStableVersion =
        NpmPackages.muiMaterial |> getLatestNpmPackageStableVersion

    let latestLabVersion =
        CreateProcess.fromRawCommand
            npm
            [ "show"
              NpmPackages.muiLab
              "version" ]
        |> CreateProcess.withWorkingDirectory docsAppDirPath
        |> CreateProcess.redirectOutput
        |> Proc.run
        |> fun r -> r.Result.Output
        |> SemVer.parse

    let latestIconsStableVersion =
        NpmPackages.muiIconsMaterial |> getLatestNpmPackageStableVersion

    let latestDatePickersStableVersion =
        NpmPackages.muiXDatePickers |> getLatestNpmPackageStableVersion

    let latestDatePickersProStableVersion =
        NpmPackages.muiXDatePickersPro |> getLatestNpmPackageStableVersion

    let muiV = latestCoreStableVersion
    let iconsV = latestIconsStableVersion
    let datepickersV = latestDatePickersStableVersion
    let datepickersProV = latestDatePickersProStableVersion

    poke
        muiLibProjectPath
        $"//NpmPackage[@Name='{NpmPackages.muiMaterial}']/@Version"
        (sprintf "gte %i.%i lt %i" muiV.Major muiV.Minor (muiV.Major + 1u))

    poke
        muiLibProjectPath
        $"//NpmPackage[@Name='{NpmPackages.muiLab}']/@Version"
        latestLabVersion.AsString

    poke
        muiIconsLibProjectPath
        $"//NpmPackage[@Name='{NpmPackages.muiIconsMaterial}']/@Version"
        (sprintf "gte %i.%i lt %i" iconsV.Major iconsV.Minor (iconsV.Major + 1u))

    poke
        muiXDatePickersProjPath
        $"//NpmPackage[@Name='{NpmPackages.muiXDatePickers}']/@Version"
        (sprintf "gte %i.%i lt %i" datepickersV.Major datepickersV.Minor (datepickersV.Major + 1u))

    poke
        muiXDatePickersProProjPath
        $"//NpmPackage[@Name='{NpmPackages.muiXDatePickersPro}']/@Version"
        (sprintf "gte %i.%i lt %i" datepickersProV.Major datepickersProV.Minor (datepickersProV.Major + 1u))
)


Target.create "RegularMaintenance" ignore

Target.create "CiBuild" ignore


open Fake.Core.TargetOperators

let dependencies = [
    "Clean" ==> "DotNetRestore" ==> "Build" ==> "Pack"

    "Build" ==> "RegenerateFromLive"

    "Build" ==> "RegenerateFromCache"

    "Build" ==> "Pack"

    "UpdateFemtoVersionMetadata"
        ==> "UpdatePackages"
        ==> "RegenerateFromLive"
        ==> "RegularMaintenance"

    "DotNetRestore" ==> "Docs:Run"

    "Docs:NpmInstall" ==> "Docs:Run"

    "DotNetRestore" ==> "Docs:Build"

    "Docs:NpmInstall" ==> "Docs:Build"

    "Build" ==> "Docs:Build"

    "Docs:Build" ==> "Docs:Publish"

    "Pack" ==> "CiBuild"

    "Docs:Build" ==> "CiBuild"
]


[<EntryPoint>]
let main args =
    try
        match args with
        | [| target |] -> Target.runOrDefault target
        | _ -> Target.runOrDefault "CiBuild"
        0
    with e ->
        printfn "%A" e
        1
