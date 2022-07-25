using System; 

namespace ProjectBase
{
    public class Project
    {
        static void Main(string[] args)
        {
            int t, n;

            Console.WriteLine("Escolha um número para obter a tabuada: ");
            t = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o número de vezes desejadas: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", t, i, (t * i));
            }
            Console.ReadKey(); 
        }
    }
}
