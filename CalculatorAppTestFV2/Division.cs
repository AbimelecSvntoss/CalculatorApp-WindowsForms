using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAppTestFV2
{
    public class Division : Operacion
    {
        public override double Calcular(double n1, double n2)
        {
            return n1 / n2;
        }

        public override string Validar(double n1, double n2)
        {
            if (n2 == 0)
                return "No se puede dividir entre cero.";

            return "";
        }
    }
}