using System;
using System.Collections.Generic;

namespace SinOCP
{
    internal class ServicioCuenta
    {
        public ServicioCuenta()
        {
        }

        public PersonalTrabajo Crear(Persona persona)
        {
            PersonalTrabajo personalTrabajo = new PersonalTrabajo();
            personalTrabajo.PrimerNombre = persona.PrimerNombre;
            personalTrabajo.Apellido = persona.Apellido;
            //personalTrabajo.Email =  $"{persona.PrimerNombre}.{persona.Apellido}@personal-trabajo.com";
            personalTrabajo.Email =  $"{persona.PrimerNombre}.{persona.Apellido}@{persona.Rol}.com";
            personalTrabajo.esDoctor = persona.esDoctor;
            personalTrabajo.Rol = persona.Rol;
            return personalTrabajo;
        }
    }
}