using CalculoSalario.Empleados;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de los empleados
            DocentePorHora docente1 = new DocentePorHora("Juan", 40, true);
            DocenteContratoFijo docente2 = new DocenteContratoFijo("Ana", false);
            EmpleadoAdministrativo administrativo1 = new EmpleadoAdministrativo("Pedro", true);

            // Calcular y mostrar los salarios
            Console.WriteLine($"Salario Docente Por Hora (Rusbert): {docente1.CalcularSalario()}");
            Console.WriteLine($"Salario Docente Contrato Fijo (Richard): {docente2.CalcularSalario()}");
            Console.WriteLine($"Salario Administrativo (Emilio): {administrativo1.CalcularSalario()}");
        }
    }
}
