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

            //paramter
            Contact[] member =
            {
                new Contact(firstName, lastName, address, city, province, postalCode )
            };

            ConsolePrinter.PrintMembers(member);
            //object init
            Contact member1 =
                 new Contact() { FirstName = firstName, LastName = lastName, Address = address, City = city, Province = province, PostalCode = postalCode };

            Contact member3 = new Contact();
            member3.FirstName = firstName;
            member3.LastName = lastName;
            member3.Address = address;
            member3.City = city;
            member3.Province = province;
            member3.PostalCode = postalCode;
        }
    }
}
