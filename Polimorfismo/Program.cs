//Vale para todas las clases e interfaz
//se pasa de una clase superior a hija con as para poder usar los metodos hijas, ya que se suele englobar en el padre y luego especificar
namespace Polimorfismo
{
    class Program
    {
        static void Main()
        {
            Animal[] animales = new Animal[] { new Gato(), new Perro() };

            foreach (Animal animal in animales)
            {
                animal.Hablar();

               if (animal is Perro)
               {
                    Perro perro = animal as Perro; //No provoca excepción y da nulo, pero está controlado con if
                    //Perro perro = (Perro)animal; //Provoca excepción pero se controla con if
                    perro.Buscar();
               }

                    Console.WriteLine(animal); //Sale: Polimorfismo.Gato y Polimorfismo.Perro. Al cambiarse en gato y perro la 
                                               //función public override string ToString() return "texto" y devuelve texto

                //Otra opción en lugar de if..
                //Perro perro = animal as Perro;
                //if(perro != null) perro.Buscar();
            }
        }

    }
}
