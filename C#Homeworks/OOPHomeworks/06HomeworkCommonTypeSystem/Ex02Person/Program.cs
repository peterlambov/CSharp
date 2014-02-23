using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        Person firstPerson = new Person("pesho", 17);
        Person secondPerson = new Person("gosho");
        Console.WriteLine(firstPerson.ToString());
        Console.WriteLine(secondPerson.ToString());
    }
}

