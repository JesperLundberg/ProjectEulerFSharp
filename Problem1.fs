module Problem1

let isMultipleOf3 x =
    x % 3 = 0

let isMultipleOf5 x =
    x % 5 = 0
    
let printer x =
    printfn $"{x}"
    
let filterThrees =
        List.filter isMultipleOf3
        
let filterFives =
        List.filter isMultipleOf5

let run1() =
    printfn "Problem1"
    let result = (filterThrees [1..999] @ filterFives [1..999])
    let cleanResult = List.distinct result
    let answer = List.sum cleanResult |> printer
    0