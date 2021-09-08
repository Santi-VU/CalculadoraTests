using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Calculadora
{
    public class Division
    {
        public static decimal [] DividirConResto(decimal n1, decimal n2)
        {

            if (n2 == 0)
                throw new DivideByZeroException("Dividend value is 0");
            if (n1 < 0 || n2 < 0)
                throw new InvalidOperationException("Numbers cannot be < 0");

            decimal[] array = new decimal[2];
            array[0] = n1 / n2;
            array[1] = n1 % n2;

            return array;
        }

        public static decimal Dividir(decimal n1, decimal n2)
        {
            if (n2 == 0)
                throw new DivideByZeroException("Dividend value is 0");
            if (n1 < 0 || n2 < 0)
                throw new InvalidOperationException("Numbers cannot be < 0");
            
            return n1 / n2;
        }
    }
}
