using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuu
{
    internal class Fahrenheit
    {
        public static void Fah()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"

╔════════════════════════════════════════════════════════════════════════════════╗
║                                                                                ║
║ ███████  █████  ██   ██ ██████  ███████ ███    ██ ██   ██ ███████ ██ ████████  ║
║ ██      ██   ██ ██   ██ ██   ██ ██      ████   ██ ██   ██ ██      ██    ██     ║
║ █████   ███████ ███████ ██████  █████   ██ ██  ██ ███████ █████   ██    ██     ║
║ ██      ██   ██ ██   ██ ██   ██ ██      ██  ██ ██ ██   ██ ██      ██    ██     ║
║ ██      ██   ██ ██   ██ ██   ██ ███████ ██   ████ ██   ██ ███████ ██    ██     ║ 
║                                                                                ║
╚════════════════════════════════════════════════════════════════════════════════╝ 
");
            Console.ResetColor();
            Console.WriteLine("Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius. Imprima na tela as duas temperaturas.");
            int fahrenheit, celsius;
            Console.WriteLine("Digite a temperatura atual: ");
            fahrenheit = int.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Transformando Fahrenheit em Celsius: " + celsius);
        }
    }
}