using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Models
{
    sealed public class Calculator : ICalculatorable
    {
        static Calculator calculator;

        public Calculator()
        {

        }

        public static Calculator GetInstance()
        {
            //this is not right
            //return new Adam();

            //this is the right way to do singleton
            if (calculator == null)
                calculator = new Calculator();
            return calculator;
        }

        public decimal Dividir(decimal n1, decimal n2)
        {
            return Division.Dividir(n1, n2);
        }

        public decimal[] DividirResto(decimal n1, decimal n2)
        {
            return Division.DividirConResto(n1, n2);
        }

        public decimal Multiplicar(decimal n1, decimal n2)
        {
            return Multiplicacion.Multiplicar(n1, n2);
        }

        public decimal Restar(decimal n1, decimal n2)
        {
            return Resta.Restar(n1, n2);
        }

        public decimal Sumar(decimal n1, decimal n2)
        {
            return Suma.Sumar(n1, n2);
        }
    }
}
