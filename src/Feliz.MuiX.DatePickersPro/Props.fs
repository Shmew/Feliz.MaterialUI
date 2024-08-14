namespace Feliz.MaterialUI.X

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open System.ComponentModel
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz


open Feliz.MaterialUI

[<Erase>]
type private Helpers =
  static member inline themeStylesOverride (callback: Theme -> #seq<IStyleAttribute>): 't =
    !!(Func<Theme, _> (stylesCallback !!callback))

  static member inline breakpointThemeStylesOverrides (overrides: (IBreakpointKey * (Theme -> #seq<IStyleAttribute>)) []) =
    overrides
    |> Array.map (fun (breakpoint, themeOverride) -> string breakpoint, Helpers.themeStylesOverride themeOverride)
    |> !!createObj

  static member inline themeBreakpointStylesOverrides (overrides: (Theme -> (IBreakpointKey * #seq<IStyleAttribute>) list) []) =
    overrides |> Array.map (fun themeBpOverride ->
      Func<Theme, _> (fun theme ->
        let bpStyles = themeBpOverride theme |> List.map (fun (bp, styles) -> style.breakpoint bp styles)
        createObj !!bpStyles))

  static member inline renderElementCallback (renderer: #seq<IReactProperty> -> ReactElement): Func<'Props, ReactElement> =
    let outputCallback (propsObj: 'Props)  =
      let propsArray = JS.Constructors.Object.entries propsObj
      renderer (!!propsArray)
    Func<'Props, ReactElement> outputCallback

  static member inline renderElementCallback2 (renderer: #seq<IReactProperty> -> #seq<IReactProperty> -> ReactElement): Func<'Props, 'Props, ReactElement> =
    let outputCallback (propsObj1: 'Props) (propsObj2: 'Props)  =
      let propsArray1 = JS.Constructors.Object.entries propsObj1
      let propsArray2 = JS.Constructors.Object.entries propsObj2
      renderer (!!propsArray1) (!!propsArray2)
    Func<_, _, _> outputCallback


[<Erase>]
type calendarPicker =
  /// Callback fired on date change
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// Views for calendar picker.
  static member inline views ([<ParamArray>] views: DatePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module calendarPicker =

  /// Initially open view.
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Controlled open view.
  [<Erase>]
  type view =
    static member inline day = Interop.mkAttr "view" "day"
    static member inline month = Interop.mkAttr "view" "month"
    static member inline year = Interop.mkAttr "view" "year"


[<Erase>]
type calendarPickerSkeleton =
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (styleOverrides: #seq<IStyleAttribute>) = Interop.mkAttr "sx" (createObj !!styleOverrides)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (?xs: (#seq<IStyleAttribute>), ?sm: (#seq<IStyleAttribute>), ?md: (#seq<IStyleAttribute>), ?lg: (#seq<IStyleAttribute>), ?xl: (#seq<IStyleAttribute>)) = Interop.mkAttr "sx" (let inline paramValue p = p |> !!createObj in let x = createEmpty<obj> in (if xs.IsSome then x?``xs`` <- (paramValue xs.Value)); (if sm.IsSome then x?``sm`` <- (paramValue sm.Value)); (if md.IsSome then x?``md`` <- (paramValue md.Value)); (if lg.IsSome then x?``lg`` <- (paramValue lg.Value)); (if xl.IsSome then x?``xl`` <- (paramValue xl.Value)); x)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeOverride: Theme -> #seq<IStyleAttribute>) = Interop.mkAttr "sx" (Helpers.themeStylesOverride themeOverride)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeOverrides: (Theme -> #seq<IStyleAttribute>) []) = Interop.mkAttr "sx" (themeOverrides |> Array.map Helpers.themeStylesOverride)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (breakpointThemeOverrides: (IBreakpointKey * (Theme -> #seq<IStyleAttribute>)) []) = Interop.mkAttr "sx" (Helpers.breakpointThemeStylesOverrides breakpointThemeOverrides)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (?xs: (Theme -> #seq<IStyleAttribute>), ?sm: (Theme -> #seq<IStyleAttribute>), ?md: (Theme -> #seq<IStyleAttribute>), ?lg: (Theme -> #seq<IStyleAttribute>), ?xl: (Theme -> #seq<IStyleAttribute>)) = Interop.mkAttr "sx" (let inline paramValue p = p |> Helpers.themeStylesOverride in let x = createEmpty<obj> in (if xs.IsSome then x?``xs`` <- (paramValue xs.Value)); (if sm.IsSome then x?``sm`` <- (paramValue sm.Value)); (if md.IsSome then x?``md`` <- (paramValue md.Value)); (if lg.IsSome then x?``lg`` <- (paramValue lg.Value)); (if xl.IsSome then x?``xl`` <- (paramValue xl.Value)); x)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeBreakpointOverrides: (Theme -> (IBreakpointKey * #seq<IStyleAttribute>) list) []) = Interop.mkAttr "sx" (Helpers.themeBreakpointStylesOverrides themeBreakpointOverrides)
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type clockPicker =
  /// Selected date @DateIOType.
  static member inline date (value: 'T) = Interop.mkAttr "date" value
  /// On change callback @DateIOType.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// Set to `true` if focus should be moved to clock picker.
  static member inline autoFocus (value: bool) = Interop.mkAttr "autoFocus" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  ///   Get clock number aria-text for hours.
  ///
  /// **Signature:**
  ///
  /// `function(hours: string) => string`
  ///
  /// *hours:* The hours to format.
  ///
  /// *returns* (string): the formatted hours text.
  static member inline getHoursClockNumberText (getHoursClockNumberText: string -> string) = Interop.mkAttr "getHoursClockNumberText" getHoursClockNumberText
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  ///   Get clock number aria-text for minutes.
  ///
  /// **Signature:**
  ///
  /// `function(minutes: string) => string`
  ///
  /// *minutes:* The minutes to format.
  ///
  /// *returns* (string): the formatted minutes text.
  static member inline getMinutesClockNumberText (getMinutesClockNumberText: string -> string) = Interop.mkAttr "getMinutesClockNumberText" getMinutesClockNumberText
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  ///   Get clock number aria-text for seconds.
  ///
  /// **Signature:**
  ///
  /// `function(seconds: string) => string`
  ///
  /// *seconds:* The seconds to format.
  ///
  /// *returns* (string): the formatted seconds text.
  static member inline getSecondsClockNumberText (getSecondsClockNumberText: string -> string) = Interop.mkAttr "getSecondsClockNumberText" getSecondsClockNumberText
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: ClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: ClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// Views for calendar picker.
  static member inline views ([<ParamArray>] views: TimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module clockPicker =

  /// Initially open view.
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Controlled open view.
  [<Erase>]
  type view =
    static member inline hours = Interop.mkAttr "view" "hours"
    static member inline minutes = Interop.mkAttr "view" "minutes"
    static member inline seconds = Interop.mkAttr "view" "seconds"


[<Erase>]
type datePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// CSS media query when `Mobile` mode will be changed to `Desktop`.
  static member inline desktopModeMediaQuery (value: string) = Interop.mkAttr "desktopModeMediaQuery" value
  /// Props applied to the
  ///
  ///   [`Dialog`](https://mui.com/material-ui/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Paper props passed down to [Paper](https://mui.com/material-ui/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Popper props passed down to [Popper](https://mui.com/material-ui/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: seq<ReactElement>) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// Custom component for popper [Transition](https://mui.com/material-ui/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: DatePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module datePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type dateRangePicker =
  /// Callback fired when the value (the selected date range) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(date: DateRange, keyboardInputValue: string) => void`
  ///
  /// *date:* The new parsed date range.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: ('TDate option * 'TDate option) -> string -> unit) = Interop.mkAttr "onChange" (Func<_, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `startProps` and `endProps` arguments of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props), that you need to forward to the range start/end inputs respectively. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(startProps: MuiTextFieldProps, endProps: MuiTextFieldProps) => React.ReactElement`
  ///
  /// *startProps:* Props that you need to forward to the range start input.
  ///
  /// *endProps:* Props that you need to forward to the range end input.
  ///
  /// *returns* (React.ReactElement): The range input to render.
  static member inline renderInput (renderer: #seq<IReactProperty> -> #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback2 renderer)
  /// The value of the picker.
  static member inline value ([<ParamArray>] values: 'T []) = Interop.mkAttr "value" values
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// The number of calendars that render on **desktop**.
  static member inline calendars (numCalendars: int) = Interop.mkAttr "calendars" numCalendars
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// CSS media query when `Mobile` mode will be changed to `Desktop`.
  static member inline desktopModeMediaQuery (value: string) = Interop.mkAttr "desktopModeMediaQuery" value
  /// Props applied to the
  ///
  ///   [`Dialog`](https://mui.com/material-ui/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  /// If `true`, after selecting `start` date calendar will not automatically switch to the month of `end` date.
  static member inline disableAutoMonthSwitching (value: bool) = Interop.mkAttr "disableAutoMonthSwitching" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: ReactElement) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: seq<ReactElement>) = Interop.mkAttr "endText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: string) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: string seq) = Interop.mkAttr "endText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: int) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: float) = Interop.mkAttr "endText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Paper props passed down to [Paper](https://mui.com/material-ui/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Popper props passed down to [Popper](https://mui.com/material-ui/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for `` days. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, dateRangePickerDayProps: DateRangePickerDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *dateRangePickerDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, position: string) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *position:* The date to test, 'start' or 'end'.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: ReactElement) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: seq<ReactElement>) = Interop.mkAttr "startText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: string) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: string seq) = Interop.mkAttr "startText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: int) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: float) = Interop.mkAttr "startText" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// Custom component for popper [Transition](https://mui.com/material-ui/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module dateRangePicker =

  /// The number of calendars that render on **desktop**.
  [<Erase>]
  type calendars =
    static member inline _1 = Interop.mkAttr "calendars" 1
    static member inline _2 = Interop.mkAttr "calendars" 2
    static member inline _3 = Interop.mkAttr "calendars" 3


[<Erase>]
type dateRangePickerDay =
  /// The date to show.
  static member inline day (value: 'T) = Interop.mkAttr "day" value
  /// Set to `true` if the `day` is the end of a highlighted date range.
  static member inline isEndOfHighlighting (value: bool) = Interop.mkAttr "isEndOfHighlighting" value
  /// Set to `true` if the `day` is the start of a highlighted date range.
  static member inline isEndOfPreviewing (value: bool) = Interop.mkAttr "isEndOfPreviewing" value
  /// Set to `true` if the `day` is in a highlighted date range.
  static member inline isHighlighting (value: bool) = Interop.mkAttr "isHighlighting" value
  /// Set to `true` if the `day` is in a preview date range.
  static member inline isPreviewing (value: bool) = Interop.mkAttr "isPreviewing" value
  /// Set to `true` if the `day` is the start of a highlighted date range.
  static member inline isStartOfHighlighting (value: bool) = Interop.mkAttr "isStartOfHighlighting" value
  /// Set to `true` if the `day` is the end of a highlighted date range.
  static member inline isStartOfPreviewing (value: bool) = Interop.mkAttr "isStartOfPreviewing" value
  /// If `true`, day is outside of month and will be hidden.
  static member inline outsideCurrentMonth (value: bool) = Interop.mkAttr "outsideCurrentMonth" value
  /// If `true`, renders as disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// If `true`, days are rendering without margin. Useful for displaying linked range of days.
  static member inline disableMargin (value: bool) = Interop.mkAttr "disableMargin" value
  /// If `true`, renders as selected.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (styleOverrides: #seq<IStyleAttribute>) = Interop.mkAttr "sx" (createObj !!styleOverrides)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (?xs: (#seq<IStyleAttribute>), ?sm: (#seq<IStyleAttribute>), ?md: (#seq<IStyleAttribute>), ?lg: (#seq<IStyleAttribute>), ?xl: (#seq<IStyleAttribute>)) = Interop.mkAttr "sx" (let inline paramValue p = p |> !!createObj in let x = createEmpty<obj> in (if xs.IsSome then x?``xs`` <- (paramValue xs.Value)); (if sm.IsSome then x?``sm`` <- (paramValue sm.Value)); (if md.IsSome then x?``md`` <- (paramValue md.Value)); (if lg.IsSome then x?``lg`` <- (paramValue lg.Value)); (if xl.IsSome then x?``xl`` <- (paramValue xl.Value)); x)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeOverride: Theme -> #seq<IStyleAttribute>) = Interop.mkAttr "sx" (Helpers.themeStylesOverride themeOverride)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeOverrides: (Theme -> #seq<IStyleAttribute>) []) = Interop.mkAttr "sx" (themeOverrides |> Array.map Helpers.themeStylesOverride)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (breakpointThemeOverrides: (IBreakpointKey * (Theme -> #seq<IStyleAttribute>)) []) = Interop.mkAttr "sx" (Helpers.breakpointThemeStylesOverrides breakpointThemeOverrides)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (?xs: (Theme -> #seq<IStyleAttribute>), ?sm: (Theme -> #seq<IStyleAttribute>), ?md: (Theme -> #seq<IStyleAttribute>), ?lg: (Theme -> #seq<IStyleAttribute>), ?xl: (Theme -> #seq<IStyleAttribute>)) = Interop.mkAttr "sx" (let inline paramValue p = p |> Helpers.themeStylesOverride in let x = createEmpty<obj> in (if xs.IsSome then x?``xs`` <- (paramValue xs.Value)); (if sm.IsSome then x?``sm`` <- (paramValue sm.Value)); (if md.IsSome then x?``md`` <- (paramValue md.Value)); (if lg.IsSome then x?``lg`` <- (paramValue lg.Value)); (if xl.IsSome then x?``xl`` <- (paramValue xl.Value)); x)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeBreakpointOverrides: (Theme -> (IBreakpointKey * #seq<IStyleAttribute>) list) []) = Interop.mkAttr "sx" (Helpers.themeBreakpointStylesOverrides themeBreakpointOverrides)
  /// If `true`, renders as today date.
  static member inline today (value: bool) = Interop.mkAttr "today" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type dateTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Date tab icon.
  static member inline dateRangeIcon (element: ReactElement) = Interop.mkAttr "dateRangeIcon" element
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// CSS media query when `Mobile` mode will be changed to `Desktop`.
  static member inline desktopModeMediaQuery (value: string) = Interop.mkAttr "desktopModeMediaQuery" value
  /// Props applied to the
  ///
  ///   [`Dialog`](https://mui.com/material-ui/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Toggles visibility of date time switching tabs
  static member inline hideTabs (value: bool) = Interop.mkAttr "hideTabs" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Maximal selectable moment of time with binding to date, to set max time in each day use `maxTime`.
  static member inline maxDateTime (value: 'T) = Interop.mkAttr "maxDateTime" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Minimal selectable moment of time with binding to date, to set min time in each day use `minTime`.
  static member inline minDateTime (value: 'T) = Interop.mkAttr "minDateTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarOrClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarOrClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Paper props passed down to [Paper](https://mui.com/material-ui/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Popper props passed down to [Popper](https://mui.com/material-ui/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Time tab icon.
  static member inline timeIcon (element: ReactElement) = Interop.mkAttr "timeIcon" element
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: seq<ReactElement>) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// Custom component for popper [Transition](https://mui.com/material-ui/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: DateTimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module dateTimePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type desktopDatePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Paper props passed down to [Paper](https://mui.com/material-ui/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Popper props passed down to [Popper](https://mui.com/material-ui/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: seq<ReactElement>) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// Custom component for popper [Transition](https://mui.com/material-ui/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: DatePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module desktopDatePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type desktopDateRangePicker =
  /// Callback fired when the value (the selected date range) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(date: DateRange, keyboardInputValue: string) => void`
  ///
  /// *date:* The new parsed date range.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: ('TDate option * 'TDate option) -> string -> unit) = Interop.mkAttr "onChange" (Func<_, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `startProps` and `endProps` arguments of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props), that you need to forward to the range start/end inputs respectively. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(startProps: MuiTextFieldProps, endProps: MuiTextFieldProps) => React.ReactElement`
  ///
  /// *startProps:* Props that you need to forward to the range start input.
  ///
  /// *endProps:* Props that you need to forward to the range end input.
  ///
  /// *returns* (React.ReactElement): The range input to render.
  static member inline renderInput (renderer: #seq<IReactProperty> -> #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback2 renderer)
  /// The value of the picker.
  static member inline value ([<ParamArray>] values: 'T []) = Interop.mkAttr "value" values
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// The number of calendars that render on **desktop**.
  static member inline calendars (numCalendars: int) = Interop.mkAttr "calendars" numCalendars
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// If `true`, after selecting `start` date calendar will not automatically switch to the month of `end` date.
  static member inline disableAutoMonthSwitching (value: bool) = Interop.mkAttr "disableAutoMonthSwitching" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: ReactElement) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: seq<ReactElement>) = Interop.mkAttr "endText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: string) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: string seq) = Interop.mkAttr "endText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: int) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: float) = Interop.mkAttr "endText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Paper props passed down to [Paper](https://mui.com/material-ui/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Popper props passed down to [Popper](https://mui.com/material-ui/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for `` days. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, dateRangePickerDayProps: DateRangePickerDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *dateRangePickerDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, position: string) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *position:* The date to test, 'start' or 'end'.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: ReactElement) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: seq<ReactElement>) = Interop.mkAttr "startText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: string) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: string seq) = Interop.mkAttr "startText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: int) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: float) = Interop.mkAttr "startText" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// Custom component for popper [Transition](https://mui.com/material-ui/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module desktopDateRangePicker =

  /// The number of calendars that render on **desktop**.
  [<Erase>]
  type calendars =
    static member inline _1 = Interop.mkAttr "calendars" 1
    static member inline _2 = Interop.mkAttr "calendars" 2
    static member inline _3 = Interop.mkAttr "calendars" 3


[<Erase>]
type desktopDateTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Date tab icon.
  static member inline dateRangeIcon (element: ReactElement) = Interop.mkAttr "dateRangeIcon" element
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Toggles visibility of date time switching tabs
  static member inline hideTabs (value: bool) = Interop.mkAttr "hideTabs" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Maximal selectable moment of time with binding to date, to set max time in each day use `maxTime`.
  static member inline maxDateTime (value: 'T) = Interop.mkAttr "maxDateTime" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Minimal selectable moment of time with binding to date, to set min time in each day use `minTime`.
  static member inline minDateTime (value: 'T) = Interop.mkAttr "minDateTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarOrClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarOrClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Paper props passed down to [Paper](https://mui.com/material-ui/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Popper props passed down to [Popper](https://mui.com/material-ui/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Time tab icon.
  static member inline timeIcon (element: ReactElement) = Interop.mkAttr "timeIcon" element
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: seq<ReactElement>) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// Custom component for popper [Transition](https://mui.com/material-ui/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: DateTimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module desktopDateTimePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type desktopTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: ClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: ClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Paper props passed down to [Paper](https://mui.com/material-ui/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Popper props passed down to [Popper](https://mui.com/material-ui/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// Custom component for popper [Transition](https://mui.com/material-ui/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: TimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module desktopTimePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type localizationProvider =
  static member inline children (element: ReactElement) = prop.children element
  static member inline children (elements: seq<ReactElement>) = prop.children elements
  static member inline children (value: string) = Interop.mkAttr "children" value
  static member inline children (values: string seq) = Interop.mkAttr "children" values
  static member inline children (value: int) = Interop.mkAttr "children" value
  static member inline children (value: float) = Interop.mkAttr "children" value
  /// Locale for the date library you are using
  static member inline adapterLocale (localeCode: string) = Interop.mkAttr "adapterLocale" localeCode
  /// Formats that are used for any child pickers
  static member inline dateFormats (?dayOfMonth: string, ?fullDate: string, ?fullDateTime: string, ?fullDateTime12h: string, ?fullDateTime24h: string, ?fullDateWithWeekday: string, ?fullTime: string, ?fullTime12h: string, ?fullTime24h: string, ?hours12h: string, ?hours24h: string, ?keyboardDate: string, ?keyboardDateTime: string, ?keyboardDateTime12h: string, ?keyboardDateTime24h: string, ?minutes: string, ?month: string, ?monthAndDate: string, ?monthAndYear: string, ?monthShort: string, ?normalDate: string, ?normalDateWithWeekday: string, ?seconds: string, ?shortDate: string, ?weekday: string, ?weekdayShort: string, ?year: string) = Interop.mkAttr "dateFormats" (let x = createEmpty<obj> in (if dayOfMonth.IsSome then x?``dayOfMonth`` <- dayOfMonth); (if fullDate.IsSome then x?``fullDate`` <- fullDate); (if fullDateTime.IsSome then x?``fullDateTime`` <- fullDateTime); (if fullDateTime12h.IsSome then x?``fullDateTime12h`` <- fullDateTime12h); (if fullDateTime24h.IsSome then x?``fullDateTime24h`` <- fullDateTime24h); (if fullDateWithWeekday.IsSome then x?``fullDateWithWeekday`` <- fullDateWithWeekday); (if fullTime.IsSome then x?``fullTime`` <- fullTime); (if fullTime12h.IsSome then x?``fullTime12h`` <- fullTime12h); (if fullTime24h.IsSome then x?``fullTime24h`` <- fullTime24h); (if hours12h.IsSome then x?``hours12h`` <- hours12h); (if hours24h.IsSome then x?``hours24h`` <- hours24h); (if keyboardDate.IsSome then x?``keyboardDate`` <- keyboardDate); (if keyboardDateTime.IsSome then x?``keyboardDateTime`` <- keyboardDateTime); (if keyboardDateTime12h.IsSome then x?``keyboardDateTime12h`` <- keyboardDateTime12h); (if keyboardDateTime24h.IsSome then x?``keyboardDateTime24h`` <- keyboardDateTime24h); (if minutes.IsSome then x?``minutes`` <- minutes); (if month.IsSome then x?``month`` <- month); (if monthAndDate.IsSome then x?``monthAndDate`` <- monthAndDate); (if monthAndYear.IsSome then x?``monthAndYear`` <- monthAndYear); (if monthShort.IsSome then x?``monthShort`` <- monthShort); (if normalDate.IsSome then x?``normalDate`` <- normalDate); (if normalDateWithWeekday.IsSome then x?``normalDateWithWeekday`` <- normalDateWithWeekday); (if seconds.IsSome then x?``seconds`` <- seconds); (if shortDate.IsSome then x?``shortDate`` <- shortDate); (if weekday.IsSome then x?``weekday`` <- weekday); (if weekdayShort.IsSome then x?``weekdayShort`` <- weekdayShort); (if year.IsSome then x?``year`` <- year); x)
  /// Date library instance you are using, if it has some global overrides `jsx dateLibInstance={momentTimeZone} `
  static member inline dateLibInstance (value: obj) = Interop.mkAttr "dateLibInstance" value
  /// Locale for components texts
  static member inline localeText (value: obj) = Interop.mkAttr "localeText" value

module localizationProvider =

  /// DateIO adapter class function
  [<Erase>]
  type dateAdapter =
    static member inline dayJs = Interop.mkAttr "dateAdapter" (import "AdapterDayjs" "@mui/x-date-pickers/AdapterDayjs")
    static member inline dateFns = Interop.mkAttr "dateAdapter" (import "AdapterDateFns" "@mui/x-date-pickers/AdapterDateFns")
    static member inline luxon = Interop.mkAttr "dateAdapter" (import "AdapterLuxon" "@mui/x-date-pickers/AdapterLuxon")
    static member inline moment = Interop.mkAttr "dateAdapter" (import "AdapterMoment" "@mui/x-date-pickers/AdapterMoment")


[<Erase>]
type mobileDatePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// Props applied to the
  ///
  ///   [`Dialog`](https://mui.com/material-ui/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: seq<ReactElement>) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: DatePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileDatePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type mobileDateRangePicker =
  /// Callback fired when the value (the selected date range) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(date: DateRange, keyboardInputValue: string) => void`
  ///
  /// *date:* The new parsed date range.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: ('TDate option * 'TDate option) -> string -> unit) = Interop.mkAttr "onChange" (Func<_, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `startProps` and `endProps` arguments of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props), that you need to forward to the range start/end inputs respectively. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(startProps: MuiTextFieldProps, endProps: MuiTextFieldProps) => React.ReactElement`
  ///
  /// *startProps:* Props that you need to forward to the range start input.
  ///
  /// *endProps:* Props that you need to forward to the range end input.
  ///
  /// *returns* (React.ReactElement): The range input to render.
  static member inline renderInput (renderer: #seq<IReactProperty> -> #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback2 renderer)
  /// The value of the picker.
  static member inline value ([<ParamArray>] values: 'T []) = Interop.mkAttr "value" values
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// The number of calendars that render on **desktop**.
  static member inline calendars (numCalendars: int) = Interop.mkAttr "calendars" numCalendars
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// Props applied to the
  ///
  ///   [`Dialog`](https://mui.com/material-ui/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  /// If `true`, after selecting `start` date calendar will not automatically switch to the month of `end` date.
  static member inline disableAutoMonthSwitching (value: bool) = Interop.mkAttr "disableAutoMonthSwitching" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: ReactElement) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: seq<ReactElement>) = Interop.mkAttr "endText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: string) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: string seq) = Interop.mkAttr "endText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: int) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: float) = Interop.mkAttr "endText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for `` days. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, dateRangePickerDayProps: DateRangePickerDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *dateRangePickerDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, position: string) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *position:* The date to test, 'start' or 'end'.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: ReactElement) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: seq<ReactElement>) = Interop.mkAttr "startText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: string) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: string seq) = Interop.mkAttr "startText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: int) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: float) = Interop.mkAttr "startText" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileDateRangePicker =

  /// The number of calendars that render on **desktop**.
  [<Erase>]
  type calendars =
    static member inline _1 = Interop.mkAttr "calendars" 1
    static member inline _2 = Interop.mkAttr "calendars" 2
    static member inline _3 = Interop.mkAttr "calendars" 3


[<Erase>]
type mobileDateTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Date tab icon.
  static member inline dateRangeIcon (element: ReactElement) = Interop.mkAttr "dateRangeIcon" element
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// Props applied to the
  ///
  ///   [`Dialog`](https://mui.com/material-ui/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Toggles visibility of date time switching tabs
  static member inline hideTabs (value: bool) = Interop.mkAttr "hideTabs" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Maximal selectable moment of time with binding to date, to set max time in each day use `maxTime`.
  static member inline maxDateTime (value: 'T) = Interop.mkAttr "maxDateTime" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Minimal selectable moment of time with binding to date, to set min time in each day use `minTime`.
  static member inline minDateTime (value: 'T) = Interop.mkAttr "minDateTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarOrClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarOrClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Time tab icon.
  static member inline timeIcon (element: ReactElement) = Interop.mkAttr "timeIcon" element
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: seq<ReactElement>) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: DateTimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileDateTimePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type mobileTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Props applied to the
  ///
  ///   [`Dialog`](https://mui.com/material-ui/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: ClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: ClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: TimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module mobileTimePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type monthPicker =
  /// Date value for the MonthPicker
  static member inline date (value: 'T) = Interop.mkAttr "date" value
  /// Callback fired on date change.
  static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// className applied to the root element.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` picker is disabled
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// If `true` picker is readonly
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (styleOverrides: #seq<IStyleAttribute>) = Interop.mkAttr "sx" (createObj !!styleOverrides)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (?xs: (#seq<IStyleAttribute>), ?sm: (#seq<IStyleAttribute>), ?md: (#seq<IStyleAttribute>), ?lg: (#seq<IStyleAttribute>), ?xl: (#seq<IStyleAttribute>)) = Interop.mkAttr "sx" (let inline paramValue p = p |> !!createObj in let x = createEmpty<obj> in (if xs.IsSome then x?``xs`` <- (paramValue xs.Value)); (if sm.IsSome then x?``sm`` <- (paramValue sm.Value)); (if md.IsSome then x?``md`` <- (paramValue md.Value)); (if lg.IsSome then x?``lg`` <- (paramValue lg.Value)); (if xl.IsSome then x?``xl`` <- (paramValue xl.Value)); x)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeOverride: Theme -> #seq<IStyleAttribute>) = Interop.mkAttr "sx" (Helpers.themeStylesOverride themeOverride)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeOverrides: (Theme -> #seq<IStyleAttribute>) []) = Interop.mkAttr "sx" (themeOverrides |> Array.map Helpers.themeStylesOverride)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (breakpointThemeOverrides: (IBreakpointKey * (Theme -> #seq<IStyleAttribute>)) []) = Interop.mkAttr "sx" (Helpers.breakpointThemeStylesOverrides breakpointThemeOverrides)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (?xs: (Theme -> #seq<IStyleAttribute>), ?sm: (Theme -> #seq<IStyleAttribute>), ?md: (Theme -> #seq<IStyleAttribute>), ?lg: (Theme -> #seq<IStyleAttribute>), ?xl: (Theme -> #seq<IStyleAttribute>)) = Interop.mkAttr "sx" (let inline paramValue p = p |> Helpers.themeStylesOverride in let x = createEmpty<obj> in (if xs.IsSome then x?``xs`` <- (paramValue xs.Value)); (if sm.IsSome then x?``sm`` <- (paramValue sm.Value)); (if md.IsSome then x?``md`` <- (paramValue md.Value)); (if lg.IsSome then x?``lg`` <- (paramValue lg.Value)); (if xl.IsSome then x?``xl`` <- (paramValue xl.Value)); x)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeBreakpointOverrides: (Theme -> (IBreakpointKey * #seq<IStyleAttribute>) list) []) = Interop.mkAttr "sx" (Helpers.themeBreakpointStylesOverrides themeBreakpointOverrides)
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type pickersDay =
  /// The date to show.
  static member inline day (value: 'T) = Interop.mkAttr "day" value
  /// If `true`, day is outside of month and will be hidden.
  static member inline outsideCurrentMonth (value: bool) = Interop.mkAttr "outsideCurrentMonth" value
  /// If `true`, renders as disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// If `true`, days are rendering without margin. Useful for displaying linked range of days.
  static member inline disableMargin (value: bool) = Interop.mkAttr "disableMargin" value
  /// If `true`, renders as selected.
  static member inline selected (value: bool) = Interop.mkAttr "selected" value
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (styleOverrides: #seq<IStyleAttribute>) = Interop.mkAttr "sx" (createObj !!styleOverrides)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (?xs: (#seq<IStyleAttribute>), ?sm: (#seq<IStyleAttribute>), ?md: (#seq<IStyleAttribute>), ?lg: (#seq<IStyleAttribute>), ?xl: (#seq<IStyleAttribute>)) = Interop.mkAttr "sx" (let inline paramValue p = p |> !!createObj in let x = createEmpty<obj> in (if xs.IsSome then x?``xs`` <- (paramValue xs.Value)); (if sm.IsSome then x?``sm`` <- (paramValue sm.Value)); (if md.IsSome then x?``md`` <- (paramValue md.Value)); (if lg.IsSome then x?``lg`` <- (paramValue lg.Value)); (if xl.IsSome then x?``xl`` <- (paramValue xl.Value)); x)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeOverride: Theme -> #seq<IStyleAttribute>) = Interop.mkAttr "sx" (Helpers.themeStylesOverride themeOverride)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeOverrides: (Theme -> #seq<IStyleAttribute>) []) = Interop.mkAttr "sx" (themeOverrides |> Array.map Helpers.themeStylesOverride)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (breakpointThemeOverrides: (IBreakpointKey * (Theme -> #seq<IStyleAttribute>)) []) = Interop.mkAttr "sx" (Helpers.breakpointThemeStylesOverrides breakpointThemeOverrides)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (?xs: (Theme -> #seq<IStyleAttribute>), ?sm: (Theme -> #seq<IStyleAttribute>), ?md: (Theme -> #seq<IStyleAttribute>), ?lg: (Theme -> #seq<IStyleAttribute>), ?xl: (Theme -> #seq<IStyleAttribute>)) = Interop.mkAttr "sx" (let inline paramValue p = p |> Helpers.themeStylesOverride in let x = createEmpty<obj> in (if xs.IsSome then x?``xs`` <- (paramValue xs.Value)); (if sm.IsSome then x?``sm`` <- (paramValue sm.Value)); (if md.IsSome then x?``md`` <- (paramValue md.Value)); (if lg.IsSome then x?``lg`` <- (paramValue lg.Value)); (if xl.IsSome then x?``xl`` <- (paramValue xl.Value)); x)
  /// The system prop that allows defining system overrides as well as additional CSS styles. See the [`sx` page](https://mui.com/system/getting-started/the-sx-prop/) for more details.
  static member inline sx (themeBreakpointOverrides: (Theme -> (IBreakpointKey * #seq<IStyleAttribute>) list) []) = Interop.mkAttr "sx" (Helpers.themeBreakpointStylesOverrides themeBreakpointOverrides)
  /// If `true`, renders as today date.
  static member inline today (value: bool) = Interop.mkAttr "today" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()


[<Erase>]
type staticDatePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: seq<ReactElement>) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: DatePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module staticDatePicker =

  /// Force static wrapper inner components to be rendered in mobile or desktop mode.
  [<Erase>]
  type displayStaticWrapperAs =
    static member inline desktop = Interop.mkAttr "displayStaticWrapperAs" "desktop"
    static member inline mobile = Interop.mkAttr "displayStaticWrapperAs" "mobile"

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type staticDateRangePicker =
  /// Callback fired when the value (the selected date range) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(date: DateRange, keyboardInputValue: string) => void`
  ///
  /// *date:* The new parsed date range.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: ('TDate option * 'TDate option) -> string -> unit) = Interop.mkAttr "onChange" (Func<_, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `startProps` and `endProps` arguments of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props), that you need to forward to the range start/end inputs respectively. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(startProps: MuiTextFieldProps, endProps: MuiTextFieldProps) => React.ReactElement`
  ///
  /// *startProps:* Props that you need to forward to the range start input.
  ///
  /// *endProps:* Props that you need to forward to the range end input.
  ///
  /// *returns* (React.ReactElement): The range input to render.
  static member inline renderInput (renderer: #seq<IReactProperty> -> #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback2 renderer)
  /// The value of the picker.
  static member inline value ([<ParamArray>] values: 'T []) = Interop.mkAttr "value" values
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// The number of calendars that render on **desktop**.
  static member inline calendars (numCalendars: int) = Interop.mkAttr "calendars" numCalendars
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// If `true`, after selecting `start` date calendar will not automatically switch to the month of `end` date.
  static member inline disableAutoMonthSwitching (value: bool) = Interop.mkAttr "disableAutoMonthSwitching" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: ReactElement) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: seq<ReactElement>) = Interop.mkAttr "endText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: string) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (values: string seq) = Interop.mkAttr "endText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: int) = Interop.mkAttr "endText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for end input label and toolbar placeholder.
  static member inline endText (value: float) = Interop.mkAttr "endText" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for `` days. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, dateRangePickerDayProps: DateRangePickerDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *dateRangePickerDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, position: string) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *position:* The date to test, 'start' or 'end'.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: ReactElement) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: seq<ReactElement>) = Interop.mkAttr "startText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: string) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (values: string seq) = Interop.mkAttr "startText" values
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: int) = Interop.mkAttr "startText" value
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated** -
  ///
  ///       Use the `localeText` prop of `LocalizationProvider` instead, see https://mui.com/x/react-date-pickers/localization/.
  ///
  /// Text for start input label and toolbar placeholder.
  static member inline startText (value: float) = Interop.mkAttr "startText" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module staticDateRangePicker =

  /// The number of calendars that render on **desktop**.
  [<Erase>]
  type calendars =
    static member inline _1 = Interop.mkAttr "calendars" 1
    static member inline _2 = Interop.mkAttr "calendars" 2
    static member inline _3 = Interop.mkAttr "calendars" 3

  /// Force static wrapper inner components to be rendered in mobile or desktop mode.
  [<Erase>]
  type displayStaticWrapperAs =
    static member inline desktop = Interop.mkAttr "displayStaticWrapperAs" "desktop"
    static member inline mobile = Interop.mkAttr "displayStaticWrapperAs" "mobile"


[<Erase>]
type staticDateTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// Date tab icon.
  static member inline dateRangeIcon (element: ReactElement) = Interop.mkAttr "dateRangeIcon" element
  /// Formats the day of week displayed in the calendar header.
  ///
  /// **Signature:**
  ///
  /// `function(day: string) => string`
  ///
  /// *day:* The day of week provided by the adapter's method `getWeekdays`.
  ///
  /// *returns* (string): The name to display.
  static member inline dayOfWeekFormatter (formatter: string -> string) = Interop.mkAttr "dayOfWeekFormatter" (Func<_, _> formatter)
  /// Default calendar month displayed when `value={null}`.
  static member inline defaultCalendarMonth (value: 'T) = Interop.mkAttr "defaultCalendarMonth" value
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Toggles visibility of date time switching tabs
  static member inline hideTabs (value: bool) = Interop.mkAttr "hideTabs" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Left arrow icon aria-label text.
  static member inline leftArrowButtonText (value: string) = Interop.mkAttr "leftArrowButtonText" value
  /// If `true` renders `LoadingComponent` in calendar instead of calendar view. Can be used to preload information and show it in calendar.
  static member inline loading (value: bool) = Interop.mkAttr "loading" value
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Maximal selectable moment of time with binding to date, to set max time in each day use `maxTime`.
  static member inline maxDateTime (value: 'T) = Interop.mkAttr "maxDateTime" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Minimal selectable moment of time with binding to date, to set min time in each day use `minTime`.
  static member inline minDateTime (value: 'T) = Interop.mkAttr "minDateTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> unit) = Interop.mkAttr "onMonthChange" handler
  /// Callback firing on month change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => void | Promise`
  ///
  /// *month:* The new month.
  ///
  /// *returns* (void | Promise): -
  static member inline onMonthChange (handler: 'TDate -> JS.Promise<unit>) = Interop.mkAttr "onMonthChange" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: CalendarOrClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: CalendarOrClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Callback firing on year change @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => void`
  ///
  /// *year:* The new year.
  static member inline onYearChange (handler: 'TDate -> unit) = Interop.mkAttr "onYearChange" handler
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Disable heavy animations.
  static member inline reduceAnimations (value: bool) = Interop.mkAttr "reduceAnimations" value
  /// Custom renderer for day. Check the [PickersDay](https://mui.com/x/api/date-pickers/pickers-day/) component.
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate, selectedDays: Array, pickersDayProps: PickersDayProps) => JSX.Element`
  ///
  /// *day:* The day to render.
  ///
  /// *selectedDays:* The days currently selected.
  ///
  /// *pickersDayProps:* The props of the day to render.
  ///
  /// *returns* (JSX.Element): The element representing the day.
  static member inline renderDay (renderer: unit -> ReactElement) = Interop.mkAttr "renderDay" renderer
  /// Component displaying when passed `loading` true.
  ///
  /// **Signature:**
  ///
  /// `function() => React.ReactNode`
  ///
  /// *returns* (React.ReactNode): The node to render when loading.
  static member inline renderLoading (renderer: unit -> ReactElement) = Interop.mkAttr "renderLoading" renderer
  /// <svg class="MuiSvgIcon-root MuiSvgIcon-fontSizeInherit css-1cw4hi4" focusable="false" aria-hidden="true" viewbox="0 0 24 24" data-testid="ReportProblemOutlinedIcon"><br><br>      <path d="M12 5.99L19.53 19H4.47L12 5.99M12 2L1 21h22L12 2zm1 14h-2v2h2v-2zm0-6h-2v4h2v-4z"></path><br><br>    </svg>
  ///
  ///     **Deprecated**
  ///
  /// Right arrow icon aria-label text.
  static member inline rightArrowButtonText (value: string) = Interop.mkAttr "rightArrowButtonText" value
  /// Disable specific date. @DateIOType
  ///
  /// **Signature:**
  ///
  /// `function(day: TDate) => boolean`
  ///
  /// *day:* The date to test.
  ///
  /// *returns* (boolean): Returns `true` if the date should be disabled.
  static member inline shouldDisableDate (shouldDisableDate: System.DateTime -> bool) = Interop.mkAttr "shouldDisableDate" (Func<_, _> shouldDisableDate)
  /// Disable specific months dynamically. Works like `shouldDisableDate` but for month selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(month: TDate) => boolean`
  ///
  /// *month:* The month to check.
  ///
  /// *returns* (boolean): If `true` the month will be disabled.
  static member inline shouldDisableMonth (shouldDisableMonth: int -> bool) = Interop.mkAttr "shouldDisableMonth" (Func<_, _> shouldDisableMonth)
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// If `true`, days that have `outsideCurrentMonth={true}` are displayed.
  static member inline showDaysOutsideCurrentMonth (value: bool) = Interop.mkAttr "showDaysOutsideCurrentMonth" value
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Time tab icon.
  static member inline timeIcon (element: ReactElement) = Interop.mkAttr "timeIcon" element
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Date format, that is displaying in toolbar.
  static member inline toolbarFormat (value: string) = Interop.mkAttr "toolbarFormat" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: ReactElement) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: seq<ReactElement>) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: string) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (values: string seq) = Interop.mkAttr "toolbarPlaceholder" values
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: int) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker date value placeholder, displaying if `value` === `null`.
  static member inline toolbarPlaceholder (value: float) = Interop.mkAttr "toolbarPlaceholder" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: DateTimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module staticDateTimePicker =

  /// Force static wrapper inner components to be rendered in mobile or desktop mode.
  [<Erase>]
  type displayStaticWrapperAs =
    static member inline desktop = Interop.mkAttr "displayStaticWrapperAs" "desktop"
    static member inline mobile = Interop.mkAttr "displayStaticWrapperAs" "mobile"

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline day = Interop.mkAttr "openTo" "day"
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline month = Interop.mkAttr "openTo" "month"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"
    static member inline year = Interop.mkAttr "openTo" "year"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type staticTimePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: ClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: ClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: TimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module staticTimePicker =

  /// Force static wrapper inner components to be rendered in mobile or desktop mode.
  [<Erase>]
  type displayStaticWrapperAs =
    static member inline desktop = Interop.mkAttr "displayStaticWrapperAs" "desktop"
    static member inline mobile = Interop.mkAttr "displayStaticWrapperAs" "mobile"

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type timePicker =
  /// Callback fired when the value (the selected date) changes @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue, keyboardInputValue: string) => void`
  ///
  /// *value:* The new parsed value.
  ///
  /// *keyboardInputValue:* The current value of the keyboard input.
  static member inline onChange (handler: 'TValue -> string -> unit) = Interop.mkAttr "onChange" (Func<'TValue, string, unit> handler)
  /// The `renderInput` prop allows you to customize the rendered input. The `props` argument of this render prop contains props of [TextField](https://mui.com/material-ui/api/text-field/#props) that you need to forward. Pay specific attention to the `ref` and `inputProps` keys.
  ///
  /// **Signature:**
  ///
  /// `function(props: MuiTextFieldPropsType) => React.ReactNode`
  ///
  /// *props:* The props of the input.
  ///
  /// *returns* (React.ReactNode): The node to render as the input.
  static member inline renderInput (renderer: #seq<IReactProperty> -> ReactElement) = Interop.mkAttr "renderInput" (Helpers.renderElementCallback renderer)
  /// Regular expression to detect "accepted" symbols.
  static member inline acceptRegex (acceptRegex: System.Text.RegularExpressions.Regex) = Interop.mkAttr "acceptRegex" acceptRegex
  /// 12h/24h view for hour selection clock.
  static member inline ampm (value: bool) = Interop.mkAttr "ampm" value
  /// Display ampm controls under the clock (instead of in the toolbar).
  static member inline ampmInClock (value: bool) = Interop.mkAttr "ampmInClock" value
  /// className applied to the root component.
  static member inline className (value: string) = Interop.mkAttr "className" value
  /// If `true` the popup or dialog will immediately close after submitting full date.
  static member inline closeOnSelect (value: bool) = Interop.mkAttr "closeOnSelect" value
  /// Overrideable components.
  static member inline components (value: obj) = Interop.mkAttr "components" value
  /// The props used for each component slot.
  static member inline componentsProps (props: IReactProperty list) = Interop.mkAttr "componentsProps" (createObj !!props)
  /// CSS media query when `Mobile` mode will be changed to `Desktop`.
  static member inline desktopModeMediaQuery (value: string) = Interop.mkAttr "desktopModeMediaQuery" value
  /// Props applied to the
  ///
  ///   [`Dialog`](https://mui.com/material-ui/api/dialog/) element.
  static member inline DialogProps (props: IReactProperty list) = Interop.mkAttr "DialogProps" (createObj !!props)
  /// If `true`, the picker and text field are disabled.
  static member inline disabled (value: bool) = Interop.mkAttr "disabled" value
  /// Do not ignore date part when validating min/max time.
  static member inline disableIgnoringDatePartForTimeValidation (value: bool) = Interop.mkAttr "disableIgnoringDatePartForTimeValidation" value
  /// Disable mask on the keyboard, this should be used rarely. Consider passing proper mask for your format.
  static member inline disableMaskedInput (value: bool) = Interop.mkAttr "disableMaskedInput" value
  /// Do not render open picker button (renders only text field with validation).
  static member inline disableOpenPicker (value: bool) = Interop.mkAttr "disableOpenPicker" value
  /// Props to pass to keyboard input adornment.
  static member inline InputAdornmentProps (props: IReactProperty list) = Interop.mkAttr "InputAdornmentProps" (createObj !!props)
  /// Format string.
  static member inline inputFormat (value: string) = Interop.mkAttr "inputFormat" value
  /// Pass a ref to the `input` element.
  static member inline inputRef (ref: IRefValue<#Element option>) = Interop.mkAttr "inputRef" ref
  /// Pass a ref to the `input` element.
  static member inline inputRef (handler: #Element -> unit) = Interop.mkAttr "inputRef" handler
  /// Custom mask. Can be used to override generate from format. (e.g. `__/__/____ __:__` or `__/__/____ __:__ _M`).
  static member inline mask (value: string) = Interop.mkAttr "mask" value
  /// Max time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline maxTime (value: 'T) = Interop.mkAttr "maxTime" value
  /// Min time acceptable time. For input validation date part of passed object will be ignored if `disableIgnoringDatePartForTimeValidation` not specified.
  static member inline minTime (value: 'T) = Interop.mkAttr "minTime" value
  /// Step over minutes.
  static member inline minutesStep (value: int) = Interop.mkAttr "minutesStep" value
  /// Step over minutes.
  static member inline minutesStep (value: float) = Interop.mkAttr "minutesStep" value
  /// Callback fired when date is accepted @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(value: TValue) => void`
  ///
  /// *value:* The value that was just accepted.
  static member inline onAccept (handler: 'TValue -> unit) = Interop.mkAttr "onAccept" handler
  /// Callback fired when the popup requests to be closed. Use in controlled mode (see open).
  static member inline onClose (handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback that fired when input value or new `value` prop validation returns **new** validation error (or value is valid after error). In case of validation error detected `reason` prop return non-null value and `TextField` must be displayed in `error` state. This can be used to render appropriate form error.
  ///
  /// [Read the guide](https://next.material-ui-pickers.dev/guides/forms) about form integration and error displaying.
  ///
  /// **Signature:**
  ///
  /// `function(reason: TError, value: TInputValue) => void`
  ///
  /// *reason:* The reason why the current value is not valid.
  ///
  /// *value:* The invalid value.
  static member inline onError (handler: 'TError -> 'TInputValue -> unit) = Interop.mkAttr "onError" (Func<_, _, _> handler)
  /// Callback fired when the popup requests to be opened. Use in controlled mode (see open).
  static member inline onOpen (handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Callback fired on view change.
  ///
  /// **Signature:**
  ///
  /// `function(view: ClockPickerView) => void`
  ///
  /// *view:* The new view.
  static member inline onViewChange (handler: ClockPickerView -> unit) = Interop.mkAttr "onViewChange" handler
  /// Control the popup or dialog open state.
  static member inline open' (value: bool) = Interop.mkAttr "open" value
  /// Props to pass to keyboard adornment button.
  static member inline OpenPickerButtonProps (props: IReactProperty list) = Interop.mkAttr "OpenPickerButtonProps" (createObj !!props)
  /// Paper props passed down to [Paper](https://mui.com/material-ui/api/paper/) component.
  static member inline PaperProps (props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Popper props passed down to [Popper](https://mui.com/material-ui/api/popper/) component.
  static member inline PopperProps (props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Make picker read only.
  static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
  /// Dynamically check if time is disabled or not. If returns `false` appropriate time point will ot be acceptable.
  ///
  /// **Signature:**
  ///
  /// `function(timeValue: number, clockType: ClockPickerView) => boolean`
  ///
  /// *timeValue:* The value to check.
  ///
  /// *clockType:* The clock type of the timeValue.
  ///
  /// *returns* (boolean): Returns `true` if the time should be disabled
  static member inline shouldDisableTime (shouldDisableTime: System.DateTime -> string -> bool) = Interop.mkAttr "shouldDisableTime" (Func<_, _, _> shouldDisableTime)
  /// If `true`, show the toolbar even in desktop mode.
  static member inline showToolbar (value: bool) = Interop.mkAttr "showToolbar" value
  /// Component that will replace default toolbar renderer.
  static member inline ToolbarComponent (value: ReactElementType) = Interop.mkAttr "ToolbarComponent" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: ReactElement) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: seq<ReactElement>) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: string) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (values: string seq) = Interop.mkAttr "toolbarTitle" values
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: int) = Interop.mkAttr "toolbarTitle" value
  /// Mobile picker title, displaying in the toolbar.
  static member inline toolbarTitle (value: float) = Interop.mkAttr "toolbarTitle" value
  /// Custom component for popper [Transition](https://mui.com/material-ui/transitions/#transitioncomponent-prop).
  static member inline TransitionComponent (value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The value of the picker.
  static member inline value (value: 'T) = Interop.mkAttr "value" value
  /// Array of views to show.
  static member inline views ([<ParamArray>] views: TimePickerView []) = Interop.mkAttr "views" views
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()

module timePicker =

  /// First view to show. Must be a valid option from `views` list
  [<Erase>]
  type openTo =
    static member inline hours = Interop.mkAttr "openTo" "hours"
    static member inline minutes = Interop.mkAttr "openTo" "minutes"
    static member inline seconds = Interop.mkAttr "openTo" "seconds"

  /// Force rendering in particular orientation.
  [<Erase>]
  type orientation =
    static member inline landscape = Interop.mkAttr "orientation" "landscape"
    static member inline portrait = Interop.mkAttr "orientation" "portrait"


[<Erase>]
type yearPicker =
  /// If `true` future days are disabled.
  static member inline disableFuture (value: bool) = Interop.mkAttr "disableFuture" value
  /// If `true`, today's date is rendering without highlighting with circle.
  static member inline disableHighlightToday (value: bool) = Interop.mkAttr "disableHighlightToday" value
  /// If `true` past days are disabled.
  static member inline disablePast (value: bool) = Interop.mkAttr "disablePast" value
  /// Maximal selectable date. @DateIOType
  static member inline maxDate (value: 'T) = Interop.mkAttr "maxDate" value
  /// Minimal selectable date. @DateIOType
  static member inline minDate (value: 'T) = Interop.mkAttr "minDate" value
  /// Disable specific years dynamically. Works like `shouldDisableDate` but for year selection view @DateIOType.
  ///
  /// **Signature:**
  ///
  /// `function(year: TDate) => boolean`
  ///
  /// *year:* The year to test.
  ///
  /// *returns* (boolean): Returns `true` if the year should be disabled.
  static member inline shouldDisableYear (shouldDisableYear: int -> bool) = Interop.mkAttr "shouldDisableYear" (Func<_, _> shouldDisableYear)
  /// This component does not support children.
  static member inline children  = UnsupportedProp ()
