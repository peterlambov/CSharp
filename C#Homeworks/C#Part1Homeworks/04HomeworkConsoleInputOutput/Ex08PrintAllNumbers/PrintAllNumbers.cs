//Write a program that reads an integer number n from the console
//and prints all the numbers in the interval [1..n],
//each on a single line.
using System;
namespace Ex08PrintAllNumbers
{
    class PrintAllNumbers
    {
        static void Main()
        {
            Console.Write("Enter the number n:");
            int n = int.Parse(Console.ReadLine());
            int number=0;
            for (int i = 0; i < n; i++)
            {
                
                number += 1;
                Console.WriteLine(number);
            }
           
        }
    }
}
