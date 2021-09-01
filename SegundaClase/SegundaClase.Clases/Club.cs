using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase.Clases
{
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
