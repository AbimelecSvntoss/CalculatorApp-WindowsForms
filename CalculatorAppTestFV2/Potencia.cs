using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAppTestFV2
{
    public class Potencia : Operacion
    {
        public override double Calcular(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
    }
}