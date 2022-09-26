namespace Feliz.MaterialUI.X

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System.ComponentModel
open Fable.Core
open Feliz
open Feliz.MaterialUI

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module classesProps =

  module calendarPickerSkeleton =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the week element.
      static member inline week(className: string) : IReactProperty = unbox ("classes.week", className)
      /// Styles applied to the day element.
      static member inline daySkeleton(className: string) : IReactProperty = unbox ("classes.daySkeleton", className)
  
  
  module clockPicker =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the arrowSwitcher element.
      static member inline arrowSwitcher(className: string) : IReactProperty = unbox ("classes.arrowSwitcher", className)
  
  
  module dateRangePickerDay =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `isHighlighting=true` and `outsideCurrentMonth=false`.
      static member inline rangeIntervalDayHighlight(className: string) : IReactProperty = unbox ("classes.rangeIntervalDayHighlight", className)
      /// Styles applied to the root element if `isStartOfHighlighting=true` or `day` is the start of the month.
      static member inline rangeIntervalDayHighlightStart(className: string) : IReactProperty = unbox ("classes.rangeIntervalDayHighlightStart", className)
      /// Styles applied to the root element if `isEndOfHighlighting=true` or `day` is the end of the month.
      static member inline rangeIntervalDayHighlightEnd(className: string) : IReactProperty = unbox ("classes.rangeIntervalDayHighlightEnd", className)
      /// Styles applied to the preview element.
      static member inline rangeIntervalPreview(className: string) : IReactProperty = unbox ("classes.rangeIntervalPreview", className)
      /// Styles applied to the root element if `isPreviewing=true` and `outsideCurrentMonth=false`.
      static member inline rangeIntervalDayPreview(className: string) : IReactProperty = unbox ("classes.rangeIntervalDayPreview", className)
      /// Styles applied to the root element if `isStartOfPreviewing=true` or `day` is the start of the month.
      static member inline rangeIntervalDayPreviewStart(className: string) : IReactProperty = unbox ("classes.rangeIntervalDayPreviewStart", className)
      /// Styles applied to the root element if `isEndOfPreviewing=true` or `day` is the end of the month.
      static member inline rangeIntervalDayPreviewEnd(className: string) : IReactProperty = unbox ("classes.rangeIntervalDayPreviewEnd", className)
      /// Styles applied to the day element.
      static member inline day(className: string) : IReactProperty = unbox ("classes.day", className)
      /// Styles applied to the day element if `isHighlighting=false`.
      static member inline dayOutsideRangeInterval(className: string) : IReactProperty = unbox ("classes.dayOutsideRangeInterval", className)
      /// Styles applied to the day element if `selected=false` and `isHighlighting=true`.
      static member inline dayInsideRangeInterval(className: string) : IReactProperty = unbox ("classes.dayInsideRangeInterval", className)
      /// Styles applied to the day element if `selected=false`.
      static member inline notSelectedDate(className: string) : IReactProperty = unbox ("classes.notSelectedDate", className)
  
  
  module monthPicker =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
  
  
  module pickersDay =
  
    /// Override or extend the styles applied to the component.
    [<Erase>]
    type classes =
      /// Styles applied to the root element.
      static member inline root(className: string) : IReactProperty = unbox ("classes.root", className)
      /// Styles applied to the root element if `disableMargin=false`.
      static member inline dayWithMargin(className: string) : IReactProperty = unbox ("classes.dayWithMargin", className)
      /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=true`.
      static member inline dayOutsideMonth(className: string) : IReactProperty = unbox ("classes.dayOutsideMonth", className)
      /// Styles applied to the root element if `outsideCurrentMonth=true` and `showDaysOutsideCurrentMonth=false`.
      static member inline hiddenDaySpacingFiller(className: string) : IReactProperty = unbox ("classes.hiddenDaySpacingFiller", className)
      /// Styles applied to the root element if `disableHighlightToday=false` and `today=true`.
      static member inline today(className: string) : IReactProperty = unbox ("classes.today", className)
      /// State class applied to the root element if `selected=true`.
      static member inline selected(className: string) : IReactProperty = unbox ("classes.selected", className)
      /// State class applied to the root element if `disabled=true`.
      static member inline disabled(className: string) : IReactProperty = unbox ("classes.disabled", className)
  
  