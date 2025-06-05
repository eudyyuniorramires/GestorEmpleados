using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmpleados
{
    internal class EmpleadoMedioTiempo:Empleado,IAumentoSalario
    {
        public int HorasTrabajadas {  get; set; }

        public decimal TarifasPorHora { get; set; } 


        public EmpleadoMedioTiempo(string nombre, decimal salariobase, int horastrabajadas ,decimal tarifasporhora) : base(nombre, salariobase) 
        {
        

            this.HorasTrabajadas = horastrabajadas;
        
            this.TarifasPorHora = tarifasporhora;
        }

        public override decimal CalcularSalario()
        {

           return HorasTrabajadas * TarifasPorHora;

        }

        public void AumentoSalario(decimal porcentaje) 
        {

            SalarioBase += porcentaje;
        
        }





    }
}
