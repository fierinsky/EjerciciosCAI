using System;

namespace SegundaClase.Clases
{
    public class Futbolista
    {
        private int _numeroDocumento;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private int _ritmo;
        private int _dribbling;
        private int _tiro;
        private int _defensa;
        private int _ataque;
        private int _fisico;
        private float _sueldo;
        private bool _buenRendimiento;

        public Futbolista()
        {
            _buenRendimiento = false;
        }

        public Futbolista(int dni, string nombre, DateTime fechaNacimiento, int ritmo, int dribbling, int tiro, int defensa, int ataque, int fisico, float sueldo, bool rendimiento)
        {
            _numeroDocumento = dni;
            nombre = _nombre + " " + _apellido;
            _fechaNacimiento = fechaNacimiento;
            _ritmo = ritmo;
            _dribbling = dribbling;
            _tiro = tiro;
            _defensa = defensa;
            _ataque = ataque;
            _fisico = fisico;
            _sueldo = sueldo;
            _buenRendimiento = rendimiento;
        }

        //propiedades, getter y setter
        public int NumeroDocumento
        {
            get
            {
                return _numeroDocumento;
            }
            set
            {
                _numeroDocumento = value;
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

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }


        public string NombreCompleto
        {
            get
            {
                return _nombre + " " + _apellido;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }

        //CORREGIR
        public TimeSpan Edad
        {
            get
            {
                return DateTime.Now - _fechaNacimiento;
            }
        }

        public int Ritmo
        {
            get
            {
                return _ritmo;
            }
            set
            {
                _ritmo = value;
            }
        }

        public int Ataque
        {
            get
            {
                return _ataque;
            }
            set
            {
                _ataque = value;
            }
        }

        public int Defensa
        {
            get
            {
                return _defensa;
            }
            set
            {
                _defensa = value;
            }
        }

        public int Tiro
        {
            get
            {
                return _tiro;
            }
            set
            {
                _tiro = value;
            }
        }

        public int Fisico
        {
            get
            {
                return _fisico;
            }
            set
            {
                _fisico = value;
            }
        }

        public int Dribbling
        {
            get
            {
                return _dribbling;
            }
            set
            {
                _dribbling = value;
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

        public bool BuenRendimiento
        {
            get
            {
                return _buenRendimiento;
            }
            set
            {
                _buenRendimiento = value;
            }
        }


        public void BonoContrato()
        {
            if (_buenRendimiento) 
            {
                _sueldo *= 1.2f;
                Console.WriteLine(NombreCompleto + " ha recibido un bonus en su contrato por su buen rendimiento");
            }
        }

        public void ConformeEnClub()
        {
            if (_sueldo > 20000000)
                Console.WriteLine("El futbolista " + _nombre + " está conforme en el club.");
            else Console.WriteLine("El futbolista " + _nombre + " no está conforme en el club");
        }
    }
}
