//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class QuotientOfFactorial
    {
        static void Main()
        {
            Console.Write("Please enter N:");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Please enter K:");
            int K = int.Parse(Console.ReadLine());
            decimal Nfactorial = 1;
            decimal Kfactorial = 1;
            for (int i = 1; i <=N; i++)
            {
                Nfactorial *= i; 
            }
            for (int j = 1; j <= K; j++)
            {
                Kfactorial *= j;
            }
            Console.WriteLine(Nfactorial/Kfactorial);
            
            
        }
    }

