namespace Feliz.MaterialUI.X

open Fable.Core

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

