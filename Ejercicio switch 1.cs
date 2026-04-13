internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("numeros de la semana");
        Console.WriteLine("escriba un numero del 1 al 7");
        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("lunes");
                break;
            case 2:
                Console.WriteLine("martes");
                break;
            case 3:
                Console.WriteLine("miercoles");
                break;
            case 4:
                Console.WriteLine("jueves");
                break;
            case 5:
                Console.WriteLine("viernes");
                break;
            case 6:
                Console.WriteLine("sabado");
                break;
            case 7:
                Console.WriteLine("domingo");
                break;
            default:
                Console.WriteLine("numero no valido");
                break;
        }
    }
}