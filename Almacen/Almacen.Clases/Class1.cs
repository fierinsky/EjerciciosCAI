using System;

namespace Almacen.Clases
{
    public class Almacen
    {
        private string _nombre;
        private string _direccion;
        private string _razonSocial;
        private Producto[] _productos;
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

        public string RazonSocial
        {
            get
            {
                return _razonSocial;
            }
            set
            {
                _razonSocial = value;
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

        public Producto[] Productos
        {
            get
            {
                return _productos;
            }
            set
            {
                _productos = value;
            }
        }
    }

    public class Producto
    {
        private string _nombre;
        private int _id;
        private float _precio;
        private int _stock;

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

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
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
