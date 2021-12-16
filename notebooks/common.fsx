[<AutoOpen>]
module common

module String =
    let fromArray (ar:char[]) = 
        new string(ar)

module Result =
    let failIfError =
        function 
        | Ok x -> x
        | Error error -> failwith (error.ToString())
        
module Array2D =
    let toArray (source: 'T[,]) =
        source |> Seq.cast<'T> |> Seq.toArray
    let toJagged (source: 'T[,]) = 
        [|
            for i in (Array2D.base1 source)..(Array2D.length1 source - 1) do
                yield [|
                    for j in (Array2D.base2 source)..(Array2D.length2 source - 1) do
                        yield source.[i,j]
            |]
        |]
    let tryGet i j source =
        if (i >= Array2D.base1 source 
            && j >= Array2D.base2 source 
            && i < Array2D.length1 source 
            && j < Array2D.length2 source)
        then Some source.[i,j]
        else None

module Seq = 
    open System.Collections.Generic
    
    let group keySelector valueSelector source = 
        source |> Seq.groupBy keySelector 
        |> Seq.map (fun (key, entries) -> key, valueSelector entries)
        
    let takeUntil predicate (s:seq<_>) = 
        let rec loop (en:IEnumerator<_>) = seq {
            if en.MoveNext() then
              yield en.Current
              if not (predicate en.Current) then
                yield! loop en }
        seq { use en = s.GetEnumerator()
            yield! loop en }

module Array = 
    let median (source: 'a[]) =
        (Array.sort source).[source.Length / 2]

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
    split.[0], split.[1]