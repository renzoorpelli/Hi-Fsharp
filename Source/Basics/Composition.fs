module Basics.Basics.Composition

// Composition operator `>>` is used to compose functions
let addTwoSubtractTwoNegateAndPrint' =
    Functions.add 2 >> 
    Functions.subtract 2 >> 
    Functions.negate >> 
    Functions.print