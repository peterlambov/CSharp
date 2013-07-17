using System;
    class Exchange
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("New value of a is:" + a);
            Console.WriteLine("New value of b is:" + b);//First way to do it
            int c = 5;
            int d = 10;
            int t = c;
            c = d;
            d = t;
            Console.WriteLine(c);
            Console.WriteLine(d);//Second way
            
        }
    }