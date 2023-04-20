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

type DoubleModPair = 
    static member UInt64 () =
        Gen.choose (1, 1000000) |> Gen.two |> Gen.map (fun (x, y) -> ((uint64)x * (uint64)y, (uint64)y)) |> Arb.fromGen

[<Property( Arbitrary = [| typeof<DoubleModPair> |], MaxTest=1000000)>]
let ``double divide calcuration keeps integer precision`` (x:uint64) (y:uint64) = 
    (uint64)((double)x / (double)y) = x / y
