using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuu
{
    internal class CalculodeIdade
    {

        public static void Idade()
        {
            int ano_nascimento, ano_atual, idade;

            Console.Write("Digite o ano de seu nascimento: ");
            ano_nascimento = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            idade = ano_atual - ano_nascimento;
            Console.WriteLine("sua idade é: " + idade + " anos");

        }
    }
}