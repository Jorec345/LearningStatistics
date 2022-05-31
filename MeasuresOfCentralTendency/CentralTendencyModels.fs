namespace MeasuresOfCentralTendency


module  CentralTendency =
    let StdCalc (Numbers: list<decimal>) =
        let mean = List.average Numbers
        let   pow(a:decimal, d:decimal) = decimal (float a ** float d)
        
        let deviationFromMean = List.sumBy (fun x->  pow((x-mean),2)) Numbers
        
        deviationFromMean/ decimal Numbers.Length
           