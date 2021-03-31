# Feliz.MaterialUI

Feliz.MaterialUI provides [Feliz](https://github.com/Zaid-Ajaj/Feliz)-style Fable bindings for [Material-UI](https://material-ui.com/).

Read the MUI docs
-----------------

The [official Material-UI docs](https://material-ui.com/) are the best resource for understanding and learning the Material-UI components. The Feliz.MaterialUI documentation will focus on documenting how the bindings work, not how to use every prop of every component.

Versioning strategy
--------------

The official Material-UI docs, which are the basis for the Feliz.MaterialUI bindings, often contain fixes and improvements that result in breaking changes in Feliz.MaterialUI, even though the documentation changes may not correspond to a major release (or any release at all) of `@material-ui/core`.

I am therefore unsure as to the optimal versioning strategy for Feliz.MaterialUI. For now, I will use my best judgement for each update. Minor updates may contain slight breaking changes. I will try to document all breaking changes (and a migration path) in the release notes.

If you have strong opinions on this and disagree with my approach, feel free to get in touch on GitHub.

Note that all components from `@material-ui/lab` are experimental, and there will be frequent breaking changes to these parts of the bindings (primarily resulting from breaking changes in the components themselves). The major version will never be incremented for breaking changes to these experimental bindings.

Feedback welcome!
-----------------

If you have suggestions or feedback, please [open an issue on GitHub](https://github.com/Shmew/Feliz.MaterialUI/issues)!
