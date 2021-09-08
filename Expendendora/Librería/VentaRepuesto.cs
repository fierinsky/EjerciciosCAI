using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería
{
    public class VentaRepuesto
    {
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        public VentaRepuesto(string nombreComercio, string direccion)
        {
            _nombreComercio = nombreComercio;
            _direccion = direccion;
            _listaProductos = new List<Repuesto>();
        }

        public VentaRepuesto()
        {

        }

        public List<Repuesto> ListaProductos
        {
            get
            {
                return _listaProductos;
            }
        }

        public string NombreComercio
        {
            get
            {
                return _nombreComercio;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
        }

        public void AgregarRepuesto(Repuesto r)
        {
            _listaProductos.Add(r);
        }

        public void QuitarRepuesto(int cod)
        {
            Repuesto r = Buscar(cod);
            _listaProductos.Remove(r);
        }

        public void ModificarPrecio(int cod, double pre)
        {
            Repuesto r = Buscar(cod);
            r.Precio = pre;
        }

        public void AgregarStock(int cod, int cant)
        {

        }

        public void QuitarStock(int cod, int cant)
        {

        }

        public List<Repuesto> TraerPorCategoria(int cod)
        {
            return ListaProductos;
        }

        private Repuesto Buscar(int cod)
        {
            return _listaProductos.Where(r => r.Equals(cod)).First();
        }
    }
}
