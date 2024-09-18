using System;

namespace CalculoSalario.Empleados
{
    public class DocentePorHora : Empleado
    {
        private const decimal TarifaPorHora = 800;
        public int HorasTrabajadas { get; set; }

        public DocentePorHora(string nombre, int horasTrabajadas, bool metaAlcanzada) 
            : base(nombre, metaAlcanzada)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }
}
