using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmpleados
{
    internal class EmpleadoTiempoCompleto : Empleado,IAumentoSalario
    {
        public decimal Bono {  get; set; }

        public EmpleadoTiempoCompleto(string nombre, decimal salariobase, decimal bono) : base (nombre,salariobase)
        {
        
            this.Bono = bono;
        
        }

        

        public override decimal CalcularSalario()
        {
           return SalarioBase + Bono;
            
        }

        public void AumentoSalario(double porcentaje) 
        {


            SalarioBase =+ SalarioBase * (decimal)(porcentaje/100);
            Console.WriteLine($"Nuevo salario base de {Nombre} ahora es de {SalarioBase}");
        

        }

     





    }
}
