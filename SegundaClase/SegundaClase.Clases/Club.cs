using System;
using System.Collections.Generic;

namespace SegundaClase.Clases
{
    public class Club
    {
        private int _idClub;
        private string _nombre;
        private DateTime _fundacion;
        private List<Futbolista> _futbolistas;
        //private Futbolista _jugador;

        public Club(int id, string nombre, DateTime fundacion)
        {
            _idClub = id;
            _nombre = nombre;
            _fundacion = fundacion;
            _futbolistas = new List<Futbolista>();
        }

        public Club()
        {
            _futbolistas = new List<Futbolista>();
        }
        
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

        public void FicharJugador(Futbolista f)
        {
            _futbolistas.Add(f);
        }

        public void MostrarJugadores()
        {
            foreach (Futbolista jugador in _futbolistas)
            {
                Console.WriteLine("Los jugadores de " + _nombre + " son: " + jugador.NombreCompleto);
            }
        }
    }
}
