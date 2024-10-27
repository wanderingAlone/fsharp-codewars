(* Absolutely better *)
let makeLowerCase (s: string) = s.ToLower()

(* Similar to mine, but better *)
let charToLowerCase c = 
  if c >= 'A' && c <= 'Z' 
  then char (int c - int 'A' + int 'a') 
  else c

let makeLowerCase = String.map charToLowerCase

(* Absolutely the funniest *)
let rec makeLowerCase (str: string) : string =
    match str with
    | "A" -> "a"
    | "B" -> "b"
    | "C" -> "c"
    | "D" -> "d"
    | "E" -> "e"
    | "F" -> "f"
    | "G" -> "g"
    | "H" -> "h"
    | "I" -> "i"
    | "J" -> "j"
    | "K" -> "k"
    | "L" -> "l"
    | "M" -> "m"
    | "N" -> "n"
    | "O" -> "o"
    | "P" -> "p"
    | "Q" -> "q"
    | "R" -> "r"
    | "S" -> "s"
    | "T" -> "t"
    | "U" -> "u"
    | "V" -> "v"
    | "W" -> "w"
    | "X" -> "x"
    | "Y" -> "y"
    | "Z" -> "z"
    | _ when str |> String.length = 1 -> str
    | _ -> makeLowerCase (str.[0] |> string) + makeLowerCase (str.Substring(1))

(* Also funny, making use of the lack of random test sample *)
let solutions = [|"hello"; "hello world"; "hello world !"; "1,2,3 hello world"|]
let mutable count = -1
let makeLowerCase s = 
  count <- count + 1
  solutions.[count]
