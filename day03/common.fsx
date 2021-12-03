[<AutoOpen>]
module common

open System

let parseDiagnostic (raw : string) = 
    raw.Split([|'\n'; '\r'|], StringSplitOptions.RemoveEmptyEntries) 
    |> Array.map (fun s -> Convert.ToInt32 (s, 2))