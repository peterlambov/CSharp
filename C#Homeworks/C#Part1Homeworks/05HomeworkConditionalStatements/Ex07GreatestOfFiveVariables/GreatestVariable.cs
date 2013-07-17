//Write a program that finds the greatest of given 5 variables.

using System;

    class GreatestVariable
    {
        static void Main()
        {
            Console.Write("Enter the first number:");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            double secondfNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number:");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number:");
            double fourthNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the fifth number:");
            double fifthNum = double.Parse(Console.ReadLine());
            double biggestNum = firstNum;
            if (biggestNum < secondfNum)
            {
                biggestNum = secondfNum;
            }
            if (biggestNum < thirdNum)
            {
                biggestNum = thirdNum;
            }
            if (biggestNum < fourthNum)
            {
                biggestNum = fourthNum;
            }
            if (biggestNum < fifthNum)
            {
                biggestNum = fifthNum;
            }
            Console.WriteLine("The biggest of the five numbers is: {0}",biggestNum);
           

        }
    }

