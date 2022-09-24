module Domain

open Feliz.Generator


type ClassRule = {
  DocLines: string list
  MethodName: string
  RealRuleName: string
  GlobalClass : string
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

[<RequireQualifiedAccess>]
type PropOverload =
    | Regular of RegularPropOverload
    | Enum of EnumPropOverload

type BreakpointKey = string

type JsParamName = string
type FsParamName = string
type FsExprCode = string

type ParamName = string

type ParamTypeSignature = string

type IsOptional = bool

type FsTypeSignature = string

type TsAtomicType =
    | String
    | Number
    | Bool
    | Func
    | Object
    | Element
    | ElementType
    | StringLiteral of string
    | OtherType of typeName: string

type TsType =
    | Atomic of TsAtomicType
    | Union of cases: TsType list
    | Object of entries: (string * TsType * bool) list
    | Array of TsType
