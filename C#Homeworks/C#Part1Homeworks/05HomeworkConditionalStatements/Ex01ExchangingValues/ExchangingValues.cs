//Write an if statement that examines two integer variables and exchanges their values 
//if the first one is greater than the second one.
using System;
class ExchangingValues
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                b = a;
            }
            Console.WriteLine("The greater number is: {0}",b);
        }
    }

