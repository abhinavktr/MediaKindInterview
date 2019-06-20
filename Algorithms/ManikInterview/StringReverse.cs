using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class StringReverse
    {
        public StringReverse()
        {
            string str = "This";

            Console.WriteLine(ReverseString(str));
        }
        public string ReverseString(string str)
        {
            if(str.Length < 2)
            {
                return str;
            }
            Console.WriteLine(str.Substring(1) + " - " + str[0]);
            return ReverseString(str.Substring(1)) + str[0];
        }
    }
}