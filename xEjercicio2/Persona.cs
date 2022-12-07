using System.Globalization;
using System.Text;

//Main pregunta e interactua, la clase opera para responder a las preguntas

namespace xEjercicio2
{
    //enum Sex { Hombre, Mujer } //Si se deja ahí se llama directamente como sexo y no como persona.sexo como abajo public
    class Persona
    {
        public enum Genero { Hombre, Mujer } //se llamaria persona.sexo y no directamente sexo como arriba

        private const Genero SEXO_POR_DEFECTO = Genero.Hombre;

        const string LETTERS = "trwagmyfpdxbnjzsqvhlcke";

        public const int OVERWEIGHT = 1;
        public const int IDEALWEIGHT = 0;
        public const int TOOTHIN = -1;
        //private const int POSITION = 23;

        //EN LUGAR DE DECLARAR AQUÍ SE HACE MEJOR POR CONSTRUCTOR
        /*private string _name = string.Empty;
        private int _age = 0;
        private string _dni = string.Empty;
        private double _weight = 0;
        private double _height = 0;*/

        //NO SE DECLARA AQUÍ SINO EN CONSTRUCTOR
        private string _name;
        private int _age;
        private string _dni;
        private double _weight;
        private double _height;
        private Genero sexo;



        public string Name { set => _name = value; }
        public int Age { set => _age = value; }
        public double Weight { set => _weight = value; }
        public double Height { set => _height = value; }
        public Genero Sexo { set => sexo = value; }

        public Persona(string name, int age, Genero sexo, double weight, double height) 
        {
            Name = name;
            Age = age;
            Sexo = sexo;
            Height= height;
            Weight= weight;
            _dni = GenerarDNI(); //Porque se genera el dato
        }

        public Persona(string name, int age, Genero sexo): this(name, age, sexo, 0, 0) //Algunos parámetros
        {
            //Quitamos aqui porque se repite y para ello ponemos this
            //Name = name;
            //Age = age;
            //Sexo = sexo;
          
        }

        public Persona() : this(string.Empty, 0, SEXO_POR_DEFECTO)//Por defecto
        {
            //Quitamos aqui porque se repite y para ello ponemos this
            //Name = string.Empty;
            //this._dni = GenerarDNI();
        } 

        public int CalcularIMC()
        {
            int result = IDEALWEIGHT;
            double imc = _weight / Math.Pow(_height, 2);
    

            if (imc < 20)
            {
                result = TOOTHIN;
            }
            else if (result > 25)
            {
                result = OVERWEIGHT;
            }
            return result;
        }
        public bool EsMayorDeEdad()
        {
            return _age >= 18;
        }
        public override string ToString()
        {
            //Se puede hacer $"fff\n" pero es otro modo
            StringBuilder builder = new StringBuilder(); //Igual que $"Tiene de IMC: \n

            builder.AppendLine($"Nombre: {_name}"); //Se usa atributo porque la propiedad es solo escritura sino seria propiedad
            builder.AppendLine($"Edad: {_age}");
            builder.AppendLine($"Sexo: {sexo}");
            builder.AppendLine($"DNI: {_dni}");
            builder.AppendLine($"Peso: {_weight}");
            builder.AppendLine($"Altura: {_height}");

            return builder.ToString();
        }
        private string GenerarDNI()
        {
            //1º opcion y corregir
            /*Random random = new Random();
            string result = "";
            int result2 = 0;
            string[] array = new string[POSITION];
            string letter = "";

            for (int i = 0; i > 8; i++)
            {
                result += random.Next(0, 10);
            }

            result2 = int.Parse(result);

            letter = array[result2 % 23];

            return $"DNI: {result2}{letter}";*/

            int numero = GenerarNumeroAleatorio();
            char letra = LETTERS[numero % LETTERS.Length];

            return numero.ToString() + letra;
        }

        private int GenerarNumeroAleatorio()
        {
            Random random = new Random();

            return random.Next(1, 100000000);
        }
    }
}
