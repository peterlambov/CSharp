using System;
using System.Linq;

  public  class OperationWithStudents
    {
      static void Main()
      {
          Student[] fewStudents = new Student[5];
          fewStudents[0] = new Student("Pesho", "Georgiev", 20);
          fewStudents[1] = new Student("Angel", "Ivanov", 22);
          fewStudents[2] = new Student("Mariq", "Petrova", 19);
          fewStudents[3] = new Student("Dodor", "Kirilov", 30);
          fewStudents[4] = new Student("Dragan", "Petkov", 45);

          var firstBeforeLast =
              from student in fewStudents
              where Convert.ToChar(student.FirstName.Substring(0, 1)) < Convert.ToChar(student.LastName.Substring(0, 1))
              select student;

          Console.WriteLine("Students whose first name is alphabetically before their last name are:");

          foreach (var student in firstBeforeLast)
          {
              Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
          }

          var ageBetween =
              from student in fewStudents
              where student.Age >= 18 && student.Age <= 24
              select student;

          Console.WriteLine("Students in the age between 18 and 24 are:");

          foreach (var student in ageBetween)
          {
              Console.WriteLine("{0} {1} {2}",student.FirstName,student.LastName,student.Age);
          }

          Console.WriteLine("Students sorted in descending order by first name and the by last name:");
          var orderedByNamesDescending = fewStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
          //first way
          foreach (var item in orderedByNamesDescending)
          {
              Console.WriteLine("{0} {1} {2}",item.FirstName,item.LastName,item.Age);
          }

          Console.WriteLine("Same with LINQ:");
          //second way with LINQ
          var orderedSecondway =
              from student in fewStudents
              orderby student.FirstName descending,student.LastName descending
              select student;
          foreach (var item in orderedSecondway)
          {
              Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.Age);
          }
      }
    }

