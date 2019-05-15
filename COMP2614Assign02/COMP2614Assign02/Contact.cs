using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string province;
        private string postalCode;

        public Contact()
        {
        }

        public Contact(string firstName, string lastName, string address, string city, string province, string postalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            Province = province;
            PostalCode = postalCode;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public override string ToString()
        {
            return string.Format("LastName: {0} FirstName {1}", lastName, firstName);
        }

    }
}
