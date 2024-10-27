let sumArray (array: Option<list<int>>) = 
    match array with
    | Some a when List.length a > 1 -> 
        List.sum a - (List.min a + List.max a)
    | _ -> 0
