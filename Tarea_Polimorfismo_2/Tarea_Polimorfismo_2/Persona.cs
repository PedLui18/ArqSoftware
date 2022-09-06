namespace Tarea_Polimorfismo_2
{
    public class Persona : IPersona
    {
        public string Nombre { get; set; }

        public virtual string correr()
        {
            return "Estoy Corriendo";
        }
    }
    //public abstract class Persona : IPersona
    //{
    //    public string Nombre { get; set; }

    //    public virtual string correr()
    //    {
    //        return "Estoy Corriendo";
    //    }
    //}
}