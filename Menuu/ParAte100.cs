using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuu
{
    internal class ParAte100
    {
        public static void Ate100()
        {


            int contador;


            for (contador = 2; contador <= 100; contador++)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador + "\n");
                }

            }




        }
    }
}