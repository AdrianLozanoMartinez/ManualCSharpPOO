namespace AtributoPropiedadConstructor
{
    //Enum sin especificar public/private debe ir fuera de la class Nombre{
    enum Sexos { Hombre, Mujer, NoEspecifica }; //Se pone fuera para usarlo en otra clase
    class Persona  //Declara datos y acciones
    {
        //Enum especificando public/private debe ir dentro de la class Nombre{
        public enum Sexos2 { Hombre, Mujer, NoEspecifica };


        //ATRIBUTOS -> Se CAMBIAN solamente en métodos, propiedades o constructores

        //Atributo
        private Sexos sexo; //Del enumerado FUERA de la class Nombre{
        private Sexos2 sexo2; //Del enumerado DENTRO de la class Nombre{
        private string dni;
        private string name;
        private int age;

        //Atributo - se recomienda _ para especificar que es PRIVADO
        private Sexos _sexo;
        private Sexos2 _sexo2;
        private string _dni;
        private string _name;
        private int _age;

        //Propiedad -> Acceder a los valores del atributo privados
        public Sexos Sexo { get => sexo; set => sexo = value; }
        public Sexos2 Sexo2 { get => sexo2; set => sexo2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public int Age
        {
            get => age;
            set
            {
                age = value;
            }
        }
        public bool IsAdult { get => age >= 18; }  //Propiedad boolean del atributo age


        //Propiedad -> Acceder a los valores del atributo _privados
        public Sexos Sexo1 { get => _sexo; set => _sexo = value; }
        public Sexos2 Sexo22 { get => _sexo2; set => _sexo2 = value; }
        public string Dni2 { get => _dni; set => _dni = value; }
        public string Name2 { get => _name; set => _name = value; }
        public int Age2
        {
            get => _age;
            set
            {
                _age = value;
            }
        }
        public bool IsAdult2 { get => _age >= 18; }



        //CONSTRUCTORES -> MAS PARÁMETROS ARRIBA y MENOS ABAJO
        //Se usa PROPIEDAD -> Si se va a llamar en otra clase
        //Se usa PROPIEDAD o ATRIBUTO -> Si no se va a llamar en otra clase

        //Constructor -> Por defecto con más parámetros 
        public Persona(string dni, string name, int age, Sexos2 sexo) //Si no queremos declarar algo no inicializamos aquí
        {
            //NO ACONSEJABLE. Cogemos ATRIBUTOS = Parámetros del constructor. Se usa THIS para llamar a otro atributo dentro de la clase
            this.dni = dni;
            this.name = name;
            this.age = age;
            this.sexo2 = sexo;

            //NO ACONSEJABLE. Cogemos ATRIBUTOS = Parámetros del constructor  
            _dni = dni;
            _name = name;
            _age = age;
            _sexo2 = sexo;

            //SI SE ACONSEJA. Cogemos PROPIEDADES = Parámetros del constructor 
            Dni = dni;
            Name = name;
            Age = age;
            Sexo2 = sexo;
        }

        //Constructor -> Por defecto con menos parámetros
        public Persona(string name, int age, Sexos2 sexo) : this("-", name, age, sexo)
        {                                                 //this -> Coge y envía al constructor por defecto, como dni - y la edad /=2
            Age /= 2;
        }

        //Constructor -> Por defecto
        public Persona()  //Modificando dni y nombre
        {
            dni = "-";
            name = "Tu nombre";
        }
    }
}