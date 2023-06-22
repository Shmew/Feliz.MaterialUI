namespace Feliz.MaterialUI.X

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.MaterialUI

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module MuiXHelpers =

  open Fable.React

  let reactElement (el: ReactElementType) (props: 'a) : ReactElement =
    import "createElement" "react"

  let reactElementTag (tag: string) (props: 'a) : ReactElement =
    import "createElement" "react"

  let createElement (el: ReactElementType) (properties: IReactProperty seq) : ReactElement =
    reactElement el (!!properties |> Object.fromFlatEntries)

  let createElementTag (tag: string) (properties: IReactProperty seq) : ReactElement =
    reactElementTag tag (!!properties |> Object.fromFlatEntries)

[<Erase>]
type MuiX =

  static member inline calendarPicker props = createElement (import "CalendarPicker" "@mui/x-date-pickers-pro/CalendarPicker") props

  static member inline calendarPickerSkeleton props = createElement (import "CalendarPickerSkeleton" "@mui/x-date-pickers-pro/CalendarPickerSkeleton") props

  static member inline clockPicker props = createElement (import "ClockPicker" "@mui/x-date-pickers-pro/ClockPicker") props

  static member inline datePicker props = createElement (import "DatePicker" "@mui/x-date-pickers-pro/DatePicker") props

  static member inline dateRangePicker props = createElement (import "DateRangePicker" "@mui/x-date-pickers-pro/DateRangePicker") props

  static member inline dateRangePickerDay props = createElement (import "DateRangePickerDay" "@mui/x-date-pickers-pro/DateRangePickerDay") props

  static member inline dateTimePicker props = createElement (import "DateTimePicker" "@mui/x-date-pickers-pro/DateTimePicker") props

  static member inline desktopDatePicker props = createElement (import "DesktopDatePicker" "@mui/x-date-pickers-pro/DesktopDatePicker") props

  static member inline desktopDateRangePicker props = createElement (import "DesktopDateRangePicker" "@mui/x-date-pickers-pro/DesktopDateRangePicker") props

  static member inline desktopDateTimePicker props = createElement (import "DesktopDateTimePicker" "@mui/x-date-pickers-pro/DesktopDateTimePicker") props

  static member inline desktopTimePicker props = createElement (import "DesktopTimePicker" "@mui/x-date-pickers-pro/DesktopTimePicker") props

  static member inline localizationProvider props = createElement (import "LocalizationProvider" "@mui/x-date-pickers-pro/LocalizationProvider") props

  static member inline localizationProvider (children: #seq<ReactElement>) = createElement (import "LocalizationProvider" "@mui/x-date-pickers-pro/LocalizationProvider") [ localizationProvider.children (children :> seq<ReactElement>) ]

  static member inline mobileDatePicker props = createElement (import "MobileDatePicker" "@mui/x-date-pickers-pro/MobileDatePicker") props

  static member inline mobileDateRangePicker props = createElement (import "MobileDateRangePicker" "@mui/x-date-pickers-pro/MobileDateRangePicker") props

  static member inline mobileDateTimePicker props = createElement (import "MobileDateTimePicker" "@mui/x-date-pickers-pro/MobileDateTimePicker") props

  static member inline mobileTimePicker props = createElement (import "MobileTimePicker" "@mui/x-date-pickers-pro/MobileTimePicker") props

  static member inline monthPicker props = createElement (import "MonthPicker" "@mui/x-date-pickers-pro/MonthPicker") props

  static member inline pickersDay props = createElement (import "PickersDay" "@mui/x-date-pickers-pro/PickersDay") props

  static member inline staticDatePicker props = createElement (import "StaticDatePicker" "@mui/x-date-pickers-pro/StaticDatePicker") props

  static member inline staticDateRangePicker props = createElement (import "StaticDateRangePicker" "@mui/x-date-pickers-pro/StaticDateRangePicker") props

  static member inline staticDateTimePicker props = createElement (import "StaticDateTimePicker" "@mui/x-date-pickers-pro/StaticDateTimePicker") props

  static member inline staticTimePicker props = createElement (import "StaticTimePicker" "@mui/x-date-pickers-pro/StaticTimePicker") props

  static member inline timePicker props = createElement (import "TimePicker" "@mui/x-date-pickers-pro/TimePicker") props

  static member inline yearPicker props = createElement (import "YearPicker" "@mui/x-date-pickers-pro/YearPicker") props
