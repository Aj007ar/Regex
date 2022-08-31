using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblems
{
    internal class Select
    {
        public void choose()
        {
            Console.WriteLine("\n1.Check First Name Valid or Not\n2.Check Last Name Valid or Not\n3.Check Email Valid or Not\n4.Check Mobile Number valid or Not");
            Console.WriteLine("5.Check Password Atleast 8 Charecter\n6.Check Password atleast 1 UpperCase\n7.Check Password Atleast 1 numaric\n8.Check Password atleast 1 Special Charecter");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Choose your choice");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\n-----------------------> Validate First Name <-----------------------------");
                    ValidateUser firstName = new ValidateUser();
                    Console.WriteLine("Enter First Name");
                    string fName = Convert.ToString(Console.ReadLine());
                    firstName.ValidateFirstName(fName);
                    choose();
                    break;
                case 2:
                    Console.WriteLine("\n-----------------------> Validate Last Name <-----------------------------");
                    ValidateUser lastName = new ValidateUser();
                    Console.WriteLine("Enter Last Name");
                    string lName = Convert.ToString(Console.ReadLine());
                    lastName.ValidateLastName(lName);
                    choose();
                    break;
                case 3:
                    Console.WriteLine("\n-----------------------> Validate Email Id <-----------------------------");
                    ValidateUser email = new ValidateUser();
                    Console.WriteLine("Enter Email Id");
                    string mail = Convert.ToString(Console.ReadLine());
                    email.ValidateEmailId(mail);
                    choose();
                    break;
                case 4:
                    Console.WriteLine("\n-----------------------> Validate Mobile Number <-----------------------------");
                    ValidateUser mobile = new ValidateUser();
                    Console.WriteLine("Enter Mobile Number");
                    string mobileNum = Convert.ToString(Console.ReadLine());
                    mobile.ValidateMobileNumber(mobileNum);
                    choose();
                    break;
                case 5:
                    Console.WriteLine("\n-----------------------> Validate Password Rule 1 <-----------------------------");
                    ValidateUser Pass1 = new ValidateUser();
                    Console.WriteLine("Enter Password");
                    string pass = Convert.ToString(Console.ReadLine());
                    Pass1.ValidatePassRule_1(pass);
                    choose();
                    break;
                case 6:
                    Console.WriteLine("\n-----------------------> Validate Password Rule 2 <-----------------------------");
                    ValidateUser Pass2 = new ValidateUser();
                    Console.WriteLine("Enter Password");
                    string pasS = Convert.ToString(Console.ReadLine());
                    Pass2.ValidatePassRule_2(pasS);
                    choose();
                    break;
                case 7:
                    Console.WriteLine("\n-----------------------> Validate Password Rule 3 <-----------------------------");
                    ValidateUser Pass3 = new ValidateUser();
                    Console.WriteLine("Enter Password");
                    string paSS = Convert.ToString(Console.ReadLine());
                    Pass3.ValidatePassRule_3(paSS);
                    choose();
                    break;
                case 8:
                    Console.WriteLine("\n-----------------------> Validate Password Rule 4 <-----------------------------");
                    ValidateUser Pass4 = new ValidateUser();
                    Console.WriteLine("Enter Password");
                    string PaSS = Convert.ToString(Console.ReadLine());
                    Pass4.ValidatePassRule_4(PaSS);
                    choose();
                    break;
                case 0:
                    break;
            }
        }
    }
}
