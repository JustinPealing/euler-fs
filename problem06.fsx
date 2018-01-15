let sumSquares a =
    a |> List.sumBy (fun x -> x * x)

let squareSums a =
    let sum = a |> List.sum
    sum * sum

let result = squareSums [1..100] - sumSquares [1..100]

printfn "%i" result