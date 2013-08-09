//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
using System;
using System.Linq;
namespace Ex01LeapYear
{
    class Leap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year:");
            int year= int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.",year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.",year);
            }

            
        }
    }
}
