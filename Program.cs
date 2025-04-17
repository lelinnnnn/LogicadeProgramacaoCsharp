using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] pokemons = { "Pikachu", "Pidgeot", "Arbok", "Ekans", "Raichu", "Nidorina", "Nidorino", "Gloom", "Zubat", "Paras" };
            string[] tipo = { "Eletrico", "Planta", "Poison", "Fogo", "Voar", "Agua", "Bug", "Normal", "Ground", "Fada "};
            int[] peso = { 10, 20, 30, 50, 3, 4, 75, 77, 54, 87 };
            Console.WriteLine($"Nome do pokemon: " + pokemons[0]);
            Console.WriteLine($"Tipo do pokemon: " + tipo[0]);
            Console.WriteLine($"Peso do pokemon: " + peso[0]);

            

            Console.WriteLine("Total de pokemons: " + pokemons.Length);

            Console.WriteLine("Listagem de pokemons");
            Console.WriteLine("ID\tPokemon\t\tTipo\t\tPeso");
            for (int i = 0; i < pokemons.Length; i++)
            {
                Console.Write(i);
                Console.Write("\t");
                Console.Write(pokemons[i]);
                Console.Write("\t\t");
                Console.Write(tipo[i]);
                Console.Write("\t\t");
                Console.WriteLine(peso[i]);
                
               
            }



        }
    }
}
