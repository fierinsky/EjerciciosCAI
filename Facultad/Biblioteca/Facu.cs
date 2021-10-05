using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Facu
    {
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
            _alumnos = new List<Alumno>();
            _empleados = new List<Empleado>();
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

        public void ModificarAlumno(Alumno alumno)
        {

        }

        public void ModificarEmpleado(Empleado empleado)
        {

        }

        public List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }

        
        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado = empleados.Find(e => e.Legajo == legajo);
            return empleado;
        }

        public List<Empleado> TraerEmpleados()
        {
            return _empleados;
        }

        private List<Empleado> TraerEmpleadoPorNombre(string nombre)
        {
            List<Empleado> lst = new List<Empleado>();
            foreach (Empleado e in _empleados)
            {
                if (e.Nombre == nombre)
                    lst.Add(e);
            }
            return lst;
        }

        public Alumno TraerAlumnoPorCodigo(int codigo)
        {
            List<Alumno> alumnos = new List<Alumno>();
            Alumno alumno = alumnos.Find(a => a.Codigo == codigo);
            return alumno;
        }
    }
}
