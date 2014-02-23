using System;
using System.Linq;



    public class Student:Human
    {
        private int grade;

        public Student(int gradee, string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.Grade = gradee;
        }
        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                this.grade = value;
            }
        }

        
    }

