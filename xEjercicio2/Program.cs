using System.Globalization;
//Main pregunta e interactua, la clase opera para responder a las preguntas

namespace xEjercicio2
{
    class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Introduce su nombre");
            string name = Console.ReadLine();   
            Console.WriteLine("Introduce su edad");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce su sexo");
            Persona.Genero sexo = (Persona.Genero)Enum.Parse(typeof(Persona.Genero), Console.ReadLine(), true);
            Console.WriteLine("Introduce su peso");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce su altura");
            double height = double.Parse(Console.ReadLine());

            Persona persona1 = new Persona(name, age, sexo, weight, height);
            Persona persona2 = new Persona(name, age, sexo);
            Persona persona3 = new Persona();

            //Para usar el set de la propiedades, te pide el usuario
            persona3.Name= name;
            persona3.Age = age;
            persona3.Sexo = sexo;
            persona3.Weight = weight;
            persona3.Height = height;

            IndicarPeso(persona1);
            IndicarPeso(persona2);
            IndicarPeso(persona3);

            IndicarEdad(persona1);
            IndicarEdad(persona2);
            IndicarEdad(persona3);

            Console.WriteLine(persona1);
            Console.WriteLine(persona2);
            Console.WriteLine(persona3);
        }

        static void IndicarPeso(Persona persona) //Persona persona equivale a persona1.CalcularIMC(weight, height);
        {
            int imc = persona.CalcularIMC();

            if (imc == Persona.OVERWEIGHT)
            {
                Console.WriteLine("Tienes sobrepeso");
            }
            else if (imc == Persona.TOOTHIN)
            {
                Console.WriteLine("Estás demasiado delgado");
            }
            else
            {
                Console.WriteLine("Peso ideal");
            }
        }

        static void IndicarEdad(Persona persona)
        {
            bool esMayor = persona.EsMayorDeEdad();

            if(esMayor)
                Console.WriteLine("Es mayor de edad");
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }

    }
}