namespace Estatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
             */
        }
    }
}