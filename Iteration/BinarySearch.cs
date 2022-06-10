using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Iteration
{
    internal class BinarySearch
    {
        public int Solution(int[] input, int target)
        {
            int left = 0;
            int right = input.Length-1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (input[middle] == target)
                    return middle;
                else if (input[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return -1;
        }
    }
}
