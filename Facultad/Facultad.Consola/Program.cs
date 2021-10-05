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
            Console.WriteLine("1) Listar Alumnos \n2) Listar Empleados \n3) Agregar Alumno \n4) Modfificar Alumno \n5) Eliminar Alumno \n6) Agregar Empleado \n7) Modificar Empleado \n8) Eliminar Empleado \nX) Salir");
        }

        private static void ListarAlumnos()
        {
            if (!_facultad.TraerAlumnos().Any())
                Console.WriteLine("No hay alumnos");
            else
            {
                foreach (Alumno a in _facultad.TraerAlumnos())
                {
                    Console.WriteLine(a.ToString());
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
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private static void AgregarAlumno()
        {
            Console.WriteLine("Ingrese el codigo del alumno: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del alumno: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento del alumno: ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            Alumno alumno = new Alumno(codigo, nombre, apellido, fecha);
            _facultad.AgregarAlumno(alumno);

            Console.WriteLine("Alumno agregado correctamente");
        }

        //AGREGAR EXCEPTION ALUMNO NO ENCONTRADO Y TERMINAR
        private static void ModificarAlumno()
        {
            Console.WriteLine("Ingrese el codigo del alumno a modificar: ");
            int codigo = int.Parse(Console.ReadLine());

            Alumno aModificar = _facultad.TraerAlumnoPorCodigo(codigo);
            if (aModificar == null)
                Console.WriteLine("No se encontró el alumno " + codigo);

            else
            {
                AgregarAlumno();
                _facultad.EliminarAlumno(aModificar);
                Console.WriteLine("Alumno eliminado correctamente");
            }
        }

        //AGREGAR EXCEPTION ALUMNO NO ENCONTRADO
        private static void EliminarAlumno()
        {
            Console.WriteLine("Ingrese el codigo del alumno a eliminar: ");
            int codigo = int.Parse(Console.ReadLine());
            Alumno aBorrar = _facultad.TraerAlumnoPorCodigo(codigo);

            if (aBorrar == null)
                Console.WriteLine("No se encontró el alumno " + codigo);

            else
            {
                _facultad.EliminarAlumno(aBorrar);
                Console.WriteLine("Alumno eliminado correctamente");
            }
        }

        private static void AgregarEmpleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento del empleado: ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de legajo del empleado: ");
            int legajo = int.Parse(Console.ReadLine());

            DateTime ingreso = DateTime.Now;

            Console.WriteLine("Ingrese el tipo de empleado: ");
            int tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:                    
                    Console.WriteLine("Ingrese el apodo del bedel");
                    string apodo = Console.ReadLine();
                    Bedel bedel = new Bedel(apodo, nombre, apellido, legajo, fecha, ingreso);
                    _facultad.AgregarEmpleado(bedel);
                    break;

                case 2:
                    Docente docente = new Docente(nombre, apellido, legajo, fecha, ingreso);
                    _facultad.AgregarEmpleado(docente);
                    break;

                case 3:
                    Directivo directivo = new Directivo(nombre, apellido, legajo, fecha, ingreso);
                    _facultad.AgregarEmpleado(directivo);
                    break;
            }    
            
            Console.WriteLine("Empleado agregado correctamente");
        }

        //AGREGAR EXCEPTION EMPLEADO NO ENCONTRADO Y TERMINAR
        private static void ModificarEmpleado()
        {
            Console.WriteLine("Ingrese el codigo del número de legajo del empleado a modificar: ");
            int legajo = int.Parse(Console.ReadLine());

            Empleado empModificar = _facultad.TraerEmpleadoPorLegajo(legajo);

            if (empModificar == null)
                Console.WriteLine("Empleado no encontrado");

            else
            {
                
                _facultad.AgregarEmpleado(empModificar);
                Console.WriteLine("Empleado elimnado correctamente");
            }
        }

        //AGREGAR EXCEPTION EMPLEADO NO ENCONTRADO
        private static void EliminarEmpleado()
        {
            Console.WriteLine("Ingrese el codigo del número de legajo del empleado a eliminar: ");
            int legajo = int.Parse(Console.ReadLine());

            Empleado empBorrar = _facultad.TraerEmpleadoPorLegajo(legajo);

            if (empBorrar == null)
                Console.WriteLine("Empleado no encontrado");

            else
            {
                _facultad.EliminarEmpleado(empBorrar);
                Console.WriteLine("Empleado elimnado correctamente");
            }
        }
    }
}
