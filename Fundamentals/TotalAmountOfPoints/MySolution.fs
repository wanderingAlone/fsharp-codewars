module Kata

let splitMatch (r: string) : int =
    match r.Split(':') with
    | [| x; y |] when int x > int y -> 3
    | [| x; y |] when int x = int y -> 1
    | _ -> 0

let points (games: list<string>) : int =
    List.sumBy splitMatch games
