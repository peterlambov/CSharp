using System;
using System.Linq;


    public class Kitten:Cat
    {
        public Kitten(int age, string name, string sex)
            : base(age, name, sex)
        {
            if (sex == "male")
            {
                throw new ArgumentException("Kitten's sex can be only female!");
            }
        }
        
    }

