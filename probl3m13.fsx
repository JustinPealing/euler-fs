let sum =
    System.IO.File.ReadAllLines "problem13.txt"
    |> Array.sumBy bigint.Parse

(string sum).[0..9]
