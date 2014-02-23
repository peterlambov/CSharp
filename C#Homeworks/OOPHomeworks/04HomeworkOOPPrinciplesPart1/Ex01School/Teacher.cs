using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Teacher:People,IComment
    {
       private List<Discipline> disciplines;
       
       public List<Discipline> Disciplines
       {
           get { return this.disciplines; }
           set { this.disciplines = value; }
       }

       public Teacher(string name):base(name)
       {
           this.Disciplines = new List<Discipline>();
       }

       public void AddDiscipline(Discipline discipline)
       {
           Disciplines.Add(discipline);
       }


      
    }

