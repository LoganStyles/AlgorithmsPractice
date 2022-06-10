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
         * 1 => 1
         * 2 => 1
         * 3 => 2
         * 4 => 3
         * 5 => 5
         * 6 => 8
         * 7 => 13
         */

        /*
         * brute force
         * time complexity: O(2^n)
         * space complexity: O(n)
         */
        public int Solution(int input)
        {
            if (input <= 2)
                return 1;

            return Solution(input - 1) + Solution(input - 2);
        }
    }
}
