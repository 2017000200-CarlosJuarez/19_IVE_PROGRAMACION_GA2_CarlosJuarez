internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Letra segun su calificacion");
        Console.WriteLine("Ingrese su letra de calificacion");
        char letra = char.Parse(Console.ReadLine().ToUpper());

        switch (letra)
        {
            case 'A':
                Console.WriteLine("Excelente");
                break;
            case 'B':
                Console.WriteLine("bueno");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            case 'D':
                Console.WriteLine("deficiente");
                break;
            case 'F':
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Numero no valido");
                break;
        }
    }
}