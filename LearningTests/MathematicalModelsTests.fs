namespace LearningStatistics

module MeasureOfCentralTendency =

    open LearningStatistics
    open System
    open Xunit

    [<Fact>]
    let ``Variance test`` () =
        let input  =  [1.5m;9.3m;4.6m;3.8m]
        let expectedVariance = 10.727m
        let actualVar =  LearningStatistics.centralTendency.VarCalc input
        Assert.Equal(expectedVariance,Math.Round(actualVar,3) )
   

    [<Fact>]
    let ``Standard deviation test`` () =
        let input  =  [1.5m;9.3m;4.6m;3.8m]
        let expectedstandardDeviation = 3.275m
        let actualStd =  LearningStatistics.centralTendency.StdCalc input
        Assert.Equal(expectedstandardDeviation, Math.Round(actualStd,3) )
 
    [<Fact>]
    let ``Kurtosis test`` () =
        let input  =  [1.5m;9.3m;4.6m;3.8m]
        let expectedKurtosis =  0.511m
        let actualKurt =  LearningStatistics.centralTendency.kurtosis input
        Assert.Equal(expectedKurtosis,Math.Round(actualKurt,3))

module robustness =
    let 