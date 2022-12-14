namespace Resumen_Generica
{
    class Program
    {
        /*
         * Utiliza misma clase para diferentes tipos (string, int, persona, etc) y ahorramos de volver a escribir todo el código por cada tipo
            *T indica que trabaja con int porque esta indicado abajo, porque trabaja con cualquier tipo, el que especifiquemos
            *T value -> valor por parametro del tipo indicado abajo <in>(10)
             
            *Se suele usar para colecciones
            *<barajaEspañola> o <barajaFrancesa)
            *generica -> baraja es igual, se reparte igual, se baraja igual...
            *return Rendimiento > otro.Rendimiento -> Rendimiento coge la primera Persona persona = new Persona; y otro.Rendimiento coge el segundo Persona persona = new Persona; que se ponga
            *se puede heredar 
            *where string: object -> G:T -> string hereda de object y no al reves sino no compila -> Metodos genericos, se utiliza cuando no se sabe los tipos y para decir que uno hereda de otro
            *object algo = 10 es un int que lo especifica con el 10
             
            *NO ME QUEDA DEL TODO CLARO
            *G:new -> G tiene un constructor
            *G:T,new -> G Hereda de T y tiene instancia de T
            *G:T,new() where T:new() -> G Hereda de T y tiene instancia de T, donde ...
        */
        static void Main()
        {
            ClaseIndividual<int> clasePadre = new ClaseIndividual<int>(10);

            clasePadre.MetodoGenerico(5); //Pasamos el valor en entero de 5 al método del padre


            /*object algo = 18;
            bool esIgual = ClaseHija.EsIGual(algo.GetType "Otra cosa");

            Console.WriteLine(esIgual); //Da false*/



            ClaseHija clasehija = new ClaseHija() { NombrePropiedad = 30 }; //Mandamos valor a la propiedad
            ClaseHija clasehija2 = new ClaseHija() { NombrePropiedad = 40 };

            Console.WriteLine($"¿clasehija es mayor que la clasehija2?: {clasehija.MetodoHija(clasehija2)}"); //False


        }
    }
}