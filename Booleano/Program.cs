using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleano
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string valor1, valor2;

            Console.WriteLine("Digite true para VERDADEIRO ou false para FALSO");
            valor1 = Console.ReadLine();
            Console.WriteLine("Digite true para VERDADEIRO ou false para FALSO");
            valor2 = Console.ReadLine();

            if (valor1 == "VERDADEIRO" && valor2 == "VERDADEIRO")
            {
                Console.WriteLine("VERDADEIRO");
            }
            else
            {
                Console.WriteLine("FALSO");
            }
        }
    }
}
