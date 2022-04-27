using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJugadores
{
    public class Mago : Jugador, IPartida, IMagia
    {
        public override int puntuarJugador(int puntos)
        {
            return puntos;
        }

        public void UsarArma()
        {
            Console.WriteLine("soy el mago , y soy un pete usando arma");
        }

        public void UsarDefensaPersonal()
        {
            Console.WriteLine("soy el mago , y soy un pete usando defensa personal");
        }

        public void UsarMagia()
        {
            Console.WriteLine("soy el mago , y soy un crack usando magia");
        }
    }
}
