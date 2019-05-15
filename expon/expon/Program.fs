// Learn more about F# at http://fsharp.org

open System


let times n y = n*y

let one = 1



let mk_expon times one =
    let rec expon n x =
        match n with 
        |n=0 -> one 

        if n = 0 then one 
        elif n%2 = 0 then expon (times x x) (n/2)
        else times x (expon x (n-1))
    expon 


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
