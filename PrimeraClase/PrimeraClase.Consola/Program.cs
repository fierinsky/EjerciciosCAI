using System;
using PrimeraClase.Validacion;

namespace PrimeraClase.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            byte codigo = 0;
            float resultado = 0;
            float operando1 = 0;
            float operando2 = 0;
            do
            {
                Console.Write("1 Suma +" + Environment.NewLine + "2 Resta -" + Environment.NewLine + "3 División /"
                    + Environment.NewLine + "4 Multiplicación *" + Environment.NewLine + "5 Potenciación ^" +
                    Environment.NewLine + "9 Salir" + Environment.NewLine +
                    "Ingrese el número de la operación que desea realiar: ");
                input = Console.ReadLine();
                if (!Byte.TryParse(input, out codigo))
                    Console.WriteLine("Código erróneo");
                else if (codigo == 1 || codigo == 2 || codigo == 3 || codigo == 4 || codigo == 5)
                {
                    operando1 = ingresarNum();
                    operando2 = ingresarNum();
                    resultado = CalcularOperacion(codigo, operando1, operando2);
                    MostrarResultado(codigo, operando1, operando2, resultado);
                }
            }
            while (codigo != 9);
        }
    }
}
