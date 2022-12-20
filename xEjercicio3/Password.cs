namespace xEjercicio3
{

    class Password
    {
        const int LENGTH = 8;
        const string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwyxz0123456789";

        private int _length;
        private string _password;

        public int Length { get => _length; set => _length = value; }
        public string Passwordd { get => _password; }
        public Password(int length)
        {
            Length = length;
            _password = GenerarPassword();
        }
        public Password() : this(LENGTH)
        {
        }
        public bool EsFuerte()
        {
            bool esFuerte = false;
            int mayus = 0;
            int minus = 0;
            int num = 0;

            for (int i = 0; i < _password.Length; i++)
            {
                if (char.IsUpper(_password[i]))
                {
                    mayus++;
                }
                else if (char.IsLower(_password[i]))
                {
                    minus++;
                }
                else if (char.IsNumber(_password[i]))
                {
                    num++;
                }
            }
            if (mayus > 2 && minus > 1 && num > 5)
            {
                esFuerte = true;
            }
            return esFuerte;
        }


        public string GenerarPassword()
        {
            string contrasena = "";

            char[] caracteres = new char[_length];
            Random random = new Random();

            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = LETTERS[random.Next(LETTERS.Length)];
            }

            contrasena = new string(caracteres);
            return contrasena;
        }
    }
}
