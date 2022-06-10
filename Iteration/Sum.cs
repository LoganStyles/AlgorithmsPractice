using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Iteration
{
    internal class Sum
    {
        /*
         * write a function sum that takes an array of numbers
         * as an input. the function should return the total sum
         * of all elements.
         */

        //Time: O(n)
        //Space: O(1)
        public int Solution(int[] input)
        {
            int sum = 0;
            int index = 0;

            while (index < input.Length)
                sum += input[index++];
            return sum;
        }
    }
}
