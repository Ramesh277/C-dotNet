using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Lettersbalance
    {
        static bool LettersBalance(string word)
        {
            bool isBalanced;
            for (int i = 0; i < word.Length / 2; i++)
            {
                isBalanced = false;
                for (int j = word.Length - 1; j >= word.Length / 2; j--)
                {
                    if (word[i] == word[j])
                    {
                        isBalanced = true;
                    }
                }
                if (!isBalanced)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LettersBalance("kfdfdk")); // True
            Console.WriteLine(LettersBalance("reyjer")); // False
            Console.WriteLine(LettersBalance("wkxzcsazsckawx")); // True
            Console.WriteLine(LettersBalance("pkmqsdedeskgqm")); // False
        }
    }
}
