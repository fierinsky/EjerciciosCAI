using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaHelper
{
    public static class Helper
    {
        public static bool validarInt(string entrada, ref int salida)
        {
            bool flag = true;
            if (!int.TryParse(entrada, out salida))
                Console.WriteLine("Ingrese un número");
            else flag = false;
            return flag;
        }

        public static bool validarFloat(string entrada, ref float salida)
        {
            bool flag = true;
            if (!float.TryParse(entrada, out salida))
                Console.WriteLine("Ingrese un número");
            else flag = false;
            return flag;
        }

        public static bool validarString(string s)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(s))
                Console.WriteLine("Texto vacío");
            else flag = false;
            return flag;
        }

        public static bool validarFecha(string entrada, ref DateTime salida)
        {
            bool flag = true;
            if (!DateTime.TryParse(entrada, out salida))
            {
                flag = true;
                Console.WriteLine("Ingrese una fecha válida");
            }
            else
            {
                TimeSpan ts = DateTime.Now - salida;
                if (ts.Days <= 0)
                {
                    flag = true;
                    Console.WriteLine("La fecha ingresada debe ser anterior a la fecha actual");
                }
                else flag = false;
            }
            return flag;
        }
    }
}
