let rec leq = function
    | ([],    ys)    -> true
    | (xs,    [])    -> false
    | (x::xs, y::ys) -> x < y || (x=y && leq (xs, ys));;
