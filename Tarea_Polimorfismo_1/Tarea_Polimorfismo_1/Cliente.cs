using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Polimorfismo_1
{
    public class Cliente : Persona
    {
        private string nombre;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        public string categoria { get; set; }
        public string codigo { get; set; }


        public override string generarCodigo()
        {
            return (nombre + " " + "123abc");
        }
    }

    //public class Cliente : IPersona
    //{
    //    public string categoria { get; set; }
    //    public string codigo { get; set; }
    //    public string apellidos { get; set; }
    //    public string documento { get; set; }
    //    public string nombres { get; set; }
    //    public string tipo { get; set; }

    //    public string generarCodigo()
    //    {
    //        return "123abc";
    //    }
    //}
}
