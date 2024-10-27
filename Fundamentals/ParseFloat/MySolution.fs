let parseFloat s =
    match System.Double.TryParse(s) with
    | true, v -> Some v
    | _ -> None
