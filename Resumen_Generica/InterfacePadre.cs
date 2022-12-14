namespace Resumen_Generica
{
    interface InterfacePadre<T> //Definimos T como cualquier tipo que en Program se declara como int u otro
    {
        bool MetodoHija(T variableParametro);
    }
}
