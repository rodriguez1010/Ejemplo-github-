using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_github
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Gray;

            string producto = "";

            double precio = 0;

            int cantidad = 0;

            Console.WriteLine("Ingrese su producto.");
            producto = Console.ReadLine();

            Console.WriteLine("Precio: ");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de producto: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("El producto {0} tiene una inversion de {1}", producto, (double)precio * cantidad);

            Console.ReadKey();

        }
    }
}
