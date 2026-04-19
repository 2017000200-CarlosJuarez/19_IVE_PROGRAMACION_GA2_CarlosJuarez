internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("caracter");

        Console.WriteLine("Ingrese su caracter");
        char a = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (a) 
        {
            case 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U': Console.WriteLine("Es una vocal");
                break;
            case '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9': Console.WriteLine("Es un numero");
                break;
        }
    }
}
