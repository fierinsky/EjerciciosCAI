using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using ConsolaHelper;

namespace Facultad.Consola
{
    class Program
    {
        static bool _activo;
        static Facu _facultad;

        static Program()
        {
            _activo = true;
            _facultad = new Facu("FCE", 7);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a " + _facultad.Nombre + ", elija una opción para continuar: ");
            do
            {
                DesplegarMenu();

                string opcionSeleccionada = Console.ReadLine();
                Helper.validarString(opcionSeleccionada); 
                
            if (opcionSeleccionada.ToUpper() == "X")
                {
                    _activo = false;
                    continue;
                }

            switch (opcionSeleccionada)
                {
                    case "1":
                        ListarAlumnos();
                        break;
                    case "2":
                        ListarEmpleados();
                        break;
                    case "3":
                        AgregarAlumno();
                        break;
                    case "4":
                        ModificarAlumno();
                        break;
                    case "5":
                        EliminarAlumno();
                        break;
                    case "6":
                        AgregarEmpleado();
                        break;
                    case "7":
                        ModificarEmpleado();
                        break;
                    case "8":
                        EliminarEmpleado();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }   

                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }

            while (_activo);
            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
        }
        
        private static void DesplegarMenu()
        {
            Console.WriteLine("1) Listar Alumnos \n2) Listar Empleados \n3) Agregar Alumno \n4) Modfificar Alumno \n5) Eliminar Alumno \n6) Agregar Empleado \n7) Modificar Empleado \n8) Eliminar Empleado X) Salir");
        }

        private static void ListarAlumnos()
        {
            if (!_facultad.TraerAlumnos().Any())
                Console.WriteLine("No hay alumnos");
            else
            {
                foreach (Alumno a in _facultad.TraerAlumnos())
                {
                    Console.WriteLine(a.GetNombreCompleto());
                }
            }
        }

        private static void ListarEmpleados()
        {
            if (!_facultad.TraerEmpleados().Any())
                Console.WriteLine("No hay empleados");
            else
            {
                foreach (Empleado e in _facultad.TraerEmpleados())
                {
                    Console.WriteLine(e.GetNombreCompleto());
                }
            }
        }

        private static void AgregarAlumno()
        {
            Console.WriteLine("Ingrese el codigo del alumno nuevo: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del alumno nuevo: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del alumno nuevo: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento del alumno nuevo: ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            Alumno alumno = new Alumno(codigo, nombre, apellido, fecha);
            _facultad.AgregarAlumno(alumno);
        }

        private static void ModificarAlumno()
        {

        }

        private static void EliminarAlumno()
        {
            Console.WriteLine("Ingrese el codigo del alumno a eliminar: ");
            int codigo = int.Parse(Console.ReadLine());

            Alumno aBorrar = _facultad.TraerAlumnoPorCodigo(codigo);
            _facultad.EliminarAlumno(aBorrar);
            Console.WriteLine("Alumno elimnado correctamente");
        }

        private static void AgregarEmpleado()
        {

        }
        private static void ModificarEmpleado()
        {
            
        }

        private static void EliminarEmpleado()
        {
            Console.WriteLine("Ingrese el codigo del número de legajo del empleado a eliminar: ");
            int legajo = int.Parse(Console.ReadLine());

            Empleado empBorrar = _facultad.TraerEmpleadoPorLegajo(legajo);
            _facultad.EliminarEmpleado(empBorrar);
            Console.WriteLine("Empleado elimnado correctamente");
        }
    }
}
