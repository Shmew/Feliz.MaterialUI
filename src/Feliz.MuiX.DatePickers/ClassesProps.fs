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
  
  