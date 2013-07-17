using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int? someInteger = null;
            Console.WriteLine(
              "This is the integer with Null value -> " + someInteger);
            someInteger = 5;
            Console.WriteLine(
              "This is the integer with value 5 -> " + someInteger);

        }
    }
}
