namespace Polimorfismo
{
    class Gato : Animal
    {
        public override void Hablar()
        {
            Console.WriteLine("Miau");
        }

        public override string ToString() //Sobreescribimos la función ToString() predeterminada del sistema, sino se sobreescribe te devuelve polimorfismo.gato
        {
            string gato = "Soy un gato"; 
            return gato;
        }
    }
}
