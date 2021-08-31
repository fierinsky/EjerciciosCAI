using System;
using Almacen.Clases;
namespace Almacen
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen.Clases.Almacen almacen = new Clases.Almacen();
            Producto papa = new Producto();
            Producto detergente = new Producto();
            Empleado cajero = new Empleado();
            Empleado limpieza = new Empleado();
            Empleado encargado = new Empleado();

            almacen.Nombre = "El Chino de la Esquina";
            almacen.Direccion = "Cochabamba 3470";
            almacen.RazonSocial = "Chino S.A.";

            papa.Id = 1;
            papa.Nombre = "Papa";
            papa.Precio = 15.5f;
            papa.Stock = 40;

            detergente.Id = 2;
            detergente.Nombre = "Mr. Músculo";
            detergente.Precio = 84.95f;
            detergente.Stock = 25;

            cajero.Nombre = "Carlos García";
            cajero.DNI = 44531960;
            cajero.Edad = 18;
            cajero.Antiguedad = 6;
            cajero.Puesto = "Cajero";
            cajero.Sueldo = 20000f;

            limpieza.Nombre = "Pedro Perez";
            limpieza.DNI = 37556960;
            limpieza.Edad = 25;
            limpieza.Antiguedad = 18;
            limpieza.Puesto = "Limpieza";
            limpieza.Sueldo = 30000f;

            encargado.Nombre = "Lorena Lopez";
            encargado.DNI = 34093812;
            encargado.Edad = 28;
            encargado.Antiguedad = 32;
            encargado.Puesto = "Encargada";
            encargado.Sueldo = 60000f;

            almacen.Productos[1] = detergente;
            almacen.Productos[0] = papa;

            almacen.Empleados[0] = limpieza;
            almacen.Empleados[1] = encargado;
            almacen.Empleados[2] = cajero;

        }
    }
}
