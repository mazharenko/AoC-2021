[<AutoOpen>]
module common

module String =
    let fromArray (ar:char[]) = 
        new string(ar)
        
module Array2D =
    let toArray (source: 'T[,]) =
        source |> Seq.cast<'T> |> Seq.toArray
    
let readLines (input: string): string[] =
    input.Split([|'\n'; '\r'|], StringSplitOptions.RemoveEmptyEntries) 

let read2d (input: string) =
    let lines = readLines input |> Array.ofSeq
    array2D lines

let displayPipe x =
    x |> display |> ignore
    x

let splitToTuple2 (separators : string array) (s : string) =
    let split = s.Split(separators, StringSplitOptions.RemoveEmptyEntries)
    split[0], split[1]