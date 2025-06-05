using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmpleados
{
    internal class Empresa
    {
       

        List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado empleado) 
        {
           empleados.Add(empleado);    
        }

        public void MostrarEmpleados() 
        {

            foreach (var empleado in empleados)
            {
                empleado.MostrarInfomacion();   
            }
        }

        public void CalcularGastosTotal() 
        {


            Console.WriteLine("");
        
        
        }
    }
}
