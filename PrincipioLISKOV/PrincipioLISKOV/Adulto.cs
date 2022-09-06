using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLISKOV
{
    public class Adulto : Persona
    {
        public string Tarjeta { get; set; }
        //public Adulto(string ci, string nombre, string apellidos)
        //{
        //    this.CI = ci;
        //    this.Nombre = nombre;
        //    this.Apellidos= apellidos;
        //}

        public string PagarMatricula()
        {
            return "Pagando la mensualidad";
        }
    }
}
