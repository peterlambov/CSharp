//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Hello
    {
        static void Main()//The following code in the Main method is one of the tests, 
                          //in UnitTestProjectHelloMethod you can run three more tests and see the results.
        {
            Console.WriteLine("Enter your name:");
            string yourName = Console.ReadLine();// The best input is probably "Pesho" :D
            PrintName(yourName);
        }
        public static void PrintName(string name)
        {
            Console.WriteLine("Hello,{0}!",name);
        }

       
    }

