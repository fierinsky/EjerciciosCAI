using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librería;

namespace Expendendora.Consola
{
    class Program
    {
        static bool _consolaActiva;
        static VentaRepuesto _ventaRepuesto;

        static Program()
        {
            _consolaActiva = true;
            _ventaRepuesto = new VentaRepuesto("Ferretería Cacho", "Congreso 2389");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de " + _ventaRepuesto.NombreComercio);

            while (_consolaActiva)
            {
                Console.Clear();
                Menu();

                string opcionMenu = Console.ReadLine();

                switch (opcionMenu.ToLower())
                {
                    case "1":
                         Agregar();
                        break;
                    case "2":
                        Borrar();
                        break;
                    case "3":
                        Modificar();
                        break;
                    case "4":
                        Listar();
                        break;
                    case "5":
                        AgregarStock_Repuesto();
                        break;
                    case "6":
                        QuitarStock_Repuesto();
                        break;
                    case "x":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        private static void Modificar()
        {
            //VALIDAR CON HELPER
            Console.WriteLine("Ingres el codigo del repuesto a modificar");
            int cod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo precio del repuesto");
            double pre = Convert.ToDouble(Console.ReadLine());

            _ventaRepuesto.ModificarPrecio(cod, pre);

            Console.WriteLine("Precio modificado");
        }

        private static void Borrar()
        {
            //VALIDAR CON HELPER
            Console.WriteLine("Ingrese el codigo del repuesto a eliminar");
            int cod = Convert.ToInt32(Console.ReadLine());

            _ventaRepuesto.QuitarRepuesto(cod);
            Console.WriteLine("Repuesto quitado");
        }

        private static void Agregar()
        {
            //VALIDAR CON HELPER
            Console.WriteLine("Ingrese el codigo del repuesto");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del repuesto");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del repuesto");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la categoría del repuesto");
            string nomCat = Console.ReadLine();
            Console.WriteLine("Ingrese la categoría del repuesto");
            int codCat = Convert.ToInt32(Console.ReadLine());

            Categoria cat = new Categoria(codCat, nomCat);

            Repuesto r = new Repuesto(codigo, nombre, precio, 0, cat);

            _ventaRepuesto.AgregarRepuesto(r);
            Console.WriteLine("Repuesto agregado");
        }

        static void Menu()
        {
            Console.WriteLine("1) Alta repuesto");
            Console.WriteLine("2) Baja repuesto");
            Console.WriteLine("3) Modificar precio de un repuesto");
            Console.WriteLine("4) Listar repuestos por categoría");
            Console.WriteLine("5) Agregar stock a un repuesto");
            Console.WriteLine("6) Quitar stock a un repuesto");
            Console.WriteLine("X: Terminar");
        }
    }
}
