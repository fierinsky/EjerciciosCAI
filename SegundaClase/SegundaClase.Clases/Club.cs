using System;
using System.Collections.Generic;

namespace SegundaClase.Clases
{
    public class Club
    {
        private int _idClub;
        private string _nombre;
        private DateTime _fundacion;

        public Club(int id, string nombre, DateTime fundacion)
        {
            _idClub = id;
            _nombre = nombre;
            _fundacion = fundacion;
        }

        public Club()
        {

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

        public void MostrarJugadores(List<Futbolista> jugadores)
        {
            Console.WriteLine("Los jugadores de " + _nombre + " son: " + jugadores.ToString());
        }
    }
}
