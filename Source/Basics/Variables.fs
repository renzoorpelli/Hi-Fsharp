module Source.Basics.Variables

(* This is a block comment *)
let result = 1+1= 2

// strings
let hello = "Hello" + " World"
let verbatimXml = @"<img alt=""this is a cat"">"

// types
let stringValue = "my string"
let intValue = 10
let explicitTypedInt: int = 10
let mutable mutableInt = 10

mutableInt <- 11 // <- assign a new value

// hex, octal or binary
let numbers = (0x9F, 0o77, 0b1010) // (159, 63, 10)
let ( sbyte, byte   )  = ( 55y, 55uy )  // 8-bit integer
let ( short, ushort )  = ( 50s, 50us )  // 16-bit integer
let ( int,   uint   )  = ( 50,  50u  )  // 32-bit integer
let ( long,  ulong  )  = ( 50L, 50uL )  // 64-bit integer
let bigInt = 9999999999999I // System.Numerics.BigInteger
let float = 50.0f // signed 32-bit float
let double = 50.0 // signed 64-bit float
let scientific = 2.3E+32   // signed 64-bit float
let decimal = 50.0m       // signed 128-bit decimal
let bytes= 'a'B          // ascii character; 97uy
let byteArray = "text"B // ascii string; [|116uy; 101uy; 120uy; 116uy|]


// primes, idiomatic to functional languages that indicate to the developer a variation of an existing value or function
let x = 5
let x' = x + 1
let x'' = x' + 2