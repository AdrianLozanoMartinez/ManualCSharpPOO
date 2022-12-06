namespace Ejercicio1
{
    //default -> int n = default -> Da valor por defecto, en int da 0, string da null, en clase da null
    //Se usa sino se sabe el valor por defecto, mejor poner el valor por defecto, en atributo se pone el valor por defecto, default se suele usar en this constructor y metodos
    class Program
    {
        static void Main(string[] args)
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