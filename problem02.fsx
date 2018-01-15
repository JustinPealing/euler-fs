let rec fibonacci a b =
    a::(if b < 4000000 then fibonacci b (a + b) else [])

printfn "%A" (fibonacci 1 2)
printfn "Sum: %i" (fibonacci 1 2 |> List.filter (fun x -> x % 2 = 0) |> List.sum)
