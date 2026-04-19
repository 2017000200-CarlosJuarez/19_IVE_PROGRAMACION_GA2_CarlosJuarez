internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora");
        int n1, n2, o;
        Console.WriteLine("Ingrese su primer numero");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese su segundo numero");
        n2 = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("1=Suma");
        Console.WriteLine("2=resta");
        Console.WriteLine("3=multiplicacion");
        Console.WriteLine("4=division");

        Console.WriteLine("Escriba un numero del 1 al 4");
        o = Convert.ToInt32(Console.ReadLine());

        switch(o)
        {
            case 1: Console.WriteLine(n1 + n2);
                break;
            case 2: Console.WriteLine(n1 - n2);
                break;
            case 3: Console.WriteLine(n1 * n2);
                break;
            case 4: Console.WriteLine(n1 / n2);
                break;
        }
    }
}