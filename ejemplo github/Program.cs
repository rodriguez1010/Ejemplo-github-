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
            string codigo = "";
            double precio = 0;

            int cantidad = 0;

            Console.WriteLine("Ingrese su producto.");
            producto = Console.ReadLine();

            Console.WriteLine(" ingrese el codigo del producto");
            codigo = Console.ReadLine();

            Console.WriteLine("Precio: ");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de producto: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("El producto {0} con codigo de {1} tiene una inversion de {2}", producto,codigo, (double)precio * cantidad);

            Console.ReadKey();

        }
    }
}
