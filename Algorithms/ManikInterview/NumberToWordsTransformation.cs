using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    using System;

    //https://codeinterview.io/QEVEVFKGAK

    public class NumberToWordsTransformationApproachOne
    {
        private static int tensPlace = 10;
        private static int hundredsPlace = 100;
        private static int thousandsPlace = 1000;
        //private static int tenThousandsPlace = 10000;
        //private static int hundredThousandsPlace = 100000;
        private static int millionPlace = 1000000;
        //private static int tenMillionsPlace = 10000000;
        //private static int hundredMillionsPlace = 100000000;

        public NumberToWordsTransformationApproachOne()
        {
            Console.WriteLine(TransformNumberToWords(-948453230));
        }

        public string TransformNumberToWords(int number)
        {
            string inWords = "";
            if (number == 0)
            {
                return "zero";
            }
            else if (number < 0)
            {
                return "minus " + TransformNumberToWords(Math.Abs(number));
            }

            if (number / millionPlace > 0)
            {
                inWords += TransformNumberToWords(number / millionPlace) + " million ";
                number %= millionPlace;
            }

            if (number / thousandsPlace > 0)
            {
                inWords += TransformNumberToWords(number / thousandsPlace) + " thousand ";
                number %= thousandsPlace;
            }

            if (number / hundredsPlace > 0)
            {
                inWords += TransformNumberToWords(number / hundredsPlace) + " hundred ";
                number %= hundredsPlace;
            }

            if (number > 0)
            {
                inWords += GetTens(number);
            }

            return inWords;
        }

        private string GetTens(int number)
        {
            string str = "";

            if (number > 19)
            {
                str += tensList[number / tensPlace] + " ";
                number %= tensPlace;
            }

            if (number > 0)
            {
                str += onesList[number];
            }
            return str;
        }

        private string[] onesList = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Nineteen" };
        private string[] tensList = new string[] { "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
    }

    public class NumberToWordsTransformationApproachTwo
    {
        private static int tensPlace = 10;
        private static int hundredsPlace = 100;
        private static int thousandsPlace = 1000;
        private static int tenThousandsPlace = 10000;
        private static int hundredThousandsPlace = 100000;
        private static int millionPlace = 1000000;
        private static int tenMillionsPlace = 10000000;
        private static int hundredMillionsPlace = 100000000;

        public NumberToWordsTransformationApproachTwo()
        {
            TransformNumberToWords(8617240);
        }

        public void TransformNumberToWords(int number)
        {

            Console.WriteLine(number / hundredMillionsPlace + " hundred millions.");
            number %= hundredMillionsPlace;
            //Console.WriteLine(number/tenMillionsPlace + " ten millions.");
            //number %= tenMillionsPlace;
            int millions = number / millionPlace;
            Console.Write(GetTens(millions) + " million ");
            //int millions = number/millionPlace;
            //if(millions > 19)
            //{
            //  Console.Write(tensList[millions/tensPlace] + " ");
            //  millions %= tensPlace;
            //}

            //Console.Write(onesList[millions] + " million ");
            number %= millionPlace;

            Console.Write(onesList[number / hundredThousandsPlace] + " hundred ");
            number %= hundredThousandsPlace;

            int thousands = number / thousandsPlace;
            //Console.WriteLine(number/tenThousandsPlace + " ten thousands.");
            //number %= tenThousandsPlace;

            Console.Write(GetTens(thousands) + " thousand ");
            //if(thousands > 19)
            //{
            //  Console.Write(tensList[thousands/tensPlace] + " ");
            //  thousands %= tensPlace;
            //}

            //Console.Write(onesList[thousands] + " thousand ");
            number %= thousandsPlace;

            Console.Write(onesList[number / hundredsPlace] + " hundred ");
            number %= hundredsPlace;

            Console.Write(GetTens(number));
            //if(number > 19)
            //{
            //  Console.Write(tensList[number/tensPlace] + " ");
            //  number %= tensPlace;
            //}

            //Console.Write(onesList[number/onesPlace]);
        }

        private string GetTens(int number)
        {
            string str = "";

            if (number > 19)
            {
                str += tensList[number / tensPlace] + " ";
                number %= tensPlace;
            }
            str += onesList[number];

            return str;
        }

        private string[] onesList = new string[] {
            "", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Nineteen" };

        private string[] tensList = new string[] {
            "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
    }
}
