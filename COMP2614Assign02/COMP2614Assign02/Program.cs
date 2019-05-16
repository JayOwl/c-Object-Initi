using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string address;
            string city;
            string province;
            string postalCode;

            Console.Title = "COMP2614 - Assignment 2 - A00838629";

            System.Console.Write("Whats your first name?: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Whats your last name?: ");
            lastName = System.Console.ReadLine();


            System.Console.Write("Whats your address?: ");
            address = System.Console.ReadLine();

            System.Console.Write("Whats your city?: ");
            city = System.Console.ReadLine();

            System.Console.Write("Whats your province?: ");
            province = System.Console.ReadLine();

            System.Console.Write("Whats your postal code?: ");
            postalCode = System.Console.ReadLine();

            //Calling Parameterized constructor
            Contact[] contact =
            {
                new Contact(firstName, lastName, address, city, province, postalCode )
            };

            ConsolePrinter.PrintMembers(contact);
            //Using Object Initialization
            Contact contact_1 =
                 new Contact() { FirstName = firstName, LastName = lastName, Address = address, City = city, Province = province, PostalCode = postalCode };

            //Populate using properties 
            Contact contact_2 = new Contact();
            contact_2.FirstName = firstName;
            contact_2.LastName = lastName;
            contact_2.Address = address;
            contact_2.City = city;
            contact_2.Province = province;
            contact_2.PostalCode = postalCode;
        }
    }
}
