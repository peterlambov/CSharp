﻿//Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input.
// If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100;
// if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
//Use a switch statement and at the end print the calculated new value in the console.

using System;
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("Please enter your score");
            int score = int.Parse(Console.ReadLine());
            Console.Write("This is your new score after your bonus was added:");
            switch (score)
            {
                case 1: 
                    Console.WriteLine(score * 10);
                    break;
                case 2: 
                    Console.WriteLine(score*10);
                    break;
                case 3: 
                    Console.WriteLine(score*10);
                    break;
                case 4:
                    Console.WriteLine(score*100);
                    break;
                case 5:
                    Console.WriteLine(score*100);
                    break;
                case 6: 
                    Console.WriteLine(score*100);
                    break;
                case 7: 
                    Console.WriteLine(score*1000);
                    break;
                case 8: 
                    Console.WriteLine(score*1000);
                    break;
                case 9: 
                    Console.WriteLine(score*1000);
                    break;
                default: 
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }

