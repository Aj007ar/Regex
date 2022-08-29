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
        public Regex EmailIdRegex = new Regex(@"^[a-z]+([.+-_][a-z]+)*@[a-z]+.[a-z]+([.]+[a-z]+)*$");

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
        public void ValidateEmailId(string EmailId)
        {
            Console.WriteLine("\nEmail Id " + EmailId);
            if (EmailIdRegex.IsMatch(EmailId))
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id");
            }
        }
    }
}
