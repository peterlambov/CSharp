//Write a method that checks if the element at given position in given array of integers
//is bigger than its two neighbors (when such exist).
using System;
using System.Linq;



   public class Neighbors
    {
        static void Main()
      {
        int[] array = new int[] { 1, 9, 0, 6, 4, 12, 9, 3, -50, 1, 20, 14, 5 };
        Console.WriteLine("Enter the position of the element that you want to check:"); //Position starts from 1, not from zero.
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("The element at position {0} is bigger than its two neighbors:{1}.",position, BiggerThanNeughbors(array, position));
      }
       public static bool BiggerThanNeughbors(int[] array, int position)
        {

            if (position == 1)
            {
                return false;
            }
            else if (position >= array.Length)
            {
                return false;
            }
            else
            {

                if (array[position - 2] < array[position - 1] && array[position - 1] > array[position])
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }

