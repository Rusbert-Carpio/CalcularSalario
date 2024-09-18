using System;

namespace CalculoSalario.Empleados
{
    public class EmpleadoAdministrativo : Empleado
    {
        private const decimal SalarioBase = 2500;
        private const decimal Bonificacion = 400;

        public EmpleadoAdministrativo(string nombre, bool metaAlcanzada) 
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
