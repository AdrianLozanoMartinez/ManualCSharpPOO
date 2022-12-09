namespace Resumen_Interfaces
{
                
    class Program
    {
        static void Main()
        {
            ClassHija hija = new ClassHija();

            hija.MetodoSinEnviar(); //Procede de la clase Padre

            Console.WriteLine();

            hija.MetodoInterfaz(); //Procede de la interfaz
        }
    }
}