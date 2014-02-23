using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class TestForExtensionsForIenumerable
    {
       public static void Main()
       {
           int[] numbers = { 1, 2, 3, 4 };
           Console.WriteLine(numbers.Sum());
           Console.WriteLine(numbers.Product());
           Console.WriteLine(numbers.Min());
           Console.WriteLine(numbers.Max());
           Console.WriteLine(numbers.Average());

       }
    }

