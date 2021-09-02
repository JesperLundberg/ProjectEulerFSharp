module Problem1

let isMultipleOf3or5 x =
    if x % 3 = 0 || x % 5 = 0
    then Some(x)
    else None
    
let printer x =
    printfn $"%d{x}"

let run1() =
    printfn "Problem1"
    let result =
        seq [1..1000]
        |> Seq.choose isMultipleOf3or5
        |> Seq.takeWhile (fun elem -> elem < 1000)
        |> Seq.sum
        |> printer
    0