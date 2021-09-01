module Problem1

let isMultipleOf3or5 x =
    if x % 3 = 0 || x % 5 = 0 then true
    else false
    
let printer x =
    printfn $"%d{x}"
    
let filter =
        List.filter isMultipleOf3or5

let run1() =
    printfn "Problem1"
    let result = filter [1..999]
    let answer = List.sum result |> printer
    0