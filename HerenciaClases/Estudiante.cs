public class Estudiante : MiembroDeLaComunidad
{
    public string Curso { get; set; }

    public Estudiante(string nombre, string apellido, string identificacion, string curso)
        : base(nombre, apellido, identificacion)
    {
        Curso = curso;
    }
}
