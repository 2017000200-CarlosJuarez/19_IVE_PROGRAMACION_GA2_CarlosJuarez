internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("menu");
        int m;

        Console.WriteLine("1=hamburguesa");
        Console.WriteLine("2=pizza");
        Console.WriteLine("3=pollo frito");
        Console.WriteLine("4=ensalada");

        Console.WriteLine("Escriba un numero del 1 al 4");
        m = Convert.ToInt32(Console.ReadLine());

        switch(m)
        {
            case 1: Console.WriteLine("usted a pedido un menu de hamburguesa");
                break;
            case 2: Console.WriteLine("usted a pedido un menu de pizza");
                break;
            case 3: Console.WriteLine("usted a pedido un menu de pollo frito");
                break;
            case 4: Console.WriteLine("usted a pedido un menu de ensalada");
                break;
        }
    }
}