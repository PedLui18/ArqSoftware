using System;
using System.Collections.Generic;

namespace SinOCP
{
    public interface IServicioCuenta
    {
        PersonalTrabajo Crear(IAplicacion persona);
    }

    public class ServicioCuenta : IServicioCuenta
    {
        public ServicioCuenta()
        {
        }

        public PersonalTrabajo Crear(IAplicacion persona)
        {
            PersonalTrabajo personalTrabajo = new PersonalTrabajo();
            personalTrabajo.PrimerNombre = persona.PrimerNombre;
            personalTrabajo.Apellido = persona.Apellido;
            personalTrabajo.Email = $"{persona.PrimerNombre}.{persona.Apellido}@personal-trabajo.com";
            return personalTrabajo;
        }
    }
}