namespace Resumen_Generica
{
    class ClaseHija : InterfacePadre<ClaseHija> //Definimos T como cualquier tipo que en Program se declara como int u otro
    {
        public double NombrePropiedad { get; set; }

        public bool MetodoHija(ClaseHija variableParametro)
        {
            return NombrePropiedad > variableParametro.NombrePropiedad; //Comparamos si la propiedad es mayor que la enviada por parámetro
        }

        /*public static bool EsIGual<T, G>(T obj1, G obj2) where G:T
        {
            return obj1.Equals(obj2);
        }*/
    }
}
