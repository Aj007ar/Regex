using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    internal class ValidateUser
    {
        public Regex FirstNameregex = new Regex(@"^[A-Z]{1}[A-Z a-z]{3,}$");
        public Regex LastNameregex = new Regex(@"^[A-Z]{1}[A-Z a-z]{3,}$");

        public void ValidateFirstName(string FirstName)
        {
            Console.WriteLine("\nFirst Name "+ FirstName);
            if (FirstNameregex.IsMatch(FirstName))
            {
                Console.WriteLine("Valid first Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
        public void ValidateLastName(string LastName)
        {
            Console.WriteLine("\nLast Name " + LastName);
            if (LastNameregex.IsMatch(LastName))
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
