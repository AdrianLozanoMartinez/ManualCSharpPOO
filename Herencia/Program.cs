//Hijo hereda todo del padre 
//Si queremos heredar desde un nieto debe pasar primero por el padre y luego el abuelo, no puede del tirón ni heredar de más de uno
namespace Herencia
{
    class Program
    {
        static void Main()
        {
            Persona persona = new Persona("Barbarroja");
            persona.Hablar("Venga vamos");

            Pirata pirata = new Pirata("Hizir", "Barbarroja"); 
                                     //(nombre,  apodo)
            pirata.Hablar("Hola");

            Mimo mimo = new Mimo("Paco");
            mimo.Hablar("No habla porque es un mimo");  ////Sobreescribir es que cambia el método del padre en el hijo, eje: persona come con tenedor y pirata con las manos. 
        }
    }
}