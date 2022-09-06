using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Partido
    {
        public string DT { get; set; }
        public string Arbitro { get; set; }
        public string Equipo { get; set; }

        public Partido(string dt, string arbitro, string equipo)
        {
            this.DT = dt;
            this.Arbitro = arbitro;
            this.Equipo = equipo;
        }

        public string Iniciar()
        {
            return ("Inicio el partido");
        }

        public string FinalizarPartido()
        {
            return "Finalizo el partido";
        }
    }
}
