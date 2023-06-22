namespace Feliz.MaterialUI.X

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open System.ComponentModel
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.MaterialUI

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module themeOverrides =

  module theme =

    module styleOverrides =

      [<Erase>]
      type muiCalendarPicker =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCalendarPicker", !!values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPicker.styleOverrides.root", createObj !!styles)
        /// Styles applied to the transition group element.
        static member inline viewTransitionContainer(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPicker.styleOverrides.viewTransitionContainer", createObj !!styles)

      [<Erase>]
      type muiCalendarPickerSkeleton =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiCalendarPickerSkeleton", !!values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPickerSkeleton.styleOverrides.root", createObj !!styles)
        /// Styles applied to the week element.
        static member inline week(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPickerSkeleton.styleOverrides.week", createObj !!styles)
        /// Styles applied to the day element.
        static member inline daySkeleton(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiCalendarPickerSkeleton.styleOverrides.daySkeleton", createObj !!styles)

      [<Erase>]
      type muiClockPicker =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiClockPicker", !!values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiClockPicker.styleOverrides.root", createObj !!styles)
        /// Styles applied to the arrowSwitcher element.
        static member inline arrowSwitcher(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiClockPicker.styleOverrides.arrowSwitcher", createObj !!styles)

      [<Erase>]
      type muiDateRangePickerDay =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiDateRangePickerDay", !!values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `isHighlighting=true` and `outsideCurrentMonth=false`.
        static member inline rangeIntervalDayHighlight(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayHighlight", createObj !!styles)
        /// Styles applied to the root element if `isStartOfHighlighting=true` or `day` is the start of the month.
        static member inline rangeIntervalDayHighlightStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayHighlightStart", createObj !!styles)
        /// Styles applied to the root element if `isEndOfHighlighting=true` or `day` is the end of the month.
        static member inline rangeIntervalDayHighlightEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayHighlightEnd", createObj !!styles)
        /// Styles applied to the preview element.
        static member inline rangeIntervalPreview(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalPreview", createObj !!styles)
        /// Styles applied to the root element if `isPreviewing=true` and `outsideCurrentMonth=false`.
        static member inline rangeIntervalDayPreview(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayPreview", createObj !!styles)
        /// Styles applied to the root element if `isStartOfPreviewing=true` or `day` is the start of the month.
        static member inline rangeIntervalDayPreviewStart(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayPreviewStart", createObj !!styles)
        /// Styles applied to the root element if `isEndOfPreviewing=true` or `day` is the end of the month.
        static member inline rangeIntervalDayPreviewEnd(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.rangeIntervalDayPreviewEnd", createObj !!styles)
        /// Styles applied to the day element.
        static member inline day(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.day", createObj !!styles)
        /// Styles applied to the day element if `isHighlighting=false`.
        static member inline dayOutsideRangeInterval(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.dayOutsideRangeInterval", createObj !!styles)
        /// Styles applied to the day element if `selected=false` and `isHighlighting=true`.
        static member inline dayInsideRangeInterval(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.dayInsideRangeInterval", createObj !!styles)
        /// Styles applied to the day element if `selected=false`.
        static member inline notSelectedDate(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiDateRangePickerDay.styleOverrides.notSelectedDate", createObj !!styles)

      [<Erase>]
      type muiMonthPicker =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiMonthPicker", !!values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiMonthPicker.styleOverrides.root", createObj !!styles)

      [<Erase>]
      type muiPickersDay =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiPickersDay", !!values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.root", createObj !!styles)
        /// Styles applied to the root element if `disableMargin=false`.
        static member inline dayWithMargin(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.dayWithMargin", createObj !!styles)
        /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=true`.
        static member inline dayOutsideMonth(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.dayOutsideMonth", createObj !!styles)
        /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=false`.
        static member inline hiddenDaySpacingFiller(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.hiddenDaySpacingFiller", createObj !!styles)
        /// Styles applied to the root element if `disableHighlightToday=false` and `today=true`.
        static member inline today(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.today", createObj !!styles)
        /// State class applied to the root element if `selected=true`.
        static member inline selected(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.selected", createObj !!styles)
        /// State class applied to the root element if `disabled=true`.
        static member inline disabled(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiPickersDay.styleOverrides.disabled", createObj !!styles)

      [<Erase>]
      type muiYearPicker =
        /// Allows to create new variants for Material UI components. These new variants can specify what styles the component should have when that specific variant prop value is applied.
        static member inline variants([<ParamArray>] values: {| props: #seq<IReactProperty>; style: #seq<IStyleAttribute> |} []) : IThemeProp = theme.componentVariants("MuiYearPicker", !!values)
        /// Styles applied to the root element.
        static member inline root(styles: IStyleAttribute list) : IThemeProp = unbox ("components.MuiYearPicker.styleOverrides.root", createObj !!styles)
