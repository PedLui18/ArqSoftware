using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new CitaMedica().Crear("Ariel", "Guzman", "ag@ddd.com", DateTime.Now));
            Console.WriteLine(new CitaMedica().Crear("", "", "ag@ddd.com", null));
            Console.ReadKey();
        }
    }

    //internal class CitaMedica
    //{
    //    internal string Crear(string nombre, string apellido, string correo, DateTime? hora)
    //    {
    //        string resultado = "";
    //        bool esValido = true;
    //        if (string.IsNullOrEmpty(nombre)) { 
    //            resultado = "El nombre es nulo";
    //            esValido = false;
    //        }
    //        if (string.IsNullOrEmpty(apellido))
    //        {
    //            resultado = "El apellido es nulo";
    //            esValido = false;
    //        }
    //        if (!correo.Contains("@")){
    //            resultado = "El correo es incorrecto";
    //            esValido = false;
    //        }
    //        if (hora == null)
    //        {
    //            resultado = "No tiene una hora asignada";
    //            esValido = false;
    //        }
    //        if (esValido)
    //            resultado = "La cita medica ha sido generada";

    //        return resultado;
    //    }
    //}
}
