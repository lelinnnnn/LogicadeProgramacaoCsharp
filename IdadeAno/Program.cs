using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeAno
{
    internal class Program
    {

        static void Main(string[] args, int contador)
        {
            
                int ano, anonascimento, idade;
            while (contador > 0)
            {
                Console.WriteLine("Digite sua idade");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o ano atual");
                ano = int.Parse(Console.ReadLine());


                    anonascimento = (ano - idade);




                if (idade == 0)
                {

                }
            }

        }
    }
}
