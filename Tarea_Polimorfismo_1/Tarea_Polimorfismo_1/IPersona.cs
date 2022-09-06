namespace Tarea_Polimorfismo_1
{
    public interface IPersona
    {
        string apellidos { get; set; }
        string documento { get; set; }
        string nombres { get; set; }
        string tipo { get; set; }

        //public string generarCodigo();
        //public string calcularSueldo();
    }
}