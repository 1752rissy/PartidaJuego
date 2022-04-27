using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaJugadores
{
    public  class ControladorJugador
    {
        //esta clase usa INYECCION DE DEPENDENCIA POR METODO, fijense como estan repartidas las responsabilidades 
        //segun el metodo y la interfaz correspondiente
        public void UsarMagia(IMagia magia)
        {
            magia.UsarMagia();
        }

        public void UsarDefensaPersonalArma(IPartida partida)
        {
            partida.UsarDefensaPersonal();
            partida.UsarArma();
        }
    }
}
