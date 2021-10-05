using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Directivo : Empleado
    {
        public Directivo(string nombre, string apellido, int legajo, DateTime fecha, DateTime ingreso) : base(legajo, ingreso, nombre, apellido, fecha)
        {

        }

        public override string GetNombreCompleto()
        {
            return "Sr. Director " + _apellido;
        }
    }
}
