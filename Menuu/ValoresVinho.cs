﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuu
{
    internal class ValoresVinho
    {
        public static void Vinho()
        {

            int quantidadeBranco = 0, quantidadeTinto = 0;
            string vinhos;


            while (true)
            {
                Console.WriteLine("Digite qual o tipo de vinho ou digite 'f' para finalizar o programa \n Digite ('t' para vinho tinto e 'b' para vinho branco): ");
                vinhos = Console.ReadLine();


                if (vinhos == "b")
                {
                    quantidadeBranco++;
                }
                if (vinhos == "t")
                {
                    quantidadeTinto++;
                }
                Console.Clear();
                if (vinhos == "f")
                {
                    Console.WriteLine("O total de vinhos brancos em estoque são: ", quantidadeBranco, "\ne o de vinhos tintos são: ", quantidadeTinto);
                    break;
                }
            }
        }
    }
}