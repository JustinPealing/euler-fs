let divisors n = 
    [1..n-1] |> List.filter (fun x -> n % x = 0)

let d n =
    divisors n |> List.sum

let isAmicable a =
    let b = d a
    b <> a && d b = a

[1..9999] |> List.filter isAmicable |> List.sum |> printfn "%i"
