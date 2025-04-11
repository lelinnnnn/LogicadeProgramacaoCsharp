using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menuu;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um sistema de menu em cada opção cadastre um item, controlando o acesso do teclado.

            int opcao = 1;
            while (opcao != 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
  __  __ ___ _  _ _   _   ___  ___     _ _____ _____   _____ ___   _   ___  ___ ___ 
 |  \/  | __| \| | | | | |   \| __|   /_\_   _|_ _\ \ / /_ _|   \ /_\ |   \| __/ __|
 | |\/| | _|| .` | |_| | | |) | _|   / _ \| |  | | \ V / | || |) / _ \| |) | _|\__ \
 |_|  |_|___|_|\_|\___/  |___/|___| /_/ \_\_| |___| \_/ |___|___/_/ \_\___/|___|___/
                                                                                    ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n Menu de atividades\n");
                Console.WriteLine(" 1 - Atividade Ano Bissexto");
                Console.WriteLine(" 2 - Atividade ano que nasceu");
                Console.WriteLine(" 3 - Atividade booleana");
                Console.WriteLine(" 4 - Atividade calcular desconto");
                Console.WriteLine(" 5 - Atividade calcular idade");
                Console.WriteLine(" 6 - Atividade cartão pagamento");
                Console.WriteLine(" 7 - Atividade do troco ");
                Console.WriteLine(" 8 - Atividade calcular IMC ");
                Console.WriteLine(" 9 - Atividade idade ano - INDISPONÍVEL");
                Console.WriteLine(" 10 - Atividade idade anos ");
                Console.WriteLine(" 11 - Atividade Keno ");
                Console.WriteLine(" 12 - Atividade maior número ");
                Console.WriteLine(" 13 - Atividade multiplo de 3 e 5 ");
                Console.WriteLine(" 14 - Atividade par até 100");
                Console.WriteLine(" 15 - Atividade do kg do peixe");
                Console.WriteLine(" 16 - Atividade positivo negativo ou zero");
                Console.WriteLine(" 17 - Atividade reajuste 5%");
                Console.WriteLine(" 18 - Atividade salário mínimo");
                Console.WriteLine(" 19 - Atividade sucessor - INDISPONÍVEL");
                Console.WriteLine(" 20 - Atividade Temperatura Fahrenheit Celsius");
                Console.WriteLine(" 21 - Atividade trocar valor");
                Console.WriteLine(" 22 - Atividade valor A e B");
                Console.WriteLine(" 23 - Atividade do Vinho");


                Console.ResetColor();

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                //TryParse serve para verificar se o conteudo da variavel é um texto digitado e simbolo ! (exclamação) simcoliza diferente
                //Lemos nessa condição  se (texto) ou (numero menor que 0) ou (numero maior que 5)
                {
                    Console.WriteLine(" Opção Invalida , Digite Novamente");
                }
                switch (opcao)
                {
                    case 1:

                        AnoBissexto.Bissexto();
                        break;

                    case 2:

                        AnoNasceu.AnoNascer();
                        break;

                    case 3:

                        NumBooleano.Booleano();
                        break;

                    case 4:


                        CalcularDesconto.Desconto();
                        break;

                    case 5:

                        CalculodeIdade.Idade();
                        break;

                    case 6:

                        CalculoCartao.Cartao();
                        break;

                    case 7:
                        CalculoTroco.Troco();
                        break;

                    case 8:

                        CalculoIMC.IMC();
                        break;

                    case 9:

                        Console.WriteLine("Indisponível");
                        break;

                    case 10:

                        CalculoIdadeAnos.IdadeAnos();
                        break;

                        
                    case 11:
                        PernaKeno.Keno();
                        break;

                        case 12:  
                            MaiorNumero.Numero();
                        break;

                    case 13:
                        ParAte100.Ate100();
                        break;

                        case 14:
                        Peixekg.Peixe();
                        break;

                        case 15:

                            PositivoNegativoouZero.NegativouZero();
                        break;

                    case 16:
                        Reajuste5.CincoPorCento();
                        break;

                    case 17:
                        SalarioMinimo.Minimo();
                        break;

                    case 18:
                        Fahrenheit.Fah();
                        break;

                        case 19:
                            ValoresVinho.Vinho();
                        break;







                    default:

                        Console.WriteLine(" 0Opção Invalida...Tente novamente");
                        break;

                }

                if (opcao != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

    }
}