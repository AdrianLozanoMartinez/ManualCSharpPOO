namespace xEjercicio3
{
    class Program
    {
        static void Main()
        {
            Ejecutable();
        }

        static void Ejecutable()
        {
            Console.WriteLine("Indica una cantidad de contraseñas: ");
            int cant = int.Parse(Console.ReadLine());
            Password[] passwords = new Password[cant];

            Console.WriteLine("Indicala longitud de las contraseñas: ");
            int length = int.Parse(Console.ReadLine());

            bool[] comoEs = new bool[passwords.Length];

            for (int i = 0; i < passwords.Length; i++)
            {
                passwords[i] = new Password(length);
                comoEs[i] = passwords[i].EsFuerte();

                Console.WriteLine($"{passwords[i].Passwordd} {comoEs[i]}");
            }
        }
    }
}