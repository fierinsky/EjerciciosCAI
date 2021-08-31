using System;
using Restaurant.Clases;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant.Clases.Restaurant resto = new Clases.Restaurant();
            Plato fritas = new Plato();
            Menu menu = new Menu();
            Silla uno = new Silla();
            Silla dos = new Silla();
            Mesa mesaza = new Mesa();

            fritas.Id = 1;
            fritas.Descripcion = "Papas fritas de primera calidad cortadas en forma de rejilla fritadas en aceite de primera calidad";
            fritas.Nombre = "Papas Fritas Rejilla";
            fritas.Precio = 69.99f;

            menu.Platos[0] = fritas;

            resto.Nombre = "Lo de Pipe";
            resto.RazonSocial = "PIPE SRL";
            resto.Menu = menu;
            resto.Sillas[0] = uno;
            resto.Sillas[1] = dos;
            resto.Mesas[0] = mesaza;
        }
    }
}
