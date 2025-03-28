using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peixe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            double peso, multa = 4, limite = 50;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("RENDIMENTO DIÁRIO");
            Console.WriteLine("\nMulta: R$ 4.00 por kG ultrapassado");
            Console.WriteLine("Digitalize o peso do peixe: ");
            peso = double.Parse(Console.ReadLine());

            excesso = (peso - limite);

            
        }
    }
}
