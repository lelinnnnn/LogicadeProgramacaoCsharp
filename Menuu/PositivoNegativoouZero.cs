using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuu
{
    internal class PositivoNegativoouZero
    {
        public static void NegativouZero()
        {

            int numero;
            Console.WriteLine("VOU FALAR O QUE É O NÚMERO");
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());


            if (numero == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (numero > 0)
            {
                Console.WriteLine("Número positivo");
            }
            else
            {
                Console.WriteLine("Número negativo");
            }
        }
    }
}