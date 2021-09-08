using System;
using System.Collections.Generic;
using SegundaClase.Clases;

namespace SegundaClase.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //AGREGAR INTERACCION CONSOLA-USUARIO, PASAR INTERACCION DE CONSOLA DE LAS CLASES AL PROGRAM
            Futbolista messi = new Futbolista();
            Club psg = new Club(1, "PSG", new DateTime(1970, 8, 12));

            messi.NumeroDocumento = 32964420;
            messi.Apellido = "Messi";
            messi.Nombre = "Lionel";
            messi.Fisico = 55;
            messi.Ataque = 99;
            messi.Defensa = 65;
            messi.Dribbling = 95;
            messi.Sueldo = 15000000;
            messi.BuenRendimiento = true;
            
            psg.FicharJugador(messi);
            psg.MostrarJugadores();

            messi.BonoContrato();
            messi.ConformeEnClub();
            messi.BonoContrato();
            messi.ConformeEnClub();

            Console.Write("Presiona enter para salir.");
            Console.ReadKey();
        }
    }
}
