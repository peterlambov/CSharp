using System;
using System.Linq;
using System.Text;

  public  class Person
    {
      private string name;
      private int? age;


      public Person()
      {
         
      }

      public Person(string name)
          : this(name, null)
      {
      }

      public Person(string name, int? age)
      {
          this.Name = name;
          this.Age = age;
      }

      public string Name
      {
          get { return this.name; }
          set
          {
              if (value.Length <= 0)
              {
                  throw new ArgumentException();
              }
              this.name = value;
          }
      }

      public int? Age
      {
          get { return this.age; }
          set
          {
              this.age = value;
          }
      }

      public override string ToString()
      {
          StringBuilder result = new StringBuilder();
          result.Append("Here is the information about the person:\n");
          result.AppendFormat("Name:{0}\n",this.Name);
          if (this.Age == null)
          {
              result.AppendLine("The age of this person is not specified.");
          }
          else
          {
              result.AppendFormat("Age:{0}\n",this.Age.ToString());
          }
          return result.ToString();
      }
    }

