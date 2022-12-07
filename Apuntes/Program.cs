namespace Apuntes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *clase estatica como una abstracta
             *estatica es para tener una clase siempre disponible como una caja que cogemos cuando lo necesitemos porque no se cierra hasta que se cierre el programa
             *no se llama atributo sino variable estatica, 
             *Se llama lo primero en el programa
             *todo estatico, no puede tener nada que no lo sea
             *debe llevar static... 
             *no se pued ecrear instancia Persona persona = new Persona;
             *no se puede heredar ni coger herencia
             *En una clase NO ESTATICA puede llevar metodos, campos...estaticos
             *se comporta igual que la constante al llamarse en el program
             *MiClaseEstatica.MiMetodoEstatico(); -> Es igual que Console.WriteLine();
             *Se puede llamar desde cualquier program, clases, al ser publica
             *Igual que las clases pero sin usar el new de Persona persona = new Persona;
             *Se carga memoria para ser compartido entre todos
             *Se usa para utilidades, como generar dni, 
             *libreria math es estaticos tambien
             *Ideal hacer uno llamado utilidades, que quite el acento, la ñ, etc
             *Clases se dividen en statica y no estatica (instancia)
             *Utilidades de string, de int...
             *
             *
             *GENERICAS
             *T indica que trabaja con int porque esta indicado abajo, porque trabaja con cualquier tipo, el que especifiquemos
             *T value -> valor por parametro del tipo indicado abajo <in>(10)
             *Para utilizar misma clase para diferentes tipos, sirve para string, int, person aetc y ahorramos de vovler a escribir todo el códgio por cada tipo
             *Se suele usar para colecciones
             *<barajaEspañola> o <barajaFrancesa)
             *generica -> baraja es igual, se reparte igual, se baraja igual...
             *return Rendimiento > otro.Rendimiento -> Rendimiento coge la primera Persona persona = new Persona; y otro.Rendimiento coge el segundo Persona persona = new Persona; que se ponga
             *se puede heredar 
             *where string: object -> G:T -> string hereda de object y no al reves sino no compila -> Metodos genericos, se utiliza cuando no se sabe los tipos y para decir que uno hereda de otro
             *object algo = 10 es un int que lo especifica con el 10
             *
             *NO ME QUEDA DEL TODO CLARO
             *G:new -> G tiene un constructor
             *G:T,new -> G Hereda de T y tiene instancia de T
             *G:T,new() where T:new() -> G Hereda de T y tiene instancia de T, donde ...
             */
        }
    }
}