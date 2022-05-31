namespace LearningStatistics


module  centralTendency =
    let VarCalc (Numbers: list<decimal>) =
        let mean = List.average Numbers
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        
        let deviationFromMean = List.sumBy (fun x->  pow((x-mean),2)) Numbers
        
        deviationFromMean/ decimal Numbers.Length - 1m

    let StdCalc (nums: list<decimal>) =
        let mean = List.average nums
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        
        let deviationFromMean = List.sumBy (fun x->  pow((x-mean),2)) nums
        
        pow((deviationFromMean/ decimal nums.Length),0.5m)  
    
    let kurtosis (inputNumbers: list<decimal>) =
        let mean = List.average inputNumbers
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        
        let forthMoment = List.sumBy (fun x->  pow((x-mean),4m)) inputNumbers
        let secondMoment = List.sumBy (fun x->  pow((x-mean),2m)) inputNumbers
        (forthMoment/pow(secondMoment,2m))* decimal inputNumbers.Length
