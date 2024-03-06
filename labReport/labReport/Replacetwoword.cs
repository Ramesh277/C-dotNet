using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Replacetwoword
    {
        public static string ReplaceWords(string word, char ch)
        {
            string firstWord = string.Empty;
            string secondWord = string.Empty;
            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[i] != ch)
                {
                    secondWord += word[i];
                }
                else
                {
                    for (int j = i + 1; j <= word.Length - 1; j++)
                    {
                        firstWord += word[j];
                    }
                    break;
                }
            }
            return firstWord + ch + secondWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceWords("dog_octopus", '_')); // octopus_dog
            Console.WriteLine(ReplaceWords("a.b", '.')); // b.a
            Console.WriteLine(ReplaceWords("good very", ' ')); // very good
        }
    }
}
