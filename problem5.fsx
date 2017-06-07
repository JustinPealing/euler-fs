let isDivisibleByAllNumbersUpto20 x =
    [1..20] |> List.forall (fun n -> x % n = 0)

let result =
    Seq.initInfinite (fun x -> x + 1)
    |> Seq.map ((*) 20)
    |> Seq.filter isDivisibleByAllNumbersUpto20
    |> Seq.head

printfn "%i" result
