//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class BinarySearch
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements N and the elements after that.");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("Enter the integer K:");
            int K = int.Parse(Console.ReadLine());
            int result=0;
            if (array[0] > K)
            {
                Console.WriteLine("There is no number that is smaller than or equal to K.");
            }
            else
            {
                int index = Array.BinarySearch(array, K);
                if (index >= 0)
                {
                    result = array[index];
                }
                else
                {
                    result = array[~index-1];
                    
                }
                Console.WriteLine("The largest number smaller than or equal to K is {0}.",result);
            }
            

    }
    }
    

