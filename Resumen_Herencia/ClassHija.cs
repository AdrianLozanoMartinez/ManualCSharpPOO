namespace Resumen_Herencia
{
    class ClassHija : ClassPadre //Se herera el nombre
    {
        private string _apodoHija;

        public string ApodoHija { get => _apodoHija; set => _apodoHija = value; }

        public ClassHija(string nombrePadre, string apodoHija) : base(nombrePadre) //base(nombre) llama al padre con el
        {                                                            //nombre que estaba en su constructor
                                                                     //+ apodo que añadimos en la hija
            ApodoHija = apodoHija;
        }

        public void MetodoHija() 
        {
            Console.WriteLine($"{ApodoHija}: Texto");
        }

        //VIRTUAL -> OVERRIDE
        public override void MetodoPadreVirtual(string texto) //Se puede SOBREESCRIBIR
        {
            base.MetodoPadreVirtual($"Texto incluido desde el método hija + {texto}");
        }
    }
}
