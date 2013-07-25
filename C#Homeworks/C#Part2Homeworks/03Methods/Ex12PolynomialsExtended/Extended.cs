//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//x2 + 5 = 1x2 + 0x + 5 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PolynomialsExtended
{
    static void Main()
    {
        int[] firstPol = { 5, 6, 1 };
        int[] secondPol = { 3, 4, 5 };
        Console.WriteLine("Sum:");
        PolynomSum(firstPol, secondPol);
        Console.WriteLine("Substract:");
        PolynomSubstraction(firstPol, secondPol);
        Console.WriteLine("Product:");
        PolynomMultiplication(firstPol, secondPol);
    }
    static void PolynomSum(int[] firstPol, int[] secondPol)
    {
        List<int> sumPol = new List<int>();
        if (firstPol.Length >= secondPol.Length)
        {
            for (int i = 0; i < firstPol.Length; i++)
            {
                sumPol.Add(firstPol[i] + secondPol[i]);
            }
        }
        else
        {
            for (int i = 0; i < secondPol.Length; i++)
            {
                sumPol.Add(firstPol[i] + secondPol[i]);
            }
        }
        StringBuilder strSumPol = new StringBuilder();
        if (sumPol[0] != 0)
        {
            strSumPol.AppendFormat("{0} ", sumPol[0]);
        }
        for (int i = 1; i < sumPol.Count; i++)
        {
            if (sumPol[i] != 0 && sumPol[i] > 0)
            {
                strSumPol.AppendFormat("+ {0}x^{1} ", sumPol[i], i);
            }
            if (sumPol[i] < 0)
            {
                strSumPol.AppendFormat("{0}x^{1} ", sumPol[i], i);
            }
        }
        Console.WriteLine(strSumPol.ToString());
    }
    static void PolynomSubstraction(int[] firstPol, int[] secondPol)
    {
        List<int> sumPol = new List<int>();
        if (firstPol.Length >= secondPol.Length)
        {
            for (int i = 0; i < firstPol.Length; i++)
            {
                sumPol.Add(firstPol[i] - secondPol[i]);
            }
        }
        else
        {
            for (int i = 0; i < secondPol.Length; i++)
            {
                sumPol.Add(firstPol[i] - secondPol[i]);
            }
        }
        StringBuilder strSumPol = new StringBuilder();
        if (sumPol[0] != 0)
        {
            strSumPol.AppendFormat("{0} ", sumPol[0]);
        }
        for (int i = 1; i < sumPol.Count; i++)
        {
            if (sumPol[i] != 0 && sumPol[i] > 0)
            {
                strSumPol.AppendFormat("+ {0}x^{1} ", sumPol[i], i);
            }
            if (sumPol[i] < 0)
            {
                strSumPol.AppendFormat("{0}x^{1} ", sumPol[i], i);
            }
        }
        Console.WriteLine(strSumPol.ToString());
    }
    static void PolynomMultiplication(int[] firstPol, int[] secondPol)
    {
        int[] multiPol = new int[firstPol.Length + secondPol.Length];
        int startPoint = 0;
        for (int i = 0; i < firstPol.Length; i++)
        {
            startPoint = i;
            for (int j = 0; j < secondPol.Length; j++)
            {
                multiPol[startPoint] = multiPol[startPoint] + (secondPol[j] * firstPol[i]);
                startPoint++;
            }
        }
        StringBuilder strMultiPol = new StringBuilder();
        if (multiPol[0] != 0)
        {
            strMultiPol.AppendFormat("{0} ", multiPol[0]);
        }
        for (int i = 1; i < multiPol.Length; i++)
        {
            if (multiPol[i] != 0 && multiPol[i] > 0)
            {
                strMultiPol.AppendFormat("+ {0}x^{1} ", multiPol[i], i);
            }
            if (multiPol[i] < 0)
            {
                strMultiPol.AppendFormat("{0}x^{1} ", multiPol[i], i);
            }
        }
        Console.WriteLine(strMultiPol.ToString());
    }
}


