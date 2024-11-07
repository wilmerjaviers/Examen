public class Asignatura : Alumno, IAsignatura
{
    private int n1;
    private int n2;
    private int n3;

    public int N1
    {
        get => n1;
        set
        {
            if (value > 30)
                throw new Exception("La nota del primer parcial no puede sobrepasar del 30%");
            n1 = value;
        }
    }

    public int N2
    {
        get => n2;
        set
        {
            if (value > 30)
                throw new Exception("La nota del segundo parcial no puede sobrepasar del 30%");
            n2 = value;
        }
    }

    public int N3
    {
        get => n3;
        set
        {
            if (value > 40)
                throw new Exception("La nota del tercer parcial no puede sobrepasar del 40%");
            n3 = value;
        }
    }

    public string NombreAsignatura { get; set; }
    public string Horario { get; set; }
    public string NombreDocente { get; set; }

    public double CalcularNotaFinal()
    {
        return N1 + N2 + N3;
    }

    public double CalcularNotaFinal(int nota1, int nota2, int nota3)
    {
        return nota1 + nota2 + nota3;
    }

    public string MensajeNotaFinal(double notaFinal)
    {
        if (notaFinal >= 90 && notaFinal <= 100)
            return $"La Nota final es: {notaFinal}% - El Alumno(a) es Sobresaliente";
        else if (notaFinal >= 80 && notaFinal < 90)
            return $"La Nota final es: {notaFinal}% - El Alumno(a) es Muy Bueno";
        else if (notaFinal >= 60 && notaFinal < 80)
            return $"La Nota final es: {notaFinal}% - El Alumno(a) es Bueno";
        else
            return $"La Nota final es: {notaFinal}% - El Alumno(a) esta Reprobado";
    }

    public void Imprimir()
    {
        Console.WriteLine("\n************************************************************");
        Console.WriteLine($"El Nombre del estudiante es: {NombreAlumno}");
        Console.WriteLine($"El Número de cuenta es: {NumeroCuenta}");
        Console.WriteLine($"El Correo electrónico es: {Email}");
        Console.WriteLine($"El Nombre de la clase es: {NombreAsignatura}");
        Console.WriteLine($"El Horario es: {Horario}");
        Console.WriteLine($"El Nombre del docente es: {NombreDocente}");

        //método sin parámetros
        double notaFinal1 = CalcularNotaFinal();
        Console.WriteLine(MensajeNotaFinal(notaFinal1));

        //método con parámetros
        double notaFinal2 = CalcularNotaFinal(N1, N2, N3);
        Console.WriteLine(MensajeNotaFinal(notaFinal2));
        Console.WriteLine("\n************************************************************");
    }
}