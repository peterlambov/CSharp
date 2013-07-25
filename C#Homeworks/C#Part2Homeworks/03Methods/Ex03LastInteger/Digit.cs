//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Digit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigit(number));
        }
        static string LastDigit(int number)
        {
            int remainder = number % 10;
            string digitWord = "";
            switch (remainder)
            {
                case 0: digitWord = "zero";
                    break;
                case 1: digitWord = "one";
                    break;
                case 2:digitWord="two";
                    break;
                case 3:digitWord="three";
                    break;
                case 4:digitWord="four";
                    break;
                case 5: digitWord = "five";
                    break;
                case 6: digitWord = "six";
                    break;
                case 7: digitWord = "seven";
                    break;
                case 8: digitWord = "eight";
                    break;
                case 9: digitWord = "nine";
                    break;
                default: digitWord = ""; 
                    break;
            }

            return digitWord;
        }
    }

