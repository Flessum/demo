
let branchA () = printfn "This is branch A."

let branchB () = printfn "This is branch B."

let branchX () = printfn "This is branch X."

let branchY () = printfn "This is branch Y."

[<EntryPoint>]
let main argv =
    printfn "%A" argv
    branchA ()
    branchB ()
    branchX ()
    branchY ()
    printfn "That's all."
    System.Console.ReadKey () |> ignore
    0 // return an integer exit code
