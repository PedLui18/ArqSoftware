using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Polimorfismo_1
{
    internal class Empleado : Persona
    {
        public string tipoContrato { get; set; }
        public string sueldo { get; set; }

        private string nombre;
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        public override string calcularSueldo()
        {
            return (nombre + " " + "123Bs");
        }
    }

    //public class Empleado : IPersona
    //{
    //    public string tipoContrato { get; set; }
    //    public string sueldo { get; set; }
    //    public string apellidos { get; set; }
    //    public string documento { get; set; }
    //    public string nombres { get; set; }
    //    public string tipo { get; set; }

    //    public string calcularSueldo()
    //    {
    //        return "123Bs";
    //    }

    //}
}
