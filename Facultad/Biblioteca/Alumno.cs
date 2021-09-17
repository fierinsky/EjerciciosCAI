using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Alumno : Persona
    {
        private int _codigo;

        public int Codigo { get => _codigo; }

        public string Credencial { get => GetCredencial(); }

        public Alumno(int codigo, string nombre, string apellido, DateTime fecha) : base(nombre, apellido, fecha)
        {
            _codigo = codigo;
        }

        public override string GetCredencial()
        {
            return $"Código: {_codigo} {_apellido}, {_nombre}";
        }

        public override string ToString()
        {
            return GetCredencial();
        }
    }
}
