
let branchA () = printfn "This is branch A."

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    branchA ()
    System.Console.ReadKey () |> ignore
    0 // return an integer exit code
