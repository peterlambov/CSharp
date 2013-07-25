//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaxInteger
    {
        static void Main()
        {
            //Console.WriteLine("Enter the first number:");//In the following code we use the method for only two numbers.
           // int firstNum = int.Parse(Console.ReadLine());
           // Console.WriteLine("Enter the second number:");
           // int secondNum = int.Parse(Console.ReadLine());
           // GetMax(firstNum, secondNum);
            Console.WriteLine("Enter three numbers,each on a separate line:");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int tempBigger=GetMax(firstNum, secondNum);
            Console.WriteLine(GetMax(tempBigger, thirdNum));
        }
        static int GetMax(int firstNumber, int secondNumber)
        {
            int maxNumber = firstNumber;
            if (firstNumber < secondNumber)
            {
                maxNumber = secondNumber;
            }
            return maxNumber;
            
        }
    }

