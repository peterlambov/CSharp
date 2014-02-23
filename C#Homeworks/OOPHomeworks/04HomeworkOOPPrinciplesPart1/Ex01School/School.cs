using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public  class School
    {
      private readonly List<Class> classes;

      public School()
      {
          this.classes = new List<Class>();
      }

      public void AddClass(Class classOne)
      {
          this.classes.Add(classOne);
      }
    }

