//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
namespace Ex19DateCanada
{
    class Canada
    {
        static void Main()
        {
            string text = "Today is 15.08.2013 and on 14.09.2013 we have an exam, in other words on 14/09/2013";
            MatchCollection dates = Regex.Matches(text, @"(0?[1-9]|[12][0-9]|3[01])[.](0?[1-9]|1[012])[.]\d{4}");
            foreach (Match date in dates)
            {
                DateTime d = DateTime.Parse(date.ToString());
                Console.WriteLine(d.ToString("dd.MM.yyyy", new CultureInfo("en-CA")));
                //Console.WriteLine(d.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}
