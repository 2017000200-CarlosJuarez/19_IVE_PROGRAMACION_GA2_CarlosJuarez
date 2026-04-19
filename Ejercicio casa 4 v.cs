internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("entradas");
        int a;
        double v, b = 0;

        Console.WriteLine("Ingrese el valor que desee calcular");
        v = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1 - metros");
        Console.WriteLine("2 - pies");
        Console.WriteLine("3 - centimetros");
        Console.WriteLine("4 - pilgadas");

        Console.WriteLine("Elija el numero segun su medida");
        a = int.Parse(Console.ReadLine());

        switch (a)
        {
            case 1:
                b = v;
                break;
            case 2:
                b = v * 3.28;
                break;
            case 3:
                b = v * 100;
                break;
            case 4:
                b = v * 39.37;
                break;
        }

        Console.WriteLine("EL RESULTADO ES: " + b);
    }
}