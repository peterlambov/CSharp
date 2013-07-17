//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter N:");
        double N = double.Parse(Console.ReadLine());
        Console.Write("Enter X:");
        double X = double.Parse(Console.ReadLine());
        double S = 1;
        double resultX  ;
        double Nfactorial = 1;
        for (int i = 1; i <= N; i++)
        {
            Nfactorial *= i;
            resultX = (double)Math.Pow(X, i);
            S += (Nfactorial / resultX);
        }
        Console.Write("S=");
        Console.WriteLine(S);
    }
}