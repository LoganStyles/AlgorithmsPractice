using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Recursion
{
    internal class Permutations
    {
        /*
         * Permutations is a collection of items where the order of the items matters
         * 
         * Given a collection of elements {a,b,c}, 
         * we want to arrange the elements in every possible order
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
                return new List<List<char>>
                {
                    new List<char>()
                };

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

        public List<List<char>> SolutionUsingArrayIndex(char[] input)
        {
            return SolutionUsingArrayIndexHelper(input, 0);
        }
        public List<List<char>> SolutionUsingArrayIndexHelper(char[] input, int index)
        {
            if (input.Length == index)
            {
                return new List<List<char>>
                {
                    new List<char>()
                };

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
