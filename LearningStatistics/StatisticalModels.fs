namespace LearningStatistics

module StatisticalModels =

//a function that sums two numbers
    let Add a b =
        a + b

//A function that gets the difference between three numbers
    let DifferenceOfThreeNumbers a b c =
        a - b - c


module MultiplicativeModels =
//A function that multiplies two numbers
    let MultiplyTwoNumbers a b =
        a * b
//A function that multiplies three numbers
    let MultiplyThreeNumbers a b c =
        a * b *c
    
//create one modules and 3 tests for them. give each a model e.g average, variance,standard deviation

module functionValues =

    let Add (transform : int -> int ) z = transform z   // a function that takes in a function. it takes in an interger and returns an integer
    let increment x = x + 1
    let result = Add increment 100 


//Lamda expressions
    let Add1 = Add (fun x -> x + 1)100
  