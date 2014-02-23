using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamWork;

namespace TestProgram
{
    class TestProgram
    {
        [STAThread]
        static void Main()
        {
            //string file = RWFiles.OpenFile();
            //Console.Write(file);
            //Console.WriteLine();
            //Console.ReadLine();

            Destination destinatin1 = new Destination("");
            int test = destinatin1.Index<int>("359802203944");
            Console.WriteLine("Index: {0}", test);
            Console.ReadLine();
        }
    }
}
