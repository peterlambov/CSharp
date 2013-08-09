//Write a program that prints to the console which day of the week is today. Use System.DateTime.
using System;
using System.Linq;
namespace Ex03DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime currentDay = DateTime.Now;
            Console.WriteLine(currentDay.DayOfWeek);
        }
    }
}
