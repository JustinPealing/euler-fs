let isPrime p =
    [2..(p/2)] |> Seq.forall (fun x -> p % x <> 0)

Seq.initInfinite ((+) 2)
    |> Seq.filter isPrime
    |> Seq.item 10000
    |> printfn "%A"
