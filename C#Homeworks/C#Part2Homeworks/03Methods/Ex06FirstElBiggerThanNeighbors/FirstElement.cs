//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
//if there’s no such element.
using System;
using System.Linq;
    class FirstElement
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 10, 21, 12, 7, 6, 5, };
            Console.WriteLine("The first element that is bigger than its neighbors has index:{0}.",FirstBiggerThanNeighbors(array));
            //The counting starts from 0
            //If there isn't such element its index will be -1 /doesn't exist/
        }
        static int FirstBiggerThanNeighbors(int[] array)
        {
            int indexOfFirst = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    indexOfFirst = i;
                    break;
                }
                else
                    {
                        indexOfFirst = -1;
                    }
                
            }
            return indexOfFirst;
        }
    }

