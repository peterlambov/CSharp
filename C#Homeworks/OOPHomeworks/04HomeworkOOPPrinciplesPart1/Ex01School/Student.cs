using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student:People,IComment
{
    private int classNumber;
   
    public int ClassNumber
    {
        get{return this.classNumber;}
        set{

            if (value<0)
            {
                throw new ArgumentException();
            }

            this.classNumber=value;
           }
    }

    public Student(string name, int number)
        : base(name)
    {
        this.classNumber = number;
    }


   
}

