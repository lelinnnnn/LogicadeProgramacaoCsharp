using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocarValor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valorB, valorA;

            Console.WriteLine("Digite o valor A: ");
            valorA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor B: ");
            valorB = int.Parse(Console.ReadLine());

            Console.WriteLine("ValorA igual a: " + valorB);
            Console.WriteLine("ValorB igual a: " + valorA);

        }
    }
}
