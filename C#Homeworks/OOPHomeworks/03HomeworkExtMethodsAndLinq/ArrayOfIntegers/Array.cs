using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Array
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 21, 42, 58, 27, 14, 231, 569, 781, 24, 180, 222 };

        Console.WriteLine("These are the numbers from the array that are divisible by 3 and 7:");

        var dividisibleBySevenAndThree = array.Where(x => x % 3 == 0 && x % 7 == 0);

        foreach (var number in dividisibleBySevenAndThree)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Same using LINQ:");
        //using LINQ
        var secondWay =
            from number in array
            where number % 3 == 0 && number % 7 == 0
            select number;
        foreach (var item in secondWay)
        {
            Console.WriteLine(item);
        }
    }
}

