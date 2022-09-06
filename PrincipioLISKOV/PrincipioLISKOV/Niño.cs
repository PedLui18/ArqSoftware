using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLISKOV
{
    public class Niño : Persona
    {
        public int Rude { get; set; } 
        public Adulto Tutor { get; set; }

        //public Niño(int rude, string nombre, string apellidos)
        //{
        //    this.Rude = rude;
        //    this.Nombre = nombre;
        //    this.Apellidos = apellidos;
        //}
    }
}
