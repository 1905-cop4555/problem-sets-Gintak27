// Learn more about F# at http://fsharp.org

open System

let rec func x =  
    match x  with
         |0 -> 0I
         |1 -> 1I
         |x -> func(x-1) + func(x-2)
    
    

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let y = func 4
    
    0 // return an integer exit code
