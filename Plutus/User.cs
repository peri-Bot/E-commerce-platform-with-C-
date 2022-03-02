using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plutus
{
    class User:PlutusDBLayer
    {
        string userName;
        string firstName;
        string lastName;
        string passw;
        string email;
        string phone;
        string addressLine;
        string city;
        string postalCode;
        string zipCode;
        
        public User()
        {

        }

        public User(string email, string passw)
        {
            this.passw = passw;
            this.email = email;
        }

        public User(string userName, string firstName, string lastName, string passw, string email, string phone, string addressLine, string city, string postalCode, string zipCode)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.passw = passw;
            this.email = email;
            this.phone = phone;
            this.addressLine = addressLine;
            this.city = city;
            this.postalCode = postalCode;
            this.zipCode = zipCode;
        }

        public string UserName { get => userName; set => userName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Passw { get => passw; set => passw = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string AddressLine { get => addressLine; set => addressLine = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }


        public User GetUser()
        {
            return getUser();
        }
    }
}
