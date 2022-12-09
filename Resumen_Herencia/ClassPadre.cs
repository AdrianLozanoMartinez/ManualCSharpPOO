namespace Resumen_Herencia
{
    class ClassPadre
    {
        private string _nombrePadre;

        public string NombrePadre { get => _nombrePadre; set => _nombrePadre = value; }

        public ClassPadre(string nombre)
        {
            NombrePadre = nombre;
        }

        public string MetodoEnviando()  //Se define en esta clase Padre y necesita Console.WriteLine en Program para visualizar
        {
            return "Envío de texto desde Clase Padre";
        }

        public void MetodoPadre(string texto) //No se puede sobreescribir
        {
            Console.WriteLine($"{NombrePadre}: {texto}");
        }

        //VIRTUAL -> OVERRIDE
        public virtual void MetodoPadreVirtual(string texto) //Se puede SOBREESCRIBIR
        {
            Console.WriteLine($"{NombrePadre}: {texto}");
        }
    }
}
