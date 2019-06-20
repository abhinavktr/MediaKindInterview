using System;

namespace ConsoleAppOne
{
    public class BobbleSort
    {
        public void BobbleSortArray()
        {
            Console.WriteLine("Hello");
            int[] intArray = new int[] { 5, 2, 7, 7, 1, 9 };

            intArray = SortArrayAsce(intArray);

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        private static int[] SortArrayAsce(int[] intArray)
        {
            int swapCount = 0;

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > intArray[i + 1])
                {
                    int a = intArray[i];
                    intArray[i] = intArray[i + 1];
                    intArray[i + 1] = a;
                    swapCount += 1;
                }
            }

            if (swapCount > 0)
            {
                intArray = SortArrayAsce(intArray);
            }

            return intArray;
        }
    }

}
