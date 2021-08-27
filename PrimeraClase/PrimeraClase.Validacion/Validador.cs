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

        private static void ej1() {
            int registro = 708;
            for (int i = 1; i <= registro; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i + " - Foo");
                else if (i % 5 == 0)
                    Console.WriteLine(i + " - Bar");
                else if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " - FooBar");
                else
                    Console.WriteLine(i);
            }
        }

        private static void ej5()
        {
            string numero = "";
            Console.Write("Ingrese un número de 5 cifras: ");
            string num = Console.ReadLine();
            for (int i = 0; i < num.Length; i++)
            {
                numero += num[-i];
            }
            Console.WriteLine("El número invertido es " + numero);
        }

        private static void ej6() {
            Console.Write("Ingrese un numero: ");
            string a = Console.ReadLine();
            int numa = Convert.ToInt32(a));
            Console.Write("Ingrese otro numero: ");
            string b = Console.ReadLine();
            int numb = Convert.ToInt32(b);
            Console.WriteLine("Resultado: " + (numa + numb) * (numa - numb));
        }

        private static void ej8()
        {
            DateTime hoy = DateTime.Today;
            Console.Write("Ingrese una fecha: ");
            string input = Console.ReadLine();
            DateTime fecha = Convert.ToDateTime(input);
            int resultado = (hoy - fecha).Days;
            Console.WriteLine("La diferencia de fechas es de " + resultado + " días.");
        }

        private static void ej9()
        {
            string user = "felipe";
            Console.Write("Ingrese el nombre de usuario: ");
            string input = Console.ReadLine();
            if (user == input)
                Console.WriteLine("Hola felipe!");
            else Console.WriteLine("No te conozco");
        }

        private static void ej10()
        {
            Console.Write("Ingrese un caracter: ");
            string caracter = Console.ReadLine();
            if (caracter.Length > 1)
                Console.WriteLine("Ingrese un único caracter");
            else if (Char.IsNumber(Convert.ToChar(caracter)))
                Console.WriteLine("El caracter es un número");
            else if (caracter.Equals('a') || caracter.Equals('e') || caracter.Equals('i') || caracter.Equals('o') |||| caracter.Equals('u'))
                Console.WriteLine("El caracter es una vocal");
            else Console.WriteLine("El caracter es una consonante");
        }

        //terminar
        private static void ej12()
        {
            Console.WriteLine("Ingrese una fecha: ");
            DateTime fecha1 = Convert.ToDateTime(Console.ReadLine());
      
            Console.WriteLine("Ingrese otra fecha: ");
            DateTime fecha2 = Convert.ToDateTime(Console.ReadLine());

            TimeSpan diferencia = fecha1 - fecha2;  

            Console.WriteLine("La diferencia es de " + diferencia);
        }

        private static void ej13()
        {
            Console.Write("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <= num; i++)
            {
                res *= i;
            }
            Console.WriteLine(res);
        }

        public static void ej14()
        {
            Console.Write("Ingrese un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i  = 1; i < 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
        }

        public static void ej15()
        {
            
        }

        public static void ej16()
        {
            Console.Write("Ingrese un numero: ");
            string num = Console.ReadLine();
            Console.WriteLine("Número ingresado: " + num + " – Tiene " + num.Length + " dígitos");
        }


    }
}
