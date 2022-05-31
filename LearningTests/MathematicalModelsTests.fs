namespace LearningStatistics

module MeasureOfCentralTendency =
open LearningStatistics
open System
open Xunit

[<Fact>]
    let ``Variance test`` () =
    let input  =  [1.5m;9.3m;4.6m;3.8m]
    let expectedVariance = 8.045m
    let actualVar =  LearningStatistics.centralTendency.StdCalc input
    Assert.Equal(expectedVariance, actualVar )
   

[<Fact>]
    let ``Standard deviation test`` () =
    let input  =  [1.5m;9.3m;4.6m;3.8m]
    let expectedstandardDeviation = 2.6m
    let actualStd =  LearningStatistics.centralTendency.VarCalc input
    Assert.Equal(expectedstandardDeviation, actualStd )
 
[<Fact>]
    let ``Kurtosis test`` () =
    let input  =  [1.5m;9.3m;4.6m;3.8m]
    let expectedKurtosis = 1.844m
    let actualKurt =  LearningStatistics.centralTendency.kurtosis input
    Assert.Equal(expectedKurtosis, actualKurt)

