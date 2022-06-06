namespace LearningStatistics
open System

module  centralTendency =
    let VarCalc (Numbers: list<decimal>) =
        let mean = List.average Numbers
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        
        let deviationFromMean = List.sumBy (fun x->  pow((x-mean),2m)) Numbers
        
        deviationFromMean/ (decimal Numbers.Length - 1m)
        

    let StdCalc (nums: list<decimal>) = 
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        pow(VarCalc(nums),0.5m)  
      
    
    let kurtosis (inputNumbers: list<decimal>) =
        let mean = List.average inputNumbers
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        
        let forthMoment = List.sumBy (fun x->  pow((x-mean),4m)) inputNumbers
        let secondMoment = List.sumBy (fun x->  pow((x-mean),2m)) inputNumbers
        (forthMoment/pow(secondMoment,2m))//* decimal inputNumbers.Length


module  robustStatistics =
    let   trimmedMean (inputPrices: list<decimal>, percentBound: decimal) =
        let priceLength = inputPrices.Length
        let sortedPrices = List.sort inputPrices
        let NtoBeRemoved = int(percentBound * decimal (priceLength))
        let trimmedList  = sortedPrices[NtoBeRemoved..(priceLength - NtoBeRemoved)]
        ((List.sum trimmedList)/ decimal (trimmedList.Length))
        
    