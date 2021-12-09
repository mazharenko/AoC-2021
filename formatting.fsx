[<AutoOpen>]
module Formatting
open System.Text

let formatTable (formatElement : 'a -> string) (matrix : 'a[,]) = 
    let builder = StringBuilder()
    Printf.bprintf builder "<table>"
    for i in (Array2D.base1 matrix)..(Array2D.length1 matrix - 1) do
        Printf.bprintf builder "<tr>"
        for j in (Array2D.base2 matrix)..(Array2D.length2 matrix - 1) do
            Printf.bprintf builder $"<td>{formatElement matrix.[i,j]}</td>"
        Printf.bprintf builder "</tr>"
    Printf.bprintf builder "</table>"
    builder.ToString();