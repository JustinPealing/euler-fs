open System.IO
open System.Linq

let loadGrid path = 
    let parseLine (line:string) = 
        line.Split() |> Array.map int    
    File.ReadLines(path).ToArray() |> Array.map parseLine |> array2D

let grid = loadGrid "problem11.txt"

let maxX = 
    [for y in [1..19] do
        for x in [1..16] do
            yield grid.[y,x] * grid.[y,x+1] * grid.[y,x+2] * grid.[y,x+3] ]
    |> List.max

let maxY = 
    [for x in [1..19] do
        for y in [1..16] do
            yield grid.[y,x] * grid.[y+1,x] * grid.[y+2,x] * grid.[y+3,x] ]
    |> List.max

let maxDiag1 = 
    [for x in [1..16] do
        for y in [1..16] do
            yield grid.[y,x] * grid.[y+1,x+1] * grid.[y+2,x+2] * grid.[y+3,x+3] ]
    |> List.max

let maxDiag2 = 
    [for x in [1..16] do
        for y in [1..16] do
            yield grid.[y+3,x] * grid.[y+2,x+1] * grid.[y+1,x+2] * grid.[y,x+3] ]
    |> List.max

[maxX; maxY; maxDiag1; maxDiag2] |> List.max |> printfn "%i"
