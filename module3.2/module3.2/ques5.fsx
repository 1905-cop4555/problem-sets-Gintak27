let rec interleave = function
  | ([],[]) -> []
  | (x::xs, y::ys) -> x::y::(interleave (xs,ys));; 


 let rec interleaveAux acc = function
 | ([],[]) -> acc
 | (x::xs,y::ys) -> let acc = x::y::acc
                    interleaveAux acc (xs,ys)
