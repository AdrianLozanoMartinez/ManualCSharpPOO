namespace Resumen_Casting
{
    internal class Program
    {
        static void Main()
        {
            //as -> Conversión entre compatibles o null si no es posible en lugar de generar una excepción


            //object obj = "hola";

            //Excepción, Persona no es un string
            //Persona persona = (persona)obj;

            //No Excepción, AS. Al no ser un string Persona dará null
            //Persona persona = obj as Persona;





            //is -> Comprueba si el resultado es compatible con el tipo


            //Persona persona = new Persona();

            //False -> Persona no hereda de int
            //bool result = persona is int;

            //True -> Persona hereda de object
            //bool result = persona is object;




            //Ejemplo
           /* Animal[] animales = new Animal[] { new Gato(), new Perro() };


            foreach (Animal animal in animales)
            {
                animal.Hablar();

                if (animal is Perro)
                {
                    Perro perro = animal as Perro; //No provoca excepción y da nulo, pero está controlado con if
                    //Perro perro = (Perro)animal; //Provoca excepción pero se controla con if
                    perro.Buscar();
                }

                Console.WriteLine(animal);*/
            }
    }
}