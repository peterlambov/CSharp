//Write a program that reads a date and time given in the format: day.month.year
//hour:minute:second and prints the date and time after 6 hours and 30 minutes 
//(in the same format) along with the day of week in Bulgarian.
using System;
using System.Globalization;
using System.Linq;
namespace Ex17TimeAfterHours
{
    class SixAndAHalfHours
    {
        static void Main()
        {
            string currentDate = "20.08.2013 21:30:10";
            DateTime currentD = DateTime.ParseExact(currentDate, "d.MM.yyyy HH:mm:ss",CultureInfo.InvariantCulture);
            DateTime afterHours = currentD.AddHours(6).AddMinutes(30);
            string final = afterHours.ToString("dddd", new CultureInfo("bg-BG")); //We get the day in BG language.
            Console.WriteLine(final);
        }
    }
}
