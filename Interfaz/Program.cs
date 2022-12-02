namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Pajaro gorrion = new Pajaro();
            gorrion.Hablar(); //No se puede meter en console porque no devuelve nada, es void, para ello hay que devolver algo como en muerto dentro de Animal por eso le he puesto string tanto en abstracto como en Animal 
            gorrion.Andar();
            gorrion.Volar();
            Console.WriteLine($"El pájaro: {gorrion.Muere()}");

            Pajaro[] arrayPajaro = new Pajaro[10]; //Creamos array de pájaro
            //Animal[] arrayPajaro = new Animal[10]; //Puede ser animal porque pájaro es un animal
            //IVolador[] arrayPajaro = new IVolador[10]; //Para solo dejar que vuele

            for (int i = 0; i <= arrayPajaro.Length - 1; i++) //Meter pájaros en el array
            {
                Pajaro pajaro = new Pajaro(); //Creamos por cada vuelta de for un animal
                arrayPajaro[i] = pajaro;
            }
            foreach (Pajaro pajarito in arrayPajaro)
            {
                pajarito.Hablar();
                Console.WriteLine(pajarito.Muere()); 
            }
            gorrion.Saltar();

        }
    }
}