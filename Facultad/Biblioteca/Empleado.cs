using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    abstract class Empleado : Persona
    {
        protected DateTime _fechaIngreso;
        protected int _legajo;
        protected List<Salario> _salarios;

        public int Antiguedad
        {
            get
            {
                return int.Parse(DateTime.Now - _fechaIngreso);
            }
        }

        public DateTime FechaIngreso { get => _fechaIngreso; }

        public DateTime FechaNacimiento { get => _fechaNacimiento; }


        public int Legajo { get => _legajo; }

        public List<Salario> Salarios { get => _salarios; }

        public Salario UltimoSalario
        {
            get
            {
                return UltimoSalario;
            }
        }

        private void AgregarSalario()
    }
}
