namespace Abstracto
{
    class Rectangulo : Figura
    {
        private double @base;
        private double altura;

        public Rectangulo(double @base, double altura)
        {
            this.@base = @base;
            this.altura = altura;
        }

        public override double GetArea()
        {
            return @base * altura;
        }

        public override double GetPerimetro()
        {
            return @base * 2 + altura * 2;
        }
    }
}
