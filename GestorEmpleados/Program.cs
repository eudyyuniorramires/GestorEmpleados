using System.Diagnostics;
using System.Globalization;

namespace GestorEmpleados 
{

    class Program 
    {


        static void Main(string[] args)
        {

            Empresa empresa = new Empresa();

            bool salir = false;


            while (!salir) 
            {

                Console.WriteLine("Sistema de gestion de Empleados");
                Console.WriteLine("Agregar empleados de tiempo completo [1]");
                Console.WriteLine("Agregar empleadp de Medio Tiempo [2]");
                Console.WriteLine("Mostrar empleados");


                switch (Console.ReadLine()) 
                {

                    case "1":
                        Console.WriteLine("Ingrese el nombre del empleado");
                        string nombreCompleto = Console.ReadLine();
                        Console.WriteLine("Ingrese el salio base");
                        decimal salarioBase = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el bono");
                        decimal bono = decimal.Parse(Console.ReadLine());
                        empresa.AgregarEmpleado(new EmpleadoTiempoCompleto(nombreCompleto, salarioBase, bono));
                        break;

                     case "2":
                        Console.WriteLine("Ingrese el nombre");
                        nombreCompleto = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad de horas");
                        int horas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese ingrese el pago por hora");
                        decimal pagoPorHora = decimal.Parse(Console.ReadLine());
                        decimal salarioBaseNull = 0;
                        empresa.AgregarEmpleado(new EmpleadoMedioTiempo(nombreCompleto,salarioBaseNull,horas,pagoPorHora));
                        break;


                    case "3":
                        Console.WriteLine("La lista de empleados es:");
                        empresa.MostrarEmpleados();
                        break;

                        case "4":
                        salir = true;
                        break   ;
               
                }    
            
            
            
            }  

        }
    
    
    }
    



}