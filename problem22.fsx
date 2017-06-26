open System
open System.IO

let readNames path =
    let text = File.ReadAllText path
    text.Replace("\"", "").Split(',')

let sortedNames = 
    readNames "problem22.txt"
    |> Array.sort

let nameScore (name:string) = 
    name.ToCharArray() |> Array.map (fun x -> 1 + int x - int 'A') |> Array.sum

let scores = [for i in [0..(sortedNames.Length - 1)] do
    yield (i + 1) * nameScore sortedNames.[i]
]
scores |> List.sum |> printfn "%i"
