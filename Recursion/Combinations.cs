namespace AlgorithmsPractice.Recursion
{
    internal class Combinations
    {
        //* Combinations is a collection of items where the order of the items doesn't matter
        /* 
        combinations of [a,b,c] is
        []
        [a]
        [b]
        [c]
        [a,b]
        [b,c]
        [a,c]
        [a,b,c]

        Given a set of n things, there are 2^n possible combinations
        when solving this sort of problems, the decision process is binary.
        if we start with an empty array, 
        you either include one of the element in the array or not.
         */

        //receive an array {a,b,c}
        //pick the first element 'a'
        //recursively pass the rest of the array  {b,c} to the combinations funct
        //from d result of rest {b,c}, form a new collection by adding d first element that was previously excluded
        //combine both collections

        /*
         * base case: determine what would b the base case for this problem by
         establishing a minute part of the problem whose answer we alrady know.
         in this example, considert that when given an empty array, we know that
         its combination would b an empty array.

         psuedocode:
         * return a list/2d array with one empty list/array inside
         * 
         * select the current element (currentElement), since it is what will be processed
         * in the current funct call 
         * then pass the rest of the elements recursively and get the results (combsWithoutCurrentElement)
         * create a new combination (combsWithCurrentElement)
         * combine each item in combsWithoutCurrentElement with currentElement & push the result into (combsWithCurrentElement)
         * combine both (combsWithCurrentElement) & (combsWithoutCurrentElement)
         */

        //Time: O(2^n)
        //space: O(n^2)
        public List<List<char>> Solution(char[] input)
        {
            //chk for base case
            if (input.Length == 0)
            {
                var combinations = new List<List<char>>();
                combinations.Add(new List<char>());

                return combinations;
            }

            var currentElement = input[0];
            var restOfElements = new char[input.Length - 1];
            Array.Copy(input, 1, restOfElements, 0, input.Length - 1);

            var combsWithoutCurrentElement = Solution(restOfElements);
            var combsWithCurrentElement = new List<List<char>>();

            foreach (var item in combsWithoutCurrentElement)
            {
                var newItem = new List<char>();
                newItem.AddRange(item);
                newItem.Add(currentElement);
                combsWithCurrentElement.Add(newItem);
            }

            combsWithoutCurrentElement.AddRange(combsWithCurrentElement);

            return combsWithoutCurrentElement;
        }
    }
}
