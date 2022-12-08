namespace Resumen
{
    //PLANTILLA de datos más que lógicos.Persona, Animal, Figura...
    //Define GENERALMENTE como son las personas...

 /////////////////////////////////////////////////////////ENCAPSULACIÓN///////////////////////////////////////////////////
    class NombreClass //o public class NombreClass
    {
        //Atributos
        private string _nombre; //Guarda datos

        //Propiedades
        public string Nombre { get => _nombre; set => _nombre = value; } //Manipula datos

        //Constructores
        public NombreClass(string nombre) //Con más parámetros arriba
        {
            //Propiedad = VariableConstructor
            Nombre = nombre;
        }

        public NombreClass() : this("Andrés") //Por defecto, con menos parámetros abajo
        {                                     //Puede estar string.Empty o vacío o "relleno"
                             //this -> Cogemos el constructor de arriba más próximo
                                  //"Andrés" -> Mandamos al constructor de arriba la cadena "Andrés" o  string.Empty o vacío

            //Lo quitamos porque se repite arriba
            //Nombre = string.Empty; //Puede o no inicializar atributos, en este caso lo inicializamos a vacío, otra forma es "". En número es 0 y en boolean es false
        }

        public void NombreMetodo()
        {
            Console.WriteLine($"{Nombre} está en el Método");
        }


/////////////////////////////////////////////////////////ABSTRACCIÓN///////////////////////////////////////////////////





    }
}
