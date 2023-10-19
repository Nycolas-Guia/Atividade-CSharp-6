using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.Clear();
            double I,F;
            Console.WriteLine("Digite o primeiro numero da sequencia:");
            I = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Digite o ultimo numero da sequencia:");
            F = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            if (F < I)
            {
                goto inicio;
            }

            while (I > 0 && F > 0 && I <= F)
            {
                Console.WriteLine(I);
                I++;
                Thread.Sleep(100);
            }
            
            Console.ReadKey();
        }
    }
}
