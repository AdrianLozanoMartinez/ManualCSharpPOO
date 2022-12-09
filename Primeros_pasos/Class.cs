namespace Resumen
{
    //PLANTILLA de datos más que lógicos.Persona, Animal, Figura...
    //Define GENERALMENTE como son las personas...

 /////////////////////////////////////////////////////////ENCAPSULACIÓN///////////////////////////////////////////////////
    class Class //o public class NombreClass
    {
        //Atributos
        private string _nombre; //Guarda datos

        //Propiedades
        public string Nombre { get => _nombre; set => _nombre = value; } //Manipula datos

        //Constructores
        public Class(string nombre) //Con más parámetros arriba
        {
            //Propiedad = VariableConstructor
            Nombre = nombre;
        }

        public Class() : this("Andrés") //Por defecto, con menos parámetros abajo
        {                                     //Puede estar string.Empty o vacío o "relleno"
                             //this -> Cogemos el constructor de arriba más próximo
                                  //"Andrés" -> Mandamos al constructor de arriba la cadena "Andrés" o  string.Empty o vacío

            //Lo quitamos porque se repite arriba
            //Nombre = string.Empty; //Puede o no inicializar atributos, en este caso lo inicializamos a vacío, otra forma es "". En número es 0 y en boolean es false
        }

        public void NombreMetodoSINParametro()
        {
            Console.WriteLine($"{Nombre} está en el Método SIN parámetro");
        }

        public void NombreMetodoCONParametro(string texto) 
        {
            Console.WriteLine($"{Nombre} está en el Método CON parámetro {texto}");
        }
    }
}
