
namespace CalculoSalario.Empleados
{
    public class DocenteContratoFijo : Empleado
    {
        private const decimal SalarioBase = 3000;
        private const decimal Bonificacion = 500;

        public DocenteContratoFijo(string nombre, bool metaAlcanzada) 
            : base(nombre, metaAlcanzada) { }

        public override decimal CalcularSalario()
        {
            if (MetaAlcanzada)
            {
                return SalarioBase + Bonificacion;
            }
            else
            {
                return SalarioBase + (Bonificacion / 2);
            }
        }
    }
}
