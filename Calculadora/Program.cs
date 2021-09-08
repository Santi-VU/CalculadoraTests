using System;
using System.Drawing;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = 0;
            decimal n2 = 0;
            decimal[] decArray;

            bool error = false;
            bool entradaCombi = false;
            int opcion = -1;
            int auxOption = -1;

            decimal nuevoNumero = 0;
            string operador = "";
            bool primeraVez = true;
            decimal totalCombi = 0;
            
            StringBuilder sb = new StringBuilder();
            StringBuilder combinada = new StringBuilder();

            while (opcion != 0)
            {
                Console.WriteLine(MostrarOpciones(sb, error));
                if (Int32.TryParse(Console.ReadLine(), out opcion))
                    error = false;
                else
                    error = true;
                /////
                
                if (opcion == 1)
                {
                    Console.WriteLine("Introduzca primer número:");
                    Decimal.TryParse(Console.ReadLine(), out n1);

                    Console.WriteLine("Introduzca segundo número:");
                    Decimal.TryParse(Console.ReadLine(), out n2);

                    sb = new StringBuilder();
                    sb.Append("El resultado de la operación ");
                    sb.Append(n1.ToString());
                    sb.Append(" + ");
                    sb.Append(n2.ToString());
                    sb.Append(" es: ");
                    sb.Append(Suma.Sumar(n1, n2).ToString());
                    sb.Append("\n");

                    Console.WriteLine(sb.ToString());
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Introduzca primer número:");
                    Decimal.TryParse(Console.ReadLine(), out n1);

                    Console.WriteLine("Introduzca segundo número:");
                    Decimal.TryParse(Console.ReadLine(), out n2);

                    sb = new StringBuilder();
                    sb.Append("El resultado de la operación ");
                    sb.Append(n1.ToString());
                    sb.Append(" - ");
                    sb.Append(n2.ToString());
                    sb.Append(" es: ");
                    sb.Append(Resta.Restar(n1, n2).ToString());
                    sb.Append("\n");

                    Console.WriteLine(sb.ToString());
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Introduzca primer número:");
                    Decimal.TryParse(Console.ReadLine(), out n1);

                    Console.WriteLine("Introduzca segundo número:");
                    Decimal.TryParse(Console.ReadLine(), out n2);

                    sb = new StringBuilder();
                    sb.Append("El resultado de la operación ");
                    sb.Append(n1.ToString());
                    sb.Append(" * ");
                    sb.Append(n2.ToString());
                    sb.Append(" es: ");
                    sb.Append(Multiplicacion.Multiplicar(n1, n2).ToString());
                    sb.Append("\n");

                    Console.WriteLine(sb.ToString());
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Introduzca primer número:");
                    Decimal.TryParse(Console.ReadLine(), out n1);

                    Console.WriteLine("Introduzca segundo número:");
                    Decimal.TryParse(Console.ReadLine(), out n2);

                    decArray = Division.DividirConResto(n1, n2);

                    sb = new StringBuilder();
                    sb.Append("El resultado de la operación ");
                    sb.Append(n1.ToString());
                    sb.Append(" / ");
                    sb.Append(n2.ToString());
                    sb.Append(" es: ");
                    sb.Append(decArray[0].ToString());
                    sb.Append("\n");
                    sb.Append("El resto es: ");
                    sb.Append(decArray[1].ToString());
                    sb.Append("\n");

                    Console.WriteLine(sb.ToString());
                }
                else if (opcion == 5)
                { 
                    while (auxOption != 0)
                    {
                        Console.WriteLine(OpcionesCombinada(sb, entradaCombi, primeraVez));
                        string respuesta = Console.ReadLine();
                        if (respuesta.Equals("0"))
                        {
                            Console.WriteLine("Operación: " + combinada.ToString());
                            Console.WriteLine("Resultado: " + totalCombi.ToString());
                            auxOption = -1;
                            continue;
                        } 
                        else
                        {
                            if (entradaCombi == false)
                            {
                                if (!Decimal.TryParse(respuesta, out nuevoNumero))
                                {
                                    //error
                                } 
                                else
                                {
                                    if (primeraVez)
                                    {
                                        Decimal.TryParse(respuesta, out totalCombi);
                                        primeraVez = false;
                                    }

                                    combinada.Append(nuevoNumero.ToString());
                                    if (operador.Equals("+"))
                                    {
                                        totalCombi = Suma.Sumar(totalCombi, nuevoNumero);
                                    }
                                    else if (operador.Equals("-"))
                                    {
                                        totalCombi = Resta.Restar(totalCombi, nuevoNumero);
                                    }
                                    else if (operador.Equals("*"))
                                    {
                                        totalCombi = Multiplicacion.Multiplicar(totalCombi, nuevoNumero);
                                    }
                                    else if (operador.Equals("/"))
                                    {
                                        totalCombi = Division.Dividir(totalCombi, nuevoNumero);
                                    }
                                    entradaCombi = true;
                                }
                            }
                            else
                            {
                                if (respuesta.Length == 1)
                                {
                                    if (!respuesta.Equals("+") && !respuesta.Equals("-") && !respuesta.Equals("*") &&
                                        !respuesta.Equals("/"))
                                    {
                                        // err
                                    } 
                                    else
                                    {
                                        //Calcular
                                        if (respuesta.Equals("+"))
                                        {
                                            combinada.Append(respuesta);
                                        }
                                        else if (respuesta.Equals("-"))
                                        {
                                            combinada.Append(respuesta);
                                        }
                                        else if (respuesta.Equals("*"))
                                        {
                                            combinada.Append(respuesta);
                                        }
                                        else
                                        {
                                            combinada.Append(respuesta);
                                        }
                                        entradaCombi = false;
                                        operador = respuesta;
                                    }
                                } else
                                {
                                    //err
                                }
                            }
                        }
                    }
                }
                else if (opcion == 0)
                {
                    Console.WriteLine("Saliendoo...!");
                }
                else
                {
                    error = true;
                }
            }
        }

        public static string MostrarOpciones(StringBuilder sb, bool error)
        {
            sb = new StringBuilder();

            if (error == false)
                sb.AppendLine("Seleccione opción: ");
            else
                sb.AppendLine("Opción incorrecta. Seleccione nuevamente: ");
            sb.AppendLine("1) Sumar");
            sb.AppendLine("2) Restar");
            sb.AppendLine("3) Multiplicar");
            sb.AppendLine("4) Divir");
            sb.AppendLine("5) Operación combinada");
            sb.AppendLine("0) Salir");

            return sb.ToString();
        }

        public static string OpcionesCombinada(StringBuilder sb, bool entradaCombi, bool primeraVez)
        {
            sb = new StringBuilder();
            if (primeraVez)
                sb.AppendLine("Introduzca '0' para calcular la operación");
            if (entradaCombi == false)
                sb.AppendLine("Introduzca número");
            else
                sb.AppendLine("Introduzca operador");

            return sb.ToString();
        }
    }
}
