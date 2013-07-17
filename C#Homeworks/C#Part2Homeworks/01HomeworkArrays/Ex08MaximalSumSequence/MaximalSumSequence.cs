  //Write a program that finds the sequence of maximal sum in given array. Example:
  //{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
  //Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Text;

    class MaximalSumSequence
    {
        static void Main()
        {
            //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };//In case you don't want to enter the sequence on the console you can use this row
            int n = int.Parse(Console.ReadLine());
           int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
           }
            int currentSum = 0;
            int bestSum = int.MinValue;
            StringBuilder bestSequenceBuild = new StringBuilder();
            string bestSequence = "";
            for (int i = 0; i < array.Length; i++)
            {
                currentSum = currentSum + array[i];//We start by adding to each other the elements.
                bestSequenceBuild.AppendFormat("{0}, ", array[i]);
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestSequence = bestSequenceBuild.ToString();
                    
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                    bestSequenceBuild.Clear();
                }
                
            }
            Console.WriteLine("The best sequence is: \" {0} \" ", bestSequence);
            Console.WriteLine("The best sum is: {0} ", bestSum);
            
  

    
    }
        }
    

