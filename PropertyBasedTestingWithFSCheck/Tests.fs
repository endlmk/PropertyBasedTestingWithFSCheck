module Tests

open System
open Xunit
open FsCheck
open FsCheck.Xunit

let add x y = x + y

[<Fact>]
let ``Add test`` () =
    Assert.Equal(3, add 1 2)

[<Property>]
let ``add = x + y`` x y = 
    add x y = x + y