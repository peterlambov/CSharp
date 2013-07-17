//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example:N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;
using System.Collections.Generic;


class Variations
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;
    static void Main()
    {
        Console.Write("Enter N=");
        numberOfIterations = int.Parse(Console.ReadLine());
        Console.Write("Enter K=");
         numberOfLoops = int.Parse(Console.ReadLine());       
         loops = new int[numberOfLoops];
        NestedLoops();
    }
   static void NestedLoops()
        {
           InitLoops();
           int currentPosition;
            while (true)
              {
               PrintLoops();
               currentPosition = numberOfLoops - 1;//The index of the last element
               loops[currentPosition] = loops[currentPosition] + 1;//We make it bigger with one
               while (loops[currentPosition] > numberOfIterations)//If we are at a point when an element is bigger than N(the last number)
               {                                                  //We make it one
                loops[currentPosition] = 1;
                currentPosition--;
                if (currentPosition < 0)
                 {
                  return;
                 }
                loops[currentPosition] = loops[currentPosition] + 1;//The element before the last one is made bigger with one
               }
              }
        }
            static void InitLoops()
                 {
                     for (int i = 0; i < numberOfLoops; i++)//We have exactly K loops, for each element of the variaotion consisting of K elements
                        {
                           loops[i] = 1;//This is the starting variation , it looks like this: 1 1 1 1 1 ..(N times)
                        }
                 }
            static void PrintLoops()
                {
                     for (int i = 0; i < numberOfLoops; i++)
                     {
                           Console.Write("{0} ", loops[i]);
                     }
                           Console.WriteLine();
                }

}
