//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except
//a fixed list of public holidays specified preliminary as array.
using System;
using System.Linq;


namespace Ex05WorkDays
{
    class Work
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the year, the month and the day of the last day that you want to check, each on a separate line:");
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            DateTime endDate = new DateTime(year, month, day);
            DateTime startDate = DateTime.Today;
            int daysLength = 0;
            daysLength = Math.Abs((startDate - endDate).Days);
            if (startDate > endDate)
            {
                startDate = endDate;
                endDate = DateTime.Today;
            }
            DateTime[] holidayDays = { new DateTime(2013, 1, 1), new DateTime(2013, 3, 8), new DateTime(2012, 1, 1), new DateTime(2013, 12, 25) };
            bool realHoliday = false;
            int workLength = 0;
            for (int i = 0; i < daysLength; i++)
            {
                startDate = startDate.AddDays(1);
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    for (int k = 0; k < holidayDays.Length; k++)
                    {
                        if (startDate == holidayDays[k])
                        {
                            realHoliday = true;
                            break;
                        }

                    }
                    if (!realHoliday)
                    {
                        workLength++;
                    }
                    realHoliday = false;
                }
            }
            Console.WriteLine("The  number of workdays is: {0}",workLength);
        }
            
       
    }
}
