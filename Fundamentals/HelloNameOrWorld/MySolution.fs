let fixHello (s: string) : string =
  sprintf "Hello, %s%s!" (s.[0..0].ToString().ToUpper()) (s.[1..].ToLower())

let hello (s: string) : string =
    match s with
    | "" -> "Hello, World!"
    | _ -> fixHello s
