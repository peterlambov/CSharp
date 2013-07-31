//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03DecimalToHexadecimal
{
    class DecToHex
    {
        static void Main()
        {
            Console.WriteLine("Enter your number:");
            int number = int.Parse(Console.ReadLine());
            List<string> hexNumber = new List<string>();
            while (number > 0)
            {
                switch (number % 16)
                {
                    case 10: hexNumber.Add("A");
                        break;
                    case 11: hexNumber.Add("B");
                        break;
                    case 12: hexNumber.Add("C");
                        break;
                    case 13: hexNumber.Add("D");
                        break;
                    case 14: hexNumber.Add("E");
                        break;
                    case 15: hexNumber.Add("F");
                        break;
                    default: hexNumber.Add((number % 16).ToString());
                        break;
                }
                number = number / 16;
            }
            hexNumber.Reverse();
            for (int i = 0; i < hexNumber.Count; i++)
            {
                Console.Write("{0}",hexNumber[i]);
            }
            Console.WriteLine();

           
        }
    }
}
