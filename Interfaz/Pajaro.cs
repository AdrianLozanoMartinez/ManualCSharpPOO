namespace Interfaz
{
    class Pajaro : Animal, ITerrestreVolador
    {
        public override void Hablar()
        {
            Console.WriteLine("Pio");
        }

        public void Andar()
        {
            Console.WriteLine("Ando");
        }

        public void Volar()
        {
            Console.WriteLine("Vuelo");
        }

        public void Saltar()
        {
            Console.WriteLine("Boiiinngg");
        }

        //No se pone aquí porque ya se ha heredado de Animal

    }
}
