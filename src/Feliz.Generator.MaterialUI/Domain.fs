module Domain

open Feliz.Generator


type ClassRule = {
  DocLines: string list
  MethodName: string
  RealRuleName: string
}


type MuiComponent = { 
  GeneratorComponent: Component
  ClassRules: ClassRule list
  ComponentName: string option
}


type MuiComponentApi = { 
  GeneratorComponentApi: ComponentApi
  MuiComponents: MuiComponent list
}


type Locale = {
  Name: string
  ImportName: string
}


type Localization = {
  Locales: Locale list
}
