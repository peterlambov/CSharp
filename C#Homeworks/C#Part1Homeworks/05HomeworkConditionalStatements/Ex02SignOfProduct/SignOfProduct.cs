//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.

using System;
    class SignOfProduct
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.Write("The sign of the product of the three numbers is: ");
            if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if(a == 0 || b == 0 || c == 0)
                Console.WriteLine("The product of the three numbers is 0 and it doesn't have a sign." );
        }
    }

