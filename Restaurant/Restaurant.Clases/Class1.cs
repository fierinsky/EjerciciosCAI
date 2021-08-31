using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Clases
{
    public class Restaurant
    {
        private string _nombre;
        private string _direccion;
        private string _RazonSocial;
        private string _descripcion;
        private Mesa[] _mesas;
        private Silla[] _sillas;
        private Menu _menu;
        private Empleado[] _empleados;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return _RazonSocial;
            }
            set
            {
                _RazonSocial = value;
            }
        }

        public Mesa[] Mesas
        {
            get
            {
                return _mesas;
            }
            set
            {
                _mesas = value;
            }
        }

        public Menu Menu
        {
            get
            {
                return _menu;
            }
            set
            {
                _menu = value;
            }
        }

        public Silla[] Sillas
        {
            get
            {
                return _sillas;
            }
            set
            {
                _sillas = value;
            }
        }

        public Empleado[] Empleados
        {
            get
            {
                return _empleados;
            }
            set
            {
                _empleados = value;
            }
        }
    }

    public class Mesa
    {
        private int _numero;
        private int _comensales;
        private string _material;
        private string _estado;

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        public int Comensales
        {
            get
            {
                return _comensales;
            }
            set
            {
                _comensales = value;
            }
        }

        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
            }
        }
    }

    public class Silla
    {
        private int _numero;
        private string _material;
        private string _estado;

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
            }
        }
    }

    public class Plato
    {
        private int _id;
        private float _precio;
        private string _nombre;
        private string _descripcion;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public float Precio
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

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
    }

    public class Menu
    {
        private Plato[] _platos;

        public Plato[] Platos
        {
            get
            {
                return _platos;
            }
            set
            {
                _platos = value;
            }
        }
    }

    public class Empleado
    {
        private string _nombre;
        private int _dni;
        private float _sueldo;
        private int _edad;
        private int _antiguedad;
        private string _puesto;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public int DNI
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }

        public float Sueldo
        {
            get
            {
                return _sueldo;
            }
            set
            {
                _sueldo = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }

        public int Antiguedad
        {
            get
            {
                return _antiguedad;
            }
            set
            {
                _antiguedad = value;
            }
        }

        public string Puesto
        {
            get
            {
                return _puesto;
            }
            set
            {
                _puesto = value;
            }
        }
    }
}
}
