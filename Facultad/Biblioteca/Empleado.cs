using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Empleado : Persona
    {
        protected DateTime _fechaIngreso;
        protected int _legajo;
        protected List<Salario> _salarios;
        protected Salario _ultimoSalario;

        public Empleado(int legajo, DateTime ingreso, string nombre, string apellido, DateTime fecha) : base(nombre, apellido, fecha)
        {
            _legajo = legajo;
            _fechaIngreso = ingreso;
        }

        //public int Antiguedad { get => int.Parse(DateTime.Now - _fechaIngreso); }

        public DateTime FechaIngreso { get => _fechaIngreso; }

        public DateTime FechaNacimiento { get => _fechaNacimiento; }

        public int Legajo { get => _legajo; }

        public List<Salario> Salarios { get => _salarios; }

        public Salario UltimoSalario { get => _ultimoSalario; }

        //VALIDAR
        private void AgregarSalario(Salario salario)
        {
            _salarios.Add(salario);
        }

        public override string GetCredencial()
        {
            return $"{_legajo}, - {GetNombreCompleto()} salario ${_ultimoSalario}";
        }

        public override string ToString()
        {
            return GetCredencial();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else if (_legajo == ((Empleado)obj).Legajo)
                return true;
            else
                return false;
        }
    }
}
