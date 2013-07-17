//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;
  class IncreasingSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int len = 1;
            int bestLen = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestLen = len;
                        index = i;
                    }
                    len = 1;
                }
            }
            if (len > bestLen)
            {
                bestLen = len;
                index = array.Length - 1;
            }
            Console.WriteLine("This is the longest increasing sequence:");        
            for (int i = index-bestLen + 1; i < index+1; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
         
         
            
        }
    }

