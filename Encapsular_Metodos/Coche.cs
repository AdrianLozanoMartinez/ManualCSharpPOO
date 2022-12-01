namespace Encapsular_Metodos
{
    class Coche
    {
        //Enumerado
        public enum TipoMotor { Diesel, Gasolina, Hibrido };

        //Constante
        const int EDADMAXIMA = 20;

        //Atributo
        private string modelo;
        private string marca;
        private int edad;
        private int puertas;
        private double consumo;
        private TipoMotor _tipoMotor;

        //Propiedades -Depende si queremos leer y transformar
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Puertas { get => puertas; set => puertas = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        public bool Eschatarra { get => edad > EDADMAXIMA; }
        public TipoMotor TiposMotor { get => _tipoMotor; } //Leerlo fuera y no se pone set porque nosotros no podemos cambiar el motor

        //Constructores
        public Coche(string modelo, string marca, int edad, int puertas, double consumo, TipoMotor tipoMotor)
        {
            //OPCIÓN PEOR
            //variable_atributo = variable_constructor
            //this.modelo = modelo;
            //this.marca = marca;
            //this.edad = edad;
            //this.puertas = puertas;
            //this.consumo = consumo;

            //OPCIÓN MEJOR
            //variable_propiedades = variable_constructor
            Modelo = modelo;
            Marca = marca;
            Edad = edad;
            Puertas = puertas;
            Consumo = consumo;
            //atributo
            _tipoMotor = tipoMotor;
        }


        //Métodos
        public void Arrancar()
        {
            switch(_tipoMotor)
            {
                case TipoMotor.Gasolina:
                    Console.WriteLine("Bruuu");
                    break;
                case TipoMotor.Diesel:
                    Console.WriteLine("Fiiishh");
                    break;
                case TipoMotor.Hibrido:
                    Console.WriteLine("Shiii");
                    break;
            }
        }

        public void PasarTiempo()
        {
            Edad++;  //Se puede ahorrar si metemos console en el método
            //Console.WriteLine(Edad++); 
        }

        //Mostrar todos los datos
        public void MostrarDatos()
        {
            Console.WriteLine("Modelo " + Modelo);
            Console.WriteLine("Marca " + Marca);
            Console.WriteLine("Edad " + Edad);
            Console.WriteLine("Puertas " + Puertas);
            Console.WriteLine("Consumo " + Consumo);
            Console.WriteLine("_tipoMotor " + _tipoMotor);
        }
    }
}
