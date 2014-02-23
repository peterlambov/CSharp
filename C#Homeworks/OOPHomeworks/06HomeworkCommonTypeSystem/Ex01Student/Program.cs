using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public  class Program
    {
      static void Main()
      {

          Student firstStudent = new Student("gesho", "goshev", "petrov", "999", "burgas", 1234,
              "pesho@abv.bg", 3, Specialty.Banker, Univesity.BurgasFreeUniversity, Faculty.BankovoDelo);

          Student secondStudent = new Student("pesho", "goshev", "petrov", "123", "burgas", 1234,
              "pesho@abv.bg", 3, Specialty.Banker, Univesity.BurgasFreeUniversity, Faculty.BankovoDelo);


          bool areEqual = Student.Equals(firstStudent, secondStudent);
          Console.WriteLine("The first and the second student are equal: {0}", areEqual);

          if (firstStudent == secondStudent)
          {
              Console.WriteLine("The students are equal.");
          }

          if (firstStudent != secondStudent)
          {
              Console.WriteLine("The students are NOT equal.");
          }

          Student copiedStudent = firstStudent.Clone() as Student;
          Console.WriteLine(copiedStudent.ToString());

          Console.WriteLine(firstStudent.CompareTo(secondStudent)); //gesho is lexicographically before pesho, so negative result is expected.

      }
    }

