namespace Ejercicio1
{
    class Program
    {
        static void Main()
        {
            Cuenta titular = new Cuenta("Adri");
            Cuenta cantidad = new Cuenta("Adri", 1000);

            Console.WriteLine("Titular");
            Console.WriteLine($"Cantidad inicial");
            Console.WriteLine(titular);
            titular.Ingresar(200);
            Console.WriteLine($"Cantidad después de ingresar");
            Console.WriteLine(titular);
            titular.Retirar(100);
            Console.WriteLine($"Cantidad después de retirar");
            Console.WriteLine(titular);

            Console.WriteLine();

            Console.WriteLine("Cantidad");
            Console.WriteLine($"Cantidad inicial");
            Console.WriteLine(cantidad);
            cantidad.Ingresar(200);
            Console.WriteLine($"Cantidad después de ingresar");
            Console.WriteLine(cantidad);
            cantidad.Retirar(100);
            Console.WriteLine($"Cantidad después de retirar");
            Console.WriteLine(cantidad);
        }
    }
}