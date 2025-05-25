using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Customer : Person
    {
        public Customer(string fistName, string lastName, string companyName) 
            : base(fistName, lastName)
        {
            Company = companyName;
        }

        public string Company { get; set; }

        public string Fax { get; set; }

        public override string GetInfo()
        {
            string info = @$"Hello, I`m customer from {Company}
                           First Name: {FirstName}
                           Last Name: {LastName}
                           Email: {Email}
                           Phone Number: {PhoneNumber}
                           Address: {Address}
                           Is Dengere: {IsDangere}";

            return info;    
        }

        public override bool CheckTolerance()
        {
            return (FirstName.Length > 2 && LastName.Length > 2 && Company.Length > 2);
        }
    }
}
