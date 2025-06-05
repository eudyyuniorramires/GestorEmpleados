using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmpleados
{
   abstract internal class Empleado : IAumentoSalario
   {

        public string Nombre { get; set; }

        public decimal SalarioBase { get; set; }

       public  Empleado(string nombre,decimal salariobase) 
        {
            this.Nombre = nombre;

            this.SalarioBase = salariobase;
 
        }

         public abstract decimal CalcularSalario();

        public void MostrarInfomacion()
        {


            Console.WriteLine($"Nombre: {Nombre}  Salario Base: {SalarioBase}");

        }


        public void AumentoSalario(decimal porcentaje) 
        {
        
        
        
        
        }
        


    }



}
