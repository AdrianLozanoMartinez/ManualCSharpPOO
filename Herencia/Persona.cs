//PADRE -> De él hereda los hijos (Mimo y Pirata)
namespace Herencia
{
    class Persona
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public Persona(string nombre)
        {
            Nombre = nombre;   //Cogemos de la propiedad el Nombre
        }

        public virtual void Hablar(string texto)  //Solo se puede sobreescribir metodo que tenga virtual. Hablar estaba en persona y se cambia en Pirata y Mimo
        {                                         //Virtual te da el permiso, se pone en el padre y override en el hijo, o virtual en un hijo y overraide en el hijo de ese hijo de arriba que sería su padre
                                                  //Dentro de Virtual se usa base.Metodo(texto se puede usar el que coge de Persona o se omite)

            Console.WriteLine($"{Nombre}: {texto}");  //Se coge de la propiedad Nombre y cogemos lo que nos da en Program -> Barbarroja
                                                      //En texto se coge lo que mandamos en Program mediante la llamada del método ->
                                                      //persona.Hablar("Venga vamos");, le mandamos Venga vamos
        }
    }
}
