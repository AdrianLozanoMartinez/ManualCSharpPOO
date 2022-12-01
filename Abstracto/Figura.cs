//Persona podría ser abstracto o ser vivo y otras clases que heredan cogen sus métodos abstracto como comer..etc...cada ser vivo comen diferente
//Una clase abstracta puede tener métodos no abstracto como por ejemplo método morir(ya que todas las células están muertas)
namespace Abstracto
{
    abstract class Figura  //Convertimos abstract, los demás heredan que deben hacer/poner lo que public abstract ponga aunque no lo use
    {
        public abstract double GetPerimetro();
        public abstract double GetArea();
    }
}
