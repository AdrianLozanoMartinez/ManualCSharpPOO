namespace Herencia
{
    class Pirata : Persona //Sale error porque hay que poner un constructor del nombre que estaba en el constructor del padre, porque hereda lo que esté en el constructor. base(nombre) 
    {                      //Si pulsamos encima clic y luego pulsamos Ctrl + . elegimos 1º opción y se pone solo
        
        private string apodo;

        //public string Apodo { get => apodo; set => apodo = value; } //Se comenta porque no se va a usar

        public Pirata(string nombre, string apodo) : base(nombre) //Hereda nombre del constructor padre
        {
            this.apodo = apodo;
        }


        public override void Hablar(string texto)
        {
            Console.WriteLine($"{apodo}: Arrr! {texto}"); ; //-> Usando el del propio hijo (pirata) y usando el apodo
            base.Hablar($"Arr! {texto}"); //-> Llamando al padre y usando el nombre
        }
    }
}
