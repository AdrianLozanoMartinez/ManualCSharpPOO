namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class -> Para guardar datos.Se copia referencia de donde está la información, si modifica de donde hereda se trabaja con trabajo cambiado.
            //struct -> Para trabajar datos.Se copia el dato directamente, si modifica de donde hereda no modifica el dato que se va a trabajar.

            //Empleado e = new Empleado { Nombre = "a", Id = 9 };

            //Es lo mismo que arriba, pero arriba es struct con datos
            /*Empleado e2 = new Empleado();
            e2.Nombre = "a";
            e2.Id = 9;*/

            StructPoint sp1 = new StructPoint { X = 10, Y = 20 };
            StructPoint sp2 = new StructPoint { X = 10, Y = 20 };

            Console.WriteLine(sp1.Equals(sp2)); //Sale true porque tienen el mismo valor

            StructPoint sp3 = new StructPoint { X = 10, Y = 30 };
            StructPoint sp4 = new StructPoint { X = 10, Y = 20 };

            Console.WriteLine(sp3.Equals(sp4)); //Sale false porque tienen diferente valor

            ClassPoint sp5 = new ClassPoint { X = 10, Y = 20 };
            ClassPoint sp6 = new ClassPoint { X = 10, Y = 20 };

            sp5 = sp6;
            sp5.X = 2;

            Console.WriteLine(sp5.Equals(sp6)); //Sale true porque tienen misma dirección sp5 = sp6 porque pasamos dirección y no dato

            StructPoint sp7 = new StructPoint { X = 10, Y = 20 };
            StructPoint sp8 = new StructPoint { X = 10, Y = 20 };

            sp7 = sp8;
            sp8.X = 2;

            Console.WriteLine(sp7.Equals(sp8)); //Sale false porque tienen diferentes datos sp7 = sp8 
        }
    }
}