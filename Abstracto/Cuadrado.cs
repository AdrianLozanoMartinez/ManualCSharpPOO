using System.Drawing;

namespace Abstracto
{
    class Cuadrado : Rectangulo
    {

        public Cuadrado(double lado) : base(lado, lado)
        {                                //@base, altura -> Proviene del padre. Se puede llamar como quiera y como lo hemos declarado al lado, se puede dejar así, mientras sea el mismo tipo se guarda igu
            //No es necesario añadir nada más porque usa los métodos del cuadrado, aquí coge el valor y usa lo que hay en el rectangulo
        }

    }
}
