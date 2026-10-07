using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        string continuar = "S";

        while (continuar.ToUpper() == "S")
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            string literal;

            if (promedio >= 90)
            {
                literal = "A";
            }
            else if (promedio >= 80)
            {
                literal = "B";
            }
            else if (promedio >= 70)
            {
                literal = "C";
            }
            else
            {
                literal = "D";
            }

            estudiantes.Add(new Estudiante
            {
                Nombre = nombre,
                Apellido = apellido,
                Nota1 = nota1,
                Nota2 = nota2,
                Nota3 = nota3,
                Nota4 = nota4,
                Promedio = promedio,
                Literal = literal
            });

            Console.Write("¿Desea ingresar otro estudiante? (S/N): ");
            continuar = Console.ReadLine();

            Console.WriteLine();
        }

        // Ordenar por apellido
        estudiantes = estudiantes.OrderBy(e => e.Apellido).ToList();

        // Mostrar reporte
        Console.WriteLine();
        Console.WriteLine("COLEGIO DIOS ES BUENO");
        Console.WriteLine("CALIFICACIONES DEL CUATRIMESTRE");
        Console.WriteLine("==========================================================================");
        Console.WriteLine("Nombre       Apellido       Nota1  Nota2  Nota3  Nota4  Promedio  Literal");
        Console.WriteLine("==========================================================================");

        foreach (Estudiante estudiante in estudiantes)
        {
            Console.WriteLine(
                $"{estudiante.Nombre,-12}" +
                $"{estudiante.Apellido,-15}" +
                $"{estudiante.Nota1,-7}" +
                $"{estudiante.Nota2,-7}" +
                $"{estudiante.Nota3,-7}" +
                $"{estudiante.Nota4,-7}" +
                $"{estudiante.Promedio,-10:F2}" +
                $"{estudiante.Literal}"
            );
        }

        // Contar estudiantes por literal
        int cantidadA = estudiantes.Count(e => e.Literal == "A");
        int cantidadB = estudiantes.Count(e => e.Literal == "B");
        int cantidadC = estudiantes.Count(e => e.Literal == "C");
        int cantidadD = estudiantes.Count(e => e.Literal == "D");

        Console.WriteLine();
        Console.WriteLine("TOTALES");
        Console.WriteLine("=================================");
        Console.WriteLine("Estudiantes en A: " + cantidadA);
        Console.WriteLine("Estudiantes en B: " + cantidadB);
        Console.WriteLine("Estudiantes en C: " + cantidadC);
        Console.WriteLine("Estudiantes reprobados: " + cantidadD);
    }
}

class Estudiante
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
    public double Nota4 { get; set; }

    public double Promedio { get; set; }

    public string Literal { get; set; }
}
