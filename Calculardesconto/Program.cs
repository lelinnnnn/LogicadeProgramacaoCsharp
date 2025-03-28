using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculardesconto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double preco, desconto;


            Console.WriteLine("Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());


            if (preco > 100)
            {
                desconto = preco * 0.10;
                Console.WriteLine(desconto + " reais de desconto");
            }
            else
            {
                {
                    desconto = preco * 0.05;
                    Console.WriteLine(desconto + " reais de desconto");

                }





            }
        }
    }
}