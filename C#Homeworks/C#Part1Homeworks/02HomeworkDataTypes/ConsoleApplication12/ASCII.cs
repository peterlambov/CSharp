using System;

    class ASCII
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            for (int i = 0; i <= 255; i++)
                Console.WriteLine("{0}={1}",i,(char)i);
        }
    }

