using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
   public class QuickSort
    {
        public static void Sort(int[] input, int low, int high)
        {            
            if(low < high)
            {
                int pi = partition(input, low, high);
                Sort(input, low, pi - 1);
                Sort(input, pi + 1, high);
            }
        }

        private static int partition(int[] input, int low, int high)
        {
            int pivot = input[high];
            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (input[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }
            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = input[i + 1];
            input[i + 1] = input[high];
            input[high] = temp1;
            return i + 1;
        }

        private static void Swap(int[] input, int index1, int index2)
        {
            var temp = input[index2];
            input[index2] = input[index1];
            input[index1] = temp;           
        }
    }
}
