public class ExAlumno : MiembroDeLaComunidad
{
    public int AñoGraduacion { get; set; }

    public ExAlumno(string nombre, string apellido, string identificacion, int añoGraduacion)
        : base(nombre, apellido, identificacion)
    {
        AñoGraduacion = añoGraduacion;
    }
}
