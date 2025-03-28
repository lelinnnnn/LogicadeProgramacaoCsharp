using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metragem, pernadireita, pernaesquerda;

            Console.WriteLine("Digite o tamanho da perna esquerda: ");
            pernaesquerda = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tamanho da perna direita: ");
            pernadireita = int.Parse(Console.ReadLine());
            
            
                if (pernadireita < pernaesquerda)
                {

                    Console.WriteLine("Cotó na perna direita");


                }
                else if (pernaesquerda == pernaesquerda)
                {
                    Console.WriteLine("Normal");
                }
                else
                {
                    Console.WriteLine("Cotó na perna esquerda");
                }

            
        }
        }
    }
