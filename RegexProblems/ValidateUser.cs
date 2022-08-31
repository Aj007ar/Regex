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
        public Regex MobileNumberRegex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PassRule_1Regex=new Regex(@"^([A-Z a-z 0-9 !@#$&]){8,}$");
        public Regex PassRule_2Regex = new Regex("^(?=.*?[A-Z]).{8,}$");
        public Regex PassRule_3Regex = new Regex("^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$");
        public Regex PassRule_4Regex = new Regex("^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=-]).{8,}$");


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
        public void ValidateMobileNumber(string MobileNum)
        {
            Console.WriteLine("\nMobile Number " + MobileNum);
            if (MobileNumberRegex.IsMatch(MobileNum))
            {
                Console.WriteLine("Valid Mobile Number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }
        }
        public void ValidatePassRule_1(string PassRule_1)
        {
            Console.WriteLine("\nPassword "+PassRule_1);
            if (PassRule_1Regex.IsMatch(PassRule_1))
            {
                Console.WriteLine("Valid for Password Rule 1");
            }
            else
            {
                Console.WriteLine("Invalid password rule 1");
            }
        }
        public void ValidatePassRule_2(string PassRule_2)
        {
            Console.WriteLine("\nPassword " + PassRule_2);
            if (PassRule_2Regex.IsMatch(PassRule_2))
            {
                Console.WriteLine("Valid for Password Rule 2");
            }
            else
            {
                Console.WriteLine("Invalid password rule 2");
            }
        }
        public void ValidatePassRule_3(string PassRule_3)
        {
            Console.WriteLine("\nPassword " + PassRule_3);
            if (PassRule_3Regex.IsMatch(PassRule_3))
            {
                Console.WriteLine("Valid for Password Rule 3");
            }
            else
            {
                Console.WriteLine("Invalid password rule 3");
            }
        }
        public void ValidatePassRule_4(string PassRule_4)
        {
            Console.WriteLine("\nPassword " + PassRule_4);
            if (PassRule_4Regex.IsMatch(PassRule_4))
            {
                Console.WriteLine("Valid for Password Rule 4");
            }
            else
            {
                Console.WriteLine("Invalid password rule 4");
            }
        }
    }
}
