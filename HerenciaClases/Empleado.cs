public class Empleado : MiembroDeLaComunidad
{
    public string Puesto { get; set; }

    public Empleado(string nombre, string apellido, string identificacion, string puesto)
        : base(nombre, apellido, identificacion)
    {
        Puesto = puesto;
    }
}
