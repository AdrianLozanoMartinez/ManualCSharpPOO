namespace Resumen
{
    //Instanciar una clase, creando un OBJETO DE LA PLANTILLA de la CLASE
    //Define CONCRETAMENTE como son las personas... ->  Cristina López, de 37 años 

    //NombreClase nombre = new NombreClase(); 
    class Program
    {
        static void Main()
        {
/////////////////////////////////////////////////////////ENCAPSULACIÓN///////////////////////////////////////////////////
    
            //Instancia
            NombreClass nombreClass1 = new NombreClass();
            Console.WriteLine($"Constructor por defecto: {nombreClass1.Nombre}"); //No aparece nombre porque en el constructor y la instancia está vacío 

            NombreClass nombreClass2 = new NombreClass("Adri");
            Console.WriteLine($"Constructor con más parámetros: {nombreClass2.Nombre}\n");

            nombreClass1.NombreMetodo();
            nombreClass2.NombreMetodo();


/////////////////////////////////////////////////////////ABSTRACCIÓN///////////////////////////////////////////////////
           




        }
    }
}