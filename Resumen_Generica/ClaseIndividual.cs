namespace GenericaMASResumen
{
    class ClaseIndividual<T> //Definimos T como cualquier tipo que en Program se declara como int u otro
    {
        private T _variable; 

        public ClaseIndividual(T variable)
        {
            _variable = variable;
        }

        public T MetodoGenerico(T variableParametro)
        {
            Console.WriteLine($"variableParametro: {variableParametro}"); //recogemos el parámetro dado en Program

            return variableParametro;
        }

        
    }
}
