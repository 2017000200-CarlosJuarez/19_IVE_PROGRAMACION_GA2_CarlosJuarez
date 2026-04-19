internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("trigonometria");
        double a,b,c,ta,co,se,o;

        Console.WriteLine("Ingrese su lado A");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese su lado B");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese su lado C");
        c = Convert.ToInt32(Console.ReadLine());

        double ta = a / b;
        double co = b / c;
        double se = a / c;

        Console.WriteLine("1 - tangente");
        ta = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2 - coseco");
        co = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("seno");
        se = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el numero de la operacion que desea realizar);
        o = Convert.ToInt32(Console.ReadLine());

        switch (o)
        {
            case 1:
                Console.WriteLine(ta);
                break;
            case 2:
                Console.WriteLine(co);
                break;
            case 3:
                Console.WriteLine(se);
                break;
        }
    }
}