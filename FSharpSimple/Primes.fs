module PrimesLib

open Microsoft.FSharp.Collections

let odds =
    let limit = System.Int32.MaxValue |> float |> sqrt |> int
    [3..2..limit]

let isPrime n = // naïve implementation
    2::odds |> Seq.forall (fun x -> n%x <> 0 || n=x)