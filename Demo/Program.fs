
let branchB () = printfn "This is branchB."

[<EntryPoint>]
let main argv =
    branchB ()
    printfn "%A" argv
    System.Console.ReadKey () |> ignore
    0 // return an integer exit code
