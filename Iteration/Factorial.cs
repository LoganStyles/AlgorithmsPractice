using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Iteration
{
    internal class Factorial
    {
        /*
         * Print the factorial of any number
         * e.g 4!=4*3*2*1
         */
        //time: O(n)
        //space:O(1)
        public int Solution(int input)
        {
            int result = 1;
            int index = 1;

            while (index <= input)
                result *= index++;
            return result;
        }
    }
}
