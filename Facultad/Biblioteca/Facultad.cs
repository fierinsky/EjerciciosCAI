using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Facultad
    {
        List<Alumno> _alumnos;
        private int _cantSedes;
        List<Empleado> _empleados;
        private string _nombre;

        public int CantSedes { get => _cantSedes; }
        public string Nombre { get => _nombre; }

        private void AgregarAlumno(Alumno alumno)
        {

        }

        private void AgregarEmpleado (Empleado empleado)
        {

        }

        private void EliminarAlumno(Alumno alumno)
        {

        }

        private void EliminarEmpleado(Empleado empleado)
        {

        }

        private void ModificarEmpleado(Empleado empleado)
        {

        }

        private List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }

        //revisar
        private Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            Empleado a = new Empleado();
            foreach (Empleado e in _empleados)
            {
                if (e.Legajo == legajo)
                    a = e;
            }
            return a;
        }

        private List<Empleado> TraerEmpleados()
        {
            return _empleados;
        }

        private List<Empleado> TraerEmpleadoPorApellido(string nombre)
        {
            List<Empleado> lst = new List<Empleado>();
            foreach (Empleado e in _empleados)
            {
                if (e.Nombre == nombre)
                    lst.Add(e);
            }
            return lst;
        }
    }
}
