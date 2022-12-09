namespace Resumen_Herencia
{
    class Program
    {
        static void Main()
        {
            //Usamos la ClassHija porque hereda del padre y usamos ambas clases a través de ella
            ClassHija hija = new ClassHija("NombrePadre", "ApodoHija"); //Mandamos (nombre,apodo) a la
                                                                        //clase hija que contiene ambos.
                                                                        //Nombre es hererado
            Console.WriteLine($"{hija.NombrePadre} y {hija.ApodoHija}");

            Console.WriteLine();

            hija.MetodoPadre("Texto"); 
            hija.MetodoHija();

            Console.WriteLine();

            Console.WriteLine(hija.MetodoEnviando()); //Procede de la clase Padre con return "Texto"

            Console.WriteLine();

            hija.MetodoPadreVirtual("Texto sin sobreescribir con Virtual");
            hija.MetodoPadreVirtual("Texto sobreescrito con Override");
        }
    }
}