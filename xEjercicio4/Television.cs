namespace xEjercicio4
{
    class Television : Electrodomestico
    {
        //Atributos
        private double _resolucion;
        private bool _tdt;

        //Constantes
        public const double RESOLUCION = 20;
        public const bool TDT = false;

        //Propiedades
        public double Resolucion { get => _resolucion; }
        public bool Tdt { get => _tdt; }

        //Constructores
        //public Television(double precio, Coolor color, CoonsumoEnergetico consumoEnergetico, double peso, double resolucion, bool tdt) : base (precio, color, consumoEnergetico, peso) //base(mismo orden que está en el constructor)
        public Television(double precio, string color, char consumoEnergetico, double peso, double resolucion, bool tdt) : base (precio, color, consumoEnergetico, peso) //base(mismo orden que está en el constructor)
        {
            _resolucion = resolucion;
            _tdt = tdt;
            precio = base.PrecioFinal(precio, peso);
        }
        public Television(double precio, double peso) : this (precio, COLOR, CONSUMOENERGETICO, peso, RESOLUCION, TDT) { }
        public Television() : this (PRECIOBASE, PESO){ }

        //Métodos
        public override double PrecioFinal(double precioEntrado, double pesoEntrado)
        {
            double precio = 0;

            if (_resolucion > 40)
            {
                precioEntrado += (precioEntrado*30)/100;
            }
            if (_tdt == true)
            {
                precioEntrado += 50;
            }

            precio = base.PrecioFinal(precioEntrado, pesoEntrado);
            return precio;
        }

        public override string ToString()
        {
            return "Televisión: ";
        }
    }
}
