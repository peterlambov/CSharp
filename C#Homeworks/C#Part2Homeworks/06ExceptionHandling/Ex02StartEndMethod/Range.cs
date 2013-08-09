//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//	a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;
using System.Linq;
namespace Ex02StartEndMethod
{
    class Range
    {
        static int number;
        static void Main()
        {
            //number = 12;
            //StartEnd(21, 45); This part of the code works for a single number and immediately throws ArgumentOutOfRangeException according to the method's design.
            //The following part gets the 10 numbers from the console as long as they are a1<a2<...<a10.
            try
            {
                int start = 1;
                int end = 100;
                for (int i = 0; i < 10; i++)
                {
                    number = int.Parse(Console.ReadLine());
                    StartEnd(start, end);
                    start = number;
                }
            }
            catch (OverflowException OverF)
            {
                Console.WriteLine(OverF.Message);
            }
            catch (FormatException formEx)
            {
                Console.WriteLine(formEx.Message);
            }
        }
        static void StartEnd(int start, int end)
        {
            
            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException("The number is either smaller than the previous one or bigger than the end number!" );
            }
        }
    }
}
