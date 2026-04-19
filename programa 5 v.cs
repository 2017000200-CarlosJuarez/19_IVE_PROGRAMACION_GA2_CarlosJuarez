internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("mes");
        int m;

        Console.WriteLine("Escriba un numero del 1 al 12 segun su mes");
        m = Convert.ToInt32(Console.ReadLine());

        switch (m)
        {
            case 1:
                Console.WriteLine("enero  - 31 dias");
                break;
            case 2:
                Console.WriteLine("febrero - 28 dias");
                break;
            case 3:
                Console.WriteLine("marzo - 31 dias");
                break;
            case 4:
                Console.WriteLine("abril - 30 dias");
                break;
            case 5:
                Console.WriteLine("mayo - 31 dias");
                break;
            case 6:
                Console.WriteLine("junio - 30 dias");
                break;
            case 7:
                Console.WriteLine("julio - 31 dias");
                break;
            case 8:
                Console.WriteLine("agosto - 31 dias");
                break;
            case 9:
                Console.WriteLine("septiembre - 30 dias");
                break;
            case 10:
                Console.WriteLine("octubre - 31 dias");
                break;
            case 11:
                Console.WriteLine("noviembre - 31 dias");
                break;
            case 12:
                Console.WriteLine("disciembre - 31 dias");
                break;
        }
    }
}