[<AutoOpen>]
module common 

#r "nuget: MathNet.Numerics.FSharp, 5.0.0-alpha03"
open MathNet.Numerics.LinearAlgebra

type Rotation = MathNet.Numerics.LinearAlgebra.Matrix<float>

let rotations90 : Rotation [] =
    let A = [
        matrix [
            [1.; 0.; 0.]
            [0.; 1.; 0.]
            [0.; 0.; 1.]
        ]
        matrix [
            [0.; 1.; 0.]
            [0.; 0.; 1.]
            [1.; 0.; 0.]
        ]
        matrix [
            [0.; 0.; 1.]
            [1.; 0.; 0.]
            [0.; 1.; 0.]
        ]
    ]
    let B = [
        matrix [
            [1.; 0.; 0.]
            [0.; 1.; 0.]
            [0.; 0.; 1.]
        ]
        matrix [
            [-1.; 0.; 0.]
            [0.; -1.; 0.]
            [0.; 0.; 1.]
        ]
        matrix [
            [-1.; 0.; 0.]
            [0.; 1.; 0.]
            [0.; 0.; -1.]
        ]
        matrix [
            [1.; 0.; 0.]
            [0.; -1.; 0.]
            [0.; 0.; -1.]
        ]
    ]
    let C = [
        matrix [
            [1.; 0.; 0.]
            [0.; 1.; 0.]
            [0.; 0.; 1.]
        ]
        matrix [
            [0.; 0.; -1.]
            [0.; -1.; 0.]
            [-1.; 0.; 0.]
        ]
    ]
    [|
        for a in A do
        for b in B do
        for c in C do
            yield a * b * c
    |]

