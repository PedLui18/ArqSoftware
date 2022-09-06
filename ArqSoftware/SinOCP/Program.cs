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
            List<Persona> personas = new List<Persona>() {
                new Persona { PrimerNombre = "Andres", Apellido = "Cespedes", esDoctor = true, Rol = Rol.Doctor},
                new Persona { PrimerNombre = "Elmer", Apellido = "Hermosa", esDoctor = false, Rol = Rol.Enfermera},
                new Persona { PrimerNombre = "Ruben", Apellido = "Saucedo", esDoctor = true, Rol = Rol.Doctor},
                new Persona { PrimerNombre = "Renato", Apellido = "Humerez", esDoctor = false, Rol = Rol.Enfermera},
                new Persona { PrimerNombre = "Armando", Apellido = "Carpas", esDoctor = false, Rol = Rol.Enfermera},
            };
            List<PersonalTrabajo> pTrabajo = new List<PersonalTrabajo>();
            foreach (Persona persona in personas) {
                // Servico Cuentas, que va manejar las cuentas de los empleados
                pTrabajo.Add(new ServicioCuenta().Crear(persona));
            }
            foreach (var personal in pTrabajo)
            {
                Console.WriteLine($"Bienvenido {personal.PrimerNombre}, {personal.Apellido}, {personal.Email}, {personal.esDoctor}, {personal.Rol}");
            }
            Console.ReadKey();
        }
    }
}
