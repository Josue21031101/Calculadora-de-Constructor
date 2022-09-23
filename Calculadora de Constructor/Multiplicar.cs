using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Constructor
{
    internal class Multiplicar
    {
        double v1, v2;

        public Multiplicar()
        {
        }

        public Multiplicar(double v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public double multiplicar()
        {
            return v1 * v2;
        }
    }
}
