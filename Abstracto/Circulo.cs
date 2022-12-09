namespace Abstracto
{
    class Circulo : Figura  //Figura abstracta
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override double GetArea()  //Se utiliza los métodos heredados del abstracto Figuras
        {
            return 2 * Math.PI * radio;
        }

        public override double GetPerimetro()  //Se utiliza los métodos heredados del abstracto Figuras
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
