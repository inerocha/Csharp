using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBase
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read(); 
        } 
        public static void Register ()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Completed");
            Console.WriteLine("_____________________________________________");
        }
        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password");
                }
            }else
            {
                Console.WriteLine("Login failed, wrong username");
            }
        }
    }
}
