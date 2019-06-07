using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
   public class RainningDropsCollection
    {
        //from geeks for geek
        public static int Trap(int[] input)
        {
            // left[i] contains height of tallest bar to the 
            // left of i'th bar including itself 
            int[] left = new int[input.Length];

            // Right [i] contains height of tallest bar to 
            // the right of ith bar including itself 
            int[] right = new int[input.Length];

            // Initialize result 
            int water = 0;

            // Fill left array 
            left[0] = input[0];
            for (int i = 1; i < input.Length; i++)
                left[i] = Math.Max(left[i - 1], input[i]);

            // Fill right array 
            right[input.Length - 1] = input[input.Length - 1];
            for (int i = input.Length - 2; i >= 0; i--)
                right[i] = Math.Max(right[i + 1], input[i]);

            // Calculate the accumulated water element by element 
            // consider the amount of water on i'th bar, the 
            // amount of water accumulated on this particular 
            // bar will be equal to min(left[i], right[i]) - arr[i] . 
            for (int i = 0; i < input.Length; i++)
                water += Math.Min(left[i], right[i]) - input[i];

            return water;
        }
    }
}
