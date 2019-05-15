

// playing around in interactive 
let x = 2 + 4
let y = x;;
val x : int = 6
val y : int = 6


let times x y = x*y
let z = (times 2 4) + 4;;
val times : x:int -> y:int -> int
val z : int = 12


> let cossq r = 
     let c = cos r
     c*c;;
val cossq : r:float -> float

> let cossq r = 
     let c = cos r * cos r ;;

       let c = cos r * cos r ;;