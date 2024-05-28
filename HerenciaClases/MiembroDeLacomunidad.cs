public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Identificacion { get; set; }

    public MiembroDeLaComunidad(string nombre, string apellido, string identificacion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Identificacion = identificacion;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} {Apellido}, ID: {Identificacion}");
    }
}
