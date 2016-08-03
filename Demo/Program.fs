
let branchA () = printfn "This is branch A."

let branchB () = printfn "This is branch B."

let branchX () = printfn "This is branch X."

[<EntryPoint>]
let main argv =
    printfn "%A" argv
    branchA ()
    branchB ()
    branchX ()
    System.Console.ReadKey () |> ignore
    0 // return an integer exit code
