using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Multiplicacion
    {
        public static decimal Multiplicar(decimal n1, decimal n2)
        {
            if (n1 < 0 || n2 < 0)
                throw new InvalidOperationException("Numbers cannot be < 0");
            else if (n1 == 0 || n2 == 0)
                throw new InvalidOperationException("Multiplier is 0");
            return n1 * n2;
        }
    }
}
