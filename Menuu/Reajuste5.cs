﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuu
{
    internal class Reajuste5
    {
        public static void CincoPorCento()
        {

            Console.Title = "Reajuste de 5%";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("╔═══════════════════════════════════════════════════════════════════════╗");
            Console.Write(@"                                            
║                                                                       ║
║   █████       ██ ██    ██ ███████ ████████ ███████     ███████ ██  ██ ║
║  ██   ██      ██ ██    ██ ██         ██    ██          ██         ██  ║
║  ███████      ██ ██    ██ ███████    ██    █████       ███████   ██   ║
║  ██   ██ ██   ██ ██    ██      ██    ██    ██               ██  ██    ║
║  ██   ██  █████   ██████  ███████    ██    ███████     ███████ ██  ██ ║
");

            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.");
            double valor, valorReajustado;

            Console.Write("Digite um valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor normal: " + valor);
            valorReajustado = (valor * 0.05) + valor;

            Console.WriteLine("Valor reajustado: " + valorReajustado);
        }
    }
}