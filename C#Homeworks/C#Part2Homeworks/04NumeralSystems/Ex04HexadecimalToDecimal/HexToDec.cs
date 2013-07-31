//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Linq;
namespace Ex04HexadecimalToDecimal
{
    class HexToDec
    {
        static void Main()
        {
            string number = Console.ReadLine();
            char[] decArray = number.ToCharArray();
            Array.Reverse(decArray);
            double sum = 0;//This is where we going to keep the actual decimal number.
            for (int i = 0; i < decArray.Length; i++)
            {
                double digit = 0;
                switch (decArray[i])
                {
                    case 'A': digit = 10;
                        break;
                    case 'B': digit = 11;
                        break;
                    case 'C': digit = 12; 
                        break;
                    case 'D': digit = 13;
                        break;
                    case 'E': digit = 14;
                        break;
                    case 'F': digit = 15;
                        break;
                    default: digit = double.Parse(decArray[i].ToString());
                        break;
                }
                    for (int j = 0; j < i; j++)
                    {
                        digit = digit * 16;
                    }
                
                sum += digit;
            }
            Console.WriteLine(sum);
          

        }
          
    }
}
