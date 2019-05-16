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

            //paramater
            Contact[] contact =
            {
                new Contact(firstName, lastName, address, city, province, postalCode )
            };

            ConsolePrinter.PrintMembers(contact);
            //object init
            Contact contact_2 =
                 new Contact() { FirstName = firstName, LastName = lastName, Address = address, City = city, Province = province, PostalCode = postalCode };

            //properties
            Contact contact_3 = new Contact();
            contact_3.FirstName = firstName;
            contact_3.LastName = lastName;
            contact_3.Address = address;
            contact_3.City = city;
            contact_3.Province = province;
            contact_3.PostalCode = postalCode;
        }
    }
}
