//Write a program that finds the maximal sequence of equal elements in an array.
		//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

    class SequenceOfEqualElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)

            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int len = 1;
            int bestLen = 0;
            int bestLenElement = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestLenElement = array[i];
                    }
                    len = 1;
                }
            }
            
            if (len > bestLen)
            {
                bestLen = len;
                bestLenElement = array[array.Length - 1];
            }
            Console.WriteLine("The longest sequence is from {0} elements of type \"{1}\" .", bestLen, bestLenElement);
            
        }
    }

