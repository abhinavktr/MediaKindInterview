using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class QuickSort
    {
        public QuickSort()
        {
            Console.WriteLine("Hello");

            int[] arr = new int[] { 24, 11, 32, 35, 17, 15, 19 };

            //QuickSort quickSort = new QuickSort();
            //quickSort.Print(arr);

            DoQuickSort(arr, 0, arr.Length - 1);
            Print(arr);
            Console.WriteLine("Done");
        }

        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = low - 1;
            int j;

            for (j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            //Print(arr);

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            //Print(arr);

            return i + 1;
        }

        public void DoQuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);

                DoQuickSort(arr, low, pivot - 1);
                DoQuickSort(arr, pivot + 1, high);
            }
        }

        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }

    }    
}
