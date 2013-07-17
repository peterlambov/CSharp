//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	//N = 10 -> N! = 3628800 -> 2
	//N = 20 -> N! = 2432902008176640000 -> 4

using System;
using System.Numerics;

    class TrailingZeros
    {
        static void Main()
        {
            Console.Write("Enter your number N:");
            int N = int.Parse(Console.ReadLine());
            BigInteger Nfactorial = 1;
            int trailingZeroes = 0;
            int XOnN = 5;
            for (int i = 1; i <=N; i++)
            {
                Nfactorial *= i;
                XOnN=(int)Math.Pow(XOnN,i);
                trailingZeroes += ((N / XOnN));//The number of trailing zeros of a number is given by the formula: n/5+n/25+n/125....+n/5^n
            }

            Console.WriteLine("This is N factorial: {0}",Nfactorial);
            Console.WriteLine("The number of trailing zeros is: {0}", trailingZeroes);
        }
    }

