namespace Polimorfismo
{
    class Perro : Animal, IBuscador
    {
        public override void Hablar()
        {
            Console.WriteLine("Guau");
        }

        public void Buscar()
        {
            Console.WriteLine("Busco");
        }

        public override string ToString()  //Sobreescribimos la función ToString() predeterminada del sistema, sino se sobreescribe te devuelve polimorfismo.gato
        {
            return "Soy un perro";
        }
    }
}
