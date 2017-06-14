let explode (s:string) =
    [for c in s -> c]

let inline charToInt c = int c - int '0'

pown 2I 1000
    |> string
    |> explode
    |> List.map charToInt
    |> List.sum
