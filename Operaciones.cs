using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_1
{
    public class Operaciones
    {
        // Se hacen tres metodos con mismo nombre pero que tengan diferentes parametros
        public double Multiplicar(double a, double b)
        {
            double mult=a*b;

            return mult;
        }
        public double Multiplicar(double a)
        {
            double mult=a*5;
            return mult;
        }
        public double Multiplicar()
        {
            double mult=5*5;
            return mult;

        }
    }
}
