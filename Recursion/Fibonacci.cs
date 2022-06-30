using System;

namespace AlgorithmsPractice.Recursion
{
    /*
         * Write a function 'fib(n)' that takes in a number as an
         * argument. The function should return the n-th number of 
         * the Fibonacci sequence.
         * 
         * the 1st & 2nd number of the sequence is 1.
         * to generate the next number of the sequence, we sum the previous two.
         * 
         * n:      1,2,3,4,5,6,7,8,9
         * fib(n): 1,1,2,3,5,8,13,21,34
         * 
         */
    internal class Fibonacci
    {
        /*
        
        so let's review some test cases
         * Fib(1) => 1
         * Fib(2)=> 1
         * Fib(3) => 2
         * Fib(4) => 3
         * Fib(5) => 5
         * Fib(6) => 8
         * Fib(7) => 13

        this problem refers to itself twice over (otherwise called a multibranch recursion)
        since for instance Fib(6)= Fib(5) + Fib(4)
        we can infer that the problem has a self-referential nature

         in general
         fib(n)= fib(n-1)+fib(n-2)

         n will get smaller until we arrive at the base case of fib(2) or fib(1)

         With multibranch recursions, we are dealing with multiple base cases.
         Also they are best visualized as trees
         */

        /*
         * brute force
         * time complexity: O(2^n) exponential
         * space complexity: O(n)
         */
        public int Fib(int input)
        {
            if (input <= 2)
                return 1;

            return Fib(input - 1) + Fib(input - 2);
        }

        /* 
        faster
         */

//         public int FibAsASeries(int input)
//         {
//             var result = 0;
//             var previous =0;
//             for (var current = 1; current <= input; current++) {
// result=current;

//              }
//             return result;
//         }

        #region  PRINT ALL FIBONACCI NUMBERS
        //time: O(2^n)
        //space: O(n)
        public int PrintAllFib(int input)
        {
            if (input <= 2)
            {
                Console.WriteLine($"Fib for {input} is 1");

                return 1;
            }

            var result = PrintAllFib(input - 1) + PrintAllFib(input - 2);
            Console.WriteLine($"Fib for {input} is {result}");
            return result;
        }

        //time: O(n* 2^n)
        //space: O(n)
        public void PrintAllFibPretty(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + ": " + _PrintAllFibPretty(i));
            }
        }

        private int _PrintAllFibPretty(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            return _PrintAllFibPretty(n - 1) + _PrintAllFibPretty(n - 2);
        }

        #endregion

        #region sum of odd fib

        /*
         * 
         * Fibonacci
            The Fibonacci sequence begins like this:
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34
            (each number is the sum of the previous two)

            What is the sum of all odd numbers 
            in the Fibonacci sequence that are less
            than 10,000?

            less than 60=>1+1+3+5+13+21+55=23
            Fib(1) => 1
            Fib(2)=> 1
            Fib(3) => 2
            Fib(4) => 3
            Fib(5) => 5
            Fib(6) => 8
            Fib(7) => 13
            Fib(8) => 21
            Fib(9) => 34
            Fib(10) => 55
        
         */

        /* 
        time: O(n* 2^n)
        space: O(n)
        */
        public int SumOfOddFibonacci(int limit)
        {
            var sum = 0;
            var input = 1;
            while (sum < limit)
            {
                var result = _SumOfOddFibonacci(input);
                if (result % 2 == 1)
                    sum += result;

                input++;
            }

            return sum;
        }

        private int _SumOfOddFibonacci(int input)
        {
            if (input <= 2)
                return 1;

            return _SumOfOddFibonacci(input - 1) + _SumOfOddFibonacci(input - 2);
        }

        //time:O(n)
        //space:O(1)
        public int SumOfOddFibonacciFaster(int n)
        {
            var sum = 0;
            var previous = 0;
            var current = 1;

            while (current <= n)
            {
                if (current % 2 != 0)
                    sum += current;

                //1,1,2,3,5,8,13,21,34
                current += previous;
                previous = current - previous;
            }

            return sum;
        }

        #endregion
    }
}
