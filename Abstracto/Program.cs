//Abstracta mezcla entre una clase normal y una interfaz, pero solo se puede poner una hererada, las interfaces pueden ser más
//Cuando lo hacen todos los animales se usa class abstracta, si lo hace algunos se usan interfaz
//Override en los abstracto
//NO SE PUEDE CREAR INSTANCIA DE UNA ABSTRACTA, SE DEBE COGER DE LAS HIJAS
namespace Abstracto
{
    class Program
    {
        static void Main()
        {
            Circulo circulo = new Circulo(10);
            Console.WriteLine($"Área del círculo: {circulo.GetArea()}");
            Console.WriteLine($"Perímetro del círculo: {circulo.GetPerimetro()}");
            Console.WriteLine();

            Cuadrado cuadrado = new Cuadrado(10);
            Console.WriteLine($"Área del cuadrado: {cuadrado.GetArea()}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.GetPerimetro()}");
            Console.WriteLine();


            Rectangulo rectangulo = new Rectangulo(10, 5);
            Console.WriteLine($"Área del rectángulo: {rectangulo.GetArea()}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.GetPerimetro()}");
            Console.WriteLine();


            Triangulo triangulo = new Triangulo(10, 5, 10, 20);
            Console.WriteLine($"Área del triángulo: {triangulo.GetArea()}");
            Console.WriteLine($"Perímetro del triángulo: {triangulo.GetPerimetro()}");
            Console.WriteLine();

        }
    }
}
