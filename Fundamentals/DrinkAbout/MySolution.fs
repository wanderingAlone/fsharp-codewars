let peopleWithAgeDrink old =
    match old with
    | _ when old < 14 -> "drink toddy"
    | _ when old < 18 -> "drink coke"
    | _ when old < 21 -> "drink beer"
    | _ -> "drink whisky"
