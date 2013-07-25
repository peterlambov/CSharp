//Write a method that reverses the digits of given decimal number. Example: 256  652
using System;
using System.Linq;

namespace Ex07ReverseDigits
{
    class ReverseDigits
    {
        static void Main()
        {
            Console.WriteLine("Enter your number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReversedNumber(number));
        }

        static int ReversedNumber(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result = result * 10 + number % 10;
                number = number / 10;
            }
            return result;
        }
    }
}

