internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("entradas");
        int o, c;
        double p, t;

        Console.WriteLine("1 - calco Q300");
        Console.WriteLine("2 - tribuna Q100 o Q150");
        Console.WriteLine("3 - preferencia Q50 o Q75");
        Console.WriteLine("4 - generales Q30 o Q50");
        Console.WriteLine("Elija el numero segun su sector");
        o = Convert.ToInt32(Console.ReadLine());

        switch (o) 
        {
            case 1: p = 300;
                break;
            case 2: p = 100;
                break;
            case 3: p = 50;
                break;
            case 4: p = 30;
                break;
        }
        Console.WriteLine("Cantidad de entradas queridas");
        c = Convert.ToInt32(Console.ReadLine());

        t = p * c;
        Console.WriteLine("El total es:"+t);
    }
}
