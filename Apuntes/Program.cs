namespace Apuntes
{
    class Program
    {
        static void Main()
        {
            /*
             * ESTUDIAR DIAPOSITIVAS, EXAME SIMILAR AL EJERCIIO



////////ABSTRACTO/CLASES/INTERFAZ
             * Inicio de clases
                 abstract class ClassAbstracta                                     -> Abstracta/Padre
                 interface Inombre                                                 -> Interfaz/Padre
                 class ClassHererada : ClassAbstracta/ClaseHerenciaPadre/Inombre   -> ClassAbstracta/Hija
             
             * Métodos
                public abstract void nombre(){    -> Abstracta/Padre
                public override void nombre(){    -> Override/Hija
             
                public void nombre() -> Interfaz (No se define)/ClasePadre-ClaseHija(Se desarrolla la herencia y suyo)
             
             * Constructor
                public nombreClase(string nombre) : base(nombre) //base llama al constructor padre cuando HEREDA. 
                                                                  Abstracta no puede porque solo declara el método/propiedades sin inicializa
             

    

////////ESTÁTICAS 
             * public static class ClaseEstatica -> Igual a clase normal pero no puede crear instancia -> Animal animales = new Animal();
                                                        Creado para métodos que se usan en varios sitios
                                                        Se llama la primera antes que cualquier clase y permanece en memoria para ser usada como por ejemplo herramientas
                                                        Ni hereda ni puede ser hererada
             * public static int variableClase = 10; -> Atributo
             * static ClaseEstatica()                -> Constructor (opcional)
             * public static void Metodo()           -> Método
             
             * Program:
               int variable = ClaseEstatica.variableClase;
               variableClase.Metodo();



////////GENÉRICAS
             * Clase
                class ClaseGenerica<T> -> Inicio. T es int/string... lo que definamos luego, para ser usado en varias circunstancias
                private T _variable;             -> Atributo
                public ClaseGenerica(T value)    -> Constructor
                public T Metodo(T parametro)     -> Método

             * Interfaz
                interface Inombre<T>                     -> Inicio de la interfaz 
                bool Metodo(T parametro);                -> Método

                class nombreClase : Inombre<nombreClase> -> Inicio de la clase hija, Hereda interfaz
                public bool Metodo(nombreClase parametro)
                
             * Método
                static class nombreClase
                public static bool Metodo>T, G>(T obj1, G obj2) where G : T
             

             * Program
                Clase
                ClaseGenerica<int> variable = new ClaseGenerica<int>(10);
                variable.Metodo(5);

                Interfaz
                nombreClase variable = new nombreClase() { variable2 = 10 };

                Método
                bool variable = nombreClase.Metodo(parametro, "Texto");
                



////////CASTING
                //AS -> Conversión de un tipo a otro
                object obj = "texto";
             * (Persona)obj;                     -> PROVOCA excepción, controlar try/catch
             * Persona persona = obj as Persona; -> NO PROVOCA excepción, si da error devuelve NULO
             
                //IS -> Comprueba tipos
               Persona persona = new Persona();
             * persona is object    -> True, porque persona ES objeto
             * persona is int       -> False, porque persona NO ES int
             



////////POLIMORFISMO 
             * Clase hererada como un abstracta se sobrescribe los métodos en las hijas y para verlo recorremos un array del padre y dentro las hijas, llamando a una función muestra dicha función con el resultado de cada hija
               Animal[] animales = new Animal[] {new Gato(), new Perro()};
               foreach (Animal animal in animales) animal.Hablar();
               Muestra -> Perro: Guau, Gato: Miau
             



////////SOBREESCRIBIR MÉTODOS DE OBJECTOS 
             * public virtual string ToString()
            */
        }//78
    }
}