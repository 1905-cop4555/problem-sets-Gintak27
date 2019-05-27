// Learn more about F# at http://fsharp.org

open System

let curry a = (fun x -> fun y -> a(x,y))



[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
