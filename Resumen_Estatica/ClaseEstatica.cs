namespace Resumen_Estatica
{
    public static class ClaseEstatica
    {
        //Variable estática
        public static int variable = 10;

        static ClaseEstatica() //Constructor llamado igual que la clase
        {
            //Opcional
        }

        public static void MetodoStatic()
        {
            Console.WriteLine("Método estático");
        }
    }
}
