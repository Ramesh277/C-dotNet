using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class FullSequenceLetter
    {
        static string FullSequenceOfLetters(string word)
        {
            string fullSequence = string.Empty;
            for (int i = word[0], j = 0; i <= word[1]; i++, j++)
            {
                fullSequence += (char)(word[0] + j);
            }
            return fullSequence;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FullSequenceOfLetters("bg")); // bcdefg
            Console.WriteLine(FullSequenceOfLetters("xy")); // xy 
            Console.WriteLine(FullSequenceOfLetters("az")); // abcdefghijklmnopqrstuvwxyz
        }
    }
}
