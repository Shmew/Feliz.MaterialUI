// ts2fable 0.7.1
module rec Feliz.MaterialUI.PopupState.Bindings

open System
open Fable
open Fable.Core
open Browser.Types
open Feliz
open Fable.React


module Core =
    type SyntheticEvent = Browser.Types.Event
    type MouseEvent = Browser.Types.MouseEvent
    type TouchEvent = Browser.Types.TouchEvent
    type FocusEvent = Browser.Types.FocusEvent

    type [<AllowNullLiteral>] IExports =
        abstract initCoreState: CoreState
        abstract createPopupState: options: CreatePopupStateOptions -> PopupState
        /// <summary>Creates a ref that sets the anchorEl for the popup.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract anchorRef: popupState: PopupState -> ('T option -> unit)
        /// <summary>Creates props for a component that opens the popup when clicked.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindTrigger: popupState: PopupState -> obj
        /// <summary>Creates props for a component that toggles the popup when clicked.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindToggle: popupState: PopupState -> obj
        /// <summary>Creates props for a component that opens the popup on its contextmenu event (right click).</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindContextMenu: popupState: PopupState -> obj
        /// <summary>Creates props for a component that opens the popup while hovered.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindHover: popupState: PopupState -> obj
        /// <summary>Creates props for a component that opens the popup while focused.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindFocus: popupState: PopupState -> obj
        /// <summary>Creates props for a component that opens the popup while double click.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindDoubleClick: popupState: PopupState -> BindDoubleClickReturn
        /// <summary>Creates props for a `Popover` component.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindPopover: popupState: PopupState -> BindPopoverReturn
        /// <summary>Creates props for a `Menu` component.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindMenu: popupState: PopupState -> BindMenuReturn
        /// <summary>Creates props for a `Popper` component.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindPopper: popupState: PopupState -> BindPopperReturn
        /// <summary>Creates props for a `Dialog` component.</summary>
        /// <param name="popupState">the argument passed to the child function of
        /// `PopupState`</param>
        abstract bindDialog: popupState: PopupState -> BindDialogReturn

    type [<AllowNullLiteral>] CreatePopupStateOptions =
        abstract state: CoreState with get, set
        abstract setState: (CoreState -> unit) with get, set
        abstract popupId: string option with get, set
        abstract variant: Variant with get, set
        abstract parentPopupState: PopupState option with get, set
        abstract disableAutoFocus: bool option with get, set

    type [<AllowNullLiteral>] BindDoubleClickReturn =
        abstract ``aria-controls``: string option with get, set
        abstract ``aria-describedby``: string option with get, set
        abstract ``aria-haspopup``: obj with get, set
        abstract onDoubleClick: (SyntheticEvent -> obj option) with get, set

    type [<AllowNullLiteral>] BindPopoverReturn =
        abstract id: string option with get, set
        abstract anchorEl: HTMLElement option with get, set
        abstract anchorPosition: AnchorPosition option with get, set
        abstract anchorReference: BindPopoverReturnAnchorReference with get, set
        abstract ``open``: bool with get, set
        abstract onClose: (unit -> unit) with get, set
        abstract onMouseLeave: (MouseEvent -> unit) with get, set
        abstract disableAutoFocus: bool option with get, set
        abstract disableEnforceFocus: bool option with get, set
        abstract disableRestoreFocus: bool option with get, set

    type [<AllowNullLiteral>] BindMenuReturn =
        abstract id: string option with get, set
        abstract anchorEl: HTMLElement option with get, set
        abstract anchorPosition: AnchorPosition option with get, set
        abstract anchorReference: BindPopoverReturnAnchorReference with get, set
        abstract ``open``: bool with get, set
        abstract onClose: (unit -> unit) with get, set
        abstract onMouseLeave: (MouseEvent -> unit) with get, set
        abstract autoFocus: bool option with get, set
        abstract disableAutoFocusItem: bool option with get, set
        abstract disableAutoFocus: bool option with get, set
        abstract disableEnforceFocus: bool option with get, set
        abstract disableRestoreFocus: bool option with get, set

    type [<AllowNullLiteral>] BindPopperReturn =
        abstract id: string option with get, set
        abstract anchorEl: HTMLElement option with get, set
        abstract ``open``: bool with get, set
        abstract onMouseLeave: (MouseEvent -> unit) with get, set

    type [<AllowNullLiteral>] BindDialogReturn =
        abstract ``open``: bool with get, set
        abstract onClose: (SyntheticEvent -> unit) with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] Variant =
        | Popover
        | Popper
        | Dialog

    type [<AllowNullLiteral>] AnchorPosition =
        abstract top: float with get, set
        abstract left: float with get, set

    type [<AllowNullLiteral>] PopupState =
        abstract ``open``: (U2<SyntheticEvent, HTMLElement> -> unit) with get, set
        abstract close: (unit -> unit) with get, set
        abstract toggle: (U2<SyntheticEvent, HTMLElement> -> unit) with get, set
        abstract onMouseLeave: (MouseEvent -> unit) with get, set
        abstract setOpen: (bool -> U2<SyntheticEvent, HTMLElement> -> unit) with get, set
        abstract isOpen: bool with get, set
        abstract anchorEl: HTMLElement option with get, set
        abstract anchorPosition: AnchorPosition option with get, set
        abstract setAnchorEl: (HTMLElement -> obj option) with get, set
        abstract setAnchorElUsed: bool with get, set
        abstract disableAutoFocus: bool with get, set
        abstract popupId: string option with get, set
        abstract variant: Variant with get, set
        abstract _openEventType: string option with get, set
        abstract _childPopupState: PopupState option with get, set
        abstract _setChildPopupState: (PopupState option -> unit) with get, set

    type [<AllowNullLiteral>] CoreState =
        abstract isOpen: bool with get, set
        abstract setAnchorElUsed: bool with get, set
        abstract anchorEl: HTMLElement option with get, set
        abstract anchorPosition: AnchorPosition option with get, set
        abstract hovered: bool with get, set
        abstract _openEventType: string option with get, set
        abstract _childPopupState: PopupState option with get, set
        abstract _deferNextOpen: bool with get, set
        abstract _deferNextClose: bool with get, set

    type [<AllowNullLiteral>] ControlAriaProps =
        abstract ``aria-controls``: string option with get, set
        abstract ``aria-describedby``: string option with get, set
        abstract ``aria-haspopup``: obj option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] BindPopoverReturnAnchorReference =
        | AnchorEl
        | AnchorPosition

