using System;

    class HelloWorld
    {
        static void Main()
        {
            string a = "Hello";
            string b = "World";
            object c = a + " " + b;
            string d = Convert.ToString(c);
            Console.WriteLine(d);
        }
    }


