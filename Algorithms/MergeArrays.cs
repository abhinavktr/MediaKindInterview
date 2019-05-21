using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeArrays
    {
        public int[] Merge(int[] ar1,int[] ar2)
        {
            int ar1Pointer = 0, ar2Pointer = 0, targetIndex = 0;
            int remaining = ar1.Length + ar2.Length;
            int[] mergedArray = new int[remaining];
            
           while(remaining > 0)
            {
                if (ar1Pointer >= ar1.Length) //handling if the end of first array, copy the remaining elemnt of array 2
                {
                    mergedArray[targetIndex] = ar2[ar2Pointer++];                   
                }else if(ar2Pointer >= ar2.Length)
                {
                    mergedArray[targetIndex] = ar1[ar1Pointer++];
                   
                }else if(ar1[ar1Pointer] < ar2[ar2Pointer])
                {
                    mergedArray[targetIndex] = ar1[ar1Pointer++];                    
                }else if(ar1[ar1Pointer] == ar2[ar2Pointer])
                {
                    mergedArray[targetIndex++] = ar2[ar2Pointer];                  
                    mergedArray[targetIndex] = ar2[ar2Pointer];
                    ar2Pointer++;ar1Pointer++;
                }
                else
                {
                    mergedArray[targetIndex] = ar2[ar2Pointer++];                    
                }

                targetIndex++;
                remaining--;
            }
            return mergedArray;
        }
    }
}
