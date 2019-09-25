using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_1
{
    public class Datos
    {
        public void Obtenerdatos()
        {
            // Se piden los datos y se asginan a variables , y se utiliza la sobrecarga del metodo para obtener un resultado
            Operaciones op = new Operaciones();
            Console.WriteLine("Hola");
            Console.WriteLine("Ingrese dos datos:");
            Console.WriteLine("Dato 1:");
            double dato1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dato 2:");
            double dato2 = Convert.ToDouble(Console.ReadLine());

            double res = op.Multiplicar(dato1, dato2);

            Console.WriteLine("Resultado = "+ res);
        }
    }
}
