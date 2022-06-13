namespace LearningStatistics
open System

module  centralTendency =
    let pow (a:decimal, d:decimal) = 
        decimal (float a ** float d)

    let VarCalc (numbers: list<decimal>) =
        let mean = List.average numbers
        let deviationFromMean = List.sumBy (fun x->  pow((x-mean),2m)) numbers
        
        deviationFromMean/ (decimal numbers.Length - 1m)
        

    let StdCalc (nums: list<decimal>) = 
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        pow(VarCalc(nums),0.5m)  
      
    
    let kurtosis (inputNumbers: list<decimal>) =
        let mean = List.average inputNumbers
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        
        let forthMoment = List.sumBy (fun x->  pow((x-mean),4m)) inputNumbers
        let secondMoment = List.sumBy (fun x->  pow((x-mean),2m)) inputNumbers
        (forthMoment/pow(secondMoment,2m))//* decimal inputNumbers.Length

    let covariance (input1: list<decimal>, input2: list<decimal>) =
        let mean1 = List.average input1
        let mean2 = List.average input2
        let n = if List.length input1 <= 30 then decimal((List.length input2) - 1)   else  decimal(List.length input2)
        let sumOfDeviations = (List.zip input1 input2 |> List.sumBy(fun (x,y) -> (x - mean1) * (y - mean2)))/n
        sumOfDeviations
        


    let   trimmedMean (inputPrices: list<decimal>, percentBound: decimal) =
        let priceLength = inputPrices.Length
        let sortedPrices = List.sort inputPrices
        let NtoBeRemoved = int(percentBound * decimal (priceLength))
        let trimmedList  = sortedPrices[NtoBeRemoved..(priceLength - NtoBeRemoved)]
        ((List.sum trimmedList)/ decimal (trimmedList.Length))


    let trackingError (portfolioReturns: list<decimal>,benchmarkReturns: list<decimal> ) =
        
          let outPut =
            if List.isEmpty portfolioReturns then 
                0m
            elif 
                List.isEmpty benchmarkReturns  then
                0m
            elif
                (List.length portfolioReturns   <> List.length benchmarkReturns) 
                then 0m
            else
       
            let ourN = List.zip portfolioReturns benchmarkReturns
            let sumOfDeviations = (List.sumBy (fun (x,y)-> pow((x-y),2m)) ourN)/decimal ourN.Length 
            let res = pow(sumOfDeviations,0.5m)
            res 
          outPut
    
    let trackingError2 (portfolioReturns: list<decimal>,benchmarkReturns: list<decimal> ) =
        
            if List.isEmpty portfolioReturns then 
                printfn "empty list"
            elif 
                List.isEmpty benchmarkReturns  then
                printfn "empty list"
            elif
                (List.length portfolioReturns   <> List.length benchmarkReturns) 
                then    
                printfn "unequal list"
            
       
            let ourN = List.zip portfolioReturns benchmarkReturns
            let sumOfDeviations = (List.sumBy (fun (x,y)-> pow((x-y),2m)) ourN)/decimal ourN.Length 
            let res = pow(sumOfDeviations,0.5m)
            res 
   
    let mean1 (dataSet : list<decimal>) = 

            if List.isEmpty dataSet then 0m
            
            else
                let lengthOfDataset = decimal dataSet.Length
                let Summations = List.sum dataSet
                Summations/lengthOfDataset
     
