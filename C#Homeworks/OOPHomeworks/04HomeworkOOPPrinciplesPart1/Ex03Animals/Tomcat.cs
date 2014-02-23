using System;
using System.Linq;


   public class Tomcat:Cat
    {
        public Tomcat(int age, string name, string sex)
            : base(age, name, sex)
        {
            if (sex == "female")
            {
                throw new ArgumentException("Tomcat's sex can be only male!");
            }
        }
        
    }

