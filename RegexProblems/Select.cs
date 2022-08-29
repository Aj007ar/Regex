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
            Console.WriteLine("\n1.Check First Name Valid or Not");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Choose your choice");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\n-----------------------> Validate First Name <-----------------------------");
                    ValidFirstName firstName = new ValidFirstName();
                    Console.WriteLine("Enter First Name");
                    string fName = Convert.ToString(Console.ReadLine());
                    firstName.ValidateFirstName(fName);
                    choose();
                    break;
                case 0:
                    break;
            }
        }
    }
}
