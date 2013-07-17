//We are given 5 integer numbers. Write a program that checks if the sum of some subset
//of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.	
using System;
class SumOfsubset
{
    static void Main()
    {
     
        Console.WriteLine("Hello, this program checks if the sum of some subset of them is 0.");
        Console.WriteLine();
        Console.WriteLine("Enter the number of integers:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        bool isFound = false;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter an integer: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int subset = 1; subset < Math.Pow(2, n); subset++)
        {
            int sum = 0;
            for (int pos = 0; pos < n; pos++)
            {

                bool isOne = (((subset >> pos) & 1) == 1);
                if (isOne == true)
                {
                    sum += arr[pos];
                }
            }
            if (sum == 0)
            {
                isFound = true;
            }
        }
        if (isFound)
        {
            Console.WriteLine("There is at least one subset which sum is equal to zero.");
        }
        else
        {
            Console.WriteLine("There is no subset with sum equal to zero.");
        }
    }
}


