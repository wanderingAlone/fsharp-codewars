let oneOrZero y =
    match y with
    | _ when y < '5' -> '0'
    | _ -> '1'

let fakeBin x =
    x |> Seq.map oneOrZero |> System.String.Concat
