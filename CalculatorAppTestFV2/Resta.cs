using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAppTestFV2
{
    public class Resta : Operacion
    {
        public override double Calcular(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}