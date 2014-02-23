using System;
using System.Linq;


public class Animal
{
       private int age;
       private string name;
       private string sex;

       public Animal(int age, string name, string sex)
       {
           this.Age = age;
           this.Name = name;
           this.Sex = sex;
       }
    public string Sex
    {
        get
        {
            return this.sex;
        }
        set
        {
            if (value.Length<=0)
            {
                throw new ArgumentException();
            }
            this.sex = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length <= 0)
            {
                throw new ArgumentException();
            }
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException();
            }
            this.age = value;
        }
    }
}

