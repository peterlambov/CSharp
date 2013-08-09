//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Linq;
using System.Net;


namespace Ex04FileDownload
{
    class Download
    {
        static void Main()
        {
            WebClient myClient = new WebClient();
            string address = "http://www.devbg.org/img/Logo-BASD.jpg";
            string fileName = "BASD.jpg";
            try
            {
                myClient.DownloadFile(address, fileName);//It is normal when the program is being executed to have a reaction from your FireWall.

                Console.WriteLine("Downloading finished.");

            }
            catch (ArgumentNullException argNull)
            {
                Console.WriteLine(argNull.Message);
            }
            catch (WebException webEx)
            {
                Console.WriteLine(webEx.Message);
            }
            catch (NotSupportedException notSupport)
            {
                Console.WriteLine(notSupport.Message);
            }
        }
    }
}
