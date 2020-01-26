module Samples.Samples.SignIn.SignIn

open System
open System.Text.RegularExpressions
open Elmish
open Fable.MaterialUI.Icons
open Feliz
open Feliz.ElmishComponents
open Feliz.MaterialUI


[<AutoOpen>]
module Domain =


  type ValidEmail = private ValidEmail of string with
    static member Create s =
      if s = "" then
        Error "Required"
      elif not <| Regex.IsMatch(s, "\w+@\w+\.\w+") then
        Error "Enter a valid email address"
      else
        ValidEmail s |> Ok

  type ValidPassword = private ValidPassword of string with
    static member Create s =
      if s = "" then Error "Required" else ValidPassword s |> Ok


  type SubmitData = {
    Email: ValidEmail
    Password: ValidPassword
    RememberMe: bool
  }
    


type Model =
  { EmailAddress: string
    ValidateEmailAddress: bool
    Password: string
    ValidatePassword: bool
    RememberMe: bool
    IsBusy: bool }



type Msg =
  | SetEmailAddress of string
  | EnableValidateEmailAddress
  | SetPassword of string
  | EnableValidatePassword
  | SetRememberMe of bool
  | SubmitInvalid
  | SubmitValid of SubmitData
  | SignInCompleted


let init =
  { EmailAddress = ""
    ValidateEmailAddress = false
    Password = ""
    ValidatePassword = false
    RememberMe = false
    IsBusy = false }


let update msg m =
  match msg with
  | SetEmailAddress s -> { m with EmailAddress = s }, Cmd.none
  | EnableValidateEmailAddress -> { m with ValidateEmailAddress = true }, Cmd.none
  | SetPassword s -> { m with Password = s }, Cmd.none
  | EnableValidatePassword -> { m with ValidatePassword = true }, Cmd.none
  | SetRememberMe b -> { m with RememberMe = b }, Cmd.none
  | SubmitInvalid -> { m with ValidateEmailAddress = true; ValidatePassword = true }, Cmd.none
  | SubmitValid _ when m.IsBusy -> m, Cmd.none
  | SubmitValid data ->
      let signIn =
        async {
          do! Async.Sleep 1000
          return SignInCompleted
        }
      { m with IsBusy = true }, Cmd.OfAsync.result signIn
  | SignInCompleted -> { m with IsBusy = false }, Cmd.none


let useStyles = Styles.makeStyles(fun styles theme ->
  {|
    paper = styles.create [
      style.marginTop (theme.spacing 8)
      style.display.flex
      style.flexDirection.column
      style.alignItems.center
    ]
    progressBar = styles.create [
      style.margin (theme.spacing 1)
    ]
    avatar = styles.create [
      style.margin (theme.spacing 1)
      style.backgroundColor theme.palette.primary.main
    ]
    form = styles.create [
      style.width (length.perc 100)  // Allegedly fixes an IE 11 issue
      style.marginTop (theme.spacing 1)
    ]
    submit = styles.create [
      style.margin (theme.spacing(3, 0, 2))
    ]
  |}
)

let app = React.functionComponent(fun (model, dispatch) ->
  let classes = useStyles ()
  Mui.container [
    container.component' "main"
    container.maxWidth.xs
    container.children [
      Html.div [
        prop.className classes.paper
        prop.children [
          if model.IsBusy then
            Mui.circularProgress [
              prop.className classes.progressBar
              circularProgress.color.secondary
            ]
          else
            Mui.avatar [
              prop.className classes.avatar
              avatar.children [
                lockOutlinedIcon []
              ]
            ]
                
          Mui.typography [
            typography.component' "h1"
            typography.variant.h5
            typography.children "Sign in"
          ]
          Html.form [
            prop.className classes.form
            prop.children [
              Mui.textField [
                textField.value model.EmailAddress
                textField.onChange (SetEmailAddress >> dispatch)
                textField.variant.outlined
                textField.margin.normal
                textField.required true
                textField.fullWidth true
                textField.id "email"
                textField.label "Email Address"
                textField.name "email"
                textField.autoComplete "email"
                textField.autoFocus true
                prop.onBlur (fun _ -> dispatch EnableValidateEmailAddress)

                match model.ValidateEmailAddress, ValidEmail.Create model.EmailAddress with
                | false, _ | true, Ok _ -> ()
                | true, Error err ->
                    textField.error true
                    textField.helperText err
              ]
              Mui.textField [
                textField.value model.Password
                textField.onChange (SetPassword >> dispatch)
                textField.variant.outlined
                textField.margin.normal
                textField.required true
                textField.fullWidth true
                textField.id "password"
                textField.label "Password"
                textField.name "password"
                textField.type' "password"
                textField.autoComplete "current-password"
                prop.onBlur (fun _ -> dispatch EnableValidatePassword)

                match model.ValidatePassword, ValidPassword.Create model.Password with
                | false, _ | true, Ok _ -> ()
                | true, Error err ->
                    textField.error true
                    textField.helperText err
              ]
              Mui.formControlLabel [
                formControlLabel.label "Remember me"
                formControlLabel.control (
                  Mui.checkbox [
                    checkbox.checked' model.RememberMe
                    checkbox.onChange (SetRememberMe >> dispatch)
                    checkbox.value "remember"
                    checkbox.color.primary
                  ]
                )
              ]
              Mui.button [
                button.type'.submit
                button.fullWidth true
                button.variant.contained
                button.color.primary
                prop.className classes.submit
                button.children "Sign In"
                button.disabled model.IsBusy
                prop.onClick (fun e ->
                  e.preventDefault ()
                  match ValidEmail.Create model.EmailAddress, ValidPassword.Create model.Password with
                  | Ok e, Ok p -> SubmitValid { Email = e; Password = p; RememberMe = model.RememberMe } |> dispatch
                  | _ -> dispatch SubmitInvalid
                )
              ]
              Mui.grid [
                grid.container true
                grid.children [
                  Mui.grid [
                    grid.item true
                    grid.xs.true'
                    grid.children [
                      Mui.link [
                        prop.href "#"
                        link.variant "body2"
                        link.children "Forgot password?"
                        prop.onClick (fun e -> e.preventDefault ())  // to avoid reloading the demo
                      ]
                    ]
                  ]
                  Mui.grid [
                    grid.item true
                    grid.children [
                      Mui.link [
                        prop.href "#"
                        link.variant "body2"
                        link.children "Don't have an account? Sign Up"
                        prop.onClick (fun e -> e.preventDefault ())  // to avoid reloading the demo
                      ]
                    ]
                  ]
                ]
              ]
            ]
          ]
        ]
      ]
    ]
  ]
)


let render model dispatch =
  app (model, dispatch)


let getSample (key: string) =
  React.elmishComponent("SignIn", init, update, render, key)
