// Learn more about F# at http://fsharp.org

open System


let succ n: int = 
    let z = n

    

[<EntryPoint>]
let main argv =

    let y = succ 4
    printfn "%d" y

    let inp = System.Console.ReadLine()
    0 // return an integer exit code



