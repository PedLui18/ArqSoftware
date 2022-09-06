namespace Tarea_Polimorfismo_2
{
    //public class Informatico : Persona
    //{
    //    public override string correr()
    //    {
    //        return "Informatico corre";
    //    }
    //}

    public class Informatico : IPersona
    {
        public string Nombre { get; set; }

        public string correr()
        {
            return "Informatico corre";
        }
    }
}