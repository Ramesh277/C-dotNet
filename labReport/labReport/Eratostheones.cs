﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labReport
{
    internal class Eratostheones
    {
        static bool[] SieveOfEratosthenes(int n)
        {
            bool[] array = new bool[n];
            for (int i = 2; i < n; i++)
            {
                array[i] = true;
            }
            for (int j = 2; j * j <= n; j++)
            {
                if (array[j] == true)
                {
                    for (int k = j * j; k < n; k += j)
                    {
                        array[k] = false;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            var arrayOfPrimes = SieveOfEratosthenes(100);
            for (int i = 0; i < arrayOfPrimes.Length; i++)
            {
                if (arrayOfPrimes[i] != false)
                {
                    Console.Write($"{i} "); // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59

                }
            }
            }
        }
}
