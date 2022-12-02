namespace Interfaz
{
    class Pajaro : Animal, ITerrestre, IVolador
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

        //No se pone aquí porque ya se ha heredado de Animal

    }
}
