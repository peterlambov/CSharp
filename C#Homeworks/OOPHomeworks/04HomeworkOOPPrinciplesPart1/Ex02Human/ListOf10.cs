using System;
using System.Collections.Generic;
using System.Linq;


   public class ListOf10
    {
       static void Main()
       {
           List<Student> listOfStudents = new List<Student>();

           Student firstStudent = new Student(4, "pesho", "petrov");
           listOfStudents.Add(firstStudent);

           Student secondStudent = new Student(8, "gosho", "ivanov");
           listOfStudents.Add(secondStudent);

           Student thirdStudent = new Student(2, "misho", "goshev");
           listOfStudents.Add(thirdStudent);

           Student fourthStudent = new Student(12, "tisho", "tishev");
           listOfStudents.Add(fourthStudent);

           Student fifthStudent = new Student(5, "visho", "cekov");
           listOfStudents.Add(fifthStudent);

           Student sixthStudent = new Student(9, "krisko", "georgiev");
           listOfStudents.Add(sixthStudent);

           Student seventhStudent = new Student(10, "grisko", "chapaev");
           listOfStudents.Add(seventhStudent);

           Student eighthStudent = new Student(3, "mariq", "georgieva");
           listOfStudents.Add(eighthStudent);

           Student ninthStudent = new Student(12, "viktoriya", "petrova");
           listOfStudents.Add(ninthStudent);

           Student tenthStudent = new Student(1, "ganka", "ivanova");
           listOfStudents.Add(tenthStudent);

           var sortedStudents = listOfStudents.OrderBy(x => x.Grade);

           Console.WriteLine("Here are the students, sorted by grade in ascending order:");

           foreach (var student in sortedStudents)
           {
               Console.WriteLine("{0} {1} {2}",student.FirstName,student.LastName,student.Grade);
           }

           List<Worker> listOfWorkers = new List<Worker>();

           Worker firstWorker = new Worker(300, 6, "pesho", "goshev");
           listOfWorkers.Add(firstWorker);

           Worker secondWorker = new Worker(400, 8, "gosho", "peshev");
           listOfWorkers.Add(secondWorker);

           Worker thirdWorker = new Worker(200, 6, "misho", "konstantinov");
           listOfWorkers.Add(thirdWorker);

           Worker fourthWorker = new Worker(1000, 8, "samuil", "rusev");
           listOfWorkers.Add(fourthWorker);

           Worker fifthWorker = new Worker(2000, 6, "misho", "gochev");
           listOfWorkers.Add(fifthWorker);

           Worker sixthWorker = new Worker(100, 8, "dragan", "kolev");
           listOfWorkers.Add(sixthWorker);

           Worker seventhWorker = new Worker(250, 10, "misho", "aleksiev");
           listOfWorkers.Add(seventhWorker);

           Worker eigthWorker = new Worker(2500, 12, "hristo", "fotev");
           listOfWorkers.Add(eigthWorker);

           Worker ninthWorker = new Worker(450,9, "miroslav", "penev");
           listOfWorkers.Add(ninthWorker);

           Worker tenthWorker = new Worker(2500,5, "ilian", "koldeev");
           listOfWorkers.Add(tenthWorker);

           var sortedWorkers = listOfWorkers.OrderByDescending(x => x.MoneyPerHour());

           Console.WriteLine("Here are the workers, sorted by mone per hour in descending order:");
           foreach (var worker in sortedWorkers)
           {
               Console.WriteLine("{0} {1} {2}",worker.FirstName,worker.LastName,worker.MoneyPerHour());   
           }
           Console.WriteLine("Here are both students and workers, sorted by first name and then by last name:");
           List<Human> finalList = new List<Human>();

           finalList.AddRange(sortedStudents);
           finalList.AddRange(sortedWorkers);

           var finalSorted = finalList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
           foreach (var human in finalSorted)
           {
               Console.WriteLine("{0} {1}",human.FirstName,human.LastName);
           }

           //var finalSortedLINQ=
           //    from human in finalList
           //    orderby human.FirstName,human.LastName
           //    select human
           //    ;
           //foreach (var item in finalSortedLINQ)
           //{
           //     Console.WriteLine("{0} {1}",item.FirstName,item.LastName);
           //}

          
       }
    }

