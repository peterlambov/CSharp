//* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//  Example:n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;

    class Permutations
    {
        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
        static void Permute(int[] array, int current, int len)
        {
            if (current == len)
            {
                for (int i = 0; i <= len; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = current; i <= len; i++)
                {
                    Swap(ref array[i], ref array[current]);
                    Permute(array, current + 1, len);
                    Swap(ref array[i], ref array[current]);
                }
            }

        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 1; i <=array.Length; i++)
            {

                array[i - 1] = i;
            }
            Permute(array, 0, array.Length - 1);
        }
    }

