class Program
{
    static void Main(string[] args)
    {
        var asignatura = new Asignatura();

        try
        {
            Console.WriteLine("BIENVENIDOS A EXAMEN I - PROGRAMACIÓN II");

            Console.Write("\nIngrese el nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Ingrese el número de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese el correo electrónico: ");
            asignatura.Email = Console.ReadLine();

            Console.Write("Ingrese el nombre de la clase: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el horario de la clase: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Ingrese el nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.Write("\nIngrese la nota del primer parcial: ");
            asignatura.N1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del segundo parcial: ");
            asignatura.N2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del tercer parcial: ");
            asignatura.N3 = int.Parse(Console.ReadLine());

            asignatura.Imprimir();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}