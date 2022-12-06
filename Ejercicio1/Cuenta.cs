namespace Ejercicio1
{
    class Cuenta
    {
        private string _titular;
        private double _cantidad;

        public string Titular { get => _titular; set => _titular = value; }
        public double Cantidad { get => _cantidad; set => _cantidad = value; }

        public Cuenta(string titular, int cantidad)
        {
            _titular = titular;
            _cantidad = cantidad;
        }
        public Cuenta(string titular) : this(titular, 0) //Obligatorio, cogemos del que tiene más pero como no tenemos datos en cuenta ponemos valor por defecto 0
        {                                                //this coge el cosntructor de arriba
        }
        public override string ToString()
        {
            return $"Su nombre es {Titular} y su cuenta está a {Cantidad}";
        }
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                Cantidad += cantidad;
            }
     
        }
        public void Retirar(double cantidad)
        {
            Cantidad -= cantidad;

            if (Cantidad < 0)
            {
                Cantidad = 0;
            }
        }
    }
}
