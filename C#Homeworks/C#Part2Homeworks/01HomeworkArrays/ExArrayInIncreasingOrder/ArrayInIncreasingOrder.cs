//* Write a program that reads an array of integers and removes from it a minimal number of elements in such way
//that the remaining array is sorted in increasing order. Print the remaining sorted array. 
//Example:{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

using System;

    class ArrayInIncreasingOrder
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }

