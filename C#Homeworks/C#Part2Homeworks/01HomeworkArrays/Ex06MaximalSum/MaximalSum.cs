//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.
using System;

    class MaximalSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int S = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            
            for (int i = N-K; i <N; i++)
            {
                S = S + array[i];
            }
            Console.WriteLine(S);
           
            
            

        }
    }

