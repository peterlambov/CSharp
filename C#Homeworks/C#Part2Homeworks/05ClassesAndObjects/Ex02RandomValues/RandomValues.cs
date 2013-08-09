//Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;
using System.Linq;
namespace Ex02RandomValues
{
    class RandomValues
    {
        static void Main(string[] args)
        {
            Random range=new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}",range.Next(100,201));
            }
        }
    }
}
