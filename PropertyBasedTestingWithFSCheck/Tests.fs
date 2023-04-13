module Tests

open System
open Xunit

let add x y = 0


[<Fact>]
let ``Add test`` () =
    Assert.Equal(3, add 1 2)
