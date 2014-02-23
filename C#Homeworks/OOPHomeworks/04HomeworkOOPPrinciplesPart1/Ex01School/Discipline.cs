using System;
using System.Collections.Generic;
using System.Linq;

  public  class Discipline:IComment
    {
       
      private string name;
      private int numberOfLectures;
      private int numberOfExercises;
      public List<string> comments{get;set;}
      public string Name
      {
          get { return this.name; }
          set { this.name = value; }
      }

      public int NumberOfLectures
      {
          get { return this.numberOfLectures; }
          set { this.numberOfLectures = value; }
      }

      public int NumberOfExercises
      {
          get { return this.numberOfExercises; }
          set { this.numberOfExercises = value; }
      }

      public Discipline(string name, int numberOfLectures, int numberOfExercises)
      {
          this.Name = name;
          this.NumberOfLectures = numberOfLectures;
          this.NumberOfExercises = numberOfExercises;
      }

      public void AddComment(string text)
      {
          this.comments.Add(text);
      }

      

    }

