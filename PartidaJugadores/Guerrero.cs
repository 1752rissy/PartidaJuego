using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJugadores
{
    internal class Guerrero : Jugador, IPartida
    {
        public override int puntuarJugador(int puntos)
        {
            return puntos;
        }

        public void UsarArma()
        {
            Console.WriteLine("soy el guerrero , y soy un crack usando arma");
        }

        public void UsarDefensaPersonal()
        {
            Console.WriteLine("soy el guerrero , y soy un crack usando defensa personal");
        }
    }
}
