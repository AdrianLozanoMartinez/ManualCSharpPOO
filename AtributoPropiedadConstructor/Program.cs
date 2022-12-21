namespace AtributoPropiedadConstructor
{
    class Program
    {
        static void Main()
        {
            //INSTANCIAS
            Persona persona = new Persona(); //Constructor predeterminado, sino mandamos datos, nos coge lo que haya en el constructor por DEFECTO

                Console.WriteLine(persona.Name);    //Tu nombre
                Console.WriteLine(persona.Dni);     //-
                Console.WriteLine(persona.Age);     //0
                Console.WriteLine(persona.IsAdult); //False

                Console.WriteLine();                //Salto de línea para dejar espacio



            Persona persona2 = new Persona("1212121p", "Manolo", 42, Persona.Sexos2.Hombre); //Constructor con más parámetro -> public Persona(string dni, string name, int age, Sexos2 sexo) 

            Console.WriteLine(persona2.Name);       //Manolo
                Console.WriteLine(persona2.Dni);        //1212121p
                Console.WriteLine(persona2.Age);        //42
                Console.WriteLine(persona2.IsAdult);    //True
                Console.WriteLine(persona2.Sexo22);     //Hombre

                Console.WriteLine();

            persona2.Name = "Manuela";
            //persona2.Sexo = Persona.Sexos2.Mujer;
            persona2.Age = 42;
            persona2.Sexo22 = Persona.Sexos2.Mujer;

                Console.WriteLine(persona2.Name);       //Manolo
                Console.WriteLine(persona2.Dni);        //1212121p
                Console.WriteLine(persona2.Age);        //42
                Console.WriteLine(persona2.IsAdult);    //True
                Console.WriteLine(persona2.Sexo22);     //Mujer

                Console.WriteLine();


            Persona persona3 = new Persona("Diego", 37, Persona.Sexos2.Hombre); //Constructor con menos parámetro pero no por defecto, al no poner el DNI, coge por defecto en :this"-"

            Console.WriteLine(persona3.Name);           //Diego
            Console.WriteLine(persona3.Dni);            //Coge el por defecto en :this"-"
            Console.WriteLine(persona3.Age);            //18
            Console.WriteLine(persona3.IsAdult);        //True

        }
    }
}