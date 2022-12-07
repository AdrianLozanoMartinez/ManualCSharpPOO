namespace xEjercicio1Profe
{
    class Cuenta
    {
        private string titular;
        public double cantidad;

        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        //cuando la cuenta es opcional
        public Cuenta(string titular, double cantidad)
        {
            this.Titular = titular;
            this.Cantidad = cantidad;
        }

        public Cuenta(string titular) : this(titular, 0)
        {
            this.titular = titular;
        }
    }
}
