/* Public se llama de donde sea, incluso otro proyecto, se puede desde program incluso main
 * Protected -> Solo puede ser llamada de otra clase derivada o la propia,, pero desde program no se puede, ni main
 * Private -> solo la clase puede llamar, no derivadam ni program ni main
 * 
 * Public -> TODOS
 * Protected -> Clase propia y clases heredadas
 * Private -> Clase propia
 */
namespace ManualCSharpPOO
{
    class Persona
    {
 //////////////////////////////////////////////////////////////////USO DE GET / SET///////////////////////////////////////////////////
        //Opción corta
        //Propiedad
        public string Nombre1 { get; set; } //get y set están predefinidas y lo hace el pc automáticamente
        public string Nombre2 { get; }      //Puede estar sin set
                                            //public string Nombre3 { set; }    //No puede estar sin get


        //Opción larga
        //Atributo
        private string nombre3; //Necesario para poder usarlo dentro de get/set

        //Propiedad
        public string Nombre3
        {
            //Se puede quitar get o set porque al ser manual el nombre lo ponemos nosotros
            get
            {
                return nombre3;
            }
            set
            {
                nombre3 = value;
            }
        }
 //////////////////////////////////////////////////////////////////PUBLIC / PRIVATE///////////////////////////////////////////////////
 
        /*Atributos
          - public -> Puede cambiar fuera de la clase - NO recomendable
          - private -> No puede cambiar fuera al menos que USE MÉTODOS y PROPIEDADES - RECOMENDABLE*/

        public string Nombre4 { private get; set; }
        //Privado
        //Público
        public string Nombre5 { get; private set; }
        //Público    //Privado


        //Ambas en públicas
        public string Nombre7 { get; set; }

        //Ambas en privado
        //public string Nombre7 { private get; private set; } //NUNCA
        private string Nombre8 { get; set; } //SI

        //Si queremos poner SET y GET en PRIVADO lo ponemos en el atributo en lugar de la propiedad
        /*private string nombre9;

        public string get
        {  
            return nombre9;
        }
        public set 
        {
            nombre9 = value;
        }*/

        //FUERA se pone LA MENOS RESTRICTIVA -> LA QUE MENOS restrictiva es PUBLIC Y LA QUE MÁS PRIVATE entre medio protected

//////////////////////////////////////////////////////////////////GENERAL/////////////////////////////////////////////////////////////

        //return se puede sustituir con => cuando hay una sola línea

        //value.substring(0,10); -> a partir de la posicion 0 incluido, te coge 10 posiciones del 0 al 9
    }
}
