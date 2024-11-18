module Basics.Basics.Pipelines

// Pipe operator `|>` is used to chain functions and arguments together
let addTowSubtractTwoNegateAndPrint num =
    num |> Functions.add 2
        |> Functions.subtract 2
        |> Functions.negate
        |> Functions.print

