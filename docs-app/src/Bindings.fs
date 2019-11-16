namespace Feliz.ReactHighlight

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type Highlight =
  static member inline highlight (props: IReactProperty list) =
    Interop.reactApi.createElement(importDefault "react-highlight", createObj !!props)



namespace Feliz.Markdown

open Feliz

type ITextProperties =
  abstract children: string

type IParagraphProperties =
  abstract children: ReactElement []

type ILinkProperties =
  abstract href: string
  abstract children: ReactElement []

type IHeadingProperties =
  abstract level: int
  abstract children: ReactElement []

module markdown =

  type renderers =

    static member inline text (render: ITextProperties -> Fable.React.ReactElement) =
      unbox<IMarkdownRenderer> (Interop.mkAttr "text" render)

    static member inline paragraph (render: IParagraphProperties -> Fable.React.ReactElement) =
      unbox<IMarkdownRenderer> (Interop.mkAttr "paragraph" render)

    static member inline link (render: ILinkProperties -> Fable.React.ReactElement) =
      unbox<IMarkdownRenderer> (Interop.mkAttr "link" render)

    static member inline heading (render: IHeadingProperties -> Fable.React.ReactElement) =
      unbox<IMarkdownRenderer> (Interop.mkAttr "heading" render)
