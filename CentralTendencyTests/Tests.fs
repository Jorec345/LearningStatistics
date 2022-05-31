 namespace MeasuresOfCentralTendency
 module Tests =

open System
open Xunit

[<Fact>]
    let ``Standard deviation test`` () =
    let expectedNumbers  = [1.5;9.5;4.2;3.1] 
    let expectedMean = 4.575
    let expected standardDeviation = 9.006
    let actualMean =  CentralTendency.
    Assert.True(true)
