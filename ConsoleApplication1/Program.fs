// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open PrimesLib

//odds |> printfn "Odds: %A"
odds |> (fun o -> printfn "Odds (there are %i of these) first item is %i and the last is %i: %A" o.Length (o.Item 0) (o.Item (o.Length - 1)) o)

[2..20] |> List.filter isPrime |> printfn "%A"

System.Console.ReadKey() |> ignore 