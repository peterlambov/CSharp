//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class PrimeNumbers
{

    static void Main()
    {
        bool[] allElements = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(allElements.Length); i++)
        {
            if (allElements[i] == false)
            {
                for (int j = i * i; j < allElements.Length; j = j + i)
                {
                    allElements[j] = true;
                }
            }
        }
        for (int i = 2; i < allElements.Length; i++)
        {
            if (allElements[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }

}

