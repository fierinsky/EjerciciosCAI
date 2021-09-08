using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public Repuesto()
        {

        }

        public Repuesto(int cod, string nom, double pre, int sto, Categoria cat)
        {
            _codigo = cod;
            _nombre = nom;
            _precio = pre;
            _stock = sto;
            _categoria = cat;
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public int Stock
        {
            get
            {
                return _codigo;
            }
        }

        public override string ToString()
        {
            return _nombre;
        }
    }
}
