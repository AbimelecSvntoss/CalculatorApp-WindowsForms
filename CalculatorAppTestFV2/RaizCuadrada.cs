using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAppTestFV2
{
    public class RaizCuadrada : Operacion
    {
        public override double Calcular(double n1, double n2)
        {
            return Math.Sqrt(n1);
        }

        public override string Validar(double n1, double n2)
        {
            if (n1 < 0)
                return "No existe raíz de números negativos.";

            return "";
        }
    }
}