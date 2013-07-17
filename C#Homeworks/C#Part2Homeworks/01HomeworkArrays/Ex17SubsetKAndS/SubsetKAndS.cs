//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

    class SubsetKAndS
    {
        static void Main()
        {
            Console.WriteLine("Enter N for number of elements,K for number of elements of the sum and S for the sum:");
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            Console.WriteLine("Enter each element:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            string subset = "";
            int maxSubsets = (int)Math.Pow(2, N) - 1;
            for (int i = 1; i <= maxSubsets; i++)
            {
                subset = "";
                long checkingSum = 0;
                int lenCounter = 0;
                for (int j = 0; j <= N; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        checkingSum = checkingSum + array[j];
                        subset = subset + " " + array[j];
                        lenCounter++;
                    }
                }
                if (checkingSum == S && lenCounter==K)
                {
                    Console.WriteLine("Number of subsets that have the sum of {0}:", S);
                    counter++;
                    Console.WriteLine("This subset has a sum of {0} : {1} and exactly {2} members.", S, subset,K);
                }
            }
            Console.WriteLine(counter);
        }
    }

