//Write a program that finds the index of given element in a sorted array of integers by using the binary search 
//algorithm (find it in Wikipedia).

using System;

    class BinarySearch
    {
        static int BinarySearching(int[] array, int key)
        {
            Array.Sort(array);
            int start = 0;
            int end = array.Length - 1;           
            while (end >= start)
            {
                int middle = (start + end) / 2;//This is the middle of our sequence
                if (array[middle] < key)//If our key is "above" this sequence, our new sequence will start from the element after the middle.
                {
                    start = middle + 1;
                }
                else if (array[middle] > key)//If our key is "under" the sequence, our new sequence will end with the element before the middle.
                {
                    end = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("This is the sorted array:");
            for (int i = 0; i <array.Length; i++)
            {
               
                Console.WriteLine(array[i]);
            }
            
            int key = int.Parse(Console.ReadLine());
            Console.Write("The element that you entered has index: ");
            Console.WriteLine(BinarySearching(array,key));

           
        }
    }

