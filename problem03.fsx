let rec nextFactor (x:bigint) (n:bigint) = 
    if x % n = 0I then n else nextFactor x (n + 1I)

let rec factors (x:bigint) =
    let f = nextFactor x 2I
    let otherFactors = if f = x then [] else factors (x / f)
    f::otherFactors

printfn "%A" (factors 600851475143I)
