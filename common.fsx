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