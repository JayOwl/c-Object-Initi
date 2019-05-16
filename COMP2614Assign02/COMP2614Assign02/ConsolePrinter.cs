using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class ConsolePrinter
    {
        public static void PrintMembers(Contact[] contacts)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Contact Information");
            Console.WriteLine(new string('-', 38));
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("Firstname:      {0} \nLastName:       {1}\nAddress:        {2}\nCity:           {3} \nProvince:       {4} \nPostal Code:    {5}",
                        contact.FirstName,
                        contact.LastName,
                        contact.Address,
                        contact.City,
                        contact.Province,
                        contact.PostalCode
                    );
            }
            Console.WriteLine("\n");
            Console.WriteLine("Contacts");
            Console.WriteLine(new string('-', 38));

            foreach (Contact contact in contacts)
            {
                Console.WriteLine("{0} {1, 1}\n{2}\n{3} {4, 1}  {5, 1}",
                    contact.FirstName,
                    contact.LastName,
                    contact.Address,
                    contact.City,
                    contact.Province,
                    contact.PostalCode
                );
            }

            Console.WriteLine("\n");

            foreach (Contact contact_1 in contacts)
            {
                Console.WriteLine("{0} {1, 1}\n{2}\n{3} {4, 1}  {5, 1}",
                    contact_1.FirstName,
                    contact_1.LastName,
                    contact_1.Address,
                    contact_1.City,
                    contact_1.Province,
                    contact_1.PostalCode
                );
            }

            Console.WriteLine("\n");

            foreach (Contact contact_2 in contacts)
            {
                Console.WriteLine("{0} {1, 1}\n{2}\n{3} {4, 1}  {5, 1}",
                   contact_2.FirstName,
                   contact_2.LastName,
                   contact_2.Address,
                   contact_2.City,
                   contact_2.Province,
                   contact_2.PostalCode
                );
            }
        }
    }
}
