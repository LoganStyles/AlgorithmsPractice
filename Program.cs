// See https://aka.ms/new-console-template for more information
using AlgorithmsPractice.DP;
using AlgorithmsPractice.Iteration;
using AlgorithmsPractice.Recursion;

Console.WriteLine("Hello, Algorithms practice!");

#region Recursion & DP
#region Fibonacci
//var fib = new Fibonacci();
//var input = 10;
//Console.WriteLine($"{input} : {fib.Solution(input)}");

//var fibWithMemo = new FibonacciWithMemo();
//Console.WriteLine($"{input} : {fibWithMemo.Solution(input)}");
#endregion

#region Sum
//var sumOfNumbers = new Sum();
//Console.WriteLine(sumOfNumbers.Solution(new int[] { 2, 5, 6, -3 }));
//Console.WriteLine(sumOfNumbers.SolutionWithIndex(new int[] { 2, 10, 6, -3 }));
#endregion

#region combinations
//var combinationsInput = new char[] { 'a', 'b', 'c' };
//var getCombinations = new Combinations();
//var results = getCombinations.Solution(combinationsInput);
#endregion

#region Permutations
//var getPermutations = new Permutations();
//var input = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
//var startTime = DateTime.Now;
//var results = getPermutations.Solution(input);
//var endTime = DateTime.Now;
//Console.WriteLine($"duration with Solution: {endTime.Millisecond - startTime.Millisecond}");

//var arrayinput = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
//var arraystartTime = DateTime.Now;
//var arrayresults = getPermutations.SolutionUsingArrayIndex(arrayinput);
//var arrayendTime = DateTime.Now;
//Console.WriteLine($"duration with SolutionUsingArrayIndex: {arrayendTime.Millisecond - arraystartTime.Millisecond}");
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
