using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Polimorfismo_1
{
    public abstract class Persona : IPersona
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string documento { get; set; }

        public string tipo { get; set; }

        public virtual string generarCodigo()
        {
            return "123asd";
        }

        public virtual string calcularSueldo()
        {
            return "100bs";
        }
    }

    //public abstract class Persona : IPersona
    //{
    //    public string nombres { get; set; }
    //    public string apellidos { get; set; }
    //    public string documento { get; set; }

    //    public string tipo { get; set; }

    //    public virtual string generarCodigo()
    //    {
    //        return "123asd";
    //    }

    //    public virtual string calcularSueldo()
    //    {
    //        return "100bs";
    //    }
    //}
}
