using System;
using System.Linq;

   public class TestSchool
    {
       public static void Main()
       {
         Class myClass = new Class("12 V");

           Teacher firstTeacher = new Teacher("Gesha");
           myClass.AddTeacher(firstTeacher);

           Teacher secondTeacher = new Teacher("Dragan");
           myClass.AddTeacher(secondTeacher);

           Teacher thirdTeacher = new Teacher("Petkan");
           myClass.AddTeacher(thirdTeacher);
           string comment="you mad?";
           thirdTeacher.AddComment(comment);
           Console.WriteLine(thirdTeacher.comments[0]);
           foreach (var teacher in myClass.SetOfTeachers)
           {
               teacher.Name = "something";
               Console.WriteLine(teacher.Name);
           }
       }
    }

