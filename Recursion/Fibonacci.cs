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
    }
}
