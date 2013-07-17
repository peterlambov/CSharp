//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.

using System;
    class StringIntOrDouble
    {
        static void Main()
        {
            
            Console.WriteLine("Please enter something by your choice - 1 for int input,2 for double input or 3-for string input:");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.Write("Enter your integer number:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("This is the modified integer number:");
                    Console.WriteLine(a + 1);
                    break;
                case 2: Console.Write("Enter your double number:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("This is the modified double number:");
                    Console.WriteLine(b+1);
                    break;
                case 3: Console.Write("Enter your string expression:");
                    string exp = Console.ReadLine();
                    Console.WriteLine("This is the modified expression:");
                    Console.WriteLine(exp+"*");
                    break;
                default: Console.WriteLine("Error!");
                    break;
            }

        }
    }
