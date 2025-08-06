using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoAreYou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;

                Console.Write("Enter first name: ");
                firstName = Console.ReadLine().Trim();

                Console.Write("Enter last name: ");
                lastName = Console.ReadLine().Trim();

                Console.WriteLine($"\nYour full name is: {firstName} {lastName}");
        }
    }
}
