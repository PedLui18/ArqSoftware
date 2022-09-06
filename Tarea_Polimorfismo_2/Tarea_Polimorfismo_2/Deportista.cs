namespace Tarea_Polimorfismo_2
{
    //public class Deportista : Persona
    //{
    //    public override string correr()
    //    {
    //        return "Deportista esta corriendo";
    //    }
    //}

    public class Deportista : IPersona
    {
        public string Nombre { get; set; }
        public string correr()
        {
            return "Deportista esta corriendo";
        }
    }
}