/* A company has name, address, phone number, fax number, web site and manager.
* The manager has first name, last name, age and a phone number. Write a
* program that reads the information about a company and its manager and
* prints them on the console.
*/
using System;
    class Company
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //We set the console to UTF8 in case there are any special characters used
            Console.WriteLine("Please write the information about the company:");
            Console.Write("Name:");
            string companyName = (Console.ReadLine());
            Console.Write("Address:");
            string companyAddress = (Console.ReadLine());
            Console.Write("Phone number:");
            ulong companyPhoneNumber = ulong.Parse(Console.ReadLine());
            Console.Write("Fax number:");
            ulong companyFax = ulong.Parse(Console.ReadLine());
            Console.Write("Web site:");
            string companyWebsite = (Console.ReadLine());
            Console.WriteLine("Please write the information about the manager of the company:");
            Console.Write("First name:");
            string managerFirstName = (Console.ReadLine());
            Console.Write("Last name:");
            string managerLastName = (Console.ReadLine());
            Console.Write("Age:");
            uint managerAge = uint.Parse(Console.ReadLine());
            Console.Write("Phone number:");
            ulong managerPhoneNumber = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Here's the information you entered about the company:");
            Console.WriteLine("Name: {0}"+"\n"+"Address:{1}"+"\n"+"Phone number: {2}"+"\n"+"Fax number: {3}"+"\n"+"Web site: {4}",companyName,companyAddress,companyPhoneNumber,companyFax,companyWebsite);
            Console.WriteLine("Here's the information you entered about the manager:");
            Console.WriteLine("First name: {0}"+"\n"+"Last name: {1}"+"\n"+"Age: {2}"+"\n"+"Phone number: {3}",managerFirstName,managerLastName,managerAge,managerPhoneNumber);


        }
    }

