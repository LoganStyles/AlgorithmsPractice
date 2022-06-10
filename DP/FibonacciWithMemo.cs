using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.DP
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

    /*
         * 1 => 1
         * 2 => 1
         * 3 => 2
         * 4 => 3
         * 5 => 5
         * 6 => 8
         * 7 => 13
         */

    /*
     * memoization
     * time complexity: O(n)
     * space complexity: O(n)
     */
    internal class FibonacciWithMemo
    {
        public int Solution(int input)
        {
            var memo = new int[input + 1];
            return SolutionHelper(input, memo);
        }

        private int SolutionHelper(int input, int[] memo)
        {
            if (memo[input] > 0)
                return memo[input];

            if (input <= 2)
                return 1;

            memo[input] = SolutionHelper(input - 1, memo) + SolutionHelper(input - 2, memo);
            return memo[input];
        }
    }
}
