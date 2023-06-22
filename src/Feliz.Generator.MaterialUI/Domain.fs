﻿module Domain

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

type LiteralPropType =
    | StringLiteral of string
    | BoolLiteral of bool
    | IntLiteral of int

type AtomicPropType =
    | Any
    | String
    | Number
    | Integer
    | Bool
    | Date
    | Func
    | Object
    | Element
    | ElementType
    | HTMLElement
    | Node
    | Literal of LiteralPropType
    | OtherType of typeName: string

type PropType =
    | Atomic of AtomicPropType
    | Union of cases: PropType list
    | Object of entries: (string * PropType * bool) list
    | Array of PropType
