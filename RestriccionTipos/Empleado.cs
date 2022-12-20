namespace RestriccionTipos
{
    class Empleado : IEmpleado
    {
        public string Nombre { get; set; }
        public string Id { get; set; }

        public Empleado()
        {

        }

        public Empleado(string nombre, string id)
        {
            Nombre = nombre;
            Id = id;
        }
    }
}
