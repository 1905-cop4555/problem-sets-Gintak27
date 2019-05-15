// Learn more about F# at http://fsharp.org

open System


let times n y = n*y

let one = 1



let mk_expon times one =
  let rec expon n x =
    match n with 
    |0 -> one 
    |n when n%2 = 0 -> (times x x) (n/2)
    |n -> (times x (expon x (n-1))
  expon
     


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
