namespace xEjercicio3
{

    class Password
    {
        //Atributos
        private int _longitud;
        private string _contrasena;

        //Constante
        const int LONGITUD = 8;

        //Propiedades
        public int Longitud { get => _longitud; set => _longitud = value; } //Lo creamos CREO para poder meterlo por teclado por lo que nos pide en el ejercicio
        public string Contrasena { get => _contrasena; } 

        //Constructores
        public Password(int longitud) 
        {
            GenerarPassword(longitud);  
        }
        public Password() : this(LONGITUD) { }

        //Métodos
        public bool EsFuerte(string result)
        {
            string caracteR = result.ToUpper();
            string caracter = result.ToLower();
            int contLEtter = 0;
            int contLetter = 0;
            int contNumber = 0;
            bool send = false;

      
            for (int i = 0; i < result.Length; i++)
            {
                if (Char.IsDigit(result[i]))
                {
                    contNumber++;
                }
                
                else if (caracter[i] == result[i])
                {
                    contLetter++;
                }
                else if (caracteR[i] == result[i])
                {
                    contLEtter++;
                }
            }

                //Console.WriteLine(contNumber);
                //Console.WriteLine(contLetter);
                //Console.WriteLine(contLEtter);

            if (contLEtter > 2 && contLetter > 1 && contNumber > 5)
            {
                send = true;
            }
            else
            {
                send = false;
            }

            return send;  
        }

        public string GenerarPassword(int longitud)
        {
            Random random = new Random();
            //CREO QUE Se podría hacer con expresiones regulares/(char)'A' y con minúsculas -> Código ASCII, más números
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] charCaracter = new char[longitud];
            string[] resultString = new string[longitud];
            string result = "";

            for (int i = 0; i < charCaracter.Length; i++)
            {
                charCaracter[i] = characters[random.Next(characters.Length)];
                resultString[i] += charCaracter[i];
            }

            foreach (string local in resultString)
            {
                result += local;
            }
            EsFuerte(result);

            return result;  
        }


    }
}
