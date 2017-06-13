let factors n = [
    for i in 1..(int (sqrt (float n))) do
        if n % i = 0 then
            yield i
            if i <> n / i then yield n / i
]        

let triangleNumbers = 
    Seq.unfold (fun (i, n) -> Some (n, (i+1, n+i))) (2, 1)

triangleNumbers
    |> Seq.find (fun x -> (factors x).Length > 500)
