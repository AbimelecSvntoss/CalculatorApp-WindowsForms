using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAppTestFV2
{
    public abstract class Operacion
    {
        public abstract double Calcular(double n1, double n2);
        public virtual string Validar(double n1, double n2)
        {
            return "";
        }
    }
}
