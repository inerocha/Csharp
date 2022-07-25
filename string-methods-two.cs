using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBase
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the string here: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a character to search: ");
            char searchInput = Console.ReadLine()[0];
            int searchIndex = input.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Your full name is: {0}", fullName);

            Console.ReadKey();


        }
    }
}
