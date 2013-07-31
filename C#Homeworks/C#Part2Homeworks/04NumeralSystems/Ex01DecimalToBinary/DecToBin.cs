//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01DecimalToBinary
{
    class DecToBin
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<int> binaryNum = new List<int>();
            while (number > 0)
            {
                binaryNum.Add(number % 2);
                number = number / 2;
            }
            binaryNum.Reverse();
            Console.WriteLine("This is the binary representation of the number:");
            for (int i = 0; i <binaryNum.Count; i++)
            {
                Console.Write(binaryNum[i]);
            }
            Console.WriteLine();
            
        }
        
    }
}
