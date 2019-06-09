let rec interleave = function
  | ([],[]) -> []
  | (x::xs, y::ys) -> x::y::(interleave (xs,ys));; 
