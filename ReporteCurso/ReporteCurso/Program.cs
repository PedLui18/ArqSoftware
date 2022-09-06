using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporteCurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reporte = new ReporteCurso();

            reporte.AgregarEntrada(new ReporteCursoEntrada { nombre = "patrones de disenio", });
            reporte.AgregarEntrada(new ReporteCursoEntrada { nombre = "patrones de disenio", });
            Console.WriteLine(reporte.ToString);
            reporte.GuardarArchivo(@"Reportes");
            Console.ReadKey();
        }


    }
}
