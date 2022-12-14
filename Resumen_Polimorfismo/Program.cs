namespace Resumen_Polimorfismo
{
    class Program
    {
        static void Main()
        {
            ClassInterfazPadre[] polimorfismo = new ClassInterfazPadre[] { new ClaseHija1(), new ClaseHija2() };

            foreach (ClassInterfazPadre poli in polimorfismo)
            {
                if (poli is ClaseHija1) //Si lo que manda pertenece a las claseHija1
                {
                    ClaseHija1 claseHija1 = poli as ClaseHija1; //Especificando para evitar errores que poli pertenece a la ClaseHija1
                    claseHija1.Hablar(); //Declaramos solo para mostrar claseHija1
                }
                    poli.Hablar(); //Mostramos claseHija1 y 2
            }
        }
    }
}