public class Administrativo : Empleado
{
    public string Departamento { get; set; }

    public Administrativo(string nombre, string apellido, string identificacion, string puesto, string departamento)
        : base(nombre, apellido, identificacion, puesto)
    {
        Departamento = departamento;
    }
}
