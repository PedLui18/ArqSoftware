namespace SinOCP
{
    public interface IAplicacion
    {
        string PrimerNombre { get; set; }
        string Apellido { get; set; }
        IServicioCuenta ProcesarCuenta { get; set; }
    }

    public class Persona : IAplicacion
    {
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        public IServicioCuenta ProcesarCuenta { get; set; }
    }
}