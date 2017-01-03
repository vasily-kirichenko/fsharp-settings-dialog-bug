module M

type My() =
    member __.Foo(p: int, ?g: System.DateTime) = () 

let y = 1 + 1

//open System

//let xy = new System.IO.FileStream("", IO.FileMode.Append)
//let z: System.IDisposable = null

//let _ = { new System.IDisposable with
//              member this.Dispose(): unit = 
//                  raise (System.NotImplementedException()) }

//let internal xxx = 1

//let y = xxx

//let z = xxx
//let h = xxx

//type internal MyClass() =
//    let mutable value = "hello"

//    let tupleize x y = (x, y)

//    member this.TurnIntoTuple(x: string, y: int) = tupleize x y

//    member private this.Whatever() = ()

//    member internal this.MyProperty
//        with get() = value
//        and set(s) = value <- s