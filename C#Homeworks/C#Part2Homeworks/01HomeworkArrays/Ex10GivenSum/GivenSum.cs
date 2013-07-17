//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
using System;
  class GivenSum
    {
      static void Main()
      {
          int n = int.Parse(Console.ReadLine());
          int[] array = new int[n];
          for (int i = 0; i < array.Length; i++)
          {
              array[i] = int.Parse(Console.ReadLine());
          }
          int S = int.Parse(Console.ReadLine());
          int startIndex = 0;
          int endIndex = 0;
          int sum = 0;
          int numberOfSums=0;
          for (int i = 0; i < array.Length; i++)
          {
               for (int j = 0; j < array.Length; j++)
                  {
                      if (i + j < array.Length)
                      {
                          sum += array[i+j];
                          if (sum == S)
                          {
                              startIndex = i;
                              endIndex = i + j;
                              numberOfSums++;
                              Console.Write("\nElements with sum {0} are: ", S);
                              for (int k = startIndex; k <= endIndex; k++)
                              {
                                  
                                  Console.Write("{0} ",array[k]+";");
                                  
                              }
                          }
                      }
                  }
               sum = 0;  
          }
          Console.WriteLine();
         
          Console.WriteLine("There are {0} combinations that have the sum {1}.", numberOfSums,S);
         
      }
    }

