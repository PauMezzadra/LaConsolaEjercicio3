using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsolaEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Ingrese cualquier tecla, o X para terminar");

            } while (Console.ReadKey().Key != ConsoleKey.X);

        }
    }
}
