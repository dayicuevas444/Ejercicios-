using System;

class Program
{
    static void Main()
    {
        string continuar = "Si";

        Console.WriteLine("COLEGIO DIOS ES BUENO");
        Console.WriteLine("CALIFICACIONES DEL CUATRIMESTRE");
        Console.WriteLine("==============================================");

        while (continuar.ToUpper() == "SI")
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

            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Nombre     Apellido     Nota1  Nota2  Nota3  Nota4  Promedio  Literal");
            Console.WriteLine($"{nombre,-10} {apellido,-12} {nota1,-6} {nota2,-6} {nota3,-6} {nota4,-6} {promedio,-9:F2} {literal}");
            Console.WriteLine("==============================================");

            Console.Write("¿Desea ingresar otro estudiante? (Si/No): ");
            continuar = Console.ReadLine();

            Console.WriteLine();
        }

        Console.WriteLine("Programa terminado.");
    }
}
