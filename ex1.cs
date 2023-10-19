using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double num, tab, med;
            Console.WriteLine("Digite um numero:");
            num = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                tab = num * i;
                Console.WriteLine("{0} x {1} = {2}",num,i,tab);
            }
            Console.ReadKey();
        }
    }
}
