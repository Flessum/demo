
let branchA () = printfn "This is branch A."

let branchB () = printfn "This is branch B."

[<EntryPoint>]
let main argv =
    printfn "%A" argv
    branchA ()
    branchB ()
    System.Console.ReadKey () |> ignore
    0 // return an integer exit code
