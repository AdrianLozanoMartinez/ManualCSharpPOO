namespace RestriccionTipos
{
    class ListaEmpleados<T> where T : Empleado, IEmpleado, new()
    {                                                    //new -> si se usa no puede ser clase abstracta
                                                         //Se refiere al constructor por defecto
                                                         //Debe llevar constructor por defecto, 
        private T[] empleados;
        private int contador = 0;

        public ListaEmpleados()
        {
            empleados = new T[10]; //Empleado será un array de 10 empleados
        }

        public void AddEmpleado(T empleado)
        {
            empleados[contador] = empleado;
            contador++;
        }
    }
}

//TODAS LAS HERERADAS NECESITAN HEREDAR UN CONSTRUCTOR SI LO TIENE EL PADRE, SINO LO TIENE O ES POR DEFECTO NO HACE FALTA IMPLEMENTARLO EN LA HIJA
