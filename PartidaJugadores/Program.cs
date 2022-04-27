using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJugadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //open close
            List<IPartida> TipoJugador = new List<IPartida>();
            List<IMagia> TipoJugadorMagia = new List<IMagia>();

            Elfo elfo = new Elfo(); 
            Guerrero guerrero = new Guerrero();

            TipoJugador.Add(guerrero);
            TipoJugador.Add(elfo);
            TipoJugador.Add(new Mago());
            TipoJugadorMagia.Add(elfo);
            TipoJugadorMagia.Add(new Mago());

            foreach (IPartida partida in TipoJugador)
            {
                partida.UsarArma();
                partida.UsarDefensaPersonal();
            }

            foreach(IMagia magia in TipoJugadorMagia)
            {
                magia.UsarMagia();
            }

            //si usamos la clase ControladorJugador seria de la siguiente fomra:
            ControladorJugador JugadorElfo = new ControladorJugador();
            //siempre cada jugador con el o los metodos que necesite implementar de la clase ControladorJugador
            JugadorElfo.UsarMagia(elfo);
            JugadorElfo.UsarDefensaPersonalArma(elfo);

            ControladorJugador Guerrero = new ControladorJugador();
            Guerrero.UsarDefensaPersonalArma(guerrero);

            Console.ReadLine();

        }
    }
}
