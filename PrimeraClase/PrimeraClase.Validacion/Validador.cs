using System;

namespace PrimeraClase.Validacion
{
    public class Validador
    {
        private static float ingresarNum()
        {
            bool flag;
            string operando;
            float op;
            do
            {
                Console.Write("Ingrese un número: ");
                operando = Console.ReadLine();
                if (!float.TryParse(operando, out op))
                {
                    Console.WriteLine("Ingrese un valor numérico");
                    flag = true;
                }
                else flag = false;
            }
            while (flag);
            return op;
        }

        private static float CalcularOperacion(byte cod, float op1, float op2)
        {
            float res = 0;
            switch (cod)
            {
                case 1:
                    res = op1 + op2;
                    break;
                case 2:
                    res = op1 - op2;
                    break;
                case 3:
                    if (op2 != 0)
                        res = op1 / op2;
                    break;
                case 4:
                    res = op1 * op2;
                    break;

                case 5:
                    res = Convert.ToSingle(Math.Pow(op1, op2));
                    break;
            }
            return res;
        }

        private static void MostrarResultado(byte cod, float op1, float op2, float res)
        {
            switch (cod)
            {
                case 1:
                    Console.WriteLine(op1 + " + " + op2 + " = " + res); ;
                    break;
                case 2:
                    Console.WriteLine(op1 + " - " + op2 + " = " + res); ;
                    break;
                case 3:
                    if (op2 == 0)
                        Console.WriteLine("Error, división por 0");
                    else
                        Console.WriteLine(op1 + " / " + op2 + " = " + res); ;
                    break;
                case 4:
                    Console.WriteLine(op1 + " * " + op2 + " = " + res); ;
                    break;
                case 5:
                    Console.WriteLine(op1 + " ^ " + op2 + " = " + res);
                    break;
            }
        }
    }
}
