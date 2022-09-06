namespace SinOCP
{
    public class Doctor : IAplicacion
    {
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        public IServicioCuenta ProcesarCuenta { get; set; } = new CuentaDoctor();
    }
}