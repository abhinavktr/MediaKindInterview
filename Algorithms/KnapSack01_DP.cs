﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class DynamicProgramming
    {
        static long[] fibCache = new long[200];

        // Top-down
        public static long Fibonacci(long n)
        {
            if (n <= 1)
                fibCache[n] = 1;
            if (fibCache[n] == 0)
                fibCache[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
            return fibCache[n];
        }
    }
    public class Item
    {
        public string Label;
        public int Weight;
        public int Value;
    }
    //copied from PS
    class KnapSack01_DP
    {
        public static List<Item> ZeroOneKnapsack(int capacity, List<Item> items, out int solutionValue)
        {
            // Create arrays for keeping track of the maximum value for each sub-solution
            // and which items to include, respectively:
            var maxValues = (int[,])Array.CreateInstance(typeof(int), items.Count + 1, capacity + 1);
            var doInclude = (bool[,])Array.CreateInstance(typeof(bool), items.Count + 1, capacity + 1);

            // Notice, that at this point, both arrays are initialized with 0's and false, respectively.

            // Fill out the cache-arrays, starting with the smallest sub-solution first...
            for (var i = 0; i < items.Count; i++)
            {
                var currentItem = items[i];
                var row = i + 1;
                for (var c = 1; c <= capacity; c++)
                {
                    // What is the maximum possible value for the two cases where the
                    // item is included and excluded from the final solution, respectively?
                    var valueExcluded = maxValues[row - 1, c];
                    var valueIncluded = 0;
                    if (currentItem.Weight <= c)
                        valueIncluded = currentItem.Value + maxValues[row - 1, c - currentItem.Weight];

                    // Only use the current item if it results in a higher value:
                    if (valueIncluded > valueExcluded)
                    {
                        maxValues[row, c] = valueIncluded;
                        doInclude[row, c] = true;
                    }
                    else
                    {
                        maxValues[row, c] = valueExcluded;
                    }
                }
            }

            // We now have the solution, hidden within our two arrays. The maximum possible value for the
            // original problem is found in the lower right array element:
            solutionValue = maxValues[items.Count, capacity];

            // Find out which items that actually constitutes the above found solution value...
            var chosenItems = new List<Item>();
            // Iterate backwards, starting from the last item...
            for (var row = items.Count; row > 0; row--)
            {
                // If the current item should not be included, just skip it and look at the next one:
                if (!doInclude[row, capacity])
                    continue;

                // Otherwise, add it to the list of chosen items:
                var item = items[row - 1];
                chosenItems.Add(item);

                // Now, with that item chosen, the next sub-problem's capacity is correspondingly smaller:
                capacity -= item.Weight;
            }
            return chosenItems;
        }
    }
}
