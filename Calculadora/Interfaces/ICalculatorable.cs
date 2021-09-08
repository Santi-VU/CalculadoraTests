using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Interfaces
{
    interface ICalculatorable
    {
        public decimal Sumar(decimal n1, decimal n2);
        public decimal Restar(decimal n1, decimal n2);
        public decimal Multiplicar(decimal n1, decimal n2);
        public decimal Dividir(decimal n1, decimal n2);
        public decimal[] DividirResto(decimal n1, decimal n2);

    }
}
