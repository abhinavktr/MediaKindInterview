using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class FindRepeatedWord
    {
        public void Main()
        {
            Console.WriteLine("Hello");

            string sentence = "Had Haddock had. a fit?";
            string word = "had";
            char[] delem = new char[] { ' ', '.' };
            Console.WriteLine(firstRepeatedWord(sentence, word, delem));

            Console.WriteLine("Done");
        }

        public string firstRepeatedWord(string sentence, string word, char[] delem)
        {
            string repeatedIndexAndWord = "";
            string[] words = sentence.Split(delem);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    repeatedIndexAndWord = $"{i} - {words[i]}";
                    break;
                }
            }

            return repeatedIndexAndWord;
        }
    }
}
