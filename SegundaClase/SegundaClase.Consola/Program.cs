using System;
using SegundaClase.Clases;

namespace SegundaClase.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolista messi = new Futbolista();
            Club psg = new Club();

            messi.NumeroDocumento = 32964420;
            messi.Apellido = "Messi";
            messi.Nombre = "Lionel";
            messi.Fisico = 55;
            messi.Ataque = 99;
            messi.Defensa = 65;
            messi.Dribbling = 95;
            messi.Sueldo = 15000000;

            psg.IdClub = 1;
            psg.Nombre = "PSG";
            psg.Fundacion = new DateTime(1970, 8, 12);
            psg.Futbolistas[0] = messi;
        }
    }
}
