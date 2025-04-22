using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Randomm
{
    internal class Program
    {
        public class Ficha
        {
            //Propriedades
            public string NomeDoJogador;
            public string NomeDoPersonagem;
            public string Raca;
            public string Classe;
            public int vida;

            //Método
            public void ImprimirFicha()
            {
                {
                    Console.WriteLine("=================== FICHA DO PERSONAGEM ===================");
                    Console.WriteLine("Nome do personagem: " + NomeDoPersonagem);
                    Console.WriteLine("Raça: " + Raca);
                    Console.WriteLine("Classe: " + Classe);
                    Console.WriteLine("Vida: " + vida);
                    Console.WriteLine("======================");
                    Console.WriteLine("======================");
                    Console.WriteLine("\n");
                }
            }
        }


        static void Main(string[] args)
        {
            

            Random random = new Random();
            int d6jogador = 0;
            int d6inimigo = 0;


            Ficha personagemPrincipal = new Ficha();

            personagemPrincipal.NomeDoJogador = "MARCIAODOTI";
            personagemPrincipal.NomeDoPersonagem = "MARCINHO";
            personagemPrincipal.Raca = "TI";
            personagemPrincipal.Classe = "TORNEIRO";
            personagemPrincipal.vida = 1000;

            


            Console.WriteLine("===========AVENTURA COMEÇA===========");
            personagemPrincipal.ImprimirFicha();
            Console.WriteLine("Você está marciando");
            Console.WriteLine("Uma pessoa esbarra em você. O que você faz?\n[ 1 ] se vira\n[ 2 ] continua como se nada fosse"); 


            string decisao = Console.ReadLine();

            {
                if (decisao == "2")
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Agora começa!!!");
                    Ficha inimigo = new Ficha();
                    inimigo.NomeDoJogador = "Valus";
                    inimigo.NomeDoPersonagem = "White";
                    inimigo.Raca = "Colosso";
                    inimigo.Classe = "Gigante";
                    inimigo.vida = 2000;
                    inimigo.ImprimirFicha();

                    while (inimigo.vida > 0)
                        d6jogador = random.Next(1, 6);
                    d6inimigo = random.Next(1, 6);

                    if (d6jogador > d6inimigo)
                    {
                        inimigo.vida -= 10;
                        Console.WriteLine("Boa, consegui acertar!");

                    }
                    else if (d6jogador < d6inimigo)
                    {
                        personagemPrincipal.vida -= 10;
                        Console.WriteLine("Eite, essa doeu!*");
                    }
                    else
                    {
                        Console.WriteLine("Nada acontece!");

                    }
                    Console.WriteLine("Vida do jogador: " + personagemPrincipal.vida);
                    Console.WriteLine("Vida do inimigo: " + inimigo.vida);
                    Console.WriteLine("\n");

                    Thread.Sleep(1000);

                }



                else
                {
                    Console.WriteLine("Continua a beber");
                }






            }



            }
    }
}
