//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
using System;
using System.Globalization;
using System.Linq;
namespace Ex16Days
{
    class Dates
    {
        static void Main(string[] args)
        {
            string firstDate = "27.02.2006";
            string secondDate = "3.03.2006";
            DateTime startDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine((endDate - startDate).TotalDays);
            //This is the second variant, here the format is always validated - input like 27/02,2006 is not a problem.
            //string[] first=firstDate.Split( new char[] {' ','.',',','/','\\'});
            //string[] second = secondDate.Split(new char[] { ' ', '.', ',', '/', '\\' });
            //string fDate = string.Join(".", first);
            //string sDAte = string.Join(".", second);
            //DateTime start = DateTime.ParseExact(fDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            //DateTime end = DateTime.ParseExact(sDAte, "d.MM.yyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine((end-start).TotalDays);
        }
    }
}
