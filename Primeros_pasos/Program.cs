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
            Class nombreClass1 = new Class();
            Console.WriteLine($"ENCAPSULACIÓN: Constructor por defecto de nombreClass1: {nombreClass1.Nombre}"); //No aparece nombre porque en el constructor y la instancia está vacío 

            Class nombreClass2 = new Class("Adri");
            Console.WriteLine($"ENCAPSULACIÓN: Constructor con más parámetros de nombreClass2: {nombreClass2.Nombre}\n");

            nombreClass1.NombreMetodoSINParametro();
            nombreClass2.NombreMetodoSINParametro();

            Console.WriteLine();

            nombreClass1.NombreMetodoCONParametro("-> Un Parámetro");
            nombreClass2.NombreMetodoCONParametro("-> Otro Parámetro");

            Console.WriteLine();

            nombreClass1.Nombre = "Andresita";
            Console.WriteLine($"Cambiamos el nombre de nombreClass1: {nombreClass1.Nombre}");

            nombreClass2.Nombre = "Adriana";
            Console.WriteLine($"Cambiamos el nombre de nombreClass2: {nombreClass2.Nombre}");
        }
    }  
}