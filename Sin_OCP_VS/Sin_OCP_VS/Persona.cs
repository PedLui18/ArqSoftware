namespace SinOCP
{
    public class Persona : IAplicacion
    {
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        public IServicioCuenta ProcesarCuenta { get; set; }
    }
}