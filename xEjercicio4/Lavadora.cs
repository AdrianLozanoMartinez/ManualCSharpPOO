namespace xEjercicio4
{
    class Lavadora : Electrodomestico
    {
        //Atributo
        private double _carga;

        private const double CARGA = 5;

        //Propiedad
        public double Carga { get => _carga; }

        //Constructores
        //public Lavadora(double precio, Coolor color, CoonsumoEnergetico consumoEnergetico, double carga) : base(precio, color, consumoEnergetico, carga) 
        public Lavadora(double precio, string color, char consumoEnergetico, double carga) : base(precio, color, consumoEnergetico, carga) 
        {
            _carga = carga;
            precio = base.PrecioFinal(precio, _carga);  
        }
        public Lavadora(double precio, double peso) : this (precio, COLOR, CONSUMOENERGETICO, CARGA) { }
        public Lavadora() : this(PRECIOBASE,PESO) { }

        //Métodos
        public override double PrecioFinal(double precioEntrado, double _carga) 
        {
            double precio = 0;

            if(_carga > 30)
            {
                precioEntrado += 50;
            }
            precio = base.PrecioFinal(precioEntrado, _carga);

            return precio;
        }

        public override string ToString()
        {
            return "Lavadora: ";
        }
    }
}
