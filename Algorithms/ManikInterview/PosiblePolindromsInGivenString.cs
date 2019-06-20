using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    class PosiblePolindromsInGivenString
    {
        public PosiblePolindromsInGivenString(string str)
        {
            //str = "abbaeae";
            Console.WriteLine($"Full String: {str}");
            PrintPossiblePalindroms(str);
        }

        public static void PrintPossiblePalindroms(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                CheckPolindrom(str, i, i);
                CheckPolindrom(str, i, i + 1);
            }
        }

        public static void CheckPolindrom(string str, int startIndex, int endIndex)
        {
            while (startIndex >= 0 &&
                 endIndex < str.Length &&
                 str[startIndex] == str[endIndex])
            {
                int length = endIndex + 1 - startIndex;
                if (length > 1)
                {
                    Console.WriteLine(str.Substring(startIndex, length));
                }
                startIndex--;
                endIndex++;
            }
        }
    }
}
