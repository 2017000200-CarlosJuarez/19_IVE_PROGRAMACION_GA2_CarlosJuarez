internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Impresoras");

        int c1, o;
        double p = 650, i = 0.12;
        double a, b, c2 = 0, d, e;

        Console.WriteLine("Ingrese la cantidad de impresoras que desea comprar");
        c1 = Convert.ToInt32(Console.ReadLine());

        a = p + (p * i);

        Console.WriteLine("1 - efectivo = 10%");
        Console.WriteLine("2 - tarjeta = 5%");
        Console.WriteLine("3 - Vale de regalo = 15%");
        Console.WriteLine("Elija el numero segun su forma de pago");
        o = Convert.ToInt32(Console.ReadLine());

        switch(o) 
        {
            case 1: c2 = 0.10;
                break;
            case 2: c2 = 0.05;
                break;
            case 3: c2 = 0.15;
                break;
        }

        b = a * c1;
        d = b * c2;
        e = b - d;

        Console.WriteLine("Su cantidad es: "+c1);
        Console.WriteLine("Su precio con iva es: Q"+a);
        Console.WriteLine("Su total sin descuento es: "+b);
        Console.WriteLine("Su descuento es: Q"+d);
        Console.WriteLine("Su total a pagar es: "+e);



    }
}