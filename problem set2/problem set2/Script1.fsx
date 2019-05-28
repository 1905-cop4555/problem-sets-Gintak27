

let _curry a = (fun x -> fun y -> a(x,y))

let curry f x y = f (x,y);;

let uncurry a = (fun (x,y) -> a x y)
let _uncurry f (x,y) = f x y