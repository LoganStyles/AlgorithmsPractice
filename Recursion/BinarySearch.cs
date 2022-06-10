using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Recursion
{
    internal class BinarySearch
    {

        public int Solution(int[] input, int target)
        {
            return SolutionHelper(input, target, 0, input.Length - 1);
        }

        private int SolutionHelper(int[] input, int target, int left, int right)
        {
            if (left > right)
                return -1;

            int middle = left + (right - left) / 2;

            if (input[middle] == target)
                return middle;
            else if (input[middle] < target)
                return SolutionHelper(input, target, middle + 1, right);
            else
                return SolutionHelper(input, target, left, middle - 1);
        }
    }
}
