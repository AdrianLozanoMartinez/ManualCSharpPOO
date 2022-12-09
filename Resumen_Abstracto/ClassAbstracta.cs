namespace Resumen
{
    /////////////////////////////////////////////////////////ABSTRACCIÓN///////////////////////////////////////////////////
    //El término persona o ser vivo podría ser abstracto.
    //Otras clases heredan sus métodos ya que...cada ser vivo comen, hablan... diferente
    //Puede tener métodos no abstracto. Ej: método morir -> Ya que todas las células están muertas

    //abstract
    abstract class ClassAbstracta  //Cuando heredan deben poner :Class2 en clase hererada -> ClassHererada:Class2
    {
        //Método abstracto
        public abstract void Hablar(); 

        //Método normal
        public void MetodoNoAbstracto()
        {
            Console.WriteLine("No soy abstracto");
        }
    }
}
