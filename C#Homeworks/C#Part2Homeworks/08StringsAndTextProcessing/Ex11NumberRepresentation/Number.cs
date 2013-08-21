//Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.
using System;
using System.Linq;
namespace Ex11NumberRepresentation
{
    class Number
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Decimal:");
            Decimal(number);
            Console.WriteLine("Hexadecimal:");
            Hexadecimal(number);
            Console.WriteLine("Percentage:");
            Percentage(number);
            Console.WriteLine("Scientific:");
            Scientific(number);

        }
        public static void Decimal(int number)
        {
            string realNum = string.Format("{0,15:D}",number);
            Console.WriteLine(realNum);
        }
        public static void Hexadecimal(int number)
        {
            string realNum = String.Format("{0,15:X}", number);
            Console.WriteLine(realNum);
        }
        public static void Percentage(int number)
        {
            string realNum = String.Format("{0,15:P}", number);
                Console.WriteLine(realNum);
        }
        public static void Scientific(int number)
        {
            string realNum = String.Format("{0,15:E}", number);
            Console.WriteLine(realNum);
        }
    }
}
