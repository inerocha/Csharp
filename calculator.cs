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
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Type a number, and then press enter: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type another number, and then press enter: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list: ");
            Console.WriteLine("Add +");
            Console.WriteLine("Subtract -");
            Console.WriteLine("Multiply *");
            Console.WriteLine("Divide /");
            Console.WriteLine("Your option?: ");

            switch (Console.ReadLine())
            {
                case "+": 
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Your result {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break; 
            }

            Console.WriteLine("Press any key to close the Calculator");
            Console.ReadKey();
        }
    }
}
