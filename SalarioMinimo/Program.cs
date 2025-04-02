using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioMinimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioMinimo = 1518, salarioUsuario, qtdSalarioMinimo;

            Console.Write("Digite o salario: ");
            salarioUsuario = double.Parse(Console.ReadLine());

            qtdSalarioMinimo = (int)(salarioUsuario / salarioMinimo);
            Console.WriteLine("Salario usuario: " + salarioUsuario + "\nSalario minimo " + salarioMinimo + "\nQuantidade de salario minimo: " + qtdSalarioMinimo);

        }
    }
}
