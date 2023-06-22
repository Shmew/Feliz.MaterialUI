# Feliz.MaterialUI

Feliz.MaterialUI provides [Feliz](https://github.com/Zaid-Ajaj/Feliz)-style Fable bindings for [MUI (aka Material-UI](https://mui.com/)).

Read the MUI documentation
-----------------

The [official MUI documentation](https://mui.com/material-ui/getting-started/overview/) is the best resource for understanding and learning the MUI components. The Feliz.MaterialUI documentation will focus on documenting how the bindings work, not how to use every prop of every component.

Versioning strategy
--------------

The official MUI docs, which are the basis for the Feliz.MaterialUI bindings, often contain fixes and improvements that result in breaking changes in Feliz.MaterialUI, even though the documentation changes may not correspond to a major release (or any release at all) of `@mui/material`.

I am therefore unsure as to the optimal versioning strategy for Feliz.MaterialUI. For now, I will use my best judgement for each update. Minor updates may contain slight breaking changes. I will try to document all breaking changes (and a migration path) in the release notes.

If you have strong opinions on this and disagree with my approach, feel free to get in touch on GitHub.

Note that all components from `@mui/lab` are experimental, and there will be frequent breaking changes to these parts of the bindings (primarily resulting from breaking changes in the components themselves). The major version will never be incremented for breaking changes to these experimental bindings.

Feedback welcome!
-----------------

If you have suggestions or feedback, please [open an issue on GitHub](https://github.com/ArtemyB/Feliz.MaterialUI/issues)!
