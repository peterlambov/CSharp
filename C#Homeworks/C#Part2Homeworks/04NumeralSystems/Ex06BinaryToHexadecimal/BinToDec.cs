//Write a program to convert binary numbers to hexadecimal numbers (directly).
// 0x0 = 0000      0x8 = 1000
// 0x1 = 0001	   0x9 = 1001	     									
// 0x2 = 0010      0xA = 1010
// 0x3 = 0011      0xB = 1011
// 0x4 = 0100      0xC = 1100
// 0x5 = 0101      0xD = 1101  THE FOLLOWING PROGRAM IS DESIGNED TO WORK WITH BINARY NUMBERS USING THE FORMAT IN THE LEFT.
// 0x6 = 0110      0xE = 1110
// 0x7 = 0111      0xF = 1111

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06BinaryToHexadecimal
{
    class BinToDec
    {
        static void Main(string[] args)
        {
            //Be careful, if you don't enter the binary number correctly , the program is going to throw an exception!
            string binNumber = Console.ReadLine();
            char[] binArray = binNumber.ToCharArray();
            int remainder = binArray.Length % 4;
            List<string> realNum = new List<string>();
            binArray = (new string('0', remainder) + binNumber).ToCharArray();
            for (int i = 0; i < binArray.Length - 1; i += 4)
            {
                string bit = string.Concat(binArray[i].ToString(), binArray[i + 1].ToString(), binArray[i + 2].ToString(), binArray[i + 3].ToString());
                switch (bit)
                {
                    case "0000": realNum.Add("0");
                        break;
                    case "0001": realNum.Add("1");
                        break;
                    case "0010": realNum.Add("2");
                        break;
                    case "0011": realNum.Add("3");
                        break;
                    case "0100": realNum.Add("4");
                        break;
                    case "0101": realNum.Add("5");
                        break;
                    case "0110": realNum.Add("6");
                        break;
                    case "0111": realNum.Add("7");
                        break;
                    case "1000": realNum.Add("8");
                        break;
                    case "1001": realNum.Add("9");
                        break;
                    case "1010": realNum.Add("A");
                        break;
                    case "1011": realNum.Add("B");
                        break;
                    case "1100": realNum.Add("C");
                        break;
                    case "1101": realNum.Add("D");
                        break;
                    case "1110": realNum.Add("E");
                        break;
                    case "1111": realNum.Add("F");
                        break;
                    default:
                        break;

                }
            }
            for (int i = 0; i < realNum.Count; i++)
            {
                Console.Write(realNum[i]);
            }
            Console.WriteLine();
        }
    }
}

