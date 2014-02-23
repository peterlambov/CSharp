using System;
using System.Collections.Generic;
using System.Linq;


  public  class Class:IComment
    {
      private string textIdentifier;
      private List<Teacher> setOfteachers;
      public List<string> comments { get; set; }
      public List<Teacher> SetOfTeachers
      {
          get { return this.setOfteachers; }
          set { this.setOfteachers = value; }
      }

      public string TextIdentifier
      {
          get { return this.textIdentifier; }
          set
          {
              if (value.Length <= 0)
              {
                  throw new ArgumentException();
              }

              this.textIdentifier = value;
          }
          
      }

      public Class(string Identifier)
      {
          this.SetOfTeachers = new List<Teacher>();
          this.TextIdentifier = Identifier;
      }

      public void AddTeacher(Teacher teacher)
      {
          SetOfTeachers.Add(teacher);
      }

      public void AddComment(string text)
      {
          this.comments.Add(text);
      }


     


    }

