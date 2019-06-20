using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class MergeSortSample
    {
        int[] a = new int[] { 1, 3, 5, 7, 11 , 12, 15};
        int[] b = new int[] { 2, 4, 6, 8, 9, 17 };

        public void MergeSort()
        {
            //Check how clone works
            int[] cloned = a.Clone() as int[];
            cloned[2] = 22;

            int[] merged = new int[a.Length + b.Length];

            int l = 0;
            int r = 0;
            int m = 0;
            int i = 0;
            for (i = 0; (l < a.Length) && (r < b.Length); i++)
            {
                if (a[l] < b[r])
                {
                    merged[m] = a[l];
                    m++;
                    l++;
                }
                else
                {
                    merged[m] = b[r];
                    m++;
                    r++;
                }
            }

            if (l < a.Length)
            {
                Array.Copy(a, l, merged, m, merged.Length - i);
            }

            if (r < b.Length)
            {
                Array.Copy(b, r, merged, m, merged.Length - i);
            }

            for (int j = 0; j < merged.Length; j++)
            {
                Console.WriteLine(merged[j]);
            }
        }
    }
}
