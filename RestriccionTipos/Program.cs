namespace RestriccionTipos
{
    class Program
    {
        enum Color { Rojo, Verde }
        static void Main()
        {
            ListaEmpleados<Directivo> listaEmpleadosD = new ListaEmpleados<Directivo>();
            ListaEmpleados<Empleado> listaEmpleadosE = new ListaEmpleados<Empleado>();

            ListaEmpleados<Directivo> listaEmpleadosX = new ListaEmpleados<Directivo>();

            listaEmpleadosD.AddEmpleado(new Directivo());
            listaEmpleadosE.AddEmpleado(new Empleado());

            listaEmpleadosX.AddEmpleado(new Directivo("","2"));

            string input = Console.ReadLine();

            Color color;  //Variable local
            bool w = Enum.TryParse(input, true, out color);

            Color color2 = Enum.Parse<Color>(input, true);


        }
    }
}