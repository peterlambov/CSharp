//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex02BinaryToDecimal
{
    class BinToDec
    {
        static void Main()
        {
           long number = long.Parse(Console.ReadLine());
           List<double> digits = new List<double>();
           while (number > 0)
           {
               digits.Add(number % 10);
               number = number / 10;
           }
          
           for (int i = 0; i < digits.Count; i++)
           {
               digits[i] = digits[i]*Math.Pow(2, i);
           }
           double sum = 0;
           for (int i = 0; i < digits.Count; i++)
           {
               sum += digits[i];
           }
           Console.WriteLine("The decimal representation of the number is: {0}.",sum);
           
           
        }
    }
}
