open System 


let listA = [1.0..20.0]
let listB = [21.0..40.0] 


List.zip listA listB |> List.sumBy(fun (x,y) -> x+y) 

let ourN = List.zip listA listB
ourN.Length



let covariance input1 input2 =
    let mean1 = List.average input1
    let mean2 = List.average input2
    let n = if List.length input1 <= 30 then decimal((List.length input2) - 1)   else  decimal(List.length input2)
    let sumOfDeviations = (List.zip input1 input2 |> List.sumBy(fun (x,y) -> (x - mean1) * (y - mean2)))/n
    sumOfDeviations
        

covariance (List.map(decimal)listA) (List.map(decimal)listB) 

let squares =  [ for i in 1 .. 10 do i*i]

let concatList = List.concat [[1;2;3];[2;4;5];[5;7;8]]
concatList
let appendList = List.append [1;2;3;4] [6;7;8;9;10]

let sumList = List.fold (fun x y -> x + y) 0 [1;2;3]
let maximum = List.reduce max [1;2;3;4;5]

let times x y = x * y 
let foldtimes n = List.fold times 11 [1 .. 10]

[1..5] <> [1..5]

 let trackingError (portfolioReturns: list<decimal>,benchmarkReturns: list<decimal> ) =
        let ourN = List.zip portfolioReturns benchmarkReturns
        let sumOfDeviations = (List.sumBy (fun (x,y)-> pow((x-y),2m)) ourN)/decimal ourN.Length 
        pow(sumOfDeviations,0.5m)
    

    //let trackingError (portfolioReturns: list<decimal>,benchmarkReturns: list<decimal> ) =

        //let ourN = List.zip portfolioReturns benchmarkReturns

        //if List.isEmpty ourN = 0m then 0m
        // else 
          // let sumOfDeviations = (List.sumBy (fun (x,y)-> pow((x-y),2m)) ourN)/decimal ourN.Length 
           //pow(sumOfDeviations,0.5m)
        
        