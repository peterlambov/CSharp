using System;
using System.Linq;

public class ThrowException
{
    static void ReadInteger(int start,int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number<start ||number>end)
        {
            throw new InvalidRangeException<int>("Number is either too small or too large.", start, end);
        }
    }

    static void ReadDateTime(DateTime start, DateTime end)
    {
        string[] dates = Console.ReadLine().Split('/'); //the date should be int the format yyy/mm/dd
        DateTime currentDate = new DateTime(int.Parse(dates[0]), int.Parse(dates[1]), int.Parse(dates[2]));
        if (currentDate<start || currentDate>end)
        {
            throw new InvalidRangeException<DateTime>("The date is either too early or too late.", start, end);
        }
    }
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a integer number in range [1 … 100]");
            ReadInteger(1, 100);
        }
        catch (InvalidRangeException<int> except) //We catch the most concrete exception
        {

            Console.WriteLine(except.Message);
        }

        try
        {
            Console.WriteLine("Enter a DateTime number in range [1.1.1980 … 31.12.2013]");
            ReadDateTime(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
        }
        catch (InvalidRangeException<DateTime> except)
        {

            Console.WriteLine(except.Message);
        }
    }


    
}

