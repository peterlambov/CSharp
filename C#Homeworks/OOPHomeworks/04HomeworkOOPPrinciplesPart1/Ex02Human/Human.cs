﻿using System;
using System.Linq;


     public abstract class Human
    {
         private string firstName;
         private string lastName;
         public Human(string firstname, string lastname)
         {
             this.FirstName = firstname;
             this.LastName = lastname;
         }

         public string FirstName
         {
             get { return this.firstName; }
             set
             {
                 if (value.Length<=0)
                 {
                     throw new ArgumentException();  
                 }
                 this.firstName = value; 
             }
         }

         public string LastName
         {
             get { return this.lastName; }
             set
             {
                 if (value.Length <= 0)
                 {
                     throw new ArgumentException();
                 }
                 this.lastName = value;
             }
         }
    }

