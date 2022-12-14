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
            Console.WriteLine("Introduzca la longitud de la contraseña");
            int longitud = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la cantidad de contraseñas que quieres tener");
            int cantidad = int.Parse(Console.ReadLine());

            string[] array = new string[cantidad];

            Password password = new Password();

            for (int i = 0; i < cantidad; i++)
            {
                string contrasena = password.GenerarPassword(longitud);
                bool fuerte = password.EsFuerte(contrasena);

                Console.WriteLine(contrasena + ' ' + fuerte);
            }
        }
    }
}