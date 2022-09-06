using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sin_OCP_VS
{
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
