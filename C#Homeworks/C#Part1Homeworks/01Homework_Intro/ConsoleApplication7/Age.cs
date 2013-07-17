using System;

class Age
{
    static void Main()
    {
        Console.WriteLine("Your age is :");
        int age = int.Parse(Console.ReadLine());
        int ageAfter = age + 10;
        Console.WriteLine("Your age after 10 years will be: " + ageAfter);
    }
}

