using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Resta
    {
        public static decimal Restar(decimal n1, decimal n2)
        {
            if (n1 < 0 || n2 < 0)
                throw new InvalidOperationException("Numbers cannot be < 0");
            else if (n1 < n2)
                throw new InvalidOperationException("First number must be > than Second number");
            return n1 - n2;
        }
    }
}
