using System;

class Comparison
{
    static void Main()
    {
        float a = 5.3f;
        float b = 6.1f;
        Console.Write("{0} and {1} are equal:",a,b);
        bool equalAB = Math.Abs(a - b) < 1e-6;
        Console.WriteLine(equalAB);
    
    }


}