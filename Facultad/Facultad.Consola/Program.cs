using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

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
            Console.WriteLine("Bienvenido a " + _facultad.Nombre);
            do
            {
                DesplegarMenu(); 
                string opcionSeleccionada = Console.ReadLine();
                
            if (opcionSeleccionada.ToUpper() == "X")
                {
                    _activo = false;
                    continue;
                }

            switch (opcionSeleccionada)
                {
                    case "1":
                        // listar
                        ListarAlumnos();
                        break;
                    case "2":
                        // listar
                        ListarEmpleados();
                        break;
                    case "3":
                        // alta
                        AgregarAlumno();
                        break;
                    case "4":
                        // modificar
                        ModificarAlumno();
                        break;
                    case "5":
                        // borrar
                        EliminarAlumno();
                        break;
                    case "6":
                        // alta
                        AgregarEmpleado();
                        break;
                    case "7":
                        // modificar
                        ModificarAlumno();
                        break;
                    case "8":
                        // borrar
                        EliminarEmpleado();
                        break;
                    case "9":
                        Console.Clear();
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
        
        //terminar
        private static void DesplegarMenu()
        {
            Console.WriteLine("1) Listar Alumnos \n2) Listar Empleados ... Sigan escribiendo ustedes");
        }

        private static void ListarAlumnos()
        {
            _facultad.TraerAlumnos();
        }

        private static void ListarEmpleados()
        {
            _facultad.TraerEmpleados();
        }

        private static void AgregarAlumno()
        {
            //cambiar lo del codigo
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

        //HACER
        private static void EliminarAlumno()
        {

        }
    }
}
