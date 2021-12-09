[<AutoOpen>]
module common3

#load "../common.fsx"

open System

let parseDiagnostic (raw : string) = 
    readLines raw
    |> Seq.map (fun s -> Convert.ToInt32 (s, 2))
    |> Array.ofSeq