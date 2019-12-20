#r "paket: groupref FakeBuild //"
#load ".fake/build.fsx/intellisense.fsx"

#if !FAKE
#r "netstandard"
#r "Facades/netstandard" // https://github.com/ionide/ionide-vscode-fsharp/issues/839#issuecomment-396296095
#endif

open System
open System.Text.Json
open Fake.Core
open Fake.Core.TargetOperators
open Fake.Core.Xml
open Fake.DotNet
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.IO.FileSystemOperators
open Fake.JavaScript


let getExitCode (res: ProcessResult) =
  res.ExitCode

let failIfNonZero (exitCode: int) =
  if exitCode <> 0 then failwithf "Failed with exit code %i" exitCode



Target.create "Clean" (fun _ ->
  !! "**/bin"
  ++ "**/obj"
  ++ "**/dist"
  ++ "**/deploy"
  ++ "**/*.fable"
  -- "**/node_modules/**"
  |> Shell.cleanDirs
)

Target.create "DotNetRestore" (fun _ ->
  DotNet. restore id "Feliz.MaterialUI.sln"
)

Target.create "Build" (fun _ ->
  DotNet.build
    (fun c -> { c with Configuration = DotNet.BuildConfiguration.Release })
    "Feliz.MaterialUI.sln"
)

Target.create "RegenerateFromLive" (fun _ ->
  DotNet.exec
    // Set working directory to output directory to get same paths as when running in VS
    (fun c -> { c with WorkingDirectory = "src/Feliz.Generator.MaterialUI/bin/Release/netcoreapp3.0" })
    "run"
    "--project ../../.. -- --refresh"
  |> getExitCode |> failIfNonZero
)

Target.create "RegenerateFromCache" (fun _ ->
  DotNet.exec
    // Set working directory to output directory to get same paths as when running in VS
    (fun c -> { c with WorkingDirectory = "src/Feliz.Generator.MaterialUI/bin/Release/netcoreapp3.0" })
    "run"
    "--project ../../.."
  |> getExitCode |> failIfNonZero
)

Target.create "Pack" (fun _ ->
  DotNet.exec id "paket" "pack dist" |> getExitCode |> failIfNonZero
)

Target.create "Docs:NpmInstall" (fun _ ->
  Npm.install (fun c -> { c with WorkingDirectory = "docs-app" } )
)

Target.create "Docs:Run" (fun _ ->
  Npm.exec "start" (fun c -> { c with WorkingDirectory = "docs-app" } )
)

Target.create "Docs:Build" (fun _ ->
  Npm.run "build" (fun c -> { c with WorkingDirectory = "docs-app" } )
)

Target.create "Docs:Publish" (fun _ ->
  Shell.Exec("node", "publish.js", "docs-app") |> failIfNonZero
)

Target.create "UpdatePackages" (fun _ ->
  DotNet.exec id "paket" "update" |> getExitCode |> failIfNonZero
  Npm.exec "up" (fun c -> { c with WorkingDirectory = "docs-app" } )
  DotNet.exec id "femto" "--resolve docs-app/src" |> getExitCode |> failIfNonZero
)

Target.create "UpdateFemtoVersionMetadata" (fun _ ->
  let npm = ProcessUtils.findFilesOnPath "npm" |> Seq.head
  let latestCoreStableVersion =
    CreateProcess.fromRawCommand npm ["show"; "@material-ui/core"; "versions"; "--json"]
    |> CreateProcess.withWorkingDirectory "docs-app"
    |> CreateProcess.redirectOutput
    |> Proc.run
    |> fun r -> r.Result.Output
    |> fun s -> printfn "%s" s; s
    |> JsonSerializer.Deserialize<seq<string>>
    |> Seq.map SemVer.parse
    |> Seq.filter (fun v -> v.PreRelease.IsNone)
    |> Seq.last

  let latestLabVersion =
    CreateProcess.fromRawCommand npm ["show"; "@material-ui/lab"; "version"]
    |> CreateProcess.withWorkingDirectory "docs-app"
    |> CreateProcess.redirectOutput
    |> Proc.run
    |> fun r -> r.Result.Output
    |> SemVer.parse

  let v = latestCoreStableVersion
  poke
    "src/Feliz.MaterialUI/Feliz.MaterialUI.fsproj"
    "//NpmPackage[@Name='@material-ui/core']/@Version"
    (sprintf "gte %i.%i lt %i" v.Major v.Minor (v.Major + 1u))

  poke
    "src/Feliz.MaterialUI/Feliz.MaterialUI.fsproj"
    "//NpmPackage[@Name='@material-ui/lab']/@Version"
    latestLabVersion.AsString
)

Target.create "RegularMaintenance" ignore

Target.create "CiBuild" ignore

"Clean"
  ==> "DotNetRestore"
  ==> "Build"
  ==> "Pack"

"Build"
  ==> "RegenerateFromLive"

"Build"
  ==> "RegenerateFromCache"

"Build"
  ==> "Pack"

"UpdateFemtoVersionMetadata"
  ==> "UpdatePackages"
  ==> "RegenerateFromLive"
  ==> "RegularMaintenance"

"DotNetRestore"
  ==> "Docs:Run"

"Docs:NpmInstall"
  ==> "Docs:Run"

"DotNetRestore"
  ==> "Docs:Build"

"Docs:NpmInstall"
  ==> "Docs:Build"

"Docs:Build"
  ==> "Docs:Publish"

"Pack"
==> "CiBuild"

"Docs:Build"
==> "CiBuild"

Target.runOrDefault "CiBuild"
