namespace SinOCP{
    public class CuentaEnfermero : IServicioCuenta{

        public PersonalTrabajo Crear(IAplicacion persona)
        {
            PersonalTrabajo personalTrabajo = new PersonalTrabajo();
            personalTrabajo.PrimerNombre = persona.PrimerNombre;
            personalTrabajo.Apellido = persona.Apellido;
            personalTrabajo.Email = $"{persona.PrimerNombre}.{persona.Apellido}@enfermero.com";
            return personalTrabajo;
        }
    }
}
