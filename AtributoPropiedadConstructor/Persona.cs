//Class (Clases) -> Declara datos y acciones
namespace AtributoPropiedadConstructor
{
    //Enum sin especificar public/private debe ir fuera de la class Nombre{
    enum Sexos { Hombre, Mujer, NoEspecifica }; //Se pone fuera para usarlo en otra clase
    class Persona
    {
        //Enum especificando public/private debe ir dentro de la class Nombre{
        public enum Sexos2 { Hombre, Mujer, NoEspecifica };


        //Atributo -> No cambia al menos que cambiemos manualmente. this.atributo = nombreConstructor; o atributo = nombreConstructor;  en el constructor

        //Atributo
        private Sexos sexo; //Del enumerado fuera de la class Nombre{
        private Sexos2 sexo2; //Del enumerado dentro de la class Nombre{
        private string dni;
        private string name;
        private int age;

        //Atributo - se recomienda _ para especificar que es PRIVADO
        private Sexos _sexo;
        private Sexos2 _sexo2;
        private string _dni;
        private string _name;
        private int _age;


        ////////Los valores Solo se cambia en metodos, propiedades o constructor\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\º


        //Propiedad -> Cambia al poner set. set => nombre = value. Luego Nombre = nombreConstructor en el constructor

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
        public bool IsAdult { get => age >= 18; }

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



        //CONSTRUCTORES -> Se pone los que MAS PARÁMETROS ARRIBA y los de MENOS ABAJO
        //--> Si se va a llamar en otra clase se necesita la propiedad
        //--> Si no se va a llamar en otra clase da igual si propiedad o atributo 
        //Se usa THIS para llamar a otro constructor o atributo dentro de la clase

        //Constructor -> Por defecto
        public Persona()  //Modificando dni y nombre
        {
            dni = "-";
            name = "Tu nombre";
        }

        //Constructor -> Por defecto con más parámetros 
        public Persona(string dni, string name, int age, Sexos2 sexo) //Si no queremos declarar la edad u otro, podemos no inicializar aquí
        {
            //Atributos = Parámetros del constructor -> NO se aconseja
            this.dni = dni;
            this.name = name;
            this.age = age;
            this.sexo2 = sexo;

            //_Atributos = Parámetros del constructor -> NO se aconseja
            _dni = dni;
            _name = name;
            _age = age;
            _sexo2 = sexo;

            //Propiedades = Parámetros del constructor -> SI se aconseja
            Dni = dni;
            Name = name;
            Age = age;
            Sexo2 = sexo;
        }

        //Constructor -> Por defecto con menos parámetros
        public Persona(string name, int age, Sexos2 sexo) : this("-", name, age, sexo)
        {                                                //this -> Coge y envía al constructor por defecto, como dni - y la edad /=2
            Age /= 2;
        }
    }
}
