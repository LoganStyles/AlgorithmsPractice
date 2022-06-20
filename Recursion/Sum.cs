namespace AlgorithmsPractice.Recursion
{
    /*
     * write a function sum that takes an array of numbers
     * as an input. the function should return the total sum
     * of all elements.
     */

    //start by listing out test cases of varying sizes
    /* 
     Solution([]) = 0
     Solution([1]) = 1
     Solution([1,5]) = 6
     Solution([1,5,7]) = 13
     Solution([1,5,7,-2]) = 11

     take note:
     we structure the example in such a way as to have varying input size together with overlapping elements
     
     this leads us towards solving this problem recursively
     where the empty array is a base case.
     Solution([]) = 0

     next we can highlight any 2 instances to indicate the recursive cases:
     Solution([1,5]) = 6
     Solution([1,5,7]) = 13
     ----the above can b represented recursively below
     Solution([1,5,7]) == 7 + Solution([1,5])
     
     in general, we now have:
     Solution([a,b,c,d]) = a + Solution([b,c,d])

     we can then re-evaluate the math from bottom up

     Solution([]) => 0
     Solution([1]) = 1 + Solution([]) => 1
     Solution([1,5]) = 5 + Solution([1]) => 6
     Solution([1,5,7]) = 7 + Solution([1,5]) => 13
     Solution([1,5,7,-2]) = -2 + Solution([1,5,7]) => 11
     here 11 is the final answer


      */
    internal class Sum
    {
        //Time: O(n^2): we have O(n) recursive calls, within each (in the worst case) we perform O(n) iterations due to Array.Copy
        //Space: O(n) from coderbyte video??, should'nt it be O(n^2) due to additional array created
        public int Solution(int[] input)
        {
            if (input.Length == 0)
                return 0;

            var remaining = new int[input.Length - 1];
            Array.Copy(input, 1, remaining, 0, remaining.Length);

            return input[0] + Solution(remaining);
        }

        // this solution removes the additional iteration due to Array.Copy
        //Time: O(n)
        //Space: O(n)
        public int SolutionWithIndex(int[] input)
        {
            return SolutionWithIndexHelper(input, 0);
        }

        //here index represents the start of the array under consideration
        //hence no extra array is needed
        private int SolutionWithIndexHelper(int[] input, int index)
        {
            if (index == input.Length)
                return 0;

            return input[index] + SolutionWithIndexHelper(input, index + 1);
        }
    }
}
