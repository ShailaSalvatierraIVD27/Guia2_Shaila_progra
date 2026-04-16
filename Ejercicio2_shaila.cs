internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos valores numericos");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n****MENU PRINCIPAL****");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("Salir");
        Console.WriteLine("Digite el valor segun sea la operación []");
        int opc = Convert.ToInt32(Console.ReadLine());

        //evaluar con swith
        string msj = "";
        double result;
        switch (opc)
        {
            case 1:
                msj = "La suma es : " + (num1 + num2);
                break;
            case 2:
                msj = "La Resta es : " + (num1 - num2);
                break;
            case 3:
                msj = "La Multiplicación es : " + (num1 * num2);
                break;
            case 4:
                msj = "La Division es : " + (num1 / num2);
                break;
            case 5:
                msj = ("Saliendo del sistema");
                break;
            default:
                msj = "Digite una opción valida!!!";
                break;
        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(msj);
    }
}