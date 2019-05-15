using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class ConsolePrinter
    {
        public static void PrintMembers(Contact[] members)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Contact Information");
            Console.WriteLine(new string('-', 38));
            foreach (Contact member in members)
            {
                Console.WriteLine("Firstname: {0, 8} \nLastName: {1, 10}  \nAddress: {2, 12} \nCity: {3, 14} \nProvince: {4, 11} \nPostal Code:{5, 5}",
                                         member.FirstName,
                                         member.LastName,
                                         member.Address,
                                         member.City,
                                         member.Province,
                                         member.PostalCode
                                        );
            }
            Console.WriteLine("\n");
            Console.WriteLine("Contacts");
            Console.WriteLine(new string('-', 38));
            Console.WriteLine("\n");


            foreach (Contact member1 in members)
            {
                Console.WriteLine("Firstname: {0, -15} \nLastName: {1, -15}  \nAddress: {2, 6} \nCity: {3, 6} \nProvince: {4, 6} \nPostal Code:{5, 6}",
                                         member1.FirstName,
                                         member1.LastName,
                                         member1.Address,
                                         member1.City,
                                         member1.Province,
                                         member1.PostalCode
                                        );
            }

            Console.WriteLine(new string('-', 38));
            Console.WriteLine("\n");


            foreach (Contact member3 in members)
            {
                Console.WriteLine("Firstname: {0, -15} \nLastName: {1, -15}  \nAddress: {2, 6} \nCity: {3, 6} \nProvince: {4, 6} \nPostal Code:{5, 6}",
                                         member3.FirstName,
                                         member3.LastName,
                                         member3.Address,
                                         member3.City,
                                         member3.Province,
                                         member3.PostalCode
                                        );
            }

        }
    }
}
