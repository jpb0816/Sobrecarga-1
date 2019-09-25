using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase operaciones para llamar los metodos de multiplicar
            
            Operaciones op = new Operaciones();
            double res = op.Multiplicar(2, 3);
            double res2 = op.Multiplicar(5);
            double res3=op.Multiplicar();

            Console.WriteLine(res);

            Console.WriteLine("\n"+res2);

            Console.WriteLine("\n"+res3);


            Console.WriteLine("--------------------------------");

            Datos d = new Datos();
            d.Obtenerdatos();

            Console.ReadKey();
        }
    }
}
