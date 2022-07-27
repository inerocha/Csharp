using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneBase
{
    public class BaseOne
    {
        static void Main(String[] args)
        {
            //Use the correct method to print the highest value of x and y.
            int x = 5;
            int y = 10;
            Console.WriteLine(Math.Max(x,y));

            //Use the correct method to print the square root of x.
            Console.WriteLine(Math.Sqrt(64));


            //Use the correct method to round the number 2.6 to its nearest integer.
            Console.WriteLine(Math.Round(2.6));
        }
    }
}
