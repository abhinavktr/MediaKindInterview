using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class MaxOccuringCharInString
    {
        public MaxOccuringCharInString()
        {
            string str = "Find max occuring char in this-string";
            int[] count = new int[256];

            for(int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;
            }

            //for(int i = 0; i < count.Length; i++)
            //{
            //    Console.WriteLine(count[i]);
            //}
            int max = -1;
            char maxOccuredChar = ' ';

            for (int i = 0; i < str.Length; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    maxOccuredChar = str[i];
                }
            }

            Console.WriteLine($"{maxOccuredChar} - {max}");
        }
    }
}
