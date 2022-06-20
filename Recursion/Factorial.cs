namespace AlgorithmsPractice.Recursion
{
    internal class Factorial
    {
        /*
         * Print the factorial of any number
         * e.g 4!=4*3*2*1
         */
        //time: O(n)
        //space:O(n)

        public int Solution(int input)
        {
            if (input == 1)
                return 1;

            return input * Solution(input - 1);
        }
    }
}
