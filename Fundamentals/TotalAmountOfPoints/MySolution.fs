module Kata

let points (games: list<string>) : int =
    games
    |> List.sumBy (fun r ->
        let [| x; y |] = r.Split(':') |> Array.map int
        match x, y with
        | _ when x > y -> 3
        | _ when x = y -> 1
        | _ -> 0
    )
