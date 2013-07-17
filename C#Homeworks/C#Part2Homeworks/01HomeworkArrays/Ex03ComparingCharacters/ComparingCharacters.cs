//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

    class ComparingCharacters
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // Enter number of characters for the two arrays
            int m = int.Parse(Console.ReadLine());
            char[] firstArray = new char[n];
            char[] secondArray = new char[m];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
            }
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            bool equalArrays = true;
            
                for (int i = 0; i < minLength; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        continue;
                    }
                    else if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine("Lexicographically the second array is before the first array.");
                        break;
                    }
                    else if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("Lexicographically the first array is before the second array.");
                        break;
                    }
                    
                }
                if (equalArrays == true && firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine("The second array is lexicographically before the first array.");
                }
                else if (equalArrays == true && firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine("The first array is lexicographically before the second array.");
                }
                else if (equalArrays == true && firstArray.Length == secondArray.Length)
                {
                    Console.WriteLine("None of the arrays is lexicographically before the other, they are equal.");
                }

            

           
           

        }
    }
