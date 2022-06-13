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

    [<Fact>]
    let ``Tracking error`` () =
        let inputReturns = [23.0m; 23.5m; 22.0m; 22.5m; 23.6m]
        let inputBenchmark = [22.5m; 23.0m; 22.0m; 22.1m; 23.9m]
        let expectederror = 0.387m
        let actualerror = LearningStatistics.centralTendency.trackingError (inputReturns,inputBenchmark)
        Assert.Equal(expectederror,Math.Round(actualerror,3))

    [<Fact>]
    let ``Tracking error with empty list`` () =
        let inputlist = []
        let inputbenchmark = []
        let expectederror =0.000m
        let actualTrackingerror = LearningStatistics.centralTendency.trackingError (inputlist,inputbenchmark)
        Assert.Equal(expectederror,Math.Round (actualTrackingerror,3))

    [<Fact>]
    let ``Tracking error with unequal list`` () =
        let inputlist = [23.0m; 23.5m; 22.0m; 22.5m]
        let inputbenchmark = [22.5m; 23.0m; 22.0m; 22.1m; 23.9m]
        let expectederror = 0.0m
        let actualTrackingerror = LearningStatistics.centralTendency.trackingError (inputlist,inputbenchmark)
        Assert.Equal(expectederror,Math.Round (actualTrackingerror,3))

        
    [<Fact>]
    let ``Tracking error with only zeros`` () =
        let inputlist = [0.0m; 0.0m; 0.0m; 0.0m; 0.0m]
        let inputbenchmark = [0.0m; 0.0m; 0.0m; 0.0m; 0.0m]
        let expectederror = 0.0m
        let actualTrackingerror = LearningStatistics.centralTendency.trackingError (inputlist,inputbenchmark)
        Assert.Equal(expectederror,Math.Round (actualTrackingerror,3))
    
    [<Fact>]
    let ``Our mean test 1`` () =
         let inputData = [3m;7m;8m;3m;2m;6m]
         let expectedMean = 4.833m
         let actualMean = LearningStatistics.centralTendency.mean1 (inputData)
         Assert.Equal(expectedMean, Math.Round (actualMean,3))

    [<Fact>]
    let ``Our mean test 2`` () =
         let inputData = [0m;0m;0m;0m;0m;0m]
         let expectedMean = 0m
         let actualMean = LearningStatistics.centralTendency.mean1 (inputData)
         Assert.Equal(expectedMean, Math.Round (actualMean,3))

