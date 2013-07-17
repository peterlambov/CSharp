//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

    class FactorialExpression
    {
        static void Main()
        {
            Console.Write("Please enter N:");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Please enter K:");
            int K = int.Parse(Console.ReadLine());
            BigInteger Nfactorial = 1;
            BigInteger Kfactorial = 1;
            for (int i = 1; i <= N; i++)
            {
                Nfactorial *= i;
            }
            for (int j = 1; j <= K; j++)
            {
                Kfactorial *= j;
            }
            BigInteger KminusNFactorial = 1;
            for (int i = 1; i <=(K-N); i++)
            {
                KminusNFactorial *= i;
                
            }
            Console.Write("The result of the expression is:");
            Console.WriteLine((Nfactorial*Kfactorial)/KminusNFactorial);
        }
    }

