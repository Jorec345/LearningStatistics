namespace LearningStatistics


module Tests =

open System
open Xunit

[<Fact>]
let ``My test`` () =
    Assert.True(true)
    
    Say.goodnite "James"
    Say.hello 
  
[<Fact>]
    let ``Test that two numbers are summed correctly`` () =
    let expectedResult = 11
    let actual = StatisticalModels.Add 5 6
    Assert.Equal(expectedResult, actual )
  




   

