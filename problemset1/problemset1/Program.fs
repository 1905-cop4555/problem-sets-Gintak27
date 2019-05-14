// Learn more about F# at http://fsharp.org

open System


let succ n = n +1

   
[<EntryPoint>]
let main argv =

    let y = succ 4
    printfn "%d" 5

    let inp = System.Console.ReadLine()
    0 // return an integer exit code
     


