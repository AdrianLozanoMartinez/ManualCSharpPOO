namespace Resumen_Interfaces
{
                  //1ºClaseHererada,2º Interfaces
    class ClassHija : ClassPadre, IInterfaz
    {

        public override void MetodoSinEnviar() //Hererado del Padre
        {
            Console.WriteLine("Envío de texto desde Clase Hija con método de la clase Padre");
        }
        public void MetodoInterfaz() //Hererado de la Interfaz
        {
            Console.WriteLine("Envío de texto desde Clase Hija con método de la interfaz hererada");
        }
    }
}
