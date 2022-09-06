using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinOCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TENEMOS UNA SERIE DE PERSONAS QUE VAN A SER POSTULANTES A
            //UNA SERIE DE TRABAJOS (Personal Trabajo)
            List<IAplicacion> personas = new List<IAplicacion>() {
                new Persona { PrimerNombre = "Andres", Apellido = "Cespedes"},
                new Doctor { PrimerNombre = "Elmer", Apellido = "Hermosa"},
                new Enfermero { PrimerNombre = "Ruben", Apellido = "Saucedo"},
                new Doctor { PrimerNombre = "Renato", Apellido = "Humerez"},
                new Persona { PrimerNombre = "Armando", Apellido = "Carpas"},
            };

            List<PersonalTrabajo> personalTrabajo = new List<PersonalTrabajo>();
            foreach (IAplicacion persona in personas)
            {
                // Servico Cuentas, que va manejar las cuentas de los empleados
                personalTrabajo.Add(persona.ProcesarCuenta.Crear(persona));
                //pTrabajo.Add(new ServicioCuenta().Crear(persona));
            }
            foreach (var personal in personalTrabajo)
            {
                Console.WriteLine($"Bienvenido {personal.PrimerNombre}, {personal.Apellido}, {personal.Email}");
            }
            Console.ReadKey();
        }
    }
}
