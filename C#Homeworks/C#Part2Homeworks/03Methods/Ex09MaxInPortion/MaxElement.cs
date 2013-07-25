//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Linq;

class MaxElement
    {
        static void Main()
        {
            Console.WriteLine("Enter number of elements in your array:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the index of the element that you want to start from:");
            int givenIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Max element in this portion = {0}.",MaxElementInPortion(array, givenIndex));
            Console.Write("Type true for sorting the array ascending or false for descending sort:");
            bool ascending = bool.Parse(Console.ReadLine());
            SelectionSort(array, ascending);
            PrintArray(array);
           
        }
        static int MaxElementInPortion(int[] array,int givenIndex)
        {
            int biggestIndex = givenIndex;
            for (int i = givenIndex; i < array.Length; i++)
            {
                if (array[givenIndex] < array[i])
                {
                    biggestIndex = i;
                }
            }
            return array[biggestIndex];
        }
        static void SelectionSort(int[] array,bool ascending)
        {

            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            if (ascending == false)
            {
                Array.Reverse(array);
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+" ");
            }
        }
    }

