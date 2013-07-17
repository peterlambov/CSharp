using System;

    class NullValues
    {
        static void Main()
        {
            int? intnumber = null;
            Console.WriteLine("This is an integer with value:" + intnumber);
            intnumber = 10;
            Console.WriteLine("The new value of the integer is:" + intnumber);
            double? doublenumber = null;
            Console.WriteLine("The value of double number is:" + doublenumber);
            doublenumber = 15.5;
            Console.WriteLine("The new value of double number is:" + doublenumber);
        }
    }
