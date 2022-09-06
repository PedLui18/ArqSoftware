using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP
{
    internal class AsignacionCitaMedica
    {
        public DateTime? DateTime { get; set; }
        public Paciente paciente { get; set; }

        public AsignacionCitaMedica()
        {

        }
    }
}
