using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Facultad
    {
        //AGREGAR VALIDACIONES

        List<Alumno> _alumnos;
        private int _cantSedes;
        List<Empleado> _empleados;
        private string _nombre;

        public int CantSedes { get => _cantSedes; }
        public string Nombre { get => _nombre; }

        private void AgregarAlumno(Alumno alumno)
        {
            _alumnos.Add(alumno);
        }

        private void AgregarEmpleado (Empleado empleado)
        {
            _empleados.Add(empleado);
        }

        private void EliminarAlumno(Alumno alumno)
        {
            foreach (Alumno a in _alumnos)
            {
                if (a == alumno)
                    _alumnos.Remove(alumno);
            }
        }

        private void EliminarEmpleado(Empleado empleado)
        {
            foreach (Empleado e in _empleados)
            {
                if (e == empleado)
                    _empleados.Remove(empleado);
            }
        }

        //HACER
        private void ModificarEmpleado(Empleado empleado)
        {

        }

        private List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }

        //REVISAR
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
