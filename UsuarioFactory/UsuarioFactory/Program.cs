using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioFactory
{
    internal class Program
    {
        public class Usuario{
            public string Nombre { get; set; }
            public string Correo{ get; set; }
            public string Pais { get; set; }

            private Usuario(string nombre, string correo, string pais)
            {
                Nombre = nombre;
                Correo = correo;
                Pais = pais;
            }

            public class Factory
            {
                //Principio de una solo responsabilidad --> Asignar y crear por defecto
                internal static Usuario PaisPorDefecto(string nombre, string correo)
                {
                    return new Usuario(nombre, correo, "Bolivia");
                }

                internal static Usuario CorreoPorDefecto(string nombre, string pais)
                {
                    return new Usuario(nombre, "uab@institucional.com", pais);
                }
            }
        }
        

        static void Main(string[] args)
        {
            //var usuario = new Usuario("Pedro", "pedro@tarqui.com");
            //Console.WriteLine($"Usuario: {usuario.Nombre}, Correo: {usuario.Correo}, Pais: {usuario.Pais}");
            var usuario1 = Usuario.Factory.PaisPorDefecto("Pedro", "pedro@tarqui.com");
            Console.WriteLine($"Usuario: {usuario1.Nombre}, Correo: {usuario1.Correo}, Pais: {usuario1.Pais}");
            var usuario2 = Usuario.Factory.CorreoPorDefecto("Pedro", "Bolivia");
            Console.WriteLine($"Usuario: {usuario2.Nombre}, Correo: {usuario2.Correo}, Pais: {usuario2.Pais}");
            Console.ReadKey();
        }
    }
}
