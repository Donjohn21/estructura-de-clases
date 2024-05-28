public class Maestro : Docente
{
    public int AñosExperiencia { get; set; }

    public Maestro(string nombre, string apellido, string identificacion, string puesto, string asignatura, int añosExperiencia)
        : base(nombre, apellido, identificacion, puesto, asignatura)
    {
        AñosExperiencia = añosExperiencia;
    }
}
