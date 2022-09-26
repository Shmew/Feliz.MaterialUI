module Feliz.MaterialUI.X.MuiClasses

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Feliz
open Feliz.MaterialUI

type [<Erase>] calendarPicker =

  /// Styles applied to the root element.
  static member inline root : string = ".MuiCalendarPicker-root"
  /// Styles applied to the transition group element.
  static member inline viewTransitionContainer : string = ".MuiCalendarPicker-viewTransitionContainer"


type [<Erase>] calendarPickerSkeleton =

  /// Styles applied to the root element.
  static member inline root : string = ".MuiCalendarPickerSkeleton-root"
  /// Styles applied to the week element.
  static member inline week : string = ".MuiCalendarPickerSkeleton-week"
  /// Styles applied to the day element.
  static member inline daySkeleton : string = ".MuiCalendarPickerSkeleton-daySkeleton"


type [<Erase>] clockPicker =

  /// Styles applied to the root element.
  static member inline root : string = ".MuiClockPicker-root"
  /// Styles applied to the arrowSwitcher element.
  static member inline arrowSwitcher : string = ".MuiClockPicker-arrowSwitcher"


type [<Erase>] dateRangePickerDay =

  /// Styles applied to the root element.
  static member inline root : string = ".MuiDateRangePickerDay-root"
  /// Styles applied to the root element if `isHighlighting=true` and `outsideCurrentMonth=false`.
  static member inline rangeIntervalDayHighlight : string = ".MuiDateRangePickerDay-rangeIntervalDayHighlight"
  /// Styles applied to the root element if `isStartOfHighlighting=true` or `day` is the start of the month.
  static member inline rangeIntervalDayHighlightStart : string = ".MuiDateRangePickerDay-rangeIntervalDayHighlightStart"
  /// Styles applied to the root element if `isEndOfHighlighting=true` or `day` is the end of the month.
  static member inline rangeIntervalDayHighlightEnd : string = ".MuiDateRangePickerDay-rangeIntervalDayHighlightEnd"
  /// Styles applied to the preview element.
  static member inline rangeIntervalPreview : string = ".MuiDateRangePickerDay-rangeIntervalPreview"
  /// Styles applied to the root element if `isPreviewing=true` and `outsideCurrentMonth=false`.
  static member inline rangeIntervalDayPreview : string = ".MuiDateRangePickerDay-rangeIntervalDayPreview"
  /// Styles applied to the root element if `isStartOfPreviewing=true` or `day` is the start of the month.
  static member inline rangeIntervalDayPreviewStart : string = ".MuiDateRangePickerDay-rangeIntervalDayPreviewStart"
  /// Styles applied to the root element if `isEndOfPreviewing=true` or `day` is the end of the month.
  static member inline rangeIntervalDayPreviewEnd : string = ".MuiDateRangePickerDay-rangeIntervalDayPreviewEnd"
  /// Styles applied to the day element.
  static member inline day : string = ".MuiDateRangePickerDay-day"
  /// Styles applied to the day element if `isHighlighting=false`.
  static member inline dayOutsideRangeInterval : string = ".MuiDateRangePickerDay-dayOutsideRangeInterval"
  /// Styles applied to the day element if `selected=false` and `isHighlighting=true`.
  static member inline dayInsideRangeInterval : string = ".MuiDateRangePickerDay-dayInsideRangeInterval"
  /// Styles applied to the day element if `selected=false`.
  static member inline notSelectedDate : string = ".MuiDateRangePickerDay-notSelectedDate"


type [<Erase>] monthPicker =

  /// Styles applied to the root element.
  static member inline root : string = ".MuiMonthPicker-root"


type [<Erase>] pickersDay =

  /// Styles applied to the root element.
  static member inline root : string = ".MuiPickersDay-root"
  /// Styles applied to the root element if `disableMargin=false`.
  static member inline dayWithMargin : string = ".MuiPickersDay-dayWithMargin"
  /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=true`.
  static member inline dayOutsideMonth : string = ".MuiPickersDay-dayOutsideMonth"
  /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=false`.
  static member inline hiddenDaySpacingFiller : string = ".MuiPickersDay-hiddenDaySpacingFiller"
  /// Styles applied to the root element if `disableHighlightToday=false` and `today=true`.
  static member inline today : string = ".MuiPickersDay-today"
  /// State class applied to the root element if `selected=true`.
  static member inline selected : string = ".Mui-selected"
  /// State class applied to the root element if `disabled=true`.
  static member inline disabled : string = ".Mui-disabled"


type [<Erase>] yearPicker =

  /// Styles applied to the root element.
  static member inline root : string = ".MuiYearPicker-root"

