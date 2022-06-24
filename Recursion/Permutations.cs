namespace AlgorithmsPractice.Recursion
{
    internal class Permutations
    {
        /*
         * Permutations is a collection of items where the order of the items matters

         With combinations we decide whether or not to include an element. 
         With permutations we definitely include an element but we decide where to put it.
         
         * e.g
         * Given a collection of elements {a,b,c}, 
         * we want to arrange the elements in every possible order

         permutations of [a,b,c] is
         [
            [c,b,a]
            [c,a,b]
            [b,c,a]
            [b,a,c]
            [a,c,b]
            [a,b,c]
        ]
        Given a set of n things, there are n! permutations => 3!=3*2*1=6

        DIAGRAM
        drawing a tree helps to understand why it's n! 
        becos when solving this sort of problems, we make a decision on each element
        about where to put that element. 
        starting from the base case which is an empty array,
        as we progress down the tree, we place an element at different positions within an existing array.
        as we progress down the tree, the number of positions to place an element increases by 1.
         the final permutations are the nodes at the very bottom
         */

        /*
         * base case: determine what would b the base case for this problem by
         establishing a minute part of the problem whose answer we alrady know.
         in this example, consider that when given an empty array, we know that
         its permutation would b an empty array.

         psuedocode:
         * return a list/2d array 
         * 
         * To solve using recursion, get the current element (first element), 
         * & pass the rest recursively to the permutations funct.
         * 
         * from the result of the rest permutation,
         * create a new collection by adding the current element 
         * to all possible positions in each item of the rest permutation
         */

        //Time: O(n!)
        //Space: O(n^2)
        public List<List<char>> Solution(char[] input)
        {
            if (input.Length == 0)
            {
                return new List<List<char>> { new List<char>() };
            }

            var currentElement = input[0];
            var restOfElements = new char[input.Length - 1];
            Array.Copy(input, 1, restOfElements, 0, restOfElements.Length);
            var permutationsWithoutCurrentElement = Solution(restOfElements);

            var allPermutations = new List<List<char>>();

            foreach (var item in permutationsWithoutCurrentElement)
            {
                for (var i = 0; i <= item.Count; i++)
                {
                    var newItem = new List<char>();
                    newItem.AddRange(item);
                    newItem.Insert(i, currentElement);
                    allPermutations.Add(newItem);
                }
            }

            return allPermutations;
        }

        //Time: O(n^2)
        //Space: O(n^2)
        public List<List<char>> SolutionUsingArrayIndex(char[] input)
        {
            return SolutionUsingArrayIndexHelper(input, 0);
        }

        public List<List<char>> SolutionUsingArrayIndexHelper(char[] input, int index)
        {
            if (input.Length == index)
            {
                return new List<List<char>> { new List<char>() };
            }

            var currentElement = input[0];
            var permutationsWithoutCurrentElement = SolutionUsingArrayIndexHelper(input, index + 1);

            var allPermutations = new List<List<char>>();

            foreach (var item in permutationsWithoutCurrentElement)
            {
                for (var i = 0; i <= item.Count; i++)
                {
                    var newItem = new List<char>();
                    newItem.AddRange(item);
                    newItem.Insert(i, currentElement);
                    allPermutations.Add(newItem);
                }
            }

            return allPermutations;
        }
    }
}
