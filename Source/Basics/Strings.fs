module Basics.Basics.Strings

// slicing
let str = "Hello World"
let first = str[0..4]
let second = str[6..]

// interpolation
let expr = "Hello"
printfn " \"%s\" \\ World" expr
printfn $" \"{expr}\" \\ World!"
printfn $" \"%s{expr}\" \\ World!"
printf  $@" ""{expr}"" \ World!"
printfn $@" ""%s{expr}"" \ World!"
printfn $@" ""%s{expr}"" \ World!"
