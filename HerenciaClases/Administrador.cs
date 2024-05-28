public class Administrador : Docente
{
    public string Nivel { get; set; }

    public Administrador(string nombre, string apellido, string identificacion, string puesto, string asignatura, string nivel)
        : base(nombre, apellido, identificacion, puesto, asignatura)
    {
        Nivel = nivel;
    }
}
