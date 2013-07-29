//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StringArray
    {
        static void Main()
        {
            string[] array = new string[] {"a","abf","ab","afgs","asddgg","aa","fghgh","dgsgsdfgdfh","s","dfhdfgf","sdfsdf","fddf","sff" };
            StringSort(array);
            Console.WriteLine("This is the sorted array:");
            //Console.WriteLine(string.Join(" ",array)); //Another easy way to print the array
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void StringSort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j].Length < array[i].Length)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }

