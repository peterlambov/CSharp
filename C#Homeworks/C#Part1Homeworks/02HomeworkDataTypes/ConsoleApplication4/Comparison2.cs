using System;

    class Comparison2
    {
        static void Main()
        {
            double c = 5.00000001f;
            double d = 5.00000003f;
            Console.Write("{0} and {1} are equal:",c,d);
            bool equalCD = Math.Abs(c - d) < 1e-6;
            Console.WriteLine(equalCD);
        }
    }

