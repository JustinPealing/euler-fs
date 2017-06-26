let charToInt c = int c - int '0'

let rec factorial (n:bigint) = 
    if n = 1I then 1I else n * factorial (n - 1I)

let s = factorial 100I |> string
s.ToCharArray() |> Array.map charToInt |> Array.sum |> printfn "%s"
