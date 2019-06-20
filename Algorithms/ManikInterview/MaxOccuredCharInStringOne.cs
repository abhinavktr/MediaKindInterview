using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class MaxOccuredCharInStringOne
    {
        public MaxOccuredCharInStringOne()
        {
            string str = "abcdefghijkzzlmnopqrstuvwxyz";

            for (int i = 0; i < str.Length; i++)
            {
                //Console.WriteLine((int)str[i] + " - " + ((int)str[i])%97);
            }

            Console.WriteLine(MaxOccuredChar(str));
        }

        public char MaxOccuredChar(string str)
        {
            int[] asciiCodes = new int[26];
            int modulus = 97;
            int maxOccured = -1;

            for (int i = 0; i < str.Length; i++)
            {
                asciiCodes[str[i] % modulus]++;
            }

            for (int i = 0; i < asciiCodes.Length - 1; i++)
            {
                if (asciiCodes[i] < asciiCodes[i + 1])
                {
                    maxOccured = i;
                }
            }

            return (char)(maxOccured + modulus + 1);
        }
    }
}
