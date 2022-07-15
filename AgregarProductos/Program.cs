using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregarProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod, linea;
            int can = 0,
                fi = 0;
            double pre = 0,
                tot = 0,
                pag = 0;
            char op;
            fi = 6;
            pag = 0;

            Console.WriteLine("------------------Agregar Productos------------------");
            Console.SetCursorPosition(5, 4);
            Console.Write("Producto     Cantidad    Precio      Total");
            do
            {
                Console.SetCursorPosition(5, fi);
                prod = Console.ReadLine();

                Console.SetCursorPosition(17, fi);
                linea = Console.ReadLine();
                can = int.Parse(linea);

                Console.SetCursorPosition(30, fi);
                linea = Console.ReadLine();
                pre = int.Parse(linea);

                tot = can * pre;
                Console.SetCursorPosition(43, fi);
                Console.Write(tot);

                pag = pag + tot;
                fi = fi + 1;
                Console.SetCursorPosition(30, 23);
                Console.Write("Desea agregar otro producto? S/N");
                linea = Console.ReadLine();
                op = char.Parse(linea.ToUpper());
            } while (op.ToString().Contains("S"));
            Console.WriteLine("Total a pagar: " + pag);
        }
    }
}
