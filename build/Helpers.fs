module [<AutoOpen>] Helpers

open System
open System.IO
open Fake.Core
open Fake.IO
open Fake.JavaScript
open Fake.Testing.Common

module Pnpm =

     /// The Npm parameter type
    type PnpmParams = 
        { Src: string
          PnpmFilePath: string
          WorkingDirectory: string
          Timeout: TimeSpan }

    /// Arguments for the Npm install command
    type InstallArgs =
        | Standard
        | Forced

    /// The list of supported Npm commands.
    type NpmCommand =
        | Install of InstallArgs
        | Run of string
        | RunSilent of string
        | RunTest of string
        | Test
        | Custom of string

    let pnpmFileName =
        ProcessUtils.tryFindFileOnPath "pnpm"
        |> Option.defaultWith (fun () ->
            invalidOp "Couldn't find pnpm in Path"
        )
    
    let defaultPnpmParams : PnpmParams = 
        { Src = ""
          PnpmFilePath = pnpmFileName
          WorkingDirectory = "."
          Timeout = TimeSpan.MaxValue }

    let private parseInstallArgs = function
        | Standard -> ""
        | Forced -> " --force"

    let private parse = function
        | Install installArgs -> sprintf "install %s" (installArgs |> parseInstallArgs)
        | Run str -> sprintf "run %s" str
        | RunSilent str -> sprintf "run --silent %s" str
        | RunTest str -> sprintf "run --silent %s" str
        | Custom str -> str
        | Test -> "test --silent"

     /// Runs the given process and returns the process result.
    let private execute (pnpmParams: PnpmParams) command =
        let mutable result = None
        let pnpmPath = Path.GetFullPath(pnpmParams.PnpmFilePath)
        let args = command |> parse
        try 
            let procResult =
                CreateProcess.fromRawCommand pnpmPath [args]
                |> CreateProcess.withWorkingDirectory pnpmParams.WorkingDirectory
                |> CreateProcess.withTimeout pnpmParams.Timeout
                |> Proc.run

            let exitCode = procResult.ExitCode
            if exitCode <> 0 then result <- Some(sprintf "exit code: %d" exitCode)
        with exn ->
            let mutable message = exn.Message
            if not (isNull exn.InnerException) then message <- message + Environment.NewLine + exn.InnerException.Message
            result <- Some(message)
        match result with
        | None -> ()
        | Some msg ->
            match command with
            | RunTest str -> raise (FailedTestsException("Test(s) Failed"))
            | Test -> raise (FailedTestsException("Test(s) Failed"))
            | _ -> failwith msg

    let private npm setParams = defaultPnpmParams |> setParams |> execute

    let install setParams = npm setParams <| Install Standard 

    let exec command setParams = npm setParams <| Custom command

    let run command setParams = npm setParams <| Run command
