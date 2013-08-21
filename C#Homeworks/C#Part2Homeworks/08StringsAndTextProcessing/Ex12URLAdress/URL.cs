//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"
using System;
using System.Linq;
namespace Ex12URLAdress
{
    class URL
    {
        static void Main()
        {
            string address = "http://www.devbg.org/forum/index.php";
            int indexTwoDots = address.IndexOf(":");
            int indexW = address.IndexOf("www");
            int indexSlash = address.IndexOf("/", indexW);
            string protocol = address.Substring(0, indexTwoDots);
            string server = address.Substring(indexW, indexSlash - indexW);
            string resource = address.Substring(indexSlash, address.Length - indexSlash);
            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
        }
    }
}
