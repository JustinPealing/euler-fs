type P = {a:int; b:int; c:int}

let sq x = x * x

let items = 
    [1..998] |> Seq.collect (fun a ->
        [(a + 1)..998] |> Seq.collect (fun b ->
            [(b + 1)..998] |> Seq.map (fun c ->
                {a=a; b=b; c=c})))

let result = items |> Seq.find (fun p -> sq p.a + sq p.b = sq p.c && p.a + p.b + p.c = 1000 )

printfn "%A" result
printfn "%i" (result.a * result.b * result.c)
