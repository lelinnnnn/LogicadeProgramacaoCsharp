using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoPessoaQueNasceu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"

╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                                           ║
║  █████  ███    ██  ██████  ███████     ██ ███    ███ ███████ ███████ ███████ ███████     ██ ██████  ██  █████  ███████    ║
║ ██   ██ ████   ██ ██    ██ ██         ██  ████  ████ ██      ██      ██      ██         ██  ██   ██ ██ ██   ██ ██         ║
║ ███████ ██ ██  ██ ██    ██ ███████   ██   ██ ████ ██ █████   ███████ █████   ███████   ██   ██   ██ ██ ███████ ███████    ║
║ ██   ██ ██  ██ ██ ██    ██      ██  ██    ██  ██  ██ ██           ██ ██           ██  ██    ██   ██ ██ ██   ██      ██    ║
║ ██   ██ ██   ████  ██████  ███████ ██     ██      ██ ███████ ███████ ███████ ███████ ██     ██████  ██ ██   ██ ███████    ║
║                                                                                                                           ║
╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝   ");
            Console.ResetColor();
            Console.Title = "Anos, Meses e Dias";
            int anonascimento = 1, idadeanos, anoatual , mes, dia;

            Console.WriteLine("Digite o ano que você nasceu: ");
            anonascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Que ano você está? ");
            anoatual = int.Parse(Console.ReadLine());

            idadeanos = anoatual - anonascimento;
            mes = idadeanos * 12;
            dia = idadeanos * 365;

            Console.WriteLine("IDADE: " + idadeanos);
            Console.WriteLine("MESES: " + mes);
            Console.WriteLine("DIAS:  " + dia);
                              

        }
    }
}
