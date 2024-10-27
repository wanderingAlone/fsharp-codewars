let isUpperCase (c: char) =
    c >= 'A' && c <= 'Z'

let toLowerCase (c: char) =
    match c with
    | _ when isUpperCase c -> char (int c + 32)
    | _ -> c

let makeLowerCase (s: string) =
    s |> Seq.map toLowerCase |> Seq.toArray |> System.String
