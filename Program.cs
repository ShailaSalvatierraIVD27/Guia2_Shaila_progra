using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("RANGO DE ESTUDIANTES");
        Console.WriteLine("Ingrese una letra (A, B, C. D y F)");
        char letra = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            case 'a':
                Console.WriteLine("EXELENTE");
                break;
            case 'B':
                Console.WriteLine("BUENO");
                break;
            case 'C':
                Console.WriteLine("REGULAR");
                break;
            case 'D':
                Console.WriteLine("DEFICIENTE");
                break;
            case 'F':
                Console.WriteLine("REPROBADO");
                break;
            default:
                Console.WriteLine("Letra no válida");
                break;

        }
    }
}
   