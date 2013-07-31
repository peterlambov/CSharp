//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08BinaryShort
{
    class BinShort
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<int> binNumber = new List<int>();
            StringBuilder binary = new StringBuilder();
            if (number > 0)
            {

                while (number > 0)
                {
                    binNumber.Add(number % 2);
                    number /= 2;
                }
                while (binNumber.Count % 16 != 0)
                {
                    binNumber.Add(0);
                }
                binNumber.Reverse();

                for (int i = 0; i < binNumber.Count; i++)
                {
                    binary.Append(binNumber[i]);
                }

                Console.WriteLine(binary);
            }
            else
            {
                
                number = Math.Abs(number) - 1;
                while(number>0)
                {
                    binNumber.Add(number % 2);
                    number /= 2;
                }
                while (binNumber.Count % 16 != 0)
                {
                    binNumber.Add(0);
                }
                binNumber.Reverse();
                for (int i = 0; i < binNumber.Count; i++)
                {
                    if (binNumber[i] == 0)
                    {
                        binary.Append(1);
                    }
                    else
                    {
                        binary.Append(0);
                    }
                }
                Console.WriteLine(binary);
                              

            }
        }
    }
}
