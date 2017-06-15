let rec toWords n = 
    match n with
    | 0 -> []
    | 1 -> ["one"]
    | 2 -> ["two"]
    | 3 -> ["three"]
    | 4 -> ["four"]
    | 5 -> ["five"]
    | 6 -> ["six"]
    | 7 -> ["seven"]
    | 8 -> ["eight"]
    | 9 -> ["nine"]
    | 10 -> ["ten"]
    | 11 -> ["eleven"]
    | 12 -> ["twelve"]
    | 13 -> ["thirteen"]
    | 14 -> ["fourteen"]
    | 15 -> ["fifteen"]
    | 16 -> ["sixteen"]
    | 17 -> ["seventeen"]
    | 18 -> ["eighteen"]
    | 19 -> ["nineteen"]
    | x when x / 10 = 2 -> "twenty"::toWords (x % 10)
    | x when x / 10 = 3 -> "thirty"::toWords (x % 10)
    | x when x / 10 = 4 -> "forty"::toWords (x % 10)
    | x when x / 10 = 5 -> "fifty"::toWords (x % 10)
    | x when x / 10 = 6 -> "sixty"::toWords (x % 10)
    | x when x / 10 = 7 -> "seventy"::toWords (x % 10)
    | x when x / 10 = 8 -> "eighty"::toWords (x % 10)
    | x when x / 10 = 9 -> "ninety"::toWords (x % 10)
    | x when x >= 1000 -> toWords (x / 1000)@["thousand"]
    | x when x >= 100 ->
        let hundreds = toWords (x / 100)@["hundred"]
        let rest = toWords (x % 100)
        if rest.Length > 0 then hundreds@["and"]@rest else hundreds

[1..1000]
|> List.map toWords
|> List.concat
|> List.sumBy String.length
|> printfn "%i"
