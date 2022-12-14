namespace Resumen_Estatica
{
    /*
        *Clase siempre disponible como una caja de utilidades, no se cierra hasta que se cierre el programa (generar dni, math, quitar acento y ñ, utilidades de string o int...) 
        *Se puede llamar desde cualquier program, clases, al ser publica
        *No se puede heredar ni coger herencia
        *1º que se llama en el programa
        *No se puede crear instancia Persona persona = new Persona;
    */
    class Program
    {
        static void Main()
        {
            int variable = ClaseEstatica.variable;
            ClaseEstatica.MetodoStatic();
        }
    }
}