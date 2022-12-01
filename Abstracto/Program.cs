using System.Drawing;

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
            Console.WriteLine($"Área del rectángulo: {circulo.GetArea()}");
            Console.WriteLine($"Perímetro del rectángulo: {circulo.GetPerimetro()}");
            Console.WriteLine();


            Triangulo triangulo = new Triangulo(10, 5, 10, 20);
            Console.WriteLine($"Área del triángulo: {cuadrado.GetArea()}");
            Console.WriteLine($"Perímetro del triángulo: {cuadrado.GetPerimetro()}");
            Console.WriteLine();

        }
    }
}
