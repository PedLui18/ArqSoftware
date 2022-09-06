using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Reloj
    {
        //Propiedad fecha Hora
        public DateTime FechaHora { get; set; }

        private Reloj() { }

        public static Reloj instanciaReloj = new Reloj();

        public static Reloj Instancia()
        {
            instanciaReloj.FechaHora = DateTime.Now;
            return instanciaReloj;
        }
    }
}
