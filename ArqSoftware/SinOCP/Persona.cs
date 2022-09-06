namespace SinOCP
{
    public class Persona
    {
        public string PrimerNombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public bool esDoctor { get; set; }
        public Rol Rol { get; set; }
    }
}