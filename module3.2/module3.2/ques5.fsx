let rec interleave = function
  | ([],[]) -> []
  | (x::xs, y::ys) -> x::y::(interleave (xs,ys));; 


 let rec interleaveAux acc = function
 | ([],[]) -> acc
 | (x::xs,y::ys) -> let acc = x::y::acc
                    interleaveAux acc (xs,ys)

 let interleaveTail l1 l2 =
  let acc = []
  interleaveAux acc (l1,l2)

 let noTailResults = interleave ([0..1000],[0..1000]);;