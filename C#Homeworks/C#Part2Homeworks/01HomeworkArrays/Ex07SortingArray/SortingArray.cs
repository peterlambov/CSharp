//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SortingArray
{
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int minIndex = 0;
        int tempElement;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] <= array[minIndex])
                {
                    minIndex = j;
                }

            }
            tempElement = array[i];
            array[i] = array[minIndex];
            array[minIndex] = tempElement;
        }
        Console.WriteLine("This is the sorted array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
         
            
           
}


