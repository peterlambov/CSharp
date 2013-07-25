//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class NumberInArray

    {
        static void Main()
        {
            Console.WriteLine("Enter your number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of elements of the array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter each element:");
            //int[] array = { 1, 5, 5, 5, 5, 0, 0, 0, 4, 6 }; 
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            { 
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your number {0} exists in the array {1} times.",number,NumberOfTimes(array, number));
        }
        public static int NumberOfTimes(int[] array,int number)
        {
            int numberOfTimes = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    numberOfTimes++;
                }
            }
            return numberOfTimes;
        }
    }

