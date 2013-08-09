//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.
using System;
using System.IO;
using System.Linq;
using System.Security;
namespace Ex03ReadingFile
{
    class File
    {
        static void Main()
        {
            Console.WriteLine("Enter the name of the file:");
            string path = Console.ReadLine(); //You can test by entering the example from the task or to read your own file, don't forget to get rid of the quotes.
            try
            {
                string content = System.IO.File.ReadAllText(path);
                Console.WriteLine(content);
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
            
           
        }
    }
}
