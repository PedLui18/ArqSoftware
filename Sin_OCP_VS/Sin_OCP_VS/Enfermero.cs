namespace SinOCP
{
    public class Enfermero : IAplicacion
    {
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        public IServicioCuenta ProcesarCuenta { get; set; } = new CuentaEnfermero();
    }
}