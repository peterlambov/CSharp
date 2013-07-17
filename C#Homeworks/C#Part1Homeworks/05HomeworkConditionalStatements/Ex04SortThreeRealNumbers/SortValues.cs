//Sort 3 real values in descending order using nested if statements.

using System;

    class SortValues
    {
        static void Main()
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            if (a > b && a > c && b > c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (b > a && b > c && a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else if (a > c && a > b && c > b)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else if (c > a && c > b && a > b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else if(c>a&&c>b&&b>a)
            {
                Console.WriteLine(" {0} {1} {2}",c,b,a);
            }
            else if (b > c && b > a && c > a)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
    }
