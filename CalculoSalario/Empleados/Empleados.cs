namespace CalculoSalario.Empleados
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public bool MetaAlcanzada { get; set; }

        public Empleado(string nombre, bool metaAlcanzada)
        {
            Nombre = nombre;
            MetaAlcanzada = metaAlcanzada;
        }

        // Método abstracto que será implementado en las clases derivadas
        public abstract decimal CalcularSalario();
    }
}
