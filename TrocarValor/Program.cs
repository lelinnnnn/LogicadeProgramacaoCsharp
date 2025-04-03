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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"

╔═══════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                   ║
║ ████████ ██████   ██████   ██████  █████  ██████      ██    ██  █████  ██       ██████  ██████    ║
║    ██    ██   ██ ██    ██ ██      ██   ██ ██   ██     ██    ██ ██   ██ ██      ██    ██ ██   ██   ║
║    ██    ██████  ██    ██ ██      ███████ ██████      ██    ██ ███████ ██      ██    ██ ██████    ║
║    ██    ██   ██ ██    ██ ██      ██   ██ ██   ██      ██  ██  ██   ██ ██      ██    ██ ██   ██   ║
║    ██    ██   ██  ██████   ██████ ██   ██ ██   ██       ████   ██   ██ ███████  ██████  ██   ██    ║
║                                                                                                   ║
╚═══════════════════════════════════════════════════════════════════════════════════════════════════╝                                                                                                
");
            Console.ResetColor();
            int valorB, valorA;
            Console.WriteLine("Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.");
            Console.WriteLine("Digite o valor A: ");
            valorA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor B: ");
            valorB = int.Parse(Console.ReadLine());

            Console.WriteLine("ValorA igual a: " + valorB);
            Console.WriteLine("ValorB igual a: " + valorA);

        }
    }
}
