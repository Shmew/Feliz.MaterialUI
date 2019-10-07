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
  StylesheetName: string option
}


type MuiComponentApi = { 
  GeneratorComponentApi: ComponentApi
  MuiComponents: MuiComponent list
}
