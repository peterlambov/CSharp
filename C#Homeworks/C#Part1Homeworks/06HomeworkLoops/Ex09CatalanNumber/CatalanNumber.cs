//Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

    class CatalanNumber
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            BigInteger n = int.Parse(Console.ReadLine());
            BigInteger Nfactorial = 1;
            BigInteger TwoNFactorial = 1;
            BigInteger NplusOneFactorial = 1;
            if (n < 0)
            {
                Console.WriteLine("Invalid N!");
            }
            for (int i = 1; i <= n; i++)
            {
                Nfactorial *= i;
            }
            for(int j = 1; j<=2*n ;j++)
            {
                TwoNFactorial*=j;
            }
            for (int f = 1; f <= (n + 1); f++)
            {
                NplusOneFactorial *= f;
            }
            Console.Write("The Nth Catalan number is: ");
            Console.WriteLine(TwoNFactorial/(NplusOneFactorial*Nfactorial));

        }
    }

