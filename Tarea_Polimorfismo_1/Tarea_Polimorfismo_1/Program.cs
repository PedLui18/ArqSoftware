using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Polimorfismo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Cliente1");
            Empleado clienteEmpleado1 = new Empleado("ClienteEmpleado1");
            Cliente cliente2 = new Cliente("Cliente2");
            Empleado clienteEmpleado2 = new Empleado("ClienteEmpleado2");
            Empleado clienteEmpleado3 = new Empleado("ClienteEmpleado3");

            Persona[] personas = { cliente1, cliente2, clienteEmpleado1, clienteEmpleado2, clienteEmpleado3 };

            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.generarCodigo());
                Console.WriteLine(persona.calcularSueldo());
            }

            //IPersona[] clientes = { cliente1, cliente2};
            //IPersona[] cliEmpleados = { clienteEmpleado1, clienteEmpleado2, clienteEmpleado3 }; 

            //foreach (IPersona cliente in clientes)
            //{
            //    Console.WriteLine(cliente.generarCodigo());
            //}

            //foreach (IPersona cliEmpleado in cliEmpleados)
            //{
            //    Console.WriteLine(cliEmpleado.calcularSueldo());
            //}


            Console.ReadKey();
        }
    }
}
