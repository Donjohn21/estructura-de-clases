using System;
//john wilbert 2022-0417
namespace HerenciaClases
{
    class Program
    {
        static void Main(string[] args)
        {
            MiembroDeLaComunidad miembro = new MiembroDeLaComunidad("Juan", "Perez", "123456");
            Empleado empleado = new Empleado("Ana", "Gomez", "789012", "Secretario");
            Estudiante estudiante = new Estudiante("Luis", "Martinez", "345678", "10° Grado");
            ExAlumno exalumno = new ExAlumno("Maria", "Lopez", "901234", 2010);
            Docente docente = new Docente("Carlos", "Fernandez", "567890", "Profesor", "Matemáticas");
            Administrativo administrativo = new Administrativo("Laura", "Diaz", "123789", "Administrativo", "Recursos Humanos");
            Administrador administrador = new Administrador("Jorge", "Hernandez", "456123", "Director", "Ciencias", "Primaria");
            Maestro maestro = new Maestro("Sara", "Mendoza", "789345", "Profesor", "Historia", 15);

            miembro.MostrarInformacion();
            empleado.MostrarInformacion();
            estudiante.MostrarInformacion();
            exalumno.MostrarInformacion();
            docente.MostrarInformacion();
            administrativo.MostrarInformacion();
            administrador.MostrarInformacion();
            maestro.MostrarInformacion();
        }
    }
}
