// Learn more about F# at http://fsharp.org

open System


let times n y = n*y

let mk_expon times one =
    let rec expon x n =
        if n = 0 then one 
        elif n%2 = expon (times x x) (n/2)
        else times x (expon x (n-1)) 
     expon 

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
