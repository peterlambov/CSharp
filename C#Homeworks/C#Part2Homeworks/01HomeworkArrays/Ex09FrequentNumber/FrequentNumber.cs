//Write a program that finds the most frequent number in an array. 
//Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;
using System.Text;

    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i <array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int maxCounter = 1;
            int mostFrequent = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        mostFrequent = array[i];
                    }
                }
            }

            if (maxCounter > 1)
            {
                Console.WriteLine("The number {0} is the most frequent member of the array, it is used {1} times .", mostFrequent, maxCounter);
            }
            else
            {
                Console.WriteLine("Each number is different from the others, there isn't most frequent one");
            }
        }
    }

