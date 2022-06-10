namespace AlgorithmsPractice.Recursion
{
    /*
     * write a function sum that takes an array of numbers
     * as an input. the function should return the total sum
     * of all elements.
     */
    internal class Sum
    {
        //Time: O(n^2)
        //Space: O(n) from coderbyte video??, should'nt it be O(n^2) due to additional array created
        public int Solution(int[] input)
        {
            if (input.Length == 0)
                return 0;

            var remaining = new int[input.Length - 1];
            Array.Copy(input, 1, remaining, 0, remaining.Length);

            return input[0] + Solution(remaining);
        }

        //Time: O(n)
        //Space: O(n)
        public int SolutionWithIndex(int[] input)
        {
            return SolutionWithIndexHelper(input, 0);
        }

        private int SolutionWithIndexHelper(int[] input, int index)
        {
            if (index == input.Length)
                return 0;

            return input[index] + SolutionWithIndexHelper(input, index + 1);
        }
    }
}
