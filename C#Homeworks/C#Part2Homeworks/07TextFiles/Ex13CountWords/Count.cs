//Write a program that reads a list of words from a file words.txt and finds how many times
//each of the words is contained in another file test.txt. The result should be written in 
//the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.
using System;
using System.IO;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;
namespace Ex13CountWords
{
    class Count
    {
        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader(@"..\..\test.txt");
                using (reader)
                {
                    string[] words = File.ReadAllLines(@"..\..\words.txt");
                    int[] numberOfTimes = new int[words.Length];
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            numberOfTimes[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }
                        line = reader.ReadLine();
                    }
                    Array.Sort(numberOfTimes, words);
                    StreamWriter writer = new StreamWriter(@"..\..\result.txt");
                    using (writer)
                    {
                        for (int i = numberOfTimes.Length-1; i >= 0 ; i--)
                        {
                            writer.WriteLine("{0} {1}", numberOfTimes[i], words[i]);
                        }
                    }
                }
            }

            catch (ArgumentNullException argNull)
            {
                Console.WriteLine(argNull.Message);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            catch (PathTooLongException tooLong)
            {
                Console.WriteLine(tooLong.Message);
            }
            catch (DirectoryNotFoundException notFoundDir)
            {
                Console.WriteLine(notFoundDir.Message);
            }
            catch (UnauthorizedAccessException access)
            {
                Console.WriteLine(access.Message);
            }
            catch (FileNotFoundException notfound)
            {
                Console.WriteLine(notfound.Message);
            }
            catch (NotSupportedException notSupport)
            {
                Console.WriteLine(notSupport.Message);
            }
            catch (SecurityException secEx)
            {
                Console.WriteLine(secEx.Message);
            }

            finally
            {
                Console.WriteLine("Last problem from the homework solved!");
            }
        }
    }
}
