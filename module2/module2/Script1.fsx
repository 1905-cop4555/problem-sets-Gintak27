
let rec split = function
    | [] -> ([],[])
    | [x] -> ([x],[])
    | x::y::zs -> let (M,N) = split  zs
                  (x::M, y::N);;
