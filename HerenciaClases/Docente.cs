public class Docente : Empleado
{
    public string Asignatura { get; set; }

    public Docente(string nombre, string apellido, string identificacion, string puesto, string asignatura)
        : base(nombre, apellido, identificacion, puesto)
    {
        Asignatura = asignatura;
    }
}
