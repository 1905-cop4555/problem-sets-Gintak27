

let _curry a = (fun x -> fun y -> a(x,y))

let curry f x y = f (x,y);;