module Hooks =

    type Variant = Core.Variant
    type PopupState = Core.PopupState

    type [<AllowNullLiteral>] IExports =
        abstract usePopupState: options: UsePopupStateOptions -> PopupState

    type [<AllowNullLiteral>] UsePopupStateOptions =
        abstract parentPopupState: PopupState option with get, set
        abstract popupId: string option with get, set
        abstract variant: Variant with get, set
        abstract disableAutoFocus: bool option with get, set

module HoverMenu =
    type MenuProps = JS.Object

    type [<AllowNullLiteral>] IExports =
        abstract HoverMenu: Fable.React.ReactElementType<MenuProps>

module HoverPopover =
    type PopoverProps = JS.Object

    type [<AllowNullLiteral>] IExports =
        abstract HoverPopover: Fable.React.ReactElementType<PopoverProps>

module HoverWorkaround =

    type PropInjector<'InjectedProps> = ReactElementType<'InjectedProps> -> ReactElementType
    type CSSProperties = JS.Object

    type [<AllowNullLiteral>] IExports =
        abstract hoverWorkaround: PropInjector<IExportsHoverWorkaroundPropInjector>

    type [<AllowNullLiteral>] IExportsHoverWorkaroundPropInjectorPaperProps =
        abstract style: CSSProperties with get, set

    type [<AllowNullLiteral>] IExportsHoverWorkaroundPropInjector =
        abstract ref: Ref<obj option> with get, set
        abstract style: CSSProperties with get, set
        abstract PaperProps: IExportsHoverWorkaroundPropInjectorPaperProps with get, set

module Index =

    type [<AllowNullLiteral>] IExports =
        abstract PopupState: ReactElementType<Props>

    type [<AllowNullLiteral>] Props =
        abstract popupId: string option with get, set
        abstract children: (Core.PopupState -> ReactElement option) with get, set
        abstract variant: Core.Variant with get, set
        abstract parentPopupState: Core.PopupState option with get, set
        abstract disableAutoFocus: bool option with get, set
