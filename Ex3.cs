using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            do
            {               
                Console.WriteLine("Digite um numero par:");
                num = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            } while (num % 2 != 0);
            
            Console.WriteLine("Numero digitado: " + num);

            Console.ReadKey();
        }
    }
}
