namespace Feliz.MaterialUI.X

open System
open Fable.Core
open Fable.Core.JS


type [<StringEnum>] [<RequireQualifiedAccess>] CalendarPickerView =
    | Year
    | Day
    | Month

type [<StringEnum>] [<RequireQualifiedAccess>] ClockPickerView =
    | Hours
    | Minutes
    | Seconds

type CalendarOrClockPickerView =
    U2<CalendarPickerView, ClockPickerView>
