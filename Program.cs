// See https://aka.ms/new-console-template for more information
using AlgorithmsPractice.DP;
using AlgorithmsPractice.Iteration;
using AlgorithmsPractice.Recursion;

Console.WriteLine("Hello, Algorithms practice!");

#region Recursion & DP
#region Fibonacci
var solution = new Fibonacci();
var input = 4;

// Console.WriteLine($"{input} : {solution.Fib(input)}");

//var fibWithMemo = new FibonacciWithMemo();
//Console.WriteLine($"{input} : {fibWithMemo.Solution(input)}");

// var startTime = DateTime.Now;
// solution.PrintAllFib(input);
// var endTime = DateTime.Now;
// var duration = endTime - startTime;
// Console.WriteLine($"duration for PrintAllFib is {duration.Milliseconds}");

// startTime = DateTime.Now;
// solution.PrintAllFibPretty(input);
// endTime = DateTime.Now;
// duration = endTime - startTime;
// Console.WriteLine($"duration for PrintAllFibPretty is {duration.Milliseconds}");

Console.WriteLine($"sum of odd fib nums less than {input}: {solution.SumOfOddFibonacci(input)}");
#endregion

#region Sum
//var sumOfNumbers = new Sum();
//Console.WriteLine(sumOfNumbers.Solution(new int[] { 2, 5, 6, -3 }));
//Console.WriteLine(sumOfNumbers.SolutionWithIndex(new int[] { 2, 10, 6, -3 }));
#endregion

#region combinations
// var getCombinations = new Combinations();
// var results = getCombinations.Solution(new char[] { 'a', 'b', 'c' });
// System.Console.WriteLine(results.Count);
#endregion

#region Permutations
// var getPermutations = new Permutations();
// // var input = new char[] { 'a', 'b', 'c' };
// var input = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
// var startTime = DateTime.Now;
// var results = getPermutations.Solution(input);
// var endTime = DateTime.Now;
// Console.WriteLine($"duration with Solution: {endTime.Millisecond - startTime.Millisecond}");

// var arrayinput = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
// var arraystartTime = DateTime.Now;
// var arrayresults = getPermutations.SolutionUsingArrayIndex(arrayinput);
// var arrayendTime = DateTime.Now;
// Console.WriteLine($"duration with SolutionUsingArrayIndex: {arrayendTime.Millisecond - arraystartTime.Millisecond}");
#endregion

//var recursiveFactorial = new AlgorithmsPractice.Recursion.Factorial();
//Console.WriteLine(recursiveFactorial.Solution(4));

#region Binary Search

//var recursionBS = new AlgorithmsPractice.Recursion.BinarySearch();
//Console.WriteLine(recursionBS.Solution(new int[] { 2, 7, 8, 9, 10, 13, 17, 18, 19, 21 }, 7));//1
//Console.WriteLine(recursionBS.Solution(new int[] { 2, 7, 8, 9, 10, 13, 17, 18, 19, 21 }, 15));//-1
#endregion

#endregion

#region Iteration

#region Factorial
//var iterativeFactorial = new AlgorithmsPractice.Iteration.Factorial();
//Console.WriteLine(iterativeFactorial.Solution(4));
#endregion

#region Binary Search

//var iterativeBS = new AlgorithmsPractice.Iteration.BinarySearch();
//Console.WriteLine(iterativeBS.Solution(new int[] {2,7,8,9,10,13,17,18,19,21},7));//1
//Console.WriteLine(iterativeBS.Solution(new int[] {2,7,8,9,10,13,17,18,19,21},15));//-1
#endregion

#endregion

Console.ReadLine();
