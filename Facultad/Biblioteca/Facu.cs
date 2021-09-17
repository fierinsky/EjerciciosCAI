using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Facu
    {
        //AGREGAR VALIDACIONES

        private List<Alumno> _alumnos;
        private int _cantSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        public int CantSedes { get => _cantSedes; }
        public string Nombre { get => _nombre; }

        public Facu(string nombre, int sedes)
        {
            _nombre = nombre;
            _cantSedes = sedes;
        }

        public void AgregarAlumno(Alumno alumno)
        {
            _alumnos.Add(alumno);
        }

        public void AgregarEmpleado (Empleado empleado)
        {
            _empleados.Add(empleado);
        }

        public void EliminarAlumno(Alumno alumno)
        {
            foreach (Alumno a in _alumnos)
            {
                if (a == alumno)
                    _alumnos.Remove(alumno);
            }
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            foreach (Empleado e in _empleados)
            {
                if (e == empleado)
                    _empleados.Remove(empleado);
            }
        }

        //HACER
        public void ModificarEmpleado(Empleado empleado)
        {

        }

        public List<Alumno> TraerAlumnos()
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

        public List<Empleado> TraerEmpleados()
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
