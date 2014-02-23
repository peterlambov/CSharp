using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 public class Program
    {
        static void Main()
        {
            BitArray64 array = new BitArray64(10);
            StringBuilder sr = new StringBuilder();
            foreach (var item in array)
            {
                sr.Append(item);
            }
            Console.WriteLine(sr.ToString());
        }
    }

