using System;

namespace SegundaClase.Clases
{
    public class Futbolista
    {
        private int _numeroDocumento;
        private string _nombre;
        private string _apellido;
        private DateTime _edad;
        private int _ritmo;
        private int _dribbling;
        private int _tiro;
        private int _defensa;
        private int _ataque;
        private int _fisico;
        private float _sueldo;

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

        public DateTime Edad
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
    }

    public class Club
    {
        private int _idClub;
        private string _nombre;
        private DateTime _fundacion;
        private Futbolista[] _futbolistas;

        public int IdClub
        {
            get
            {
                return _idClub;
            }
            set
            {
                _idClub = value;
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

        public DateTime Fundacion
        {
            get
            {
                return _fundacion;
            }
            set
            {
                _fundacion = value;
            }
        }

        public Futbolista[] Futbolistas
        {
            get
            {
                return _futbolistas;
            }
            set
            {
                _futbolistas = value;
            }
        }
    }
}
