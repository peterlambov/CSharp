using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class People:IComment
    {
       private string name;
       public List<string> comments { get; set; }
       public string Name
       {
           get { return this.name; }
           set {
               if (value.Length<=0)
               {
                   throw new ArgumentException();
               }
               this.name = value; }

       }

       public People(string name)
       {
           this.Name = name;
           this.comments = new List<string>();
       }

    public void AddComment(string text)
    {
        comments.Add(text);
    }

    }

