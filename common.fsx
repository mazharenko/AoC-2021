[<AutoOpen>]
module common

module String =
    let fromArray (ar:char[]) = 
        new string(ar)
        
module Array2D =
    let toArray (source: 'T[,]) =
        source |> Seq.cast<'T> |> Seq.toArray
    
let displayPipe x =
    x |> display |> ignore
    x

let splitToTuple2 (separators : string array) (s : string) =
    let split = s.Split(separators, StringSplitOptions.RemoveEmptyEntries)
    split[0], split[1]