namespace Source.Basics
    
module PatternMatching =
    // Shape
    type Shape =
    | Square of side : double
    | Rectangle of width : double * length : double
    let getArea shape =
        match shape with
        | Square side -> side * side
        | Rectangle (width, length) -> width * length
    
    // Arithmetic Expression evaluator  
    type Expr =
        | Num of int
        | Add of Expr * Expr
        | Subtract of Expr * Expr
        | Multiply of Expr * Expr
        | Divide of Expr * Expr
        
    let rec evaluate expr =
        match expr with
        | Num n -> n
        | Add (left, right) ->
            let leftValue = evaluate left
            let rightValue = evaluate right
            leftValue + rightValue
        | Subtract (left, right) ->
            let leftValue = evaluate left
            let rightValue = evaluate right
            leftValue - rightValue
        | Multiply (left, right) ->
            let leftValue = evaluate left
            let rightValue = evaluate right
            leftValue * rightValue
        | Divide (left, right) ->
            let leftValue = evaluate left
            let rightValue = evaluate right
            leftValue / rightValue
            
    // Day Match
    type DayOfWeek =
        | Monday
        | Tuesday
        | Wednesday
        | Thursday
        | Friday
        | Saturday
        | Sunday
        
    let isWeekend day =
        match day with
        | Saturday | Sunday -> true
        | _ -> false
        
    // Destructure first two elements from a list
    let describeList lst =
        match lst with
        | [] -> "Empty list"
        | [x] -> $"Single element {x}"
        | x :: y :: _ -> $"First {x}, Second{y}"
        
    // Sum nested List
    type NestedList =
        | Single of int
        | List of NestedList list
    let rec sumNestedList nestedList =
        match nestedList with
        | Single n -> n
        | List lst->
            lst
            |> List.map sumNestedList
            |> List.sum
        
    