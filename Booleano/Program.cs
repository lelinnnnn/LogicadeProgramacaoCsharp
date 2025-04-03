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

            bool valor1, valor2;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
████████ ██████  ██    ██ ███████      ██████  ██    ██     ███████  █████  ██      ███████ ███████ 
   ██    ██   ██ ██    ██ ██          ██    ██ ██    ██     ██      ██   ██ ██      ██      ██      
   ██    ██████  ██    ██ █████       ██    ██ ██    ██     █████   ███████ ██      ███████ █████   
   ██    ██   ██ ██    ██ ██          ██    ██ ██    ██     ██      ██   ██ ██           ██ ██      
   ██    ██   ██  ██████  ███████      ██████   ██████      ██      ██   ██ ███████ ███████ ███████ 
                                                                                                    ");

            Console.ResetColor();
            Console.WriteLine("Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.");
            Console.WriteLine("Digite true para VERDADEIRO ou false para FALSO");
            valor1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Digite true para VERDADEIRO ou false para FALSO");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 == true && valor2 == true)
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
