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
            string stringForFloat = "0.31";
            string stringForInt = "22"; 

            int i = Int32.Parse(stringForInt);
            float f = float.Parse(stringForFloat);

            Console.WriteLine("Int = {0}, float = {1}", i,f);
        }
    }
}
