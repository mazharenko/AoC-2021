[<AutoOpen>]
module common


type Point = | Point of (int * int) with
    static member Zero = Point(0, 0)
    static member (+)(Point (x1 : int, y1 : int), Point (x2 : int, y2 : int)) : Point = 
        let x = x1 + x2
        let y = y1 + y2
        Point (x, y)
