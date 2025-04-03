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

            Console.WriteLine(@"
 _____  ___   _       ___  ______ _____ _____  ___  ________ _   _ ________  ________ 
/  ___|/ _ \ | |     / _ \ | ___ \_   _|  _  | |  \/  |_   _| \ | |_   _|  \/  |  _  |
\ `--./ /_\ \| |    / /_\ \| |_/ / | | | | | | | .  . | | | |  \| | | | | .  . | | | |
 `--. \  _  || |    |  _  ||    /  | | | | | | | |\/| | | | | . ` | | | | |\/| | | | |
/\__/ / | | || |____| | | || |\ \ _| |_\ \_/ / | |  | |_| |_| |\  |_| |_| |  | \ \_/ /
\____/\_| |_/\_____/\_| |_/\_| \_|\___/ \___/  \_|  |_/\___/\_| \_/\___/\_|  |_/\___/ 
                                                                                      
                                                                                      
");
            Console.WriteLine("2-\tFaça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse \r\nusuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).\r\n");
            double salarioMinimo = 1518, salarioUsuario, qtdSalarioMinimo;

            Console.Write("Digite o salario: ");
            salarioUsuario = double.Parse(Console.ReadLine());

            qtdSalarioMinimo = (int)(salarioUsuario / salarioMinimo);
            Console.WriteLine("Salario usuario: " + salarioUsuario + "\nSalario minimo " + salarioMinimo + "\nQuantidade de salario minimo: " + qtdSalarioMinimo);

        }
    }
}
