using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorAeBs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

                Console.WriteLine("Digite um valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            b = int.Parse(Console.ReadLine());

            if (a == b) {
                a + b;
        }
    }
}
