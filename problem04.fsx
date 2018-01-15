let reverse (s:string) =
    new string(Array.rev(s.ToCharArray()))

let isPalindrome n =
    let s = string n
    s = reverse s

let numbers = 
    [for x in 1..999 do
     for y in 1..999 do
     yield x * y]

let result = numbers |> List.filter isPalindrome |> List.max

printfn "%i" result
