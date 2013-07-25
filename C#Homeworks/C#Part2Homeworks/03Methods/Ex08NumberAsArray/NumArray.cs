//Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element arr[i] contains a digit;
//the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Linq;
using System.Numerics;

namespace Ex08NumberAsArray
{
    class NumArray
    {
        static void Main()
        {
            BigInteger[] firstNum = { 1,4,9};
            BigInteger[] secondNum =  {1,3,0,9,5};
            NumberSum(firstNum, secondNum);
        }
    public static void NumberSum(BigInteger[] firstNumber, BigInteger[] secondNumber)
    {
        Array.Reverse(firstNumber);
        Array.Reverse(secondNumber);
        int neededLength = 0;
        if (firstNumber.Length > secondNumber.Length)
        {
            neededLength = firstNumber.Length + 1;
        }
        else
        {
            neededLength = secondNumber.Length + 1;
        }

        BigInteger[] newNumber = new BigInteger[neededLength];//We declare an empty array with the length of the longer number+1 
        //we add "1" because the length might get longer with one than the longer number.
        for (int i = 0; i < newNumber.Length; i++)
        {
            if (i < firstNumber.Length)
            {
                newNumber[i] = newNumber[i] + firstNumber[i];//Here we fill the array with the first number's digits,
                //until we reach the end of the first number
                if (newNumber[i] >= 10)
                {
                    newNumber[i] = newNumber[i] - 10;
                    newNumber[i + 1] = newNumber[i + 1] + 1;
                }
            }

            if (i < secondNumber.Length)//In the same time we add each of the digits of the second number.
            {
                newNumber[i] = newNumber[i] + secondNumber[i];
                if (newNumber[i] >= 10)
                {
                    newNumber[i] = newNumber[i] - 10;
                    newNumber[i + 1] = newNumber[i + 1] + 1;
                }
            }
        }

        Array.Reverse(newNumber); //We reverse the array because our algorithm starts from the first digit,
        //not from the last as we normally do.
        for (int i = 0; i < newNumber.Length; i++)
        {
            Console.Write(newNumber[i]);
        }

        Console.WriteLine();
    }

    
}
    
}
