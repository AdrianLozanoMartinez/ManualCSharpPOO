using System.Globalization;
//Program -> Llama a los datos y acciones
namespace Encapsular_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche("Fiesta", "Ford", 10, 5, 2.5, Coche.TipoMotor.Hibrido);

            Console.WriteLine($"Marca: {coche.Marca}, Modelo: {coche.Modelo}, Años: {coche.Edad}, Puertas {coche.Puertas}, Consumo {coche.Consumo}l");
            Console.WriteLine($"¿Es chatarra? {coche.Eschatarra}");

            //Llama al método
            coche.Arrancar();  //Muestra los consoles de Arrancar, se cambia arriba ...(...Coche.TipoMotor.Híbrido)


            //Llamar al tiempo
            Console.WriteLine("Edad actual: " + coche.Edad); //Se puede ahorrar si metemos console en el método

            coche.PasarTiempo();
            Console.WriteLine("Pasa un año: " + coche.Edad);//Se puede ahorrar si metemos console en el método

            coche.PasarTiempo();
            Console.WriteLine("Pasa otro año: " + coche.Edad); //Se puede ahorrar si metemos console en el método

            Console.WriteLine(Coche.TipoMotor.Diesel);  //Aquí muestra el tipo



            //Pedir al usuario todos los datos del coche
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Introduzca modelo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Introduzca marca");
            string marca = Console.ReadLine();

            Console.WriteLine("Introduzca edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca puertas");
            int puertas = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca consumo");
            double consumo = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca tipo de motor");
            Coche.TipoMotor _tipoMotor = (Coche.TipoMotor)Enum.Parse(typeof(Coche.TipoMotor), Console.ReadLine(), true);

            Coche coche2 = new Coche(modelo, marca, edad, puertas, consumo, _tipoMotor);

            coche2.MostrarDatos();
        }
    }
}