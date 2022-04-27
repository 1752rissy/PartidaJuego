using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJugadores
{
    public class Elfo : Jugador, IPartida, IMagia
    {
        public override int puntuarJugador(int puntos)
        {
            return puntos;
        }

        public void UsarArma()
        {
            Console.WriteLine("soy el elfo , nivel medio usando arma");
        }

        public void UsarDefensaPersonal()
        {
            Console.WriteLine("soy el elfo , nivel medio usando defensa personal");
        }

        public void UsarMagia()
        {
            Console.WriteLine("soy el elfo , nivel medio usando arma");
        }
    }
}
